using Silk.NET.Input.Common;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Desktop.Collections
{
    /// <summary>
    /// A collection of GLFW-based gamepad triggers.
    /// </summary>
    internal unsafe class GlfwTriggerCollection : IReadOnlyList<Trigger>
    {
        private readonly float* _floats;

        internal GlfwTriggerCollection(float* floats, int count)
        {
            Count = count;
            _floats = floats;
        }

        /// <inheritdoc />
        public Trigger this[int index] => index < Count
            ? new Trigger(index, _floats[index])
            : throw new ArgumentOutOfRangeException();

        /// <inheritdoc />
        public int Count { get; }

        /// <inheritdoc />
        public IEnumerator<Trigger> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private struct Enumerator : IEnumerator<Trigger>
        {
            private readonly GlfwTriggerCollection _col;
            private int _current;

            public Enumerator(GlfwTriggerCollection col)
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

                Current = new Trigger(_current, _col._floats[_current]);
                _current++;
                return true;
            }

            public void Reset()
            {
                Current = default;
                _current = 0;
            }

            public Trigger Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
