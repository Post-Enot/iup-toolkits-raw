namespace IUP.Toolkits
{
    public readonly struct BinarySearchResult
    {
        public BinarySearchResult(int rawIndex, int leftBound, int rightBound)
        {
            RawIndex = rawIndex;
            LeftBound = leftBound;
            RightBound = rightBound;
        }

        public readonly bool IsFound => RawIndex >= 0;
        public readonly int Index
        {
            get
            {
                if (IsFound)
                {
                    return RawIndex;
                }
                return ~RawIndex;
            }
        }
        public readonly int RawIndex { get; }
        public readonly int LeftBound { get; }
        public readonly int RightBound { get; }
    }
}
