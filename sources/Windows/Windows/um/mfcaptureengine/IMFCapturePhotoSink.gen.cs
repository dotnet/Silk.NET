// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFCapturePhotoSink.xml' path='doc/member[@name="IMFCapturePhotoSink"]/*'/>
[Guid("D2D43CC8-48BB-4AA7-95DB-10C06977E777")]
[NativeTypeName("struct IMFCapturePhotoSink : IMFCaptureSink")]
[NativeInheritance("IMFCaptureSink")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFCapturePhotoSink : IMFCapturePhotoSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCapturePhotoSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, Guid*, void**, int> )(lpVtbl[0]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, uint> )(lpVtbl[1]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, uint> )(lpVtbl[2]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFCaptureSink.GetOutputMediaType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOutputMediaType([NativeTypeName("DWORD")] uint dwSinkStreamIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, uint, IMFMediaType**, int> )(lpVtbl[3]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, ppMediaType);
    }

    /// <inheritdoc cref = "IMFCaptureSink.GetService"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetService([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown)
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, uint, Guid*, Guid*, IUnknown**, int> )(lpVtbl[4]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, rguidService, riid, ppUnknown);
    }

    /// <inheritdoc cref = "IMFCaptureSink.AddStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddStream([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType, IMFAttributes* pAttributes, [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex)
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, uint, IMFMediaType*, IMFAttributes*, uint*, int> )(lpVtbl[5]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
    }

    /// <inheritdoc cref = "IMFCaptureSink.Prepare"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Prepare()
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, int> )(lpVtbl[6]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFCaptureSink.RemoveAllStreams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveAllStreams()
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, int> )(lpVtbl[7]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCapturePhotoSink.xml' path='doc/member[@name="IMFCapturePhotoSink.SetOutputFileName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetOutputFileName([NativeTypeName("LPCWSTR")] ushort* fileName)
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, ushort*, int> )(lpVtbl[8]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), fileName);
    }

    /// <include file='IMFCapturePhotoSink.xml' path='doc/member[@name="IMFCapturePhotoSink.SetSampleCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetSampleCallback(IMFCaptureEngineOnSampleCallback* pCallback)
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, IMFCaptureEngineOnSampleCallback*, int> )(lpVtbl[9]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), pCallback);
    }

    /// <include file='IMFCapturePhotoSink.xml' path='doc/member[@name="IMFCapturePhotoSink.SetOutputByteStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetOutputByteStream(IMFByteStream* pByteStream)
    {
        return ((delegate* unmanaged<IMFCapturePhotoSink*, IMFByteStream*, int> )(lpVtbl[10]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), pByteStream);
    }

    public interface Interface : IMFCaptureSink.Interface
    {
        [VtblIndex(8)]
        HRESULT SetOutputFileName([NativeTypeName("LPCWSTR")] ushort* fileName);
        [VtblIndex(9)]
        HRESULT SetSampleCallback(IMFCaptureEngineOnSampleCallback* pCallback);
        [VtblIndex(10)]
        HRESULT SetOutputByteStream(IMFByteStream* pByteStream);
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
        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType**, int> GetOutputMediaType;
        [NativeTypeName("HRESULT (DWORD, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, IUnknown**, int> GetService;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, IMFAttributes *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, IMFAttributes*, uint*, int> AddStream;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Prepare;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllStreams;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetOutputFileName;
        [NativeTypeName("HRESULT (IMFCaptureEngineOnSampleCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFCaptureEngineOnSampleCallback*, int> SetSampleCallback;
        [NativeTypeName("HRESULT (IMFByteStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFByteStream*, int> SetOutputByteStream;
    }
}