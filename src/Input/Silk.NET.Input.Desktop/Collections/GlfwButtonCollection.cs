using Silk.NET.Input.Common;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Desktop.Collections
{
    /// <summary>
    /// A collection of GLFW-based buttons.
    /// </summary>
    internal unsafe class GlfwButtonCollection : IReadOnlyList<Button>
    {
        private readonly byte* _bytes;

        internal GlfwButtonCollection(byte* bytes, int count)
        {
            _bytes = bytes;
            Count = count;
        }

        /// <inheritdoc />
        public int Count { get; }

        /// <inheritdoc />
        public Button this[int index] => index < Count
            ? new Button (Util.IntToSilkButton(index), index, _bytes[index] != 0)
            : throw new ArgumentOutOfRangeException();

        /// <inheritdoc />
        public IEnumerator<Button> GetEnumerator()
        {
            return new Enumerator(this);
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private struct Enumerator : IEnumerator<Button>
        {
            private readonly GlfwButtonCollection _col;
            private int _current;

            public Enumerator(GlfwButtonCollection col)
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

                Current = new Button(Util.IntToSilkButton(_current), _current, _col._bytes[_current] != 0);
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
            public Button Current { get; private set; }

            /// <inheritdoc />
            object IEnumerator.Current => Current;

            /// <inheritdoc />
            public void Dispose()
            {
            }
        }
    }
}
