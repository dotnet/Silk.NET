// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Core.Pointers
{
    /// <summary>
    /// Represents a pointer to a COM object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public unsafe struct ComPtr<T> : IComVtbl<T>, IDisposable
        where T : unmanaged, IComVtbl<T>
    {
        /// <summary>
        /// Constructs a <see cref="ComPtr{T}"/> from a pointer
        /// </summary>
        /// <param name="other"></param>
        public ComPtr(T* other)
        {
            Handle = other;
            AddRef();
        }

        /// <summary>
        /// Stored Pointer to the COM object
        /// </summary>
        public T* Handle;
        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="other"></param>
        public ComPtr(ComPtr<T> other) : this(other.Handle) { }
        /// <summary>
        /// Converts a native handle to a <see cref="ComPtr{T}"/>
        /// </summary>
        /// <param name="other"></param>
        public static implicit operator ComPtr<T>(T* other) => new ComPtr<T>(other);
        /// <summary>
        /// Converts <see cref="ComPtr{T}"/> to a native handle
        /// </summary>
        /// <param name="this"></param>
        public static implicit operator T*(ComPtr<T> @this) => @this.Handle;
        private readonly void AddRef()
        {
            if (Handle != null && *Handle is IComVtbl<IUnknown>)
            {
                ((IUnknown*)Handle->AsVtblPtr())->AddRef();
            }
        }

        /// <summary>
        /// Decrements the reference count for an interface on a COM object.
        /// </summary>
        /// <returns></returns>
        public uint Release()
        {
            uint ret = 0;

            // NOTE: This type check is free https://bit.ly/3d73dwV
            if (Handle != null && *Handle is IComVtbl<IUnknown>)
            {
                // We can't cast Handle directly just in case some crazy user decides to have a ComPtr<ComPtr<T>>
                ret = ((IUnknown*)Handle->AsVtblPtr())->Release();
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
        /// <summary>
        /// Return the address of this objects as a pointer to itself
        /// </summary>
        /// <returns></returns>
        public readonly T** GetAddressOf()
            => (T**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        /// <summary>
        /// Returns a reference to an object of type T that can be used for pinning.
        /// </summary>
        /// <returns></returns>
        public readonly ref T* GetPinnableReference() => ref *GetAddressOf();
        /// <summary>
        /// Returns value at the ComPtr
        /// </summary>
        /// <returns></returns>
        public readonly ref T Get() => ref *Handle;

        /// <summary>
        /// Releases the ComPtr, decrementing its reference counter
        /// </summary>
        public void Dispose()
        {
            Release();
        }

        /// <summary>
        /// Get the Vtbl for the Com object
        /// </summary>
        /// <returns></returns>
        public void*** AsVtblPtr() => (void***)Handle;
    }

    /// <summary>
    /// A set of helper ComPtr functions
    /// </summary>
    public static unsafe class ComPtr
    {
        /// <summary>
        /// Downcasts a ComPtr of one type to a child class
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="og"></param>
        /// <returns></returns>
        public static ComPtr<TTo> Downcast<TFrom, TTo>(ComPtr<TFrom> og)
            where TFrom : unmanaged, IComVtbl<TFrom>, IComVtbl<TTo>
            where TTo : unmanaged, IComVtbl<TTo>
            => new((TTo*)og.Handle);
    }
}
