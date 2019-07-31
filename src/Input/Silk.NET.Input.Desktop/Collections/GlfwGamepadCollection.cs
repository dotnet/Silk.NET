// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop.Collections
{
    public class GlfwGamepadCollection : IReadOnlyList<IGamepad>
    {
        private GlfwInputContext _ctx;

        public GlfwGamepadCollection(GlfwInputContext ctx)
        {
            _ctx = ctx;
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        IEnumerator<IGamepad> IEnumerable<IGamepad>.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<IGamepad> GetEnumerator()
        {
            return new Enumerator(_ctx);
        }

        public int Count { get; }
        
        public struct Enumerator : IEnumerator<IGamepad>, IEnumerator
        {
            private int _current;
            private GlfwInputContext _c;

            public Enumerator(GlfwInputContext c)
            {
                _c = c;
                _current = 0;
                Current = null;
            }
            
            public bool MoveNext()
            {
                if (_current == 16)
                {
                    return false;
                }

                for (; _current < 16; _current++)
                {
                    if (_c._gamepads[_current].IsConnected)
                    {
                        Current = _c._gamepads[_current];
                        return true;
                    }
                }

                return false;
            }

            public void Reset()
            {
                Current = null;
                _current = 0;
            }

            public IGamepad Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }

        public IGamepad this[int i] => _ctx._gamepads[i];
    }
}
