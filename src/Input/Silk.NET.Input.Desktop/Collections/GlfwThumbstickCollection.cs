using Silk.NET.Input.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Input.Desktop.Collections
{
    public unsafe class GlfwThumbstickCollection : IReadOnlyList<Thumbstick>
    {
        private float* _x, _y;
        private int _count;

        public GlfwThumbstickCollection(float* x, float* y, int count)
        {
            _x = x;
            _y = y;
            _count = count;
        }

        public int Count => _count;

        public Thumbstick this[int index] => index < _count
            ? new Thumbstick(index, _x[index], _y[index])
            : throw new ArgumentOutOfRangeException();

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
            private GlfwThumbstickCollection _col;
            private int _current;

            public Enumerator(GlfwThumbstickCollection col)
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

                Current = new Thumbstick(_current, _col._x[_current], _col._y[_current]);
                _current++;
                return true;
            }

            public void Reset()
            {
                Current = default;
                _current = 0;
            }

            public Thumbstick Current { get; set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
