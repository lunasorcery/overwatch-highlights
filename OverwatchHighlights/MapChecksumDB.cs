﻿using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace OverwatchHighlights
{
	static class MapChecksumDB
	{
		private static Dictionary<string, Map> ms_knownChecksums = new Dictionary<string, Map>() {
			{ "82c51523dc19af4a4edba5e43111682b36188ffe6c82f236dc953cef5d05c816", Map.BlackForest         },
			{ "9eae227b131ac6bd177a331dc97ceb7babb545cff3d93af5bca623b3bef726b5", Map.Castillo            },
			{ "5d00a275b98301855f3af20b475ca9106f3f28eee1e4eddaccb7184491c7d032", Map.Castillo            },
			{ "e1143cd6b8c43c85d924cd05a654652d8bb8f5fc623548c669eb999c46d46085", Map.ChateauGuillard     }, // 39060
			{ "2e8a90be740fead56467d6fe40742a5404a029924e5ed37c94ad013f9463a3f4", Map.ChateauGuillard     }, // 39083
			{ "57925bca898c0b25fa1ab5f3c0a92459158acda18d472a532b6a958cedb194c0", Map.ChateauGuillard     }, // 39103
			{ "fad957e3e8209c027f135a034ddcba1f1f276ea00d9ce428f8c65fe0987cdf67", Map.ChateauGuillard     }, // 39241
			{ "62751cbd064f6e0cbd6df936166f42fd3df704fcde986af5641b3d7c5676a6d4", Map.Dorado              },
			{ "e2872843fc4060ad193e226d6bfdbf714175a0bb5d0ec32c2bd897c483190351", Map.Dorado              }, // 39484
			{ "b10ec7bbc79a8aec0b3cd3635516a175e698967f736c0f6625a8b4c0266b32ce", Map.EcopointAntarctica  },
			{ "fd59d8a6a49911490352f4782197ddcbaec1c5e55cc8d458b7692cf50b6f1cc5", Map.Eichenwalde         },
			{ "e627df441dece13c2033bc625561ca8d4f6857b630341d8ddc46000c59076d67", Map.Eichenwalde         }, // 39484
			{ "df9cd09ad721830fcba4cb315661c7f83ac4497e9f2b87d11443feed0c030db3", Map.EstadioDasRas       },
			{ "2e7e788861bc9625d7eb0b7f4995196e0effd1e01739c7e52ed07b77b74f9b93", Map.Hanamura            },
			{ "9613ea6bb2479e2963b41036cc02bcfabcd193d3a856e63983a30c02e6ca3f8b", Map.Hanamura            }, // 39484
			{ "36a341df15c7f1199439852adc622a38a6f4642cac2874113fd85da1b000dc14", Map.Hollywood           },
			{ "48900774025651d1f7e6fda1fa8ccc86c3a6721057998408a7cb59adf9f7e62d", Map.Hollywood           },
			{ "2666eecc51a3609cfb977eb18726625cfc35a6a145f55a18261973119499ba5f", Map.HorizonLunarColony  },
			{ "5e1af3640a7e05318932dd9b742f08462bde262e7f89549a4f43c81af9e1bd43", Map.HorizonLunarColony  }, // 38459
			{ "9da70d078c525735b3e6ffcdd15d5aa4633a2dbab4a76e44b8a757d7c55714ae", Map.HorizonLunarColony  }, // 39484
			{ "0f3c7d94b4d37ee318ed185bc9cd18448893ed54952d408f9eb0f87de398e5eb", Map.Ilios               },
			{ "d35c1ad4a2331abf6d222bfdc3475f3d7f9de1b5807d150f61c6cac78d5f316f", Map.Ilios               }, // 39484
			{ "1be7309f75d73ffca1e03de880ba6e1e8d78edc5ada82bdd3ae3a0607a37b919", Map.Ilios               }, // 40133
			{ "081b8b4f31b795fe8909a16072239176ddab5133a05cccead47467eb723ca2a0", Map.IliosLighthouse     },
			{ "5a9f18fa124358150b3497b35d4af2962b8d619a1641e9d5720bd979ca240ed8", Map.IliosRuins          },
			{ "1471110df70d2833bb081e00a36ed58d3a94577d3cd944a1ee62ae6f6a2e6b2c", Map.IliosRuins          }, // 39484
			{ "c12b3f4832c1428ffe360346519f84f97a067cccf3c5e28d613474fd95bfedf5", Map.IliosWell           },
			{ "4e775879736009135644355352eb3ef307de4d0fccf811a63bb71dc3c6da160a", Map.Junkertown          },
			{ "326f3d5d63a1c18a2fd721207b3247de5df38ef2b0b598a92fb8349b2761a54b", Map.Junkertown          }, // 39935
			{ "7b944d3cc471b05428b96ad7409cc253423d70daac971c3de63fd9c48117bf63", Map.KingsRow            },
			{ "68c676a63e22b19bd15888939e214464e6c0b8838d39b54fc9df02ae1f50c18d", Map.KingsRow            }, // 39484
			{ "70e232f37b81d37479a69f27c9f0bdcbd32cdc63dd835dc01bde604f657548f1", Map.KingsRow            }, // 39935
			{ "19080a2b9c29659da8cf739df06f87a312542e3c0e1ca3cbc67bb1be6f803f95", Map.LijiangNightMarket  },
			{ "b0fc70637c33bcc89bc09f3ca6b5e99bea9bf4457f35fe80a0c325a4491d054b", Map.LijiangTower        },
			{ "83b54d9666a1152555141a88907ff1b18fbbc98dd7d17760e248666b0978b729", Map.LijiangTower        }, // 39484
			{ "8fb310763e91f23d654991c82e1245c3ca1d8ee0bbeb4940c7cf1f6eb376ff81", Map.Necropolis          },
			{ "ede8aa27218ccbed9e8424e4d68903c5ae0d31671ff52c866237e1d873b89d9e", Map.Necropolis          },
			{ "9b03383ddefb5761706317f64a8d6b998ce52bb854e2add3923e74dcd857459f", Map.Nepal               },
			{ "bdc81e535ef0ffb27d4bcb9f5befeeb890b6f38970e1261c0733d047d61717f6", Map.Nepal               }, // 39484
			{ "113fc7e9ae2b90872517af5783336e3f4d4fe4c999267943c42045b7db174e58", Map.Nepal               }, // 39935
			{ "2237c06ad7e98e217732d9f84b33cc6ebb674809fe7d45d5fc6e3fe8dc0d2f1a", Map.Numbani             },
			{ "8b4810c3f48225d2d55ce0c26e89f7f8486460c363e56ae51326854801956bda", Map.Numbani             }, // 39484
			{ "f710bb6473333d91ace388140ff934e27b2b7f91bdf3bde0a1741677b94c093b", Map.Oasis               },
			{ "e8d841ea9bfa692417c8b8635e489c84bfab1de1b2f69168066f6dd2a7ff42a6", Map.Oasis               }, // 39484
			{ "346731542d347fa3a9b99143ade3284144da926827a94dc7cbd688c699a7c284", Map.Oasis               }, // 40133
			{ "300eb49042dd55b06c3c697ebdabd066c6e5ed4c6f094d7bd89a8cf4bc6335cd", Map.OasisCityCenter     },
			{ "062097aa45c809bd39148ad4d6673b6de36f7278f3b1c5560ce5061b4346266f", Map.OasisGardens        },
			{ "517866908075af96dc64500966e7511e749f098ee9e148162f02a238d45ebfa6", Map.OasisUniversity     },
			{ "2a2bfc2a8183cd616175ba74146ec43d032fbe027b417dbd851bfdf379d69098", Map.Route66             },
			{ "d8ad0d4a35e3fba6170425a0f9c4d719e28eac7a522727ca36fadeb1f3192ee8", Map.Route66             }, // 39484
			{ "7dcff5efda3d21b1ca21eb0094060a4d7bf0bbf36587ea3af34511a472df6854", Map.SydneyHarbourArena  },
			{ "28bf6b3e4fa657fa14c6ad5c7d54256896fa2143d5ffb3800119a13a67c89b35", Map.TempleOfAnubis      },
			{ "0ed5ce428683c9966d05db8345f2882bf90fbdfd07996a5fc2814fe0b006dd6c", Map.TempleOfAnubis      }, // 39060 - tweaks for team deathmatch
			{ "54b77a2ee88f8a3ada1ca584621325313d4f6e660b8af29d2a7af3900368bea8", Map.TempleOfAnubis      }, // 39484
			{ "10df82233f4589f15841eacfb67622231a59e57f6af74bf8e66b0e6cbc58e59e", Map.VolskayaIndustries  },
			{ "f906172921603ed8744f21994f825e4c14385a671c983a233615a4bf76b3079a", Map.VolskayaIndustries  }, // 39484
			{ "93192744736714cb3597d926b6d43eecbf62b1ef6950647f4b6f48b6278cc396", Map.WatchpointGibraltar },
			{ "6e6cae336dba9ac5c75d663586b5ac8fb329ab8eff37e2c6bd8077c441a58e23", Map.WatchpointGibraltar }, // 39484
		};

		public static bool IsValidChecksumForMap(Map map, Checksum checksum)
		{
			Debug.Assert(ms_knownChecksums.ContainsKey(checksum.ToString()), $"Checksum {checksum} is unknown, expect it to be for {map}.");
			return ms_knownChecksums[checksum.ToString()] == map;
		}
	}
}
