// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("05889117-B3E1-36D8-B017-566181A5B196")]
[NativeTypeName("struct ISpatialBoundingVolumeStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialBoundingVolumeStatics
    : ISpatialBoundingVolumeStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialBoundingVolumeStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialBoundingVolumeStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialBoundingVolumeStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialBoundingVolumeStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISpatialBoundingVolumeStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpatialBoundingVolumeStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISpatialBoundingVolumeStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromBox(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem coordinateSystem,
        [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingBox")]
            SpatialBoundingBox box,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")]
            ISpatialBoundingVolume* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialBoundingVolumeStatics,
                ISpatialCoordinateSystem,
                SpatialBoundingBox,
                ISpatialBoundingVolume*,
                int>)((*lpVtbl)[6])
        )(this, coordinateSystem, box, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromOrientedBox(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem coordinateSystem,
        [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingOrientedBox")]
            SpatialBoundingOrientedBox box,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")]
            ISpatialBoundingVolume* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialBoundingVolumeStatics,
                ISpatialCoordinateSystem,
                SpatialBoundingOrientedBox,
                ISpatialBoundingVolume*,
                int>)((*lpVtbl)[7])
        )(this, coordinateSystem, box, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromSphere(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem coordinateSystem,
        [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingSphere")]
            SpatialBoundingSphere sphere,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")]
            ISpatialBoundingVolume* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialBoundingVolumeStatics,
                ISpatialCoordinateSystem,
                SpatialBoundingSphere,
                ISpatialBoundingVolume*,
                int>)((*lpVtbl)[8])
        )(this, coordinateSystem, sphere, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FromFrustum(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem coordinateSystem,
        [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingFrustum")]
            SpatialBoundingFrustum frustum,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")]
            ISpatialBoundingVolume* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialBoundingVolumeStatics,
                ISpatialCoordinateSystem,
                SpatialBoundingFrustum,
                ISpatialBoundingVolume*,
                int>)((*lpVtbl)[9])
        )(this, coordinateSystem, frustum, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromBox(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem coordinateSystem,
            [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingBox")]
                SpatialBoundingBox box,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")]
                ISpatialBoundingVolume* value
        );

        [VtblIndex(7)]
        HRESULT FromOrientedBox(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem coordinateSystem,
            [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingOrientedBox")]
                SpatialBoundingOrientedBox box,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")]
                ISpatialBoundingVolume* value
        );

        [VtblIndex(8)]
        HRESULT FromSphere(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem coordinateSystem,
            [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingSphere")]
                SpatialBoundingSphere sphere,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")]
                ISpatialBoundingVolume* value
        );

        [VtblIndex(9)]
        HRESULT FromFrustum(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem coordinateSystem,
            [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingFrustum")]
                SpatialBoundingFrustum frustum,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")]
                ISpatialBoundingVolume* value
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::SpatialBoundingBox, ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialCoordinateSystem,
            SpatialBoundingBox,
            ISpatialBoundingVolume*,
            int> FromBox;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::SpatialBoundingOrientedBox, ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialCoordinateSystem,
            SpatialBoundingOrientedBox,
            ISpatialBoundingVolume*,
            int> FromOrientedBox;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::SpatialBoundingSphere, ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialCoordinateSystem,
            SpatialBoundingSphere,
            ISpatialBoundingVolume*,
            int> FromSphere;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::SpatialBoundingFrustum, ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialCoordinateSystem,
            SpatialBoundingFrustum,
            ISpatialBoundingVolume*,
            int> FromFrustum;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialBoundingVolumeStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialBoundingVolumeStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialBoundingVolumeStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialBoundingVolumeStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpatialBoundingVolumeStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialBoundingVolumeStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialBoundingVolumeStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpatialBoundingVolumeStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialBoundingVolumeStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialBoundingVolumeStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialBoundingVolumeStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialBoundingVolumeStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialBoundingVolumeStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialBoundingVolumeStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
