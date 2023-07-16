// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFContentEnabler.xml' path='doc/member[@name="IMFContentEnabler"]/*'/>
[Guid("D3C4EF59-49CE-4381-9071-D5BCD044C770")]
[NativeTypeName("struct IMFContentEnabler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFContentEnabler : IMFContentEnabler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentEnabler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFContentEnabler*, Guid*, void**, int> )(lpVtbl[0]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentEnabler*, uint> )(lpVtbl[1]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentEnabler*, uint> )(lpVtbl[2]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFContentEnabler.xml' path='doc/member[@name="IMFContentEnabler.GetEnableType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEnableType(Guid* pType)
    {
        return ((delegate* unmanaged<IMFContentEnabler*, Guid*, int> )(lpVtbl[3]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), pType);
    }

    /// <include file='IMFContentEnabler.xml' path='doc/member[@name="IMFContentEnabler.GetEnableURL"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEnableURL([NativeTypeName("LPWSTR *")] ushort** ppwszURL, [NativeTypeName("DWORD *")] uint* pcchURL, MF_URL_TRUST_STATUS* pTrustStatus)
    {
        return ((delegate* unmanaged<IMFContentEnabler*, ushort**, uint*, MF_URL_TRUST_STATUS*, int> )(lpVtbl[4]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), ppwszURL, pcchURL, pTrustStatus);
    }

    /// <include file='IMFContentEnabler.xml' path='doc/member[@name="IMFContentEnabler.GetEnableData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEnableData(byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData)
    {
        return ((delegate* unmanaged<IMFContentEnabler*, byte**, uint*, int> )(lpVtbl[5]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), ppbData, pcbData);
    }

    /// <include file='IMFContentEnabler.xml' path='doc/member[@name="IMFContentEnabler.IsAutomaticSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsAutomaticSupported(BOOL* pfAutomatic)
    {
        return ((delegate* unmanaged<IMFContentEnabler*, BOOL*, int> )(lpVtbl[6]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), pfAutomatic);
    }

    /// <include file='IMFContentEnabler.xml' path='doc/member[@name="IMFContentEnabler.AutomaticEnable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AutomaticEnable()
    {
        return ((delegate* unmanaged<IMFContentEnabler*, int> )(lpVtbl[7]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFContentEnabler.xml' path='doc/member[@name="IMFContentEnabler.MonitorEnable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MonitorEnable()
    {
        return ((delegate* unmanaged<IMFContentEnabler*, int> )(lpVtbl[8]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFContentEnabler.xml' path='doc/member[@name="IMFContentEnabler.Cancel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Cancel()
    {
        return ((delegate* unmanaged<IMFContentEnabler*, int> )(lpVtbl[9]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEnableType(Guid* pType);
        [VtblIndex(4)]
        HRESULT GetEnableURL([NativeTypeName("LPWSTR *")] ushort** ppwszURL, [NativeTypeName("DWORD *")] uint* pcchURL, MF_URL_TRUST_STATUS* pTrustStatus);
        [VtblIndex(5)]
        HRESULT GetEnableData(byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData);
        [VtblIndex(6)]
        HRESULT IsAutomaticSupported(BOOL* pfAutomatic);
        [VtblIndex(7)]
        HRESULT AutomaticEnable();
        [VtblIndex(8)]
        HRESULT MonitorEnable();
        [VtblIndex(9)]
        HRESULT Cancel();
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
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetEnableType;
        [NativeTypeName("HRESULT (LPWSTR *, DWORD *, MF_URL_TRUST_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, MF_URL_TRUST_STATUS*, int> GetEnableURL;
        [NativeTypeName("HRESULT (BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetEnableData;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsAutomaticSupported;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> AutomaticEnable;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MonitorEnable;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Cancel;
    }
}