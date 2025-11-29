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

/// <include file='IInspectable.xml' path='doc/member[@name="IInspectable"]/*'/>
[Guid("AF86E2E0-B12D-4C6A-9C5A-D7AA65101E90")]
[NativeTypeName("struct IInspectable : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IInspectable : IInspectable.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IInspectable));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult GetIids(
            [NativeTypeName("ULONG *")] uint* iidCount,
            [NativeTypeName("IID **")] Guid** iids
        );

        [VtblIndex(3)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetIids(
            [NativeTypeName("ULONG *")] Ref<uint> iidCount,
            [NativeTypeName("IID **")] Ref2D<Guid> iids
        );

        [VtblIndex(4)]
        HResult GetRuntimeClassName(HString* className);

        [VtblIndex(4)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetRuntimeClassName(Ref<HString> className);

        [VtblIndex(5)]
        HResult GetTrustLevel(TrustLevel* trustLevel);

        [VtblIndex(5)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetTrustLevel(Ref<TrustLevel> trustLevel);
    }

    /// <include file='IInspectable.xml' path='doc/member[@name="IInspectable"]/*'/>

    [Guid("AF86E2E0-B12D-4C6A-9C5A-D7AA65101E90")]
    [NativeTypeName("struct IInspectable : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows6.2")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IInspectable));
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

            [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, Guid**, HResult> GetIids;

            [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HString*, HResult> GetRuntimeClassName;

            [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, TrustLevel*, HResult> GetTrustLevel;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInspectable.Native*, uint>)(lpVtbl[1]))(
                (IInspectable.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IInspectable.xml' path='doc/member[@name="IInspectable.GetIids"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetIids(
            [NativeTypeName("ULONG *")] uint* iidCount,
            [NativeTypeName("IID **")] Guid** iids
        )
        {
            return ((delegate* unmanaged<IInspectable.Native*, uint*, Guid**, HResult>)(lpVtbl[3]))(
                (IInspectable.Native*)Unsafe.AsPointer(ref this),
                iidCount,
                iids
            );
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetIids(
            [NativeTypeName("ULONG *")] Ref<uint> iidCount,
            [NativeTypeName("IID **")] Ref2D<Guid> iids
        )
        {
            fixed (Guid** __dsl_iids = iids)
            fixed (uint* __dsl_iidCount = iidCount)
            {
                return (HResult)GetIids(__dsl_iidCount, __dsl_iids);
            }
        }

        /// <include file='IInspectable.xml' path='doc/member[@name="IInspectable.GetRuntimeClassName"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetRuntimeClassName(HString* className)
        {
            return ((delegate* unmanaged<IInspectable.Native*, HString*, HResult>)(lpVtbl[4]))(
                (IInspectable.Native*)Unsafe.AsPointer(ref this),
                className
            );
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetRuntimeClassName(Ref<HString> className)
        {
            fixed (HString* __dsl_className = className)
            {
                return (HResult)GetRuntimeClassName(__dsl_className);
            }
        }

        /// <include file='IInspectable.xml' path='doc/member[@name="IInspectable.GetTrustLevel"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IInspectable.Native*, TrustLevel*, HResult>)(lpVtbl[5]))(
                (IInspectable.Native*)Unsafe.AsPointer(ref this),
                trustLevel
            );
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetTrustLevel(Ref<TrustLevel> trustLevel)
        {
            fixed (TrustLevel* __dsl_trustLevel = trustLevel)
            {
                return (HResult)GetTrustLevel(__dsl_trustLevel);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInspectable.Native*, Guid*, void**, HResult>)(lpVtbl[0]))(
                (IInspectable.Native*)Unsafe.AsPointer(ref this),
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

        /// <inheritdoc cref = "IUnknown.Release"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInspectable.Native*, uint>)(lpVtbl[2]))(
                (IInspectable.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IInspectable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IInspectable(Ptr3D vtbl) => LpVtbl = (IInspectable.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IInspectable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IInspectable(Ptr<IInspectable.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IInspectable.Native"/> to <see cref = "IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IInspectable.Native"/> instance to be converted </param>

    public static implicit operator IInspectable(IInspectable.Native* value) =>
        new IInspectable((Ptr<Native>)value);

    /// <summary>casts <see cref = "IInspectable"/> to <see cref = "IInspectable.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IInspectable"/> instance to be converted </param>

    public static implicit operator IInspectable.Native*(IInspectable value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IInspectable(Ptr3D value) => new IInspectable(value);

    /// <summary>casts <see cref = "IInspectable"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IInspectable"/> instance to be converted </param>

    public static implicit operator Ptr3D(IInspectable value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IInspectable(Ptr<IInspectable.Native> value) =>
        new IInspectable(value);

    /// <summary>casts <see cref = "IInspectable"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IInspectable"/> instance to be converted </param>

    public static implicit operator Ptr<IInspectable.Native>(IInspectable value) =>
        (Ptr<IInspectable.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IInspectable"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IInspectable(void*** value) =>
        new IInspectable((Ptr<Native>)value);

    /// <summary>casts <see cref = "IInspectable"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IInspectable"/> instance to be converted </param>

    public static implicit operator void***(IInspectable value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IInspectable(nuint value) =>
        new IInspectable((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IInspectable"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IInspectable"/> instance to be converted </param>

    public static implicit operator nuint(IInspectable value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IInspectable.xml' path='doc/member[@name="IInspectable.GetIids"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    ) => LpVtbl->GetIids(iidCount, iids);

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetIids(
        [NativeTypeName("ULONG *")] Ref<uint> iidCount,
        [NativeTypeName("IID **")] Ref2D<Guid> iids
    )
    {
        fixed (Guid** __dsl_iids = iids)
        fixed (uint* __dsl_iidCount = iidCount)
        {
            return (HResult)GetIids(__dsl_iidCount, __dsl_iids);
        }
    }

    /// <include file='IInspectable.xml' path='doc/member[@name="IInspectable.GetRuntimeClassName"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetRuntimeClassName(HString* className) =>
        LpVtbl->GetRuntimeClassName(className);

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRuntimeClassName(Ref<HString> className)
    {
        fixed (HString* __dsl_className = className)
        {
            return (HResult)GetRuntimeClassName(__dsl_className);
        }
    }

    /// <include file='IInspectable.xml' path='doc/member[@name="IInspectable.GetTrustLevel"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetTrustLevel(TrustLevel* trustLevel) => LpVtbl->GetTrustLevel(trustLevel);

    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetTrustLevel(Ref<TrustLevel> trustLevel)
    {
        fixed (TrustLevel* __dsl_trustLevel = trustLevel)
        {
            return (HResult)GetTrustLevel(__dsl_trustLevel);
        }
    }

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
