using System.IO;
using System.Linq;

namespace OverwatchHighlights
{
	/// <summary>
	/// Encapsulates a 256-bit checksum. Algorithm currently unknown.
	/// </summary>
	struct Checksum
	{
		private byte[] m_data;

		public Checksum(BinaryReader br)
		{
			m_data = br.ReadBytes(32);
		}

		public static bool operator ==(Checksum a, Checksum b)
		{
			return a.m_data.IsEqualTo(b.m_data);
		}

		public static bool operator !=(Checksum a, Checksum b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return string.Join("", m_data.Select(a => a.ToString("x2")));
		}
	}
}
