// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSinkWriterEx.xml' path='doc/member[@name="IMFSinkWriterEx"]/*'/>
[Guid("588D72AB-5BC1-496A-8714-B70617141B25")]
[NativeTypeName("struct IMFSinkWriterEx : IMFSinkWriter")]
[NativeInheritance("IMFSinkWriter")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFSinkWriterEx : IMFSinkWriterEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSinkWriterEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, Guid*, void**, int> )(lpVtbl[0]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint> )(lpVtbl[1]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint> )(lpVtbl[2]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFSinkWriter.AddStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddStream(IMFMediaType* pTargetMediaType, [NativeTypeName("DWORD *")] uint* pdwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, IMFMediaType*, uint*, int> )(lpVtbl[3]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), pTargetMediaType, pdwStreamIndex);
    }

    /// <inheritdoc cref = "IMFSinkWriter.SetInputMediaType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetInputMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pInputMediaType, IMFAttributes* pEncodingParameters)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint, IMFMediaType*, IMFAttributes*, int> )(lpVtbl[4]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pInputMediaType, pEncodingParameters);
    }

    /// <inheritdoc cref = "IMFSinkWriter.BeginWriting"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginWriting()
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, int> )(lpVtbl[5]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFSinkWriter.WriteSample"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteSample([NativeTypeName("DWORD")] uint dwStreamIndex, IMFSample* pSample)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint, IMFSample*, int> )(lpVtbl[6]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pSample);
    }

    /// <inheritdoc cref = "IMFSinkWriter.SendStreamTick"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SendStreamTick([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LONGLONG")] long llTimestamp)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint, long, int> )(lpVtbl[7]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, llTimestamp);
    }

    /// <inheritdoc cref = "IMFSinkWriter.PlaceMarker"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PlaceMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint, void*, int> )(lpVtbl[8]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pvContext);
    }

    /// <inheritdoc cref = "IMFSinkWriter.NotifyEndOfSegment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT NotifyEndOfSegment([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint, int> )(lpVtbl[9]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex);
    }

    /// <inheritdoc cref = "IMFSinkWriter.Flush"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint, int> )(lpVtbl[10]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex);
    }

    /// <inheritdoc cref = "IMFSinkWriter.Finalize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Finalize()
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, int> )(lpVtbl[11]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFSinkWriter.GetServiceForStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint, Guid*, Guid*, void**, int> )(lpVtbl[12]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidService, riid, ppvObject);
    }

    /// <inheritdoc cref = "IMFSinkWriter.GetStatistics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetStatistics([NativeTypeName("DWORD")] uint dwStreamIndex, MF_SINK_WRITER_STATISTICS* pStats)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint, MF_SINK_WRITER_STATISTICS*, int> )(lpVtbl[13]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pStats);
    }

    /// <include file='IMFSinkWriterEx.xml' path='doc/member[@name="IMFSinkWriterEx.GetTransformForStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwTransformIndex, Guid* pGuidCategory, IMFTransform** ppTransform)
    {
        return ((delegate* unmanaged<IMFSinkWriterEx*, uint, uint, Guid*, IMFTransform**, int> )(lpVtbl[14]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwTransformIndex, pGuidCategory, ppTransform);
    }

    public interface Interface : IMFSinkWriter.Interface
    {
        [VtblIndex(14)]
        HRESULT GetTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwTransformIndex, Guid* pGuidCategory, IMFTransform** ppTransform);
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
        public delegate* unmanaged<TSelf*, IMFMediaType*, uint*, int> AddStream;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, IMFAttributes*, int> SetInputMediaType;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BeginWriting;
        [NativeTypeName("HRESULT (DWORD, IMFSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSample*, int> WriteSample;
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
        [NativeTypeName("HRESULT (DWORD, const GUID &, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, void**, int> GetServiceForStream;
        [NativeTypeName("HRESULT (DWORD, MF_SINK_WRITER_STATISTICS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, MF_SINK_WRITER_STATISTICS*, int> GetStatistics;
        [NativeTypeName("HRESULT (DWORD, DWORD, GUID *, IMFTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, Guid*, IMFTransform**, int> GetTransformForStream;
    }
}