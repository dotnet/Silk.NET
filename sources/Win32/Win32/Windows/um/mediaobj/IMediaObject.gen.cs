// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D8AD0F58-5494-4102-97C5-EC798E59BCF4")]
[NativeTypeName("struct IMediaObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMediaObject : IMediaObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaObject));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaObject, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaObject, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaObject, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStreamCount(
        [NativeTypeName("DWORD *")] uint* pcInputStreams,
        [NativeTypeName("DWORD *")] uint* pcOutputStreams
    )
    {
        return ((delegate* unmanaged<IMediaObject, uint*, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcInputStreams,
            pcOutputStreams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetInputStreamInfo(
        [NativeTypeName("DWORD")] uint dwInputStreamIndex,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    )
    {
        return ((delegate* unmanaged<IMediaObject, uint, uint*, int>)((*lpVtbl)[4]))(
            this,
            dwInputStreamIndex,
            pdwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOutputStreamInfo(
        [NativeTypeName("DWORD")] uint dwOutputStreamIndex,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    )
    {
        return ((delegate* unmanaged<IMediaObject, uint, uint*, int>)((*lpVtbl)[5]))(
            this,
            dwOutputStreamIndex,
            pdwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetInputType(
        [NativeTypeName("DWORD")] uint dwInputStreamIndex,
        [NativeTypeName("DWORD")] uint dwTypeIndex,
        DMO_MEDIA_TYPE* pmt
    )
    {
        return (
            (delegate* unmanaged<IMediaObject, uint, uint, DMO_MEDIA_TYPE*, int>)((*lpVtbl)[6])
        )(this, dwInputStreamIndex, dwTypeIndex, pmt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOutputType(
        [NativeTypeName("DWORD")] uint dwOutputStreamIndex,
        [NativeTypeName("DWORD")] uint dwTypeIndex,
        DMO_MEDIA_TYPE* pmt
    )
    {
        return (
            (delegate* unmanaged<IMediaObject, uint, uint, DMO_MEDIA_TYPE*, int>)((*lpVtbl)[7])
        )(this, dwOutputStreamIndex, dwTypeIndex, pmt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetInputType(
        [NativeTypeName("DWORD")] uint dwInputStreamIndex,
        [NativeTypeName("const DMO_MEDIA_TYPE *")] DMO_MEDIA_TYPE* pmt,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<IMediaObject, uint, DMO_MEDIA_TYPE*, uint, int>)((*lpVtbl)[8])
        )(this, dwInputStreamIndex, pmt, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetOutputType(
        [NativeTypeName("DWORD")] uint dwOutputStreamIndex,
        [NativeTypeName("const DMO_MEDIA_TYPE *")] DMO_MEDIA_TYPE* pmt,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<IMediaObject, uint, DMO_MEDIA_TYPE*, uint, int>)((*lpVtbl)[9])
        )(this, dwOutputStreamIndex, pmt, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetInputCurrentType(
        [NativeTypeName("DWORD")] uint dwInputStreamIndex,
        DMO_MEDIA_TYPE* pmt
    )
    {
        return ((delegate* unmanaged<IMediaObject, uint, DMO_MEDIA_TYPE*, int>)((*lpVtbl)[10]))(
            this,
            dwInputStreamIndex,
            pmt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetOutputCurrentType(
        [NativeTypeName("DWORD")] uint dwOutputStreamIndex,
        DMO_MEDIA_TYPE* pmt
    )
    {
        return ((delegate* unmanaged<IMediaObject, uint, DMO_MEDIA_TYPE*, int>)((*lpVtbl)[11]))(
            this,
            dwOutputStreamIndex,
            pmt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetInputSizeInfo(
        [NativeTypeName("DWORD")] uint dwInputStreamIndex,
        [NativeTypeName("DWORD *")] uint* pcbSize,
        [NativeTypeName("DWORD *")] uint* pcbMaxLookahead,
        [NativeTypeName("DWORD *")] uint* pcbAlignment
    )
    {
        return ((delegate* unmanaged<IMediaObject, uint, uint*, uint*, uint*, int>)((*lpVtbl)[12]))(
            this,
            dwInputStreamIndex,
            pcbSize,
            pcbMaxLookahead,
            pcbAlignment
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetOutputSizeInfo(
        [NativeTypeName("DWORD")] uint dwOutputStreamIndex,
        [NativeTypeName("DWORD *")] uint* pcbSize,
        [NativeTypeName("DWORD *")] uint* pcbAlignment
    )
    {
        return ((delegate* unmanaged<IMediaObject, uint, uint*, uint*, int>)((*lpVtbl)[13]))(
            this,
            dwOutputStreamIndex,
            pcbSize,
            pcbAlignment
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetInputMaxLatency(
        [NativeTypeName("DWORD")] uint dwInputStreamIndex,
        [NativeTypeName("REFERENCE_TIME *")] long* prtMaxLatency
    )
    {
        return ((delegate* unmanaged<IMediaObject, uint, long*, int>)((*lpVtbl)[14]))(
            this,
            dwInputStreamIndex,
            prtMaxLatency
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetInputMaxLatency(
        [NativeTypeName("DWORD")] uint dwInputStreamIndex,
        [NativeTypeName("REFERENCE_TIME")] long rtMaxLatency
    )
    {
        return ((delegate* unmanaged<IMediaObject, uint, long, int>)((*lpVtbl)[15]))(
            this,
            dwInputStreamIndex,
            rtMaxLatency
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IMediaObject, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Discontinuity([NativeTypeName("DWORD")] uint dwInputStreamIndex)
    {
        return ((delegate* unmanaged<IMediaObject, uint, int>)((*lpVtbl)[17]))(
            this,
            dwInputStreamIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT AllocateStreamingResources()
    {
        return ((delegate* unmanaged<IMediaObject, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT FreeStreamingResources()
    {
        return ((delegate* unmanaged<IMediaObject, int>)((*lpVtbl)[19]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetInputStatus(
        [NativeTypeName("DWORD")] uint dwInputStreamIndex,
        [NativeTypeName("DWORD *")] uint* dwFlags
    )
    {
        return ((delegate* unmanaged<IMediaObject, uint, uint*, int>)((*lpVtbl)[20]))(
            this,
            dwInputStreamIndex,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ProcessInput(
        [NativeTypeName("DWORD")] uint dwInputStreamIndex,
        IMediaBuffer pBuffer,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("REFERENCE_TIME")] long rtTimestamp,
        [NativeTypeName("REFERENCE_TIME")] long rtTimelength
    )
    {
        return (
            (delegate* unmanaged<IMediaObject, uint, IMediaBuffer, uint, long, long, int>)(
                (*lpVtbl)[21]
            )
        )(this, dwInputStreamIndex, pBuffer, dwFlags, rtTimestamp, rtTimelength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ProcessOutput(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint cOutputBufferCount,
        DMO_OUTPUT_DATA_BUFFER* pOutputBuffers,
        [NativeTypeName("DWORD *")] uint* pdwStatus
    )
    {
        return (
            (delegate* unmanaged<IMediaObject, uint, uint, DMO_OUTPUT_DATA_BUFFER*, uint*, int>)(
                (*lpVtbl)[22]
            )
        )(this, dwFlags, cOutputBufferCount, pOutputBuffers, pdwStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Lock([NativeTypeName("LONG")] int bLock)
    {
        return ((delegate* unmanaged<IMediaObject, int, int>)((*lpVtbl)[23]))(this, bLock);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStreamCount(
            [NativeTypeName("DWORD *")] uint* pcInputStreams,
            [NativeTypeName("DWORD *")] uint* pcOutputStreams
        );

        [VtblIndex(4)]
        HRESULT GetInputStreamInfo(
            [NativeTypeName("DWORD")] uint dwInputStreamIndex,
            [NativeTypeName("DWORD *")] uint* pdwFlags
        );

        [VtblIndex(5)]
        HRESULT GetOutputStreamInfo(
            [NativeTypeName("DWORD")] uint dwOutputStreamIndex,
            [NativeTypeName("DWORD *")] uint* pdwFlags
        );

        [VtblIndex(6)]
        HRESULT GetInputType(
            [NativeTypeName("DWORD")] uint dwInputStreamIndex,
            [NativeTypeName("DWORD")] uint dwTypeIndex,
            DMO_MEDIA_TYPE* pmt
        );

        [VtblIndex(7)]
        HRESULT GetOutputType(
            [NativeTypeName("DWORD")] uint dwOutputStreamIndex,
            [NativeTypeName("DWORD")] uint dwTypeIndex,
            DMO_MEDIA_TYPE* pmt
        );

        [VtblIndex(8)]
        HRESULT SetInputType(
            [NativeTypeName("DWORD")] uint dwInputStreamIndex,
            [NativeTypeName("const DMO_MEDIA_TYPE *")] DMO_MEDIA_TYPE* pmt,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(9)]
        HRESULT SetOutputType(
            [NativeTypeName("DWORD")] uint dwOutputStreamIndex,
            [NativeTypeName("const DMO_MEDIA_TYPE *")] DMO_MEDIA_TYPE* pmt,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(10)]
        HRESULT GetInputCurrentType(
            [NativeTypeName("DWORD")] uint dwInputStreamIndex,
            DMO_MEDIA_TYPE* pmt
        );

        [VtblIndex(11)]
        HRESULT GetOutputCurrentType(
            [NativeTypeName("DWORD")] uint dwOutputStreamIndex,
            DMO_MEDIA_TYPE* pmt
        );

        [VtblIndex(12)]
        HRESULT GetInputSizeInfo(
            [NativeTypeName("DWORD")] uint dwInputStreamIndex,
            [NativeTypeName("DWORD *")] uint* pcbSize,
            [NativeTypeName("DWORD *")] uint* pcbMaxLookahead,
            [NativeTypeName("DWORD *")] uint* pcbAlignment
        );

        [VtblIndex(13)]
        HRESULT GetOutputSizeInfo(
            [NativeTypeName("DWORD")] uint dwOutputStreamIndex,
            [NativeTypeName("DWORD *")] uint* pcbSize,
            [NativeTypeName("DWORD *")] uint* pcbAlignment
        );

        [VtblIndex(14)]
        HRESULT GetInputMaxLatency(
            [NativeTypeName("DWORD")] uint dwInputStreamIndex,
            [NativeTypeName("REFERENCE_TIME *")] long* prtMaxLatency
        );

        [VtblIndex(15)]
        HRESULT SetInputMaxLatency(
            [NativeTypeName("DWORD")] uint dwInputStreamIndex,
            [NativeTypeName("REFERENCE_TIME")] long rtMaxLatency
        );

        [VtblIndex(16)]
        HRESULT Flush();

        [VtblIndex(17)]
        HRESULT Discontinuity([NativeTypeName("DWORD")] uint dwInputStreamIndex);

        [VtblIndex(18)]
        HRESULT AllocateStreamingResources();

        [VtblIndex(19)]
        HRESULT FreeStreamingResources();

        [VtblIndex(20)]
        HRESULT GetInputStatus(
            [NativeTypeName("DWORD")] uint dwInputStreamIndex,
            [NativeTypeName("DWORD *")] uint* dwFlags
        );

        [VtblIndex(21)]
        HRESULT ProcessInput(
            [NativeTypeName("DWORD")] uint dwInputStreamIndex,
            IMediaBuffer pBuffer,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("REFERENCE_TIME")] long rtTimestamp,
            [NativeTypeName("REFERENCE_TIME")] long rtTimelength
        );

        [VtblIndex(22)]
        HRESULT ProcessOutput(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("DWORD")] uint cOutputBufferCount,
            DMO_OUTPUT_DATA_BUFFER* pOutputBuffers,
            [NativeTypeName("DWORD *")] uint* pdwStatus
        );

        [VtblIndex(23)]
        HRESULT Lock([NativeTypeName("LONG")] int bLock);
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

        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetStreamCount;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetInputStreamInfo;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetOutputStreamInfo;

        [NativeTypeName("HRESULT (DWORD, DWORD, DMO_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DMO_MEDIA_TYPE*, int> GetInputType;

        [NativeTypeName("HRESULT (DWORD, DWORD, DMO_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DMO_MEDIA_TYPE*, int> GetOutputType;

        [NativeTypeName("HRESULT (DWORD, const DMO_MEDIA_TYPE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DMO_MEDIA_TYPE*, uint, int> SetInputType;

        [NativeTypeName("HRESULT (DWORD, const DMO_MEDIA_TYPE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DMO_MEDIA_TYPE*, uint, int> SetOutputType;

        [NativeTypeName("HRESULT (DWORD, DMO_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DMO_MEDIA_TYPE*, int> GetInputCurrentType;

        [NativeTypeName("HRESULT (DWORD, DMO_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DMO_MEDIA_TYPE*, int> GetOutputCurrentType;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, uint*, int> GetInputSizeInfo;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, int> GetOutputSizeInfo;

        [NativeTypeName("HRESULT (DWORD, REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, long*, int> GetInputMaxLatency;

        [NativeTypeName("HRESULT (DWORD, REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, long, int> SetInputMaxLatency;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Flush;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Discontinuity;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> AllocateStreamingResources;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FreeStreamingResources;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetInputStatus;

        [NativeTypeName(
            "HRESULT (DWORD, IMediaBuffer *, DWORD, REFERENCE_TIME, REFERENCE_TIME) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IMediaBuffer, uint, long, long, int> ProcessInput;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, DMO_OUTPUT_DATA_BUFFER *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DMO_OUTPUT_DATA_BUFFER*,
            uint*,
            int> ProcessOutput;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> Lock;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaObject(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaObject(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaObject"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaObject value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
