using System;
using System.Collections;
using System.Collections.Generic;

namespace IUP.Toolkits
{
    public readonly struct Size : IEnumerable<Coordinate>, IEquatable<Size>
    {
        public Size(int width, int height)
        {
            if (width < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(width));
            }
            if (height < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height));
            }

            Width = width;
            Height = height;
        }

        public const int DefaultMinBound = 0;
        public const int DefaultX_MinBound = DefaultMinBound;
        public const int DefaultY_MinBound = DefaultMinBound;

        public readonly int Width;
        public readonly int Height;

        public readonly int Count => Width * Height;
        public readonly Coordinate MinBound => new(DefaultX_MinBound, DefaultY_MinBound);
        public readonly Coordinate MaxBound => new(Width - 1, Height - 1);
        public readonly IEnumerable<Coordinate> Coordinates => this;

        public readonly bool InBounds(Coordinate position) => position.InBounds(MinBound, MaxBound);

        public readonly bool Equals(Size other) => (Width == other.Width) && (Height == other.Height);

        public readonly override bool Equals(object other)
        {
            if (other is not Size)
            {
                return false;
            }
            Size castedOther = (Size)other;
            return (Width == castedOther.Width) && (Height == castedOther.Height);
        }

        public override int GetHashCode() => Width.GetHashCode() ^ (Height.GetHashCode() << 2);

        public override string ToString() => $"Size(width: {Width}, height: {Height})";

        public readonly IEnumerator<Coordinate> GetEnumerator()
        {
            for (int y = MinBound.Y; y <= MaxBound.Y; y += 1)
            {
                for (int x = MinBound.X; x <= MaxBound.X; x += 1)
                {
                    yield return new Coordinate(x, y);
                }
            }
        }

        readonly IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
