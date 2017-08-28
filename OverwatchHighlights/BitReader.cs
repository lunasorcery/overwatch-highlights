namespace OverwatchHighlights
{
	class BitReader
	{
		private byte[] m_buffer;
		private int m_index;

		public BitReader(byte[] buffer)
		{
			m_buffer = buffer;
			m_index = 0;
		}

		private bool IsByteAligned()
		{
			return (m_index % 8) == 0;
		}

		public void ByteAlign()
		{
			while (!IsByteAligned())
			{
				m_index++;
			}
		}

		public bool Read1()
		{
			return Read(1) != 0;
		}
		public byte Read8()
		{
			return (byte)Read(8);
		}
		public ushort Read16()
		{
			return (ushort)Read(16);
		}
		public uint Read32()
		{
			return (uint)Read(32);
		}

		public ulong Read(int bits)
		{
			if (IsByteAligned())
			{
				if (bits == 8)
				{
					byte byte0 = m_buffer[m_index / 8]; m_index += 8;
					return byte0;
				}
				else if (bits == 16)
				{
					ushort byte0 = m_buffer[m_index / 8]; m_index += 8;
					ushort byte1 = m_buffer[m_index / 8]; m_index += 8;
					return (ulong)((byte1 << 8) | byte0);
				}
				else if (bits == 32)
				{
					uint byte0 = m_buffer[m_index / 8]; m_index += 8;
					uint byte1 = m_buffer[m_index / 8]; m_index += 8;
					uint byte2 = m_buffer[m_index / 8]; m_index += 8;
					uint byte3 = m_buffer[m_index / 8]; m_index += 8;
					return (byte3 << 24) | (byte2 << 16) | (byte1 << 8) | byte0;
				}
			}

			ulong a = 0;
			for (int i = 0; i < bits; ++i)
			{
				byte bufferByte = m_buffer[m_index / 8];
				ulong bufferRead = (ulong)((bufferByte >> (m_index % 8)) & 1) << i;
				a |= bufferRead;
				m_index++;
			}
			return a;
		}

		private bool CanRead()
		{
			return (m_index / 8) < m_buffer.Length;
		}
	}
}
