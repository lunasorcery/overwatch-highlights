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

			if (Enum.IsDefined(typeof(Skin), this.skin) && Enum.IsDefined(typeof(WeaponSkin), weaponSkin))
			{
				Debug.Assert(this.weaponSkin.ToString().StartsWith(this.skin.ToString()) || this.weaponSkin.ToString().Contains("weapon"));
			}
			else if (Enum.IsDefined(typeof(Skin), this.skin) || Enum.IsDefined(typeof(WeaponSkin), weaponSkin))
			{
				Debug.Assert(false, $"defined only one of skin {this.skin} and weaponskin {this.weaponSkin}");
			}

			this.highlightIntro = br.ReadHighlightIntro32();

			int numSprays = br.ReadInt32();
			this.sprays = br.ReadSpray32s(numSprays);

			int numVoiceLines = br.ReadInt32();
			this.voiceLines = br.ReadVoiceLine32s(numVoiceLines);

			int numEmotes = br.ReadInt32();
			this.emotes = br.ReadEmote32s(numEmotes);

			this.hero = br.ReadHero64();

			// AI players in custom matches have no HighlightIntro, no unlocks, and always use classic skins
			if (highlightIntro == HighlightIntro.None)
			{
				Debug.Assert(this.sprays.Length == 0);
				Debug.Assert(this.voiceLines.Length == 0);
				Debug.Assert(this.emotes.Length == 0);
				Debug.Assert($"{skin}" == $"{hero}_Classic");
				Debug.Assert($"{weaponSkin}" == $"{hero}_Classic");
			}

			// Ensure that sprays are correctly mapped to heroes
			foreach (var spray in sprays)
			{
				if (Enum.IsDefined(typeof(Spray), spray))
				{
					Debug.Assert(spray.ToString().StartsWith(hero.ToString()) || spray.ToString().StartsWith("Common"));
				}
			}

			// Trace all of the unknown unlocks so I can add entries for them
			foreach (var spray in sprays)
			{
				if (!Enum.IsDefined(typeof(Spray), spray))
				{
					Tracer.TraceNoDupe("sprays", $"{hero}_spray = 0x{(int)spray:X8},");
				}
			}
			foreach (var voiceLine in voiceLines)
			{
				if (!Enum.IsDefined(typeof(VoiceLine), voiceLine))
				{
					Tracer.TraceNoDupe("voiceLines", $"{hero}_voiceline = 0x{(int)voiceLine:X8},");
				}
			}
			foreach (var emote in emotes)
			{
				if (!Enum.IsDefined(typeof(Emote), emote))
				{
					Tracer.TraceNoDupe("emotes", $"{hero}_emote = 0x{(int)emote:X8},");
				}
			}
			if (!Enum.IsDefined(typeof(Skin), skin))
			{
				Tracer.TraceNoDupe("skins", $"{hero}_skin = 0x{(int)skin:X8},");
			}
			if (!Enum.IsDefined(typeof(HighlightIntro), highlightIntro))
			{
				Tracer.TraceNoDupe("highlightIntros", $"{hero}_intro = 0x{(int)highlightIntro:X8},");
			}
			if (!Enum.IsDefined(typeof(WeaponSkin), weaponSkin))
			{
				Tracer.TraceNoDupe("weaponskins", $"{skin}_weapon = 0x{(int)weaponSkin:X8},");
			}
		}

		public void Print()
		{
			Console.WriteLine("{");
			Console.WriteLine($"Hero: {hero}");
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
