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

[Guid("856DDBC1-55F7-471F-A0F2-68AC4C904592")]
[NativeTypeName("struct IBackgroundMediaPlayerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
public unsafe partial struct IBackgroundMediaPlayerStatics
    : IBackgroundMediaPlayerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundMediaPlayerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundMediaPlayerStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundMediaPlayerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundMediaPlayerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBackgroundMediaPlayerStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundMediaPlayerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBackgroundMediaPlayerStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT get_Current(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer* player
    )
    {
        return (
            (delegate* unmanaged<IBackgroundMediaPlayerStatics, IMediaPlayer*, int>)((*lpVtbl)[6])
        )(this, player);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT add_MessageReceivedFromBackground(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *"
        )]
            IEventHandler<IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundMediaPlayerStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[7])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT remove_MessageReceivedFromBackground(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBackgroundMediaPlayerStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[8]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT add_MessageReceivedFromForeground(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *"
        )]
            IEventHandler<IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundMediaPlayerStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT remove_MessageReceivedFromForeground(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBackgroundMediaPlayerStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[10]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT SendMessageToBackground(
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundMediaPlayerStatics, IPropertySet, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT SendMessageToForeground(
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundMediaPlayerStatics, IPropertySet, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT IsMediaPlaying([NativeTypeName("boolean *")] byte* isMediaPlaying)
    {
        return ((delegate* unmanaged<IBackgroundMediaPlayerStatics, byte*, int>)((*lpVtbl)[13]))(
            this,
            isMediaPlaying
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IBackgroundMediaPlayerStatics, int>)((*lpVtbl)[14]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT get_Current(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer* player
        );

        [VtblIndex(7)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT add_MessageReceivedFromBackground(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *"
            )]
                IEventHandler<IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(8)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT remove_MessageReceivedFromBackground(EventRegistrationToken token);

        [VtblIndex(9)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT add_MessageReceivedFromForeground(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *"
            )]
                IEventHandler<IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT remove_MessageReceivedFromForeground(EventRegistrationToken token);

        [VtblIndex(11)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT SendMessageToBackground(
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet value
        );

        [VtblIndex(12)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT SendMessageToForeground(
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet value
        );

        [VtblIndex(13)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT IsMediaPlaying([NativeTypeName("boolean *")] byte* isMediaPlaying);

        [VtblIndex(14)]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        HRESULT Shutdown();
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
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlayer **) __attribute__((stdcall))"
        )]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, IMediaPlayer*, int> get_Current;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_MessageReceivedFromBackground;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_MessageReceivedFromBackground;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CMedia__CPlayback__CMediaPlayerDataReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_MessageReceivedFromForeground;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_MessageReceivedFromForeground;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))"
        )]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, IPropertySet, int> SendMessageToBackground;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))"
        )]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, IPropertySet, int> SendMessageToForeground;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, byte*, int> IsMediaPlaying;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, int> Shutdown;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundMediaPlayerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundMediaPlayerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundMediaPlayerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundMediaPlayerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IBackgroundMediaPlayerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundMediaPlayerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundMediaPlayerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBackgroundMediaPlayerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundMediaPlayerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundMediaPlayerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundMediaPlayerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundMediaPlayerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundMediaPlayerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundMediaPlayerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
