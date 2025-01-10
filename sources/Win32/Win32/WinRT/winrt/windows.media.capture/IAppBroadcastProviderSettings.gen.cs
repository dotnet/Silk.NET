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

[Guid("C30BDF62-9948-458F-AD50-AA06EC03DA08")]
[NativeTypeName("struct IAppBroadcastProviderSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastProviderSettings
    : IAppBroadcastProviderSettings.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastProviderSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppBroadcastProviderSettings, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastProviderSettings, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAppBroadcastProviderSettings, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_DefaultBroadcastTitle(HSTRING value)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, HSTRING, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DefaultBroadcastTitle(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_AudioEncodingBitrate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, uint, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AudioEncodingBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, uint*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_CustomVideoEncodingBitrate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, uint, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CustomVideoEncodingBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, uint*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_CustomVideoEncodingHeight([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, uint, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CustomVideoEncodingHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, uint*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_CustomVideoEncodingWidth([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, uint, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_CustomVideoEncodingWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppBroadcastProviderSettings, uint*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_VideoEncodingBitrateMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode")]
            AppBroadcastVideoEncodingBitrateMode value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastProviderSettings,
                AppBroadcastVideoEncodingBitrateMode,
                int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_VideoEncodingBitrateMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode *")]
            AppBroadcastVideoEncodingBitrateMode* value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastProviderSettings,
                AppBroadcastVideoEncodingBitrateMode*,
                int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_VideoEncodingResolutionMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode")]
            AppBroadcastVideoEncodingResolutionMode value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastProviderSettings,
                AppBroadcastVideoEncodingResolutionMode,
                int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_VideoEncodingResolutionMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode *")]
            AppBroadcastVideoEncodingResolutionMode* value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastProviderSettings,
                AppBroadcastVideoEncodingResolutionMode*,
                int>)((*lpVtbl)[19])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_DefaultBroadcastTitle(HSTRING value);

        [VtblIndex(7)]
        HRESULT get_DefaultBroadcastTitle(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_AudioEncodingBitrate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(9)]
        HRESULT get_AudioEncodingBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_CustomVideoEncodingBitrate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_CustomVideoEncodingBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_CustomVideoEncodingHeight([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_CustomVideoEncodingHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT put_CustomVideoEncodingWidth([NativeTypeName("UINT32")] uint value);

        [VtblIndex(15)]
        HRESULT get_CustomVideoEncodingWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT put_VideoEncodingBitrateMode(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode")]
                AppBroadcastVideoEncodingBitrateMode value
        );

        [VtblIndex(17)]
        HRESULT get_VideoEncodingBitrateMode(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode *")]
                AppBroadcastVideoEncodingBitrateMode* value
        );

        [VtblIndex(18)]
        HRESULT put_VideoEncodingResolutionMode(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode"
            )]
                AppBroadcastVideoEncodingResolutionMode value
        );

        [VtblIndex(19)]
        HRESULT get_VideoEncodingResolutionMode(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode *"
            )]
                AppBroadcastVideoEncodingResolutionMode* value
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DefaultBroadcastTitle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DefaultBroadcastTitle;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_AudioEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_AudioEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_CustomVideoEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CustomVideoEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_CustomVideoEncodingHeight;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CustomVideoEncodingHeight;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_CustomVideoEncodingWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CustomVideoEncodingWidth;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastVideoEncodingBitrateMode,
            int> put_VideoEncodingBitrateMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastVideoEncodingBitrateMode*,
            int> get_VideoEncodingBitrateMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastVideoEncodingResolutionMode,
            int> put_VideoEncodingResolutionMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastVideoEncodingResolutionMode*,
            int> get_VideoEncodingResolutionMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppBroadcastProviderSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppBroadcastProviderSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppBroadcastProviderSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppBroadcastProviderSettings(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppBroadcastProviderSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastProviderSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastProviderSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppBroadcastProviderSettings value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppBroadcastProviderSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppBroadcastProviderSettings(Silk.NET.Windows.IUnknown value)
    {
        return new IAppBroadcastProviderSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastProviderSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastProviderSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppBroadcastProviderSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
