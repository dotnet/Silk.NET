// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Generic;

namespace Silk.NET.Input.Internals
{
    internal struct IsConnectedEnumerator<T> : IEnumerator<T>
        where T : IInputDevice
    {
        private IEnumerator<T> _base;

        public IsConnectedEnumerator(IEnumerator<T> @base)
        {
            _base = @base;
            Current = default!;
        }

        public bool MoveNext()
        {
            while (_base.MoveNext())
            {
                if (_base.Current?.IsConnected ?? false)
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
