// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Glfw
{
    internal struct ReadOnlyListEnumerator<T> : IEnumerator<T>
    {
        private IReadOnlyList<T> _list;
        private int _i;

        public ReadOnlyListEnumerator(IReadOnlyList<T> list)
        {
            _list = list;
            _i = 0;
            Current = default;
        }
        public bool MoveNext()
        {
            if (_i >= _list.Count)
            {
                Current = default;
                return false;
            }

            Current = _list[_i];
            _i++;
            return true;
        }

        public void Reset()
        {
            _i = 0;
            Current = default;
        }

        public T Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
