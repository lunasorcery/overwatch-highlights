using System;
using System.Diagnostics;
using System.IO;

namespace OverwatchHighlights
{
	// This allows me to ensure that I'm reading the correct amount of data from a block.
	// I create it when I'm about to read a block of a known length, and destroy it when I've finished reading.
	// This can be scoped with the 'using' keyword.
	// The assertion in Dispose() will fail if we've read the wrong amount of data.
	class DebugBlockLength : IDisposable
	{
		private int m_length;
		private BinaryReader m_binaryReader;
		private long m_start;

		public DebugBlockLength(int length, BinaryReader br)
		{
			m_length = length;
			m_binaryReader = br;
			m_start = br.BaseStream.Position;
		}

		public void Dispose()
		{
			Debug.Assert(
				m_start + m_length == m_binaryReader.BaseStream.Position, 
				$"Expected to read {m_length} bytes, bit actually read {(m_binaryReader.BaseStream.Position - m_start)} bytes"
			);
		}
	}
}
