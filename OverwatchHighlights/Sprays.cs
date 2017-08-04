﻿namespace OverwatchHighlights
{
	// https://blzgdapipro-a.akamaihd.net/game/unlocks/0x02500000XXXXXXXX.png
	enum Spray : uint
	{
		Common_Logo              = 0x0000008D,
		Tracer_Wings             = 0x000000DE,
		Tracer_Icon              = 0x000000DF,
		Tracer_Kneeling          = 0x000000E0,
		Tracer_WhatchaLookinAt   = 0x000000E1,
		Tracer_Cheers            = 0x000000E2,
		Tracer_Pixel             = 0x0000015C,
		Tracer_Cute              = 0x0000015E,
		Tracer_Portrait          = 0x00000161,
		Tracer_Blink             = 0x00000165,
		Tracer_CavalrysHere      = 0x00000167,
		Tracer_Poster            = 0x00000168,
		Tracer_Fighter           = 0x00000169,
		Tracer_Salute            = 0x0000016A,
		Tracer_Tagged            = 0x0000016B,
		Tracer_Orange            = 0x0000016C,
		Tracer_Lena              = 0x0000016E,
		Tracer_ClocksTickin      = 0x0000016F,
		Tracer_Pistols           = 0x00000170,
		Tracer_Shaded            = 0x00000171,
		Tracer_PulseBomb         = 0x00000172,
		Reaper_Icon              = 0x00000181,
		Widowmaker_Icon          = 0x00000182,
		Pharah_Raptora           = 0x00000183,
		Reinhardt_Icon           = 0x00000184,
		Mercy_Icon               = 0x00000185,
		Hanzo_Icon               = 0x00000186,
		Torbjorn_Icon            = 0x00000187,
		Winston_Icon             = 0x00000188,
		Zenyatta_Icon            = 0x00000189,
		Symmetra_Icon            = 0x0000018A,
		Bastion_Icon             = 0x0000018B,
		McCree_Icon              = 0x0000018C,
		Zarya_Icon               = 0x0000018D,
		Soldier76_Icon           = 0x0000018E,
		Lucio_Icon               = 0x0000018F,
		Roadhog_Icon             = 0x00000190,
		Junkrat_Icon             = 0x00000191,
		Genji_Icon               = 0x00000192,
		DVa_Icon                 = 0x00000193,
		Mei_Icon                 = 0x00000194,
		Common_TeaTime           = 0x000001C4,
		Common_Catcher           = 0x000001C5,
		Common_Pachimari         = 0x000001C6,
		Common_VivisAdventure    = 0x000001C7,
		Common_FOTS2             = 0x000001C8,
		Common_SiegeMode         = 0x000001C9,
		Common_Soulstone         = 0x000001CA,
		Common_Dance             = 0x000001CC,
		Common_Fuji              = 0x000001D0,
		Common_Rise              = 0x000001D2,
		Common_Rikimaru          = 0x000001D3,
		Common_OmnicRights       = 0x000001D4,
		Common_NumbaniStatue     = 0x000001D5,
		Common_ForgeOnward       = 0x000001D6,
		Common_ManAndOmnic       = 0x000001D8,
		Common_Leek              = 0x000001DB,
		Common_LumériCo          = 0x000001DC,
		Common_Pinata            = 0x000001DD,
		Common_GoldshirePictures = 0x000001DE,
		Common_Scroll            = 0x000001DF,
		Common_Jail              = 0x000001E0,
		Common_BeyondTheMoon     = 0x000001E1,
		Common_GLHF              = 0x000001E2,
		Common_Victory           = 0x000001E5,
		DVa_BNy                  = 0x000001EC,
		DVa_Diva                 = 0x000001ED,
		DVa_NanoCola             = 0x000001EE,
		Winston_Baby             = 0x000001F1,
		Winston_PrimalRage       = 0x000001F3,
		Winston_Horizon          = 0x000001F4,
		Winston_PB               = 0x000001F6,
		Symmetra_Visor           = 0x000001F9,
		Zenyatta_Graphic         = 0x000001FE,
		Zenyatta_Orb             = 0x000001FF,
		Zenyatta_Contemplative   = 0x00000201,
		Zenyatta_Aura            = 0x00000203,
		Zenyatta_Balance         = 0x00000204,
		Zenyatta_Foot            = 0x00000205,
		Zenyatta_Adorable        = 0x00000206,
		Zenyatta_Together        = 0x00000208,
		Zenyatta_Nine            = 0x0000020A,
		Lucio_Frog               = 0x00000241,
		Lucio_Baixo              = 0x00000244,
		Lucio_Deck               = 0x00000246,
		Lucio_Pixel              = 0x00000247,
		Lucio_Spin               = 0x00000248,
		Lucio_Kambo              = 0x00000249,
		Lucio_Signature          = 0x0000024B,
		DVa_LightGun             = 0x0000024F,
		DVa_Bang                 = 0x00000250,
		DVa_GG                   = 0x00000251,
		DVa_Pixel                = 0x00000252,
		DVa_MEKA                 = 0x00000253,
		DVa_PowerUp              = 0x00000254,
		DVa_WalkOfFame           = 0x00000255,
		DVa_Star                 = 0x00000256,
		Mei_Pixel                = 0x0000025D,
		Bastion_Nest             = 0x00000269,
		Bastion_Retro            = 0x0000026A,
		Zarya_Shield             = 0x00000284,
		Zarya_Barrier            = 0x00000289,
		Zarya_Tobelstein         = 0x0000028B,
		Zarya_Lift               = 0x0000028D,
		Zarya_Focused            = 0x0000028E,
		Zarya_Defender           = 0x0000028F,
		Zarya_Weights            = 0x00000290,
		Pharah_Wedjat            = 0x000002AE,
		Pharah_Statue            = 0x000002AF,
		Pharah_RocketJump        = 0x000002B0,
		Pharah_Icon              = 0x000002B1,
		Pharah_Salute            = 0x000002B2,
		Pharah_PlayPharah        = 0x000002B3,
		Pharah_AerialSuperiority = 0x000002B4,
		Pharah_Hieroglyph        = 0x000002B5,
		Pharah_ConcussiveBlast   = 0x000002B6,
		Pharah_Justice           = 0x000002B7,
		Pharah_Guardian          = 0x000002B8,
		Pharah_Wings             = 0x000002B9,
		Pharah_Stone             = 0x000002BB,
		Winston_Roar             = 0x000002CA,
		Winston_White            = 0x000002CC,
		Winston_ApeCrossing      = 0x000002CE,
		Genji_Nin                = 0x000002D0,
		Genji_GodOfWar           = 0x000002D1,
		Genji_Stance             = 0x000002D2,
		Genji_Soul               = 0x000002D4,
		Genji_Ryugekiken         = 0x000002D5,
		Genji_Pixel              = 0x000002D6,
		Genji_FullyLoaded        = 0x000002D7,
		Genji_KazeNoGotoku       = 0x000002D8,
		Genji_Lunge              = 0x000002D9,
		Genji_GreenNinja         = 0x000002DB,
		Zenyatta_Tekhartha       = 0x0000057F,
		Zenyatta_Enlightened     = 0x00000581,
		Zenyatta_Orbs            = 0x00000582,
		Zenyatta_Flow            = 0x00000585,
		Zenyatta_Throw           = 0x00000586,
		Zenyatta_Guru            = 0x00000587,
		Zenyatta_Peace           = 0x0000058A,
		Zenyatta_Taunt           = 0x0000058C,
		Zenyatta_Cute            = 0x00000597,
		Junkrat_Fuse             = 0x000005AB,
		Lucio_Confident          = 0x000005D7,
		Lucio_Cereal             = 0x000005DC,
		Lucio_Scratch            = 0x000005DD,
		Lucio_Acelerar           = 0x000005DE,
		Lucio_BreakItDown        = 0x000005DF,
		Lucio_Wave               = 0x000005E3,
		Lucio_WalkOfFame         = 0x000005E4,
		Lucio_Cute               = 0x000005ED,
		Bastion_Flight           = 0x0000060A,
		Bastion_Cute             = 0x00000618,
		Mei_Cute                 = 0x00000643,
		DVa_Watching             = 0x00000663,
		DVa_Bubble               = 0x00000667,
		DVa_PixelBunny           = 0x00000668,
		DVa_Photo                = 0x0000066C,
		DVa_Salt                 = 0x0000066F,
		DVa_LoveDVa              = 0x00000670,
		DVa_BunnyHop             = 0x00000671,
		DVa_Heart                = 0x00000676,
		DVa_Cute                 = 0x00000677,
		Zarya_GunShow            = 0x00000703,
		Zarya_Pink               = 0x00000706,
		Zarya_Champion           = 0x00000707,
		Zarya_Wrestle            = 0x00000708,
		Zarya_ForThePeople       = 0x00000713,
		Zarya_Cute               = 0x00000719,
		Zarya_Pixel              = 0x0000071A,
		Genji_Dragonblade        = 0x00000727,
		Genji_Shuriken           = 0x00000728,
		Genji_Dragon             = 0x00000729,
		Genji_Warrior            = 0x0000072B,
		Genji_Stoic              = 0x0000072C,
		Genji_Assassin           = 0x0000072D,
		Genji_Draw               = 0x0000072F,
		Genji_Shimada            = 0x00000730,
		Genji_TargetPractice     = 0x0000073C,
		Genji_Prepared           = 0x0000073D,
		Genji_Cute               = 0x0000073F,
		Genji_Onmyodo            = 0x0000073E,
		Pharah_RocketLauncher    = 0x000007AA,
		Pharah_Ana               = 0x000007B1,
		Pharah_Amari             = 0x000007B6,
		Pharah_Pixel             = 0x000007C0,
		Pharah_Cute              = 0x000007C1,
		Soldier76_Visor          = 0x000007D9,
		Symmetra_Vaswani         = 0x0000080F,
		Symmetra_Builder         = 0x00000810,
		Symmetra_Superior        = 0x00000813,
		Symmetra_Weaver          = 0x00000814,
		Symmetra_Design          = 0x00000815,
		Tracer_Confident         = 0x00000839,
		Winston_Mine             = 0x0000084F,
		Winston_Explorer         = 0x0000085A,
		Winston_Wow              = 0x0000085B,
		Winston_Research         = 0x0000085C,
		Winston_Harold           = 0x0000085D,
		Winston_Banana           = 0x0000085F,
		Winston_Rage             = 0x00000867,
		Winston_Fastball         = 0x00000869,
		Winston_Pixel            = 0x0000086B,
		Winston_Cute             = 0x0000086C,
		Common_Respect           = 0x0000086E,
		Tracer_CheersLove        = 0x00000873,
		Bastion_Pixel            = 0x000008DD,
		Common_RedO              = 0x000008DE,
		Common_RedX              = 0x000008DF,
		Common_Sorry             = 0x000008E2,
		Common_Thanks            = 0x000008E3,
		Common_WellPlayed        = 0x000008E4,
		Common_Oops              = 0x000008E5,
		Common_Punch             = 0x0000090B,
		Zenyatta_Harmony         = 0x00000A41,
		Lucio_UnderControl       = 0x00000A48,
		Zenyatta_InnerFire       = 0x00000A4B,
		Ana_OldSoldier           = 0x00000A94,
		Ana_Ana                  = 0x00000A95,
		Ana_Action               = 0x00000A97,
		Ana_Wedjat               = 0x00000A98,
		Ana_Cracked              = 0x00000A99,
		Ana_Rifle                = 0x00000A9A,
		Ana_WristLauncher        = 0x00000A9B,
		Ana_Gaze                 = 0x00000A9C,
		Ana_Eyepatch             = 0x00000A9D,
		Ana_Photograph           = 0x00000AA0,
		Ana_Sidearm              = 0x00000AA1,
		Ana_Guardian             = 0x00000AA2,
		Ana_Shadow               = 0x00000AA5,
		Ana_Grenade              = 0x00000AA7,
		Ana_Zzz                  = 0x00000AB3,
		Ana_Bearer               = 0x00000AB4,
		Ana_Letter               = 0x00000AB5,
		Ana_Cheer                = 0x00000AB6,
		Ana_Shhh                 = 0x00000AB7,
		Ana_Pixel                = 0x00000AB8,
		Ana_Cute                 = 0x00000AB9,
		Common_YouAreNotPrepared = 0x00000B13,
		Ana_Icon                 = 0x00000B2B,
		Common_Crusader          = 0x00000C06,
		Common_WitchDoctor       = 0x00000C07,
		Common_Wizard            = 0x00000C0A,
		Common_Fangs             = 0x00000C4E,
		Ana_TrickOrTreat         = 0x00000C52,
		Bastion_TrickOrTreat     = 0x00000C58,
		Pharah_TrickOrTreat      = 0x00000C5F,
		Genji_TrickOrTreat       = 0x00000C61,
		Common_Season3Competitor = 0x00000C8F,
		Genji_Oni                = 0x00000C9D,
		Common_Boop              = 0x00000CAE,
		Sombra_Cute              = 0x00000CC9,
		Sombra_Hacked            = 0x00000CCD,
		Sombra_MachinePistol     = 0x00000CD1,
		Sombra_Quien             = 0x00000CD3,
		Sombra_Superior          = 0x00000CD5,
		Sombra_Power             = 0x00000CD6,
		Sombra_Eyes              = 0x00000CD9,
		Sombra_Key               = 0x00000CDD,
		Sombra_DeafMute          = 0x00000CE0,
		Common_DiaDeLosMuertos   = 0x00000CEF,
		DVa_Cookie               = 0x00000D17,
		Genji_Kadomatsu          = 0x00000D1E,
		Tracer_Snowboarding      = 0x00000D20,
		Genji_Ornament           = 0x00000D3A,
		Tracer_Ornament          = 0x00000D3C,
		Ana_Dance                = 0x00000D59,
		Zenyatta_YutNori         = 0x00000EC7,
		Tracer_FanDance          = 0x00000EC9,
		Pharah_HappyNewYear      = 0x00000ECC,
		Zarya_Calories           = 0x00000ED2,
		Genji_GreenDragon        = 0x00000ED4,
		Lucio_KeepUps            = 0x00000ED7,
		Ana_DragonDance          = 0x00000EDA,
		Zenyatta_DragonDance     = 0x00000EDE,
		Sombra_DragonDance       = 0x00000EE3,
		DVa_DragonDance          = 0x00000EE6,
		Winston_DragonDance      = 0x00000EEC,
		Genji_DragonDance        = 0x00000EED,
		Tracer_DragonDance       = 0x00000EEF,
		Common_AwakenedLion      = 0x00000F6B,
		Orisa_Protector          = 0x00000FFF,
		Orisa_Guardian           = 0x00001000,
		Orisa_Xing               = 0x00001001,
		Orisa_JustDessert        = 0x00001002,
		Orisa_Pixel              = 0x00001003,
		Orisa_Icon               = 0x00001004,
		Orisa_CrossingGuard      = 0x00001005,
		Orisa_Swing              = 0x00001006,
		Orisa_Kick               = 0x00001007,
		Orisa_Stop               = 0x00001008,
		Orisa_Construction       = 0x00001009,
		Orisa_Cleaning           = 0x0000100A,
		Orisa_EyesPointingUp     = 0x0000100B,
		Orisa_EyesPointingIn     = 0x0000100C,
		Orisa_Tracks             = 0x0000100D,
		Orisa_Supercharged       = 0x0000100E,
		Orisa_Carving            = 0x0000100F,
		Orisa_Cute               = 0x00001010,
		Orisa_Drumming           = 0x00001011,
		Orisa_Amused             = 0x00001012,
		Orisa_Companions         = 0x00001013,
		Orisa_Shield             = 0x00001014,
		Orisa_CityOfHarmony      = 0x00001015,
		Orisa_Heroes             = 0x00001016,
		Orisa_Unmoving           = 0x00001017,
		Ana_Newborn              = 0x0000106D,
		Zenyatta_Shell           = 0x00001075,
		Lucio_Skates             = 0x00001076,
		DVa_Handheld             = 0x0000107A,
		Tracer_Slipstream        = 0x00001080,
		Genji_Ramen              = 0x00001085,
		Common_Eradicator        = 0x000010AE,
		Common_Nulltrooper       = 0x000010AF,
		Common_B73NS             = 0x000010B0,
		Common_OR14NS            = 0x000010B3,
		Zenyatta_KingOfSpades    = 0x00001165,
		Genji_JackOfClubs        = 0x00001174,
		Tracer_AceOfDiamonds     = 0x00001176,
		Doomfist_Wrapped         = 0x000011BD,
		Doomfist_OutOfTime       = 0x000011D2,


		// -- anything below here is known to exist but i've not mapped the value to a name yet --
		Common_spray_000010B2 = 0x000010B2,

		Ana_spray_00000ABA = 0x00000ABA,
		Ana_spray_00000C4C = 0x00000C4C,
		Ana_spray_0000106F = 0x0000106F,

		Bastion_spray_00000265 = 0x00000265,
		Bastion_spray_00000266 = 0x00000266,
		Bastion_spray_00000267 = 0x00000267,
		Bastion_spray_00000268 = 0x00000268,
		Bastion_spray_0000026B = 0x0000026B,
		Bastion_spray_0000026C = 0x0000026C,
		Bastion_spray_0000026D = 0x0000026D,
		Bastion_spray_0000026F = 0x0000026F,
		Bastion_spray_00000600 = 0x00000600,
		Bastion_spray_00000602 = 0x00000602,
		Bastion_spray_00000606 = 0x00000606,
		Bastion_spray_00000607 = 0x00000607,
		Bastion_spray_00000609 = 0x00000609,
		Bastion_spray_0000060B = 0x0000060B,
		Bastion_spray_00001078 = 0x00001078,
		Bastion_spray_00001169 = 0x00001169,

		Doomfist_spray_000011BC = 0x000011BC,
		Doomfist_spray_000011BF = 0x000011BF,
		Doomfist_spray_000011C9 = 0x000011C9,
		Doomfist_spray_000011CA = 0x000011CA,
		Doomfist_spray_000011CB = 0x000011CB,
		Doomfist_spray_000011CD = 0x000011CD,
		Doomfist_spray_000011CE = 0x000011CE,
		Doomfist_spray_000011CF = 0x000011CF,
		Doomfist_spray_000011D0 = 0x000011D0,
		Doomfist_spray_00001255 = 0x00001255,
		Doomfist_spray_00001275 = 0x00001275,

		DVa_spray_00000673 = 0x00000673,
		DVa_spray_00000ED6 = 0x00000ED6,
		DVa_spray_00001099 = 0x00001099,
		DVa_spray_0000116D = 0x0000116D,

		Genji_spray_00000CAF = 0x00000CAF,

		Hanzo_spray_000001A3 = 0x000001A3,
		Hanzo_spray_000001A4 = 0x000001A4,
		Hanzo_spray_000001A6 = 0x000001A6,
		Hanzo_spray_000001A7 = 0x000001A7,
		Hanzo_spray_000001A9 = 0x000001A9,
		Hanzo_spray_000001AA = 0x000001AA,
		Hanzo_spray_000001AB = 0x000001AB,
		Hanzo_spray_000001AC = 0x000001AC,
		Hanzo_spray_000001AD = 0x000001AD,
		Hanzo_spray_000001B0 = 0x000001B0,
		Hanzo_spray_0000052A = 0x0000052A,
		Hanzo_spray_0000052B = 0x0000052B,
		Hanzo_spray_0000052C = 0x0000052C,
		Hanzo_spray_0000052D = 0x0000052D,
		Hanzo_spray_0000052F = 0x0000052F,
		Hanzo_spray_00000530 = 0x00000530,
		Hanzo_spray_00000531 = 0x00000531,
		Hanzo_spray_00000532 = 0x00000532,
		Hanzo_spray_00000534 = 0x00000534,
		Hanzo_spray_00000538 = 0x00000538,
		Hanzo_spray_0000053F = 0x0000053F,
		Hanzo_spray_00000542 = 0x00000542,
		Hanzo_spray_00000B77 = 0x00000B77,
		Hanzo_spray_00000CAD = 0x00000CAD,
		Hanzo_spray_00000D29 = 0x00000D29,
		Hanzo_spray_00000EC5 = 0x00000EC5,
		Hanzo_spray_00000EDC = 0x00000EDC,
		Hanzo_spray_00001074 = 0x00001074,
		Hanzo_spray_00001163 = 0x00001163,

		Junkrat_spray_0000020B = 0x0000020B,
		Junkrat_spray_0000020C = 0x0000020C,
		Junkrat_spray_0000020D = 0x0000020D,
		Junkrat_spray_0000020E = 0x0000020E,
		Junkrat_spray_0000020F = 0x0000020F,
		Junkrat_spray_00000210 = 0x00000210,
		Junkrat_spray_00000211 = 0x00000211,
		Junkrat_spray_00000213 = 0x00000213,
		Junkrat_spray_00000214 = 0x00000214,
		Junkrat_spray_00000215 = 0x00000215,
		Junkrat_spray_00000217 = 0x00000217,
		Junkrat_spray_000005A2 = 0x000005A2,
		Junkrat_spray_000005B2 = 0x000005B2,
		Junkrat_spray_000005B3 = 0x000005B3,
		Junkrat_spray_000005B6 = 0x000005B6,
		Junkrat_spray_000005B7 = 0x000005B7,
		Junkrat_spray_000005B8 = 0x000005B8,
		Junkrat_spray_000005BF = 0x000005BF,
		Junkrat_spray_000005C1 = 0x000005C1,
		Junkrat_spray_000005C2 = 0x000005C2,
		Junkrat_spray_00000D11 = 0x00000D11,
		Junkrat_spray_00000D2C = 0x00000D2C,
		Junkrat_spray_00000EC8 = 0x00000EC8,
		Junkrat_spray_00000EDF = 0x00000EDF,
		Junkrat_spray_00001073 = 0x00001073,
		Junkrat_spray_00001166 = 0x00001166,

		Lucio_spray_000005E7 = 0x000005E7,
		Lucio_spray_00000BDE = 0x00000BDE,
		Lucio_spray_00001167 = 0x00001167,

		McCree_spray_000001B1 = 0x000001B1,
		McCree_spray_000001B2 = 0x000001B2,
		McCree_spray_000001B3 = 0x000001B3,
		McCree_spray_000001B4 = 0x000001B4,
		McCree_spray_000001B5 = 0x000001B5,
		McCree_spray_000001B6 = 0x000001B6,
		McCree_spray_000001B7 = 0x000001B7,
		McCree_spray_000001B8 = 0x000001B8,
		McCree_spray_000001B9 = 0x000001B9,
		McCree_spray_000001BA = 0x000001BA,
		McCree_spray_000001BB = 0x000001BB,
		McCree_spray_000001BE = 0x000001BE,
		McCree_spray_00000554 = 0x00000554,
		McCree_spray_00000555 = 0x00000555,
		McCree_spray_00000556 = 0x00000556,
		McCree_spray_00000558 = 0x00000558,
		McCree_spray_0000055B = 0x0000055B,
		McCree_spray_0000055E = 0x0000055E,
		McCree_spray_0000055F = 0x0000055F,
		McCree_spray_00000560 = 0x00000560,
		McCree_spray_00000561 = 0x00000561,
		McCree_spray_00000562 = 0x00000562,
		McCree_spray_00000563 = 0x00000563,
		McCree_spray_00000568 = 0x00000568,
		McCree_spray_00000870 = 0x00000870,
		McCree_spray_00000C54 = 0x00000C54,
		McCree_spray_00000D7D = 0x00000D7D,
		McCree_spray_00000EC6 = 0x00000EC6,
		McCree_spray_00000EDD = 0x00000EDD,
		McCree_spray_0000108F = 0x0000108F,
		McCree_spray_00001164 = 0x00001164,

		Mei_spray_000001E6 = 0x000001E6,
		Mei_spray_000001E7 = 0x000001E7,
		Mei_spray_000001E8 = 0x000001E8,
		Mei_spray_0000025A = 0x0000025A,
		Mei_spray_0000025B = 0x0000025B,
		Mei_spray_0000025C = 0x0000025C,
		Mei_spray_0000025E = 0x0000025E,
		Mei_spray_0000025F = 0x0000025F,
		Mei_spray_00000260 = 0x00000260,
		Mei_spray_00000261 = 0x00000261,
		Mei_spray_00000262 = 0x00000262,
		Mei_spray_00000264 = 0x00000264,
		Mei_spray_0000062C = 0x0000062C,
		Mei_spray_00000632 = 0x00000632,
		Mei_spray_00000638 = 0x00000638,
		Mei_spray_0000063C = 0x0000063C,
		Mei_spray_0000063F = 0x0000063F,
		Mei_spray_00000A4A = 0x00000A4A,
		Mei_spray_00000D2E = 0x00000D2E,
		Mei_spray_00000ED8 = 0x00000ED8,
		Mei_spray_00001077 = 0x00001077,
		Mei_spray_00001168 = 0x00001168,

		Mercy_spray_00000195 = 0x00000195,
		Mercy_spray_00000196 = 0x00000196,
		Mercy_spray_00000197 = 0x00000197,
		Mercy_spray_00000198 = 0x00000198,
		Mercy_spray_00000199 = 0x00000199,
		Mercy_spray_0000019B = 0x0000019B,
		Mercy_spray_0000019D = 0x0000019D,
		Mercy_spray_0000019F = 0x0000019F,
		Mercy_spray_000001A0 = 0x000001A0,
		Mercy_spray_000001A2 = 0x000001A2,
		Mercy_spray_00000508 = 0x00000508,
		Mercy_spray_0000050C = 0x0000050C,
		Mercy_spray_0000050D = 0x0000050D,
		Mercy_spray_0000050E = 0x0000050E,
		Mercy_spray_00000513 = 0x00000513,
		Mercy_spray_00000514 = 0x00000514,
		Mercy_spray_00000515 = 0x00000515,
		Mercy_spray_00000517 = 0x00000517,
		Mercy_spray_00000518 = 0x00000518,
		Mercy_spray_00000519 = 0x00000519,
		Mercy_spray_0000051A = 0x0000051A,
		Mercy_spray_0000051F = 0x0000051F,
		Mercy_spray_00000520 = 0x00000520,
		Mercy_spray_00000D28 = 0x00000D28,
		Mercy_spray_00000EC4 = 0x00000EC4,
		Mercy_spray_00000EDB = 0x00000EDB,
		Mercy_spray_00001072 = 0x00001072,
		Mercy_spray_00001162 = 0x00001162,

		Orisa_spray_000010F1 = 0x000010F1,
		Orisa_spray_00001161 = 0x00001161,

		Pharah_spray_000007B2 = 0x000007B2,
		Pharah_spray_000007B3 = 0x000007B3,
		Pharah_spray_000007B4 = 0x000007B4,
		Pharah_spray_00000D37 = 0x00000D37,

		Reaper_spray_00000292 = 0x00000292,
		Reaper_spray_00000293 = 0x00000293,
		Reaper_spray_00000294 = 0x00000294,
		Reaper_spray_00000295 = 0x00000295,
		Reaper_spray_00000297 = 0x00000297,
		Reaper_spray_00000298 = 0x00000298,
		Reaper_spray_00000299 = 0x00000299,
		Reaper_spray_0000029A = 0x0000029A,
		Reaper_spray_0000029E = 0x0000029E,
		Reaper_spray_0000029F = 0x0000029F,
		Reaper_spray_00000749 = 0x00000749,
		Reaper_spray_0000074A = 0x0000074A,
		Reaper_spray_0000074B = 0x0000074B,
		Reaper_spray_0000074E = 0x0000074E,
		Reaper_spray_00000751 = 0x00000751,
		Reaper_spray_00000752 = 0x00000752,
		Reaper_spray_00000756 = 0x00000756,
		Reaper_spray_00000757 = 0x00000757,
		Reaper_spray_00000758 = 0x00000758,
		Reaper_spray_00000759 = 0x00000759,
		Reaper_spray_0000075A = 0x0000075A,
		Reaper_spray_0000075F = 0x0000075F,
		Reaper_spray_00000760 = 0x00000760,
		Reaper_spray_00000761 = 0x00000761,
		Reaper_spray_00000D35 = 0x00000D35,
		Reaper_spray_00000ECA = 0x00000ECA,
		Reaper_spray_00000EE8 = 0x00000EE8,
		Reaper_spray_00000EF1 = 0x00000EF1,
		Reaper_spray_00001082 = 0x00001082,
		Reaper_spray_0000116F = 0x0000116F,

		Reinhardt_spray_00000277 = 0x00000277,
		Reinhardt_spray_00000279 = 0x00000279,
		Reinhardt_spray_0000027C = 0x0000027C,
		Reinhardt_spray_0000027D = 0x0000027D,
		Reinhardt_spray_00000280 = 0x00000280,
		Reinhardt_spray_00000283 = 0x00000283,
		Reinhardt_spray_000006D7 = 0x000006D7,
		Reinhardt_spray_000006D8 = 0x000006D8,
		Reinhardt_spray_000006D9 = 0x000006D9,
		Reinhardt_spray_000006DA = 0x000006DA,
		Reinhardt_spray_000006DB = 0x000006DB,
		Reinhardt_spray_000006DC = 0x000006DC,
		Reinhardt_spray_000006DD = 0x000006DD,
		Reinhardt_spray_000006DF = 0x000006DF,
		Reinhardt_spray_000006EE = 0x000006EE,
		Reinhardt_spray_000006EF = 0x000006EF,
		Reinhardt_spray_00000C5A = 0x00000C5A,
		Reinhardt_spray_00001079 = 0x00001079,
		Reinhardt_spray_0000116C = 0x0000116C,

		Roadhog_spray_000002A0 = 0x000002A0,
		Roadhog_spray_000002A2 = 0x000002A2,
		Roadhog_spray_000002A4 = 0x000002A4,
		Roadhog_spray_000002A5 = 0x000002A5,
		Roadhog_spray_000002A6 = 0x000002A6,
		Roadhog_spray_000002A7 = 0x000002A7,
		Roadhog_spray_000002A8 = 0x000002A8,
		Roadhog_spray_000002A9 = 0x000002A9,
		Roadhog_spray_000002AB = 0x000002AB,
		Roadhog_spray_00000781 = 0x00000781,
		Roadhog_spray_00000785 = 0x00000785,
		Roadhog_spray_00000787 = 0x00000787,
		Roadhog_spray_00000788 = 0x00000788,
		Roadhog_spray_00000789 = 0x00000789,
		Roadhog_spray_0000078A = 0x0000078A,
		Roadhog_spray_0000078B = 0x0000078B,
		Roadhog_spray_0000078C = 0x0000078C,
		Roadhog_spray_00000792 = 0x00000792,
		Roadhog_spray_00000793 = 0x00000793,
		Roadhog_spray_00000794 = 0x00000794,
		Roadhog_spray_00000795 = 0x00000795,
		Roadhog_spray_00000D36 = 0x00000D36,
		Roadhog_spray_00000ED3 = 0x00000ED3,
		Roadhog_spray_00000EE9 = 0x00000EE9,
		Roadhog_spray_00000F6C = 0x00000F6C,
		Roadhog_spray_00001083 = 0x00001083,
		Roadhog_spray_00001170 = 0x00001170,

		Soldier76_spray_000002BC = 0x000002BC,
		Soldier76_spray_000002BD = 0x000002BD,
		Soldier76_spray_000002BE = 0x000002BE,
		Soldier76_spray_000002BF = 0x000002BF,
		Soldier76_spray_000002C0 = 0x000002C0,
		Soldier76_spray_000002C1 = 0x000002C1,
		Soldier76_spray_000002C2 = 0x000002C2,
		Soldier76_spray_000002C3 = 0x000002C3,
		Soldier76_spray_000002C4 = 0x000002C4,
		Soldier76_spray_000002C5 = 0x000002C5,
		Soldier76_spray_000002C7 = 0x000002C7,
		Soldier76_spray_000002C8 = 0x000002C8,
		Soldier76_spray_000002C9 = 0x000002C9,
		Soldier76_spray_000007DC = 0x000007DC,
		Soldier76_spray_000007DE = 0x000007DE,
		Soldier76_spray_000007DF = 0x000007DF,
		Soldier76_spray_000007E3 = 0x000007E3,
		Soldier76_spray_000007E4 = 0x000007E4,
		Soldier76_spray_000007E7 = 0x000007E7,
		Soldier76_spray_000007EE = 0x000007EE,
		Soldier76_spray_000007F1 = 0x000007F1,
		Soldier76_spray_00000B9C = 0x00000B9C,
		Soldier76_spray_00000C62 = 0x00000C62,
		Soldier76_spray_00000D1C = 0x00000D1C,
		Soldier76_spray_00000ED5 = 0x00000ED5,
		Soldier76_spray_00000EEB = 0x00000EEB,
		Soldier76_spray_0000107F = 0x0000107F,
		Soldier76_spray_00001172 = 0x00001172,

		Sombra_spray_00000A8F = 0x00000A8F,
		Sombra_spray_00000CC8 = 0x00000CC8,
		Sombra_spray_00000CCA = 0x00000CCA,
		Sombra_spray_00000CCB = 0x00000CCB,
		Sombra_spray_00000CCE = 0x00000CCE,
		Sombra_spray_00000CD2 = 0x00000CD2,
		Sombra_spray_00000CD4 = 0x00000CD4,
		Sombra_spray_00000CD7 = 0x00000CD7,
		Sombra_spray_00000CD8 = 0x00000CD8,
		Sombra_spray_00000CDA = 0x00000CDA,
		Sombra_spray_00000CDB = 0x00000CDB,
		Sombra_spray_00000CDC = 0x00000CDC,
		Sombra_spray_00000CDE = 0x00000CDE,
		Sombra_spray_00000CE1 = 0x00000CE1,
		Sombra_spray_00000CE2 = 0x00000CE2,
		Sombra_spray_00000CE3 = 0x00000CE3,
		Sombra_spray_00000ED9 = 0x00000ED9,
		Sombra_spray_0000107C = 0x0000107C,
		Sombra_spray_0000116A = 0x0000116A,

		Symmetra_spray_000001F8 = 0x000001F8,
		Symmetra_spray_000002DE = 0x000002DE,
		Symmetra_spray_000002DF = 0x000002DF,
		Symmetra_spray_000002E0 = 0x000002E0,
		Symmetra_spray_000002E2 = 0x000002E2,
		Symmetra_spray_000002E3 = 0x000002E3,
		Symmetra_spray_000002E7 = 0x000002E7,
		Symmetra_spray_00000816 = 0x00000816,
		Symmetra_spray_00000818 = 0x00000818,
		Symmetra_spray_00000819 = 0x00000819,
		Symmetra_spray_00000823 = 0x00000823,
		Symmetra_spray_00000824 = 0x00000824,
		Symmetra_spray_00000825 = 0x00000825,
		Symmetra_spray_00000826 = 0x00000826,
		Symmetra_spray_00000D1F = 0x00000D1F,
		Symmetra_spray_00000ED0 = 0x00000ED0,
		Symmetra_spray_00001081 = 0x00001081,
		Symmetra_spray_00001175 = 0x00001175,

		Torbjorn_spray_000001E9 = 0x000001E9,
		Torbjorn_spray_000001EA = 0x000001EA,
		Torbjorn_spray_000002F8 = 0x000002F8,
		Torbjorn_spray_000002FA = 0x000002FA,
		Torbjorn_spray_000002FB = 0x000002FB,
		Torbjorn_spray_000002FC = 0x000002FC,
		Torbjorn_spray_000002FE = 0x000002FE,
		Torbjorn_spray_000002FF = 0x000002FF,
		Torbjorn_spray_00000301 = 0x00000301,
		Torbjorn_spray_000006A7 = 0x000006A7,
		Torbjorn_spray_000006A8 = 0x000006A8,
		Torbjorn_spray_000006A9 = 0x000006A9,
		Torbjorn_spray_000006AB = 0x000006AB,
		Torbjorn_spray_000006AC = 0x000006AC,
		Torbjorn_spray_000006AD = 0x000006AD,
		Torbjorn_spray_000006AF = 0x000006AF,
		Torbjorn_spray_000006BB = 0x000006BB,
		Torbjorn_spray_000006BC = 0x000006BC,
		Torbjorn_spray_000006BD = 0x000006BD,
		Torbjorn_spray_000006BE = 0x000006BE,
		Torbjorn_spray_000006BF = 0x000006BF,
		Torbjorn_spray_00000D15 = 0x00000D15,
		Torbjorn_spray_00000ECE = 0x00000ECE,
		Torbjorn_spray_00000EE4 = 0x00000EE4,
		Torbjorn_spray_00001091 = 0x00001091,
		Torbjorn_spray_0000116B = 0x0000116B,

		Tracer_spray_00000872 = 0x00000872,

		Widowmaker_spray_000002E8 = 0x000002E8,
		Widowmaker_spray_000002EA = 0x000002EA,
		Widowmaker_spray_000002EC = 0x000002EC,
		Widowmaker_spray_000002EE = 0x000002EE,
		Widowmaker_spray_000002EF = 0x000002EF,
		Widowmaker_spray_000002F0 = 0x000002F0,
		Widowmaker_spray_000002F1 = 0x000002F1,
		Widowmaker_spray_000002F2 = 0x000002F2,
		Widowmaker_spray_000002F3 = 0x000002F3,
		Widowmaker_spray_00000683 = 0x00000683,
		Widowmaker_spray_00000685 = 0x00000685,
		Widowmaker_spray_00000687 = 0x00000687,
		Widowmaker_spray_00000688 = 0x00000688,
		Widowmaker_spray_00000689 = 0x00000689,
		Widowmaker_spray_0000068A = 0x0000068A,
		Widowmaker_spray_00000693 = 0x00000693,
		Widowmaker_spray_00000695 = 0x00000695,
		Widowmaker_spray_00000696 = 0x00000696,
		Widowmaker_spray_00000697 = 0x00000697,
		Widowmaker_spray_00000698 = 0x00000698,
		Widowmaker_spray_00000699 = 0x00000699,
		Widowmaker_spray_000008E1 = 0x000008E1,
		Widowmaker_spray_00000BDD = 0x00000BDD,
		Widowmaker_spray_00000C65 = 0x00000C65,
		Widowmaker_spray_00000D23 = 0x00000D23,
		Widowmaker_spray_00000D3F = 0x00000D3F,
		Widowmaker_spray_00000ECB = 0x00000ECB,
		Widowmaker_spray_00000EF0 = 0x00000EF0,
		Widowmaker_spray_00000F6F = 0x00000F6F,
		Widowmaker_spray_0000107D = 0x0000107D,
		Widowmaker_spray_00001177 = 0x00001177,
		Widowmaker_spray_000002F4 = 0x000002F4,

		Winston_spray_000001F5 = 0x000001F5,
		Winston_spray_0000084C = 0x0000084C,
		Winston_spray_00000859 = 0x00000859,
		Winston_spray_00001173 = 0x00001173,

		Zarya_spray_000001D7 = 0x000001D7,
		Zarya_spray_00000287 = 0x00000287,
		Zarya_spray_00000288 = 0x00000288,
		Zarya_spray_0000028C = 0x0000028C,
		Zarya_spray_00000709 = 0x00000709,
		Zarya_spray_00000D18 = 0x00000D18,
		Zarya_spray_00000EE7 = 0x00000EE7,
		Zarya_spray_0000107B = 0x0000107B,
		Zarya_spray_0000116E = 0x0000116E,

		Zenyatta_spray_0000058F = 0x0000058F,
		Zenyatta_spray_00000596 = 0x00000596,
		Zenyatta_spray_00000D10 = 0x00000D10,
	};
}
