// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFOutputTrustAuthority.xml' path='doc/member[@name="IMFOutputTrustAuthority"]/*'/>
[Guid("D19F8E94-B126-4446-890C-5DCB7AD71453")]
[NativeTypeName("struct IMFOutputTrustAuthority : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFOutputTrustAuthority : IMFOutputTrustAuthority.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFOutputTrustAuthority));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFOutputTrustAuthority*, Guid*, void**, int> )(lpVtbl[0]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFOutputTrustAuthority*, uint> )(lpVtbl[1]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFOutputTrustAuthority*, uint> )(lpVtbl[2]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFOutputTrustAuthority.xml' path='doc/member[@name="IMFOutputTrustAuthority.GetAction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAction(MFPOLICYMANAGER_ACTION* pAction)
    {
        return ((delegate* unmanaged<IMFOutputTrustAuthority*, MFPOLICYMANAGER_ACTION*, int> )(lpVtbl[3]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this), pAction);
    }

    /// <include file='IMFOutputTrustAuthority.xml' path='doc/member[@name="IMFOutputTrustAuthority.SetPolicy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPolicy(IMFOutputPolicy** ppPolicy, [NativeTypeName("DWORD")] uint nPolicy, byte** ppbTicket, [NativeTypeName("DWORD *")] uint* pcbTicket)
    {
        return ((delegate* unmanaged<IMFOutputTrustAuthority*, IMFOutputPolicy**, uint, byte**, uint*, int> )(lpVtbl[4]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this), ppPolicy, nPolicy, ppbTicket, pcbTicket);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAction(MFPOLICYMANAGER_ACTION* pAction);
        [VtblIndex(4)]
        HRESULT SetPolicy(IMFOutputPolicy** ppPolicy, [NativeTypeName("DWORD")] uint nPolicy, byte** ppbTicket, [NativeTypeName("DWORD *")] uint* pcbTicket);
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
        [NativeTypeName("HRESULT (MFPOLICYMANAGER_ACTION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFPOLICYMANAGER_ACTION*, int> GetAction;
        [NativeTypeName("HRESULT (IMFOutputPolicy **, DWORD, BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFOutputPolicy**, uint, byte**, uint*, int> SetPolicy;
    }
}