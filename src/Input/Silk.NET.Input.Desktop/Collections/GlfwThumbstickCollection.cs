using Silk.NET.Input.Common;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Desktop.Collections
{
    /// <summary>
    /// A collection of GLFW-based thumbsticks.
    /// </summary>
    internal unsafe class GlfwThumbstickCollection : IReadOnlyList<Thumbstick>
    {
        private readonly float* _x, _y;

        internal GlfwThumbstickCollection(float* x, float* y, int count)
        {
            _x = x;
            _y = y;
            Count = count;
        }

        /// <inheritdoc />
        public int Count { get; }

        /// <inheritdoc />
        public Thumbstick this[int index] => index < Count
            ? new Thumbstick(index, _x[index], _y[index])
            : throw new ArgumentOutOfRangeException();

        /// <inheritdoc />
        public IEnumerator<Thumbstick> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private struct Enumerator : IEnumerator<Thumbstick>
        {
            private readonly GlfwThumbstickCollection _col;
            private int _current;

            public Enumerator(GlfwThumbstickCollection col)
            {
                _col = col;
                _current = 0;
                Current = default;
            }

            public bool MoveNext()
            {
                if (_current == _col.Count)
                {
                    Current = default;
                    return false;
                }

                Current = new Thumbstick(_current, _col._x[_current], _col._y[_current]);
                _current++;
                return true;
            }

            public void Reset()
            {
                Current = default;
                _current = 0;
            }

            public Thumbstick Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
