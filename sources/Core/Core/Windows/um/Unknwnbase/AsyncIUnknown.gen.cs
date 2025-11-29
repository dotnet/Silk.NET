// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/inspectable.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Core;
#pragma warning disable CS1589, CS1591, CS0419, CA1416, CS0618
namespace Silk.NET.Core;

/// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown"]/*'/>
[Guid("000E0000-0000-0000-C000-000000000046")]
[NativeTypeName("struct AsyncIUnknown : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct AsyncIUnknown : AsyncIUnknown.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.AsyncIUnknown));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(5)]
        HResult Begin_AddRef();

        [VtblIndex(3)]
        HResult Begin_QueryInterface([NativeTypeName("const IID &")] Guid* riid);

        [VtblIndex(3)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult Begin_QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid);

        [VtblIndex(7)]
        HResult Begin_Release();

        [VtblIndex(6)]
        [return: NativeTypeName("ULONG")]
        uint Finish_AddRef();

        [VtblIndex(4)]
        HResult Finish_QueryInterface(void** ppvObject);

        [VtblIndex(4)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult Finish_QueryInterface(Ref2D ppvObject);

        [VtblIndex(8)]
        [return: NativeTypeName("ULONG")]
        uint Finish_Release();
    }

    /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown"]/*'/>

    [Guid("000E0000-0000-0000-C000-000000000046")]
    [NativeTypeName("struct AsyncIUnknown : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.AsyncIUnknown));
        public void** lpVtbl;

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, HResult> Begin_QueryInterface;

            [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void**, HResult> Finish_QueryInterface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> Begin_AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> Finish_AddRef;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> Begin_Release;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> Finish_Release;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIUnknown.Native*, uint>)(lpVtbl[1]))(
                (AsyncIUnknown.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Begin_AddRef"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult Begin_AddRef()
        {
            return ((delegate* unmanaged<AsyncIUnknown.Native*, HResult>)(lpVtbl[5]))(
                (AsyncIUnknown.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Begin_QueryInterface"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult Begin_QueryInterface([NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<AsyncIUnknown.Native*, Guid*, HResult>)(lpVtbl[3]))(
                (AsyncIUnknown.Native*)Unsafe.AsPointer(ref this),
                riid
            );
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult Begin_QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid)
        {
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)Begin_QueryInterface(__dsl_riid);
            }
        }

        /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Begin_Release"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult Begin_Release()
        {
            return ((delegate* unmanaged<AsyncIUnknown.Native*, HResult>)(lpVtbl[7]))(
                (AsyncIUnknown.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Finish_AddRef"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("ULONG")]
        public uint Finish_AddRef()
        {
            return ((delegate* unmanaged<AsyncIUnknown.Native*, uint>)(lpVtbl[6]))(
                (AsyncIUnknown.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Finish_QueryInterface"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult Finish_QueryInterface(void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIUnknown.Native*, void**, HResult>)(lpVtbl[4]))(
                (AsyncIUnknown.Native*)Unsafe.AsPointer(ref this),
                ppvObject
            );
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult Finish_QueryInterface(Ref2D ppvObject)
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            {
                return (HResult)Finish_QueryInterface(__dsl_ppvObject);
            }
        }

        /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Finish_Release"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("ULONG")]
        public uint Finish_Release()
        {
            return ((delegate* unmanaged<AsyncIUnknown.Native*, uint>)(lpVtbl[8]))(
                (AsyncIUnknown.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return (
                (delegate* unmanaged<AsyncIUnknown.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((AsyncIUnknown.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult QueryInterface(
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvObject
        )
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
            }
        }

        [VtblIndex(0)]
        [Transformed]
        public HResult QueryInterface<TCom>(out TCom ppvObject)
            where TCom : unmanaged, IComVtbl
        {
            ppvObject = default;
            return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        /// <inheritdoc cref = "IUnknown.Release"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIUnknown.Native*, uint>)(lpVtbl[2]))(
                (AsyncIUnknown.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "AsyncIUnknown"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public AsyncIUnknown(Ptr3D vtbl) => LpVtbl = (AsyncIUnknown.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "AsyncIUnknown"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public AsyncIUnknown(Ptr<AsyncIUnknown.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "AsyncIUnknown.Native"/> to <see cref = "AsyncIUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "AsyncIUnknown.Native"/> instance to be converted </param>

    public static implicit operator AsyncIUnknown(AsyncIUnknown.Native* value) =>
        new AsyncIUnknown((Ptr<Native>)value);

    /// <summary>casts <see cref = "AsyncIUnknown"/> to <see cref = "AsyncIUnknown.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "AsyncIUnknown"/> instance to be converted </param>

    public static implicit operator AsyncIUnknown.Native*(AsyncIUnknown value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "AsyncIUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator AsyncIUnknown(Ptr3D value) => new AsyncIUnknown(value);

    /// <summary>casts <see cref = "AsyncIUnknown"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "AsyncIUnknown"/> instance to be converted </param>

    public static implicit operator Ptr3D(AsyncIUnknown value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "AsyncIUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator AsyncIUnknown(Ptr<AsyncIUnknown.Native> value) =>
        new AsyncIUnknown(value);

    /// <summary>casts <see cref = "AsyncIUnknown"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "AsyncIUnknown"/> instance to be converted </param>

    public static implicit operator Ptr<AsyncIUnknown.Native>(AsyncIUnknown value) =>
        (Ptr<AsyncIUnknown.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "AsyncIUnknown"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator AsyncIUnknown(void*** value) =>
        new AsyncIUnknown((Ptr<Native>)value);

    /// <summary>casts <see cref = "AsyncIUnknown"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "AsyncIUnknown"/> instance to be converted </param>

    public static implicit operator void***(AsyncIUnknown value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "AsyncIUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator AsyncIUnknown(nuint value) =>
        new AsyncIUnknown((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "AsyncIUnknown"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "AsyncIUnknown"/> instance to be converted </param>

    public static implicit operator nuint(AsyncIUnknown value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Begin_AddRef"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult Begin_AddRef() => LpVtbl->Begin_AddRef();

    /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Begin_QueryInterface"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult Begin_QueryInterface([NativeTypeName("const IID &")] Guid* riid) =>
        LpVtbl->Begin_QueryInterface(riid);

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Begin_QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid)
    {
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)Begin_QueryInterface(__dsl_riid);
        }
    }

    /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Begin_Release"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult Begin_Release() => LpVtbl->Begin_Release();

    /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Finish_AddRef"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("ULONG")]
    public uint Finish_AddRef() => LpVtbl->Finish_AddRef();

    /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Finish_QueryInterface"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult Finish_QueryInterface(void** ppvObject) =>
        LpVtbl->Finish_QueryInterface(ppvObject);

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Finish_QueryInterface(Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        {
            return (HResult)Finish_QueryInterface(__dsl_ppvObject);
        }
    }

    /// <include file='AsyncIUnknown.xml' path='doc/member[@name="AsyncIUnknown.Finish_Release"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("ULONG")]
    public uint Finish_Release() => LpVtbl->Finish_Release();

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) =>
        LpVtbl->QueryInterface(riid, ppvObject);

    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(0)]
    [Transformed]
    public HResult QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
}
