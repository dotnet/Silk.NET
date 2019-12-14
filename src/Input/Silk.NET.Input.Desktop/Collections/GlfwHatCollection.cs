using Silk.NET.Input.Common;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Desktop.Collections
{
    /// <summary>
    /// A collection of GLFW-based hats.
    /// </summary>
    internal unsafe class GlfwHatCollection : IReadOnlyList<Hat>
    {
        private readonly Position2D* _positions;

        internal GlfwHatCollection(Position2D* positions, int count)
        {
            _positions = positions;
            Count = count;
        }

        /// <inheritdoc />
        public Hat this[int index] => index < Count
            ? new Hat(index, _positions[index])
            : throw new ArgumentOutOfRangeException();

        /// <inheritdoc />
        public int Count { get; }

        /// <inheritdoc />
        public IEnumerator<Hat> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private struct Enumerator : IEnumerator<Hat>
        {
            private readonly GlfwHatCollection _col;
            private int _current;

            public Enumerator(GlfwHatCollection col)
            {
                _col = col;
                _current = 0;
                Current = default;
            }

            /// <inheritdoc />
            public bool MoveNext()
            {
                if (_current == _col.Count)
                {
                    Current = default;
                    return false;
                }

                Current = new Hat(_current, _col._positions[_current]);
                _current++;
                return true;
            }

            /// <inheritdoc />
            public void Reset()
            {
                Current = default;
                _current = 0;
            }

            /// <inheritdoc />
            public Hat Current { get; private set; }

            /// <inheritdoc />
            object IEnumerator.Current => Current;

            /// <inheritdoc />
            public void Dispose()
            {
            }
        }
    }
}
