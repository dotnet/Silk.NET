// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext"]/*'/>
[Guid("79EAC9C7-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IHlinkBrowseContext : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHlinkBrowseContext : IHlinkBrowseContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHlinkBrowseContext));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, Guid*, void**, int> )(lpVtbl[0]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint> )(lpVtbl[1]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint> )(lpVtbl[2]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.Register"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Register([NativeTypeName("DWORD")] uint reserved, IUnknown* piunk, IMoniker* pimk, [NativeTypeName("DWORD *")] uint* pdwRegister)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint, IUnknown*, IMoniker*, uint*, int> )(lpVtbl[3]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), reserved, piunk, pimk, pdwRegister);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.GetObjectW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetObjectW(IMoniker* pimk, BOOL fBindIfRootRegistered, IUnknown** ppiunk)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, IMoniker*, BOOL, IUnknown**, int> )(lpVtbl[4]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), pimk, fBindIfRootRegistered, ppiunk);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.Revoke"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Revoke([NativeTypeName("DWORD")] uint dwRegister)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint, int> )(lpVtbl[5]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), dwRegister);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.SetBrowseWindowInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetBrowseWindowInfo(HLBWINFO* phlbwi)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, HLBWINFO*, int> )(lpVtbl[6]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), phlbwi);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.GetBrowseWindowInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetBrowseWindowInfo(HLBWINFO* phlbwi)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, HLBWINFO*, int> )(lpVtbl[7]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), phlbwi);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.SetInitialHlink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetInitialHlink(IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, IMoniker*, ushort*, ushort*, int> )(lpVtbl[8]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), pimkTarget, pwzLocation, pwzFriendlyName);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.OnNavigateHlink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnNavigateHlink([NativeTypeName("DWORD")] uint grfHLNF, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName, [NativeTypeName("ULONG *")] uint* puHLID)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint, IMoniker*, ushort*, ushort*, uint*, int> )(lpVtbl[9]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), grfHLNF, pimkTarget, pwzLocation, pwzFriendlyName, puHLID);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.UpdateHlink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT UpdateHlink([NativeTypeName("ULONG")] uint uHLID, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint, IMoniker*, ushort*, ushort*, int> )(lpVtbl[10]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), uHLID, pimkTarget, pwzLocation, pwzFriendlyName);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.EnumNavigationStack"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EnumNavigationStack([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint grfHLFNAMEF, IEnumHLITEM** ppienumhlitem)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint, uint, IEnumHLITEM**, int> )(lpVtbl[11]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), dwReserved, grfHLFNAMEF, ppienumhlitem);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.QueryHlink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT QueryHlink([NativeTypeName("DWORD")] uint grfHLQF, [NativeTypeName("ULONG")] uint uHLID)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint, uint, int> )(lpVtbl[12]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), grfHLQF, uHLID);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.GetHlink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetHlink([NativeTypeName("ULONG")] uint uHLID, IHlink** ppihl)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint, IHlink**, int> )(lpVtbl[13]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), uHLID, ppihl);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.SetCurrentHlink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetCurrentHlink([NativeTypeName("ULONG")] uint uHLID)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint, int> )(lpVtbl[14]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), uHLID);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Clone(IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppiunkObj)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, IUnknown*, Guid*, IUnknown**, int> )(lpVtbl[15]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), piunkOuter, riid, ppiunkObj);
    }

    /// <include file='IHlinkBrowseContext.xml' path='doc/member[@name="IHlinkBrowseContext.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Close([NativeTypeName("DWORD")] uint reserved)
    {
        return ((delegate* unmanaged<IHlinkBrowseContext*, uint, int> )(lpVtbl[16]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), reserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Register([NativeTypeName("DWORD")] uint reserved, IUnknown* piunk, IMoniker* pimk, [NativeTypeName("DWORD *")] uint* pdwRegister);
        [VtblIndex(4)]
        HRESULT GetObjectW(IMoniker* pimk, BOOL fBindIfRootRegistered, IUnknown** ppiunk);
        [VtblIndex(5)]
        HRESULT Revoke([NativeTypeName("DWORD")] uint dwRegister);
        [VtblIndex(6)]
        HRESULT SetBrowseWindowInfo(HLBWINFO* phlbwi);
        [VtblIndex(7)]
        HRESULT GetBrowseWindowInfo(HLBWINFO* phlbwi);
        [VtblIndex(8)]
        HRESULT SetInitialHlink(IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName);
        [VtblIndex(9)]
        HRESULT OnNavigateHlink([NativeTypeName("DWORD")] uint grfHLNF, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName, [NativeTypeName("ULONG *")] uint* puHLID);
        [VtblIndex(10)]
        HRESULT UpdateHlink([NativeTypeName("ULONG")] uint uHLID, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName);
        [VtblIndex(11)]
        HRESULT EnumNavigationStack([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint grfHLFNAMEF, IEnumHLITEM** ppienumhlitem);
        [VtblIndex(12)]
        HRESULT QueryHlink([NativeTypeName("DWORD")] uint grfHLQF, [NativeTypeName("ULONG")] uint uHLID);
        [VtblIndex(13)]
        HRESULT GetHlink([NativeTypeName("ULONG")] uint uHLID, IHlink** ppihl);
        [VtblIndex(14)]
        HRESULT SetCurrentHlink([NativeTypeName("ULONG")] uint uHLID);
        [VtblIndex(15)]
        HRESULT Clone(IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppiunkObj);
        [VtblIndex(16)]
        HRESULT Close([NativeTypeName("DWORD")] uint reserved);
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
        [NativeTypeName("HRESULT (DWORD, IUnknown *, IMoniker *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, IMoniker*, uint*, int> Register;
        [NativeTypeName("HRESULT (IMoniker *, BOOL, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, BOOL, IUnknown**, int> GetObjectW;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Revoke;
        [NativeTypeName("HRESULT (HLBWINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HLBWINFO*, int> SetBrowseWindowInfo;
        [NativeTypeName("HRESULT (HLBWINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HLBWINFO*, int> GetBrowseWindowInfo;
        [NativeTypeName("HRESULT (IMoniker *, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, ushort*, ushort*, int> SetInitialHlink;
        [NativeTypeName("HRESULT (DWORD, IMoniker *, LPCWSTR, LPCWSTR, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMoniker*, ushort*, ushort*, uint*, int> OnNavigateHlink;
        [NativeTypeName("HRESULT (ULONG, IMoniker *, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMoniker*, ushort*, ushort*, int> UpdateHlink;
        [NativeTypeName("HRESULT (DWORD, DWORD, IEnumHLITEM **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IEnumHLITEM**, int> EnumNavigationStack;
        [NativeTypeName("HRESULT (DWORD, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> QueryHlink;
        [NativeTypeName("HRESULT (ULONG, IHlink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IHlink**, int> GetHlink;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCurrentHlink;
        [NativeTypeName("HRESULT (IUnknown *, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, Guid*, IUnknown**, int> Clone;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Close;
    }
}