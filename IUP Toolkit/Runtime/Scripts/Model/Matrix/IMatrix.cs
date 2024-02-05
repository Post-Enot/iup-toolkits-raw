using System;

namespace IUP.Toolkits
{
    public interface IMatrix<T> : IReadOnlyMatrix<T>
    {
        public new T this[Coordinate position] { get; set; }

        public void InitAllElements(Func<Coordinate, T> initializer);
    }
}
