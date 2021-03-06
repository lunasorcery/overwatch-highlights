﻿using System;
using System.Diagnostics;
using System.IO;

namespace OverwatchHighlights
{
	class HighlightInfo
	{
		public string playerName;
		public HighlightTypeFlag typeFlags;
		public uint unknown2;
		public uint unknown3;
		public float unknown4; // possibly a score, given that it's only for non-manual highlights...
		public float unknown5;
		public uint unknown6;
		public uint unknown7;
		public Vec3 highlightIntroPosition;
		public Vec3 highlightIntroDirection;
		public Vec3 upVector;
		public Hero hero;
		public Skin skin;
		public WeaponSkin weaponSkin;
		public ulong unknown8;
		public ulong unknown9;
		public HighlightIntro highlightIntro;
		public HighlightCategory category;
		public ulong timestamp;
		public HighlightUUID uuid;

		[Flags]
		public enum HighlightTypeFlag : byte
		{
			Top5       = 0x00,
			POTG       = 0x01,
			//Unknown_02 = 0x02, // never observed
			Manual     = 0x04,
			Unknown_08 = 0x08,
			Unknown_10 = 0x10,
			Unknown_20 = 0x20,
			Unknown_40 = 0x40,
			Unknown_80 = 0x80,
		}

		public HighlightInfo(BinaryReader br, MajorVersion gameMajorVersion)
		{
			// player name of the highlight protagonist (will differ for other people's POTGs)
			this.playerName = br.ReadNullPaddedUTF8();

			// wheeeeeeee
			if (gameMajorVersion >= new MajorVersion(1, 16, VersionBranch.None))
			{
				byte unknown1 = br.ReadByte();
				Debug.Assert(unknown1 == 0);
			}

			// 1 for potg, 0 for top5 highlight, 4 for manual highlight
			this.typeFlags = (HighlightTypeFlag)br.ReadByte();
			Debug.Assert(Extensions.AreAllFlagsDefined(typeFlags));

			this.unknown2 = br.ReadUInt32();
			Debug.Assert((unknown2 & 0x80000000u) == 0x80000000u);
			Debug.Assert((unknown2 & 0x7FFFFFFFu) <= 0x0000FFFFu);

			this.unknown3 = br.ReadUInt32();
			Debug.Assert((unknown3 & 0x80000000u) == 0x80000000u);
			Debug.Assert((unknown3 & 0x7FFFFFFFu) <= 0x0000FFFFu);

			Debug.Assert(unknown3 >= unknown2);

			this.unknown4 = br.ReadSingle();
			Debug.Assert(!float.IsInfinity(unknown4) && !float.IsNaN(unknown4));

			this.unknown5 = br.ReadSingle();
			Debug.Assert(!float.IsInfinity(unknown5) && !float.IsNaN(unknown5));

			// seems to be nonzero if the player starts the highlight in the air - elevation?
			this.unknown6 = br.ReadUInt32();

			if (gameMajorVersion >= new MajorVersion(1, 17, VersionBranch.None))
			{
				// 0 for defense team, 1 for attack team. not sure how this handles oasis/nepal/ilios/lijiangtower yet
				this.unknown7 = br.ReadUInt32();
				Debug.Assert(unknown7 == 0 || unknown7 == 1 || unknown7 == 4);
			}

			this.highlightIntroPosition = br.ReadVec3();
			Debug.Assert(highlightIntroPosition.IsFinite());

			this.highlightIntroDirection = br.ReadVec3();
			Debug.Assert(highlightIntroDirection.IsFinite());
			Debug.Assert(highlightIntroDirection.IsUnitVector());

			this.upVector = br.ReadVec3();
			Debug.Assert(upVector.IsFinite());
			Debug.Assert(upVector.IsUnitVector());
			Debug.Assert(Math.Round(upVector.x) == 0);
			Debug.Assert(Math.Round(upVector.y) == 1);
			Debug.Assert(Math.Round(upVector.z) == 0);

			this.hero = br.ReadHero64();
			this.skin = br.ReadSkin64();
			this.weaponSkin = br.ReadWeaponSkin64();

			// at a hazy guess these might be to do with the new country-specific skins for the world cup?
			if (gameMajorVersion >= new MajorVersion(1, 17, VersionBranch.None))
			{
				this.unknown8 = br.ReadUInt64();
				Debug.Assert(unknown8 == 0);
				this.unknown9 = br.ReadUInt64();
				Debug.Assert(unknown9 == 0);
			}

			this.highlightIntro = br.ReadHighlightIntro64();

			this.category = br.ReadHighlightCategory64();

			this.timestamp = br.ReadUInt64();
			this.uuid = new HighlightUUID(br);

			UnlockValidator.RunForHeroWithUnlocks(hero, skin, weaponSkin, highlightIntro);

			Debug.Assert(this.unknown3 >= this.unknown2);
		}

		public DateTime GetTimeUTC()
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.timestamp);
		}

		public void Print()
		{
			Console.WriteLine("{");
			Console.WriteLine($"  UUID: {uuid}");
			Console.WriteLine($"  Timestamp: {GetTimeUTC().ToLocalTime()}");
			Console.WriteLine($"  Player Name: {playerName}");
			Console.WriteLine($"  Hero: {hero}");
			Console.WriteLine($"  Skin: {skin}");
			Console.WriteLine($"  Weapon: {weaponSkin}");
			Console.WriteLine($"  Intro: {highlightIntro}");
			Console.WriteLine($"  Category: {category}");
			Console.WriteLine($"  Type: {typeFlags}");
			Console.WriteLine($"  Unknown2: {unknown2:X8}");
			Console.WriteLine($"  Unknown3: {unknown3:X8}");
			Console.WriteLine($"  Unknown4: {unknown4}");
			Console.WriteLine($"  Unknown5: {unknown5}");
			Console.WriteLine($"  Unknown6: {unknown6}");
			Console.WriteLine($"  Unknown7: {unknown7}");
			Console.WriteLine($"  Unknown8: {unknown8:X16}");
			Console.WriteLine($"  Unknown9: {unknown9:X16}");
			Console.WriteLine($"  Highlight Intro Position: {highlightIntroPosition}");
			Console.WriteLine($"  Highlight Intro Direction: {highlightIntroDirection}");
			Console.WriteLine($"  Up Vector: {upVector}");
			Console.WriteLine("}");
		}

		public static bool EqualWithTypeMasking(HighlightInfo a, HighlightInfo b)
		{
			if ((object)a == null && (object)b == null)
				return true;
			else if ((object)a == null || (object)b == null)
				return false;

			if (a.playerName != b.playerName)
				return false;
			//if (((int)a.type & (int)b.type) == 0)
			if(((int)a.typeFlags & 0x5) != ((int)b.typeFlags & 0x5))
				return false;
			if (a.unknown2 != b.unknown2)
				return false;
			if (a.unknown3 != b.unknown3)
				return false;
			if (a.unknown4 != b.unknown4)
				return false;
			if (a.unknown5 != b.unknown5)
				return false;
			if (a.unknown6 != b.unknown6)
				return false;
			if (a.unknown7 != b.unknown7)
				return false;
			if (a.highlightIntroPosition != b.highlightIntroPosition)
				return false;
			if (a.highlightIntroDirection != b.highlightIntroDirection)
				return false;
			if (a.upVector != b.upVector)
				return false;
			if (a.hero != b.hero)
				return false;
			if (a.skin != b.skin)
				return false;
			if (a.weaponSkin != b.weaponSkin)
				return false;
			if (a.unknown8 != b.unknown8)
				return false;
			if (a.unknown9 != b.unknown9)
				return false;
			if (a.highlightIntro != b.highlightIntro)
				return false;
			if (a.category != b.category)
				return false;
			if (a.timestamp != b.timestamp)
				return false;
			if (a.uuid != b.uuid)
				return false;
			return true;
		}

		public static bool operator ==(HighlightInfo a, HighlightInfo b)
		{
			if ((object)a == null && (object)b == null)
				return true;
			else if ((object)a == null || (object)b == null)
				return false;

			if (a.playerName != b.playerName)
				return false;
			if (a.typeFlags != b.typeFlags)
				return false;
			if (a.unknown2 != b.unknown2)
				return false;
			if (a.unknown3 != b.unknown3)
				return false;
			if (a.unknown4 != b.unknown4)
				return false;
			if (a.unknown5 != b.unknown5)
				return false;
			if (a.unknown6 != b.unknown6)
				return false;
			if (a.unknown7 != b.unknown7)
				return false;
			if (a.highlightIntroPosition != b.highlightIntroPosition)
				return false;
			if (a.highlightIntroDirection != b.highlightIntroDirection)
				return false;
			if (a.upVector != b.upVector)
				return false;
			if (a.hero != b.hero)
				return false;
			if (a.skin != b.skin)
				return false;
			if (a.weaponSkin != b.weaponSkin)
				return false;
			if (a.unknown8 != b.unknown8)
				return false;
			if (a.unknown9 != b.unknown9)
				return false;
			if (a.highlightIntro != b.highlightIntro)
				return false;
			if (a.category != b.category)
				return false;
			if (a.timestamp != b.timestamp)
				return false;
			if (a.uuid != b.uuid)
				return false;
			return true;
		}

		public static bool operator !=(HighlightInfo a, HighlightInfo b)
		{
			return !(a == b);
		}
	}
}
