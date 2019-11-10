// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    public struct FuncPtr<T> : IDisposable
        where T:Delegate
    {
        public IntPtr Value { get; }
        public FuncPtr(T @delegate)
        {
            var handle = GCHandle.Alloc(@delegate);
            Value = Marshal.GetFunctionPointerForDelegate(@delegate);
            FuncPtrInternal.Storage.Add(Value, new FuncPtrInternal{Delegate = @delegate, Handle = handle});
        }

        public void Dispose()
        {
            if (FuncPtrInternal.Storage.TryGetValue(Value, out var value))
            {
                value.Handle.Free();
            }

            FuncPtrInternal.Storage.Remove(Value);
        }
    }
}
