using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace OverwatchHighlights
{
	static partial class Extensions
	{
		public static string GetFilename(this BinaryReader br)
		{
			if (br.BaseStream is FileStream)
				return new FileInfo(((FileStream)br.BaseStream).Name).Name;
			else
				throw new Exception("Tried to get filename from a BinaryReader that isn't operating on a file!");
		}

		public static BinaryReader CreateBinaryReader(this byte[] bytes)
		{
			return new BinaryReader(new MemoryStream(bytes) { Position = 0 });
		}

		public static bool IsEqualTo(this byte[] a, byte[] b)
		{
			if (a.Length != b.Length)
				return false;
			for (int i = 0; i < a.Length; ++i)
				if (a[i] != b[i])
					return false;
			return true;
		}

		public static string ReadNullPaddedUTF8(this BinaryReader br)
		{
			List<byte> bytes = new List<byte>();
			byte b;
			while ((b = br.ReadByte()) != 0)
				bytes.Add(b);
			return Encoding.UTF8.GetString(bytes.ToArray());
		}

		public static uint[] ReadUInt32s(this BinaryReader br, int count)
		{
			uint[] buffer = new uint[count];
			for (int i = 0; i < count; ++i)
				buffer[i] = br.ReadUInt32();
			return buffer;
		}

		public static byte PeekByte(this BinaryReader br)
		{
			byte value = br.ReadByte();
			br.BaseStream.Position -= 1;
			return value;
		}

		public static uint PeekUInt32(this BinaryReader br)
		{
			uint value = br.ReadUInt32();
			br.BaseStream.Position -= sizeof(uint);
			return value;
		}

		public static HighlightType ReadHighlightType64(this BinaryReader br)
		{
			const ulong HighlightTypeMask = 0x0830000000000000ul;
			ulong value = br.ReadUInt64();
			Debug.Assert((value & 0xFFFFFFFF00000000ul) == HighlightTypeMask || value == 0);
			HighlightType type = (HighlightType)(value & 0xFFFFFFFFu);
			Debug.Assert(Enum.IsDefined(typeof(HighlightType), type));
			return type;
		}

		public static Hero ReadHero64(this BinaryReader br)
		{
			const ulong HeroMask = 0x02E0000000000000ul;
			ulong value = br.ReadUInt64();
			Debug.Assert((value & 0xFFFFFFFF00000000ul) == HeroMask);
			Hero hero = (Hero)(value & 0xFFFFFFFFu);
			Debug.Assert(Enum.IsDefined(typeof(Hero), hero));
			return hero;
		}

		public static Skin ReadSkin64(this BinaryReader br)
		{
			const ulong SkinMask = 0x0A50000000000000ul;
			ulong value = br.ReadUInt64();
			Debug.Assert((value & 0xFFFFFFFF00000000ul) == SkinMask);
			Skin skin = (Skin)(value & 0xFFFFFFFFu);
			//Debug.Assert(Enum.IsDefined(typeof(Skin), skin));
			return skin;
		}

		public static Map ReadMap64(this BinaryReader br)
		{
			const ulong MapMask = 0x0800000000000000ul;
			ulong value = br.ReadUInt64();
			Debug.Assert((value & 0xFFFFFFFF00000000ul) == MapMask);
			Map map = (Map)(value & 0xFFFFFFFFu);
			Debug.Assert(Enum.IsDefined(typeof(Map), map));
			return map;
		}

		public static HighlightIntro ReadHighlightIntro64(this BinaryReader br)
		{
			const ulong HighlightIntroMask = 0x0250000000000000ul;
			ulong value = br.ReadUInt64();
			Debug.Assert((value & 0xFFFFFFFF00000000ul) == HighlightIntroMask || value == 0);
			HighlightIntro intro = (HighlightIntro)(value & 0xFFFFFFFFu);
			//Debug.Assert(Enum.IsDefined(typeof(HighlightIntro), intro));
			return intro;
		}

		public static WeaponSkin ReadWeaponSkin64(this BinaryReader br)
		{
			const ulong WeaponSkinMask = 0x0350000000000000ul;
			ulong value = br.ReadUInt64();
			Debug.Assert((value & 0xFFFFFFFF00000000ul) == WeaponSkinMask);
			WeaponSkin weaponSkin = (WeaponSkin)(value & 0xFFFFFFFFu);
			//Debug.Assert(Enum.IsDefined(typeof(WeaponSkin), weaponSkin));
			return weaponSkin;
		}

		public static GameMode ReadGameMode64(this BinaryReader br)
		{
			const ulong GameModeMask = 0x0230000000000000ul;
			ulong value = br.ReadUInt64();
			Debug.Assert((value & 0xFFFFFFFF00000000ul) == GameModeMask || value == 0);
			GameMode gameMode = (GameMode)(value & 0xFFFFFFFFu);
			Debug.Assert(Enum.IsDefined(typeof(GameMode), gameMode));
			return gameMode;
		}

		public static HighlightType ReadHighlightType32(this BinaryReader br)
		{
			HighlightType type = (HighlightType)br.ReadUInt32();
			Debug.Assert(Enum.IsDefined(typeof(HighlightType), type));
			return type;
		}

		public static Hero ReadHero32(this BinaryReader br)
		{
			Hero hero = (Hero)br.ReadUInt32();
			Debug.Assert(Enum.IsDefined(typeof(Hero), hero));
			return hero;
		}

		public static Skin ReadSkin32(this BinaryReader br)
		{
			Skin skin = (Skin)br.ReadUInt32();
			//Debug.Assert(Enum.IsDefined(typeof(Skin), skin));
			return skin;
		}

		public static Spray ReadSpray32(this BinaryReader br)
		{
			Spray spray = (Spray)br.ReadUInt32();
			//Debug.Assert(Enum.IsDefined(typeof(Spray), spray));
			return spray;
		}

		public static Emote ReadEmote32(this BinaryReader br)
		{
			Emote emote = (Emote)br.ReadUInt32();
			//Debug.Assert(Enum.IsDefined(typeof(Emote), emote));
			return emote;
		}

		public static VoiceLine ReadVoiceLine32(this BinaryReader br)
		{
			VoiceLine voiceLine = (VoiceLine)br.ReadUInt32();
			//Debug.Assert(Enum.IsDefined(typeof(VoiceLine), voiceLine));
			return voiceLine;
		}

		public static HighlightIntro ReadHighlightIntro32(this BinaryReader br)
		{
			HighlightIntro intro = (HighlightIntro)br.ReadUInt32();
			//Debug.Assert(Enum.IsDefined(typeof(HighlightIntro), intro));
			return intro;
		}

		public static WeaponSkin ReadWeaponSkin32(this BinaryReader br)
		{
			WeaponSkin weaponSkin = (WeaponSkin)br.ReadUInt32();
			//Debug.Assert(Enum.IsDefined(typeof(WeaponSkin), weaponSkin));
			return weaponSkin;
		}

		public static Spray[] ReadSpray32s(this BinaryReader br, int count)
		{
			Spray[] sprays = new Spray[count];
			for (int i = 0; i < count; ++i)
				sprays[i] = br.ReadSpray32();
			return sprays;
		}

		public static Emote[] ReadEmote32s(this BinaryReader br, int count)
		{
			Emote[] emotes = new Emote[count];
			for (int i = 0; i < count; ++i)
				emotes[i] = br.ReadEmote32();
			return emotes;
		}

		public static VoiceLine[] ReadVoiceLine32s(this BinaryReader br, int count)
		{
			VoiceLine[] voiceLines = new VoiceLine[count];
			for (int i = 0; i < count; ++i)
				voiceLines[i] = br.ReadVoiceLine32();
			return voiceLines;
		}

		public static Vec2 ReadVec2(this BinaryReader br)
		{
			float x = br.ReadSingle();
			float y = br.ReadSingle();
			return new Vec2(x, y);
		}

		public static Vec3 ReadVec3(this BinaryReader br)
		{
			float x = br.ReadSingle();
			float y = br.ReadSingle();
			float z = br.ReadSingle();
			return new Vec3(x, y, z);
		}
	}
}
