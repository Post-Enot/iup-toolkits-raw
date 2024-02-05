namespace IUP.Toolkits
{
    public static class IntExtensions
    {
        public static bool InBounds(this int x, int min, int max)
        {
            return (x >= min) && (x <= max);
        }

        public static bool UnableIndex(this int x)
        {
            return x == IndexUtility.UnableIndex;
        }
    }
}
