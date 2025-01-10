// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("99FA3FF4-1742-42A6-902E-087D41F965EC")]
[NativeTypeName("struct ISystemMediaTransportControls : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemMediaTransportControls
    : ISystemMediaTransportControls.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemMediaTransportControls));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISystemMediaTransportControls, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISystemMediaTransportControls, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISystemMediaTransportControls, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PlaybackStatus(
        [NativeTypeName("ABI::Windows::Media::MediaPlaybackStatus *")] MediaPlaybackStatus* value
    )
    {
        return (
            (delegate* unmanaged<ISystemMediaTransportControls, MediaPlaybackStatus*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PlaybackStatus(
        [NativeTypeName("ABI::Windows::Media::MediaPlaybackStatus")] MediaPlaybackStatus value
    )
    {
        return (
            (delegate* unmanaged<ISystemMediaTransportControls, MediaPlaybackStatus, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayUpdater(
        [NativeTypeName("ABI::Windows::Media::ISystemMediaTransportControlsDisplayUpdater **")]
            ISystemMediaTransportControlsDisplayUpdater* value
    )
    {
        return (
            (delegate* unmanaged<
                ISystemMediaTransportControls,
                ISystemMediaTransportControlsDisplayUpdater*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SoundLevel(
        [NativeTypeName("ABI::Windows::Media::SoundLevel *")] SoundLevel* value
    )
    {
        return (
            (delegate* unmanaged<ISystemMediaTransportControls, SoundLevel*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsPlayEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IsPlayEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsStopEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_IsStopEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsPauseEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_IsPauseEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_IsRecordEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_IsRecordEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_IsFastForwardEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_IsFastForwardEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_IsRewindEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_IsRewindEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_IsPreviousEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_IsPreviousEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_IsNextEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_IsNextEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_IsChannelUpEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_IsChannelUpEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_IsChannelDownEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte*, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_IsChannelDownEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISystemMediaTransportControls, byte, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT add_ButtonPressed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CSystemMediaTransportControlsButtonPressedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISystemMediaTransportControls,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[32])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT remove_ButtonPressed(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ISystemMediaTransportControls, EventRegistrationToken, int>)(
                (*lpVtbl)[33]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT add_PropertyChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CSystemMediaTransportControlsPropertyChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISystemMediaTransportControls,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[34])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT remove_PropertyChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ISystemMediaTransportControls, EventRegistrationToken, int>)(
                (*lpVtbl)[35]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PlaybackStatus(
            [NativeTypeName("ABI::Windows::Media::MediaPlaybackStatus *")]
                MediaPlaybackStatus* value
        );

        [VtblIndex(7)]
        HRESULT put_PlaybackStatus(
            [NativeTypeName("ABI::Windows::Media::MediaPlaybackStatus")] MediaPlaybackStatus value
        );

        [VtblIndex(8)]
        HRESULT get_DisplayUpdater(
            [NativeTypeName("ABI::Windows::Media::ISystemMediaTransportControlsDisplayUpdater **")]
                ISystemMediaTransportControlsDisplayUpdater* value
        );

        [VtblIndex(9)]
        HRESULT get_SoundLevel(
            [NativeTypeName("ABI::Windows::Media::SoundLevel *")] SoundLevel* value
        );

        [VtblIndex(10)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_IsPlayEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_IsPlayEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_IsStopEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_IsStopEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_IsPauseEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_IsPauseEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT get_IsRecordEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT put_IsRecordEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(20)]
        HRESULT get_IsFastForwardEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT put_IsFastForwardEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(22)]
        HRESULT get_IsRewindEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(23)]
        HRESULT put_IsRewindEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(24)]
        HRESULT get_IsPreviousEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(25)]
        HRESULT put_IsPreviousEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(26)]
        HRESULT get_IsNextEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(27)]
        HRESULT put_IsNextEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(28)]
        HRESULT get_IsChannelUpEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(29)]
        HRESULT put_IsChannelUpEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(30)]
        HRESULT get_IsChannelDownEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(31)]
        HRESULT put_IsChannelDownEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(32)]
        HRESULT add_ButtonPressed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CSystemMediaTransportControlsButtonPressedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(33)]
        HRESULT remove_ButtonPressed(EventRegistrationToken token);

        [VtblIndex(34)]
        HRESULT add_PropertyChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CSystemMediaTransportControlsPropertyChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(35)]
        HRESULT remove_PropertyChanged(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Media::MediaPlaybackStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaPlaybackStatus*, int> get_PlaybackStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaPlaybackStatus) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaPlaybackStatus, int> put_PlaybackStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::ISystemMediaTransportControlsDisplayUpdater **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISystemMediaTransportControlsDisplayUpdater*,
            int> get_DisplayUpdater;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SoundLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SoundLevel*, int> get_SoundLevel;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsPlayEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsPlayEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsStopEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsStopEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsPauseEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsPauseEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsRecordEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsRecordEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsFastForwardEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsFastForwardEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsRewindEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsRewindEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsPreviousEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsPreviousEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsNextEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsNextEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsChannelUpEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsChannelUpEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsChannelDownEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsChannelDownEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CSystemMediaTransportControlsButtonPressedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ButtonPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ButtonPressed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CSystemMediaTransportControlsPropertyChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PropertyChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PropertyChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISystemMediaTransportControls"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISystemMediaTransportControls(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISystemMediaTransportControls"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISystemMediaTransportControls(Silk.NET.WinRT.IInspectable value)
    {
        return new ISystemMediaTransportControls(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISystemMediaTransportControls"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISystemMediaTransportControls"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISystemMediaTransportControls value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISystemMediaTransportControls"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISystemMediaTransportControls(Silk.NET.Windows.IUnknown value)
    {
        return new ISystemMediaTransportControls(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISystemMediaTransportControls"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISystemMediaTransportControls"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISystemMediaTransportControls value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
