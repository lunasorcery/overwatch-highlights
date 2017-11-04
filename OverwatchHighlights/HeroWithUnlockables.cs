using System;
using System.Diagnostics;
using System.IO;

namespace OverwatchHighlights
{
	class HeroWithUnlockables
	{
		public Skin skin;
		public WeaponSkin weaponSkin;
		public HighlightIntro highlightIntro;
		public Spray[] sprays;
		public VoiceLine[] voiceLines;
		public Emote[] emotes;
		public Hero hero;

		public HeroWithUnlockables(BinaryReader br, MajorVersion gameMajorVersion)
		{
			this.skin = br.ReadSkin32();
			this.weaponSkin = br.ReadWeaponSkin32();

			this.highlightIntro = br.ReadHighlightIntro32();

			int numSprays = br.ReadInt32();
			this.sprays = br.ReadSpray32s(numSprays);

			int numVoiceLines = br.ReadInt32();
			this.voiceLines = br.ReadVoiceLine32s(numVoiceLines);

			int numEmotes = br.ReadInt32();
			this.emotes = br.ReadEmote32s(numEmotes);

			// what????
			if (gameMajorVersion >= new MajorVersion(1, 17, VersionBranch.None))
			{
				uint unknownInV17 = br.ReadUInt32();
				Debug.Assert(unknownInV17 == 0xffffffff || unknownInV17 == 0x00000000 || unknownInV17 == 0x00000001);
			}

			this.hero = br.ReadHero64();

			// AI players in custom matches have no HighlightIntro, no unlocks, and always use classic skins
			// Bots in the Junkenstein/Uprising modes sometimes use non-classic skins.
			if (highlightIntro == HighlightIntro.None)
			{
				Debug.Assert(this.sprays.Length == 0);
				Debug.Assert(this.voiceLines.Length == 0);
				Debug.Assert(this.emotes.Length == 0);
				Debug.Assert(
					($"{skin}" == $"{hero}_Classic") ||
					(hero == Hero.Junkrat && skin == Skin.Junkrat_DrJunkenstein) ||
					(hero == Hero.Mercy && skin == Skin.Mercy_Witch) ||
					(hero == Hero.Reaper && skin == Skin.Reaper_skin_00001BEB) ||
					(hero == Hero.Roadhog && skin == Skin.Roadhog_skin_0000195C)
				);
				Debug.Assert(
					($"{weaponSkin}" == $"{hero}_Classic") ||
					(hero == Hero.Junkrat && weaponSkin == WeaponSkin.Junkrat_DrJunkenstein) ||
					(hero == Hero.Mercy && weaponSkin == WeaponSkin.Mercy_Witch) ||
					(hero == Hero.Reaper && weaponSkin == WeaponSkin.Reaper_skin_00001BEB_weapon_00002AA8) ||
					(hero == Hero.Roadhog && weaponSkin == WeaponSkin.Roadhog_skin_0000195C_weapon_0000258F)
				);
			}

			// Ensure that unlocks are correctly mapped to heroes
			UnlockValidator.RunForHeroWithUnlocks(hero, skin, weaponSkin, highlightIntro, sprays, emotes, voiceLines);
		}

		public void Print()
		{
			Console.WriteLine("{");
			Console.WriteLine($"  Hero:             {hero}");
			Console.WriteLine($"  Skin:             {skin}");
			Console.WriteLine($"  Weapon:           {weaponSkin}");
			Console.WriteLine($"  Highlight Intro:  {highlightIntro}");
			Console.WriteLine($"  Sprays:           [{(string.Join(", ", sprays))}]");
			Console.WriteLine($"  Voice Lines:      [{(string.Join(", ", voiceLines))}]");
			Console.WriteLine($"  Emotes:           [{(string.Join(", ", emotes))}]");
			Console.WriteLine("}");
		}
	}
}
