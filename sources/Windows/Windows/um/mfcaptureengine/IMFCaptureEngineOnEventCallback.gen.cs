// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFCaptureEngineOnEventCallback.xml' path='doc/member[@name="IMFCaptureEngineOnEventCallback"]/*'/>
[Guid("AEDA51C0-9025-4983-9012-DE597B88B089")]
[NativeTypeName("struct IMFCaptureEngineOnEventCallback : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFCaptureEngineOnEventCallback : IMFCaptureEngineOnEventCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCaptureEngineOnEventCallback));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnEventCallback*, Guid*, void**, int> )(lpVtbl[0]))((IMFCaptureEngineOnEventCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnEventCallback*, uint> )(lpVtbl[1]))((IMFCaptureEngineOnEventCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnEventCallback*, uint> )(lpVtbl[2]))((IMFCaptureEngineOnEventCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCaptureEngineOnEventCallback.xml' path='doc/member[@name="IMFCaptureEngineOnEventCallback.OnEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnEvent(IMFMediaEvent* pEvent)
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnEventCallback*, IMFMediaEvent*, int> )(lpVtbl[3]))((IMFCaptureEngineOnEventCallback*)Unsafe.AsPointer(ref this), pEvent);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnEvent(IMFMediaEvent* pEvent);
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
        [NativeTypeName("HRESULT (IMFMediaEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaEvent*, int> OnEvent;
    }
}