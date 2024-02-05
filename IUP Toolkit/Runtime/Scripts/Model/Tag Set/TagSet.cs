using System.Collections;
using System.Collections.Generic;

namespace IUP.Toolkits
{
    public class TagSet<T> : ITagSet<T>
    {
        public int Count => _tags.Count;

        private readonly HashSet<T> _tags = new();

        public void Add(T tag) => _ = _tags.Add(tag);

        public void Add(params T[] tags) => _tags.UnionWith(tags);

        public bool Contains(T item) => _tags.Contains(item);

        public void Remove(T tag) => _ = _tags.Remove(tag);

        public void Remove(params T[] tags) => _tags.ExceptWith(tags);

        public void Clear() => _tags.Clear();

        public IEnumerator<T> GetEnumerator() => _tags.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _tags.GetEnumerator();
    }
}
