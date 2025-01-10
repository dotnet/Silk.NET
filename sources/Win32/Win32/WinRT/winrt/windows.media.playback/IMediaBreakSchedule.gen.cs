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

[Guid("A19A5813-98B6-41D8-83DA-F971D22B7BBA")]
[NativeTypeName("struct IMediaBreakSchedule : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaBreakSchedule : IMediaBreakSchedule.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaBreakSchedule));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaBreakSchedule, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ScheduleChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakSchedule_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaBreakSchedule,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ScheduleChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaBreakSchedule, EventRegistrationToken, int>)((*lpVtbl)[7])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InsertMidrollBreak(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak mediaBreak
    )
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, IMediaBreak, int>)((*lpVtbl)[8]))(
            this,
            mediaBreak
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveMidrollBreak(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak mediaBreak
    )
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, IMediaBreak, int>)((*lpVtbl)[9]))(
            this,
            mediaBreak
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MidrollBreaks(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaBreak_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaBreakSchedule, IVectorView<IntPtr>**, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PrerollBreak(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak value
    )
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, IMediaBreak, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PrerollBreak(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak* value
    )
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, IMediaBreak*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PostrollBreak(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak value
    )
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, IMediaBreak, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PostrollBreak(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak* value
    )
    {
        return ((delegate* unmanaged<IMediaBreakSchedule, IMediaBreak*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PlaybackItem(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
            IMediaPlaybackItem* value
    )
    {
        return (
            (delegate* unmanaged<IMediaBreakSchedule, IMediaPlaybackItem*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ScheduleChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakSchedule_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_ScheduleChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT InsertMidrollBreak(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak mediaBreak
        );

        [VtblIndex(9)]
        HRESULT RemoveMidrollBreak(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak mediaBreak
        );

        [VtblIndex(10)]
        HRESULT get_MidrollBreaks(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaBreak_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(11)]
        HRESULT put_PrerollBreak(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak value
        );

        [VtblIndex(12)]
        HRESULT get_PrerollBreak(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak* value
        );

        [VtblIndex(13)]
        HRESULT put_PostrollBreak(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak value
        );

        [VtblIndex(14)]
        HRESULT get_PostrollBreak(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak* value
        );

        [VtblIndex(15)]
        HRESULT get_PlaybackItem(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
                IMediaPlaybackItem* value
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakSchedule_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ScheduleChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ScheduleChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaBreak *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaBreak, int> InsertMidrollBreak;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaBreak *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaBreak, int> RemoveMidrollBreak;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaBreak_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_MidrollBreaks;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaBreak *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaBreak, int> put_PrerollBreak;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaBreak **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaBreak*, int> get_PrerollBreak;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaBreak *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaBreak, int> put_PostrollBreak;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaBreak **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaBreak*, int> get_PostrollBreak;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlaybackItem*, int> get_PlaybackItem;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaBreakSchedule"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaBreakSchedule(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaBreakSchedule"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaBreakSchedule(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaBreakSchedule(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaBreakSchedule"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaBreakSchedule"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaBreakSchedule value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaBreakSchedule"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaBreakSchedule(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaBreakSchedule(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaBreakSchedule"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaBreakSchedule"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaBreakSchedule value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
