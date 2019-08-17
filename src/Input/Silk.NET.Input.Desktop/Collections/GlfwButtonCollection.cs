using Silk.NET.Input.Common;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Desktop.Collections
{
    public unsafe class GlfwButtonCollection : IReadOnlyList<Button>
    {
        private byte* _bytes;
        private int _count;

        public GlfwButtonCollection(byte* bytes, int count)
        {
            _bytes = bytes;
            _count = count;
        }

        public int Count => _count;

        public Button this[int index] => index < _count
            ? new Button (Util.IntToSilkButton(index), index, _bytes[index] != 0)
            : throw new ArgumentOutOfRangeException();

        public IEnumerator<Button> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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

                Current = new Button(Util.IntToSilkButton(_current), _current, _col._bytes[_current] != 0);
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
