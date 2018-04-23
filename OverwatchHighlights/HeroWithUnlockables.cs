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
		public int unknownInV17;
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

			// might be to do with team affiliation? seems to be either 0 or 1 depending on team - not sure about -1??
			if (gameMajorVersion >= new MajorVersion(1, 17, VersionBranch.None))
			{
				this.unknownInV17 = br.ReadInt32();
				Debug.Assert(unknownInV17 == -1 || unknownInV17 == 0 || unknownInV17 == 1 || unknownInV17 == 4);
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
					(hero == Hero.Reaper && skin == Skin.Reaper_Dracula) ||
					(hero == Hero.Roadhog && skin == Skin.Roadhog_JunkensteinsMonster) ||
					(hero == Hero.Orisa && skin == Skin.Orisa_NullSector) ||
					(hero == Hero.UprisingEvent_00000173 && skin == Skin.UprisingEvent_00000173_Classic) ||
					(hero == Hero.UprisingEvent_00000178 && skin == Skin.UprisingEvent_00000178_Classic) ||
					(hero == Hero.UprisingEvent_00000179 && skin == Skin.UprisingEvent_00000179_Classic) ||
					(hero == Hero.RetributionEvent_000001AC && skin == Skin.RetributionEvent_000001AC_Classic) ||
					(hero == Hero.RetributionEvent_000001B8 && skin == Skin.RetributionEvent_000001B8_Classic) ||
					(hero == Hero.RetributionEvent_000001BA && skin == Skin.RetributionEvent_000001BA_Classic) ||
					(hero == Hero.RetributionEvent_000001BB && skin == Skin.RetributionEvent_000001BB_Classic) ||
					(hero == Hero.RetributionEvent_000001CE && skin == Skin.RetributionEvent_000001CE_Classic)
				);
				Debug.Assert(
					($"{weaponSkin}" == $"{hero}_Classic") ||
					(hero == Hero.Junkrat && weaponSkin == WeaponSkin.Junkrat_DrJunkenstein) ||
					(hero == Hero.Mercy && weaponSkin == WeaponSkin.Mercy_Witch) ||
					(hero == Hero.Reaper && weaponSkin == WeaponSkin.Reaper_Dracula) ||
					(hero == Hero.Roadhog && weaponSkin == WeaponSkin.Roadhog_JunkensteinsMonster) ||
					(hero == Hero.Orisa && weaponSkin == WeaponSkin.Orisa_NullSector) ||
					(hero == Hero.UprisingEvent_00000173 && weaponSkin == WeaponSkin.UprisingEvent_00000173_Classic) ||
					(hero == Hero.UprisingEvent_00000178 && weaponSkin == WeaponSkin.UprisingEvent_00000178_Classic) ||
					(hero == Hero.UprisingEvent_00000179 && weaponSkin == WeaponSkin.UprisingEvent_00000179_Classic) ||
					(hero == Hero.RetributionEvent_000001AC && weaponSkin == WeaponSkin.RetributionEvent_000001AC_Classic) ||
					(hero == Hero.RetributionEvent_000001B8 && weaponSkin == WeaponSkin.RetributionEvent_000001B8_Classic) ||
					(hero == Hero.RetributionEvent_000001BA && weaponSkin == WeaponSkin.RetributionEvent_000001BA_Classic) ||
					(hero == Hero.RetributionEvent_000001BB && weaponSkin == WeaponSkin.RetributionEvent_000001BB_Classic) ||
					(hero == Hero.RetributionEvent_000001CE && weaponSkin == WeaponSkin.RetributionEvent_000001CE_Classic)
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
			Console.WriteLine($"  Unknown In V17:   {unknownInV17}");
			Console.WriteLine("}");
		}
	}
}
