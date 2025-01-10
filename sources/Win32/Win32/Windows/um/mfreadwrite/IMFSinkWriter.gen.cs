// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3137F1CD-FE5E-4805-A5D8-FB477448CB3D")]
[NativeTypeName("struct IMFSinkWriter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSinkWriter : IMFSinkWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSinkWriter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSinkWriter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSinkWriter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSinkWriter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddStream(
        IMFMediaType pTargetMediaType,
        [NativeTypeName("DWORD *")] uint* pdwStreamIndex
    )
    {
        return ((delegate* unmanaged<IMFSinkWriter, IMFMediaType, uint*, int>)((*lpVtbl)[3]))(
            this,
            pTargetMediaType,
            pdwStreamIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetInputMediaType(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        IMFMediaType pInputMediaType,
        IMFAttributes pEncodingParameters
    )
    {
        return (
            (delegate* unmanaged<IMFSinkWriter, uint, IMFMediaType, IMFAttributes, int>)(
                (*lpVtbl)[4]
            )
        )(this, dwStreamIndex, pInputMediaType, pEncodingParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginWriting()
    {
        return ((delegate* unmanaged<IMFSinkWriter, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteSample([NativeTypeName("DWORD")] uint dwStreamIndex, IMFSample pSample)
    {
        return ((delegate* unmanaged<IMFSinkWriter, uint, IMFSample, int>)((*lpVtbl)[6]))(
            this,
            dwStreamIndex,
            pSample
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SendStreamTick(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("LONGLONG")] long llTimestamp
    )
    {
        return ((delegate* unmanaged<IMFSinkWriter, uint, long, int>)((*lpVtbl)[7]))(
            this,
            dwStreamIndex,
            llTimestamp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PlaceMarker(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("LPVOID")] void* pvContext
    )
    {
        return ((delegate* unmanaged<IMFSinkWriter, uint, void*, int>)((*lpVtbl)[8]))(
            this,
            dwStreamIndex,
            pvContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT NotifyEndOfSegment([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSinkWriter, uint, int>)((*lpVtbl)[9]))(this, dwStreamIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSinkWriter, uint, int>)((*lpVtbl)[10]))(
            this,
            dwStreamIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Finalize()
    {
        return ((delegate* unmanaged<IMFSinkWriter, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetServiceForStream(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("const GUID &")] Guid* guidService,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<IMFSinkWriter, uint, Guid*, Guid*, void**, int>)((*lpVtbl)[12])
        )(this, dwStreamIndex, guidService, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetStatistics(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        MF_SINK_WRITER_STATISTICS* pStats
    )
    {
        return (
            (delegate* unmanaged<IMFSinkWriter, uint, MF_SINK_WRITER_STATISTICS*, int>)(
                (*lpVtbl)[13]
            )
        )(this, dwStreamIndex, pStats);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddStream(
            IMFMediaType pTargetMediaType,
            [NativeTypeName("DWORD *")] uint* pdwStreamIndex
        );

        [VtblIndex(4)]
        HRESULT SetInputMediaType(
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            IMFMediaType pInputMediaType,
            IMFAttributes pEncodingParameters
        );

        [VtblIndex(5)]
        HRESULT BeginWriting();

        [VtblIndex(6)]
        HRESULT WriteSample([NativeTypeName("DWORD")] uint dwStreamIndex, IMFSample pSample);

        [VtblIndex(7)]
        HRESULT SendStreamTick(
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            [NativeTypeName("LONGLONG")] long llTimestamp
        );

        [VtblIndex(8)]
        HRESULT PlaceMarker(
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            [NativeTypeName("LPVOID")] void* pvContext
        );

        [VtblIndex(9)]
        HRESULT NotifyEndOfSegment([NativeTypeName("DWORD")] uint dwStreamIndex);

        [VtblIndex(10)]
        HRESULT Flush([NativeTypeName("DWORD")] uint dwStreamIndex);

        [VtblIndex(11)]
        HRESULT Finalize();

        [VtblIndex(12)]
        HRESULT GetServiceForStream(
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            [NativeTypeName("const GUID &")] Guid* guidService,
            [NativeTypeName("const IID &")] Guid* riid,
            [NativeTypeName("LPVOID *")] void** ppvObject
        );

        [VtblIndex(13)]
        HRESULT GetStatistics(
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            MF_SINK_WRITER_STATISTICS* pStats
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

        [NativeTypeName("HRESULT (IMFMediaType *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaType, uint*, int> AddStream;

        [NativeTypeName(
            "HRESULT (DWORD, IMFMediaType *, IMFAttributes *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IMFMediaType,
            IMFAttributes,
            int> SetInputMediaType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BeginWriting;

        [NativeTypeName("HRESULT (DWORD, IMFSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSample, int> WriteSample;

        [NativeTypeName("HRESULT (DWORD, LONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, long, int> SendStreamTick;

        [NativeTypeName("HRESULT (DWORD, LPVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, int> PlaceMarker;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> NotifyEndOfSegment;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Flush;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Finalize;

        [NativeTypeName(
            "HRESULT (DWORD, const GUID &, const IID &, LPVOID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, void**, int> GetServiceForStream;

        [NativeTypeName("HRESULT (DWORD, MF_SINK_WRITER_STATISTICS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, MF_SINK_WRITER_STATISTICS*, int> GetStatistics;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSinkWriter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSinkWriter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSinkWriter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSinkWriter(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSinkWriter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSinkWriter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSinkWriter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSinkWriter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
