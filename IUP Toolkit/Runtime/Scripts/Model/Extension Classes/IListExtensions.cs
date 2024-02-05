using System;
using System.Collections.Generic;

namespace IUP.Toolkits
{
    public static class IListExtensions
    {
        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            (list[i], list[j]) = (list[j], list[i]);
        }

        public static void MoveFromTo<T>(this IList<T> list, int from, int to)
        {
            T movedItem = list[from];
            list.RemoveAt(from);
            list.Insert(to, movedItem);
        }

        public static void MoveItemFromTo<T>(this IList<T> list, int from, int to)
        {
            T movedItem = list[from];
            list.RemoveAt(from);
            list.Insert(to, movedItem);
        }

        #region Shuffling
        public static void DurstenfeldAlgorithm<T>(this IList<T> list, Random random)
        {
            for (int i = list.Count - 1; i >= 1; i -= 1)
            {
                int j = random.Next(0, i + 1);
                list.Swap(i, j);
            }
        }

        public static void DurstenfeldAlgorithm<T>(this IList<T> list, int from, int to, Random random)
        {
            for (int i = to; i >= from + 1; i -= 1)
            {
                int j = random.Next(from, i + 1);
                list.Swap(i, j);
            }
        }
        #endregion
    }
}
