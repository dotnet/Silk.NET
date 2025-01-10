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

[Guid("F8BA7C79-1FC8-4097-AD70-C0FA18CC0050")]
[NativeTypeName("struct IMediaPlaybackSession2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackSession2 : IMediaPlaybackSession2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackSession2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPlaybackSession2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlaybackSession2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_BufferedRangesChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession2,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_BufferedRangesChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession2, EventRegistrationToken, int>)((*lpVtbl)[7])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_PlayedRangesChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession2,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_PlayedRangesChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession2, EventRegistrationToken, int>)((*lpVtbl)[9])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_SeekableRangesChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession2,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_SeekableRangesChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession2, EventRegistrationToken, int>)(
                (*lpVtbl)[11]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_SupportedPlaybackRatesChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession2,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_SupportedPlaybackRatesChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession2, EventRegistrationToken, int>)(
                (*lpVtbl)[13]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SphericalVideoProjection(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSphericalVideoProjection **")]
            IMediaPlaybackSphericalVideoProjection* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession2,
                IMediaPlaybackSphericalVideoProjection*,
                int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsMirroring([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession2, byte*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IsMirroring([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession2, byte, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetBufferedRanges(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **"
        )]
            IVectorView<MediaTimeRange>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession2, IVectorView<MediaTimeRange>**, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetPlayedRanges(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **"
        )]
            IVectorView<MediaTimeRange>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession2, IVectorView<MediaTimeRange>**, int>)(
                (*lpVtbl)[18]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetSeekableRanges(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **"
        )]
            IVectorView<MediaTimeRange>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession2, IVectorView<MediaTimeRange>**, int>)(
                (*lpVtbl)[19]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT IsSupportedPlaybackRateRange(
        double rate1,
        double rate2,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlaybackSession2, double, double, byte*, int>)((*lpVtbl)[20])
        )(this, rate1, rate2, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_BufferedRangesChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_BufferedRangesChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_PlayedRangesChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_PlayedRangesChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_SeekableRangesChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_SeekableRangesChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_SupportedPlaybackRatesChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(13)]
        HRESULT remove_SupportedPlaybackRatesChanged(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT get_SphericalVideoProjection(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackSphericalVideoProjection **"
            )]
                IMediaPlaybackSphericalVideoProjection* value
        );

        [VtblIndex(15)]
        HRESULT get_IsMirroring([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_IsMirroring([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        HRESULT GetBufferedRanges(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **"
            )]
                IVectorView<MediaTimeRange>** value
        );

        [VtblIndex(18)]
        HRESULT GetPlayedRanges(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **"
            )]
                IVectorView<MediaTimeRange>** value
        );

        [VtblIndex(19)]
        HRESULT GetSeekableRanges(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **"
            )]
                IVectorView<MediaTimeRange>** value
        );

        [VtblIndex(20)]
        HRESULT IsSupportedPlaybackRateRange(
            double rate1,
            double rate2,
            [NativeTypeName("boolean *")] byte* value
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
            int> add_BufferedRangesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_BufferedRangesChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PlayedRangesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PlayedRangesChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SeekableRangesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_SeekableRangesChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SupportedPlaybackRatesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_SupportedPlaybackRatesChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackSphericalVideoProjection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackSphericalVideoProjection*,
            int> get_SphericalVideoProjection;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsMirroring;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsMirroring;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<MediaTimeRange>**, int> GetBufferedRanges;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<MediaTimeRange>**, int> GetPlayedRanges;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<MediaTimeRange>**, int> GetSeekableRanges;

        [NativeTypeName("HRESULT (DOUBLE, DOUBLE, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, byte*, int> IsSupportedPlaybackRateRange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlaybackSession2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlaybackSession2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlaybackSession2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackSession2(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlaybackSession2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackSession2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackSession2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlaybackSession2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlaybackSession2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackSession2(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlaybackSession2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackSession2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackSession2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlaybackSession2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
