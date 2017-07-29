using System;
using System.Diagnostics;
using System.IO;

namespace OverwatchHighlights
{
	class HighlightInfo
	{
		public string playerName;
		public byte unknown1;
		public uint unknown2;
		public uint unknown3;
		public Vec2 unknown4;
		public uint unknown4a;
		public Vec3 unknown5;
		public Vec3 unknown6;
		public Vec3 maybeUpVector;
		public Hero hero;
		public Skin skin;
		public WeaponSkin weaponSkin;
		public HighlightIntro highlightIntro;
		public ulong unknownUnlock;
		public ulong timestamp;
		public HighlightUUID uuid;

		public HighlightInfo(BinaryReader br, BuildNumber build, Map map)
		{
			// player name of the highlight protagonist (will differ for other people's POTGs)
			this.playerName = br.ReadNullPaddedUTF8();

			// 0 for normal, 1 for potg, 4 for unknown
			this.unknown1 = br.ReadByte();
			Debug.Assert(unknown1 == 0 || unknown1 == 1 || unknown1 == 4);

			this.unknown2 = br.ReadUInt32();
			Debug.Assert((unknown2 & 0x80000000u) == 0x80000000u);
			Debug.Assert((unknown2 & 0x7FFFFFFFu) <= 0x0000FFFFu);

			this.unknown3 = br.ReadUInt32();
			Debug.Assert((unknown3 & 0x80000000u) == 0x80000000u);
			Debug.Assert((unknown3 & 0x7FFFFFFFu) <= 0x0000FFFFu);
			
			this.unknown4 = br.ReadVec2();
			Debug.Assert(unknown4.IsFinite());
			this.unknown4a = br.ReadUInt32();

			this.unknown5 = br.ReadVec3();
			Debug.Assert(unknown5.IsFinite());

			this.unknown6 = br.ReadVec3();
			Debug.Assert(unknown6.IsFinite());
			Debug.Assert(unknown6.IsUnitVector());

			this.maybeUpVector = br.ReadVec3();
			Debug.Assert(maybeUpVector.IsFinite());
			Debug.Assert(maybeUpVector.IsUnitVector());

			this.hero = br.ReadHero64();
			this.skin = br.ReadSkin64();
			this.weaponSkin = br.ReadWeaponSkin64();
			this.highlightIntro = br.ReadHighlightIntro64();

			// zero if unknown1 is 4, high value otherwise
			this.unknownUnlock = br.ReadUInt64();
			if (unknown1 == 4)
			{
				Debug.Assert(unknownUnlock == 0);
			}
			else
			{
				// assert that the top 32 bits are 08300000
				Debug.Assert((unknownUnlock & 0xFFFFFFFF00000000ul) == 0x0830000000000000ul);

				// I believe these are the only values?
				Debug.Assert((unknownUnlock == 0x0830000000000001) || (unknownUnlock == 0x0830000000000003));
			}

			this.timestamp = br.ReadUInt64();
			this.uuid = new HighlightUUID(br);

			Tracer.TraceNoDupe("highlightInfo.unknownUnlock", $"{unknownUnlock:X16} {unknown1}");

			if (Enum.IsDefined(typeof(Skin), this.skin) && Enum.IsDefined(typeof(WeaponSkin), weaponSkin))
			{
				Debug.Assert(this.weaponSkin.ToString().StartsWith(this.skin.ToString()) || this.weaponSkin.ToString().Contains("weapon"));
			}
			else if (Enum.IsDefined(typeof(Skin), this.skin) || Enum.IsDefined(typeof(WeaponSkin), weaponSkin))
			{
				Debug.Assert(false, $"defined only one of skin {this.skin} and weaponskin {this.weaponSkin}");
			}

			Debug.Assert(this.unknown3 >= this.unknown2);

			Tracer.TraceNoDupe("highlightInfo.unknown2 & unknown3", $"{this.unknown2:X8} {this.unknown3:X8}");
		}

		public void Print()
		{
			Console.WriteLine("{");
			var time = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp).ToLocalTime();
			Console.WriteLine($"  UUID: {uuid}");
			Console.WriteLine($"  Timestamp: {time}");
			Console.WriteLine($"  Player Name: {playerName}");
			Console.WriteLine($"  Hero: {hero}");
			Console.WriteLine($"  Skin: {skin}");
			Console.WriteLine($"  Weapon: {weaponSkin}");
			Console.WriteLine($"  Intro: {highlightIntro}");
			Console.WriteLine($"  Unknown Unlock: {unknownUnlock:X16}");
			Console.WriteLine($"  Unknown1: {unknown1}");
			Console.WriteLine($"  Unknown2: {unknown2:X8}");
			Console.WriteLine($"  Unknown3: {unknown3:X8}");
			Console.WriteLine($"  Unknown4: {unknown4}");
			Console.WriteLine($"  Unknown4a: {unknown4a}");
			Console.WriteLine($"  Unknown5: {unknown5}");
			Console.WriteLine($"  Unknown6: {unknown6}");
			Console.WriteLine($"  Maybe Up Vector: {maybeUpVector}");
			Console.WriteLine("}");
		}

		public static bool operator ==(HighlightInfo a, HighlightInfo b)
		{
			if ((object)a == null && (object)b == null)
				return true;
			else if ((object)a == null || (object)b == null)
				return false;

			if (a.playerName != b.playerName)
				return false;
			if (a.unknown1 != b.unknown1)
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
			if (a.maybeUpVector != b.maybeUpVector)
				return false;
			if (a.hero != b.hero)
				return false;
			if (a.skin != b.skin)
				return false;
			if (a.weaponSkin != b.weaponSkin)
				return false;
			if (a.highlightIntro != b.highlightIntro)
				return false;
			if (a.unknownUnlock != b.unknownUnlock)
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
