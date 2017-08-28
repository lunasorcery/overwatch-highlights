using System.Collections.Generic;
using System.IO;

namespace OverwatchHighlights
{
	struct MajorVersion
	{
		private static Dictionary<int, string> ms_knownVersions = new Dictionary<int, string>()
		{
			// yeah, I don't understand the ordering either...
			{ 138, "(PTR) 1.13" },
			{ 147, "(Live) 1.13" },
			{ 146, "(PTR) 1.14" },
			{ 144, "(PTR) 1.15" },
		};

		private int m_version;

		public MajorVersion(BinaryReader br)
		{
			m_version = br.ReadInt32();
		}

		public static implicit operator int(MajorVersion version)
		{
			return version.m_version;
		}

		public bool IsKnownByTool()
		{
			return ms_knownVersions.ContainsKey(m_version);
		}

		public static bool operator ==(MajorVersion a, MajorVersion b)
		{
			return a.m_version == b.m_version;
		}

		public static bool operator !=(MajorVersion a, MajorVersion b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			return (obj is MajorVersion) ? this == (MajorVersion)obj : false;
		}

		public override int GetHashCode()
		{
			return m_version.GetHashCode();
		}

		public override string ToString()
		{
			if (ms_knownVersions.ContainsKey(m_version))
				return ms_knownVersions[m_version];
			return $"unknown-major-version-{m_version}";
		}
	}
}
