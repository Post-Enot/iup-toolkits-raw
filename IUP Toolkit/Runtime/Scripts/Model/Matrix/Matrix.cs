using System;
using System.Collections;
using System.Collections.Generic;

namespace IUP.Toolkits
{
    public sealed class Matrix<T> : IMatrix<T>
    {
        public Matrix(int width = 0, int height = 0)
        {
            _doubleArray = new T[height, width];
            Size = new Size(width, height);
        }

        public Matrix(int width, int height, Func<Coordinate, T> initializer)
        {
            _doubleArray = new T[height, width];
            Size = new Size(width, height);
            InitAllElements(initializer);
        }

        public Size Size { get; }

        private readonly T[,] _doubleArray;

        public T this[Coordinate position]
        {
            get => _doubleArray[position.Y, position.X];
            set => _doubleArray[position.Y, position.X] = value;
        }

        public void InitAllElements(Func<Coordinate, T> initializer)
        {
            foreach (Coordinate position in Size.Coordinates)
            {
                _doubleArray[position.Y, position.X] = initializer(position);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T element in _doubleArray)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => _doubleArray.GetEnumerator();
    }
}
