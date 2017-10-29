using System;
using System.Diagnostics;
using System.IO;

namespace OverwatchHighlights
{
	class ReplayParamsBlock
	{
		public uint startFrame;
		public uint endFrame;
		public long probablyExpectedDurationMs; // always 12000
		public long startMs;
		public long endMs;
		public HeroWithUnlockables[] heroesWithUnlockables;

		public ReplayParamsBlock(BinaryReader br)
		{
			this.startFrame = br.ReadUInt32();
			this.endFrame = br.ReadUInt32();

			this.probablyExpectedDurationMs = br.ReadInt64();
			Debug.Assert(this.probablyExpectedDurationMs == 12000);

			this.startMs = br.ReadInt64();
			this.endMs = br.ReadInt64();

			// Matches are unlikely to last longer than an hour so this should be a reasonable assert
			Debug.Assert(this.startFrame <= 3600 * 60);
			Debug.Assert(this.endFrame <= 3600 * 60);
			Debug.Assert(this.startMs <= 3600 * 1000);
			Debug.Assert(this.endMs <= 3600 * 1000);

			int numHeroes = br.ReadInt32();
			//Debug.Assert(numHeroes <= 1); // this assert fails on endless junkenstein events

			this.heroesWithUnlockables = new HeroWithUnlockables[numHeroes];
			for (int i = 0; i < numHeroes; ++i)
			{
				this.heroesWithUnlockables[i] = new HeroWithUnlockables(br);
			}
		}

		public void Print()
		{
			Console.WriteLine("{");
			Console.WriteLine($"  Start Frame(?): {startFrame}");
			Console.WriteLine($"  End Frame(?): {endFrame}");
			Console.WriteLine($"  Expected duration ms: {probablyExpectedDurationMs}");
			Console.WriteLine($"  Start ms: {startMs}");
			Console.WriteLine($"  End ms: {endMs}");
			Console.WriteLine($"  Actual duration ms: {endMs - startMs}");
			if (heroesWithUnlockables.Length > 0)
			{
				Console.WriteLine($"  Heroes:");
				foreach (var hero in heroesWithUnlockables)
				{
					hero.Print();
				}
			}
			Console.WriteLine("}");
		}
	}
}
