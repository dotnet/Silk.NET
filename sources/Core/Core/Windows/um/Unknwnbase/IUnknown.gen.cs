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

/// <include file='IUnknown.xml' path='doc/member[@name="IUnknown"]/*'/>
[Guid("00000000-0000-0000-C000-000000000046")]
public unsafe partial struct IUnknown : IUnknown.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IUnknown));

    public interface Interface
    {
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        uint AddRef();

        [VtblIndex(0)]
        HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

        [VtblIndex(0)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject);

        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        uint Release();
    }

    /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown"]/*'/>

    [Guid("00000000-0000-0000-C000-000000000046")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IUnknown));
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
        }

        /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown.AddRef"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUnknown.Native*, uint>)(lpVtbl[1]))(
                (IUnknown.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown.QueryInterface"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUnknown.Native*, Guid*, void**, HResult>)(lpVtbl[0]))(
                (IUnknown.Native*)Unsafe.AsPointer(ref this),
                riid,
                ppvObject
            );
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

        /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown.Release"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUnknown.Native*, uint>)(lpVtbl[2]))(
                (IUnknown.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IUnknown"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IUnknown(Ptr3D vtbl) => LpVtbl = (IUnknown.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IUnknown"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IUnknown(Ptr<IUnknown.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IUnknown.Native"/> to <see cref = "IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUnknown.Native"/> instance to be converted </param>

    public static implicit operator IUnknown(IUnknown.Native* value) =>
        new IUnknown((Ptr<Native>)value);

    /// <summary>casts <see cref = "IUnknown"/> to <see cref = "IUnknown.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IUnknown"/> instance to be converted </param>

    public static implicit operator IUnknown.Native*(IUnknown value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IUnknown(Ptr3D value) => new IUnknown(value);

    /// <summary>casts <see cref = "IUnknown"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IUnknown"/> instance to be converted </param>

    public static implicit operator Ptr3D(IUnknown value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IUnknown(Ptr<IUnknown.Native> value) => new IUnknown(value);

    /// <summary>casts <see cref = "IUnknown"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IUnknown"/> instance to be converted </param>

    public static implicit operator Ptr<IUnknown.Native>(IUnknown value) =>
        (Ptr<IUnknown.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IUnknown"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IUnknown(void*** value) => new IUnknown((Ptr<Native>)value);

    /// <summary>casts <see cref = "IUnknown"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IUnknown"/> instance to be converted </param>

    public static implicit operator void***(IUnknown value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IUnknown(nuint value) =>
        new IUnknown((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IUnknown"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IUnknown"/> instance to be converted </param>

    public static implicit operator nuint(IUnknown value) => (nuint)value.LpVtbl;

    /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown.AddRef"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown.QueryInterface"]/*'/>

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

    /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown.Release"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
}
