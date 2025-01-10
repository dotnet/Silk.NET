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

[Guid("31DC02BC-990A-4904-AA96-FE364381F136")]
[NativeTypeName("struct IAppBroadcastBackgroundServiceStreamInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastBackgroundServiceStreamInfo
    : IAppBroadcastBackgroundServiceStreamInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastBackgroundServiceStreamInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StreamState(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastStreamState *")]
            AppBroadcastStreamState* value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundServiceStreamInfo,
                AppBroadcastStreamState*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DesiredVideoEncodingBitrate([NativeTypeName("UINT64")] ulong value)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, ulong, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DesiredVideoEncodingBitrate([NativeTypeName("UINT64 *")] ulong* value)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, ulong*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BandwidthTestBitrate([NativeTypeName("UINT64")] ulong value)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, ulong, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BandwidthTestBitrate([NativeTypeName("UINT64 *")] ulong* value)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, ulong*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_AudioCodec(HSTRING value)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, HSTRING, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AudioCodec(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundServiceStreamInfo, HSTRING*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BroadcastStreamReader(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastStreamReader **")]
            IAppBroadcastStreamReader* value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundServiceStreamInfo,
                IAppBroadcastStreamReader*,
                int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_StreamStateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_Windows__CMedia__CCapture__CAppBroadcastStreamStateChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundServiceStreamInfo,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[14])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_StreamStateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundServiceStreamInfo,
                EventRegistrationToken,
                int>)((*lpVtbl)[15])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_VideoEncodingResolutionChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundServiceStreamInfo,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[16])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_VideoEncodingResolutionChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundServiceStreamInfo,
                EventRegistrationToken,
                int>)((*lpVtbl)[17])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_VideoEncodingBitrateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundServiceStreamInfo,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[18])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_VideoEncodingBitrateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundServiceStreamInfo,
                EventRegistrationToken,
                int>)((*lpVtbl)[19])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StreamState(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastStreamState *")]
                AppBroadcastStreamState* value
        );

        [VtblIndex(7)]
        HRESULT put_DesiredVideoEncodingBitrate([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(8)]
        HRESULT get_DesiredVideoEncodingBitrate([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(9)]
        HRESULT put_BandwidthTestBitrate([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(10)]
        HRESULT get_BandwidthTestBitrate([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(11)]
        HRESULT put_AudioCodec(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_AudioCodec(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_BroadcastStreamReader(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastStreamReader **")]
                IAppBroadcastStreamReader* value
        );

        [VtblIndex(14)]
        HRESULT add_StreamStateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_Windows__CMedia__CCapture__CAppBroadcastStreamStateChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(15)]
        HRESULT remove_StreamStateChanged(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT add_VideoEncodingResolutionChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(17)]
        HRESULT remove_VideoEncodingResolutionChanged(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT add_VideoEncodingBitrateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(19)]
        HRESULT remove_VideoEncodingBitrateChanged(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastStreamState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppBroadcastStreamState*, int> get_StreamState;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> put_DesiredVideoEncodingBitrate;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_DesiredVideoEncodingBitrate;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> put_BandwidthTestBitrate;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_BandwidthTestBitrate;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_AudioCodec;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioCodec;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastStreamReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppBroadcastStreamReader*,
            int> get_BroadcastStreamReader;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_Windows__CMedia__CCapture__CAppBroadcastStreamStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_StreamStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_StreamStateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_VideoEncodingResolutionChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_VideoEncodingResolutionChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_VideoEncodingBitrateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_VideoEncodingBitrateChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppBroadcastBackgroundServiceStreamInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppBroadcastBackgroundServiceStreamInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppBroadcastBackgroundServiceStreamInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppBroadcastBackgroundServiceStreamInfo(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAppBroadcastBackgroundServiceStreamInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastBackgroundServiceStreamInfo"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastBackgroundServiceStreamInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAppBroadcastBackgroundServiceStreamInfo value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppBroadcastBackgroundServiceStreamInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppBroadcastBackgroundServiceStreamInfo(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppBroadcastBackgroundServiceStreamInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastBackgroundServiceStreamInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastBackgroundServiceStreamInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppBroadcastBackgroundServiceStreamInfo value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
