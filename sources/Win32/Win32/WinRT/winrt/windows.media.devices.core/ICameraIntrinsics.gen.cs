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

[Guid("0AA6ED32-6589-49DA-AFDE-594270CA0AAC")]
[NativeTypeName("struct ICameraIntrinsics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraIntrinsics : ICameraIntrinsics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraIntrinsics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICameraIntrinsics, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICameraIntrinsics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICameraIntrinsics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICameraIntrinsics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICameraIntrinsics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FocalLength(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics, Vector2*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PrincipalPoint(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics, Vector2*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RadialDistortion(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics, Vector3*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TangentialDistortion(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics, Vector2*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ImageWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ICameraIntrinsics, uint*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ImageHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ICameraIntrinsics, uint*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ProjectOntoFrame(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 coordinate,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics, Vector3, Point*, int>)((*lpVtbl)[12]))(
            this,
            coordinate,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UnprojectAtUnitDepth(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point pixelCoordinate,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* result
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics, Point, Vector2*, int>)((*lpVtbl)[13]))(
            this,
            pixelCoordinate,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ProjectManyOntoFrame(
        [NativeTypeName("UINT32")] uint coordinatesLength,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* coordinates,
        [NativeTypeName("UINT32")] uint resultsLength,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results
    )
    {
        return (
            (delegate* unmanaged<ICameraIntrinsics, uint, Vector3*, uint, Point*, int>)(
                (*lpVtbl)[14]
            )
        )(this, coordinatesLength, coordinates, resultsLength, results);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT UnprojectPixelsAtUnitDepth(
        [NativeTypeName("UINT32")] uint pixelCoordinatesLength,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* pixelCoordinates,
        [NativeTypeName("UINT32")] uint resultsLength,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* results
    )
    {
        return (
            (delegate* unmanaged<ICameraIntrinsics, uint, Point*, uint, Vector2*, int>)(
                (*lpVtbl)[15]
            )
        )(this, pixelCoordinatesLength, pixelCoordinates, resultsLength, results);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FocalLength(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(7)]
        HRESULT get_PrincipalPoint(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(8)]
        HRESULT get_RadialDistortion(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(9)]
        HRESULT get_TangentialDistortion(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(10)]
        HRESULT get_ImageWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT get_ImageHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT ProjectOntoFrame(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 coordinate,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result
        );

        [VtblIndex(13)]
        HRESULT UnprojectAtUnitDepth(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point pixelCoordinate,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* result
        );

        [VtblIndex(14)]
        HRESULT ProjectManyOntoFrame(
            [NativeTypeName("UINT32")] uint coordinatesLength,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* coordinates,
            [NativeTypeName("UINT32")] uint resultsLength,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results
        );

        [VtblIndex(15)]
        HRESULT UnprojectPixelsAtUnitDepth(
            [NativeTypeName("UINT32")] uint pixelCoordinatesLength,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* pixelCoordinates,
            [NativeTypeName("UINT32")] uint resultsLength,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* results
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
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_FocalLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_PrincipalPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_RadialDistortion;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_TangentialDistortion;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ImageWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ImageHeight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Point *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3, Point*, int> ProjectOntoFrame;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Point, Vector2*, int> UnprojectAtUnitDepth;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Numerics::Vector3 *, UINT32, ABI::Windows::Foundation::Point *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Vector3*, uint, Point*, int> ProjectManyOntoFrame;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Point *, UINT32, ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            Point*,
            uint,
            Vector2*,
            int> UnprojectPixelsAtUnitDepth;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICameraIntrinsics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICameraIntrinsics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICameraIntrinsics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICameraIntrinsics(Silk.NET.WinRT.IInspectable value)
    {
        return new ICameraIntrinsics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraIntrinsics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraIntrinsics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICameraIntrinsics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICameraIntrinsics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICameraIntrinsics(Silk.NET.Windows.IUnknown value)
    {
        return new ICameraIntrinsics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraIntrinsics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraIntrinsics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICameraIntrinsics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
