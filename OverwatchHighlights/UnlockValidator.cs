﻿using System;
using System.Diagnostics;
using System.Linq;

namespace OverwatchHighlights
{
	static class UnlockValidator
	{
		public static void Run()
		{
			var allSkins = GetEnumValues<Skin>();
			var allWeapons = GetEnumValues<WeaponSkin>();
			var allEmotes = GetEnumValues<Emote>();
			var allIntros = GetEnumValues<HighlightIntro>();
			var allVoiceLines = GetEnumValues<VoiceLine>();
			var allSprays = GetEnumValues<Spray>();

			// ensure no skin has more than 2 weapons
			foreach (var skin in allSkins)
			{
				var matchingWeapons = allWeapons.Where(weapon => weapon.ToString().StartsWith(skin.ToString()));
				Debug.Assert(matchingWeapons.Count() <= 2, $"Skin {skin} should have no more than 2 weapons, found {matchingWeapons.Count()}");
			}

			// ensure every weapon has a matching skin
			foreach (var weapon in allWeapons)
			{
				var matchingSkins = allSkins.Where(skin => weapon.ToString().StartsWith(skin.ToString()));
				Debug.Assert(matchingSkins.Count() == 1, $"Weapon {weapon} should have exactly 1 matching skin, found {matchingSkins.Count()}");
			}

			foreach (var skin in allSkins)
			{
				if (skin.ToString().Contains("_skin_"))
				{
					Debug.Assert(skin.ToString().EndsWith($"_{(int)skin:X8}"));
				}
			}
			foreach (var weapon in allWeapons)
			{
				if (weapon.ToString().Contains("_weapon_"))
				{
					Debug.Assert(weapon.ToString().EndsWith($"_{(int)weapon:X8}"));
				}
			}
			foreach (var emote in allEmotes)
			{
				if (emote.ToString().Contains("_emote_"))
				{
					Debug.Assert(emote.ToString().EndsWith($"_{(int)emote:X8}"));
				}
			}
			foreach (var intro in allIntros)
			{
				if (intro.ToString().Contains("_intro_"))
				{
					Debug.Assert(intro.ToString().EndsWith($"_{(int)intro:X8}"));
				}
			}
			foreach (var voiceLine in allVoiceLines)
			{
				if (voiceLine.ToString().Contains("_voiceline_"))
				{
					Debug.Assert(voiceLine.ToString().EndsWith($"_{(int)voiceLine:X8}"));
				}
			}
			foreach (var spray in allSprays)
			{
				if (spray.ToString().Contains("_spray_"))
				{
					Debug.Assert(spray.ToString().EndsWith($"_{(int)spray:X8}"));
				}
			}
		}

		public static void RunForHeroWithUnlocks(Hero hero, Skin skin, WeaponSkin weapon, HighlightIntro intro, Spray[] sprays = null, Emote[] emotes = null, VoiceLine[] voiceLines = null)
		{
			if (sprays!=null)
			{
				foreach (var spray in sprays)
				{
					if (IsDefined(spray))
					{
						Debug.Assert(spray.ToString().StartsWith($"{hero}_") || spray.ToString().StartsWith("Common_"), $"Spray {spray} should belong to '{hero}', maybe it's a Common spray?");
						if (spray.ToString().StartsWith($"{hero}_spray_"))
						{
							Debug.Assert(spray.ToString() == $"{hero}_spray_{(int)spray:X8}");
						}
						else if (spray.ToString().StartsWith($"Common_spray_"))
						{
							Debug.Assert(spray.ToString() == $"Common_spray_{(int)spray:X8}");
						}
					}
				}
			}
			if (voiceLines != null)
			{
				foreach (var voiceLine in voiceLines)
				{
					if (IsDefined(voiceLine))
					{
						Debug.Assert(voiceLine.ToString().StartsWith($"{hero}_"));
						if (voiceLine.ToString().StartsWith($"{hero}_voiceline_"))
						{
							Debug.Assert(voiceLine.ToString() == $"{hero}_voiceline_{(int)voiceLine:X8}");
						}
					}
				}
			}
			if (emotes != null)
			{
				foreach (var emote in emotes)
				{
					if (IsDefined(emote))
					{
						Debug.Assert(emote.ToString().StartsWith($"{hero}_"));
						if (emote.ToString().StartsWith($"{hero}_emote_"))
						{
							Debug.Assert(emote.ToString() == $"{hero}_emote_{(int)emote:X8}");
						}
					}
				}
			}
			if (IsDefined(skin))
			{
				Debug.Assert(skin.ToString().StartsWith($"{hero}_"));
				if (skin.ToString().StartsWith($"{hero}_skin_"))
				{
					Debug.Assert(skin.ToString() == $"{hero}_skin_{(int)skin:X8}");
				}
			}
			if (IsDefined(weapon))
			{
				Debug.Assert(weapon.ToString().StartsWith($"{hero}_"));
				if (weapon.ToString().StartsWith($"{hero}_skin_"))
				{
					Debug.Assert(weapon.ToString() == $"{hero}_skin_{(int)skin:X8}_weapon_{(int)weapon:X8}");
				}
			}
			if (IsDefined(intro) && intro != HighlightIntro.None)
			{
				Debug.Assert(intro.ToString().StartsWith($"{hero}_"));
				if (intro.ToString().StartsWith($"{hero}_intro_"))
				{
					Debug.Assert(intro.ToString() == $"{hero}_intro_{(int)intro:X8}");
				}
			}
			if (IsDefined(skin) && IsDefined(weapon))
			{
				Debug.Assert(weapon.ToString().StartsWith(skin.ToString()));
			}
			else if (IsDefined(skin) && !IsDefined(weapon))
			{
				Debug.Assert(false, $"Defined skin {skin} but corresponding weapon {(int)weapon:X8} is not defined");
			}
			else if (!IsDefined(skin) && IsDefined(weapon))
			{
				Debug.Assert(false, $"Defined weapon {weapon} but corresponding skin {(int)skin:X8} is not defined");
			}

			TraceUnlocks(hero, skin, weapon, intro, sprays, emotes, voiceLines);
		}

		private static void TraceUnlocks(Hero hero, Skin skin, WeaponSkin weapon, HighlightIntro intro, Spray[] sprays = null, Emote[] emotes = null, VoiceLine[] voiceLines = null)
		{
			if (sprays != null)
			{
				foreach (var spray in sprays)
				{
					if (!IsDefined(spray))
					{
						Tracer.TraceNoDupe("unlocks.sprays", $"{hero}_spray_{(int)spray:X8} = 0x{(int)spray:X8},");
					}
				}
			}
			if (voiceLines != null)
			{
				foreach (var voiceLine in voiceLines)
				{
					if (!IsDefined(voiceLine))
					{
						Tracer.TraceNoDupe("unlocks.voiceLines", $"{hero}_voiceline_{(int)voiceLine:X8} = 0x{(int)voiceLine:X8},");
					}
				}
			}
			if (emotes != null)
			{
				foreach (var emote in emotes)
				{
					if (!IsDefined(emote))
					{
						Tracer.TraceNoDupe("unlocks.emotes", $"{hero}_emote_{(int)emote:X8} = 0x{(int)emote:X8},");
					}
				}
			}
			if (!IsDefined(skin))
			{
				Tracer.TraceNoDupe("unlocks.skins", $"{hero}_skin_{(int)skin:X8} = 0x{(int)skin:X8},");
			}
			if (!IsDefined(intro))
			{
				Tracer.TraceNoDupe("unlocks.highlightIntros", $"{hero}_intro_{(int)intro:X8} = 0x{(int)intro:X8},");
			}
			if (!IsDefined(weapon))
			{
				if (IsDefined(skin))
					Tracer.TraceNoDupe("unlocks.weaponskins", $"{skin}_weapon_{(int)weapon:X8} = 0x{(int)weapon:X8},");
				else
					Tracer.TraceNoDupe("unlocks.weaponskins", $"{hero}_skin_{(int)skin:X8}_weapon_{(int)weapon:X8} = 0x{(int)weapon:X8},");
			}
		}

		private static bool IsDefined<T>(T value)
		{
			return Enum.IsDefined(typeof(T), value);
		}

		private static T[] GetEnumValues<T>()
		{
			return (T[])Enum.GetValues(typeof(T));
		}
	}
}
