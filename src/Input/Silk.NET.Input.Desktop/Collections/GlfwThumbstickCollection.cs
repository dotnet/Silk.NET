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
        private float* _positions, _directions;
        private int _count;

        public GlfwThumbstickCollection(float* positions, float* directions, int count)
        {
            _positions = positions;
            _directions = directions;
            _count = count;
        }

        public int Count => _count;

        public Thumbstick this[int index] => index < _count
            ? new Thumbstick(index, Get(_positions, index), Get(_directions, index))
            : throw new ArgumentOutOfRangeException();

        public static float Get(float* floats, int index)
        {
            return (float)Marshal.PtrToStructure
            (
                Marshal.ReadIntPtr((IntPtr)floats, index * IntPtr.Size),
                typeof(float)
            );
        }

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

                Current = new Thumbstick(_current, Get(_col._positions, _current), Get(_col._directions, _current));
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
