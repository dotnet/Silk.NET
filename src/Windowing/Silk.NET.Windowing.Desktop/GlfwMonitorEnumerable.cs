// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Desktop
{
    internal class GlfwMonitorEnumerable : IEnumerable<IMonitor>
    {
        public unsafe IEnumerator<IMonitor> GetEnumerator() => new Enumerator
            (GlfwProvider.GLFW.Value.GetMonitors(out var count), count);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private unsafe struct Enumerator : IEnumerator<IMonitor>
        {
            private readonly Monitor** _monitors;
            private readonly int _count;
            private int _index;

            public Enumerator(Monitor** monitors, int count)
            {
                _monitors = monitors;
                _count = count;
                _index = 0;
                Current = null;
            }

            public bool MoveNext()
            {
                if (_index >= _count)
                {
                    Current = null;
                    return false;
                }

                Current = new GlfwMonitor(_monitors[_index], _index);
                _index++;
                return true;
            }

            public void Reset()
            {
                Current = null;
                _index = 0;
            }

            public IMonitor Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
