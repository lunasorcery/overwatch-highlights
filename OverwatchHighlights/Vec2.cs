using System;

namespace OverwatchHighlights
{
	struct Vec2
	{
		public float x, y;

		public Vec2(float xy)
		{
			x = y = xy;
		}

		public Vec2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public float Length
		{
			get { return (float)Math.Sqrt(x * x + y * y); }
		}

		public bool IsUnitVector()
		{
			const float EPSILON = 0.0001f;
			return Math.Abs(this.Length - 1) < EPSILON;
		}

		public bool IsFinite()
		{
			if (float.IsNaN(x) || float.IsNaN(y))
				return false;
			if (float.IsInfinity(x) || float.IsInfinity(y))
				return false;
			return true;
		}

		public static bool operator ==(Vec2 a, Vec2 b)
		{
			return a.x == b.x && a.y == b.y;
		}

		public static bool operator !=(Vec2 a, Vec2 b)
		{
			return !(a == b);
		}

		public override string ToString()
		{
			return $"({x}, {y})";
		}
	}
}
