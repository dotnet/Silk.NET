// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F23B6E77-3EF7-40DE-B943-068B1321701D")]
[NativeTypeName("struct IAudioTrack : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioTrack : IAudioTrack.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioTrack));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioTrack, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioTrack, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioTrack, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioTrack, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioTrack, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioTrack, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_OpenFailed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CAudioTrack_Windows__CMedia__CCore__CAudioTrackOpenFailedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAudioTrack,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_OpenFailed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IAudioTrack, EventRegistrationToken, int>)((*lpVtbl)[7]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetEncodingProperties(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
            IAudioEncodingProperties* value
    )
    {
        return ((delegate* unmanaged<IAudioTrack, IAudioEncodingProperties*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PlaybackItem(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
            IMediaPlaybackItem* value
    )
    {
        return ((delegate* unmanaged<IAudioTrack, IMediaPlaybackItem*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IAudioTrack, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SupportInfo(
        [NativeTypeName("ABI::Windows::Media::Core::IAudioTrackSupportInfo **")]
            IAudioTrackSupportInfo* value
    )
    {
        return ((delegate* unmanaged<IAudioTrack, IAudioTrackSupportInfo*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_OpenFailed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CAudioTrack_Windows__CMedia__CCore__CAudioTrackOpenFailedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_OpenFailed(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT GetEncodingProperties(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
                IAudioEncodingProperties* value
        );

        [VtblIndex(9)]
        HRESULT get_PlaybackItem(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
                IMediaPlaybackItem* value
        );

        [VtblIndex(10)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_SupportInfo(
            [NativeTypeName("ABI::Windows::Media::Core::IAudioTrackSupportInfo **")]
                IAudioTrackSupportInfo* value
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CAudioTrack_Windows__CMedia__CCore__CAudioTrackOpenFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_OpenFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_OpenFailed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioEncodingProperties*, int> GetEncodingProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlaybackItem*, int> get_PlaybackItem;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IAudioTrackSupportInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioTrackSupportInfo*, int> get_SupportInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioTrack"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioTrack(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioTrack"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioTrack(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioTrack(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioTrack"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioTrack"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioTrack value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioTrack"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioTrack(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioTrack(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioTrack"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioTrack"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioTrack value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
