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
		Ana_intro_00000A5A = 0x00000A5A,
		Ana_intro_00000A5B = 0x00000A5B,
		Ana_intro_00000A7A = 0x00000A7A,
		Ana_intro_00000A7B = 0x00000A7B,
		Ana_intro_00000A7D = 0x00000A7D,

		Bastion_intro_0000013B = 0x0000013B,
		Bastion_intro_0000013D = 0x0000013D,
		Bastion_intro_00000224 = 0x00000224,

		DVa_intro_00000153 = 0x00000153,
		DVa_intro_00000154 = 0x00000154,
		DVa_intro_00000155 = 0x00000155,
		DVa_intro_0000022C = 0x0000022C,
		DVa_intro_0000023F = 0x0000023F,
		DVa_intro_0000104B = 0x0000104B,

		Genji_intro_00000150 = 0x00000150,
		Genji_intro_00000151 = 0x00000151,
		Genji_intro_00000152 = 0x00000152,
		Genji_intro_0000022B = 0x0000022B,
		Genji_intro_0000023E = 0x0000023E,
		Genji_intro_00000C43 = 0x00000C43,

		Hanzo_intro_0000012C = 0x0000012C,
		Hanzo_intro_0000012D = 0x0000012D,
		Hanzo_intro_0000012E = 0x0000012E,
		Hanzo_intro_0000021F = 0x0000021F,
		Hanzo_intro_00000232 = 0x00000232,

		Lucio_intro_00000147 = 0x00000147,
		Lucio_intro_00000148 = 0x00000148,
		Lucio_intro_00000228 = 0x00000228,

		McCree_intro_0000013E = 0x0000013E,
		McCree_intro_0000013F = 0x0000013F,
		McCree_intro_00000140 = 0x00000140,
		McCree_intro_00000225 = 0x00000225,
		McCree_intro_00000238 = 0x00000238,

		Mei_intro_00000156 = 0x00000156,
		Mei_intro_00000158 = 0x00000158,
		Mei_intro_00000C38 = 0x00000C38,

		Mercy_intro_00000126 = 0x00000126,
		Mercy_intro_00000127 = 0x00000127,
		Mercy_intro_00000128 = 0x00000128,
		Mercy_intro_00000219 = 0x00000219,
		Mercy_intro_00000EAE = 0x00000EAE,

		Orisa_intro_00000F65 = 0x00000F65,
		Orisa_intro_00000F90 = 0x00000F90,
		Orisa_intro_00000FF2 = 0x00000FF2,

		Pharah_intro_00000083 = 0x00000083,
		Pharah_intro_00000084 = 0x00000084,
		Pharah_intro_00000085 = 0x00000085,
		Pharah_intro_0000021D = 0x0000021D,

		Reaper_intro_0000005B = 0x0000005B,
		Reaper_intro_0000005C = 0x0000005C,
		Reaper_intro_0000005D = 0x0000005D,
		Reaper_intro_0000021B = 0x0000021B,

		Reinhardt_intro_00000087 = 0x00000087,
		Reinhardt_intro_00000088 = 0x00000088,
		Reinhardt_intro_00000089 = 0x00000089,
		Reinhardt_intro_0000021E = 0x0000021E,

		Roadhog_intro_0000014A = 0x0000014A,
		Roadhog_intro_0000014B = 0x0000014B,
		Roadhog_intro_0000014C = 0x0000014C,
		Roadhog_intro_00000229 = 0x00000229,
		Roadhog_intro_00000EAD = 0x00000EAD,

		Soldier76_intro_00000144 = 0x00000144,
		Soldier76_intro_00000145 = 0x00000145,
		Soldier76_intro_00000146 = 0x00000146,
		Soldier76_intro_00000227 = 0x00000227, // probably heroic
		Soldier76_intro_0000023A = 0x0000023A,

		Sombra_intro_00000AFB = 0x00000AFB,
		Sombra_intro_00000AFC = 0x00000AFC,
		Sombra_intro_00000B0D = 0x00000B0D,
		Sombra_intro_00000B0F = 0x00000B0F,
		Sombra_intro_00000CC1 = 0x00000CC1,

		Symmetra_intro_00000138 = 0x00000138,
		Symmetra_intro_0000013A = 0x0000013A,
		Symmetra_intro_00000223 = 0x00000223,
		Symmetra_intro_00000D4D = 0x00000D4D,

		Torbjorn_intro_0000012F = 0x0000012F,
		Torbjorn_intro_00000131 = 0x00000131,
		Torbjorn_intro_00000220 = 0x00000220,
		Torbjorn_intro_0000104A = 0x0000104A,

		Tracer_intro_00000051 = 0x00000051,
		Tracer_intro_00000052 = 0x00000052,
		Tracer_intro_00000053 = 0x00000053,
		Tracer_intro_000001FB = 0x000001FB,
		Tracer_intro_000001FC = 0x000001FC,
		Tracer_intro_00000E4F = 0x00000E4F,

		Widowmaker_intro_00000129 = 0x00000129,
		Widowmaker_intro_0000012A = 0x0000012A,
		Widowmaker_intro_0000012B = 0x0000012B,
		Widowmaker_intro_0000021C = 0x0000021C,
		Widowmaker_intro_0000022F = 0x0000022F,

		Winston_intro_00000132 = 0x00000132,
		Winston_intro_00000133 = 0x00000133,
		Winston_intro_00000134 = 0x00000134,
		Winston_intro_00000221 = 0x00000221,
		
		Zarya_intro_00000143 = 0x00000143,
		Zarya_intro_00000226 = 0x00000226,

		Zenyatta_intro_00000135 = 0x00000135,
		Zenyatta_intro_00000136 = 0x00000136,
		Zenyatta_intro_00000222 = 0x00000222,
		Zenyatta_intro_00000235 = 0x00000235,
		Zenyatta_intro_00001060 = 0x00001060,
	};
}
