// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFCapturePreviewSink.xml' path='doc/member[@name="IMFCapturePreviewSink"]/*'/>
[Guid("77346CFD-5B49-4D73-ACE0-5B52A859F2E0")]
[NativeTypeName("struct IMFCapturePreviewSink : IMFCaptureSink")]
[NativeInheritance("IMFCaptureSink")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFCapturePreviewSink : IMFCapturePreviewSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCapturePreviewSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, Guid*, void**, int> )(lpVtbl[0]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, uint> )(lpVtbl[1]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, uint> )(lpVtbl[2]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFCaptureSink.GetOutputMediaType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOutputMediaType([NativeTypeName("DWORD")] uint dwSinkStreamIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, uint, IMFMediaType**, int> )(lpVtbl[3]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, ppMediaType);
    }

    /// <inheritdoc cref = "IMFCaptureSink.GetService"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetService([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, uint, Guid*, Guid*, IUnknown**, int> )(lpVtbl[4]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, rguidService, riid, ppUnknown);
    }

    /// <inheritdoc cref = "IMFCaptureSink.AddStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddStream([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType, IMFAttributes* pAttributes, [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, uint, IMFMediaType*, IMFAttributes*, uint*, int> )(lpVtbl[5]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
    }

    /// <inheritdoc cref = "IMFCaptureSink.Prepare"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Prepare()
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, int> )(lpVtbl[6]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFCaptureSink.RemoveAllStreams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveAllStreams()
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, int> )(lpVtbl[7]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCapturePreviewSink.xml' path='doc/member[@name="IMFCapturePreviewSink.SetRenderHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRenderHandle(HANDLE handle)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, HANDLE, int> )(lpVtbl[8]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), handle);
    }

    /// <include file='IMFCapturePreviewSink.xml' path='doc/member[@name="IMFCapturePreviewSink.SetRenderSurface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetRenderSurface(IUnknown* pSurface)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, IUnknown*, int> )(lpVtbl[9]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), pSurface);
    }

    /// <include file='IMFCapturePreviewSink.xml' path='doc/member[@name="IMFCapturePreviewSink.UpdateVideo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT UpdateVideo([NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const COLORREF *")] COLORREF* pBorderClr)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, MFVideoNormalizedRect*, RECT*, COLORREF*, int> )(lpVtbl[10]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), pSrc, pDst, pBorderClr);
    }

    /// <include file='IMFCapturePreviewSink.xml' path='doc/member[@name="IMFCapturePreviewSink.SetSampleCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetSampleCallback([NativeTypeName("DWORD")] uint dwStreamSinkIndex, IMFCaptureEngineOnSampleCallback* pCallback)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, uint, IMFCaptureEngineOnSampleCallback*, int> )(lpVtbl[11]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwStreamSinkIndex, pCallback);
    }

    /// <include file='IMFCapturePreviewSink.xml' path='doc/member[@name="IMFCapturePreviewSink.GetMirrorState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMirrorState(BOOL* pfMirrorState)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, BOOL*, int> )(lpVtbl[12]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), pfMirrorState);
    }

    /// <include file='IMFCapturePreviewSink.xml' path='doc/member[@name="IMFCapturePreviewSink.SetMirrorState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetMirrorState(BOOL fMirrorState)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, BOOL, int> )(lpVtbl[13]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), fMirrorState);
    }

    /// <include file='IMFCapturePreviewSink.xml' path='doc/member[@name="IMFCapturePreviewSink.GetRotation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetRotation([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwRotationValue)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, uint, uint*, int> )(lpVtbl[14]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwStreamIndex, pdwRotationValue);
    }

    /// <include file='IMFCapturePreviewSink.xml' path='doc/member[@name="IMFCapturePreviewSink.SetRotation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetRotation([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwRotationValue)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, uint, uint, int> )(lpVtbl[15]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwStreamIndex, dwRotationValue);
    }

    /// <include file='IMFCapturePreviewSink.xml' path='doc/member[@name="IMFCapturePreviewSink.SetCustomSink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetCustomSink(IMFMediaSink* pMediaSink)
    {
        return ((delegate* unmanaged<IMFCapturePreviewSink*, IMFMediaSink*, int> )(lpVtbl[16]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), pMediaSink);
    }

    public interface Interface : IMFCaptureSink.Interface
    {
        [VtblIndex(8)]
        HRESULT SetRenderHandle(HANDLE handle);
        [VtblIndex(9)]
        HRESULT SetRenderSurface(IUnknown* pSurface);
        [VtblIndex(10)]
        HRESULT UpdateVideo([NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const COLORREF *")] COLORREF* pBorderClr);
        [VtblIndex(11)]
        HRESULT SetSampleCallback([NativeTypeName("DWORD")] uint dwStreamSinkIndex, IMFCaptureEngineOnSampleCallback* pCallback);
        [VtblIndex(12)]
        HRESULT GetMirrorState(BOOL* pfMirrorState);
        [VtblIndex(13)]
        HRESULT SetMirrorState(BOOL fMirrorState);
        [VtblIndex(14)]
        HRESULT GetRotation([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwRotationValue);
        [VtblIndex(15)]
        HRESULT SetRotation([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwRotationValue);
        [VtblIndex(16)]
        HRESULT SetCustomSink(IMFMediaSink* pMediaSink);
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
        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> SetRenderHandle;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetRenderSurface;
        [NativeTypeName("HRESULT (const MFVideoNormalizedRect *, const RECT *, const COLORREF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFVideoNormalizedRect*, RECT*, COLORREF*, int> UpdateVideo;
        [NativeTypeName("HRESULT (DWORD, IMFCaptureEngineOnSampleCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFCaptureEngineOnSampleCallback*, int> SetSampleCallback;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetMirrorState;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetMirrorState;
        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetRotation;
        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetRotation;
        [NativeTypeName("HRESULT (IMFMediaSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaSink*, int> SetCustomSink;
    }
}