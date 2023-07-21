// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem"]/*' />
[Guid("90EB3E6B-ECBF-45CC-B1DA-C6FE3EA70D57")]
[NativeTypeName("struct IMFPMediaItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFPMediaItem : IMFPMediaItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPMediaItem));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFPMediaItem*, uint>)(lpVtbl[1]))((IMFPMediaItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPMediaItem*, uint>)(lpVtbl[2]))((IMFPMediaItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetMediaPlayer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMediaPlayer(IMFPMediaPlayer** ppMediaPlayer)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, IMFPMediaPlayer**, int>)(lpVtbl[3]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), ppMediaPlayer);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppwszURL)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, ushort**, int>)(lpVtbl[4]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), ppwszURL);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetObject(IUnknown** ppIUnknown)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, IUnknown**, int>)(lpVtbl[5]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), ppIUnknown);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetUserData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetUserData([NativeTypeName("DWORD_PTR *")] nuint* pdwUserData)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, nuint*, int>)(lpVtbl[6]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pdwUserData);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.SetUserData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetUserData([NativeTypeName("DWORD_PTR")] nuint dwUserData)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, nuint, int>)(lpVtbl[7]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), dwUserData);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetStartStopPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStartStopPosition(Guid* pguidStartPositionType, PROPVARIANT* pvStartValue, Guid* pguidStopPositionType, PROPVARIANT* pvStopValue)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, Guid*, PROPVARIANT*, Guid*, PROPVARIANT*, int>)(lpVtbl[8]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pguidStartPositionType, pvStartValue, pguidStopPositionType, pvStopValue);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.SetStartStopPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetStartStopPosition([NativeTypeName("const GUID *")] Guid* pguidStartPositionType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvStartValue, [NativeTypeName("const GUID *")] Guid* pguidStopPositionType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvStopValue)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, Guid*, PROPVARIANT*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pguidStartPositionType, pvStartValue, pguidStopPositionType, pvStopValue);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.HasVideo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT HasVideo(BOOL* pfHasVideo, BOOL* pfSelected)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, BOOL*, BOOL*, int>)(lpVtbl[10]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pfHasVideo, pfSelected);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.HasAudio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT HasAudio(BOOL* pfHasAudio, BOOL* pfSelected)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, BOOL*, BOOL*, int>)(lpVtbl[11]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pfHasAudio, pfSelected);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.IsProtected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsProtected(BOOL* pfProtected)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, BOOL*, int>)(lpVtbl[12]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pfProtected);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDuration([NativeTypeName("const GUID &")] Guid* guidPositionType, PROPVARIANT* pvDurationValue)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, Guid*, PROPVARIANT*, int>)(lpVtbl[13]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), guidPositionType, pvDurationValue);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetNumberOfStreams"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwStreamCount)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, uint*, int>)(lpVtbl[14]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pdwStreamCount);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetStreamSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfEnabled)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, uint, BOOL*, int>)(lpVtbl[15]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), dwStreamIndex, pfEnabled);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.SetStreamSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fEnabled)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, uint, BOOL, int>)(lpVtbl[16]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), dwStreamIndex, fEnabled);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetStreamAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetStreamAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidMFAttribute, PROPVARIANT* pvValue)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[17]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), dwStreamIndex, guidMFAttribute, pvValue);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetPresentationAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetPresentationAttribute([NativeTypeName("const GUID &")] Guid* guidMFAttribute, PROPVARIANT* pvValue)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), guidMFAttribute, pvValue);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetCharacteristics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetCharacteristics([NativeTypeName("MFP_MEDIAITEM_CHARACTERISTICS *")] uint* pCharacteristics)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, uint*, int>)(lpVtbl[19]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pCharacteristics);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.SetStreamSink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetStreamSink([NativeTypeName("DWORD")] uint dwStreamIndex, IUnknown* pMediaSink)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, uint, IUnknown*, int>)(lpVtbl[20]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), dwStreamIndex, pMediaSink);
    }

    /// <include file='IMFPMediaItem.xml' path='doc/member[@name="IMFPMediaItem.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetMetadata(IPropertyStore** ppMetadataStore)
    {
        return ((delegate* unmanaged<IMFPMediaItem*, IPropertyStore**, int>)(lpVtbl[21]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), ppMetadataStore);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMediaPlayer(IMFPMediaPlayer** ppMediaPlayer);

        [VtblIndex(4)]
        HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppwszURL);

        [VtblIndex(5)]
        HRESULT GetObject(IUnknown** ppIUnknown);

        [VtblIndex(6)]
        HRESULT GetUserData([NativeTypeName("DWORD_PTR *")] nuint* pdwUserData);

        [VtblIndex(7)]
        HRESULT SetUserData([NativeTypeName("DWORD_PTR")] nuint dwUserData);

        [VtblIndex(8)]
        HRESULT GetStartStopPosition(Guid* pguidStartPositionType, PROPVARIANT* pvStartValue, Guid* pguidStopPositionType, PROPVARIANT* pvStopValue);

        [VtblIndex(9)]
        HRESULT SetStartStopPosition([NativeTypeName("const GUID *")] Guid* pguidStartPositionType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvStartValue, [NativeTypeName("const GUID *")] Guid* pguidStopPositionType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvStopValue);

        [VtblIndex(10)]
        HRESULT HasVideo(BOOL* pfHasVideo, BOOL* pfSelected);

        [VtblIndex(11)]
        HRESULT HasAudio(BOOL* pfHasAudio, BOOL* pfSelected);

        [VtblIndex(12)]
        HRESULT IsProtected(BOOL* pfProtected);

        [VtblIndex(13)]
        HRESULT GetDuration([NativeTypeName("const GUID &")] Guid* guidPositionType, PROPVARIANT* pvDurationValue);

        [VtblIndex(14)]
        HRESULT GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwStreamCount);

        [VtblIndex(15)]
        HRESULT GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfEnabled);

        [VtblIndex(16)]
        HRESULT SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fEnabled);

        [VtblIndex(17)]
        HRESULT GetStreamAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidMFAttribute, PROPVARIANT* pvValue);

        [VtblIndex(18)]
        HRESULT GetPresentationAttribute([NativeTypeName("const GUID &")] Guid* guidMFAttribute, PROPVARIANT* pvValue);

        [VtblIndex(19)]
        HRESULT GetCharacteristics([NativeTypeName("MFP_MEDIAITEM_CHARACTERISTICS *")] uint* pCharacteristics);

        [VtblIndex(20)]
        HRESULT SetStreamSink([NativeTypeName("DWORD")] uint dwStreamIndex, IUnknown* pMediaSink);

        [VtblIndex(21)]
        HRESULT GetMetadata(IPropertyStore** ppMetadataStore);
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
        public delegate* unmanaged<TSelf*, IMFPMediaPlayer**, int> GetMediaPlayer;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetURL;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> GetObject;

        [NativeTypeName("HRESULT (DWORD_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint*, int> GetUserData;

        [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, int> SetUserData;

        [NativeTypeName("HRESULT (GUID *, PROPVARIANT *, GUID *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, Guid*, PROPVARIANT*, int> GetStartStopPosition;

        [NativeTypeName("HRESULT (const GUID *, const PROPVARIANT *, const GUID *, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, Guid*, PROPVARIANT*, int> SetStartStopPosition;

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
        public delegate* unmanaged<TSelf*, uint, IUnknown*, int> SetStreamSink;

        [NativeTypeName("HRESULT (IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore**, int> GetMetadata;
    }
}
