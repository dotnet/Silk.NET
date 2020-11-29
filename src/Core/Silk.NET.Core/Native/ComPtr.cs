// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    public unsafe struct ComPtr<T> : IDisposable
        where T:unmanaged
    {
        public ComPtr(T* other)
        {
            Handle = other;
            AddRef();
        }

        public T* Handle;
        public ComPtr(ComPtr<T> other) : this(other.Handle){}
        public ComPtr(ComObject obj) : this((T*) obj.Handle){}
        public static implicit operator ComPtr<T>(T* other) => new ComPtr<T>(other);
        public static implicit operator T*(ComPtr<T> @this) => @this.Handle;
        public ComObject AsComObject() => ComObject.FromPtr((IUnknown*)Handle);
        private readonly void AddRef()
        {
            if (Handle != null)
            {
                ((IUnknown*) Handle)->AddRef();
            }
        }

        public uint Release()
        {
            uint ret = 0;
            if (Handle != null)
            {
                ret = ((IUnknown*) Handle)->Release();
            }

            return ret;
        }

        public readonly ref T* GetPinnableReference()
        {
            fixed (T** ptr = &Handle)
            {
                return ref *ptr;
            }
        }

        public void Dispose()
        {
            Release();
        }
    }
}
