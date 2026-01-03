// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/inspectable.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Core;
#pragma warning disable CS1589, CS1591, CS0419, CA1416, CS0618
namespace Silk.NET.Core;

/// <include file='IClassFactory.xml' path='doc/member[@name="IClassFactory"]/*'/>
[Guid("00000001-0000-0000-C000-000000000046")]
[NativeTypeName("struct IClassFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IClassFactory : IClassFactory.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IClassFactory));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult CreateInstance(
            IUnknown pUnkOuter,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvObject
        );

        [VtblIndex(3)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult CreateInstance(
            IUnknown pUnkOuter,
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvObject
        );

        [VtblIndex(4)]
        HResult LockServer([NativeTypeName("BOOL")] MaybeBool<int> fLock);
    }

    /// <include file='IClassFactory.xml' path='doc/member[@name="IClassFactory"]/*'/>

    [Guid("00000001-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IClassFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IClassFactory));
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

            [NativeTypeName("HRESULT (IUnknown *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native*,
                Guid*,
                void**,
                HResult> CreateInstance;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, HResult> LockServer;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IClassFactory.Native*, uint>)(lpVtbl[1]))(
                (IClassFactory.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IClassFactory.xml' path='doc/member[@name="IClassFactory.CreateInstance"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult CreateInstance(
            IUnknown pUnkOuter,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvObject
        )
        {
            return (
                (delegate* unmanaged<
                    IClassFactory.Native*,
                    IUnknown.Native*,
                    Guid*,
                    void**,
                    HResult>)(lpVtbl[3])
            )((IClassFactory.Native*)Unsafe.AsPointer(ref this), pUnkOuter.LpVtbl, riid, ppvObject);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CreateInstance(
            IUnknown pUnkOuter,
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvObject
        )
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)CreateInstance(pUnkOuter, __dsl_riid, __dsl_ppvObject);
            }
        }

        [VtblIndex(3)]
        [Transformed]
        public HResult CreateInstance<TCom>(IUnknown pUnkOuter, out TCom ppvObject)
            where TCom : unmanaged, IComVtbl
        {
            ppvObject = default;
            return CreateInstance(pUnkOuter, TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        /// <include file='IClassFactory.xml' path='doc/member[@name="IClassFactory.LockServer"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult LockServer([NativeTypeName("BOOL")] MaybeBool<int> fLock)
        {
            return (
                (delegate* unmanaged<IClassFactory.Native*, MaybeBool<int>, HResult>)(lpVtbl[4])
            )((IClassFactory.Native*)Unsafe.AsPointer(ref this), fLock);
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return (
                (delegate* unmanaged<IClassFactory.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((IClassFactory.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IClassFactory.Native*, uint>)(lpVtbl[2]))(
                (IClassFactory.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IClassFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IClassFactory(Ptr3D vtbl) => LpVtbl = (IClassFactory.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IClassFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IClassFactory(Ptr<IClassFactory.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IClassFactory.Native"/> to <see cref = "IClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "IClassFactory.Native"/> instance to be converted </param>

    public static implicit operator IClassFactory(IClassFactory.Native* value) =>
        new IClassFactory((Ptr<Native>)value);

    /// <summary>casts <see cref = "IClassFactory"/> to <see cref = "IClassFactory.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IClassFactory"/> instance to be converted </param>

    public static implicit operator IClassFactory.Native*(IClassFactory value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IClassFactory(Ptr3D value) => new IClassFactory(value);

    /// <summary>casts <see cref = "IClassFactory"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IClassFactory"/> instance to be converted </param>

    public static implicit operator Ptr3D(IClassFactory value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IClassFactory(Ptr<IClassFactory.Native> value) =>
        new IClassFactory(value);

    /// <summary>casts <see cref = "IClassFactory"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IClassFactory"/> instance to be converted </param>

    public static implicit operator Ptr<IClassFactory.Native>(IClassFactory value) =>
        (Ptr<IClassFactory.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IClassFactory"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IClassFactory(void*** value) =>
        new IClassFactory((Ptr<Native>)value);

    /// <summary>casts <see cref = "IClassFactory"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IClassFactory"/> instance to be converted </param>

    public static implicit operator void***(IClassFactory value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IClassFactory(nuint value) =>
        new IClassFactory((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IClassFactory"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IClassFactory"/> instance to be converted </param>

    public static implicit operator nuint(IClassFactory value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IClassFactory.xml' path='doc/member[@name="IClassFactory.CreateInstance"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult CreateInstance(
        IUnknown pUnkOuter,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObject
    ) => LpVtbl->CreateInstance(pUnkOuter, riid, ppvObject);

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateInstance(
        IUnknown pUnkOuter,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppvObject
    )
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)CreateInstance(pUnkOuter, __dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(3)]
    [Transformed]
    public HResult CreateInstance<TCom>(IUnknown pUnkOuter, out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return CreateInstance(pUnkOuter, TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <include file='IClassFactory.xml' path='doc/member[@name="IClassFactory.LockServer"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult LockServer([NativeTypeName("BOOL")] MaybeBool<int> fLock) =>
        LpVtbl->LockServer(fLock);

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
