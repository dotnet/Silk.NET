using Silk.NET.Input.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Input.Desktop.Collections
{
    public unsafe class GlfwTriggerCollection : IReadOnlyList<Trigger>
    {
        private float* _floats;
        private int _count;

        public GlfwTriggerCollection(float* floats, int count)
        {
            _count = count;
            _floats = floats;
        }

        public Trigger this[int index] => index < Count
            ? new Trigger(index, Get(_floats, index))
            : throw new ArgumentOutOfRangeException();

        public int Count => _count;

        public IEnumerator<Trigger> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static float Get(float* floats, int index)
        {
            Console.WriteLine("bang");
            return (float)Marshal.PtrToStructure
            (
                Marshal.ReadIntPtr((IntPtr)floats, index * IntPtr.Size),
                typeof(float)
            );
        }

        private struct Enumerator : IEnumerator<Trigger>
        {
            private GlfwTriggerCollection _col;
            private int _current;

            public Enumerator(GlfwTriggerCollection col)
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

                Current = new Trigger(_current, Get(_col._floats, _current));
                _current++;
                return true;
            }

            public void Reset()
            {
                Current = default;
                _current = 0;
            }

            public Trigger Current { get; set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
