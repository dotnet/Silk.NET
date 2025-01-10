// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8BB94F8F-F11A-43DB-B402-11930B80AE56")]
[NativeTypeName("struct IAdvancedVideoCaptureDeviceController2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedVideoCaptureDeviceController2
    : IAdvancedVideoCaptureDeviceController2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedVideoCaptureDeviceController2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LowLagPhotoSequence(
        [NativeTypeName("ABI::Windows::Media::Devices::ILowLagPhotoSequenceControl **")]
            ILowLagPhotoSequenceControl* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController2,
                ILowLagPhotoSequenceControl*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LowLagPhoto(
        [NativeTypeName("ABI::Windows::Media::Devices::ILowLagPhotoControl **")]
            ILowLagPhotoControl* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController2,
                ILowLagPhotoControl*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SceneModeControl(
        [NativeTypeName("ABI::Windows::Media::Devices::ISceneModeControl **")]
            ISceneModeControl* value
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, ISceneModeControl*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TorchControl(
        [NativeTypeName("ABI::Windows::Media::Devices::ITorchControl **")] ITorchControl* value
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, ITorchControl*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FlashControl(
        [NativeTypeName("ABI::Windows::Media::Devices::IFlashControl **")] IFlashControl* value
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, IFlashControl*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_WhiteBalanceControl(
        [NativeTypeName("ABI::Windows::Media::Devices::IWhiteBalanceControl **")]
            IWhiteBalanceControl* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController2,
                IWhiteBalanceControl*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ExposureControl(
        [NativeTypeName("ABI::Windows::Media::Devices::IExposureControl **")]
            IExposureControl* value
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, IExposureControl*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_FocusControl(
        [NativeTypeName("ABI::Windows::Media::Devices::IFocusControl **")] IFocusControl* value
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, IFocusControl*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ExposureCompensationControl(
        [NativeTypeName("ABI::Windows::Media::Devices::IExposureCompensationControl **")]
            IExposureCompensationControl* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController2,
                IExposureCompensationControl*,
                int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsoSpeedControl(
        [NativeTypeName("ABI::Windows::Media::Devices::IIsoSpeedControl **")]
            IIsoSpeedControl* value
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, IIsoSpeedControl*, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_RegionsOfInterestControl(
        [NativeTypeName("ABI::Windows::Media::Devices::IRegionsOfInterestControl **")]
            IRegionsOfInterestControl* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController2,
                IRegionsOfInterestControl*,
                int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_PrimaryUse(
        [NativeTypeName("ABI::Windows::Media::Devices::CaptureUse *")] CaptureUse* value
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, CaptureUse*, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_PrimaryUse(
        [NativeTypeName("ABI::Windows::Media::Devices::CaptureUse")] CaptureUse value
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController2, CaptureUse, int>)(
                (*lpVtbl)[18]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LowLagPhotoSequence(
            [NativeTypeName("ABI::Windows::Media::Devices::ILowLagPhotoSequenceControl **")]
                ILowLagPhotoSequenceControl* value
        );

        [VtblIndex(7)]
        HRESULT get_LowLagPhoto(
            [NativeTypeName("ABI::Windows::Media::Devices::ILowLagPhotoControl **")]
                ILowLagPhotoControl* value
        );

        [VtblIndex(8)]
        HRESULT get_SceneModeControl(
            [NativeTypeName("ABI::Windows::Media::Devices::ISceneModeControl **")]
                ISceneModeControl* value
        );

        [VtblIndex(9)]
        HRESULT get_TorchControl(
            [NativeTypeName("ABI::Windows::Media::Devices::ITorchControl **")] ITorchControl* value
        );

        [VtblIndex(10)]
        HRESULT get_FlashControl(
            [NativeTypeName("ABI::Windows::Media::Devices::IFlashControl **")] IFlashControl* value
        );

        [VtblIndex(11)]
        HRESULT get_WhiteBalanceControl(
            [NativeTypeName("ABI::Windows::Media::Devices::IWhiteBalanceControl **")]
                IWhiteBalanceControl* value
        );

        [VtblIndex(12)]
        HRESULT get_ExposureControl(
            [NativeTypeName("ABI::Windows::Media::Devices::IExposureControl **")]
                IExposureControl* value
        );

        [VtblIndex(13)]
        HRESULT get_FocusControl(
            [NativeTypeName("ABI::Windows::Media::Devices::IFocusControl **")] IFocusControl* value
        );

        [VtblIndex(14)]
        HRESULT get_ExposureCompensationControl(
            [NativeTypeName("ABI::Windows::Media::Devices::IExposureCompensationControl **")]
                IExposureCompensationControl* value
        );

        [VtblIndex(15)]
        HRESULT get_IsoSpeedControl(
            [NativeTypeName("ABI::Windows::Media::Devices::IIsoSpeedControl **")]
                IIsoSpeedControl* value
        );

        [VtblIndex(16)]
        HRESULT get_RegionsOfInterestControl(
            [NativeTypeName("ABI::Windows::Media::Devices::IRegionsOfInterestControl **")]
                IRegionsOfInterestControl* value
        );

        [VtblIndex(17)]
        HRESULT get_PrimaryUse(
            [NativeTypeName("ABI::Windows::Media::Devices::CaptureUse *")] CaptureUse* value
        );

        [VtblIndex(18)]
        HRESULT put_PrimaryUse(
            [NativeTypeName("ABI::Windows::Media::Devices::CaptureUse")] CaptureUse value
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
            "HRESULT (ABI::Windows::Media::Devices::ILowLagPhotoSequenceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ILowLagPhotoSequenceControl*,
            int> get_LowLagPhotoSequence;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::ILowLagPhotoControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ILowLagPhotoControl*, int> get_LowLagPhoto;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::ISceneModeControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISceneModeControl*, int> get_SceneModeControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::ITorchControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITorchControl*, int> get_TorchControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IFlashControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFlashControl*, int> get_FlashControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IWhiteBalanceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWhiteBalanceControl*, int> get_WhiteBalanceControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IExposureControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IExposureControl*, int> get_ExposureControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IFocusControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFocusControl*, int> get_FocusControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IExposureCompensationControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IExposureCompensationControl*,
            int> get_ExposureCompensationControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IIsoSpeedControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIsoSpeedControl*, int> get_IsoSpeedControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IRegionsOfInterestControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRegionsOfInterestControl*,
            int> get_RegionsOfInterestControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::CaptureUse *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CaptureUse*, int> get_PrimaryUse;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::CaptureUse) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CaptureUse, int> put_PrimaryUse;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdvancedVideoCaptureDeviceController2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdvancedVideoCaptureDeviceController2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdvancedVideoCaptureDeviceController2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdvancedVideoCaptureDeviceController2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAdvancedVideoCaptureDeviceController2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedVideoCaptureDeviceController2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedVideoCaptureDeviceController2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAdvancedVideoCaptureDeviceController2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdvancedVideoCaptureDeviceController2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdvancedVideoCaptureDeviceController2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAdvancedVideoCaptureDeviceController2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedVideoCaptureDeviceController2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedVideoCaptureDeviceController2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAdvancedVideoCaptureDeviceController2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
