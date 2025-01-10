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

[Guid("5ACEE5A6-5CB6-4A5A-8521-CC86B1C1ED37")]
[NativeTypeName("struct IMediaPlaybackCommandManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackCommandManager
    : IMediaPlaybackCommandManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackCommandManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaPlaybackCommandManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlaybackCommandManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlaybackCommandManager, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackCommandManager, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaPlaybackCommandManager, byte, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MediaPlayer(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer* value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, IMediaPlayer*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PlayBehavior(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
        )]
            IMediaPlaybackCommandManagerCommandBehavior* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                IMediaPlaybackCommandManagerCommandBehavior*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PauseBehavior(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
        )]
            IMediaPlaybackCommandManagerCommandBehavior* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                IMediaPlaybackCommandManagerCommandBehavior*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NextBehavior(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
        )]
            IMediaPlaybackCommandManagerCommandBehavior* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                IMediaPlaybackCommandManagerCommandBehavior*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PreviousBehavior(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
        )]
            IMediaPlaybackCommandManagerCommandBehavior* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                IMediaPlaybackCommandManagerCommandBehavior*,
                int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_FastForwardBehavior(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
        )]
            IMediaPlaybackCommandManagerCommandBehavior* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                IMediaPlaybackCommandManagerCommandBehavior*,
                int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_RewindBehavior(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
        )]
            IMediaPlaybackCommandManagerCommandBehavior* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                IMediaPlaybackCommandManagerCommandBehavior*,
                int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ShuffleBehavior(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
        )]
            IMediaPlaybackCommandManagerCommandBehavior* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                IMediaPlaybackCommandManagerCommandBehavior*,
                int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AutoRepeatModeBehavior(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
        )]
            IMediaPlaybackCommandManagerCommandBehavior* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                IMediaPlaybackCommandManagerCommandBehavior*,
                int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_PositionBehavior(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
        )]
            IMediaPlaybackCommandManagerCommandBehavior* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                IMediaPlaybackCommandManagerCommandBehavior*,
                int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_RateBehavior(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
        )]
            IMediaPlaybackCommandManagerCommandBehavior* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                IMediaPlaybackCommandManagerCommandBehavior*,
                int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_PlayReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPlayReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[19])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_PlayReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, EventRegistrationToken, int>)(
                (*lpVtbl)[20]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT add_PauseReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPauseReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[21])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT remove_PauseReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, EventRegistrationToken, int>)(
                (*lpVtbl)[22]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT add_NextReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerNextReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[23])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT remove_NextReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, EventRegistrationToken, int>)(
                (*lpVtbl)[24]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT add_PreviousReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPreviousReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[25])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT remove_PreviousReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, EventRegistrationToken, int>)(
                (*lpVtbl)[26]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT add_FastForwardReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerFastForwardReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[27])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT remove_FastForwardReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, EventRegistrationToken, int>)(
                (*lpVtbl)[28]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT add_RewindReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRewindReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[29])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT remove_RewindReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, EventRegistrationToken, int>)(
                (*lpVtbl)[30]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT add_ShuffleReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerShuffleReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[31])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT remove_ShuffleReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, EventRegistrationToken, int>)(
                (*lpVtbl)[32]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT add_AutoRepeatModeReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[33])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT remove_AutoRepeatModeReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, EventRegistrationToken, int>)(
                (*lpVtbl)[34]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT add_PositionReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPositionReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[35])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT remove_PositionReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, EventRegistrationToken, int>)(
                (*lpVtbl)[36]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT add_RateReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRateReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[37])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT remove_RateReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManager, EventRegistrationToken, int>)(
                (*lpVtbl)[38]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_MediaPlayer(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer* value
        );

        [VtblIndex(9)]
        HRESULT get_PlayBehavior(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
            )]
                IMediaPlaybackCommandManagerCommandBehavior* value
        );

        [VtblIndex(10)]
        HRESULT get_PauseBehavior(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
            )]
                IMediaPlaybackCommandManagerCommandBehavior* value
        );

        [VtblIndex(11)]
        HRESULT get_NextBehavior(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
            )]
                IMediaPlaybackCommandManagerCommandBehavior* value
        );

        [VtblIndex(12)]
        HRESULT get_PreviousBehavior(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
            )]
                IMediaPlaybackCommandManagerCommandBehavior* value
        );

        [VtblIndex(13)]
        HRESULT get_FastForwardBehavior(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
            )]
                IMediaPlaybackCommandManagerCommandBehavior* value
        );

        [VtblIndex(14)]
        HRESULT get_RewindBehavior(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
            )]
                IMediaPlaybackCommandManagerCommandBehavior* value
        );

        [VtblIndex(15)]
        HRESULT get_ShuffleBehavior(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
            )]
                IMediaPlaybackCommandManagerCommandBehavior* value
        );

        [VtblIndex(16)]
        HRESULT get_AutoRepeatModeBehavior(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
            )]
                IMediaPlaybackCommandManagerCommandBehavior* value
        );

        [VtblIndex(17)]
        HRESULT get_PositionBehavior(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
            )]
                IMediaPlaybackCommandManagerCommandBehavior* value
        );

        [VtblIndex(18)]
        HRESULT get_RateBehavior(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **"
            )]
                IMediaPlaybackCommandManagerCommandBehavior* value
        );

        [VtblIndex(19)]
        HRESULT add_PlayReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPlayReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(20)]
        HRESULT remove_PlayReceived(EventRegistrationToken token);

        [VtblIndex(21)]
        HRESULT add_PauseReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPauseReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(22)]
        HRESULT remove_PauseReceived(EventRegistrationToken token);

        [VtblIndex(23)]
        HRESULT add_NextReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerNextReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(24)]
        HRESULT remove_NextReceived(EventRegistrationToken token);

        [VtblIndex(25)]
        HRESULT add_PreviousReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPreviousReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(26)]
        HRESULT remove_PreviousReceived(EventRegistrationToken token);

        [VtblIndex(27)]
        HRESULT add_FastForwardReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerFastForwardReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(28)]
        HRESULT remove_FastForwardReceived(EventRegistrationToken token);

        [VtblIndex(29)]
        HRESULT add_RewindReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRewindReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(30)]
        HRESULT remove_RewindReceived(EventRegistrationToken token);

        [VtblIndex(31)]
        HRESULT add_ShuffleReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerShuffleReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(32)]
        HRESULT remove_ShuffleReceived(EventRegistrationToken token);

        [VtblIndex(33)]
        HRESULT add_AutoRepeatModeReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(34)]
        HRESULT remove_AutoRepeatModeReceived(EventRegistrationToken token);

        [VtblIndex(35)]
        HRESULT add_PositionReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPositionReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(36)]
        HRESULT remove_PositionReceived(EventRegistrationToken token);

        [VtblIndex(37)]
        HRESULT add_RateReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRateReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(38)]
        HRESULT remove_RateReceived(EventRegistrationToken token);
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
        public delegate* unmanaged<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlayer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlayer*, int> get_MediaPlayer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackCommandManagerCommandBehavior*,
            int> get_PlayBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackCommandManagerCommandBehavior*,
            int> get_PauseBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackCommandManagerCommandBehavior*,
            int> get_NextBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackCommandManagerCommandBehavior*,
            int> get_PreviousBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackCommandManagerCommandBehavior*,
            int> get_FastForwardBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackCommandManagerCommandBehavior*,
            int> get_RewindBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackCommandManagerCommandBehavior*,
            int> get_ShuffleBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackCommandManagerCommandBehavior*,
            int> get_AutoRepeatModeBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackCommandManagerCommandBehavior*,
            int> get_PositionBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackCommandManagerCommandBehavior*,
            int> get_RateBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPlayReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PlayReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PlayReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPauseReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PauseReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PauseReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerNextReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_NextReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_NextReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPreviousReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PreviousReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PreviousReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerFastForwardReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_FastForwardReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_FastForwardReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRewindReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_RewindReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_RewindReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerShuffleReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ShuffleReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ShuffleReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_AutoRepeatModeReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_AutoRepeatModeReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPositionReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PositionReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PositionReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRateReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_RateReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_RateReceived;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlaybackCommandManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlaybackCommandManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlaybackCommandManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackCommandManager(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlaybackCommandManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackCommandManager"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackCommandManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlaybackCommandManager value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlaybackCommandManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackCommandManager(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlaybackCommandManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackCommandManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackCommandManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlaybackCommandManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
