using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace OverwatchHighlights
{
	struct Checksum
	{
		private static byte[] ms_key;

		private byte[] m_data;

		static Checksum()
		{
			// I feel kinda iffy about shipping the raw key in my code, so I've developed this as a compromise.
			// You'll need to create a file 'checksumKey.bin' alongside your exe, that contains the 32-byte key.
			ms_key = null;
			if (File.Exists("checksumKey.bin"))
			{
				ms_key = File.ReadAllBytes("checksumKey.bin");
				if (ms_key.Length != 32)
				{
					ms_key = null;
				}
			}
		}

		public Checksum(BinaryReader br)
		{
			m_data = br.ReadBytes(32);
		}

		public static bool CanCompute { get { return ms_key != null; } }

		public static Checksum Compute(byte[] input)
		{
			if (ms_key == null)
			{
				throw new Exception("Can't calculate checksum - key is not available!");
			}
			using (var sha256 = new HMACSHA256(ms_key))
			{
				var digest = sha256.ComputeHash(input);
				return new Checksum() { m_data = digest };
			}
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
