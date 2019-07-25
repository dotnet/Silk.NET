using Silk.NET.Input.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Input.Desktop.Collections
{
    public unsafe class GlfwButtonCollection : IReadOnlyList<Button>
    {
        private bool* _bools;
        private int _count;
        private readonly GlfwKeyboard _keyboard;

        public GlfwButtonCollection(bool* bools, int count, GlfwKeyboard keyboard)
        {
            _bools = bools;
            _count = count;
            _keyboard = keyboard;
        }

        public int Count => _count;

        public Button this[int index] => index < _count
            ? new Button ((ButtonName)index, index, Get(_bools, index))
            : throw new ArgumentOutOfRangeException();

        public IEnumerator<Button> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static bool Get(bool* bools, int index)
        {
            return (bool)Marshal.PtrToStructure
            (
                Marshal.ReadIntPtr((IntPtr)bools, index * IntPtr.Size),
                typeof(float)
            );
        }
        private struct Enumerator : IEnumerator<Button>
        {
            private GlfwButtonCollection _col;
            private int _current;

            public Enumerator(GlfwButtonCollection col)
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

                Current = new Button((ButtonName)_current, _current, Get(_col._bools, _current));
                _current++;
                return true;
            }

            public void Reset()
            {
                Current = default;
                _current = 0;
            }

            public Button Current { get; set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
