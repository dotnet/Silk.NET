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
    /// A collection of GLFW-based keyboards.
    /// </summary>
    internal class GlfwKeyboardCollection : IReadOnlyList<IKeyboard>
    {
        private readonly GlfwInputContext _ctx;

        internal GlfwKeyboardCollection(GlfwInputContext ctx)
        {
            _ctx = ctx;
        }
        
        /// <inheritdoc />
        public IEnumerator<IKeyboard> GetEnumerator()
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
        public IKeyboard this[int index] => index == 0 ? _ctx._keyboard : throw new ArgumentOutOfRangeException();
        
        /// <inheritdoc />
        private struct Enumerator : IEnumerator<IKeyboard>
        {
            private readonly GlfwKeyboardCollection _col;
            private bool _done;

            public Enumerator(GlfwKeyboardCollection col)
            {
                _col = col;
                _done = false;
                Current = null;
            }
            
            /// <inheritdoc />
            public bool MoveNext()
            {
                Current = _done ? null : _col._ctx._keyboard;
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
            public IKeyboard Current { get; private set; }

            /// <inheritdoc />
            object IEnumerator.Current => Current;

            /// <inheritdoc />
            public void Dispose()
            {
            }
        }
    }
}
