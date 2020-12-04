// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Desktop
{
    internal struct IsConnectedWrapper<T> : IReadOnlyList<T>
        where T : IGlfwDevice
    {
        private readonly IReadOnlyList<T> _list;

        public IsConnectedWrapper(IReadOnlyList<T> list) => _list = list;
        public IEnumerator<T> GetEnumerator() => new IsConnectedEnumerator<T>(new ReadOnlyListEnumerator<T>(_list));

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public int Count => _list.Count;

        public T this[int index] => _list[index];
    }
}
