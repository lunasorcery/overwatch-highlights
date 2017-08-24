﻿using System;
using System.Diagnostics;
using System.IO;

namespace OverwatchHighlights
{
	class Highlight
	{
		private const uint MAGIC_CONSTANT = 0x036C6870; // { 'p', 'h', 'l', 0x03 }

		[Flags]
		public enum UIFlags : uint
		{
			Top5Highlight   = 0x1, // Displayed in the "Top 5" section
			ManualHighlight = 0x2, // Displayed in the "36 manual highlights" section
			IsNotNew        = 0x4, // if false, game will display "New" label
			HasBeenExported = 0x8, // if true, game will display "Recorded" label
		}

		public struct FillerStruct
		{
			public uint unknown62;
			public uint unknown63;
			public uint unknown64;
			public byte unknown65;

			public FillerStruct(BinaryReader br)
			{
				this.unknown62 = br.ReadUInt32();
				this.unknown63 = br.ReadUInt32();
				this.unknown64 = br.ReadUInt32();
				this.unknown65 = br.ReadByte();

				Debug.Assert(this.unknown62 == 0);
				Debug.Assert(this.unknown63 == 0);
				Debug.Assert(this.unknown64 == 0);
				Debug.Assert(this.unknown65 == 0);
			}
		}

		public Checksum checksum;
		public uint unknown9;
		public BuildNumber buildNumber;
		public uint playerId;
		public UIFlags uiFlags;
		public Map map;
		public GameMode gameMode;
		public HighlightInfo[] highlightInfos;
		public HeroWithUnlockables[] heroesWithUnlockables;
		public uint unknown60;
		public uint unknown61;
		public FillerStruct[] fillerStructs;
		public Replay replayBlock;

		public static Highlight FromFile(string path)
		{
			using (BinaryReader br = new BinaryReader(File.OpenRead(path)))
			{
				return new Highlight(br);
			}
		}

		public Highlight(BinaryReader br)
		{
			var filename = br.GetFilename();

			uint magic = br.ReadUInt32();
			Debug.Assert(magic == MAGIC_CONSTANT);

			this.checksum = new Checksum(br);

			int dataLength = br.ReadInt32();
			Debug.Assert(br.BaseStream.Position + dataLength == br.BaseStream.Length);

			if (Checksum.CanCompute)
			{
				long pos = br.BaseStream.Position;
				byte[] checksumInput = br.ReadBytes(dataLength);
				br.BaseStream.Position = pos;
				Checksum computedChecksum = Checksum.Compute(checksumInput);
				Debug.Assert(this.checksum == computedChecksum);
			}

			using (DebugBlockLength dbl = new DebugBlockLength(dataLength, br))
			{
				uint unknown1 = br.ReadUInt32();    // 0?
				Debug.Assert(unknown1 == 0);

				uint unknown2 = br.ReadUInt32();    // 0?
				Debug.Assert(unknown2 == 0);

				uint unknown3 = br.ReadUInt32();    // 0?
				Debug.Assert(unknown3 == 0);

				uint unknown4 = br.ReadUInt32();    // 0?
				Debug.Assert(unknown4 == 0);

				uint unknown5 = br.ReadUInt32();    // 0?
				Debug.Assert(unknown5 == 0);

				uint unknown6 = br.ReadUInt32();    // 0?
				Debug.Assert(unknown6 == 0);

				uint unknown7 = br.ReadUInt32();    // 0?
				Debug.Assert(unknown7 == 0);

				uint unknown8 = br.ReadUInt32();    // 0?
				Debug.Assert(unknown8 == 0);

				this.unknown9 = br.ReadUInt32();    // major version number?
				Debug.Assert(unknown9 == 138 || unknown9 == 147 || unknown9 == 146);
				// 138 = 1.13 ptr
				// 147 = 1.13 live
				// 146 = 1.14 ptr

				this.buildNumber = new BuildNumber(br);
				Debug.Assert(buildNumber.IsKnownByTool(), $"Unknown build number {buildNumber}");

				this.playerId = br.ReadUInt32();    // player id of the logged in user

				uint unknown12 = br.ReadUInt32();   // 0?
				Debug.Assert(unknown12 == 0);

				this.uiFlags = (UIFlags)br.ReadUInt32();
				Debug.Assert(((uint)uiFlags & 0xFFFFFFF0u) == 0); // assume only the bottom four bits will be set...
				Debug.Assert(uiFlags.HasFlag(UIFlags.ManualHighlight) != uiFlags.HasFlag(UIFlags.Top5Highlight)); // exactly one of these will be set

				this.map = br.ReadMap64();

				this.gameMode = br.ReadGameMode64();

				// 2 entries will be a POTG, 1 entry will be either a highlight or a POTG against bots, I think...
				int numHighlightInfos = br.ReadInt32();
				Debug.Assert(numHighlightInfos == 1 || numHighlightInfos == 2);

				this.highlightInfos = new HighlightInfo[numHighlightInfos];
				for (int i = 0; i < numHighlightInfos; ++i)
				{
					highlightInfos[i] = new HighlightInfo(br);
				}
				Debug.Assert(br.GetFilename().StartsWith(highlightInfos[0].uuid.ToString()));

				int numHeroes = br.ReadInt32();

				this.heroesWithUnlockables = new HeroWithUnlockables[numHeroes];
				for (int i = 0; i < numHeroes; ++i)
				{
					heroesWithUnlockables[i] = new HeroWithUnlockables(br);
				}

				// I have absolutely no idea what this section is for but it seems to be entirely predictable *shrug*
				{
					this.unknown60 = br.ReadUInt32();
					Debug.Assert(unknown60 == 0);

					this.unknown61 = br.ReadUInt32();
					Debug.Assert(unknown61 == 0);

					byte fillerCount = br.ReadByte();
					Debug.Assert(fillerCount <= 1);

					this.fillerStructs = new FillerStruct[fillerCount];
					for (int i = 0; i < fillerCount; ++i)
					{
						this.fillerStructs[i] = new FillerStruct(br);
					}
				}

				int replayDataLength = br.ReadInt32();
				Debug.Assert(br.BaseStream.Position + replayDataLength == br.BaseStream.Length);

				replayBlock = new Replay(br);
			}

			Debug.Assert(
				replayBlock.buildNumber == this.buildNumber ||
				(this.buildNumber == 38044 && replayBlock.buildNumber == 38024) ||
				(this.buildNumber == 38459 && replayBlock.buildNumber == 38510) ||
				(this.buildNumber == 38459 && replayBlock.buildNumber == 38679) ||
				(this.buildNumber == 38765 && replayBlock.buildNumber == 38679) ||
				(this.buildNumber == 38459 && replayBlock.buildNumber == 38765) ||
				(this.buildNumber == 39023 && replayBlock.buildNumber == 38882) ||
				(this.buildNumber == 39023 && replayBlock.buildNumber == 39221) ||
				(this.buildNumber == 39358 && replayBlock.buildNumber == 39221)
			// I've no idea what's up with all these weird permutations...
			);
			Debug.Assert(replayBlock.map == this.map);
			Debug.Assert(replayBlock.gameMode == this.gameMode);
			if (replayBlock.highlightInfo != null)
			{
				Debug.Assert(replayBlock.highlightInfo == highlightInfos[0]);
			}

			if (this.highlightInfos[0].unknown1 == 4)
			{
				Debug.Assert(this.highlightInfos[0].unknown4 == 0);
			}
			else
			{
				Debug.Assert(this.highlightInfos[0].unknown4 != 0);
			}
			Debug.Assert(this.highlightInfos[0].unknown5 > this.replayBlock.paramsBlock.startMs / 1000.0f);
			Debug.Assert(this.highlightInfos[0].unknown5 < this.replayBlock.paramsBlock.endMs / 1000.0f);

			if (this.highlightInfos[0].unknown1 != 1)
			{
				if (uiFlags.HasFlag(UIFlags.ManualHighlight))
					Debug.Assert(this.highlightInfos[0].unknown1 == 4);
				else
					Debug.Assert(this.highlightInfos[0].unknown1 == 0);
			}


			if (this.highlightInfos[0].unknown1 == 1 || this.highlightInfos[0].unknown1 == 0) // potg or top5
			{
				Debug.Assert(
					this.highlightInfos[0].category == HighlightCategory.HighScore ||
					this.highlightInfos[0].category == HighlightCategory.Lifesaver ||
					this.highlightInfos[0].category == HighlightCategory.Sharpshooter ||
					this.highlightInfos[0].category == HighlightCategory.Shutdown
				);
			}
			else
			{
				Debug.Assert(this.highlightInfos[0].category == HighlightCategory.None);
			}
		}

		public void Print()
		{
			Console.WriteLine();
			Console.WriteLine("-- Highlight Header --");

			Console.WriteLine($"unknown9: {unknown9}");
			Console.WriteLine($"Build: {buildNumber}");
			Console.WriteLine($"Player Id: {playerId}");
			Console.WriteLine($"Flags: {uiFlags}");
			Console.WriteLine($"Map: {map}");
			Console.WriteLine($"Game Mode: {gameMode}");

			Console.WriteLine("Highlight Infos: [");
			for (int i = 0; i < highlightInfos.Length; ++i)
			{
				Console.Write($"[{i}]: ");
				highlightInfos[i].Print();
			}
			Console.WriteLine("]");

			Console.WriteLine($"{heroesWithUnlockables.Length} heroes:");
			for (int i = 0; i < heroesWithUnlockables.Length; ++i)
			{
				Console.Write($"[{i}]: ");
				heroesWithUnlockables[i].Print();
			}

			this.replayBlock.Print();
		}
	}
}
