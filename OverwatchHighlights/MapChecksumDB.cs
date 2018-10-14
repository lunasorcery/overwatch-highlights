using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace OverwatchHighlights
{
	static class MapChecksumDB
	{
		private static Dictionary<string, Map> ms_knownChecksums = new Dictionary<string, Map>() {
			{ "82c51523dc19af4a4edba5e43111682b36188ffe6c82f236dc953cef5d05c816", Map.BlackForest         },
			{ "d5789985d38ea9e063900e1068e55326357d2a98024b553c2a9173d3c5b191e7", Map.BlackForest         }, // 40133
			{ "3f87c9029574880e85ad1fec5dd5be3d32147aa2b0660091109f8f903a24d0bf", Map.BlizzardWorld       },
			{ "4b08a653b750541af8361756cb182ee42b7993a43a7c9a3e290b501fe6f3e1ba", Map.BlizzardWorld       }, // 45752
			{ "8b540d0a894cbb4148962fded95550cd7ca96ea9f31f562acf4223c6b2c70ad7", Map.Busan               }, // 51948
			{ "9eae227b131ac6bd177a331dc97ceb7babb545cff3d93af5bca623b3bef726b5", Map.Castillo            },
			{ "5d00a275b98301855f3af20b475ca9106f3f28eee1e4eddaccb7184491c7d032", Map.Castillo            },
			{ "e1143cd6b8c43c85d924cd05a654652d8bb8f5fc623548c669eb999c46d46085", Map.ChateauGuillard     }, // 39060
			{ "2e8a90be740fead56467d6fe40742a5404a029924e5ed37c94ad013f9463a3f4", Map.ChateauGuillard     }, // 39083
			{ "57925bca898c0b25fa1ab5f3c0a92459158acda18d472a532b6a958cedb194c0", Map.ChateauGuillard     }, // 39103
			{ "fad957e3e8209c027f135a034ddcba1f1f276ea00d9ce428f8c65fe0987cdf67", Map.ChateauGuillard     }, // 39241
			{ "9654ae18fc879ab82dceab50231556d8ce0304fc702687d4f9243a637a5042f7", Map.ChateauGuillard     }, // 42210
			{ "117c20bb8647937c46946c24653848694255e794926c77274f133ab79529dfbb", Map.ChateauGuillardHalloween }, // 51948
			{ "62751cbd064f6e0cbd6df936166f42fd3df704fcde986af5641b3d7c5676a6d4", Map.Dorado              },
			{ "e2872843fc4060ad193e226d6bfdbf714175a0bb5d0ec32c2bd897c483190351", Map.Dorado              }, // 39484
			{ "b3d198624aa53f1294664084b4ccb1738d1e2997cc87c5338d9946d7e3aa0acd", Map.Dorado              }, // 41031
			{ "352212f74ea9e6a78b0c95eb27713dd1e25efd5a7baecb2d6123d115ddc19f8f", Map.Dorado              }, // 51948
			{ "b10ec7bbc79a8aec0b3cd3635516a175e698967f736c0f6625a8b4c0266b32ce", Map.EcopointAntarctica  },
			{ "fd59d8a6a49911490352f4782197ddcbaec1c5e55cc8d458b7692cf50b6f1cc5", Map.Eichenwalde         },
			{ "e627df441dece13c2033bc625561ca8d4f6857b630341d8ddc46000c59076d67", Map.Eichenwalde         }, // 39484
			{ "139e122a54ae3484ffb2455aa71b955f690a10dc874f7f0cdb8e41be83a60b45", Map.Eichenwalde         }, // 41350
			{ "b492e9904f19915884732a5904ca0c27703df3ef5f804ced8271354004ffc953", Map.Eichenwalde         }, // 42665
			{ "c5649643502009c80ff958c1375a45a407cd6511bd0f949156cb9e57bc92f4e5", Map.Eichenwalde         }, // 51948
			{ "60418c892c1764d75d2d7e9d06a30078ed70e46caa78bca6ebc8a7ca0a91f512", Map.EichenwaldeHalloween}, // 40407
			{ "df9cd09ad721830fcba4cb315661c7f83ac4497e9f2b87d11443feed0c030db3", Map.EstadioDasRas       },
			{ "2e7e788861bc9625d7eb0b7f4995196e0effd1e01739c7e52ed07b77b74f9b93", Map.Hanamura            },
			{ "9613ea6bb2479e2963b41036cc02bcfabcd193d3a856e63983a30c02e6ca3f8b", Map.Hanamura            }, // 39484
			{ "1a43b2208aafa8e0865447bc9e43364689a4d407cea827b793b54b06bef150ad", Map.Hanamura            }, // 41350
			{ "36a341df15c7f1199439852adc622a38a6f4642cac2874113fd85da1b000dc14", Map.Hollywood           },
			{ "48900774025651d1f7e6fda1fa8ccc86c3a6721057998408a7cb59adf9f7e62d", Map.Hollywood           },
			{ "8e9bebde31322d11883374ff3d4574991e27f23b1c51b54257b3b53a2bc47c3e", Map.Hollywood           }, // 40133
			{ "cb32eb6022a8337c174e91f56c5ab36d6e46a30fe8ab914a8c85be3648749219", Map.Hollywood           }, // 41031
			{ "b07262347d94bf2f8767bc32253bf53fa7e4adc418da6b250b2dba5c5c7b5f06", Map.Hollywood           }, // 42210
			{ "07c0229d14a09885cd660b9f981bc485675bd935de9f6a5cedf461e26a76e763", Map.HollywoodHalloween  }, // 51948
			{ "2666eecc51a3609cfb977eb18726625cfc35a6a145f55a18261973119499ba5f", Map.HorizonLunarColony  },
			{ "5e1af3640a7e05318932dd9b742f08462bde262e7f89549a4f43c81af9e1bd43", Map.HorizonLunarColony  }, // 38459
			{ "9da70d078c525735b3e6ffcdd15d5aa4633a2dbab4a76e44b8a757d7c55714ae", Map.HorizonLunarColony  }, // 39484
			{ "14df3369ce618d369de9b0d202d7b5b7c930eea5eb5b63e95ee9a92a6520ff1c", Map.HorizonLunarColony  }, // 42210
			{ "571af02044245df13972505603173a045f2944f09fa622257d4de022772f511c", Map.HorizonLunarColony  }, // 45752
			{ "0f3c7d94b4d37ee318ed185bc9cd18448893ed54952d408f9eb0f87de398e5eb", Map.Ilios               },
			{ "d35c1ad4a2331abf6d222bfdc3475f3d7f9de1b5807d150f61c6cac78d5f316f", Map.Ilios               }, // 39484
			{ "1be7309f75d73ffca1e03de880ba6e1e8d78edc5ada82bdd3ae3a0607a37b919", Map.Ilios               }, // 40133
			{ "eb8071246e09b9e567ba0f3a7920beacc37e4c8b2213694a30225fe920e6025a", Map.Ilios               }, // 41714
			{ "081b8b4f31b795fe8909a16072239176ddab5133a05cccead47467eb723ca2a0", Map.IliosLighthouse     },
			{ "5a9f18fa124358150b3497b35d4af2962b8d619a1641e9d5720bd979ca240ed8", Map.IliosRuins          },
			{ "1471110df70d2833bb081e00a36ed58d3a94577d3cd944a1ee62ae6f6a2e6b2c", Map.IliosRuins          }, // 39484
			{ "c12b3f4832c1428ffe360346519f84f97a067cccf3c5e28d613474fd95bfedf5", Map.IliosWell           },
			{ "4e775879736009135644355352eb3ef307de4d0fccf811a63bb71dc3c6da160a", Map.Junkertown          },
			{ "326f3d5d63a1c18a2fd721207b3247de5df38ef2b0b598a92fb8349b2761a54b", Map.Junkertown          }, // 39935
			{ "a4a52cafba2b51922bdeda97cb7577dcab6eb51c1660e84f0ff5e9bd5e55164f", Map.Junkertown          }, // 41031
			{ "73e04bf8f5c5560b0eb9450f7fac0a76f8d4a1cb5666f7c870ec6d12da23971d", Map.Junkertown          }, // 45752
			{ "857e4547ee48d93acd48098fe7788318fbd85e3f25f00af50b039a4fc5902e06", Map.JunkensteinsRevenge }, // 40407
			{ "7b944d3cc471b05428b96ad7409cc253423d70daac971c3de63fd9c48117bf63", Map.KingsRow            },
			{ "68c676a63e22b19bd15888939e214464e6c0b8838d39b54fc9df02ae1f50c18d", Map.KingsRow            }, // 39484
			{ "70e232f37b81d37479a69f27c9f0bdcbd32cdc63dd835dc01bde604f657548f1", Map.KingsRow            }, // 39935
			{ "d95dd8c99109643a7b7b5bd86690a0bb632e85a619702fe73e2a5d61ec020039", Map.KingsRow            }, // 41031
			{ "723911560b8b6e42858115676fe09004cb7931d485e87e99d0352b21d4c201b3", Map.KingsRowUprising    }, // 45752
			{ "19080a2b9c29659da8cf739df06f87a312542e3c0e1ca3cbc67bb1be6f803f95", Map.LijiangNightMarket  },
			{ "b0fc70637c33bcc89bc09f3ca6b5e99bea9bf4457f35fe80a0c325a4491d054b", Map.LijiangTower        },
			{ "83b54d9666a1152555141a88907ff1b18fbbc98dd7d17760e248666b0978b729", Map.LijiangTower        }, // 39484
			{ "3b07908c0ae62176f63d5c784db72b4e1e636d7e1f1182c131b49b8e5aed1a84", Map.LijiangTower        }, // 41031
			{ "8fb310763e91f23d654991c82e1245c3ca1d8ee0bbeb4940c7cf1f6eb376ff81", Map.Necropolis          },
			{ "ede8aa27218ccbed9e8424e4d68903c5ae0d31671ff52c866237e1d873b89d9e", Map.Necropolis          },
			{ "9b03383ddefb5761706317f64a8d6b998ce52bb854e2add3923e74dcd857459f", Map.Nepal               },
			{ "bdc81e535ef0ffb27d4bcb9f5befeeb890b6f38970e1261c0733d047d61717f6", Map.Nepal               }, // 39484
			{ "113fc7e9ae2b90872517af5783336e3f4d4fe4c999267943c42045b7db174e58", Map.Nepal               }, // 39935
			{ "43b41f5f83810458d1a37fed8b6f0b5882e86ca9b98a702f8144a6f5e6e35db3", Map.Nepal               }, // 40407
			{ "05afd8f5ac3584134c1a0e3bba64c3987ad153bb4b270ff15d7542d118f6ac7d", Map.Nepal               }, // 41031
			{ "2237c06ad7e98e217732d9f84b33cc6ebb674809fe7d45d5fc6e3fe8dc0d2f1a", Map.Numbani             },
			{ "8b4810c3f48225d2d55ce0c26e89f7f8486460c363e56ae51326854801956bda", Map.Numbani             }, // 39484
			{ "3c8e2f6c1924cdc9bc6180665c1fca0d32cdbb436dba9da8a0a7e57a745e3ed1", Map.Numbani             }, // 41031
			{ "f710bb6473333d91ace388140ff934e27b2b7f91bdf3bde0a1741677b94c093b", Map.Oasis               },
			{ "e8d841ea9bfa692417c8b8635e489c84bfab1de1b2f69168066f6dd2a7ff42a6", Map.Oasis               }, // 39484
			{ "346731542d347fa3a9b99143ade3284144da926827a94dc7cbd688c699a7c284", Map.Oasis               }, // 40133
			{ "300eb49042dd55b06c3c697ebdabd066c6e5ed4c6f094d7bd89a8cf4bc6335cd", Map.OasisCityCenter     },
			{ "062097aa45c809bd39148ad4d6673b6de36f7278f3b1c5560ce5061b4346266f", Map.OasisGardens        },
			{ "517866908075af96dc64500966e7511e749f098ee9e148162f02a238d45ebfa6", Map.OasisUniversity     },
			{ "1a06daebd77592c41b84a835abb34c5f4c47eb2639b4098f7a709bc4868b41c1", Map.RialtoRetribution   }, // 45752
			{ "2a2bfc2a8183cd616175ba74146ec43d032fbe027b417dbd851bfdf379d69098", Map.Route66             },
			{ "d8ad0d4a35e3fba6170425a0f9c4d719e28eac7a522727ca36fadeb1f3192ee8", Map.Route66             }, // 39484
			{ "2fb879652d9a4bb6707ed41834a8f3e0a9eace723dd1eb4317f9385534626ac5", Map.Route66             }, // 45752
			{ "7dcff5efda3d21b1ca21eb0094060a4d7bf0bbf36587ea3af34511a472df6854", Map.SydneyHarbourArena  },
			{ "28bf6b3e4fa657fa14c6ad5c7d54256896fa2143d5ffb3800119a13a67c89b35", Map.TempleOfAnubis      },
			{ "0ed5ce428683c9966d05db8345f2882bf90fbdfd07996a5fc2814fe0b006dd6c", Map.TempleOfAnubis      }, // 39060 - tweaks for team deathmatch
			{ "54b77a2ee88f8a3ada1ca584621325313d4f6e660b8af29d2a7af3900368bea8", Map.TempleOfAnubis      }, // 39484
			{ "b774f5f1b440a55aa05bd3ad02456d533f42f3d3f815d604cde6abebefa8a445", Map.TempleOfAnubis      }, // 41031
			{ "10df82233f4589f15841eacfb67622231a59e57f6af74bf8e66b0e6cbc58e59e", Map.VolskayaIndustries  },
			{ "f906172921603ed8744f21994f825e4c14385a671c983a233615a4bf76b3079a", Map.VolskayaIndustries  }, // 39484
			{ "d0fd15e6465d128bc8fd1e61ddb5b2ac48f8832a3eba1abdc1bd370e6b205a48", Map.VolskayaIndustries  }, // 41031
			{ "93192744736714cb3597d926b6d43eecbf62b1ef6950647f4b6f48b6278cc396", Map.WatchpointGibraltar },
			{ "6e6cae336dba9ac5c75d663586b5ac8fb329ab8eff37e2c6bd8077c441a58e23", Map.WatchpointGibraltar }, // 39484
			{ "597c717b53e0d32bcb160017cc15ece5105c9caa62c6d7365013bfdf0ff6369c", Map.WatchpointGibraltar }, // 41350
		};

		public static bool IsValidChecksumForMap(Map map, Checksum checksum)
		{
			Debug.Assert(ms_knownChecksums.ContainsKey(checksum.ToString()), $"Checksum {checksum} is unknown, expect it to be for {map}.");
			return ms_knownChecksums[checksum.ToString()] == map;
		}
	}
}
