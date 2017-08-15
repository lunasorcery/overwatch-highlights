using System.IO;
using System.Linq;

namespace OverwatchHighlights
{
	struct BuildNumber
	{
		private static int[] ms_knownBuilds = new int[] {
			37664, // 23/06/2017 PTR
			37703, // 24/06/2017 PTR
			37755, // 27/06/2017 PTR
			37793, // 28/06/2017 PTR
			37962, // 06/07/2017 PTR (first appearance of doomfist)
			38024, // 07/07/2017 PTR
			38044, // 08/07/2017 PTR
			38125, // 12/07/2017 PTR (doomfist unlocks)
			38215, // 15/07/2017 PTR
			38459, // 28/07/2017 Live?
			38510, // 28/07/2017 Live?
			38679, // 01/08/2017 Live replay only?
			38765, // 02/08/2017 Live replay only?
			38882, // 08/08/2017 Live Summer Games
			39023, // 10/08/2017 Live Summer Games
			39060, // 11/08/2017 PTR Deathmatch
			39083, // 14/08/2017 PTR Deathmatch
			39103, // 15/08/2017 PTR Deathmatch
		};

		private int m_buildNumber;

		public BuildNumber(BinaryReader br)
		{
			m_buildNumber = br.ReadInt32();
		}

		public static implicit operator int(BuildNumber build)
		{
			return build.m_buildNumber;
		}

		public bool IsKnownByTool()
		{
			return ms_knownBuilds.Contains(m_buildNumber);
		}

		public bool IsLatestKnownBuild()
		{
			return m_buildNumber == ms_knownBuilds.Max();
		}

		public static bool operator ==(BuildNumber a, BuildNumber b)
		{
			return a.m_buildNumber == b.m_buildNumber;
		}

		public static bool operator !=(BuildNumber a, BuildNumber b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			return (obj is BuildNumber) ? this == (BuildNumber)obj : false;
		}

		public override int GetHashCode()
		{
			return m_buildNumber.GetHashCode();
		}

		public override string ToString()
		{
			return m_buildNumber.ToString();
		}
	}
}
