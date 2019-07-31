// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop.Collections
{
    public class GlfwJoystickCollection : IReadOnlyList<IJoystick>
    {
        private readonly GlfwInputContext _glfwInputContext;

        public GlfwJoystickCollection(GlfwInputContext glfwInputContext)
        {
            _glfwInputContext = glfwInputContext;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        IEnumerator<IJoystick> IEnumerable<IJoystick>.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<IJoystick> GetEnumerator()
        {
            return new Enumerator(_glfwInputContext);
        }

        public int Count
        {
            get
            {
                var c = 0;
                foreach (var j in this)
                {
                    if (j.IsConnected)
                    {
                        c++;
                    }
                }

                return c;
            }
        }
        
        public struct Enumerator : IEnumerator<IJoystick>
        {
            private int _current;
            private GlfwInputContext _ctx;

            public Enumerator(GlfwInputContext ctx)
            {
                _ctx = ctx;
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
                    if (_ctx._joysticks[_current].IsConnected)
                    {
                        Current = _ctx._joysticks[_current];
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

            public IJoystick Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }

        public IJoystick this[int index] => _glfwInputContext._joysticks[index];
    }
}
