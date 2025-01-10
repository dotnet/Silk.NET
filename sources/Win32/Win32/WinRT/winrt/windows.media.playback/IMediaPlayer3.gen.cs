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

[Guid("EE0660DA-031B-4FEB-BD9B-92E0A0A8D299")]
[NativeTypeName("struct IMediaPlayer3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayer3 : IMediaPlayer3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayer3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPlayer3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPlayer3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlayer3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaPlayer3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlayer3, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaPlayer3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_IsMutedChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer3,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_IsMutedChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer3, EventRegistrationToken, int>)((*lpVtbl)[7]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_SourceChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer3,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_SourceChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer3, EventRegistrationToken, int>)((*lpVtbl)[9]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AudioBalance(double* value)
    {
        return ((delegate* unmanaged<IMediaPlayer3, double*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_AudioBalance(double value)
    {
        return ((delegate* unmanaged<IMediaPlayer3, double, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RealTimePlayback([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlayer3, byte*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RealTimePlayback([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaPlayer3, byte, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_StereoscopicVideoRenderMode(
        [NativeTypeName("ABI::Windows::Media::Playback::StereoscopicVideoRenderMode *")]
            StereoscopicVideoRenderMode* value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlayer3, StereoscopicVideoRenderMode*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_StereoscopicVideoRenderMode(
        [NativeTypeName("ABI::Windows::Media::Playback::StereoscopicVideoRenderMode")]
            StereoscopicVideoRenderMode value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlayer3, StereoscopicVideoRenderMode, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_BreakManager(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreakManager **")]
            IMediaBreakManager* value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer3, IMediaBreakManager*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CommandManager(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManager **")]
            IMediaPlaybackCommandManager* value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlayer3, IMediaPlaybackCommandManager*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_AudioDevice(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")]
            IDeviceInformation* value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer3, IDeviceInformation*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_AudioDevice(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
            IDeviceInformation value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer3, IDeviceInformation, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TimelineController(
        [NativeTypeName("ABI::Windows::Media::IMediaTimelineController **")]
            IMediaTimelineController* value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlayer3, IMediaTimelineController*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_TimelineController(
        [NativeTypeName("ABI::Windows::Media::IMediaTimelineController *")]
            IMediaTimelineController value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer3, IMediaTimelineController, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_TimelineControllerPositionOffset(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer3, TimeSpan*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_TimelineControllerPositionOffset(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer3, TimeSpan, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_PlaybackSession(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSession **")]
            IMediaPlaybackSession* value
    )
    {
        return ((delegate* unmanaged<IMediaPlayer3, IMediaPlaybackSession*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT StepForwardOneFrame()
    {
        return ((delegate* unmanaged<IMediaPlayer3, int>)((*lpVtbl)[25]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT StepBackwardOneFrame()
    {
        return ((delegate* unmanaged<IMediaPlayer3, int>)((*lpVtbl)[26]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetAsCastingSource(
        [NativeTypeName("ABI::Windows::Media::Casting::ICastingSource **")]
            ICastingSource* returnValue
    )
    {
        return ((delegate* unmanaged<IMediaPlayer3, ICastingSource*, int>)((*lpVtbl)[27]))(
            this,
            returnValue
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_IsMutedChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_IsMutedChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_SourceChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_SourceChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT get_AudioBalance(double* value);

        [VtblIndex(11)]
        HRESULT put_AudioBalance(double value);

        [VtblIndex(12)]
        HRESULT get_RealTimePlayback([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_RealTimePlayback([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_StereoscopicVideoRenderMode(
            [NativeTypeName("ABI::Windows::Media::Playback::StereoscopicVideoRenderMode *")]
                StereoscopicVideoRenderMode* value
        );

        [VtblIndex(15)]
        HRESULT put_StereoscopicVideoRenderMode(
            [NativeTypeName("ABI::Windows::Media::Playback::StereoscopicVideoRenderMode")]
                StereoscopicVideoRenderMode value
        );

        [VtblIndex(16)]
        HRESULT get_BreakManager(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreakManager **")]
                IMediaBreakManager* value
        );

        [VtblIndex(17)]
        HRESULT get_CommandManager(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManager **")]
                IMediaPlaybackCommandManager* value
        );

        [VtblIndex(18)]
        HRESULT get_AudioDevice(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")]
                IDeviceInformation* value
        );

        [VtblIndex(19)]
        HRESULT put_AudioDevice(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
                IDeviceInformation value
        );

        [VtblIndex(20)]
        HRESULT get_TimelineController(
            [NativeTypeName("ABI::Windows::Media::IMediaTimelineController **")]
                IMediaTimelineController* value
        );

        [VtblIndex(21)]
        HRESULT put_TimelineController(
            [NativeTypeName("ABI::Windows::Media::IMediaTimelineController *")]
                IMediaTimelineController value
        );

        [VtblIndex(22)]
        HRESULT get_TimelineControllerPositionOffset(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(23)]
        HRESULT put_TimelineControllerPositionOffset(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(24)]
        HRESULT get_PlaybackSession(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSession **")]
                IMediaPlaybackSession* value
        );

        [VtblIndex(25)]
        HRESULT StepForwardOneFrame();

        [VtblIndex(26)]
        HRESULT StepBackwardOneFrame();

        [VtblIndex(27)]
        HRESULT GetAsCastingSource(
            [NativeTypeName("ABI::Windows::Media::Casting::ICastingSource **")]
                ICastingSource* returnValue
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_IsMutedChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_IsMutedChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SourceChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SourceChanged;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_AudioBalance;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_AudioBalance;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_RealTimePlayback;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_RealTimePlayback;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::StereoscopicVideoRenderMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            StereoscopicVideoRenderMode*,
            int> get_StereoscopicVideoRenderMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::StereoscopicVideoRenderMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            StereoscopicVideoRenderMode,
            int> put_StereoscopicVideoRenderMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaBreakManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaBreakManager*, int> get_BreakManager;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlaybackCommandManager*, int> get_CommandManager;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeviceInformation*, int> get_AudioDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeviceInformation, int> put_AudioDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::IMediaTimelineController **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaTimelineController*, int> get_TimelineController;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::IMediaTimelineController *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaTimelineController, int> put_TimelineController;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_TimelineControllerPositionOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_TimelineControllerPositionOffset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackSession **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlaybackSession*, int> get_PlaybackSession;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StepForwardOneFrame;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StepBackwardOneFrame;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Casting::ICastingSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICastingSource*, int> GetAsCastingSource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlayer3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlayer3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlayer3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlayer3(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlayer3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlayer3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlayer3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlayer3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlayer3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlayer3(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlayer3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlayer3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlayer3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlayer3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
