// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("90EB3E6B-ECBF-45CC-B1DA-C6FE3EA70D57")]
[NativeTypeName("struct IMFPMediaItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFPMediaItem : IMFPMediaItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPMediaItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPMediaItem, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFPMediaItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPMediaItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMediaPlayer(IMFPMediaPlayer* ppMediaPlayer)
    {
        return ((delegate* unmanaged<IMFPMediaItem, IMFPMediaPlayer*, int>)((*lpVtbl)[3]))(
            this,
            ppMediaPlayer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppwszURL)
    {
        return ((delegate* unmanaged<IMFPMediaItem, ushort**, int>)((*lpVtbl)[4]))(this, ppwszURL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetObject(IUnknown* ppIUnknown)
    {
        return ((delegate* unmanaged<IMFPMediaItem, IUnknown*, int>)((*lpVtbl)[5]))(
            this,
            ppIUnknown
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetUserData([NativeTypeName("DWORD_PTR *")] nuint* pdwUserData)
    {
        return ((delegate* unmanaged<IMFPMediaItem, nuint*, int>)((*lpVtbl)[6]))(this, pdwUserData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetUserData([NativeTypeName("DWORD_PTR")] nuint dwUserData)
    {
        return ((delegate* unmanaged<IMFPMediaItem, nuint, int>)((*lpVtbl)[7]))(this, dwUserData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStartStopPosition(
        Guid* pguidStartPositionType,
        PROPVARIANT* pvStartValue,
        Guid* pguidStopPositionType,
        PROPVARIANT* pvStopValue
    )
    {
        return (
            (delegate* unmanaged<IMFPMediaItem, Guid*, PROPVARIANT*, Guid*, PROPVARIANT*, int>)(
                (*lpVtbl)[8]
            )
        )(this, pguidStartPositionType, pvStartValue, pguidStopPositionType, pvStopValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetStartStopPosition(
        [NativeTypeName("const GUID *")] Guid* pguidStartPositionType,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvStartValue,
        [NativeTypeName("const GUID *")] Guid* pguidStopPositionType,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvStopValue
    )
    {
        return (
            (delegate* unmanaged<IMFPMediaItem, Guid*, PROPVARIANT*, Guid*, PROPVARIANT*, int>)(
                (*lpVtbl)[9]
            )
        )(this, pguidStartPositionType, pvStartValue, pguidStopPositionType, pvStopValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT HasVideo(BOOL* pfHasVideo, BOOL* pfSelected)
    {
        return ((delegate* unmanaged<IMFPMediaItem, BOOL*, BOOL*, int>)((*lpVtbl)[10]))(
            this,
            pfHasVideo,
            pfSelected
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT HasAudio(BOOL* pfHasAudio, BOOL* pfSelected)
    {
        return ((delegate* unmanaged<IMFPMediaItem, BOOL*, BOOL*, int>)((*lpVtbl)[11]))(
            this,
            pfHasAudio,
            pfSelected
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsProtected(BOOL* pfProtected)
    {
        return ((delegate* unmanaged<IMFPMediaItem, BOOL*, int>)((*lpVtbl)[12]))(this, pfProtected);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDuration(
        [NativeTypeName("const GUID &")] Guid* guidPositionType,
        PROPVARIANT* pvDurationValue
    )
    {
        return ((delegate* unmanaged<IMFPMediaItem, Guid*, PROPVARIANT*, int>)((*lpVtbl)[13]))(
            this,
            guidPositionType,
            pvDurationValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwStreamCount)
    {
        return ((delegate* unmanaged<IMFPMediaItem, uint*, int>)((*lpVtbl)[14]))(
            this,
            pdwStreamCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfEnabled)
    {
        return ((delegate* unmanaged<IMFPMediaItem, uint, BOOL*, int>)((*lpVtbl)[15]))(
            this,
            dwStreamIndex,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fEnabled)
    {
        return ((delegate* unmanaged<IMFPMediaItem, uint, BOOL, int>)((*lpVtbl)[16]))(
            this,
            dwStreamIndex,
            fEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetStreamAttribute(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("const GUID &")] Guid* guidMFAttribute,
        PROPVARIANT* pvValue
    )
    {
        return (
            (delegate* unmanaged<IMFPMediaItem, uint, Guid*, PROPVARIANT*, int>)((*lpVtbl)[17])
        )(this, dwStreamIndex, guidMFAttribute, pvValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetPresentationAttribute(
        [NativeTypeName("const GUID &")] Guid* guidMFAttribute,
        PROPVARIANT* pvValue
    )
    {
        return ((delegate* unmanaged<IMFPMediaItem, Guid*, PROPVARIANT*, int>)((*lpVtbl)[18]))(
            this,
            guidMFAttribute,
            pvValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetCharacteristics(
        [NativeTypeName("MFP_MEDIAITEM_CHARACTERISTICS *")] uint* pCharacteristics
    )
    {
        return ((delegate* unmanaged<IMFPMediaItem, uint*, int>)((*lpVtbl)[19]))(
            this,
            pCharacteristics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetStreamSink([NativeTypeName("DWORD")] uint dwStreamIndex, IUnknown pMediaSink)
    {
        return ((delegate* unmanaged<IMFPMediaItem, uint, IUnknown, int>)((*lpVtbl)[20]))(
            this,
            dwStreamIndex,
            pMediaSink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetMetadata(IPropertyStore* ppMetadataStore)
    {
        return ((delegate* unmanaged<IMFPMediaItem, IPropertyStore*, int>)((*lpVtbl)[21]))(
            this,
            ppMetadataStore
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMediaPlayer(IMFPMediaPlayer* ppMediaPlayer);

        [VtblIndex(4)]
        HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppwszURL);

        [VtblIndex(5)]
        HRESULT GetObject(IUnknown* ppIUnknown);

        [VtblIndex(6)]
        HRESULT GetUserData([NativeTypeName("DWORD_PTR *")] nuint* pdwUserData);

        [VtblIndex(7)]
        HRESULT SetUserData([NativeTypeName("DWORD_PTR")] nuint dwUserData);

        [VtblIndex(8)]
        HRESULT GetStartStopPosition(
            Guid* pguidStartPositionType,
            PROPVARIANT* pvStartValue,
            Guid* pguidStopPositionType,
            PROPVARIANT* pvStopValue
        );

        [VtblIndex(9)]
        HRESULT SetStartStopPosition(
            [NativeTypeName("const GUID *")] Guid* pguidStartPositionType,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvStartValue,
            [NativeTypeName("const GUID *")] Guid* pguidStopPositionType,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvStopValue
        );

        [VtblIndex(10)]
        HRESULT HasVideo(BOOL* pfHasVideo, BOOL* pfSelected);

        [VtblIndex(11)]
        HRESULT HasAudio(BOOL* pfHasAudio, BOOL* pfSelected);

        [VtblIndex(12)]
        HRESULT IsProtected(BOOL* pfProtected);

        [VtblIndex(13)]
        HRESULT GetDuration(
            [NativeTypeName("const GUID &")] Guid* guidPositionType,
            PROPVARIANT* pvDurationValue
        );

        [VtblIndex(14)]
        HRESULT GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwStreamCount);

        [VtblIndex(15)]
        HRESULT GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfEnabled);

        [VtblIndex(16)]
        HRESULT SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fEnabled);

        [VtblIndex(17)]
        HRESULT GetStreamAttribute(
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            [NativeTypeName("const GUID &")] Guid* guidMFAttribute,
            PROPVARIANT* pvValue
        );

        [VtblIndex(18)]
        HRESULT GetPresentationAttribute(
            [NativeTypeName("const GUID &")] Guid* guidMFAttribute,
            PROPVARIANT* pvValue
        );

        [VtblIndex(19)]
        HRESULT GetCharacteristics(
            [NativeTypeName("MFP_MEDIAITEM_CHARACTERISTICS *")] uint* pCharacteristics
        );

        [VtblIndex(20)]
        HRESULT SetStreamSink([NativeTypeName("DWORD")] uint dwStreamIndex, IUnknown pMediaSink);

        [VtblIndex(21)]
        HRESULT GetMetadata(IPropertyStore* ppMetadataStore);
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

        [NativeTypeName("HRESULT (IMFPMediaPlayer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPMediaPlayer*, int> GetMediaPlayer;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetURL;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> GetObject;

        [NativeTypeName("HRESULT (DWORD_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint*, int> GetUserData;

        [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, int> SetUserData;

        [NativeTypeName(
            "HRESULT (GUID *, PROPVARIANT *, GUID *, PROPVARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            PROPVARIANT*,
            Guid*,
            PROPVARIANT*,
            int> GetStartStopPosition;

        [NativeTypeName(
            "HRESULT (const GUID *, const PROPVARIANT *, const GUID *, const PROPVARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            PROPVARIANT*,
            Guid*,
            PROPVARIANT*,
            int> SetStartStopPosition;

        [NativeTypeName("HRESULT (BOOL *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, BOOL*, int> HasVideo;

        [NativeTypeName("HRESULT (BOOL *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, BOOL*, int> HasAudio;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsProtected;

        [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> GetDuration;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNumberOfStreams;

        [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> GetStreamSelection;

        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, int> SetStreamSelection;

        [NativeTypeName("HRESULT (DWORD, const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, PROPVARIANT*, int> GetStreamAttribute;

        [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> GetPresentationAttribute;

        [NativeTypeName("HRESULT (MFP_MEDIAITEM_CHARACTERISTICS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCharacteristics;

        [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown, int> SetStreamSink;

        [NativeTypeName("HRESULT (IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore*, int> GetMetadata;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFPMediaItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFPMediaItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFPMediaItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFPMediaItem(Silk.NET.Windows.IUnknown value)
    {
        return new IMFPMediaItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFPMediaItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFPMediaItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFPMediaItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
