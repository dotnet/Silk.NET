// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Desktop
{
    internal struct IsConnectedEnumerator<T> : IEnumerator<T>
        where T : IGlfwDevice
    {
        private ReadOnlyListEnumerator<T> _base;

        public IsConnectedEnumerator(in ReadOnlyListEnumerator<T> @base)
        {
            _base = @base;
            Current = default;
        }

        public bool MoveNext()
        {
            while (_base.MoveNext())
            {
                if (_base.Current.IsConnected)
                {
                    Current = _base.Current;
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
            _base.Reset();
        }

        public T Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
