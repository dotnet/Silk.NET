// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IClientSecurity.xml' path='doc/member[@name="IClientSecurity"]/*' />
[Guid("0000013D-0000-0000-C000-000000000046")]
[NativeTypeName("struct IClientSecurity : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IClientSecurity : IClientSecurity.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IClientSecurity));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IClientSecurity*, Guid*, void**, int>)(lpVtbl[0]))((IClientSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IClientSecurity*, uint>)(lpVtbl[1]))((IClientSecurity*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IClientSecurity*, uint>)(lpVtbl[2]))((IClientSecurity*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IClientSecurity.xml' path='doc/member[@name="IClientSecurity.QueryBlanket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryBlanket(IUnknown* pProxy, [NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("OLECHAR **")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, void** pAuthInfo, [NativeTypeName("DWORD *")] uint* pCapabilites)
    {
        return ((delegate* unmanaged<IClientSecurity*, IUnknown*, uint*, uint*, ushort**, uint*, uint*, void**, uint*, int>)(lpVtbl[3]))((IClientSecurity*)Unsafe.AsPointer(ref this), pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
    }

    /// <include file='IClientSecurity.xml' path='doc/member[@name="IClientSecurity.SetBlanket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetBlanket(IUnknown* pProxy, [NativeTypeName("DWORD")] uint dwAuthnSvc, [NativeTypeName("DWORD")] uint dwAuthzSvc, [NativeTypeName("OLECHAR *")] ushort* pServerPrincName, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, void* pAuthInfo, [NativeTypeName("DWORD")] uint dwCapabilities)
    {
        return ((delegate* unmanaged<IClientSecurity*, IUnknown*, uint, uint, ushort*, uint, uint, void*, uint, int>)(lpVtbl[4]))((IClientSecurity*)Unsafe.AsPointer(ref this), pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
    }

    /// <include file='IClientSecurity.xml' path='doc/member[@name="IClientSecurity.CopyProxy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CopyProxy(IUnknown* pProxy, IUnknown** ppCopy)
    {
        return ((delegate* unmanaged<IClientSecurity*, IUnknown*, IUnknown**, int>)(lpVtbl[5]))((IClientSecurity*)Unsafe.AsPointer(ref this), pProxy, ppCopy);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryBlanket(IUnknown* pProxy, [NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("OLECHAR **")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, void** pAuthInfo, [NativeTypeName("DWORD *")] uint* pCapabilites);

        [VtblIndex(4)]
        HRESULT SetBlanket(IUnknown* pProxy, [NativeTypeName("DWORD")] uint dwAuthnSvc, [NativeTypeName("DWORD")] uint dwAuthzSvc, [NativeTypeName("OLECHAR *")] ushort* pServerPrincName, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, void* pAuthInfo, [NativeTypeName("DWORD")] uint dwCapabilities);

        [VtblIndex(5)]
        HRESULT CopyProxy(IUnknown* pProxy, IUnknown** ppCopy);
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

        [NativeTypeName("HRESULT (IUnknown *, DWORD *, DWORD *, OLECHAR **, DWORD *, DWORD *, void **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint*, uint*, ushort**, uint*, uint*, void**, uint*, int> QueryBlanket;

        [NativeTypeName("HRESULT (IUnknown *, DWORD, DWORD, OLECHAR *, DWORD, DWORD, void *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint, uint, ushort*, uint, uint, void*, uint, int> SetBlanket;

        [NativeTypeName("HRESULT (IUnknown *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IUnknown**, int> CopyProxy;
    }
}
