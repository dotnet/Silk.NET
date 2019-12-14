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
    /// A collection of GLFW-based mice.
    /// </summary>
    internal class GlfwMouseCollection : IReadOnlyList<IMouse>
    {
        private readonly GlfwInputContext _ctx;

        internal GlfwMouseCollection(GlfwInputContext ctx)
        {
            _ctx = ctx;
        }
        
        /// <inheritdoc />
        public IEnumerator<IMouse> GetEnumerator()
        {
            return new Enumerator(this);
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public int Count { get; } = 1;

        /// <inheritdoc />
        public IMouse this[int index] => index == 0 ? _ctx._mouse : throw new ArgumentOutOfRangeException();
        
        /// <inheritdoc />
        public struct Enumerator : IEnumerator<IMouse>
        {
            private readonly GlfwMouseCollection _col;
            private bool _done;
            
            public Enumerator(GlfwMouseCollection col)
            {
                _col = col;
                _done = false;
                Current = null;
            }
            
            /// <inheritdoc />
            public bool MoveNext()
            {
                Current = _done ? null : _col._ctx._mouse;
                var ret = !_done;
                _done = true;
                return ret;
            }

            /// <inheritdoc />
            public void Reset()
            {
                _done = false;
                Current = null;
            }

            /// <inheritdoc />
            public IMouse Current { get; set; }

            object IEnumerator.Current => Current;

            /// <inheritdoc />
            public void Dispose()
            {
            }
        }
    }
}
