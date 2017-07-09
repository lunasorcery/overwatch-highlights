using System;

namespace OverwatchHighlights
{
	struct Vec3
	{
		public float x, y, z;

		public Vec3(float xyz)
		{
			x = y = z = xyz;
		}

		public Vec3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public float Length
		{
			get { return (float)Math.Sqrt(x * x + y * y + z * z); }
		}

		public bool IsUnitVector()
		{
			const float EPSILON = 0.0001f;
			return Math.Abs(this.Length - 1) < EPSILON;
		}

		public bool IsFinite()
		{
			if (float.IsNaN(x) || float.IsNaN(y) || float.IsNaN(z))
				return false;
			if (float.IsInfinity(x) || float.IsInfinity(y) || float.IsInfinity(z))
				return false;
			return true;
		}

		public static bool operator ==(Vec3 a, Vec3 b)
		{
			return a.x == b.x && a.y == b.y && a.z == b.z;
		}

		public static bool operator !=(Vec3 a, Vec3 b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"({x}, {y}, {z})";
		}
	}
}
