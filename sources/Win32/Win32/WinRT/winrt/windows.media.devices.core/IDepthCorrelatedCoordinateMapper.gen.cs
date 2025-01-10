// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F95D89FB-8AF0-4CB0-926D-696866E5046A")]
[NativeTypeName("struct IDepthCorrelatedCoordinateMapper : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDepthCorrelatedCoordinateMapper
    : IDepthCorrelatedCoordinateMapper.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDepthCorrelatedCoordinateMapper));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDepthCorrelatedCoordinateMapper, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDepthCorrelatedCoordinateMapper, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDepthCorrelatedCoordinateMapper, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IDepthCorrelatedCoordinateMapper, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IDepthCorrelatedCoordinateMapper, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IDepthCorrelatedCoordinateMapper, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnprojectPoint(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point sourcePoint,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem targetCoordinateSystem,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* result
    )
    {
        return (
            (delegate* unmanaged<
                IDepthCorrelatedCoordinateMapper,
                Point,
                ISpatialCoordinateSystem,
                Vector3*,
                int>)((*lpVtbl)[6])
        )(this, sourcePoint, targetCoordinateSystem, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnprojectPoints(
        [NativeTypeName("UINT32")] uint sourcePointsLength,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* sourcePoints,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem targetCoordinateSystem,
        [NativeTypeName("UINT32")] uint resultsLength,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* results
    )
    {
        return (
            (delegate* unmanaged<
                IDepthCorrelatedCoordinateMapper,
                uint,
                Point*,
                ISpatialCoordinateSystem,
                uint,
                Vector3*,
                int>)((*lpVtbl)[7])
        )(this, sourcePointsLength, sourcePoints, targetCoordinateSystem, resultsLength, results);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MapPoint(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point sourcePoint,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem targetCoordinateSystem,
        [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")]
            ICameraIntrinsics targetCameraIntrinsics,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result
    )
    {
        return (
            (delegate* unmanaged<
                IDepthCorrelatedCoordinateMapper,
                Point,
                ISpatialCoordinateSystem,
                ICameraIntrinsics,
                Point*,
                int>)((*lpVtbl)[8])
        )(this, sourcePoint, targetCoordinateSystem, targetCameraIntrinsics, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT MapPoints(
        [NativeTypeName("UINT32")] uint sourcePointsLength,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* sourcePoints,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem targetCoordinateSystem,
        [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")]
            ICameraIntrinsics targetCameraIntrinsics,
        [NativeTypeName("UINT32")] uint resultsLength,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results
    )
    {
        return (
            (delegate* unmanaged<
                IDepthCorrelatedCoordinateMapper,
                uint,
                Point*,
                ISpatialCoordinateSystem,
                ICameraIntrinsics,
                uint,
                Point*,
                int>)((*lpVtbl)[9])
        )(
            this,
            sourcePointsLength,
            sourcePoints,
            targetCoordinateSystem,
            targetCameraIntrinsics,
            resultsLength,
            results
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT UnprojectPoint(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point sourcePoint,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem targetCoordinateSystem,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* result
        );

        [VtblIndex(7)]
        HRESULT UnprojectPoints(
            [NativeTypeName("UINT32")] uint sourcePointsLength,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* sourcePoints,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem targetCoordinateSystem,
            [NativeTypeName("UINT32")] uint resultsLength,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* results
        );

        [VtblIndex(8)]
        HRESULT MapPoint(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point sourcePoint,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem targetCoordinateSystem,
            [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")]
                ICameraIntrinsics targetCameraIntrinsics,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result
        );

        [VtblIndex(9)]
        HRESULT MapPoints(
            [NativeTypeName("UINT32")] uint sourcePointsLength,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* sourcePoints,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem targetCoordinateSystem,
            [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")]
                ICameraIntrinsics targetCameraIntrinsics,
            [NativeTypeName("UINT32")] uint resultsLength,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results
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
            "HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Point,
            ISpatialCoordinateSystem,
            Vector3*,
            int> UnprojectPoint;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Point *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, UINT32, ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            Point*,
            ISpatialCoordinateSystem,
            uint,
            Vector3*,
            int> UnprojectPoints;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Media::Devices::Core::ICameraIntrinsics *, ABI::Windows::Foundation::Point *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Point,
            ISpatialCoordinateSystem,
            ICameraIntrinsics,
            Point*,
            int> MapPoint;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Point *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Media::Devices::Core::ICameraIntrinsics *, UINT32, ABI::Windows::Foundation::Point *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            Point*,
            ISpatialCoordinateSystem,
            ICameraIntrinsics,
            uint,
            Point*,
            int> MapPoints;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDepthCorrelatedCoordinateMapper"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDepthCorrelatedCoordinateMapper(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDepthCorrelatedCoordinateMapper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDepthCorrelatedCoordinateMapper(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IDepthCorrelatedCoordinateMapper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDepthCorrelatedCoordinateMapper"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDepthCorrelatedCoordinateMapper"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IDepthCorrelatedCoordinateMapper value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDepthCorrelatedCoordinateMapper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDepthCorrelatedCoordinateMapper(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDepthCorrelatedCoordinateMapper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDepthCorrelatedCoordinateMapper"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDepthCorrelatedCoordinateMapper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDepthCorrelatedCoordinateMapper value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
