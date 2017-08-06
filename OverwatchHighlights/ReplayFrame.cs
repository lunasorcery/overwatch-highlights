using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace OverwatchHighlights
{
	class ReplayFrame
	{
		private Dictionary<Map, int> ms_expectedUintsBefore1dea = new Dictionary<Map, int>()
		{
			{ Map.BlackForest,         3 },
			{ Map.Castillo,            6 },
			{ Map.Dorado,             22 },
			{ Map.EcopointAntarctica,  4 },
			{ Map.Eichenwalde,        10 },
			{ Map.Hanamura,            8 },
			{ Map.Hollywood,          16 },
			{ Map.HorizonLunarColony, 10 },
			{ Map.Ilios,              18 },
			{ Map.IliosRuins,          7 },
			{ Map.KingsRow,            3 },
			{ Map.LijiangNightMarket,  9 },
			{ Map.LijiangTower,       21 },
			{ Map.Necropolis,          3 },
			{ Map.Nepal,              13 },
			{ Map.Numbani,            16 },
			{ Map.Oasis,              22 },
			{ Map.OasisCityCenter,    13 },
			{ Map.OasisGardens,        3 },
			{ Map.OasisUniversity,     7 },
			{ Map.Route66,             8 },
			{ Map.TempleOfAnubis,     10 },
			{ Map.VolskayaIndustries, 14 },
			{ Map.WatchpointGibraltar, 6 },
		};

		public int ticker1;
		public int ticker2;
		public int eventCount;
		public float duration;
		public byte[] payload;

		public ReplayFrame(BinaryReader br, Map map)
		{
			this.ticker1 = br.ReadInt32();
			this.ticker2 = br.ReadInt32();
			int frameDataLength = br.ReadInt32();
			this.eventCount = br.ReadInt32();
			this.duration = br.ReadSingle();
			this.payload = br.ReadBytes(frameDataLength);
			
			// seems like the first byte of the payload will always be 03, 51, _5, or _D?
			Debug.Assert(
				payload[0] == 0x03 ||
				payload[0] == 0x51 ||
				payload[0] == 0x05 || payload[0] == 0x0d ||
				payload[0] == 0x15 || payload[0] == 0x1d ||
				payload[0] == 0x25 || payload[0] == 0x2d ||
				payload[0] == 0x35 || payload[0] == 0x3d ||
				payload[0] == 0x45 || payload[0] == 0x4d ||
				payload[0] == 0x55 || payload[0] == 0x5d ||
				payload[0] == 0x65 || payload[0] == 0x6d ||
				payload[0] == 0x75 || payload[0] == 0x7d ||
				payload[0] == 0x85 || payload[0] == 0x8d ||
				payload[0] == 0x95 ||
				payload[0] == 0xa5 || payload[0] == 0xad ||
				payload[0] == 0xb5 || payload[0] == 0xbd ||
				payload[0] == 0xc5 || payload[0] == 0xcd ||
				payload[0] == 0xd5 || payload[0] == 0xdd ||
				payload[0] == 0xe5 || payload[0] == 0xed ||
				payload[0] == 0xf5 || payload[0] == 0xfd
			);

			// seems like if the first byte is 51, the first four bytes will be 51 EF 00 00 ?
			if (payload[0] == 0x51)
			{
				Debug.Assert(payload[1] == 0xef);
				Debug.Assert(payload[2] == 0x00);
				Debug.Assert(payload[3] == 0x00);
			}
			
			processFrameData(payload, map, eventCount);
		}

		void processFrameData(byte[] frameData, Map map, int numEvents)
		{
			// this is all very messy and WIP, please don't judge me for this mess

			using (BinaryReader br = frameData.CreateBinaryReader())
			{
				while (br.BaseStream.Position < br.BaseStream.Length)
				{
					if (br.PeekByte() == 0x03)
					{
						br.ReadByte();
						processFrameData03(br, map);
					}
					else if (br.PeekUInt32() == 0x0000ef51)
					{
						br.ReadUInt32();
						processFrameData51EF0000(br);
						return;
					}
					else if (br.PeekUInt32() == 0x00001dea)
					{
						br.ReadUInt32();
						processFrameDataEA1D0000(br);
						return;
					}
					else
					{
						return;
					}
					--numEvents;
				}
			}
		}

		private void processFrameData03(BinaryReader br, Map map)
		{
			if (this.ms_expectedUintsBefore1dea.ContainsKey(map))
			{
				byte[] data = br.ReadBytes(this.ms_expectedUintsBefore1dea[map] * 4);
			}
			else
			{
				int count = 0;
				while (true)
				{
					uint a = br.ReadUInt32();
					if (a == 0x00001dea)
					{
						break;
					}
					++count;
				}
				Console.WriteLine($"map {map} seems to expect {count} uints before the EA1D0000 block");
				throw new NotImplementedException();
			}
		}

		private void processFrameData51EF0000(BinaryReader br)
		{

		}

		private void processFrameDataEA1D0000(BinaryReader br)
		{

		}

		public void Print()
		{
			Console.WriteLine("ReplayFrame {");
			Console.WriteLine($"  ticker1: {ticker1}");
			Console.WriteLine($"  ticker2: {ticker2}");
			Console.WriteLine($"  eventCount: {eventCount}");
			Console.WriteLine($"  duration: {duration} seconds");
			Console.WriteLine("}");
		}
	}
}
