// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("90C65B7F-4E0D-4CA4-882D-7A144FED0A90")]
[NativeTypeName("struct ICapturedFrameControlValues : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICapturedFrameControlValues
    : ICapturedFrameControlValues.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICapturedFrameControlValues));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICapturedFrameControlValues, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICapturedFrameControlValues, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICapturedFrameControlValues, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICapturedFrameControlValues, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Exposure(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
        )]
            IReference<TimeSpan>** value
    )
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, IReference<TimeSpan>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExposureCompensation(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")]
            IReference<float>** value
    )
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, IReference<float>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsoSpeed(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, IReference<uint>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Focus(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, IReference<uint>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SceneMode(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **"
        )]
            IReference<CaptureSceneMode>** value
    )
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, IReference<CaptureSceneMode>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Flashed(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")]
            IReference<byte>** value
    )
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, IReference<byte>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FlashPowerPercent(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")]
            IReference<float>** value
    )
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, IReference<float>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_WhiteBalance(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, IReference<uint>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ZoomFactor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")]
            IReference<float>** value
    )
    {
        return (
            (delegate* unmanaged<ICapturedFrameControlValues, IReference<float>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Exposure(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
            )]
                IReference<TimeSpan>** value
        );

        [VtblIndex(7)]
        HRESULT get_ExposureCompensation(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")]
                IReference<float>** value
        );

        [VtblIndex(8)]
        HRESULT get_IsoSpeed(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(9)]
        HRESULT get_Focus(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(10)]
        HRESULT get_SceneMode(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **"
            )]
                IReference<CaptureSceneMode>** value
        );

        [VtblIndex(11)]
        HRESULT get_Flashed(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")]
                IReference<byte>** value
        );

        [VtblIndex(12)]
        HRESULT get_FlashPowerPercent(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")]
                IReference<float>** value
        );

        [VtblIndex(13)]
        HRESULT get_WhiteBalance(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(14)]
        HRESULT get_ZoomFactor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")]
                IReference<float>** value
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
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<TimeSpan>**, int> get_Exposure;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<float>**, int> get_ExposureCompensation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_IsoSpeed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_Focus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<CaptureSceneMode>**, int> get_SceneMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<byte>**, int> get_Flashed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<float>**, int> get_FlashPowerPercent;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_WhiteBalance;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<float>**, int> get_ZoomFactor;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICapturedFrameControlValues"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICapturedFrameControlValues(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICapturedFrameControlValues"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICapturedFrameControlValues(Silk.NET.WinRT.IInspectable value)
    {
        return new ICapturedFrameControlValues(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICapturedFrameControlValues"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICapturedFrameControlValues"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICapturedFrameControlValues value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICapturedFrameControlValues"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICapturedFrameControlValues(Silk.NET.Windows.IUnknown value)
    {
        return new ICapturedFrameControlValues(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICapturedFrameControlValues"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICapturedFrameControlValues"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICapturedFrameControlValues value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
