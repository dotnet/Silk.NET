// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IBandSite.xml' path='doc/member[@name="IBandSite"]/*'/>
[Guid("4CF504B0-DE96-11D0-8B3F-00A0C911E8E5")]
[NativeTypeName("struct IBandSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBandSite : IBandSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBandSite));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBandSite*, Guid*, void**, int> )(lpVtbl[0]))((IBandSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBandSite*, uint> )(lpVtbl[1]))((IBandSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBandSite*, uint> )(lpVtbl[2]))((IBandSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBandSite.xml' path='doc/member[@name="IBandSite.AddBand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddBand(IUnknown* punk)
    {
        return ((delegate* unmanaged<IBandSite*, IUnknown*, int> )(lpVtbl[3]))((IBandSite*)Unsafe.AsPointer(ref this), punk);
    }

    /// <include file='IBandSite.xml' path='doc/member[@name="IBandSite.EnumBands"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumBands(uint uBand, [NativeTypeName("DWORD *")] uint* pdwBandID)
    {
        return ((delegate* unmanaged<IBandSite*, uint, uint*, int> )(lpVtbl[4]))((IBandSite*)Unsafe.AsPointer(ref this), uBand, pdwBandID);
    }

    /// <include file='IBandSite.xml' path='doc/member[@name="IBandSite.QueryBand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryBand([NativeTypeName("DWORD")] uint dwBandID, IDeskBand** ppstb, [NativeTypeName("DWORD *")] uint* pdwState, [NativeTypeName("LPWSTR")] ushort* pszName, int cchName)
    {
        return ((delegate* unmanaged<IBandSite*, uint, IDeskBand**, uint*, ushort*, int, int> )(lpVtbl[5]))((IBandSite*)Unsafe.AsPointer(ref this), dwBandID, ppstb, pdwState, pszName, cchName);
    }

    /// <include file='IBandSite.xml' path='doc/member[@name="IBandSite.SetBandState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetBandState([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwState)
    {
        return ((delegate* unmanaged<IBandSite*, uint, uint, uint, int> )(lpVtbl[6]))((IBandSite*)Unsafe.AsPointer(ref this), dwBandID, dwMask, dwState);
    }

    /// <include file='IBandSite.xml' path='doc/member[@name="IBandSite.RemoveBand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveBand([NativeTypeName("DWORD")] uint dwBandID)
    {
        return ((delegate* unmanaged<IBandSite*, uint, int> )(lpVtbl[7]))((IBandSite*)Unsafe.AsPointer(ref this), dwBandID);
    }

    /// <include file='IBandSite.xml' path='doc/member[@name="IBandSite.GetBandObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBandObject([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IBandSite*, uint, Guid*, void**, int> )(lpVtbl[8]))((IBandSite*)Unsafe.AsPointer(ref this), dwBandID, riid, ppv);
    }

    /// <include file='IBandSite.xml' path='doc/member[@name="IBandSite.SetBandSiteInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetBandSiteInfo([NativeTypeName("const BANDSITEINFO *")] BANDSITEINFO* pbsinfo)
    {
        return ((delegate* unmanaged<IBandSite*, BANDSITEINFO*, int> )(lpVtbl[9]))((IBandSite*)Unsafe.AsPointer(ref this), pbsinfo);
    }

    /// <include file='IBandSite.xml' path='doc/member[@name="IBandSite.GetBandSiteInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetBandSiteInfo(BANDSITEINFO* pbsinfo)
    {
        return ((delegate* unmanaged<IBandSite*, BANDSITEINFO*, int> )(lpVtbl[10]))((IBandSite*)Unsafe.AsPointer(ref this), pbsinfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddBand(IUnknown* punk);
        [VtblIndex(4)]
        HRESULT EnumBands(uint uBand, [NativeTypeName("DWORD *")] uint* pdwBandID);
        [VtblIndex(5)]
        HRESULT QueryBand([NativeTypeName("DWORD")] uint dwBandID, IDeskBand** ppstb, [NativeTypeName("DWORD *")] uint* pdwState, [NativeTypeName("LPWSTR")] ushort* pszName, int cchName);
        [VtblIndex(6)]
        HRESULT SetBandState([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwState);
        [VtblIndex(7)]
        HRESULT RemoveBand([NativeTypeName("DWORD")] uint dwBandID);
        [VtblIndex(8)]
        HRESULT GetBandObject([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(9)]
        HRESULT SetBandSiteInfo([NativeTypeName("const BANDSITEINFO *")] BANDSITEINFO* pbsinfo);
        [VtblIndex(10)]
        HRESULT GetBandSiteInfo(BANDSITEINFO* pbsinfo);
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
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> AddBand;
        [NativeTypeName("HRESULT (UINT, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> EnumBands;
        [NativeTypeName("HRESULT (DWORD, IDeskBand **, DWORD *, LPWSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDeskBand**, uint*, ushort*, int, int> QueryBand;
        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> SetBandState;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveBand;
        [NativeTypeName("HRESULT (DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetBandObject;
        [NativeTypeName("HRESULT (const BANDSITEINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BANDSITEINFO*, int> SetBandSiteInfo;
        [NativeTypeName("HRESULT (BANDSITEINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BANDSITEINFO*, int> GetBandSiteInfo;
    }
}