// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("4C7332EF-D39F-4396-B4D9-043957A7C964")]
[NativeTypeName("struct IAdaptiveMediaSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSource : IAdaptiveMediaSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAdaptiveMediaSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsLive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DesiredLiveOffset(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, TimeSpan*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_DesiredLiveOffset(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, TimeSpan, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InitialBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, uint*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_InitialBitrate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, uint, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CurrentDownloadBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, uint*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CurrentPlaybackBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, uint*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AvailableBitrates(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_UINT32_t **")]
            IVectorView<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSource, IVectorView<uint>**, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DesiredMinBitrate(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSource, IReference<uint>**, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_DesiredMinBitrate(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
            IReference<uint>* value
    )
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, IReference<uint>*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DesiredMaxBitrate(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSource, IReference<uint>**, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_DesiredMaxBitrate(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
            IReference<uint>* value
    )
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, IReference<uint>*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_AudioOnlyPlayback([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, byte*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_InboundBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, ulong*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_InboundBitsPerSecondWindow(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, TimeSpan*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_InboundBitsPerSecondWindow(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IAdaptiveMediaSource, TimeSpan, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT add_DownloadBitrateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadBitrateChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[22])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT remove_DownloadBitrateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSource, EventRegistrationToken, int>)((*lpVtbl)[23])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT add_PlaybackBitrateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourcePlaybackBitrateChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[24])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT remove_PlaybackBitrateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSource, EventRegistrationToken, int>)((*lpVtbl)[25])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT add_DownloadRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[26])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT remove_DownloadRequested(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSource, EventRegistrationToken, int>)((*lpVtbl)[27])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT add_DownloadCompleted(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadCompletedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[28])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT remove_DownloadCompleted(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSource, EventRegistrationToken, int>)((*lpVtbl)[29])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT add_DownloadFailed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadFailedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[30])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT remove_DownloadFailed(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSource, EventRegistrationToken, int>)((*lpVtbl)[31])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsLive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_DesiredLiveOffset(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(8)]
        HRESULT put_DesiredLiveOffset(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(9)]
        HRESULT get_InitialBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_InitialBitrate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_CurrentDownloadBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT get_CurrentPlaybackBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT get_AvailableBitrates(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_UINT32_t **")]
                IVectorView<uint>** value
        );

        [VtblIndex(14)]
        HRESULT get_DesiredMinBitrate(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(15)]
        HRESULT put_DesiredMinBitrate(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
                IReference<uint>* value
        );

        [VtblIndex(16)]
        HRESULT get_DesiredMaxBitrate(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(17)]
        HRESULT put_DesiredMaxBitrate(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
                IReference<uint>* value
        );

        [VtblIndex(18)]
        HRESULT get_AudioOnlyPlayback([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT get_InboundBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(20)]
        HRESULT get_InboundBitsPerSecondWindow(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(21)]
        HRESULT put_InboundBitsPerSecondWindow(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(22)]
        HRESULT add_DownloadBitrateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadBitrateChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(23)]
        HRESULT remove_DownloadBitrateChanged(EventRegistrationToken token);

        [VtblIndex(24)]
        HRESULT add_PlaybackBitrateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourcePlaybackBitrateChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(25)]
        HRESULT remove_PlaybackBitrateChanged(EventRegistrationToken token);

        [VtblIndex(26)]
        HRESULT add_DownloadRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(27)]
        HRESULT remove_DownloadRequested(EventRegistrationToken token);

        [VtblIndex(28)]
        HRESULT add_DownloadCompleted(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadCompletedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(29)]
        HRESULT remove_DownloadCompleted(EventRegistrationToken token);

        [VtblIndex(30)]
        HRESULT add_DownloadFailed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadFailedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(31)]
        HRESULT remove_DownloadFailed(EventRegistrationToken token);
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
        public delegate* unmanaged<TSelf*, byte*, int> get_IsLive;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_DesiredLiveOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_DesiredLiveOffset;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_InitialBitrate;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_InitialBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CurrentDownloadBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CurrentPlaybackBitrate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<uint>**, int> get_AvailableBitrates;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_DesiredMinBitrate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>*, int> put_DesiredMinBitrate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_DesiredMaxBitrate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>*, int> put_DesiredMaxBitrate;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AudioOnlyPlayback;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_InboundBitsPerSecond;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_InboundBitsPerSecondWindow;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_InboundBitsPerSecondWindow;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadBitrateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DownloadBitrateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_DownloadBitrateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourcePlaybackBitrateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PlaybackBitrateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_PlaybackBitrateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DownloadRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_DownloadRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DownloadCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_DownloadCompleted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DownloadFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_DownloadFailed;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdaptiveMediaSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdaptiveMediaSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdaptiveMediaSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdaptiveMediaSource(Silk.NET.WinRT.IInspectable value)
    {
        return new IAdaptiveMediaSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdaptiveMediaSource"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdaptiveMediaSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAdaptiveMediaSource value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdaptiveMediaSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdaptiveMediaSource(Silk.NET.Windows.IUnknown value)
    {
        return new IAdaptiveMediaSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdaptiveMediaSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdaptiveMediaSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAdaptiveMediaSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
