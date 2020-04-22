// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    public struct FuncPtr : IDisposable
    {
        public static implicit operator FuncPtr(IntPtr src)
        {
            return new FuncPtr(src);
        }

        public static implicit operator FuncPtr(Delegate @delegate)
        {
            return new FuncPtr(@delegate);
        }

        public static implicit operator IntPtr(FuncPtr ptr)
        {
            return ptr.Value;
        }

        public IntPtr Value { get; }

        public static FuncPtr Of<T>(T @delegate)
            where T : Delegate
        {
            return new FuncPtr(@delegate);
        }

        public FuncPtr(IntPtr ptr)
        {
            Value = ptr;
        }
        
        public FuncPtr(Delegate @delegate)
        {
            var handle = GCHandle.Alloc(@delegate);
            Value = Marshal.GetFunctionPointerForDelegate(@delegate);
            FuncPtrInternal.Storage.Add(Value, new FuncPtrInternal{Delegate = @delegate, Handle = handle});
        }

        public T Get<T>()
            where T:Delegate
        {
            if (FuncPtrInternal.Storage.TryGetValue(Value, out var value))
            {
                return (T) value.Delegate;
            }

            return Marshal.GetDelegateForFunctionPointer<T>(Value);
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
