using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace OverwatchHighlights
{
	class Replay
	{
		private const uint MAGIC_CONSTANT = 0x03707270; // { 'p', 'r', 'p', 0x03 }

		public BuildNumber buildNumber;
		public Map map;
		public GameMode gameMode;
		public Checksum checksum;
		public ReplayParamsBlock paramsBlock;
		public HighlightInfo highlightInfo;
		public List<ReplayFrame> replayFrames;

		public Replay(BinaryReader br)
		{
			uint magic = br.ReadUInt32();
			Debug.Assert(magic == MAGIC_CONSTANT);

			this.buildNumber = new BuildNumber(br);
			Debug.Assert(this.buildNumber.IsKnownByTool());

			this.map = br.ReadMap64();

			this.gameMode = br.ReadGameMode64();

			byte unknown1 = br.ReadByte();
			Debug.Assert(unknown1 == 0xB || unknown1 == 0xF);

			uint unknown2 = br.ReadUInt32();
			Debug.Assert(unknown2 == 0x10);

			uint unknown3 = br.ReadUInt32();
			Debug.Assert(unknown3 == 0x30);

			this.checksum = new Checksum(br);
			Debug.Assert(MapChecksumDB.IsValidChecksumForMap(map, checksum));

			int paramsBlockLength = br.ReadInt32();
			using (DebugBlockLength dbl = new DebugBlockLength(paramsBlockLength, br))
			{
				this.paramsBlock = new ReplayParamsBlock(br);
			}

			if ((unknown1 & 0x4) != 0)
			{
				int playersBlockLength = br.ReadInt32();
				using (DebugBlockLength dbl = new DebugBlockLength(playersBlockLength, br))
				{
					this.highlightInfo = new HighlightInfo(br, buildNumber, map);
				}
			}

			byte[] compressedBuffer = br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position));
			byte[] decompressedBuffer = Decompress(compressedBuffer);

#if DEBUG_OUTPUT_DECOMPRESSED_REPLAYDATA
			string filename = br.GetFilename();
			File.WriteAllBytes("decompressed/" + filename + ".bin", decompressedBuffer);
#endif

			using (BinaryReader br2 = decompressedBuffer.CreateBinaryReader())
			{
				this.replayFrames = new List<ReplayFrame>();
				for (int frameIndex = 0; br2.BaseStream.Position < br2.BaseStream.Length; ++frameIndex)
				{
					this.replayFrames.Add(new ReplayFrame(br2, map, frameIndex));
				}
			}

			int diffMs = (int)(this.paramsBlock.endMs - this.paramsBlock.startMs);
			int durationNoFrame0 = (int)Math.Round(this.TotalDurationWithoutFirstFrame() * 1000);
			Debug.Assert(Math.Abs(durationNoFrame0 - diffMs) <= 1);

			Debug.Assert(this.paramsBlock.startFrame == this.replayFrames[0].ticker1 - 2);
			Debug.Assert(this.paramsBlock.endFrame == this.replayFrames[this.replayFrames.Count - 1].ticker1 - 2);
			for (int i = 1; i < this.replayFrames.Count; ++i)
			{
				var lastFrame = this.replayFrames[i-1];
				var thisFrame = this.replayFrames[i];
				Debug.Assert(thisFrame.ticker1 - lastFrame.ticker1 == 1);
				Debug.Assert(
					thisFrame.ticker2 - lastFrame.ticker2 <= 2 && 
					thisFrame.ticker2 - lastFrame.ticker2 >= 0);
			}
		}

		public void Print()
		{
			Console.WriteLine();
			Console.WriteLine("-- Replay Header --");
			Console.WriteLine($"Build: {buildNumber}");
			Console.WriteLine($"Map: {map}");
			if (this.highlightInfo != null)
			{
				Console.Write("HighlightInfo: ");
				this.highlightInfo.Print();
			}

			Console.WriteLine();
			Console.WriteLine("-- Replay Data --");
			Console.WriteLine($"{replayFrames.Count} frames with {replayFrames.Sum(a => a.eventCount)} events, totalling {replayFrames.Sum(a => a.duration)} seconds, with {replayFrames.Sum(a => a.payload.Length)} bytes of payloads");
			Console.WriteLine($"totalDurationWithoutFirstFrame {TotalDurationWithoutFirstFrame()}");
			Console.WriteLine($"first few frames: ");
			for (int i = 0; i < 5; ++i)
				replayFrames[i].Print();
		}

		private static byte[] Decompress(byte[] compressedBuffer)
		{
			uint compressedMagic = BitConverter.ToUInt32(compressedBuffer, 0);
			Debug.Assert(compressedMagic == 0xFD2FB528);

			byte[] decompressedBuffer = new byte[1024 * 1024]; // 1MB should be enough for anyone!
			int length = 0;
			using (ZstdNet.Decompressor dec = new ZstdNet.Decompressor())
			{
				length = dec.Unwrap(compressedBuffer, decompressedBuffer, 0);
			}
			byte[] shrunkBuffer = new byte[length];
			Array.Copy(decompressedBuffer, 0, shrunkBuffer, 0, length);
			return shrunkBuffer;
		}

		public float TotalDurationWithoutFirstFrame()
		{
			return replayFrames.Sum(a => a.duration) - replayFrames[0].duration;
		}

		public float TotalDurationWithoutLastFrame()
		{
			return replayFrames.Sum(a => a.duration) - replayFrames[replayFrames.Count - 1].duration;
		}
	}
}
