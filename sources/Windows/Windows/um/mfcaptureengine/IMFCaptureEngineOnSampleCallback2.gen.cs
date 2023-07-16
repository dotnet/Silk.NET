// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFCaptureEngineOnSampleCallback2.xml' path='doc/member[@name="IMFCaptureEngineOnSampleCallback2"]/*'/>
[Guid("E37CEED7-340F-4514-9F4D-9C2AE026100B")]
[NativeTypeName("struct IMFCaptureEngineOnSampleCallback2 : IMFCaptureEngineOnSampleCallback")]
[NativeInheritance("IMFCaptureEngineOnSampleCallback")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFCaptureEngineOnSampleCallback2 : IMFCaptureEngineOnSampleCallback2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCaptureEngineOnSampleCallback2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2*, Guid*, void**, int> )(lpVtbl[0]))((IMFCaptureEngineOnSampleCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2*, uint> )(lpVtbl[1]))((IMFCaptureEngineOnSampleCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2*, uint> )(lpVtbl[2]))((IMFCaptureEngineOnSampleCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFCaptureEngineOnSampleCallback.OnSample"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnSample(IMFSample* pSample)
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2*, IMFSample*, int> )(lpVtbl[3]))((IMFCaptureEngineOnSampleCallback2*)Unsafe.AsPointer(ref this), pSample);
    }

    /// <include file='IMFCaptureEngineOnSampleCallback2.xml' path='doc/member[@name="IMFCaptureEngineOnSampleCallback2.OnSynchronizedEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnSynchronizedEvent(IMFMediaEvent* pEvent)
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2*, IMFMediaEvent*, int> )(lpVtbl[4]))((IMFCaptureEngineOnSampleCallback2*)Unsafe.AsPointer(ref this), pEvent);
    }

    public interface Interface : IMFCaptureEngineOnSampleCallback.Interface
    {
        [VtblIndex(4)]
        HRESULT OnSynchronizedEvent(IMFMediaEvent* pEvent);
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
        [NativeTypeName("HRESULT (IMFSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSample*, int> OnSample;
        [NativeTypeName("HRESULT (IMFMediaEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaEvent*, int> OnSynchronizedEvent;
    }
}