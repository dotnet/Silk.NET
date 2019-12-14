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
    internal class GlfwWheelCollection : IReadOnlyList<ScrollWheel>
    {
        private readonly GlfwMouse _mouse;

        internal GlfwWheelCollection(GlfwMouse mouse)
        {
            _mouse = mouse;
        }

        /// <inheritdoc />
        public ScrollWheel this[int index] => index != 0
            ? _mouse._wheel
            : throw new ArgumentOutOfRangeException();

        /// <inheritdoc />
        public int Count { get; } = 1;

        /// <inheritdoc />
        public IEnumerator<ScrollWheel> GetEnumerator()
        {
            return new Enumerator(this);
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private struct Enumerator : IEnumerator<ScrollWheel>
        {
            private readonly GlfwWheelCollection _col;
            private bool _done;

            public Enumerator(GlfwWheelCollection col)
            {
                _col = col;
                _done = false;
                Current = default;
            }

            /// <inheritdoc />
            public bool MoveNext()
            {
                if (!_done)
                {
                    Current = _col._mouse._wheel;
                    _done = true;
                    return true;
                }

                Current = default;
                return false;
            }

            /// <inheritdoc />
            public void Reset()
            {
                Current = default;
                _done = false;
            }

            /// <inheritdoc />
            public ScrollWheel Current { get; private set; }

            /// <inheritdoc />
            object IEnumerator.Current => Current;

            /// <inheritdoc />
            public void Dispose()
            {
            }
        }
    }
}
