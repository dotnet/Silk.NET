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

[Guid("0CDAA447-0798-4B4D-839F-C5EC414DB27A")]
[NativeTypeName("struct ICameraIntrinsics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraIntrinsics2 : ICameraIntrinsics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraIntrinsics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICameraIntrinsics2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICameraIntrinsics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICameraIntrinsics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICameraIntrinsics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICameraIntrinsics2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UndistortedProjectionTransform(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics2, Matrix4x4*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DistortPoint(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point input,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics2, Point, Point*, int>)((*lpVtbl)[7]))(
            this,
            input,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DistortPoints(
        [NativeTypeName("UINT32")] uint inputsLength,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* inputs,
        [NativeTypeName("UINT32")] uint resultsLength,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results
    )
    {
        return (
            (delegate* unmanaged<ICameraIntrinsics2, uint, Point*, uint, Point*, int>)((*lpVtbl)[8])
        )(this, inputsLength, inputs, resultsLength, results);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UndistortPoint(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point input,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsics2, Point, Point*, int>)((*lpVtbl)[9]))(
            this,
            input,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT UndistortPoints(
        [NativeTypeName("UINT32")] uint inputsLength,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* inputs,
        [NativeTypeName("UINT32")] uint resultsLength,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results
    )
    {
        return (
            (delegate* unmanaged<ICameraIntrinsics2, uint, Point*, uint, Point*, int>)(
                (*lpVtbl)[10]
            )
        )(this, inputsLength, inputs, resultsLength, results);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UndistortedProjectionTransform(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value
        );

        [VtblIndex(7)]
        HRESULT DistortPoint(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point input,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result
        );

        [VtblIndex(8)]
        HRESULT DistortPoints(
            [NativeTypeName("UINT32")] uint inputsLength,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* inputs,
            [NativeTypeName("UINT32")] uint resultsLength,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results
        );

        [VtblIndex(9)]
        HRESULT UndistortPoint(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point input,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result
        );

        [VtblIndex(10)]
        HRESULT UndistortPoints(
            [NativeTypeName("UINT32")] uint inputsLength,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* inputs,
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
            "HRESULT (ABI::Windows::Foundation::Numerics::Matrix4x4 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Matrix4x4*, int> get_UndistortedProjectionTransform;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Foundation::Point *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Point, Point*, int> DistortPoint;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Point *, UINT32, ABI::Windows::Foundation::Point *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Point*, uint, Point*, int> DistortPoints;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Foundation::Point *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Point, Point*, int> UndistortPoint;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Point *, UINT32, ABI::Windows::Foundation::Point *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Point*, uint, Point*, int> UndistortPoints;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICameraIntrinsics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICameraIntrinsics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICameraIntrinsics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICameraIntrinsics2(Silk.NET.WinRT.IInspectable value)
    {
        return new ICameraIntrinsics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraIntrinsics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraIntrinsics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICameraIntrinsics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICameraIntrinsics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICameraIntrinsics2(Silk.NET.Windows.IUnknown value)
    {
        return new ICameraIntrinsics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraIntrinsics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraIntrinsics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICameraIntrinsics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
