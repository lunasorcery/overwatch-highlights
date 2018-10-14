namespace OverwatchHighlights
{
	// https://blzgdapipro-a.akamaihd.net/game/unlocks/0x02500000XXXXXXXX.png
	enum HighlightIntro : uint
	{
		None                         = 0x00000000, // used by AI players

		Tracer_JustInTime            = 0x00000053,
		Reaper_ShadowStep            = 0x0000005C,
		Reaper_DeathBlossom          = 0x0000005D,
		Pharah_MissionComplete       = 0x00000083,
		Pharah_Touchdown             = 0x00000084,
		Pharah_Barrage               = 0x00000085,
		Reinhardt_MoreStretchingRequired = 0x00000087,
		Reinhardt_HammerDown         = 0x00000089,
		Mercy_HeroesNeverDie         = 0x00000126,
		Mercy_BattleAngel            = 0x00000128,
		Widowmaker_SwingingIntoAction = 0x00000129,
		Widowmaker_ISeeYou           = 0x0000012A,
		Widowmaker_HangingAround     = 0x0000012B,
		Hanzo_Superior               = 0x0000012C,
		Hanzo_MyAimIsTrue            = 0x0000012D,
		Hanzo_Backflip               = 0x0000012E,
		Torbjorn_Refreshing          = 0x00000130,
		Torbjorn_InYourFace          = 0x00000131,
		Winston_PrimalRage           = 0x00000132,
		Winston_Glasses              = 0x00000133,
		Winston_ExcuseMe             = 0x00000134,
		Zenyatta_HarmonyAndDiscord   = 0x00000135,
		Zenyatta_Focused             = 0x00000136,
		Zenyatta_Transcendence       = 0x00000137,
		Symmetra_Askew               = 0x00000138,
		Symmetra_MyReality           = 0x00000139,
		Symmetra_Dance               = 0x0000013A,
		Bastion_OnGuard              = 0x0000013B,
		Bastion_Ganymede             = 0x0000013C,
		Bastion_BulletRain           = 0x0000013D,
		McCree_RollingIntoAction     = 0x0000013E,
		McCree_TheDuel               = 0x0000013F,
		McCree_TheNamesMcCree        = 0x00000140,
		Zarya_ThisIsStrength         = 0x00000141,
		Zarya_Deadlift               = 0x00000142,
		Zarya_MaximumCharge          = 0x00000143,
		Soldier76_LookingAtYou       = 0x00000144,
		Soldier76_TargetRichEnvironment = 0x00000145,
		Soldier76_Helix              = 0x00000146,
		Lucio_DropTheBeat            = 0x00000147,
		Lucio_InTheGroove            = 0x00000148,
		Roadhog_LittlePiggy          = 0x0000014B,
		Roadhog_WholeHog             = 0x0000014C,
		Junkrat_RipTire              = 0x0000014D,
		Junkrat_Unfortunate          = 0x0000014E,
		Junkrat_ImFlying             = 0x0000014F,
		Genji_UnsheathingTheSword    = 0x00000150,
		Genji_WarriorsSalute         = 0x00000151,
		Genji_Shuriken               = 0x00000152,
		DVa_Eject                    = 0x00000153,
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
		Winston_Heroic               = 0x00000221,
		Symmetra_Heroic              = 0x00000223,
		Bastion_Heroic               = 0x00000224,
		McCree_Heroic                = 0x00000225,
		Soldier76_Heroic             = 0x00000227,
		Lucio_Heroic                 = 0x00000228,
		Roadhog_Heroic               = 0x00000229,
		Junkrat_Heroic               = 0x0000022A,
		Genji_Heroic                 = 0x0000022B,
		DVa_Heroic                   = 0x0000022C,
		Mei_Heroic                   = 0x0000022D,
		Junkrat_Random               = 0x0000023D, // I think?
		Ana_Heroic                   = 0x00000A5A,
		Ana_LockedOn                 = 0x00000A7B,
		Ana_Shh                      = 0x00000A7D,
		Sombra_Heroic                = 0x00000AFB,
		Lucio_BicycleKick            = 0x00000B17,
		Junkrat_Shotput              = 0x00000B19,
		Reaper_EternalRest           = 0x00000C33,
		Genji_PumpkinCarving         = 0x00000C43,
		Widowmaker_UnderTheMistletoe = 0x00000D43,
		Symmetra_Snowflakes          = 0x00000D4D,
		Mercy_Fortune                = 0x00000EAE,
		Orisa_Heroic                 = 0x00000F65,
		Torbjorn_MyBaby              = 0x0000104A,
		DVa_Selfie                   = 0x0000104B,
		Zenyatta_Perspective         = 0x00001060,
		Hanzo_TargetPractice         = 0x0000113F,
		Pharah_SlamDunk              = 0x00001141,
		Doomfist_OnePunch            = 0x00001188,
		Doomfist_Uppercut            = 0x0000118B,
		Doomfist_Heroic              = 0x00001198,
		Doomfist_Random              = 0x00001199,
		Moira_Heroic                 = 0x000012EA,

		// -- anything below here is known to exist but i've not mapped the value to a name yet --
		Ana_intro_00000A5B = 0x00000A5B,
		Ana_intro_00000A7A = 0x00000A7A,

		Bastion_intro_00000237 = 0x00000237,

		Brigitte_intro_000016D9 = 0x000016D9,
		Brigitte_intro_000022BC = 0x000022BC,

		Doomfist_intro_0000118A = 0x0000118A,
		Doomfist_intro_00001288 = 0x00001288,

		DVa_intro_00000155 = 0x00000155,
		DVa_intro_0000023F = 0x0000023F,

		Genji_intro_0000023E = 0x0000023E,

		Hammond_intro_000019E1 = 0x000019E1,

		Hanzo_intro_00000232 = 0x00000232,

		Lucio_intro_00000149 = 0x00000149,
		Lucio_intro_0000023B = 0x0000023B,

		McCree_intro_00000238 = 0x00000238,
		McCree_intro_00001284 = 0x00001284,

		Mei_intro_00000156 = 0x00000156,
		Mei_intro_00000158 = 0x00000158,
		Mei_intro_00000240 = 0x00000240,
		Mei_intro_00000C38 = 0x00000C38,

		Mercy_intro_00000127 = 0x00000127,
		Mercy_intro_0000021A = 0x0000021A,

		Moira_intro_000012FE = 0x000012FE,
		Moira_intro_00001324 = 0x00001324,
		Moira_intro_00001353 = 0x00001353,
		Moira_intro_00001A64 = 0x00001A64,

		Orisa_intro_00000F68 = 0x00000F68,
		Orisa_intro_00000F90 = 0x00000F90,
		Orisa_intro_00000FF2 = 0x00000FF2,
		Orisa_intro_00000FF4 = 0x00000FF4,

		Pharah_intro_00000230 = 0x00000230, // random?

		Reaper_intro_0000005B = 0x0000005B,
		Reaper_intro_0000022E = 0x0000022E,

		Reinhardt_intro_00000088 = 0x00000088,
		Reinhardt_intro_00000231 = 0x00000231,
		Reinhardt_intro_000011BA = 0x000011BA,

		Roadhog_intro_0000014A = 0x0000014A,
		Roadhog_intro_0000023C = 0x0000023C,
		Roadhog_intro_00000EAD = 0x00000EAD,
		Roadhog_intro_00001185 = 0x00001185,

		Soldier76_intro_0000023A = 0x0000023A,

		Sombra_intro_00000AFC = 0x00000AFC,
		Sombra_intro_00000B0D = 0x00000B0D,
		Sombra_intro_00000B0F = 0x00000B0F,
		Sombra_intro_00000CC1 = 0x00000CC1,

		Symmetra_intro_00000236 = 0x00000236,

		Torbjorn_intro_0000012F = 0x0000012F,
		Torbjorn_intro_00000233 = 0x00000233,

		Tracer_intro_00000051 = 0x00000051,
		Tracer_intro_00000052 = 0x00000052,
		Tracer_intro_000001FC = 0x000001FC,
		Tracer_intro_00000B18 = 0x00000B18,
		Tracer_intro_00000E4F = 0x00000E4F,

		Widowmaker_intro_0000022F = 0x0000022F,

		Winston_intro_00000234 = 0x00000234,

		Zarya_intro_00000226 = 0x00000226,
		Zarya_intro_00000239 = 0x00000239,
		Zarya_intro_0000126C = 0x0000126C,

		Zenyatta_intro_00000222 = 0x00000222,
		Zenyatta_intro_00000235 = 0x00000235,
	};
}
