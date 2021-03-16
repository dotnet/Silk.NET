// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Internals
{
    internal struct IsConnectedWrapper<T> : IReadOnlyList<T>
        where T : IInputDevice
    {
        private readonly IReadOnlyList<T> _list;

        public IsConnectedWrapper(IReadOnlyList<T> list) => _list = list;
        public IEnumerator<T> GetEnumerator() => new IsConnectedEnumerator<T>(_list.GetEnumerator());

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public int Count => _list.Count;

        public T this[int index] => _list[index];
    }
}
