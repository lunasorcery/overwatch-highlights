using System.IO;

namespace OverwatchHighlights
{
	struct HighlightUUID
	{
		private uint m_a;
		private ushort m_b;
		private ushort m_c;
		private byte[] m_d;

		public HighlightUUID(BinaryReader br)
		{
			m_a = br.ReadUInt32();
			m_b = br.ReadUInt16();
			m_c = br.ReadUInt16();
			m_d = br.ReadBytes(8);
		}

		public static bool operator ==(HighlightUUID a, HighlightUUID b)
		{
			if (a.m_a != b.m_a)
				return false;
			if (a.m_b != b.m_b)
				return false;
			if (a.m_c != b.m_c)
				return false;
			for (int i = 0; i < 8; ++i)
				if (a.m_d[i] != b.m_d[i])
					return false;
			return true;
		}

		public static bool operator !=(HighlightUUID a, HighlightUUID b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"{m_a:x8}-{m_b:x4}-{m_c:x4}-{m_d[0]:x2}{m_d[1]:x2}-{m_d[2]:x2}{m_d[3]:x2}{m_d[4]:x2}{m_d[5]:x2}{m_d[6]:x2}{m_d[7]:x2}";
		}
	}
}
