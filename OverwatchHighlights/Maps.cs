namespace OverwatchHighlights
{
	// https://blzgdapipro-a.akamaihd.net/game/maps/0x08000000XXXXXXXX.png
	// ^ a lot of the maps don't have an image up here....
	enum Map : uint
	{
		// I extracted this list of map identifiers with Overtool
		// You'll notice there are quite a few duplicates
		// For these I'm not entirely sure which ones are actually used
		// So i'm keeping them all commented out until I've got a verified highlight file for each one

		TempleOfAnubis        = 0x0000005B,
		KingsRow              = 0x000000D4,
		Hanamura              = 0x00000165,
		WatchpointGibraltar   = 0x00000184,
//		AutomationArena       = 0x000001C2,
//		Numbani               = 0x000001D4,
		VolskayaIndustries    = 0x000001DB,
		Hollywood             = 0x000002AF,
		Dorado                = 0x000002C3,
		Nepal                 = 0x000004B7,
		Route66               = 0x000005BB,
//		Tutorial              = 0x00000661,
		LijiangTower          = 0x00000662,
//		Hanamura              = 0x00000664,
		Ilios                 = 0x0000066D,
//		WatchpointGibraltar   = 0x00000675,
//		KingsRow              = 0x00000676,
//		VolskayaIndustries    = 0x00000677,
//		Hollywood             = 0x00000678,
//		Dorado                = 0x00000679,
//		Numbani               = 0x0000067A,
//		TempleOfAnubis        = 0x0000067B,
//		PracticeRange         = 0x00000688,
		Eichenwalde           = 0x0000068D,
		Oasis                 = 0x0000069E,
//		Hollywood             = 0x000006AB,
//		KingsRow              = 0x000006B1,
//		EstadiodasRas         = 0x000006B3,
//		Hanamura              = 0x000006B5,
//		LijiangTower          = 0x000006B7,
//		Soccer                = 0x000006C0,
//		VPPGreenRoom          = 0x000006C7,
//		JunkensteinsRevenge   = 0x000006C9,
//		Eichenwalde           = 0x000006CF,
		EcopointAntarctica    = 0x000006D1,
		HorizonLunarColony    = 0x000006D3,
//		JunkensteinsRevenge   = 0x000006E0,
//		KingsRow              = 0x000006FE,
//		KingsRow              = 0x00000700,
//		EcopointAntarctica    = 0x00000704,
//		Necropolis            = 0x00000705,
		BlackForest           = 0x0000070C,
//		EcopointAntarctica    = 0x0000070D,
//		Unknown710            = 0x00000710,
//		LijiangGarden         = 0x00000711,
//		LijiangNightMarket    = 0x00000712,
//		Unknown715            = 0x00000715,
//		Oasis                 = 0x00000716,
//		NepalSanctum          = 0x00000717,
//		LijiangControlCenter  = 0x0000071A,
//		Castillo              = 0x0000071C,
//		NepalVillage          = 0x00000736,
//		NepalShrine           = 0x00000738,
//		IliosWell             = 0x0000073A,
//		IliosLighthouse       = 0x0000073D,
		IliosRuins            = 0x0000073E,
//		LijiangControlCenter  = 0x00000744,
//		LijiangGarden         = 0x00000745,
		LijiangNightMarket    = 0x00000746,
//		OasisCityCenter       = 0x0000074A,
		OasisGardens          = 0x0000074C,
//		OasisUniversity       = 0x0000074D,
		Numbani               = 0x00000751,
//		KingsRow              = 0x00000764,
//		VPPGreenRoom          = 0x0000078C,
//		VPPGreenRoom          = 0x00000790,
//		VPPGreenRoom          = 0x00000791,
//		HorizonLunarColony    = 0x00000794,
	}

	static partial class Extensions
	{
		public static bool Is3v3Map(this Map map)
		{
			return
				map == Map.BlackForest ||
//				map == Map.Castillo ||
				map == Map.EcopointAntarctica ||
//				map == Map.IliosLighthouse ||
				map == Map.IliosRuins ||
//				map == Map.IliosWell ||
//				map == Map.LijiangControlCenter ||
//				map == Map.LijiangGarden ||
				map == Map.LijiangNightMarket ||
//				map == Map.Necropolis ||
//				map == Map.NepalSanctum ||
//				map == Map.NepalShrine ||
//				map == Map.NepalVillage ||
//				map == Map.OasisCityCenter ||
				map == Map.OasisGardens ||
//				map == Map.OasisUniversity ||
				false;	// because this lets me get away with the commenting shenanigans above..
		}
	}
}