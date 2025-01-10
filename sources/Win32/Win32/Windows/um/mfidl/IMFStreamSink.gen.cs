// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0A97B3CF-8E7C-4A3D-8F8C-0C843DC247FB")]
[NativeTypeName("struct IMFStreamSink : IMFMediaEventGenerator")]
[NativeInheritance("IMFMediaEventGenerator")]
public unsafe partial struct IMFStreamSink : IMFStreamSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFStreamSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFStreamSink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFStreamSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFStreamSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent* ppEvent)
    {
        return ((delegate* unmanaged<IMFStreamSink, uint, IMFMediaEvent*, int>)((*lpVtbl)[3]))(
            this,
            dwFlags,
            ppEvent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetEvent(IMFAsyncCallback pCallback, IUnknown punkState)
    {
        return (
            (delegate* unmanaged<IMFStreamSink, IMFAsyncCallback, IUnknown, int>)((*lpVtbl)[4])
        )(this, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult pResult, IMFMediaEvent* ppEvent)
    {
        return (
            (delegate* unmanaged<IMFStreamSink, IMFAsyncResult, IMFMediaEvent*, int>)((*lpVtbl)[5])
        )(this, pResult, ppEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueueEvent(
        [NativeTypeName("MediaEventType")] uint met,
        [NativeTypeName("const GUID &")] Guid* guidExtendedType,
        HRESULT hrStatus,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue
    )
    {
        return (
            (delegate* unmanaged<IMFStreamSink, uint, Guid*, HRESULT, PROPVARIANT*, int>)(
                (*lpVtbl)[6]
            )
        )(this, met, guidExtendedType, hrStatus, pvValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMediaSink(IMFMediaSink* ppMediaSink)
    {
        return ((delegate* unmanaged<IMFStreamSink, IMFMediaSink*, int>)((*lpVtbl)[7]))(
            this,
            ppMediaSink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetIdentifier([NativeTypeName("DWORD *")] uint* pdwIdentifier)
    {
        return ((delegate* unmanaged<IMFStreamSink, uint*, int>)((*lpVtbl)[8]))(
            this,
            pdwIdentifier
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMediaTypeHandler(IMFMediaTypeHandler* ppHandler)
    {
        return ((delegate* unmanaged<IMFStreamSink, IMFMediaTypeHandler*, int>)((*lpVtbl)[9]))(
            this,
            ppHandler
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ProcessSample(IMFSample pSample)
    {
        return ((delegate* unmanaged<IMFStreamSink, IMFSample, int>)((*lpVtbl)[10]))(this, pSample);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT PlaceMarker(
        MFSTREAMSINK_MARKER_TYPE eMarkerType,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarMarkerValue,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarContextValue
    )
    {
        return (
            (delegate* unmanaged<
                IMFStreamSink,
                MFSTREAMSINK_MARKER_TYPE,
                PROPVARIANT*,
                PROPVARIANT*,
                int>)((*lpVtbl)[11])
        )(this, eMarkerType, pvarMarkerValue, pvarContextValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IMFStreamSink, int>)((*lpVtbl)[12]))(this);
    }

    public interface Interface : IMFMediaEventGenerator.Interface
    {
        [VtblIndex(7)]
        HRESULT GetMediaSink(IMFMediaSink* ppMediaSink);

        [VtblIndex(8)]
        HRESULT GetIdentifier([NativeTypeName("DWORD *")] uint* pdwIdentifier);

        [VtblIndex(9)]
        HRESULT GetMediaTypeHandler(IMFMediaTypeHandler* ppHandler);

        [VtblIndex(10)]
        HRESULT ProcessSample(IMFSample pSample);

        [VtblIndex(11)]
        HRESULT PlaceMarker(
            MFSTREAMSINK_MARKER_TYPE eMarkerType,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarMarkerValue,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarContextValue
        );

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
        public delegate* unmanaged<TSelf*, uint, IMFMediaEvent*, int> GetEvent;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback, IUnknown, int> BeginGetEvent;

        [NativeTypeName("HRESULT (IMFAsyncResult *, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult, IMFMediaEvent*, int> EndGetEvent;

        [NativeTypeName(
            "HRESULT (MediaEventType, const GUID &, HRESULT, const PROPVARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Guid*, HRESULT, PROPVARIANT*, int> QueueEvent;

        [NativeTypeName("HRESULT (IMFMediaSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaSink*, int> GetMediaSink;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetIdentifier;

        [NativeTypeName("HRESULT (IMFMediaTypeHandler **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaTypeHandler*, int> GetMediaTypeHandler;

        [NativeTypeName("HRESULT (IMFSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSample, int> ProcessSample;

        [NativeTypeName(
            "HRESULT (MFSTREAMSINK_MARKER_TYPE, const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MFSTREAMSINK_MARKER_TYPE,
            PROPVARIANT*,
            PROPVARIANT*,
            int> PlaceMarker;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Flush;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFStreamSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFStreamSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFMediaEventGenerator"/> to <see cref = "IMFStreamSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFMediaEventGenerator"/> instance to be converted </param>
    public static explicit operator IMFStreamSink(Silk.NET.Windows.IMFMediaEventGenerator value)
    {
        return new IMFStreamSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFStreamSink"/> to <see cref = "Silk.NET.Windows.IMFMediaEventGenerator"/>.</summary>
    /// <param name = "value">The <see cref = "IMFStreamSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFMediaEventGenerator(IMFStreamSink value)
    {
        return new Silk.NET.Windows.IMFMediaEventGenerator(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFStreamSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFStreamSink(Silk.NET.Windows.IUnknown value)
    {
        return new IMFStreamSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFStreamSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFStreamSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFStreamSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
