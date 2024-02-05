namespace IUP.Toolkits
{
    public interface ITagSet<T> : IReadOnlyTagSet<T>
    {
        public void Add(T tag);
        public void Add(params T[] tags);
        public void Remove(T tag);
        public void Remove(params T[] tags);
        public void Clear();
    }
}
