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
    public class GlfwMouseCollection : IReadOnlyList<IMouse>
    {
        private readonly GlfwInputContext _ctx;

        public GlfwMouseCollection(GlfwInputContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerator<IMouse> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count { get; } = 1;

        public IMouse this[int index] => index == 0 ? _ctx._mouse : throw new ArgumentOutOfRangeException();
        
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
            
            public bool MoveNext()
            {
                Current = _done ? null : _col._ctx._mouse;
                var ret = !_done;
                _done = true;
                return ret;
            }

            public void Reset()
            {
                _done = false;
                Current = null;
            }

            public IMouse Current { get; set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
