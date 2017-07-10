﻿namespace OverwatchHighlights
{
	enum WeaponSkin : uint
	{
		McCree_Classic                     = 0x00001ED5,
		Zenyatta_Ifrit                     = 0x00001EDF,
		Zenyatta_Sunyatta                  = 0x00001EE7,
		Zenyatta_Classic                   = 0x00001EED,
		Junkrat_Irradiated                 = 0x00001EF9,
		Lucio_Classic                      = 0x00001EFD,
		Doomfist_Classic                   = 0x00001F05,
		Doomfist_Classic_Golden            = 0x00001F06,
		Mei_Classic                        = 0x00001F25,
		Bastion_Classic                    = 0x00001F35,
		Sombra_Classic                     = 0x00001F3D,
		Zarya_Classic                      = 0x00001FBD,
		Roadhog_Classic                    = 0x0000202D,
		Soldier76_StrikeCommanderMorrison  = 0x0000206D,
		Soldier76_Classic                  = 0x00002075,
		Genji_Classic                      = 0x00002095,
		Widowmaker_Odette                  = 0x0000210F,
		Widowmaker_Odette_Golden           = 0x00002110,
		Widowmaker_Ciel                    = 0x0000211F,
		Junkrat_Hayseed                    = 0x000021DF,
		Genji_Sparrow                      = 0x000021EF,
		Genji_Sparrow_Golden               = 0x000021F0,
		Zenyatta_Ascendant                 = 0x00002453,
		Sombra_Virus                       = 0x0000247F,
		Genji_CarbonFiber                  = 0x000024B3,
		Genji_CarbonFiber_Golden           = 0x000024B4,
		Mei_YetiHunter                     = 0x00002505,
		Ana_Classic                        = 0x00002519,
		Pharah_Anubis                      = 0x00002527,
		Sombra_LosMuertos                  = 0x000025EB,
		Sombra_LosMuertos_Golden           = 0x000025EC,
		Sombra_Azucar                      = 0x000025ED,
		Sombra_Cyberspace                  = 0x000025EF,
		Sombra_Cyberspace_Golden           = 0x000025F0,
		Tracer_Rose                        = 0x000028E2,
		Mercy_CombatMedicZiegler           = 0x000029CA,

		// -- anything below here is known to exist but i've not mapped the value to a name yet --
		Ana_weapon00 = 0x00002525,
		Ana_weapon01 = 0x0000256D,
		Ana_weapon02 = 0x00002577,
		Ana_weapon03 = 0x0000260D,

		Bastion_weapon00 = 0x00001F36,
		Bastion_weapon01 = 0x00001F39,
		Bastion_weapon02 = 0x0000220F,
		Bastion_weapon03 = 0x00002217,

		DVa_weapon00 = 0x00001F0D,
	    DVa_weapon01 = 0x000021AD,
		DVa_weapon02 = 0x000021AE,
		DVa_weapon03 = 0x000021AF,
		DVa_weapon04 = 0x00002225,
		DVa_weapon05 = 0x00002227,
		DVa_weapon06 = 0x0000246B,
		DVa_weapon07 = 0x0000246D,
		DVa_weapon08 = 0x00002708,
		DVa_weapon09 = 0x00002A34,
		
		Genji_weapon00 = 0x000021EF,
		Genji_weapon02 = 0x000021F5,
		Genji_weapon03 = 0x000024B5,
		Genji_weapon04 = 0x000025FF,
		Genji_weapon05 = 0x000029CE,
		Genji_weapon06 = 0x000029CF,

		Hanzo_weapon00 = 0x00001EAD,
		Hanzo_weapon01 = 0x00001EAF,
		Hanzo_weapon02 = 0x00001EB0,
		Hanzo_weapon03 = 0x00001EB5,
		Hanzo_weapon04 = 0x00001EB7,
		Hanzo_weapon05 = 0x00001EBD,
		Hanzo_weapon06 = 0x00001EBF,
		Hanzo_weapon07 = 0x00001EC3,
		Hanzo_weapon08 = 0x00002447,

		Junkrat_weapon00 = 0x00001EF5,
		Junkrat_weapon01 = 0x00001EFB,
		Junkrat_weapon02 = 0x000021DD,
		Junkrat_weapon03 = 0x0000221D,
		Junkrat_weapon04 = 0x0000221F,

		Lucio_weapon01 = 0x00001F01,
		Lucio_weapon02 = 0x000021D5,
		Lucio_weapon03 = 0x0000245F,
		Lucio_weapon04 = 0x00002461,
		Lucio_weapon05 = 0x000024FF,
		Lucio_weapon06 = 0x000026EC,
		Lucio_weapon07 = 0x000026ED,

		McCree_weapon00 = 0x00001EC5,
		McCree_weapon01 = 0x00001EC7,
		McCree_weapon02 = 0x00001ECD,
		McCree_weapon03 = 0x00001ECE,
		McCree_weapon04 = 0x00001ECF,
		McCree_weapon05 = 0x00001ED0,
		McCree_weapon06 = 0x00001EDB,
		McCree_weapon07 = 0x0000244B,
		McCree_weapon08 = 0x0000244D,
		McCree_weapon09 = 0x00002646,
		McCree_weapon10 = 0x00002647,
		McCree_weapon11 = 0x000026FA,

		Mei_weapon01 = 0x0000222F,
		Mei_weapon02 = 0x00002473,
		Mei_weapon03 = 0x000025D9,
		Mei_weapon04 = 0x000025DB,

		Mercy_weapon00 = 0x00001E8D,
		Mercy_weapon01 = 0x00001E8F,
		Mercy_weapon02 = 0x00001E9D,
		Mercy_weapon03 = 0x00001E9F,
		Mercy_weapon04 = 0x00002439,
		Mercy_weapon05 = 0x000025AB,
		Mercy_weapon06 = 0x00002728,

		Orisa_weapon00 = 0x0000253D,
		Orisa_weapon01 = 0x0000253F,
		Orisa_weapon02 = 0x00002996,

		Pharah_weapon00 = 0x00002035,
		Pharah_weapon01 = 0x00002065,
		Pharah_weapon02 = 0x000021B7,
		Pharah_weapon03 = 0x00002529,
		Pharah_weapon04 = 0x0000252B,
		Pharah_weapon05 = 0x0000252D,

		Reaper_weapon00 = 0x00001FDD,
		Reaper_weapon01 = 0x00001FFD,
		Reaper_weapon02 = 0x00002015,
		Reaper_weapon03 = 0x00002017,
		Reaper_weapon04 = 0x00002493,
		Reaper_weapon05 = 0x00002495,
		Reaper_weapon06 = 0x00002497,
		Reaper_weapon07 = 0x000026E4,

		Reinhardt_weapon00 = 0x00001F5D,
		Reinhardt_weapon01 = 0x00001F65,
		Reinhardt_weapon02 = 0x00001FA5,
		Reinhardt_weapon03 = 0x000029E2,

		Roadhog_weapon00 = 0x0000201D,
		Roadhog_weapon01 = 0x00002027,
		Roadhog_weapon02 = 0x00002031,
		Roadhog_weapon03 = 0x00002033,
		Roadhog_weapon04 = 0x000025D1,
		Roadhog_weapon05 = 0x000026FE,

		Soldier76_weapon01 = 0x0000207B,
		Soldier76_weapon02 = 0x000021FD,
		Soldier76_weapon03 = 0x000021FF,
		Soldier76_weapon04 = 0x00002207,
		Soldier76_weapon05 = 0x000024A5,
		Soldier76_weapon06 = 0x000024A7,
		Soldier76_weapon07 = 0x000024A9,
		Soldier76_weapon08 = 0x00002621,

		Sombra_weapon00 = 0x00001F41,
		Sombra_weapon01 = 0x0000247B,
		Sombra_weapon02 = 0x00002710,

		Symmetra_weapon00 = 0x000020B5,
		Symmetra_weapon01 = 0x000020B9,

		Torbjorn_weapon00 = 0x00001F4D,
		Torbjorn_weapon01 = 0x00001F4F,
		Torbjorn_weapon02 = 0x00002481,
		Torbjorn_weapon03 = 0x00002483,
		Torbjorn_weapon04 = 0x00002994,
		Torbjorn_weapon05 = 0x00002A2E,

		Tracer_weapon00 = 0x000020BD,
		Tracer_weapon01 = 0x000020FD,
		Tracer_weapon02 = 0x00002105,
		Tracer_weapon03 = 0x000024C1,
		Tracer_weapon04 = 0x0000255B,
		Tracer_weapon05 = 0x00002593,
		Tracer_weapon06 = 0x000029A0,
		Tracer_weapon07 = 0x000029A1,

		Widowmaker_weapon00 = 0x0000210D,
		Widowmaker_weapon01 = 0x00002115,
		Widowmaker_weapon02 = 0x0000211D,
		Widowmaker_weapon03 = 0x00002123,
		Widowmaker_weapon04 = 0x000024C3,
		Widowmaker_weapon05 = 0x000024C5,
		Widowmaker_weapon06 = 0x000024C7,
		Widowmaker_weapon07 = 0x0000250F,
		Widowmaker_weapon08 = 0x00002A32,

		Winston_weapon00 = 0x0000207F,
		Winston_weapon01 = 0x00002085,
		Winston_weapon02 = 0x00002087,
		Winston_weapon03 = 0x0000208D,
		Winston_weapon04 = 0x0000208F,
		Winston_weapon05 = 0x00002093,
		Winston_weapon06 = 0x000024AF,

		Zarya_weapon00 = 0x00001FB5,
		Zarya_weapon01 = 0x0000248D,
		Zarya_weapon02 = 0x00002560,
		Zarya_weapon03 = 0x0000270C,

		Zenyatta_weapon00 = 0x00001EE5,
		Zenyatta_weapon01 = 0x000025A3,
	}
}
