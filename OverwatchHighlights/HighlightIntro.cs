namespace OverwatchHighlights
{
	// https://blzgdapipro-a.akamaihd.net/game/unlocks/0x02500000XXXXXXXX.png
	enum HighlightIntro : uint
	{
		None                         = 0x00000000, // used by AI players

		Tracer_JustInTime            = 0x00000053,
		Reaper_DeathBlossom          = 0x0000005D,
		Pharah_Touchdown             = 0x00000084,
		Pharah_Barrage               = 0x00000085,
		Reinhardt_MoreStretchingRequired = 0x00000087,
		Mercy_BattleAngel            = 0x00000128,
		Widowmaker_SwingingIntoAction = 0x00000129,
		Widowmaker_ISeeYou           = 0x0000012A,
		Hanzo_Superior               = 0x0000012C,
		Hanzo_Backflip               = 0x0000012E,
		Winston_PrimalRage           = 0x00000132,
		Winston_Glasses              = 0x00000133,
		Winston_ExcuseMe             = 0x00000134,
		Zenyatta_HarmonyAndDiscord   = 0x00000135,
		Zenyatta_Transcendence       = 0x00000137,
		Symmetra_Dance               = 0x0000013A,
		Bastion_Ganymede             = 0x0000013C,
		McCree_RollingIntoAction     = 0x0000013E,
		McCree_TheNamesMcCree        = 0x00000140,
		Zarya_ThisIsStrength         = 0x00000141,
		Soldier76_TargetRichEnvironment = 0x00000145,
		Lucio_DropTheBeat            = 0x00000147,
		Lucio_InTheGroove            = 0x00000148,
		Junkrat_RipTire              = 0x0000014D,
		Junkrat_Unfortunate          = 0x0000014E,
		Junkrat_ImFlying             = 0x0000014F,
		Genji_UnsheathingTheSword    = 0x00000150,
		Genji_WarriorsSalute         = 0x00000151,
		DVa_LyingAround              = 0x00000154,
		Mei_Frosty                   = 0x00000157,
		Tracer_Heroic                = 0x000001FB,
		Mercy_Heroic                 = 0x00000219,
		Reaper_Heroic                = 0x0000021B,
		Widowmaker_Heroic            = 0x0000021C,
		Pharah_Heroic                = 0x0000021D,
		Reinhardt_Heroic             = 0x0000021E,
		Hanzo_Heroic                 = 0x0000021F,
		Torbjorn_Heroic              = 0x00000220,
		Symmetra_Heroic              = 0x00000223,
		Bastion_Heroic               = 0x00000224,
		McCree_Heroic                = 0x00000225,
		Soldier76_Heroic             = 0x00000227,
		Lucio_Heroic                 = 0x00000228,
		Junkrat_Heroic               = 0x0000022A,
		Genji_Heroic                 = 0x0000022B,
		DVa_Heroic                   = 0x0000022C,
		Mei_Heroic                   = 0x0000022D,
		Junkrat_Random               = 0x0000023D, // I think?
		Ana_Heroic                   = 0x00000A5A,
		Ana_LockedOn                 = 0x00000A7B,
		Ana_Shh                      = 0x00000A7D,
		Sombra_Heroic                = 0x00000AFB,
		Junkrat_Shotput              = 0x00000B19,
		Reaper_EternalRest           = 0x00000C33,
		Genji_PumpkinCarving         = 0x00000C43,
		Widowmaker_UnderTheMistletoe = 0x00000D43,
		Symmetra_Snowflakes          = 0x00000D4D,
		Mercy_Fortune                = 0x00000EAE,
		Orisa_Heroic                 = 0x00000F65,
		DVa_Selfie                   = 0x0000104B,
		Pharah_SlamDunk              = 0x00001141,
		Doomfist_Heroic              = 0x00001198,
		Doomfist_Random              = 0x00001199,

		// -- anything below here is known to exist but i've not mapped the value to a name yet --
		Ana_intro_00000A5B = 0x00000A5B,
		Ana_intro_00000A7A = 0x00000A7A,

		Bastion_intro_0000013B = 0x0000013B,
		Bastion_intro_0000013D = 0x0000013D,
		Bastion_intro_00000237 = 0x00000237,

		Doomfist_intro_00001188 = 0x00001188,
		Doomfist_intro_0000118A = 0x0000118A,
		Doomfist_intro_0000118B = 0x0000118B,

		DVa_intro_00000153 = 0x00000153,
		DVa_intro_00000155 = 0x00000155,
		DVa_intro_0000023F = 0x0000023F,

		Genji_intro_00000152 = 0x00000152,
		Genji_intro_0000023E = 0x0000023E,

		Hanzo_intro_0000012D = 0x0000012D,
		Hanzo_intro_00000232 = 0x00000232,
		Hanzo_intro_0000113F = 0x0000113F,

		Lucio_intro_00000149 = 0x00000149,
		Lucio_intro_0000023B = 0x0000023B,
		Lucio_intro_00000B17 = 0x00000B17,

		McCree_intro_0000013F = 0x0000013F,
		McCree_intro_00000238 = 0x00000238,

		Mei_intro_00000156 = 0x00000156,
		Mei_intro_00000158 = 0x00000158,
		Mei_intro_00000240 = 0x00000240,
		Mei_intro_00000C38 = 0x00000C38,

		Mercy_intro_00000126 = 0x00000126,
		Mercy_intro_00000127 = 0x00000127,
		Mercy_intro_0000021A = 0x0000021A,

		Orisa_intro_00000F68 = 0x00000F68,
		Orisa_intro_00000F90 = 0x00000F90,
		Orisa_intro_00000FF2 = 0x00000FF2,
		Orisa_intro_00000FF4 = 0x00000FF4,

		Pharah_intro_00000083 = 0x00000083,

		Reaper_intro_0000005B = 0x0000005B,
		Reaper_intro_0000005C = 0x0000005C,
		Reaper_intro_0000022E = 0x0000022E,

		Reinhardt_intro_00000088 = 0x00000088,
		Reinhardt_intro_00000089 = 0x00000089,
		Reinhardt_intro_00000231 = 0x00000231,

		Roadhog_intro_0000014A = 0x0000014A,
		Roadhog_intro_0000014B = 0x0000014B,
		Roadhog_intro_0000014C = 0x0000014C,
		Roadhog_intro_00000229 = 0x00000229,
		Roadhog_intro_00000EAD = 0x00000EAD,

		Soldier76_intro_00000144 = 0x00000144,
		Soldier76_intro_00000146 = 0x00000146,
		Soldier76_intro_0000023A = 0x0000023A,

		Sombra_intro_00000AFC = 0x00000AFC,
		Sombra_intro_00000B0D = 0x00000B0D,
		Sombra_intro_00000B0F = 0x00000B0F,
		Sombra_intro_00000CC1 = 0x00000CC1,

		Symmetra_intro_00000138 = 0x00000138,
		Symmetra_intro_00000139 = 0x00000139,

		Torbjorn_intro_0000012F = 0x0000012F,
		Torbjorn_intro_00000130 = 0x00000130,
		Torbjorn_intro_00000131 = 0x00000131,
		Torbjorn_intro_0000104A = 0x0000104A,

		Tracer_intro_00000051 = 0x00000051,
		Tracer_intro_00000052 = 0x00000052,
		Tracer_intro_000001FC = 0x000001FC,
		Tracer_intro_00000B18 = 0x00000B18,
		Tracer_intro_00000E4F = 0x00000E4F,

		Widowmaker_intro_0000012B = 0x0000012B,
		Widowmaker_intro_0000022F = 0x0000022F,

		Winston_intro_00000221 = 0x00000221,
		Winston_intro_00000234 = 0x00000234,

		Zarya_intro_00000142 = 0x00000142,
		Zarya_intro_00000143 = 0x00000143,
		Zarya_intro_00000226 = 0x00000226,
		Zarya_intro_00000239 = 0x00000239,

		Zenyatta_intro_00000136 = 0x00000136,
		Zenyatta_intro_00000222 = 0x00000222,
		Zenyatta_intro_00000235 = 0x00000235,
		Zenyatta_intro_00001060 = 0x00001060,
	};
}
