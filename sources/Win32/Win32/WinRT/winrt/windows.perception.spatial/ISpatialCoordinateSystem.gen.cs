// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

/// <include file='ISpatialCoordinateSystem.xml' path='doc/member[@name="ISpatialCoordinateSystem"]/*'/>
[Guid("69EBCA4B-60A3-3586-A653-59A7BD676D07")]
[NativeTypeName("struct ISpatialCoordinateSystem : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialCoordinateSystem
    : ISpatialCoordinateSystem.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialCoordinateSystem));
    public void*** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged[MemberFunction]<ISpatialCoordinateSystem, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged[MemberFunction]<ISpatialCoordinateSystem, uint>)((*lpVtbl)[1])
        )(this);
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged[MemberFunction]<ISpatialCoordinateSystem, uint>)((*lpVtbl)[2])
        )(this);
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<ISpatialCoordinateSystem, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged[MemberFunction]<ISpatialCoordinateSystem, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged[MemberFunction]<ISpatialCoordinateSystem, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    /// <include file='ISpatialCoordinateSystem.xml' path='doc/member[@name="ISpatialCoordinateSystem.TryGetTransformTo"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryGetTransformTo(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem target,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CMatrix4x4_t **"
        )]
            IReference<Matrix4x4>** value
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                ISpatialCoordinateSystem,
                ISpatialCoordinateSystem,
                IReference<Matrix4x4>**,
                int>)((*lpVtbl)[6])
        )(this, target, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryGetTransformTo(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem target,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CMatrix4x4_t **"
            )]
                IReference<Matrix4x4>** value
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CNumerics__CMatrix4x4_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            ISpatialCoordinateSystem,
            IReference<Matrix4x4>**,
            int> TryGetTransformTo;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialCoordinateSystem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialCoordinateSystem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialCoordinateSystem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialCoordinateSystem(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpatialCoordinateSystem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialCoordinateSystem"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialCoordinateSystem"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpatialCoordinateSystem value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialCoordinateSystem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialCoordinateSystem(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialCoordinateSystem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialCoordinateSystem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialCoordinateSystem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialCoordinateSystem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
