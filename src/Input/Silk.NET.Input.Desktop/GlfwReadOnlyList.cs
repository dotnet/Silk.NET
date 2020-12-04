// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Desktop
{
    internal unsafe struct GlfwReadOnlyList<T> : IReadOnlyList<T>
        where T : unmanaged
    {
        private T* _items;

        public GlfwReadOnlyList(T* items, int count)
        {
            Count = count;
            _items = items;
        }

        public void Update(T* items, int count)
        {
            Count = count;
            _items = items;
        }

        public IEnumerator<T> GetEnumerator() => new ReadOnlyListEnumerator<T>(this);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count { get; private set; }

        public T this[int index] => index >= Count ? throw new ArgumentOutOfRangeException() : _items[index];
    }
}
