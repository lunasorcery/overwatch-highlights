﻿using System.IO;
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
			39221, // 15/08/2017 Live replay only?
			39241, // 19/08/2017 PTR Deathmatch
			39358, // 24/08/2017 Live minor patch
			39398, // 25/08/2017 PTR 1.15 Mercy & D.Va changes
			39425, // 29/08/2017 Live 1.14 Deathmatch
			39484, // 30/08/2017 Live 1.14 Deathmatch
			39572, // 02/09/2017 Live replay only?
			39612, // 07/09/2017 PTR 1.15 Junkertown
			39775, // 13/09/2017 Live replay only?
			39823, // 20/09/2017 Live replay only?
			39935, // 20/09/2017 Live 1.15 Junkertown
			39974, // 23/09/2017 Live replay only?
			40011, // 23/09/2017 PTR 1.16
			40048, // 23/09/2017 Live 1.15 Junkertown
			40133, // 01/10/2017 Live 1.15 Junkertown
			40407, // 15/10/2017 Live 1.16 Halloween
			40763, // 29/10/2017 Live 1.16 Halloween
			40990, // 03/10/2017 Live 1.16
			41031, // 03/11/2017 PTR 1.17.0.0
			41119, // 03/11/2017 PTR 1.17.0.1 Moira
			41350, // 17/11/2017 Live 1.17.0.2 Moira
			41594, // 17/11/2017 PTR 1.18.1.0 Blizzard World
			41714, // 17/11/2017 Live 1.17.0.2 Moira
			41713, // 08/12/2017 Live 1.17.0.3 Moira
			41835, // 08/12/2017 Live 1.17.0.3 Moira, replay only?
			42210, // 15/12/2017 Live 1.18.1.2 Winter
			42563, // 22/01?/2018 Live 1.19.1.3
			42665, // 22/01?/2018 Live 1.19.1.3
			45752, // 22/04/2018 Live 1.22.0.1
			45876, // 22/04/2018 Live 1.22.0.1
			// -- hiatus lol --
			51830, // 14/10/2018 Live 1.29.0.1, replay only?
			51948, // 14/10/2018 Live 1.29.0.1
			58155, // 26/05/2019 Live 1.36.0.1
			58509, // 25/05/2019 PTR 1.37.0.0
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
