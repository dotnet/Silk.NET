// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFCaptureEngineOnSampleCallback.xml' path='doc/member[@name="IMFCaptureEngineOnSampleCallback"]/*'/>
[Guid("52150B82-AB39-4467-980F-E48BF0822ECD")]
[NativeTypeName("struct IMFCaptureEngineOnSampleCallback : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFCaptureEngineOnSampleCallback : IMFCaptureEngineOnSampleCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCaptureEngineOnSampleCallback));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback*, Guid*, void**, int> )(lpVtbl[0]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback*, uint> )(lpVtbl[1]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback*, uint> )(lpVtbl[2]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCaptureEngineOnSampleCallback.xml' path='doc/member[@name="IMFCaptureEngineOnSampleCallback.OnSample"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnSample(IMFSample* pSample)
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback*, IMFSample*, int> )(lpVtbl[3]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this), pSample);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnSample(IMFSample* pSample);
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
    }
}