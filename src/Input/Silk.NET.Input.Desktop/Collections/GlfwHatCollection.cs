using Silk.NET.Input.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Input.Desktop.Collections
{
    public unsafe class GlfwHatCollection : IReadOnlyList<Hat>
    {
        public Position2D* _positions;
        public int _count;

        public GlfwHatCollection(Position2D* positions, int count)
        {
            _positions = positions;
            _count = count;
        }

        public Hat this[int index] => index < _count
            ? new Hat(index, _positions[index])
            : throw new ArgumentOutOfRangeException();

        public int Count => _count;

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
            private GlfwHatCollection _col;
            private int _current;

            public Enumerator(GlfwHatCollection col)
            {
                _col = col;
                _current = 0;
                Current = default;
            }

            public bool MoveNext()
            {
                if (_current == _col._count)
                {
                    Current = default;
                    return false;
                }

                Current = new Hat(_current, _col._positions[_current]);
                _current++;
                return true;
            }

            public void Reset()
            {
                Current = default;
                _current = 0;
            }

            public Hat Current { get; set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
