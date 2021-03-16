// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Generic;
using Silk.NET.GLFW;
using NativeMonitor = Silk.NET.GLFW.Monitor;

namespace Silk.NET.Windowing.Glfw
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
            private readonly NativeMonitor** _monitors;
            private readonly int _count;
            private int _index;

            public Enumerator(NativeMonitor** monitors, int count)
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
