using System.Collections;

namespace IUP.Toolkits
{
    public static class CoroutineUtility
    {
        public static IEnumerator Parallel(params IEnumerator[] routines)
        {
            bool InProgress = true;
            while (InProgress)
            {
                InProgress = false;
                foreach (IEnumerator routine in routines)
                {
                    if (routine.MoveNext())
                    {
                        InProgress = true;
                        yield return routine.Current;
                    }
                }
            }
        }
    }
}
