// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFSequencerSource.xml' path='doc/member[@name="IMFSequencerSource"]/*'/>
[Guid("197CD219-19CB-4DE1-A64C-ACF2EDCBE59E")]
[NativeTypeName("struct IMFSequencerSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSequencerSource : IMFSequencerSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSequencerSource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSequencerSource*, Guid*, void**, int> )(lpVtbl[0]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSequencerSource*, uint> )(lpVtbl[1]))((IMFSequencerSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSequencerSource*, uint> )(lpVtbl[2]))((IMFSequencerSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSequencerSource.xml' path='doc/member[@name="IMFSequencerSource.AppendTopology"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AppendTopology(IMFTopology* pTopology, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("MFSequencerElementId *")] uint* pdwId)
    {
        return ((delegate* unmanaged<IMFSequencerSource*, IMFTopology*, uint, uint*, int> )(lpVtbl[3]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), pTopology, dwFlags, pdwId);
    }

    /// <include file='IMFSequencerSource.xml' path='doc/member[@name="IMFSequencerSource.DeleteTopology"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DeleteTopology([NativeTypeName("MFSequencerElementId")] uint dwId)
    {
        return ((delegate* unmanaged<IMFSequencerSource*, uint, int> )(lpVtbl[4]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), dwId);
    }

    /// <include file='IMFSequencerSource.xml' path='doc/member[@name="IMFSequencerSource.GetPresentationContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPresentationContext(IMFPresentationDescriptor* pPD, [NativeTypeName("MFSequencerElementId *")] uint* pId, IMFTopology** ppTopology)
    {
        return ((delegate* unmanaged<IMFSequencerSource*, IMFPresentationDescriptor*, uint*, IMFTopology**, int> )(lpVtbl[5]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), pPD, pId, ppTopology);
    }

    /// <include file='IMFSequencerSource.xml' path='doc/member[@name="IMFSequencerSource.UpdateTopology"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UpdateTopology([NativeTypeName("MFSequencerElementId")] uint dwId, IMFTopology* pTopology)
    {
        return ((delegate* unmanaged<IMFSequencerSource*, uint, IMFTopology*, int> )(lpVtbl[6]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), dwId, pTopology);
    }

    /// <include file='IMFSequencerSource.xml' path='doc/member[@name="IMFSequencerSource.UpdateTopologyFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateTopologyFlags([NativeTypeName("MFSequencerElementId")] uint dwId, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IMFSequencerSource*, uint, uint, int> )(lpVtbl[7]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), dwId, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AppendTopology(IMFTopology* pTopology, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("MFSequencerElementId *")] uint* pdwId);
        [VtblIndex(4)]
        HRESULT DeleteTopology([NativeTypeName("MFSequencerElementId")] uint dwId);
        [VtblIndex(5)]
        HRESULT GetPresentationContext(IMFPresentationDescriptor* pPD, [NativeTypeName("MFSequencerElementId *")] uint* pId, IMFTopology** ppTopology);
        [VtblIndex(6)]
        HRESULT UpdateTopology([NativeTypeName("MFSequencerElementId")] uint dwId, IMFTopology* pTopology);
        [VtblIndex(7)]
        HRESULT UpdateTopologyFlags([NativeTypeName("MFSequencerElementId")] uint dwId, [NativeTypeName("DWORD")] uint dwFlags);
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
        [NativeTypeName("HRESULT (IMFTopology *, DWORD, MFSequencerElementId *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTopology*, uint, uint*, int> AppendTopology;
        [NativeTypeName("HRESULT (MFSequencerElementId) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DeleteTopology;
        [NativeTypeName("HRESULT (IMFPresentationDescriptor *, MFSequencerElementId *, IMFTopology **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationDescriptor*, uint*, IMFTopology**, int> GetPresentationContext;
        [NativeTypeName("HRESULT (MFSequencerElementId, IMFTopology *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFTopology*, int> UpdateTopology;
        [NativeTypeName("HRESULT (MFSequencerElementId, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> UpdateTopologyFlags;
    }
}