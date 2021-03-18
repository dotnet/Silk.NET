// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Silk.NET.Input.Internals
{
    internal struct ReadOnlyCollectionListAdapter<T> : IReadOnlyList<T>
    {
        private readonly IReadOnlyCollection<T> _col;

        public ReadOnlyCollectionListAdapter(IReadOnlyCollection<T> col)
        {
            _col = col;
        }

        public IEnumerator<T> GetEnumerator() => _col.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public int Count => _col.Count;
        public T this[int index] => _col.ElementAt(index);
    }
}
