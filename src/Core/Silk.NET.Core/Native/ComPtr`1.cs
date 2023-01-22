// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    public unsafe struct ComPtr<T> : IComVtbl<T>, IDisposable
        where T:unmanaged, IComVtbl<T>
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
            if (Handle != null && *Handle is IComVtbl<IUnknown>)
            {
                ((IUnknown*) Handle->AsVtblPtr())->AddRef();
            }
        }

        public uint Release()
        {
            uint ret = 0;

            // NOTE: This type check is free https://bit.ly/3d73dwV
            if (Handle != null && *Handle is IComVtbl<IUnknown>)
            {
                // We can't cast Handle directly just in case some crazy user decides to have a ComPtr<ComPtr<T>>
                ret = ((IUnknown*) Handle->AsVtblPtr())->Release();
            }

            return ret;
        }

        /// <summary>
        /// Detaches the handle encapsulated by this ComPtr such that its lifetime is no longer controlled by the
        /// ComPtr.
        /// </summary>
        /// <returns>The encapsulated handle.</returns>
        public T* Detach()
        {
            var h = Handle;
            Handle = null;
            return h;
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

        public void*** AsVtblPtr() => (void***) Handle;
    }
}
