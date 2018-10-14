namespace OverwatchHighlights
{
	enum GameMode : uint
	{
		// I've commented out a few of these
		// I expect them to be correct but I don't have test data highlights to verify against.
		Default              = 0x00000000,
		JunkensteinsRevengeLockedHeroes = 0x00000003,
		CaptureTheFlag       = 0x00000007,
		Elimination          = 0x00000009,
		UprisingLockedHeroes = 0x0000000F,
//		Assault              = 0x00000014,
		Escort               = 0x00000015,
		Hybrid               = 0x00000016,
		Control              = 0x00000017,
//		UprisingAllHeroes    = 0x0000001A,
		TeamDeathmatch       = 0x0000001D,
		Deathmatch           = 0x0000001E,
		Lucioball            = 0x00000020,
		Retribution          = 0x00000025,
		JunkensteinsRevengeEndless = 0x0000002A,
	}
}
