// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource"]/*'/>
[Guid("439A42A8-0D2C-4505-BE83-F79B2A05D5C4")]
[NativeTypeName("struct IMFCaptureSource : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFCaptureSource : IMFCaptureSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCaptureSource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, Guid*, void**, int> )(lpVtbl[0]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint> )(lpVtbl[1]))((IMFCaptureSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint> )(lpVtbl[2]))((IMFCaptureSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.GetCaptureDeviceSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCaptureDeviceSource(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, IMFMediaSource** ppMediaSource)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFMediaSource**, int> )(lpVtbl[3]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), mfCaptureEngineDeviceType, ppMediaSource);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.GetCaptureDeviceActivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCaptureDeviceActivate(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, IMFActivate** ppActivate)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFActivate**, int> )(lpVtbl[4]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), mfCaptureEngineDeviceType, ppActivate);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.GetService"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetService([NativeTypeName("const IID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, Guid*, Guid*, IUnknown**, int> )(lpVtbl[5]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), rguidService, riid, ppUnknown);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.AddEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddEffect([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint, IUnknown*, int> )(lpVtbl[6]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pUnknown);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.RemoveEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveEffect([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint, IUnknown*, int> )(lpVtbl[7]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pUnknown);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.RemoveAllEffects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveAllEffects([NativeTypeName("DWORD")] uint dwSourceStreamIndex)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint, int> )(lpVtbl[8]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.GetAvailableDeviceMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAvailableDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint, uint, IMFMediaType**, int> )(lpVtbl[9]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, dwMediaTypeIndex, ppMediaType);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.SetCurrentDeviceMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCurrentDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint, IMFMediaType*, int> )(lpVtbl[10]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.GetCurrentDeviceMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCurrentDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint, IMFMediaType**, int> )(lpVtbl[11]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, ppMediaType);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.GetDeviceStreamCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDeviceStreamCount([NativeTypeName("DWORD *")] uint* pdwStreamCount)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint*, int> )(lpVtbl[12]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), pdwStreamCount);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.GetDeviceStreamCategory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDeviceStreamCategory([NativeTypeName("DWORD")] uint dwSourceStreamIndex, MF_CAPTURE_ENGINE_STREAM_CATEGORY* pStreamCategory)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint, MF_CAPTURE_ENGINE_STREAM_CATEGORY*, int> )(lpVtbl[13]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pStreamCategory);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.GetMirrorState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetMirrorState([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfMirrorState)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint, BOOL*, int> )(lpVtbl[14]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwStreamIndex, pfMirrorState);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.SetMirrorState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetMirrorState([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fMirrorState)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint, BOOL, int> )(lpVtbl[15]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwStreamIndex, fMirrorState);
    }

    /// <include file='IMFCaptureSource.xml' path='doc/member[@name="IMFCaptureSource.GetStreamIndexFromFriendlyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetStreamIndexFromFriendlyName([NativeTypeName("UINT32")] uint uifriendlyName, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex)
    {
        return ((delegate* unmanaged<IMFCaptureSource*, uint, uint*, int> )(lpVtbl[16]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), uifriendlyName, pdwActualStreamIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCaptureDeviceSource(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, IMFMediaSource** ppMediaSource);
        [VtblIndex(4)]
        HRESULT GetCaptureDeviceActivate(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, IMFActivate** ppActivate);
        [VtblIndex(5)]
        HRESULT GetService([NativeTypeName("const IID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown);
        [VtblIndex(6)]
        HRESULT AddEffect([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IUnknown* pUnknown);
        [VtblIndex(7)]
        HRESULT RemoveEffect([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IUnknown* pUnknown);
        [VtblIndex(8)]
        HRESULT RemoveAllEffects([NativeTypeName("DWORD")] uint dwSourceStreamIndex);
        [VtblIndex(9)]
        HRESULT GetAvailableDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, IMFMediaType** ppMediaType);
        [VtblIndex(10)]
        HRESULT SetCurrentDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType);
        [VtblIndex(11)]
        HRESULT GetCurrentDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType** ppMediaType);
        [VtblIndex(12)]
        HRESULT GetDeviceStreamCount([NativeTypeName("DWORD *")] uint* pdwStreamCount);
        [VtblIndex(13)]
        HRESULT GetDeviceStreamCategory([NativeTypeName("DWORD")] uint dwSourceStreamIndex, MF_CAPTURE_ENGINE_STREAM_CATEGORY* pStreamCategory);
        [VtblIndex(14)]
        HRESULT GetMirrorState([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfMirrorState);
        [VtblIndex(15)]
        HRESULT SetMirrorState([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fMirrorState);
        [VtblIndex(16)]
        HRESULT GetStreamIndexFromFriendlyName([NativeTypeName("UINT32")] uint uifriendlyName, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex);
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
        [NativeTypeName("HRESULT (MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFMediaSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFMediaSource**, int> GetCaptureDeviceSource;
        [NativeTypeName("HRESULT (MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFActivate **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFActivate**, int> GetCaptureDeviceActivate;
        [NativeTypeName("HRESULT (const IID &, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, IUnknown**, int> GetService;
        [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, int> AddEffect;
        [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, int> RemoveEffect;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveAllEffects;
        [NativeTypeName("HRESULT (DWORD, DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMFMediaType**, int> GetAvailableDeviceMediaType;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, int> SetCurrentDeviceMediaType;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType**, int> GetCurrentDeviceMediaType;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDeviceStreamCount;
        [NativeTypeName("HRESULT (DWORD, MF_CAPTURE_ENGINE_STREAM_CATEGORY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, MF_CAPTURE_ENGINE_STREAM_CATEGORY*, int> GetDeviceStreamCategory;
        [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> GetMirrorState;
        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, int> SetMirrorState;
        [NativeTypeName("HRESULT (UINT32, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetStreamIndexFromFriendlyName;
    }
}