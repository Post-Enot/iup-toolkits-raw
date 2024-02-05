using System.Collections.Generic;

namespace IUP.Toolkits
{
    public interface IReadOnlyTagSet<T> : IReadOnlyCollection<T>
    {
        public bool Contains(T item);
    }
}
