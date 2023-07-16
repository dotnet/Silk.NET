// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IInternetSecurityManagerEx2.xml' path='doc/member[@name="IInternetSecurityManagerEx2"]/*'/>
[Guid("F1E50292-A795-4117-8E09-2B560A72AC60")]
[NativeTypeName("struct IInternetSecurityManagerEx2 : IInternetSecurityManagerEx")]
[NativeInheritance("IInternetSecurityManagerEx")]
public unsafe partial struct IInternetSecurityManagerEx2 : IInternetSecurityManagerEx2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetSecurityManagerEx2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, Guid*, void**, int> )(lpVtbl[0]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, uint> )(lpVtbl[1]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, uint> )(lpVtbl[2]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInternetSecurityManager.SetSecuritySite"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSecuritySite(IInternetSecurityMgrSite* pSite)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, IInternetSecurityMgrSite*, int> )(lpVtbl[3]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pSite);
    }

    /// <inheritdoc cref = "IInternetSecurityManager.GetSecuritySite"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSecuritySite(IInternetSecurityMgrSite** ppSite)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, IInternetSecurityMgrSite**, int> )(lpVtbl[4]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), ppSite);
    }

    /// <inheritdoc cref = "IInternetSecurityManager.MapUrlToZone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MapUrlToZone([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, ushort*, uint*, uint, int> )(lpVtbl[5]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, pdwZone, dwFlags);
    }

    /// <inheritdoc cref = "IInternetSecurityManager.GetSecurityId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSecurityId([NativeTypeName("LPCWSTR")] ushort* pwszUrl, byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, ushort*, byte*, uint*, nuint, int> )(lpVtbl[6]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, pbSecurityId, pcbSecurityId, dwReserved);
    }

    /// <inheritdoc cref = "IInternetSecurityManager.ProcessUrlAction"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ProcessUrlAction([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, int> )(lpVtbl[7]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
    }

    /// <inheritdoc cref = "IInternetSecurityManager.QueryCustomPolicy"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT QueryCustomPolicy([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, ushort*, Guid*, byte**, uint*, byte*, uint, uint, int> )(lpVtbl[8]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
    }

    /// <inheritdoc cref = "IInternetSecurityManager.SetZoneMapping"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetZoneMapping([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("LPCWSTR")] ushort* lpszPattern, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, uint, ushort*, uint, int> )(lpVtbl[9]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), dwZone, lpszPattern, dwFlags);
    }

    /// <inheritdoc cref = "IInternetSecurityManager.GetZoneMappings"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetZoneMappings([NativeTypeName("DWORD")] uint dwZone, IEnumString** ppenumString, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, uint, IEnumString**, uint, int> )(lpVtbl[10]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), dwZone, ppenumString, dwFlags);
    }

    /// <inheritdoc cref = "IInternetSecurityManagerEx.ProcessUrlActionEx"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ProcessUrlActionEx([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, uint*, int> )(lpVtbl[11]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved, pdwOutFlags);
    }

    /// <include file='IInternetSecurityManagerEx2.xml' path='doc/member[@name="IInternetSecurityManagerEx2.MapUrlToZoneEx2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT MapUrlToZoneEx2(IUri* pUri, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR *")] ushort** ppwszMappedUrl, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, IUri*, uint*, uint, ushort**, uint*, int> )(lpVtbl[12]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, pdwZone, dwFlags, ppwszMappedUrl, pdwOutFlags);
    }

    /// <include file='IInternetSecurityManagerEx2.xml' path='doc/member[@name="IInternetSecurityManagerEx2.ProcessUrlActionEx2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ProcessUrlActionEx2(IUri* pUri, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, IUri*, uint, byte*, uint, byte*, uint, uint, nuint, uint*, int> )(lpVtbl[13]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved, pdwOutFlags);
    }

    /// <include file='IInternetSecurityManagerEx2.xml' path='doc/member[@name="IInternetSecurityManagerEx2.GetSecurityIdEx2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetSecurityIdEx2(IUri* pUri, byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, IUri*, byte*, uint*, nuint, int> )(lpVtbl[14]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, pbSecurityId, pcbSecurityId, dwReserved);
    }

    /// <include file='IInternetSecurityManagerEx2.xml' path='doc/member[@name="IInternetSecurityManagerEx2.QueryCustomPolicyEx2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT QueryCustomPolicyEx2(IUri* pUri, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
    {
        return ((delegate* unmanaged<IInternetSecurityManagerEx2*, IUri*, Guid*, byte**, uint*, byte*, uint, nuint, int> )(lpVtbl[15]))((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
    }

    public interface Interface : IInternetSecurityManagerEx.Interface
    {
        [VtblIndex(12)]
        HRESULT MapUrlToZoneEx2(IUri* pUri, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR *")] ushort** ppwszMappedUrl, [NativeTypeName("DWORD *")] uint* pdwOutFlags);
        [VtblIndex(13)]
        HRESULT ProcessUrlActionEx2(IUri* pUri, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags);
        [VtblIndex(14)]
        HRESULT GetSecurityIdEx2(IUri* pUri, byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved);
        [VtblIndex(15)]
        HRESULT QueryCustomPolicyEx2(IUri* pUri, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD_PTR")] nuint dwReserved);
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
        [NativeTypeName("HRESULT (IInternetSecurityMgrSite *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInternetSecurityMgrSite*, int> SetSecuritySite;
        [NativeTypeName("HRESULT (IInternetSecurityMgrSite **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInternetSecurityMgrSite**, int> GetSecuritySite;
        [NativeTypeName("HRESULT (LPCWSTR, DWORD *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, uint, int> MapUrlToZone;
        [NativeTypeName("HRESULT (LPCWSTR, BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, byte*, uint*, nuint, int> GetSecurityId;
        [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, int> ProcessUrlAction;
        [NativeTypeName("HRESULT (LPCWSTR, const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, byte**, uint*, byte*, uint, uint, int> QueryCustomPolicy;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int> SetZoneMapping;
        [NativeTypeName("HRESULT (DWORD, IEnumString **, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IEnumString**, uint, int> GetZoneMappings;
        [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, byte*, uint, byte*, uint, uint, uint, uint*, int> ProcessUrlActionEx;
        [NativeTypeName("HRESULT (IUri *, DWORD *, DWORD, LPWSTR *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUri*, uint*, uint, ushort**, uint*, int> MapUrlToZoneEx2;
        [NativeTypeName("HRESULT (IUri *, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD_PTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUri*, uint, byte*, uint, byte*, uint, uint, nuint, uint*, int> ProcessUrlActionEx2;
        [NativeTypeName("HRESULT (IUri *, BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUri*, byte*, uint*, nuint, int> GetSecurityIdEx2;
        [NativeTypeName("HRESULT (IUri *, const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUri*, Guid*, byte**, uint*, byte*, uint, nuint, int> QueryCustomPolicyEx2;
    }
}