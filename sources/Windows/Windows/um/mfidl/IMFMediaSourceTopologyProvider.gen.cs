// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFMediaSourceTopologyProvider.xml' path='doc/member[@name="IMFMediaSourceTopologyProvider"]/*'/>
[Guid("0E1D6009-C9F3-442D-8C51-A42D2D49452F")]
[NativeTypeName("struct IMFMediaSourceTopologyProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaSourceTopologyProvider : IMFMediaSourceTopologyProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaSourceTopologyProvider));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSourceTopologyProvider*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSourceTopologyProvider*, uint> )(lpVtbl[1]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSourceTopologyProvider*, uint> )(lpVtbl[2]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSourceTopologyProvider.xml' path='doc/member[@name="IMFMediaSourceTopologyProvider.GetMediaSourceTopology"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMediaSourceTopology(IMFPresentationDescriptor* pPresentationDescriptor, IMFTopology** ppTopology)
    {
        return ((delegate* unmanaged<IMFMediaSourceTopologyProvider*, IMFPresentationDescriptor*, IMFTopology**, int> )(lpVtbl[3]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this), pPresentationDescriptor, ppTopology);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMediaSourceTopology(IMFPresentationDescriptor* pPresentationDescriptor, IMFTopology** ppTopology);
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
        [NativeTypeName("HRESULT (IMFPresentationDescriptor *, IMFTopology **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationDescriptor*, IMFTopology**, int> GetMediaSourceTopology;
    }
}