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

		public HeroWithUnlockables(BinaryReader br)
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
					(hero == Hero.Reaper && skin == Skin.Reaper_skin_00001BEB)
				);
				Debug.Assert(
					($"{weaponSkin}" == $"{hero}_Classic") ||
					(hero == Hero.Reaper && weaponSkin == WeaponSkin.Reaper_skin_00001BEB_weapon_00002AA8)
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
