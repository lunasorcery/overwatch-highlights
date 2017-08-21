using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace OverwatchHighlights
{
	class ReplayFrame
	{
		// by "breakables" this refers to the breakable railings on the maps (and the icicles in Ecopoint)
		// likely also breakable vases, screens etc. - i'm not certain of these yet.
		private Dictionary<Map, int> ms_numberOfBreakables = new Dictionary<Map, int>()
		{
			{ Map.BlackForest,          96 },
			{ Map.Castillo,            168 },
			{ Map.ChateauGuillard,     272 },
			{ Map.Dorado,              688 },
			{ Map.EcopointAntarctica,  104 },
			{ Map.Eichenwalde,         296 },
			{ Map.EstadiodasRas,         0 },
			{ Map.Hanamura,            256 },
			{ Map.Hollywood,           496 },
			{ Map.HorizonLunarColony,  304 },
			{ Map.Ilios,               560 },
			{ Map.IliosLighthouse,     200 },
			{ Map.IliosRuins,          224 },
			{ Map.IliosWell,           136 },
			{ Map.KingsRow,             72 },
			{ Map.LijiangNightMarket,  272 },
			{ Map.LijiangTower,        672 },
			{ Map.Necropolis,           72 },
			{ Map.Nepal,               408 },
			{ Map.Numbani,             504 },
			{ Map.Oasis,               688 },
			{ Map.OasisCityCenter,     392 },
			{ Map.OasisGardens,         96 },
			{ Map.OasisUniversity,     200 },
			{ Map.Route66,             240 },
			{ Map.SydneyHarbourArena,    0 },
			{ Map.TempleOfAnubis,      304 },
			{ Map.VolskayaIndustries,  424 },
			{ Map.WatchpointGibraltar, 168 },
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
				payload[0] == 0xab ||
				(payload[0] & 0x07) == 0x05
			);

			processFrameData(payload, map, eventCount);
		}

		void processFrameData(byte[] frameData, Map map, int numEvents)
		{
			BitReader br = new BitReader(frameData);

			var firstTwoBits = br.Read(2);
			switch (firstTwoBits)
			{
				default:
				{
					Debug.Assert(false, $"Frame payload had unexpected first two bits {firstTwoBits >> 1}{firstTwoBits & 1}");
					return;
				}
				case 1:
				{
					while (true)
					{
						bool bit = br.Read1();
						if (!bit)
							break;
						ushort value = br.Read16();
					}
					uint next = br.Read32();
					Debug.Assert(next == 0x00001dea);
					break;
				}
				case 3:
				{
					Debug.Assert(ms_numberOfBreakables.ContainsKey(map));
					if (ms_numberOfBreakables[map] > 0)
					{
						br.ByteAlign();
						int numUints = (ms_numberOfBreakables[map] + 31) / 32; // round up to a multiple of 32
						uint[] breakablesBitfield = new uint[numUints];
						for (int i = 0; i < numUints; ++i)
						{
							breakablesBitfield[i] = br.Read32();
						}
					}
					else
					{
						// if we don't have any breakables (lucioball maps), then....
						// literally just continue on to the next bit immediately, don't even byte-align
					}
					uint next = br.Read32();
					Debug.Assert(next == 0x00001dea);
					break;
				}
			}
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
