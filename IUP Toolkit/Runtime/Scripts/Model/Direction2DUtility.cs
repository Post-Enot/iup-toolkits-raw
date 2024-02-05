using System.Collections.Generic;

namespace IUP.Toolkits
{
    public static class Direction2DUtility
    {
        public static IEnumerable<Direction2D> Direction4_Straight
        {
            get
            {
                yield return Direction2D.Up;
                yield return Direction2D.Right;
                yield return Direction2D.Down;
                yield return Direction2D.Left;
            }
        }

        public static IEnumerable<Direction2D> Direction4_Diagonal
        {
            get
            {
                yield return Direction2D.UpRight;
                yield return Direction2D.DownRight;
                yield return Direction2D.DownLeft;
                yield return Direction2D.UpLeft;
            }
        }

        public static IEnumerable<Direction2D> Direction8
        {
            get
            {
                yield return Direction2D.Up;
                yield return Direction2D.UpRight;
                yield return Direction2D.Right;
                yield return Direction2D.DownRight;
                yield return Direction2D.Down;
                yield return Direction2D.DownLeft;
                yield return Direction2D.Left;
                yield return Direction2D.UpLeft;
            }
        }

        public static Direction2D Define(float x, float y)
        {
            Direction2D direction = Direction2D.Zero;
            if (x > 0)
            {
                direction |= Direction2D.Right;
            }
            else if (x < 0)
            {
                direction |= Direction2D.Left;
            }
            if (y > 0)
            {
                direction |= Direction2D.Up;
            }
            else if (y < 0)
            {
                direction |= Direction2D.Down;
            }
            return direction;
        }
    }
}
