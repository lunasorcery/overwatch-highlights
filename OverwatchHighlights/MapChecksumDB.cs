using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OverwatchHighlights
{
	static class MapChecksumDB
	{
		private static Dictionary<Map, string> ms_knownChecksums = new Dictionary<Map, string>() {
			{ Map.BlackForest,          "82c51523dc19af4a4edba5e43111682b36188ffe6c82f236dc953cef5d05c816" },
			{ Map.Dorado,               "62751cbd064f6e0cbd6df936166f42fd3df704fcde986af5641b3d7c5676a6d4" },
			{ Map.EcopointAntarctica,   "b10ec7bbc79a8aec0b3cd3635516a175e698967f736c0f6625a8b4c0266b32ce" },
			{ Map.Eichenwalde,          "fd59d8a6a49911490352f4782197ddcbaec1c5e55cc8d458b7692cf50b6f1cc5" },
			{ Map.Hanamura,             "2e7e788861bc9625d7eb0b7f4995196e0effd1e01739c7e52ed07b77b74f9b93" },
			{ Map.Hollywood,            "36a341df15c7f1199439852adc622a38a6f4642cac2874113fd85da1b000dc14" },
			{ Map.HorizonLunarColony,   "2666eecc51a3609cfb977eb18726625cfc35a6a145f55a18261973119499ba5f" },
			{ Map.Ilios,                "0f3c7d94b4d37ee318ed185bc9cd18448893ed54952d408f9eb0f87de398e5eb" },
			{ Map.IliosRuins,           "5a9f18fa124358150b3497b35d4af2962b8d619a1641e9d5720bd979ca240ed8" },
			{ Map.KingsRow,             "7b944d3cc471b05428b96ad7409cc253423d70daac971c3de63fd9c48117bf63" },
			{ Map.LijiangTower,         "b0fc70637c33bcc89bc09f3ca6b5e99bea9bf4457f35fe80a0c325a4491d054b" },
			{ Map.Nepal,                "9b03383ddefb5761706317f64a8d6b998ce52bb854e2add3923e74dcd857459f" },
			{ Map.Numbani,              "2237c06ad7e98e217732d9f84b33cc6ebb674809fe7d45d5fc6e3fe8dc0d2f1a" },
			{ Map.Oasis,                "f710bb6473333d91ace388140ff934e27b2b7f91bdf3bde0a1741677b94c093b" },
			{ Map.OasisGardens,         "062097aa45c809bd39148ad4d6673b6de36f7278f3b1c5560ce5061b4346266f" },
			{ Map.Route66,              "2a2bfc2a8183cd616175ba74146ec43d032fbe027b417dbd851bfdf379d69098" },
			{ Map.TempleOfAnubis,       "28bf6b3e4fa657fa14c6ad5c7d54256896fa2143d5ffb3800119a13a67c89b35" },
			{ Map.VolskayaIndustries,   "10df82233f4589f15841eacfb67622231a59e57f6af74bf8e66b0e6cbc58e59e" },
			{ Map.WatchpointGibraltar,  "93192744736714cb3597d926b6d43eecbf62b1ef6950647f4b6f48b6278cc396" },
		};

		public static bool IsValidChecksumForMap(Map map, Checksum checksum)
		{
			Debug.Assert(ms_knownChecksums.ContainsKey(map));
			return string.Compare(ms_knownChecksums[map], checksum.ToString(), true) == 0;
		}
	}
}
