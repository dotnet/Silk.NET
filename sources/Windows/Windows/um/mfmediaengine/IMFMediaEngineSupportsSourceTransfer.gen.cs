// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFMediaEngineSupportsSourceTransfer.xml' path='doc/member[@name="IMFMediaEngineSupportsSourceTransfer"]/*'/>
[Guid("A724B056-1B2E-4642-A6F3-DB9420C52908")]
[NativeTypeName("struct IMFMediaEngineSupportsSourceTransfer : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFMediaEngineSupportsSourceTransfer : IMFMediaEngineSupportsSourceTransfer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineSupportsSourceTransfer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, uint> )(lpVtbl[1]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, uint> )(lpVtbl[2]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineSupportsSourceTransfer.xml' path='doc/member[@name="IMFMediaEngineSupportsSourceTransfer.ShouldTransferSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShouldTransferSource(BOOL* pfShouldTransfer)
    {
        return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, BOOL*, int> )(lpVtbl[3]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), pfShouldTransfer);
    }

    /// <include file='IMFMediaEngineSupportsSourceTransfer.xml' path='doc/member[@name="IMFMediaEngineSupportsSourceTransfer.DetachMediaSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DetachMediaSource(IMFByteStream** ppByteStream, IMFMediaSource** ppMediaSource, IMFMediaSourceExtension** ppMSE)
    {
        return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int> )(lpVtbl[4]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), ppByteStream, ppMediaSource, ppMSE);
    }

    /// <include file='IMFMediaEngineSupportsSourceTransfer.xml' path='doc/member[@name="IMFMediaEngineSupportsSourceTransfer.AttachMediaSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AttachMediaSource(IMFByteStream* pByteStream, IMFMediaSource* pMediaSource, IMFMediaSourceExtension* pMSE)
    {
        return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int> )(lpVtbl[5]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), pByteStream, pMediaSource, pMSE);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShouldTransferSource(BOOL* pfShouldTransfer);
        [VtblIndex(4)]
        HRESULT DetachMediaSource(IMFByteStream** ppByteStream, IMFMediaSource** ppMediaSource, IMFMediaSourceExtension** ppMSE);
        [VtblIndex(5)]
        HRESULT AttachMediaSource(IMFByteStream* pByteStream, IMFMediaSource* pMediaSource, IMFMediaSourceExtension* pMSE);
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
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> ShouldTransferSource;
        [NativeTypeName("HRESULT (IMFByteStream **, IMFMediaSource **, IMFMediaSourceExtension **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int> DetachMediaSource;
        [NativeTypeName("HRESULT (IMFByteStream *, IMFMediaSource *, IMFMediaSourceExtension *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int> AttachMediaSource;
    }
}