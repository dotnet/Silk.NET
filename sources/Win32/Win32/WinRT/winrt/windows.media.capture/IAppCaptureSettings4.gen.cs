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

[Guid("07C2774C-1A81-482F-A244-049D95F25B0B")]
[NativeTypeName("struct IAppCaptureSettings4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureSettings4 : IAppCaptureSettings4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureSettings4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppCaptureSettings4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, byte, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsMicrophoneCaptureEnabledByDefault(
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_SystemAudioGain(double value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, double, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SystemAudioGain(double* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, double*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_MicrophoneGain(double value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, double, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MicrophoneGain(double* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings4, double*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_VideoEncodingFrameRateMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode")]
            AppCaptureVideoEncodingFrameRateMode value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureSettings4, AppCaptureVideoEncodingFrameRateMode, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_VideoEncodingFrameRateMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode *")]
            AppCaptureVideoEncodingFrameRateMode* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureSettings4, AppCaptureVideoEncodingFrameRateMode*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_SystemAudioGain(double value);

        [VtblIndex(9)]
        HRESULT get_SystemAudioGain(double* value);

        [VtblIndex(10)]
        HRESULT put_MicrophoneGain(double value);

        [VtblIndex(11)]
        HRESULT get_MicrophoneGain(double* value);

        [VtblIndex(12)]
        HRESULT put_VideoEncodingFrameRateMode(
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode")]
                AppCaptureVideoEncodingFrameRateMode value
        );

        [VtblIndex(13)]
        HRESULT get_VideoEncodingFrameRateMode(
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode *")]
                AppCaptureVideoEncodingFrameRateMode* value
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsMicrophoneCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsMicrophoneCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_SystemAudioGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_SystemAudioGain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_MicrophoneGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_MicrophoneGain;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppCaptureVideoEncodingFrameRateMode,
            int> put_VideoEncodingFrameRateMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppCaptureVideoEncodingFrameRateMode*,
            int> get_VideoEncodingFrameRateMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppCaptureSettings4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppCaptureSettings4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppCaptureSettings4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppCaptureSettings4(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppCaptureSettings4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppCaptureSettings4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppCaptureSettings4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppCaptureSettings4 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppCaptureSettings4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppCaptureSettings4(Silk.NET.Windows.IUnknown value)
    {
        return new IAppCaptureSettings4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppCaptureSettings4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppCaptureSettings4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppCaptureSettings4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
