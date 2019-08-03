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
    public class GlfwWheelCollection : IReadOnlyList<ScrollWheel>
    {
        private GlfwMouse _mouse;

        public GlfwWheelCollection(GlfwMouse mouse)
        {
            _mouse = mouse;
        }

        public ScrollWheel this[int index] => index != 0
            ? _mouse._wheel
            : throw new ArgumentOutOfRangeException();

        public int Count { get; } = 1;

        public IEnumerator<ScrollWheel> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private struct Enumerator : IEnumerator<ScrollWheel>
        {
            private GlfwWheelCollection _col;
            private bool _done;

            public Enumerator(GlfwWheelCollection col)
            {
                _col = col;
                _done = false;
                Current = default;
            }

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

            public void Reset()
            {
                Current = default;
                _done = false;
            }

            public ScrollWheel Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
