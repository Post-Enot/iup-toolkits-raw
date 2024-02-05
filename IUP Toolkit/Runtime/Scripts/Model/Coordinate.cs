using System;

namespace IUP.Toolkits
{
    public readonly struct Coordinate : IEquatable<Coordinate>
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public const int UnableX_Value = -1;
        public const int UnableY_Value = -1;
        public const int DirectionX_Left  = -1;
        public const int DirectionX_Right =  1;
        public const int DirectionY_Up    =  1;
        public const int DirectionY_Down  = -1;

        public static Coordinate UnablePosition => new(UnableX_Value, UnableY_Value);
        public static Coordinate DirectionZero => new(0, 0);
        public static Coordinate DirectionUp => new(0, DirectionY_Up);
        public static Coordinate DirectionDown => new(0, DirectionY_Down);
        public static Coordinate DirectionLeft => new(DirectionX_Left, 0);
        public static Coordinate DirectionRight => new(DirectionX_Right, 0);
        public static Coordinate DirectionUpLeft => new(DirectionX_Left, DirectionY_Up);
        public static Coordinate DirectionUpRight => new(DirectionX_Right, DirectionY_Up);
        public static Coordinate DirectionDownLeft => new(DirectionX_Left, DirectionY_Down);
        public static Coordinate DirectionDownRight => new(DirectionX_Right, DirectionY_Down);

        public readonly int X;
        public readonly int Y;

        public readonly int L1_Distance(Coordinate destination)
            => Math.Abs(X - destination.X) + Math.Abs(Y - destination.Y);

        public readonly bool InBounds(Coordinate minBound, Coordinate maxBound)
            => X.InBounds(minBound.X, maxBound.X) && Y.InBounds(minBound.Y, maxBound.Y);

        public readonly bool Equals(Coordinate other) => (X == other.X) && (Y == other.Y);

        public readonly override bool Equals(object other)
        {
            if (other is not Coordinate)
            {
                return false;
            }
            Coordinate castedOther = (Coordinate)other;
            return (X == castedOther.X) && (Y == castedOther.Y);
        }

        public readonly override int GetHashCode() => X.GetHashCode() ^ (Y.GetHashCode() << 2);

        public readonly override string ToString() => $"Coordinate(X: {X}, Y: {Y})";

        public static Coordinate operator -(Coordinate coordinate) => new(-coordinate.X, -coordinate.Y);

        public static Coordinate operator +(Coordinate a, Coordinate b) => new(a.X + b.X, a.Y + b.Y);

        public static Coordinate operator -(Coordinate a, Coordinate b) => new(a.X - b.X, a.Y - b.Y);

        public static Coordinate operator *(Coordinate a, Coordinate b) => new(a.X * b.X, a.Y * b.Y);

        public static Coordinate operator *(int a, Coordinate b) => new(a * b.X, a * b.Y);

        public static Coordinate operator *(Coordinate a, int b) => new(a.X * b, a.Y * b);

        public static Coordinate operator /(Coordinate a, int b) => new(a.X / b, a.Y / b);

        public static bool operator ==(Coordinate lhs, Coordinate rhs) => (lhs.X == rhs.X) && (lhs.Y == rhs.Y);

        public static bool operator !=(Coordinate lhs, Coordinate rhs) => (lhs.X != rhs.X) || (lhs.Y != rhs.Y);
    }
}
