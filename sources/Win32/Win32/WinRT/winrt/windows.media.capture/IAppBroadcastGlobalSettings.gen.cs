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

[Guid("B2CB27A5-70FC-4E17-80BD-6BA0FD3FF3A0")]
[NativeTypeName("struct IAppBroadcastGlobalSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastGlobalSettings
    : IAppBroadcastGlobalSettings.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastGlobalSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppBroadcastGlobalSettings, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastGlobalSettings, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsBroadcastEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsDisabledByPolicy([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsGpuConstrained([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HasHardwareEncoder([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsAudioCaptureEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsAudioCaptureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsMicrophoneCaptureEnabledByDefault(
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_IsEchoCancellationEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsEchoCancellationEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_SystemAudioGain(double value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, double, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SystemAudioGain(double* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, double*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_MicrophoneGain(double value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, double, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_MicrophoneGain(double* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, double*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_IsCameraCaptureEnabledByDefault([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_IsCameraCaptureEnabledByDefault([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_SelectedCameraId(HSTRING value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, HSTRING, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_SelectedCameraId(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, HSTRING*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_CameraOverlayLocation(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation")]
            AppBroadcastCameraOverlayLocation value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastGlobalSettings,
                AppBroadcastCameraOverlayLocation,
                int>)((*lpVtbl)[24])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_CameraOverlayLocation(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation *")]
            AppBroadcastCameraOverlayLocation* value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastGlobalSettings,
                AppBroadcastCameraOverlayLocation*,
                int>)((*lpVtbl)[25])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_CameraOverlaySize(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize")]
            AppBroadcastCameraOverlaySize value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastGlobalSettings, AppBroadcastCameraOverlaySize, int>)(
                (*lpVtbl)[26]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_CameraOverlaySize(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize *")]
            AppBroadcastCameraOverlaySize* value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastGlobalSettings, AppBroadcastCameraOverlaySize*, int>)(
                (*lpVtbl)[27]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_IsCursorImageCaptureEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_IsCursorImageCaptureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppBroadcastGlobalSettings, byte*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsBroadcastEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsDisabledByPolicy([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_IsGpuConstrained([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_HasHardwareEncoder([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_IsAudioCaptureEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_IsAudioCaptureEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT get_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_IsEchoCancellationEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_IsEchoCancellationEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_SystemAudioGain(double value);

        [VtblIndex(17)]
        HRESULT get_SystemAudioGain(double* value);

        [VtblIndex(18)]
        HRESULT put_MicrophoneGain(double value);

        [VtblIndex(19)]
        HRESULT get_MicrophoneGain(double* value);

        [VtblIndex(20)]
        HRESULT put_IsCameraCaptureEnabledByDefault([NativeTypeName("boolean")] byte value);

        [VtblIndex(21)]
        HRESULT get_IsCameraCaptureEnabledByDefault([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT put_SelectedCameraId(HSTRING value);

        [VtblIndex(23)]
        HRESULT get_SelectedCameraId(HSTRING* value);

        [VtblIndex(24)]
        HRESULT put_CameraOverlayLocation(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation")]
                AppBroadcastCameraOverlayLocation value
        );

        [VtblIndex(25)]
        HRESULT get_CameraOverlayLocation(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation *")]
                AppBroadcastCameraOverlayLocation* value
        );

        [VtblIndex(26)]
        HRESULT put_CameraOverlaySize(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize")]
                AppBroadcastCameraOverlaySize value
        );

        [VtblIndex(27)]
        HRESULT get_CameraOverlaySize(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize *")]
                AppBroadcastCameraOverlaySize* value
        );

        [VtblIndex(28)]
        HRESULT put_IsCursorImageCaptureEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(29)]
        HRESULT get_IsCursorImageCaptureEnabled([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsBroadcastEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsDisabledByPolicy;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsGpuConstrained;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_HasHardwareEncoder;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsAudioCaptureEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsAudioCaptureEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsMicrophoneCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsMicrophoneCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsEchoCancellationEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsEchoCancellationEnabled;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_SystemAudioGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_SystemAudioGain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_MicrophoneGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_MicrophoneGain;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsCameraCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsCameraCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_SelectedCameraId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SelectedCameraId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastCameraOverlayLocation,
            int> put_CameraOverlayLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastCameraOverlayLocation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastCameraOverlayLocation*,
            int> get_CameraOverlayLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastCameraOverlaySize,
            int> put_CameraOverlaySize;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastCameraOverlaySize *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastCameraOverlaySize*,
            int> get_CameraOverlaySize;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsCursorImageCaptureEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsCursorImageCaptureEnabled;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppBroadcastGlobalSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppBroadcastGlobalSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppBroadcastGlobalSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppBroadcastGlobalSettings(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppBroadcastGlobalSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastGlobalSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastGlobalSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppBroadcastGlobalSettings value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppBroadcastGlobalSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppBroadcastGlobalSettings(Silk.NET.Windows.IUnknown value)
    {
        return new IAppBroadcastGlobalSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastGlobalSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastGlobalSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppBroadcastGlobalSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
