namespace OverwatchHighlights
{
	public enum HighlightCategory : uint
	{
		None         = 0x00000000,
		Shutdown     = 0x00000001,
		Sharpshooter = 0x00000002,
		HighScore    = 0x00000003, // doesn't show text on the highlight intro
		Lifesaver    = 0x00000004
	}
}
