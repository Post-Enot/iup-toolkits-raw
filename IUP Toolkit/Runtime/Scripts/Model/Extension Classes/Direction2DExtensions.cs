using System;

namespace IUP.Toolkits
{
    public static class Direction2DExtensions
    {
        public static Coordinate ToCoordinate(this Direction2D direction)
        {
            return direction switch
            {
                Direction2D.Zero      => Coordinate.DirectionZero,
                Direction2D.Up        => Coordinate.DirectionUp,
                Direction2D.Down      => Coordinate.DirectionDown,
                Direction2D.Left      => Coordinate.DirectionLeft,
                Direction2D.Right     => Coordinate.DirectionRight,
                Direction2D.UpLeft    => Coordinate.DirectionUpLeft,
                Direction2D.UpRight   => Coordinate.DirectionUpRight,
                Direction2D.DownLeft  => Coordinate.DirectionDownLeft,
                Direction2D.DownRight => Coordinate.DirectionDownRight,
                _                     => throw new ArgumentOutOfRangeException(nameof(direction)) // TODO.
            };
        }

        public static Direction2D Inverse(this Direction2D direction)
        {
            return direction switch
            {
                Direction2D.Zero      => Direction2D.Zero,
                Direction2D.Up        => Direction2D.Down,
                Direction2D.Down      => Direction2D.Up,
                Direction2D.Left      => Direction2D.Right,
                Direction2D.Right     => Direction2D.Left,
                Direction2D.UpLeft    => Direction2D.DownRight,
                Direction2D.UpRight   => Direction2D.DownLeft,
                Direction2D.DownLeft  => Direction2D.UpRight,
                Direction2D.DownRight => Direction2D.UpLeft,
                _                     => throw new ArgumentOutOfRangeException(nameof(direction)) // TODO.
            };
        }
    }
}
