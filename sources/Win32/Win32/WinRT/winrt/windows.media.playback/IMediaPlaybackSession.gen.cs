// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C32B683D-0407-41BA-8946-8B345A5A5435")]
[NativeTypeName("struct IMediaPlaybackSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackSession : IMediaPlaybackSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackSession));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPlaybackSession, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_PlaybackStateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_PlaybackStateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, EventRegistrationToken, int>)((*lpVtbl)[7])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_PlaybackRateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_PlaybackRateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, EventRegistrationToken, int>)((*lpVtbl)[9])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_SeekCompleted(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_SeekCompleted(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_BufferingStarted(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_BufferingStarted(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, EventRegistrationToken, int>)((*lpVtbl)[13])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_BufferingEnded(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[14])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_BufferingEnded(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, EventRegistrationToken, int>)((*lpVtbl)[15])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_BufferingProgressChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[16])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_BufferingProgressChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, EventRegistrationToken, int>)((*lpVtbl)[17])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_DownloadProgressChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[18])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_DownloadProgressChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, EventRegistrationToken, int>)((*lpVtbl)[19])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_NaturalDurationChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[20])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_NaturalDurationChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, EventRegistrationToken, int>)((*lpVtbl)[21])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT add_PositionChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[22])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT remove_PositionChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, EventRegistrationToken, int>)((*lpVtbl)[23])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT add_NaturalVideoSizeChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[24])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT remove_NaturalVideoSizeChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, EventRegistrationToken, int>)((*lpVtbl)[25])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_MediaPlayer(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer* value
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, IMediaPlayer*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_NaturalDuration(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, TimeSpan*, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Position(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, TimeSpan*, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_Position(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, TimeSpan, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_PlaybackState(
        [NativeTypeName("ABI::Windows::Media::Playback::MediaPlaybackState *")]
            MediaPlaybackState* value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, MediaPlaybackState*, int>)((*lpVtbl)[30])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_CanSeek([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, byte*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_CanPause([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, byte*, int>)((*lpVtbl)[32]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_IsProtected([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, byte*, int>)((*lpVtbl)[33]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_PlaybackRate(double* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, double*, int>)((*lpVtbl)[34]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_PlaybackRate(double value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, double, int>)((*lpVtbl)[35]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_BufferingProgress(double* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, double*, int>)((*lpVtbl)[36]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_DownloadProgress(double* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, double*, int>)((*lpVtbl)[37]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_NaturalVideoHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, uint*, int>)((*lpVtbl)[38]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_NaturalVideoWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, uint*, int>)((*lpVtbl)[39]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_NormalizedSourceRect(
        [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, Rect*, int>)((*lpVtbl)[40]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_NormalizedSourceRect(
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession, Rect, int>)((*lpVtbl)[41]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_StereoscopicVideoPackingMode(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::StereoscopicVideoPackingMode *")]
            StereoscopicVideoPackingMode* value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, StereoscopicVideoPackingMode*, int>)(
                (*lpVtbl)[42]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_StereoscopicVideoPackingMode(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::StereoscopicVideoPackingMode")]
            StereoscopicVideoPackingMode value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession, StereoscopicVideoPackingMode, int>)(
                (*lpVtbl)[43]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_PlaybackStateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_PlaybackStateChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_PlaybackRateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_PlaybackRateChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_SeekCompleted(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_SeekCompleted(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_BufferingStarted(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(13)]
        HRESULT remove_BufferingStarted(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_BufferingEnded(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(15)]
        HRESULT remove_BufferingEnded(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT add_BufferingProgressChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(17)]
        HRESULT remove_BufferingProgressChanged(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT add_DownloadProgressChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(19)]
        HRESULT remove_DownloadProgressChanged(EventRegistrationToken token);

        [VtblIndex(20)]
        HRESULT add_NaturalDurationChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(21)]
        HRESULT remove_NaturalDurationChanged(EventRegistrationToken token);

        [VtblIndex(22)]
        HRESULT add_PositionChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(23)]
        HRESULT remove_PositionChanged(EventRegistrationToken token);

        [VtblIndex(24)]
        HRESULT add_NaturalVideoSizeChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(25)]
        HRESULT remove_NaturalVideoSizeChanged(EventRegistrationToken token);

        [VtblIndex(26)]
        HRESULT get_MediaPlayer(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer* value
        );

        [VtblIndex(27)]
        HRESULT get_NaturalDuration(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(28)]
        HRESULT get_Position(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(29)]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(30)]
        HRESULT get_PlaybackState(
            [NativeTypeName("ABI::Windows::Media::Playback::MediaPlaybackState *")]
                MediaPlaybackState* value
        );

        [VtblIndex(31)]
        HRESULT get_CanSeek([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(32)]
        HRESULT get_CanPause([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(33)]
        HRESULT get_IsProtected([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(34)]
        HRESULT get_PlaybackRate(double* value);

        [VtblIndex(35)]
        HRESULT put_PlaybackRate(double value);

        [VtblIndex(36)]
        HRESULT get_BufferingProgress(double* value);

        [VtblIndex(37)]
        HRESULT get_DownloadProgress(double* value);

        [VtblIndex(38)]
        HRESULT get_NaturalVideoHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(39)]
        HRESULT get_NaturalVideoWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(40)]
        HRESULT get_NormalizedSourceRect(
            [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value
        );

        [VtblIndex(41)]
        HRESULT put_NormalizedSourceRect(
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value
        );

        [VtblIndex(42)]
        HRESULT get_StereoscopicVideoPackingMode(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::StereoscopicVideoPackingMode *")]
                StereoscopicVideoPackingMode* value
        );

        [VtblIndex(43)]
        HRESULT put_StereoscopicVideoPackingMode(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::StereoscopicVideoPackingMode")]
                StereoscopicVideoPackingMode value
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PlaybackStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PlaybackStateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PlaybackRateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PlaybackRateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SeekCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SeekCompleted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_BufferingStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_BufferingStarted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_BufferingEnded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_BufferingEnded;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_BufferingProgressChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_BufferingProgressChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DownloadProgressChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_DownloadProgressChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_NaturalDurationChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_NaturalDurationChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PositionChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PositionChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_NaturalVideoSizeChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_NaturalVideoSizeChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlayer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlayer*, int> get_MediaPlayer;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_NaturalDuration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::MediaPlaybackState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaPlaybackState*, int> get_PlaybackState;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanSeek;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanPause;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsProtected;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_PlaybackRate;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_PlaybackRate;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_BufferingProgress;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_DownloadProgress;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_NaturalVideoHeight;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_NaturalVideoWidth;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect*, int> get_NormalizedSourceRect;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect, int> put_NormalizedSourceRect;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::StereoscopicVideoPackingMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            StereoscopicVideoPackingMode*,
            int> get_StereoscopicVideoPackingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::StereoscopicVideoPackingMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            StereoscopicVideoPackingMode,
            int> put_StereoscopicVideoPackingMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlaybackSession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlaybackSession(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlaybackSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackSession(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlaybackSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackSession"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlaybackSession value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlaybackSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackSession(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlaybackSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackSession"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlaybackSession value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
