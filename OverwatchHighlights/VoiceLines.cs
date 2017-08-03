﻿namespace OverwatchHighlights
{
	enum VoiceLine : uint
	{
		Junkrat_TickTockTickTock        = 0x000008CC,
		Pharah_LeaveThisToAProfessional = 0x00000A10,
		Doomfist_TryMe                  = 0x0000119A,

		// -- anything below here is known to exist but i've not mapped the value to a name yet --
		Ana_voiceline_00000A5C = 0x00000A5C,
		Ana_voiceline_00000A5D = 0x00000A5D,
		Ana_voiceline_00000A5E = 0x00000A5E,
		Ana_voiceline_00000A5F = 0x00000A5F,
		Ana_voiceline_00000A60 = 0x00000A60,
		Ana_voiceline_00000A61 = 0x00000A61,
		Ana_voiceline_00000A62 = 0x00000A62,
		Ana_voiceline_00000A63 = 0x00000A63,
		Ana_voiceline_00000A64 = 0x00000A64,
		Ana_voiceline_00000A65 = 0x00000A65,
		Ana_voiceline_00000A66 = 0x00000A66,
		Ana_voiceline_00000BC7 = 0x00000BC7,
		Ana_voiceline_00000C91 = 0x00000C91,
		Ana_voiceline_00000D7E = 0x00000D7E,
		Ana_voiceline_00000E93 = 0x00000E93,
		Ana_voiceline_000010C1 = 0x000010C1,
		Ana_voiceline_000010C2 = 0x000010C2,
		Ana_voiceline_000010FB = 0x000010FB,
		Ana_voiceline_000010FC = 0x000010FC,

		Bastion_voiceline_00000619 = 0x00000619,
		Bastion_voiceline_0000061A = 0x0000061A,
		Bastion_voiceline_0000061C = 0x0000061C,
		Bastion_voiceline_0000061E = 0x0000061E,
		Bastion_voiceline_0000061F = 0x0000061F,
		Bastion_voiceline_00000620 = 0x00000620,
		Bastion_voiceline_00000622 = 0x00000622,
		Bastion_voiceline_000008D0 = 0x000008D0,
		Bastion_voiceline_00000A40 = 0x00000A40,
		Bastion_voiceline_000010F5 = 0x000010F5,
		Bastion_voiceline_0000110D = 0x0000110D,
		Bastion_voiceline_0000110E = 0x0000110E,

		Doomfist_voiceline_0000119E = 0x0000119E,
		Doomfist_voiceline_000011A0 = 0x000011A0,
		Doomfist_voiceline_000011A1 = 0x000011A1,
		Doomfist_voiceline_000011A2 = 0x000011A2,
		Doomfist_voiceline_000011A3 = 0x000011A3,
		Doomfist_voiceline_000011A4 = 0x000011A4,
		Doomfist_voiceline_000011A5 = 0x000011A5,
		Doomfist_voiceline_000011A6 = 0x000011A6,
		Doomfist_voiceline_000011A7 = 0x000011A7,

		DVa_voiceline_00000679 = 0x00000679,
		DVa_voiceline_0000067A = 0x0000067A,
		DVa_voiceline_0000067D = 0x0000067D,
		DVa_voiceline_0000067E = 0x0000067E,
		DVa_voiceline_0000067F = 0x0000067F,
		DVa_voiceline_00000680 = 0x00000680,
		DVa_voiceline_00000681 = 0x00000681,
		DVa_voiceline_000008CE = 0x000008CE,
		DVa_voiceline_00000A3A = 0x00000A3A,
		DVa_voiceline_00000A3B = 0x00000A3B,
		DVa_voiceline_00000A3C = 0x00000A3C,
		DVa_voiceline_00000D8A = 0x00000D8A,
		DVa_voiceline_000010C3 = 0x000010C3,
		DVa_voiceline_000010C4 = 0x000010C4,
		DVa_voiceline_00001115 = 0x00001115,
		DVa_voiceline_00001116 = 0x00001116,

		Genji_voiceline_0000076D = 0x0000076D,
		Genji_voiceline_0000076E = 0x0000076E,
		Genji_voiceline_0000076F = 0x0000076F,
		Genji_voiceline_00000771 = 0x00000771,
		Genji_voiceline_00000772 = 0x00000772,
		Genji_voiceline_00000774 = 0x00000774,
		Genji_voiceline_000008D9 = 0x000008D9,
		Genji_voiceline_00000A1B = 0x00000A1B,
		Genji_voiceline_00000A1C = 0x00000A1C,
		Genji_voiceline_00000A1D = 0x00000A1D,
		Genji_voiceline_00000A1E = 0x00000A1E,
		Genji_voiceline_00000BD9 = 0x00000BD9,
		Genji_voiceline_00000CA5 = 0x00000CA5,
		Genji_voiceline_00000D91 = 0x00000D91,
		Genji_voiceline_00000F5B = 0x00000F5B,
		Genji_voiceline_000010C5 = 0x000010C5,
		Genji_voiceline_000010C6 = 0x000010C6,
		Genji_voiceline_00001123 = 0x00001123,
		Genji_voiceline_00001124 = 0x00001124,

		Hanzo_voiceline_00000521 = 0x00000521,
		Hanzo_voiceline_00000544 = 0x00000544,
		Hanzo_voiceline_00000545 = 0x00000545,
		Hanzo_voiceline_00000546 = 0x00000546,
		Hanzo_voiceline_00000548 = 0x00000548,
		Hanzo_voiceline_00000549 = 0x00000549,
		Hanzo_voiceline_0000054A = 0x0000054A,
		Hanzo_voiceline_0000054B = 0x0000054B,
		Hanzo_voiceline_000008C9 = 0x000008C9,
		Hanzo_voiceline_00000A2D = 0x00000A2D,
		Hanzo_voiceline_00000A2E = 0x00000A2E,
		Hanzo_voiceline_00000C93 = 0x00000C93,
		Hanzo_voiceline_00000D80 = 0x00000D80,
		Hanzo_voiceline_00000E95 = 0x00000E95,
		Hanzo_voiceline_000010C7 = 0x000010C7,
		Hanzo_voiceline_000010C8 = 0x000010C8,
		Hanzo_voiceline_00001101 = 0x00001101,
		Hanzo_voiceline_00001102 = 0x00001102,

		Junkrat_voiceline_000005C3 = 0x000005C3,
		Junkrat_voiceline_000005C4 = 0x000005C4,
		Junkrat_voiceline_000005C5 = 0x000005C5,
		Junkrat_voiceline_000005C7 = 0x000005C7,
		Junkrat_voiceline_000005C8 = 0x000005C8,
		Junkrat_voiceline_000005C9 = 0x000005C9,
		Junkrat_voiceline_000005CA = 0x000005CA,
		Junkrat_voiceline_000005CB = 0x000005CB,
		Junkrat_voiceline_00000A09 = 0x00000A09,
		Junkrat_voiceline_00000A0A = 0x00000A0A,
		Junkrat_voiceline_00000BCC = 0x00000BCC,
		Junkrat_voiceline_00000C96 = 0x00000C96,
		Junkrat_voiceline_00000D83 = 0x00000D83,
		Junkrat_voiceline_000010C9 = 0x000010C9,
		Junkrat_voiceline_000010CA = 0x000010CA,
		Junkrat_voiceline_00001107 = 0x00001107,
		Junkrat_voiceline_00001108 = 0x00001108,

		Lucio_voiceline_000005F2 = 0x000005F2,
		Lucio_voiceline_000005F3 = 0x000005F3,
		Lucio_voiceline_000005F4 = 0x000005F4,
		Lucio_voiceline_000005F6 = 0x000005F6,
		Lucio_voiceline_000005F7 = 0x000005F7,
		Lucio_voiceline_000008CD = 0x000008CD,
		Lucio_voiceline_00000A0B = 0x00000A0B,
		Lucio_voiceline_00000A0C = 0x00000A0C,
		Lucio_voiceline_00000A0D = 0x00000A0D,
		Lucio_voiceline_00000A0E = 0x00000A0E,
		Lucio_voiceline_00000A0F = 0x00000A0F,
		Lucio_voiceline_00000BCD = 0x00000BCD,
		Lucio_voiceline_00000C97 = 0x00000C97,
		Lucio_voiceline_00000D84 = 0x00000D84,
		Lucio_voiceline_00000F4E = 0x00000F4E,
		Lucio_voiceline_000010CB = 0x000010CB,
		Lucio_voiceline_000010CC = 0x000010CC,
		Lucio_voiceline_00001109 = 0x00001109,
		Lucio_voiceline_0000110A = 0x0000110A,

		McCree_voiceline_0000056D = 0x0000056D,
		McCree_voiceline_0000056F = 0x0000056F,
		McCree_voiceline_00000570 = 0x00000570,
		McCree_voiceline_00000572 = 0x00000572,
		McCree_voiceline_00000573 = 0x00000573,
		McCree_voiceline_00000574 = 0x00000574,
		McCree_voiceline_00000575 = 0x00000575,
		McCree_voiceline_00000576 = 0x00000576,
		McCree_voiceline_000008CA = 0x000008CA,
		McCree_voiceline_00000A3D = 0x00000A3D,
		McCree_voiceline_00000A3E = 0x00000A3E,
		McCree_voiceline_00000BCA = 0x00000BCA,
		McCree_voiceline_00000D81 = 0x00000D81,
		McCree_voiceline_00000E96 = 0x00000E96,
		McCree_voiceline_000010CD = 0x000010CD,
		McCree_voiceline_000010CE = 0x000010CE,
		McCree_voiceline_00001103 = 0x00001103,
		McCree_voiceline_00001104 = 0x00001104,

		Mei_voiceline_00000646 = 0x00000646,
		Mei_voiceline_0000064A = 0x0000064A,
		Mei_voiceline_0000064B = 0x0000064B,
		Mei_voiceline_0000064C = 0x0000064C,
		Mei_voiceline_0000064D = 0x0000064D,
		Mei_voiceline_000008CF = 0x000008CF,
		Mei_voiceline_00000A35 = 0x00000A35,
		Mei_voiceline_00000A36 = 0x00000A36,
		Mei_voiceline_00000A37 = 0x00000A37,
		Mei_voiceline_00000A38 = 0x00000A38,
		Mei_voiceline_00000A39 = 0x00000A39,
		Mei_voiceline_00000D85 = 0x00000D85,
		Mei_voiceline_00000F4F = 0x00000F4F,
		Mei_voiceline_000010CF = 0x000010CF,
		Mei_voiceline_000010D0 = 0x000010D0,
		Mei_voiceline_0000110B = 0x0000110B,
		Mei_voiceline_0000110C = 0x0000110C,

		Mercy_voiceline_000004FE = 0x000004FE,
		Mercy_voiceline_00000501 = 0x00000501,
		Mercy_voiceline_00000502 = 0x00000502,
		Mercy_voiceline_00000504 = 0x00000504,
		Mercy_voiceline_00000506 = 0x00000506,
		Mercy_voiceline_00000507 = 0x00000507,
		Mercy_voiceline_000008C8 = 0x000008C8,
		Mercy_voiceline_00000A05 = 0x00000A05,
		Mercy_voiceline_00000A06 = 0x00000A06,
		Mercy_voiceline_00000A07 = 0x00000A07,
		Mercy_voiceline_00000A08 = 0x00000A08,
		Mercy_voiceline_00000C92 = 0x00000C92,
		Mercy_voiceline_00000D7F = 0x00000D7F,
		Mercy_voiceline_00000E94 = 0x00000E94,
		Mercy_voiceline_000010D1 = 0x000010D1,
		Mercy_voiceline_000010D2 = 0x000010D2,
		Mercy_voiceline_000010FF = 0x000010FF,
		Mercy_voiceline_00001100 = 0x00001100,

		Orisa_voiceline_00000F66 = 0x00000F66,
		Orisa_voiceline_0000103F = 0x0000103F,
		Orisa_voiceline_00001040 = 0x00001040,
		Orisa_voiceline_00001041 = 0x00001041,
		Orisa_voiceline_00001042 = 0x00001042,
		Orisa_voiceline_00001043 = 0x00001043,
		Orisa_voiceline_00001044 = 0x00001044,
		Orisa_voiceline_00001045 = 0x00001045,
		Orisa_voiceline_00001046 = 0x00001046,
		Orisa_voiceline_00001047 = 0x00001047,
		Orisa_voiceline_000010D4 = 0x000010D4,

		Pharah_voiceline_000007C2 = 0x000007C2,
		Pharah_voiceline_000007C5 = 0x000007C5,
		Pharah_voiceline_000007C8 = 0x000007C8,
		Pharah_voiceline_000007C9 = 0x000007C9,
		Pharah_voiceline_000007CA = 0x000007CA,
		Pharah_voiceline_000007CB = 0x000007CB,
		Pharah_voiceline_000008D6 = 0x000008D6,
		Pharah_voiceline_00000A11 = 0x00000A11,
		Pharah_voiceline_00000A12 = 0x00000A12,
		Pharah_voiceline_00000CA2 = 0x00000CA2,
		Pharah_voiceline_00000D8E = 0x00000D8E,
		Pharah_voiceline_000010D5 = 0x000010D5,
		Pharah_voiceline_000010D6 = 0x000010D6,
		Pharah_voiceline_0000111D = 0x0000111D,
		Pharah_voiceline_0000111E = 0x0000111E,

		Reaper_voiceline_00000762 = 0x00000762,
		Reaper_voiceline_00000764 = 0x00000764,
		Reaper_voiceline_00000768 = 0x00000768,
		Reaper_voiceline_00000769 = 0x00000769,
		Reaper_voiceline_0000076A = 0x0000076A,
		Reaper_voiceline_0000076B = 0x0000076B,
		Reaper_voiceline_000008D4 = 0x000008D4,
		Reaper_voiceline_00000A29 = 0x00000A29,
		Reaper_voiceline_00000A2A = 0x00000A2A,
		Reaper_voiceline_00000A2B = 0x00000A2B,
		Reaper_voiceline_00000A2C = 0x00000A2C,
		Reaper_voiceline_00000D8C = 0x00000D8C,
		Reaper_voiceline_00000F56 = 0x00000F56,
		Reaper_voiceline_000010D7 = 0x000010D7,
		Reaper_voiceline_0000111A = 0x0000111A,

		Reinhardt_voiceline_000006F0 = 0x000006F0,
		Reinhardt_voiceline_000006F2 = 0x000006F2,
		Reinhardt_voiceline_000006F3 = 0x000006F3,
		Reinhardt_voiceline_000006F4 = 0x000006F4,
		Reinhardt_voiceline_000006F5 = 0x000006F5,
		Reinhardt_voiceline_000006F6 = 0x000006F6,
		Reinhardt_voiceline_000006F7 = 0x000006F7,
		Reinhardt_voiceline_000006F8 = 0x000006F8,
		Reinhardt_voiceline_000006F9 = 0x000006F9,
		Reinhardt_voiceline_000008D2 = 0x000008D2,
		Reinhardt_voiceline_000010D9 = 0x000010D9,
		Reinhardt_voiceline_000010DA = 0x000010DA,
		Reinhardt_voiceline_00001114 = 0x00001114,

		Roadhog_voiceline_00000798 = 0x00000798,
		Roadhog_voiceline_00000799 = 0x00000799,
		Roadhog_voiceline_0000079B = 0x0000079B,
		Roadhog_voiceline_0000079C = 0x0000079C,
		Roadhog_voiceline_0000079D = 0x0000079D,
		Roadhog_voiceline_0000079F = 0x0000079F,
		Roadhog_voiceline_000008D5 = 0x000008D5,
		Roadhog_voiceline_00000A13 = 0x00000A13,
		Roadhog_voiceline_00000A14 = 0x00000A14,
		Roadhog_voiceline_00000A15 = 0x00000A15,
		Roadhog_voiceline_00000A16 = 0x00000A16,
		Roadhog_voiceline_00000D8D = 0x00000D8D,
		Roadhog_voiceline_00000F57 = 0x00000F57,
		Roadhog_voiceline_000010DB = 0x000010DB,
		Roadhog_voiceline_000010DC = 0x000010DC,

		Soldier76_voiceline_000007F5 = 0x000007F5,
		Soldier76_voiceline_000007F6 = 0x000007F6,
		Soldier76_voiceline_000007F7 = 0x000007F7,
		Soldier76_voiceline_000007F8 = 0x000007F8,
		Soldier76_voiceline_000007F9 = 0x000007F9,
		Soldier76_voiceline_000007FA = 0x000007FA,
		Soldier76_voiceline_000007FB = 0x000007FB,
		Soldier76_voiceline_000008D7 = 0x000008D7,
		Soldier76_voiceline_00000A30 = 0x00000A30,
		Soldier76_voiceline_00000A31 = 0x00000A31,
		Soldier76_voiceline_00000A32 = 0x00000A32,
		Soldier76_voiceline_00000BD7 = 0x00000BD7,
		Soldier76_voiceline_00000CA3 = 0x00000CA3,
		Soldier76_voiceline_00000D8F = 0x00000D8F,
		Soldier76_voiceline_00000F59 = 0x00000F59,
		Soldier76_voiceline_000010DD = 0x000010DD,
		Soldier76_voiceline_000010DE = 0x000010DE,
		Soldier76_voiceline_0000111F = 0x0000111F,
		Soldier76_voiceline_00001120 = 0x00001120,

		Sombra_voiceline_00000AFD = 0x00000AFD,
		Sombra_voiceline_00000AFE = 0x00000AFE,
		Sombra_voiceline_00000AFF = 0x00000AFF,
		Sombra_voiceline_00000B00 = 0x00000B00,
		Sombra_voiceline_00000B01 = 0x00000B01,
		Sombra_voiceline_00000B02 = 0x00000B02,
		Sombra_voiceline_00000B03 = 0x00000B03,
		Sombra_voiceline_00000B04 = 0x00000B04,
		Sombra_voiceline_00000B05 = 0x00000B05,
		Sombra_voiceline_00000B06 = 0x00000B06,
		Sombra_voiceline_00000B07 = 0x00000B07,
		Sombra_voiceline_00000D87 = 0x00000D87,
		Sombra_voiceline_00000E62 = 0x00000E62,
		Sombra_voiceline_00000F52 = 0x00000F52,
		Sombra_voiceline_000010DF = 0x000010DF,
		Sombra_voiceline_000010E0 = 0x000010E0,
		Sombra_voiceline_00001110 = 0x00001110,

		Symmetra_voiceline_00000808 = 0x00000808,
		Symmetra_voiceline_0000080D = 0x0000080D,
		Symmetra_voiceline_000008DA = 0x000008DA,
		Symmetra_voiceline_000009F2 = 0x000009F2,
		Symmetra_voiceline_000009F3 = 0x000009F3,
		Symmetra_voiceline_000009F4 = 0x000009F4,
		Symmetra_voiceline_000009F5 = 0x000009F5,
		Symmetra_voiceline_000009F6 = 0x000009F6,
		Symmetra_voiceline_000009F7 = 0x000009F7,
		Symmetra_voiceline_000009F8 = 0x000009F8,
		Symmetra_voiceline_000009F9 = 0x000009F9,
		Symmetra_voiceline_00000D92 = 0x00000D92,
		Symmetra_voiceline_00000F5C = 0x00000F5C,
		Symmetra_voiceline_000010E1 = 0x000010E1,
		Symmetra_voiceline_000010E2 = 0x000010E2,
		Symmetra_voiceline_00001125 = 0x00001125,
		Symmetra_voiceline_00001126 = 0x00001126,

		Torbjorn_voiceline_000006C0 = 0x000006C0,
		Torbjorn_voiceline_000006C3 = 0x000006C3,
		Torbjorn_voiceline_000006C6 = 0x000006C6,
		Torbjorn_voiceline_000006C7 = 0x000006C7,
		Torbjorn_voiceline_000006C8 = 0x000006C8,
		Torbjorn_voiceline_000006C9 = 0x000006C9,
		Torbjorn_voiceline_000008D1 = 0x000008D1,
		Torbjorn_voiceline_000009FE = 0x000009FE,
		Torbjorn_voiceline_00000A00 = 0x00000A00,
		Torbjorn_voiceline_00000BD0 = 0x00000BD0,
		Torbjorn_voiceline_00000D88 = 0x00000D88,
		Torbjorn_voiceline_00000F51 = 0x00000F51,
		Torbjorn_voiceline_000010E3 = 0x000010E3,
		Torbjorn_voiceline_00001111 = 0x00001111,
		Torbjorn_voiceline_00001112 = 0x00001112,

		Tracer_voiceline_00000830 = 0x00000830,
		Tracer_voiceline_00000831 = 0x00000831,
		Tracer_voiceline_00000832 = 0x00000832,
		Tracer_voiceline_00000833 = 0x00000833,
		Tracer_voiceline_00000834 = 0x00000834,
		Tracer_voiceline_00000835 = 0x00000835,
		Tracer_voiceline_00000836 = 0x00000836,
		Tracer_voiceline_00000838 = 0x00000838,
		Tracer_voiceline_000008DB = 0x000008DB,
		Tracer_voiceline_00000A33 = 0x00000A33,
		Tracer_voiceline_00000A34 = 0x00000A34,
		Tracer_voiceline_00000BDB = 0x00000BDB,
		Tracer_voiceline_00000CA7 = 0x00000CA7,
		Tracer_voiceline_00000D93 = 0x00000D93,
		Tracer_voiceline_00000F5D = 0x00000F5D,
		Tracer_voiceline_000010E5 = 0x000010E5,
		Tracer_voiceline_000010E6 = 0x000010E6,
		Tracer_voiceline_00001127 = 0x00001127,
		Tracer_voiceline_00001128 = 0x00001128,

		Widowmaker_voiceline_0000069A = 0x0000069A,
		Widowmaker_voiceline_0000069D = 0x0000069D,
		Widowmaker_voiceline_000006CB = 0x000006CB,
		Widowmaker_voiceline_000006CC = 0x000006CC,
		Widowmaker_voiceline_000006CD = 0x000006CD,
		Widowmaker_voiceline_000006CE = 0x000006CE,
		Widowmaker_voiceline_000008DC = 0x000008DC,
		Widowmaker_voiceline_00000A01 = 0x00000A01,
		Widowmaker_voiceline_00000A02 = 0x00000A02,
		Widowmaker_voiceline_00000A03 = 0x00000A03,
		Widowmaker_voiceline_00000A04 = 0x00000A04,
		Widowmaker_voiceline_00000BDC = 0x00000BDC,
		Widowmaker_voiceline_00000D94 = 0x00000D94,
		Widowmaker_voiceline_00000F5E = 0x00000F5E,
		Widowmaker_voiceline_000010E7 = 0x000010E7,
		Widowmaker_voiceline_000010E8 = 0x000010E8,
		Widowmaker_voiceline_00001129 = 0x00001129,
		Widowmaker_voiceline_0000112A = 0x0000112A,

		Winston_voiceline_00000851 = 0x00000851,
		Winston_voiceline_00000853 = 0x00000853,
		Winston_voiceline_00000855 = 0x00000855,
		Winston_voiceline_00000857 = 0x00000857,
		Winston_voiceline_00000858 = 0x00000858,
		Winston_voiceline_000008D8 = 0x000008D8,
		Winston_voiceline_00000A24 = 0x00000A24,
		Winston_voiceline_00000A25 = 0x00000A25,
		Winston_voiceline_00000A26 = 0x00000A26,
		Winston_voiceline_00000A27 = 0x00000A27,
		Winston_voiceline_00000A28 = 0x00000A28,
		Winston_voiceline_00000BD8 = 0x00000BD8,
		Winston_voiceline_00000D90 = 0x00000D90,
		Winston_voiceline_00000F5A = 0x00000F5A,
		Winston_voiceline_000010E9 = 0x000010E9,
		Winston_voiceline_000010EA = 0x000010EA,
		Winston_voiceline_00001121 = 0x00001121,
		Winston_voiceline_00001122 = 0x00001122,

		Zarya_voiceline_0000071C = 0x0000071C,
		Zarya_voiceline_0000071F = 0x0000071F,
		Zarya_voiceline_00000721 = 0x00000721,
		Zarya_voiceline_00000722 = 0x00000722,
		Zarya_voiceline_00000723 = 0x00000723,
		Zarya_voiceline_00000724 = 0x00000724,
		Zarya_voiceline_000008D3 = 0x000008D3,
		Zarya_voiceline_00000A17 = 0x00000A17,
		Zarya_voiceline_00000A18 = 0x00000A18,
		Zarya_voiceline_00000A19 = 0x00000A19,
		Zarya_voiceline_00000A1A = 0x00000A1A,
		Zarya_voiceline_000010EB = 0x000010EB,
		Zarya_voiceline_000010EC = 0x000010EC,

		Zenyatta_voiceline_0000059A = 0x0000059A,
		Zenyatta_voiceline_0000059B = 0x0000059B,
		Zenyatta_voiceline_0000059D = 0x0000059D,
		Zenyatta_voiceline_0000059E = 0x0000059E,
		Zenyatta_voiceline_0000059F = 0x0000059F,
		Zenyatta_voiceline_000005A0 = 0x000005A0,
		Zenyatta_voiceline_000005A1 = 0x000005A1,
		Zenyatta_voiceline_000008CB = 0x000008CB,
		Zenyatta_voiceline_000009FA = 0x000009FA,
		Zenyatta_voiceline_000009FB = 0x000009FB,
		Zenyatta_voiceline_000009FC = 0x000009FC,
		Zenyatta_voiceline_00000C95 = 0x00000C95,
		Zenyatta_voiceline_00000F4C = 0x00000F4C,
		Zenyatta_voiceline_000010ED = 0x000010ED,
		Zenyatta_voiceline_000010EE = 0x000010EE,
		Zenyatta_voiceline_00001105 = 0x00001105,
		Zenyatta_voiceline_00001106 = 0x00001106,
	};
}
