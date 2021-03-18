// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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

        // 1. get a ref for this, which is a readonly ref when within a readonly function
        // 2. interpret that ref as a reference to a T. it's actually a ref to a T* (well actually it's a ComPtr<T>),
        //    but let's roll with it as it's as good as we're gonna get without having pointers as generic type
        //    parameters
        // 3. get a T* from that "reference to a T".
        // 4. cast it to a T**, which is its true identity.
        public readonly T** GetAddressOf()
            => (T**) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public readonly ref T* GetPinnableReference() => ref *GetAddressOf();
        public readonly ref T Get() => ref *Handle;

        public void Dispose()
        {
            Release();
        }
    }
}
