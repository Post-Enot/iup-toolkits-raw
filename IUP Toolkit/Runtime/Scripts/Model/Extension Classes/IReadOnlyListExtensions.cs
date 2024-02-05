using System.Collections.Generic;

namespace IUP.Toolkits
{
    public static class IReadOnlyListExtensions
    {
        public static BoundSearchResult FindBounds<T>(this IReadOnlyList<T> list, T item, IComparer<T> comparer)
        {
            BinarySearchResult result = list.BinarySearch(item, comparer);

            if (!result.IsFound)
            {
                return new BoundSearchResult(result.Index, result.LeftBound, result.RightBound);
            }

            int leftBound = list.FindLeftBound(item, result.LeftBound, result.Index, comparer);
            int rightBound = list.FindRightBorder(item, result.Index, result.RightBound, comparer);

            return new BoundSearchResult(result.Index, leftBound, rightBound);
        }

        public static int FindLeftBound<T>(this IReadOnlyList<T> list, T item, int leftBound, int rightBound, IComparer<T> comparer)
        {
            while (leftBound <= rightBound)
            {
                int index = (leftBound + rightBound) / 2;
                int result = comparer.Compare(list[index], item);
                if (result == 0)
                {
                    rightBound = index - 1;
                }
                else
                {
                    leftBound = index + 1;
                }
            }
            return leftBound;
        }

        public static int FindRightBorder<T>(this IReadOnlyList<T> list, T item, int leftBound, int rightBound, IComparer<T> comparer)
        {
            while (leftBound <= rightBound)
            {
                int index = (leftBound + rightBound) / 2;

                T compared = list[index];
                int result = comparer.Compare(compared, item);

                if (result == 0)
                {
                    leftBound = index + 1;
                }
                else
                {
                    rightBound = index - 1;
                }
            }
            return rightBound;
        }

        private static BinarySearchResult BinarySearch<T>(this IReadOnlyList<T> list, T item, IComparer<T> comparer)
        {
            int leftBound = 0;
            int rightBound = list.Count - 1;

            while (leftBound <= rightBound)
            {
                int index = (leftBound + rightBound) / 2;

                T compared = list[index];
                int result = comparer.Compare(compared, item);

                if (result == 0)
                {
                    return new BinarySearchResult(index, leftBound, rightBound);
                }
                else if (result < 0)
                {
                    rightBound = index - 1;
                }
                else
                {
                    leftBound = index + 1;
                }
            }
            if (leftBound == 0)
            {
                return new BinarySearchResult(-1, 0, 0);
            }
            return new BinarySearchResult(~leftBound, leftBound, leftBound);
        }
    }
}
