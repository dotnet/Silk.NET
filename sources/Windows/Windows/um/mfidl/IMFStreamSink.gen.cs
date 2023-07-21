// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFStreamSink.xml' path='doc/member[@name="IMFStreamSink"]/*' />
[Guid("0A97B3CF-8E7C-4A3D-8F8C-0C843DC247FB")]
[NativeTypeName("struct IMFStreamSink : IMFMediaEventGenerator")]
[NativeInheritance("IMFMediaEventGenerator")]
public unsafe partial struct IMFStreamSink : IMFStreamSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFStreamSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFStreamSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFStreamSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFStreamSink*, uint>)(lpVtbl[1]))((IMFStreamSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFStreamSink*, uint>)(lpVtbl[2]))((IMFStreamSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEventGenerator.GetEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFStreamSink*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFStreamSink*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
    }

    /// <inheritdoc cref="IMFMediaEventGenerator.BeginGetEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFStreamSink*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFStreamSink*)Unsafe.AsPointer(ref this), pCallback, punkState);
    }

    /// <inheritdoc cref="IMFMediaEventGenerator.EndGetEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFStreamSink*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFStreamSink*)Unsafe.AsPointer(ref this), pResult, ppEvent);
    }

    /// <inheritdoc cref="IMFMediaEventGenerator.QueueEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
    {
        return ((delegate* unmanaged<IMFStreamSink*, uint, Guid*, HRESULT, PROPVARIANT*, int>)(lpVtbl[6]))((IMFStreamSink*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
    }

    /// <include file='IMFStreamSink.xml' path='doc/member[@name="IMFStreamSink.GetMediaSink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMediaSink(IMFMediaSink** ppMediaSink)
    {
        return ((delegate* unmanaged<IMFStreamSink*, IMFMediaSink**, int>)(lpVtbl[7]))((IMFStreamSink*)Unsafe.AsPointer(ref this), ppMediaSink);
    }

    /// <include file='IMFStreamSink.xml' path='doc/member[@name="IMFStreamSink.GetIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetIdentifier([NativeTypeName("DWORD *")] uint* pdwIdentifier)
    {
        return ((delegate* unmanaged<IMFStreamSink*, uint*, int>)(lpVtbl[8]))((IMFStreamSink*)Unsafe.AsPointer(ref this), pdwIdentifier);
    }

    /// <include file='IMFStreamSink.xml' path='doc/member[@name="IMFStreamSink.GetMediaTypeHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMediaTypeHandler(IMFMediaTypeHandler** ppHandler)
    {
        return ((delegate* unmanaged<IMFStreamSink*, IMFMediaTypeHandler**, int>)(lpVtbl[9]))((IMFStreamSink*)Unsafe.AsPointer(ref this), ppHandler);
    }

    /// <include file='IMFStreamSink.xml' path='doc/member[@name="IMFStreamSink.ProcessSample"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ProcessSample(IMFSample* pSample)
    {
        return ((delegate* unmanaged<IMFStreamSink*, IMFSample*, int>)(lpVtbl[10]))((IMFStreamSink*)Unsafe.AsPointer(ref this), pSample);
    }

    /// <include file='IMFStreamSink.xml' path='doc/member[@name="IMFStreamSink.PlaceMarker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT PlaceMarker(MFSTREAMSINK_MARKER_TYPE eMarkerType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarMarkerValue, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarContextValue)
    {
        return ((delegate* unmanaged<IMFStreamSink*, MFSTREAMSINK_MARKER_TYPE, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[11]))((IMFStreamSink*)Unsafe.AsPointer(ref this), eMarkerType, pvarMarkerValue, pvarContextValue);
    }

    /// <include file='IMFStreamSink.xml' path='doc/member[@name="IMFStreamSink.Flush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IMFStreamSink*, int>)(lpVtbl[12]))((IMFStreamSink*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IMFMediaEventGenerator.Interface
    {
        [VtblIndex(7)]
        HRESULT GetMediaSink(IMFMediaSink** ppMediaSink);

        [VtblIndex(8)]
        HRESULT GetIdentifier([NativeTypeName("DWORD *")] uint* pdwIdentifier);

        [VtblIndex(9)]
        HRESULT GetMediaTypeHandler(IMFMediaTypeHandler** ppHandler);

        [VtblIndex(10)]
        HRESULT ProcessSample(IMFSample* pSample);

        [VtblIndex(11)]
        HRESULT PlaceMarker(MFSTREAMSINK_MARKER_TYPE eMarkerType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarMarkerValue, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarContextValue);

        [VtblIndex(12)]
        HRESULT Flush();
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

        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaEvent**, int> GetEvent;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback*, IUnknown*, int> BeginGetEvent;

        [NativeTypeName("HRESULT (IMFAsyncResult *, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, IMFMediaEvent**, int> EndGetEvent;

        [NativeTypeName("HRESULT (MediaEventType, const GUID &, HRESULT, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, HRESULT, PROPVARIANT*, int> QueueEvent;

        [NativeTypeName("HRESULT (IMFMediaSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaSink**, int> GetMediaSink;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetIdentifier;

        [NativeTypeName("HRESULT (IMFMediaTypeHandler **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaTypeHandler**, int> GetMediaTypeHandler;

        [NativeTypeName("HRESULT (IMFSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSample*, int> ProcessSample;

        [NativeTypeName("HRESULT (MFSTREAMSINK_MARKER_TYPE, const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFSTREAMSINK_MARKER_TYPE, PROPVARIANT*, PROPVARIANT*, int> PlaceMarker;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Flush;
    }
}
