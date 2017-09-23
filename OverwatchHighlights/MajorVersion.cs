using System;
using System.IO;

namespace OverwatchHighlights
{
	enum VersionBranch
	{
		None = 0,
		PTR  = 1,
		Live = 2,
	}

	struct MajorVersion
	{
		private int m_a, m_b;
		private VersionBranch m_branch;

		public MajorVersion(int a, int b, VersionBranch branch)
		{
			m_a = a;
			m_b = b;
			m_branch = branch;
		}

		public MajorVersion(BinaryReader br)
		{
			m_a = m_b = 0;
			m_branch = VersionBranch.None;

			uint rawVersion = br.ReadUInt32();
			switch (rawVersion)
			{
				// what the heck, blizzard?
				case 138: Init(1, 13, VersionBranch.PTR);  break;
				case 147: Init(1, 13, VersionBranch.Live); break;
				case 146: Init(1, 14, VersionBranch.PTR);  break;
				case 150: Init(1, 14, VersionBranch.Live); break;
				case 144: Init(1, 15, VersionBranch.PTR);  break;
				case 154: Init(1, 15, VersionBranch.Live); break;
				case 148: Init(1, 16, VersionBranch.PTR);  break;
				default: throw new Exception($"Unknown major version number {rawVersion}");
			}
		}

		public bool IsKnownByTool()
		{
			if (this == new MajorVersion(1, 13, VersionBranch.PTR))  return true;
			if (this == new MajorVersion(1, 13, VersionBranch.Live)) return true;
			if (this == new MajorVersion(1, 14, VersionBranch.PTR))  return true;
			if (this == new MajorVersion(1, 14, VersionBranch.Live)) return true;
			if (this == new MajorVersion(1, 15, VersionBranch.PTR))  return true;
			if (this == new MajorVersion(1, 15, VersionBranch.Live)) return true;
			if (this == new MajorVersion(1, 16, VersionBranch.PTR))  return true;
			return false;
		}

		private void Init(int a, int b, VersionBranch branch)
		{
			m_a = a;
			m_b = b;
			m_branch = branch;
		}

		private uint ToComparableInt()
		{
			return (uint)(m_a * 10000) + (uint)(m_b * 100) + (uint)m_branch;
		}

		public static bool operator ==(MajorVersion a, MajorVersion b)
		{
			return a.ToComparableInt() == b.ToComparableInt();
		}

		public static bool operator !=(MajorVersion a, MajorVersion b)
		{
			return a.ToComparableInt() != b.ToComparableInt();
		}

		public static bool operator >=(MajorVersion a, MajorVersion b)
		{
			return a.ToComparableInt() >= b.ToComparableInt();
		}

		public static bool operator <=(MajorVersion a, MajorVersion b)
		{
			return a.ToComparableInt() <= b.ToComparableInt();
		}
	}
}
