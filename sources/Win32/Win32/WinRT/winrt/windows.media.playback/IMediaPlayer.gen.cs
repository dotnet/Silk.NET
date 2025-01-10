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

[Guid("381A83CB-6FFF-499B-8D64-2885DFC1249E")]
[NativeTypeName("struct IMediaPlayer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayer : IMediaPlayer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPlayer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPlayer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlayer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaPlayer, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlayer, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaPlayer, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AutoPlay([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlayer, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AutoPlay([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaPlayer, byte, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "Use PlaybackSession.NaturalDuration instead of NaturalDuration.  For more info, see MSDN."
    )]
    public HRESULT get_NaturalDuration(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer, TimeSpan*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
    public HRESULT get_Position(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer, TimeSpan*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
    public HRESULT put_Position(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer, TimeSpan, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "Use PlaybackSession.BufferingProgress instead of BufferingProgress.  For more info, see MSDN."
    )]
    public HRESULT get_BufferingProgress(double* value)
    {
        return ((delegate* unmanaged<IMediaPlayer, double*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("Use PlaybackSession.State instead of CurrentState.  For more info, see MSDN.")]
    public HRESULT get_CurrentState(
        [NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerState *")]
            MediaPlayerState* value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer, MediaPlayerState*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("Use PlaybackSession.CanSeek instead of CanSeek.  For more info, see MSDN.")]
    public HRESULT get_CanSeek([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlayer, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("Use PlaybackSession.CanPause instead of CanPause.  For more info, see MSDN.")]
    public HRESULT get_CanPause([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlayer, byte*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsLoopingEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlayer, byte*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IsLoopingEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaPlayer, byte, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("Use PlaybackSession.IsProtected instead of IsProtected.  For more info, see MSDN.")]
    public HRESULT get_IsProtected([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlayer, byte*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_IsMuted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlayer, byte*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_IsMuted([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaPlayer, byte, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [Obsolete(
        "Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN."
    )]
    public HRESULT get_PlaybackRate(double* value)
    {
        return ((delegate* unmanaged<IMediaPlayer, double*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [Obsolete(
        "Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN."
    )]
    public HRESULT put_PlaybackRate(double value)
    {
        return ((delegate* unmanaged<IMediaPlayer, double, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Volume(double* value)
    {
        return ((delegate* unmanaged<IMediaPlayer, double*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Volume(double value)
    {
        return ((delegate* unmanaged<IMediaPlayer, double, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [Obsolete(
        "Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN."
    )]
    public HRESULT get_PlaybackMediaMarkers(
        [NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarkerSequence **")]
            IPlaybackMediaMarkerSequence* value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlayer, IPlaybackMediaMarkerSequence*, int>)((*lpVtbl)[24])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT add_MediaOpened(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[25])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT remove_MediaOpened(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer, EventRegistrationToken, int>)((*lpVtbl)[26]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT add_MediaEnded(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[27])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT remove_MediaEnded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer, EventRegistrationToken, int>)((*lpVtbl)[28]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT add_MediaFailed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerFailedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[29])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT remove_MediaFailed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer, EventRegistrationToken, int>)((*lpVtbl)[30]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [Obsolete(
        "Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN."
    )]
    public HRESULT add_CurrentStateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[31])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [Obsolete(
        "Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN."
    )]
    public HRESULT remove_CurrentStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer, EventRegistrationToken, int>)((*lpVtbl)[32]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [Obsolete(
        "Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN."
    )]
    public HRESULT add_PlaybackMediaMarkerReached(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CPlaybackMediaMarkerReachedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[33])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    [Obsolete(
        "Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN."
    )]
    public HRESULT remove_PlaybackMediaMarkerReached(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer, EventRegistrationToken, int>)((*lpVtbl)[34]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    [Obsolete(
        "Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN."
    )]
    public HRESULT add_MediaPlayerRateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerRateChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[35])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    [Obsolete(
        "Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN."
    )]
    public HRESULT remove_MediaPlayerRateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer, EventRegistrationToken, int>)((*lpVtbl)[36]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT add_VolumeChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[37])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT remove_VolumeChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer, EventRegistrationToken, int>)((*lpVtbl)[38]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [Obsolete(
        "Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN."
    )]
    public HRESULT add_SeekCompleted(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[39])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    [Obsolete(
        "Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN."
    )]
    public HRESULT remove_SeekCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer, EventRegistrationToken, int>)((*lpVtbl)[40]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    [Obsolete(
        "Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN."
    )]
    public HRESULT add_BufferingStarted(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[41])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    [Obsolete(
        "Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN."
    )]
    public HRESULT remove_BufferingStarted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer, EventRegistrationToken, int>)((*lpVtbl)[42]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    [Obsolete(
        "Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN."
    )]
    public HRESULT add_BufferingEnded(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[43])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    [Obsolete(
        "Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN."
    )]
    public HRESULT remove_BufferingEnded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer, EventRegistrationToken, int>)((*lpVtbl)[44]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT Play()
    {
        return ((delegate* unmanaged<IMediaPlayer, int>)((*lpVtbl)[45]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMediaPlayer, int>)((*lpVtbl)[46]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    [Obsolete("Use Source instead of SetUriSource.  For more info, see MSDN.")]
    public HRESULT SetUriSource(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer, IUriRuntimeClass, int>)((*lpVtbl)[47]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AutoPlay([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AutoPlay([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        [Obsolete(
            "Use PlaybackSession.NaturalDuration instead of NaturalDuration.  For more info, see MSDN."
        )]
        HRESULT get_NaturalDuration(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(9)]
        [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
        HRESULT get_Position(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(10)]
        [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(11)]
        [Obsolete(
            "Use PlaybackSession.BufferingProgress instead of BufferingProgress.  For more info, see MSDN."
        )]
        HRESULT get_BufferingProgress(double* value);

        [VtblIndex(12)]
        [Obsolete("Use PlaybackSession.State instead of CurrentState.  For more info, see MSDN.")]
        HRESULT get_CurrentState(
            [NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerState *")]
                MediaPlayerState* value
        );

        [VtblIndex(13)]
        [Obsolete("Use PlaybackSession.CanSeek instead of CanSeek.  For more info, see MSDN.")]
        HRESULT get_CanSeek([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        [Obsolete("Use PlaybackSession.CanPause instead of CanPause.  For more info, see MSDN.")]
        HRESULT get_CanPause([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT get_IsLoopingEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_IsLoopingEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        [Obsolete(
            "Use PlaybackSession.IsProtected instead of IsProtected.  For more info, see MSDN."
        )]
        HRESULT get_IsProtected([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT get_IsMuted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT put_IsMuted([NativeTypeName("boolean")] byte value);

        [VtblIndex(20)]
        [Obsolete(
            "Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN."
        )]
        HRESULT get_PlaybackRate(double* value);

        [VtblIndex(21)]
        [Obsolete(
            "Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN."
        )]
        HRESULT put_PlaybackRate(double value);

        [VtblIndex(22)]
        HRESULT get_Volume(double* value);

        [VtblIndex(23)]
        HRESULT put_Volume(double value);

        [VtblIndex(24)]
        [Obsolete(
            "Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN."
        )]
        HRESULT get_PlaybackMediaMarkers(
            [NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarkerSequence **")]
                IPlaybackMediaMarkerSequence* value
        );

        [VtblIndex(25)]
        HRESULT add_MediaOpened(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(26)]
        HRESULT remove_MediaOpened(EventRegistrationToken token);

        [VtblIndex(27)]
        HRESULT add_MediaEnded(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(28)]
        HRESULT remove_MediaEnded(EventRegistrationToken token);

        [VtblIndex(29)]
        HRESULT add_MediaFailed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerFailedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(30)]
        HRESULT remove_MediaFailed(EventRegistrationToken token);

        [VtblIndex(31)]
        [Obsolete(
            "Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN."
        )]
        HRESULT add_CurrentStateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(32)]
        [Obsolete(
            "Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN."
        )]
        HRESULT remove_CurrentStateChanged(EventRegistrationToken token);

        [VtblIndex(33)]
        [Obsolete(
            "Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN."
        )]
        HRESULT add_PlaybackMediaMarkerReached(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CPlaybackMediaMarkerReachedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(34)]
        [Obsolete(
            "Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN."
        )]
        HRESULT remove_PlaybackMediaMarkerReached(EventRegistrationToken token);

        [VtblIndex(35)]
        [Obsolete(
            "Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN."
        )]
        HRESULT add_MediaPlayerRateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerRateChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(36)]
        [Obsolete(
            "Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN."
        )]
        HRESULT remove_MediaPlayerRateChanged(EventRegistrationToken token);

        [VtblIndex(37)]
        HRESULT add_VolumeChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(38)]
        HRESULT remove_VolumeChanged(EventRegistrationToken token);

        [VtblIndex(39)]
        [Obsolete(
            "Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN."
        )]
        HRESULT add_SeekCompleted(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(40)]
        [Obsolete(
            "Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN."
        )]
        HRESULT remove_SeekCompleted(EventRegistrationToken token);

        [VtblIndex(41)]
        [Obsolete(
            "Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN."
        )]
        HRESULT add_BufferingStarted(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(42)]
        [Obsolete(
            "Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN."
        )]
        HRESULT remove_BufferingStarted(EventRegistrationToken token);

        [VtblIndex(43)]
        [Obsolete(
            "Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN."
        )]
        HRESULT add_BufferingEnded(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(44)]
        [Obsolete(
            "Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN."
        )]
        HRESULT remove_BufferingEnded(EventRegistrationToken token);

        [VtblIndex(45)]
        HRESULT Play();

        [VtblIndex(46)]
        HRESULT Pause();

        [VtblIndex(47)]
        [Obsolete("Use Source instead of SetUriSource.  For more info, see MSDN.")]
        HRESULT SetUriSource(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AutoPlay;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AutoPlay;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        [Obsolete(
            "Use PlaybackSession.NaturalDuration instead of NaturalDuration.  For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_NaturalDuration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_Position;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        [Obsolete(
            "Use PlaybackSession.BufferingProgress instead of BufferingProgress.  For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, double*, int> get_BufferingProgress;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::MediaPlayerState *) __attribute__((stdcall))"
        )]
        [Obsolete("Use PlaybackSession.State instead of CurrentState.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, MediaPlayerState*, int> get_CurrentState;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.CanSeek instead of CanSeek.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanSeek;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.CanPause instead of CanPause.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanPause;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsLoopingEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsLoopingEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "Use PlaybackSession.IsProtected instead of IsProtected.  For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsProtected;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsMuted;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsMuted;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        [Obsolete(
            "Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, double*, int> get_PlaybackRate;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        [Obsolete(
            "Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, double, int> put_PlaybackRate;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Volume;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Volume;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IPlaybackMediaMarkerSequence **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IPlaybackMediaMarkerSequence*,
            int> get_PlaybackMediaMarkers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MediaOpened;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_MediaOpened;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MediaEnded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_MediaEnded;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MediaFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_MediaFailed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CurrentStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_CurrentStateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CPlaybackMediaMarkerReachedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PlaybackMediaMarkerReached;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_PlaybackMediaMarkerReached;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerRateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MediaPlayerRateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_MediaPlayerRateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_VolumeChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_VolumeChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SeekCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SeekCompleted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_BufferingStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_BufferingStarted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_BufferingEnded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_BufferingEnded;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Play;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        [Obsolete("Use Source instead of SetUriSource.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> SetUriSource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlayer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlayer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlayer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlayer(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlayer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlayer"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlayer"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlayer value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlayer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlayer(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlayer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlayer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlayer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlayer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
