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

[Guid("7F77EE9C-DC42-4E26-A98D-7850DF8EC925")]
[NativeTypeName("struct IMediaPlaybackList : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackList : IMediaPlaybackList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackList));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPlaybackList, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPlaybackList, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlaybackList, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackList, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlaybackList, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaPlaybackList, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ItemFailed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemFailedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackList,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ItemFailed(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackList, EventRegistrationToken, int>)((*lpVtbl)[7])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_CurrentItemChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CCurrentMediaPlaybackItemChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackList,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_CurrentItemChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackList, EventRegistrationToken, int>)((*lpVtbl)[9])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ItemOpened(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemOpenedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackList,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ItemOpened(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackList, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Items(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t **"
        )]
            IObservableVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackList, IObservableVector<IntPtr>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AutoRepeatEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackList, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_AutoRepeatEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaPlaybackList, byte, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ShuffleEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackList, byte*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_ShuffleEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaPlaybackList, byte, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CurrentItem(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
            IMediaPlaybackItem* value
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackList, IMediaPlaybackItem*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CurrentItemIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackList, uint*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT MoveNext(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
            IMediaPlaybackItem* item
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackList, IMediaPlaybackItem*, int>)((*lpVtbl)[19]))(
            this,
            item
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT MovePrevious(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
            IMediaPlaybackItem* item
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackList, IMediaPlaybackItem*, int>)((*lpVtbl)[20]))(
            this,
            item
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT MoveTo(
        [NativeTypeName("UINT32")] uint itemIndex,
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
            IMediaPlaybackItem* item
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackList, uint, IMediaPlaybackItem*, int>)((*lpVtbl)[21])
        )(this, itemIndex, item);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ItemFailed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemFailedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_ItemFailed(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_CurrentItemChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CCurrentMediaPlaybackItemChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_CurrentItemChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_ItemOpened(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemOpenedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_ItemOpened(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT get_Items(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t **"
            )]
                IObservableVector<IntPtr>** value
        );

        [VtblIndex(13)]
        HRESULT get_AutoRepeatEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_AutoRepeatEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_ShuffleEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_ShuffleEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        HRESULT get_CurrentItem(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
                IMediaPlaybackItem* value
        );

        [VtblIndex(18)]
        HRESULT get_CurrentItemIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(19)]
        HRESULT MoveNext(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
                IMediaPlaybackItem* item
        );

        [VtblIndex(20)]
        HRESULT MovePrevious(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
                IMediaPlaybackItem* item
        );

        [VtblIndex(21)]
        HRESULT MoveTo(
            [NativeTypeName("UINT32")] uint itemIndex,
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
                IMediaPlaybackItem* item
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ItemFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ItemFailed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CCurrentMediaPlaybackItemChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CurrentItemChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_CurrentItemChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemOpenedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ItemOpened;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ItemOpened;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IObservableVector<IntPtr>**, int> get_Items;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AutoRepeatEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AutoRepeatEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ShuffleEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_ShuffleEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlaybackItem*, int> get_CurrentItem;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CurrentItemIndex;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlaybackItem*, int> MoveNext;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlaybackItem*, int> MovePrevious;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IMediaPlaybackItem*, int> MoveTo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlaybackList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlaybackList(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlaybackList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackList(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlaybackList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackList"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackList"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlaybackList value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlaybackList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackList(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlaybackList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackList"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackList"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlaybackList value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
