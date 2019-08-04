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
    public class GlfwKeyboardCollection : IReadOnlyList<IKeyboard>
    {
        private readonly GlfwInputContext _ctx;

        public GlfwKeyboardCollection(GlfwInputContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerator<IKeyboard> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count { get; } = 1;

        public IKeyboard this[int index] => index == 0 ? _ctx._keyboard : throw new ArgumentOutOfRangeException();
        
        public struct Enumerator : IEnumerator<IKeyboard>
        {
            private readonly GlfwKeyboardCollection _col;
            private bool _done;

            public Enumerator(GlfwKeyboardCollection col)
            {
                _col = col;
                _done = false;
                Current = null;
            }
            
            public bool MoveNext()
            {
                Current = _done ? null : _col._ctx._keyboard;
                var ret = !_done;
                _done = true;
                return ret;
            }

            public void Reset()
            {
                _done = false;
                Current = null;
            }

            public IKeyboard Current { get; set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
