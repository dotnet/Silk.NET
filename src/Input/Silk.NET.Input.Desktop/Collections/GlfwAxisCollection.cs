// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections;
using System.Collections.Generic;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop.Collections
{
    /// <summary>
    /// A collection of GLFW-based axes.
    /// </summary>
    internal unsafe class GlfwAxisCollection : IReadOnlyList<Axis>
    {
        private readonly float* _floats;

        internal GlfwAxisCollection(float* floats, int count)
        {
            _floats = floats;
            Count = count;
        }
        
        /// <inheritdoc />
        public IEnumerator<Axis> GetEnumerator()
        {
            return new Enumerator(this);
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public int Count { get; }

        /// <inheritdoc />
        public Axis this[int index] => index < Count
            ? new Axis(index, _floats[index])
            : throw new ArgumentOutOfRangeException();
        
        private struct Enumerator : IEnumerator<Axis>
        {
            private readonly GlfwAxisCollection _col;
            private int _current;

            public Enumerator(GlfwAxisCollection col)
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

                Current = new Axis(_current, _col._floats[_current]);
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
            public Axis Current { get; private set; }

            /// <inheritdoc />
            object IEnumerator.Current => Current;

            /// <inheritdoc />
            public void Dispose()
            {
            }
        }
    }
}
