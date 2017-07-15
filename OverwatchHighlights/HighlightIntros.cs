namespace OverwatchHighlights
{
	// https://blzgdapipro-a.akamaihd.net/game/unlocks/0x02500000XXXXXXXX.png
	enum HighlightIntro : uint
	{
		None                         = 0x00000000, // used by AI players

		Junkrat_RipTire              = 0x0000014D,
		Junkrat_Unfortunate          = 0x0000014E,
		Junkrat_ImFlying             = 0x0000014F,
		Mei_Frosty                   = 0x00000157,
		Junkrat_Heroic               = 0x0000022A,
		Mei_Heroic                   = 0x0000022D,
		Junkrat_Random               = 0x0000023D, // I think?
		Widowmaker_UnderTheMistletoe = 0x00000D43,
		Doomfist_Heroic              = 0x00001198,
		Doomfist_Random              = 0x00001199,

		// -- anything below here is known to exist but i've not mapped the value to a name yet --
		Ana_intro00 = 0x00000A5A,
		Ana_intro01 = 0x00000A7A,
		Ana_intro02 = 0x00000A7B,
		Ana_intro03 = 0x00000A7D,

		Bastion_intro00 = 0x0000013B,
		Bastion_intro01 = 0x00000224,

		DVa_intro00 = 0x00000153,
		DVa_intro01 = 0x00000154,
		DVa_intro02 = 0x00000155,
		DVa_intro03 = 0x0000022C,
		DVa_intro04 = 0x0000104B,

		Genji_intro00 = 0x00000150,
		Genji_intro01 = 0x00000151,
		Genji_intro02 = 0x00000152,
		Genji_intro03 = 0x0000022B,
		Genji_intro04 = 0x0000023E,
		Genji_intro05 = 0x00000C43,

		Hanzo_intro00 = 0x0000012C,
		Hanzo_intro01 = 0x0000012D,
		Hanzo_intro02 = 0x0000012E,
		Hanzo_intro03 = 0x0000021F,
		Hanzo_intro04 = 0x00000232,

		Lucio_intro00 = 0x00000147,
		Lucio_intro01 = 0x00000148,
		Lucio_intro02 = 0x00000228,

		McCree_intro00 = 0x0000013E,
		McCree_intro01 = 0x0000013F,
		McCree_intro02 = 0x00000140,
		McCree_intro03 = 0x00000225,
		McCree_intro04 = 0x00000238,

		Mei_intro00 = 0x00000156,
		Mei_intro01 = 0x00000C38,

		Mercy_intro00 = 0x00000126,
		Mercy_intro01 = 0x00000127,
		Mercy_intro02 = 0x00000128,
		Mercy_intro03 = 0x00000219,
		Mercy_intro04 = 0x00000EAE,

		Orisa_intro00 = 0x00000F65,

		Pharah_intro00 = 0x00000084,
		Pharah_intro01 = 0x00000085,
		Pharah_intro02 = 0x0000021D,

		Reaper_intro00 = 0x0000005B,
		Reaper_intro01 = 0x0000005C,
		Reaper_intro02 = 0x0000005D,
		Reaper_intro03 = 0x0000021B,

		Reinhardt_intro00 = 0x00000087,
		Reinhardt_intro01 = 0x00000088,
		Reinhardt_intro02 = 0x00000089,
		Reinhardt_intro03 = 0x0000021E,

		Roadhog_intro00 = 0x0000014B,
		Roadhog_intro01 = 0x0000014C,
		Roadhog_intro02 = 0x00000229,
		Roadhog_intro03 = 0x00000EAD,

		Soldier76_intro00 = 0x00000144,
		Soldier76_intro01 = 0x00000145,
		Soldier76_intro02 = 0x00000146,
		Soldier76_intro03 = 0x00000227, // probably heroic
		Soldier76_intro04 = 0x0000023A,

		Sombra_intro00 = 0x00000AFB,
		Sombra_intro01 = 0x00000AFC,
		Sombra_intro02 = 0x00000B0D,
		Sombra_intro03 = 0x00000CC1,

		Symmetra_intro00 = 0x00000138,
		Symmetra_intro01 = 0x00000223,

		Torbjorn_intro00 = 0x0000012F,
		Torbjorn_intro01 = 0x00000131,
		Torbjorn_intro02 = 0x00000220,
		Torbjorn_intro03 = 0x0000104A,

		Tracer_intro00 = 0x00000051,
		Tracer_intro01 = 0x00000052,
		Tracer_intro02 = 0x00000053,
		Tracer_intro03 = 0x000001FB,
		Tracer_intro04 = 0x000001FC,
		Tracer_intro05 = 0x00000E4F,

		Widowmaker_intro00 = 0x00000129,
		Widowmaker_intro01 = 0x0000012A,
		Widowmaker_intro02 = 0x0000012B,
		Widowmaker_intro03 = 0x0000021C,

		Winston_intro00 = 0x00000132,
		Winston_intro01 = 0x00000134,
		Winston_intro02 = 0x00000221,

		Zarya_intro00 = 0x00000143,
		Zarya_intro01 = 0x00000226,

		Zenyatta_intro00 = 0x00000135,
		Zenyatta_intro01 = 0x00000222,
		Zenyatta_intro02 = 0x00001060,
	};
}
