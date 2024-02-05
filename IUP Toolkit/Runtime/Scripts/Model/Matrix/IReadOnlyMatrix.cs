using System.Collections.Generic;

namespace IUP.Toolkits
{
    public interface IReadOnlyMatrix<T> : IEnumerable<T>
    {
        public Size Size { get; }

        public T this[Coordinate position] { get; }
    }
}
