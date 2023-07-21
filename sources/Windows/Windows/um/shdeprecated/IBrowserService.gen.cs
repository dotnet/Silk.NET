// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService"]/*' />
[Guid("02BA3B52-0547-11D1-B833-00C04FC9B31F")]
[NativeTypeName("struct IBrowserService : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBrowserService : IBrowserService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBrowserService));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBrowserService*, Guid*, void**, int>)(lpVtbl[0]))((IBrowserService*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBrowserService*, uint>)(lpVtbl[1]))((IBrowserService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBrowserService*, uint>)(lpVtbl[2]))((IBrowserService*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetParentSite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetParentSite(IOleInPlaceSite** ppipsite)
    {
        return ((delegate* unmanaged<IBrowserService*, IOleInPlaceSite**, int>)(lpVtbl[3]))((IBrowserService*)Unsafe.AsPointer(ref this), ppipsite);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.SetTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTitle(IShellView* psv, [NativeTypeName("LPCWSTR")] ushort* pszName)
    {
        return ((delegate* unmanaged<IBrowserService*, IShellView*, ushort*, int>)(lpVtbl[4]))((IBrowserService*)Unsafe.AsPointer(ref this), psv, pszName);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTitle(IShellView* psv, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("DWORD")] uint cchName)
    {
        return ((delegate* unmanaged<IBrowserService*, IShellView*, ushort*, uint, int>)(lpVtbl[5]))((IBrowserService*)Unsafe.AsPointer(ref this), psv, pszName, cchName);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetOleObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOleObject(IOleObject** ppobjv)
    {
        return ((delegate* unmanaged<IBrowserService*, IOleObject**, int>)(lpVtbl[6]))((IBrowserService*)Unsafe.AsPointer(ref this), ppobjv);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetTravelLog"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTravelLog(ITravelLog** pptl)
    {
        return ((delegate* unmanaged<IBrowserService*, ITravelLog**, int>)(lpVtbl[7]))((IBrowserService*)Unsafe.AsPointer(ref this), pptl);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.ShowControlWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowControlWindow(uint id, BOOL fShow)
    {
        return ((delegate* unmanaged<IBrowserService*, uint, BOOL, int>)(lpVtbl[8]))((IBrowserService*)Unsafe.AsPointer(ref this), id, fShow);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.IsControlWindowShown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsControlWindowShown(uint id, BOOL* pfShown)
    {
        return ((delegate* unmanaged<IBrowserService*, uint, BOOL*, int>)(lpVtbl[9]))((IBrowserService*)Unsafe.AsPointer(ref this), id, pfShown);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.IEGetDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IEGetDisplayName([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] ushort* pwszName, uint uFlags)
    {
        return ((delegate* unmanaged<IBrowserService*, ITEMIDLIST*, ushort*, uint, int>)(lpVtbl[10]))((IBrowserService*)Unsafe.AsPointer(ref this), pidl, pwszName, uFlags);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.IEParseDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IEParseDisplayName(uint uiCP, [NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
    {
        return ((delegate* unmanaged<IBrowserService*, uint, ushort*, ITEMIDLIST**, int>)(lpVtbl[11]))((IBrowserService*)Unsafe.AsPointer(ref this), uiCP, pwszPath, ppidlOut);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.DisplayParseError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DisplayParseError(HRESULT hres, [NativeTypeName("LPCWSTR")] ushort* pwszPath)
    {
        return ((delegate* unmanaged<IBrowserService*, HRESULT, ushort*, int>)(lpVtbl[12]))((IBrowserService*)Unsafe.AsPointer(ref this), hres, pwszPath);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.NavigateToPidl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF)
    {
        return ((delegate* unmanaged<IBrowserService*, ITEMIDLIST*, uint, int>)(lpVtbl[13]))((IBrowserService*)Unsafe.AsPointer(ref this), pidl, grfHLNF);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.SetNavigateState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetNavigateState(BNSTATE bnstate)
    {
        return ((delegate* unmanaged<IBrowserService*, BNSTATE, int>)(lpVtbl[14]))((IBrowserService*)Unsafe.AsPointer(ref this), bnstate);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetNavigateState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetNavigateState(BNSTATE* pbnstate)
    {
        return ((delegate* unmanaged<IBrowserService*, BNSTATE*, int>)(lpVtbl[15]))((IBrowserService*)Unsafe.AsPointer(ref this), pbnstate);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.NotifyRedirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT NotifyRedirect(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, BOOL* pfDidBrowse)
    {
        return ((delegate* unmanaged<IBrowserService*, IShellView*, ITEMIDLIST*, BOOL*, int>)(lpVtbl[16]))((IBrowserService*)Unsafe.AsPointer(ref this), psv, pidl, pfDidBrowse);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.UpdateWindowList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UpdateWindowList()
    {
        return ((delegate* unmanaged<IBrowserService*, int>)(lpVtbl[17]))((IBrowserService*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.UpdateBackForwardState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT UpdateBackForwardState()
    {
        return ((delegate* unmanaged<IBrowserService*, int>)(lpVtbl[18]))((IBrowserService*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.SetFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetFlags([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwFlagMask)
    {
        return ((delegate* unmanaged<IBrowserService*, uint, uint, int>)(lpVtbl[19]))((IBrowserService*)Unsafe.AsPointer(ref this), dwFlags, dwFlagMask);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IBrowserService*, uint*, int>)(lpVtbl[20]))((IBrowserService*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.CanNavigateNow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CanNavigateNow()
    {
        return ((delegate* unmanaged<IBrowserService*, int>)(lpVtbl[21]))((IBrowserService*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetPidl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetPidl([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<IBrowserService*, ITEMIDLIST**, int>)(lpVtbl[22]))((IBrowserService*)Unsafe.AsPointer(ref this), ppidl);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.SetReferrer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetReferrer([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<IBrowserService*, ITEMIDLIST*, int>)(lpVtbl[23]))((IBrowserService*)Unsafe.AsPointer(ref this), pidl);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetBrowserIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [return: NativeTypeName("DWORD")]
    public uint GetBrowserIndex()
    {
        return ((delegate* unmanaged<IBrowserService*, uint>)(lpVtbl[24]))((IBrowserService*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetBrowserByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetBrowserByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IBrowserService*, uint, IUnknown**, int>)(lpVtbl[25]))((IBrowserService*)Unsafe.AsPointer(ref this), dwID, ppunk);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetHistoryObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetHistoryObject(IOleObject** ppole, IStream** pstm, IBindCtx** ppbc)
    {
        return ((delegate* unmanaged<IBrowserService*, IOleObject**, IStream**, IBindCtx**, int>)(lpVtbl[26]))((IBrowserService*)Unsafe.AsPointer(ref this), ppole, pstm, ppbc);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.SetHistoryObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetHistoryObject(IOleObject* pole, BOOL fIsLocalAnchor)
    {
        return ((delegate* unmanaged<IBrowserService*, IOleObject*, BOOL, int>)(lpVtbl[27]))((IBrowserService*)Unsafe.AsPointer(ref this), pole, fIsLocalAnchor);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.CacheOLEServer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CacheOLEServer(IOleObject* pole)
    {
        return ((delegate* unmanaged<IBrowserService*, IOleObject*, int>)(lpVtbl[28]))((IBrowserService*)Unsafe.AsPointer(ref this), pole);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetSetCodePage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetSetCodePage(VARIANT* pvarIn, VARIANT* pvarOut)
    {
        return ((delegate* unmanaged<IBrowserService*, VARIANT*, VARIANT*, int>)(lpVtbl[29]))((IBrowserService*)Unsafe.AsPointer(ref this), pvarIn, pvarOut);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.OnHttpEquiv"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT OnHttpEquiv(IShellView* psv, BOOL fDone, VARIANT* pvarargIn, VARIANT* pvarargOut)
    {
        return ((delegate* unmanaged<IBrowserService*, IShellView*, BOOL, VARIANT*, VARIANT*, int>)(lpVtbl[30]))((IBrowserService*)Unsafe.AsPointer(ref this), psv, fDone, pvarargIn, pvarargOut);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.GetPalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetPalette(HPALETTE* hpal)
    {
        return ((delegate* unmanaged<IBrowserService*, HPALETTE*, int>)(lpVtbl[31]))((IBrowserService*)Unsafe.AsPointer(ref this), hpal);
    }

    /// <include file='IBrowserService.xml' path='doc/member[@name="IBrowserService.RegisterWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT RegisterWindow(BOOL fForceRegister, int swc)
    {
        return ((delegate* unmanaged<IBrowserService*, BOOL, int, int>)(lpVtbl[32]))((IBrowserService*)Unsafe.AsPointer(ref this), fForceRegister, swc);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetParentSite(IOleInPlaceSite** ppipsite);

        [VtblIndex(4)]
        HRESULT SetTitle(IShellView* psv, [NativeTypeName("LPCWSTR")] ushort* pszName);

        [VtblIndex(5)]
        HRESULT GetTitle(IShellView* psv, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("DWORD")] uint cchName);

        [VtblIndex(6)]
        HRESULT GetOleObject(IOleObject** ppobjv);

        [VtblIndex(7)]
        HRESULT GetTravelLog(ITravelLog** pptl);

        [VtblIndex(8)]
        HRESULT ShowControlWindow(uint id, BOOL fShow);

        [VtblIndex(9)]
        HRESULT IsControlWindowShown(uint id, BOOL* pfShown);

        [VtblIndex(10)]
        HRESULT IEGetDisplayName([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] ushort* pwszName, uint uFlags);

        [VtblIndex(11)]
        HRESULT IEParseDisplayName(uint uiCP, [NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut);

        [VtblIndex(12)]
        HRESULT DisplayParseError(HRESULT hres, [NativeTypeName("LPCWSTR")] ushort* pwszPath);

        [VtblIndex(13)]
        HRESULT NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF);

        [VtblIndex(14)]
        HRESULT SetNavigateState(BNSTATE bnstate);

        [VtblIndex(15)]
        HRESULT GetNavigateState(BNSTATE* pbnstate);

        [VtblIndex(16)]
        HRESULT NotifyRedirect(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, BOOL* pfDidBrowse);

        [VtblIndex(17)]
        HRESULT UpdateWindowList();

        [VtblIndex(18)]
        HRESULT UpdateBackForwardState();

        [VtblIndex(19)]
        HRESULT SetFlags([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwFlagMask);

        [VtblIndex(20)]
        HRESULT GetFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(21)]
        HRESULT CanNavigateNow();

        [VtblIndex(22)]
        HRESULT GetPidl([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);

        [VtblIndex(23)]
        HRESULT SetReferrer([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [VtblIndex(24)]
        [return: NativeTypeName("DWORD")]
        uint GetBrowserIndex();

        [VtblIndex(25)]
        HRESULT GetBrowserByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk);

        [VtblIndex(26)]
        HRESULT GetHistoryObject(IOleObject** ppole, IStream** pstm, IBindCtx** ppbc);

        [VtblIndex(27)]
        HRESULT SetHistoryObject(IOleObject* pole, BOOL fIsLocalAnchor);

        [VtblIndex(28)]
        HRESULT CacheOLEServer(IOleObject* pole);

        [VtblIndex(29)]
        HRESULT GetSetCodePage(VARIANT* pvarIn, VARIANT* pvarOut);

        [VtblIndex(30)]
        HRESULT OnHttpEquiv(IShellView* psv, BOOL fDone, VARIANT* pvarargIn, VARIANT* pvarargOut);

        [VtblIndex(31)]
        HRESULT GetPalette(HPALETTE* hpal);

        [VtblIndex(32)]
        HRESULT RegisterWindow(BOOL fForceRegister, int swc);
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

        [NativeTypeName("HRESULT (IOleInPlaceSite **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleInPlaceSite**, int> GetParentSite;

        [NativeTypeName("HRESULT (IShellView *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView*, ushort*, int> SetTitle;

        [NativeTypeName("HRESULT (IShellView *, LPWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView*, ushort*, uint, int> GetTitle;

        [NativeTypeName("HRESULT (IOleObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleObject**, int> GetOleObject;

        [NativeTypeName("HRESULT (ITravelLog **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITravelLog**, int> GetTravelLog;

        [NativeTypeName("HRESULT (UINT, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, int> ShowControlWindow;

        [NativeTypeName("HRESULT (UINT, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> IsControlWindowShown;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, LPWSTR, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, ushort*, uint, int> IEGetDisplayName;

        [NativeTypeName("HRESULT (UINT, LPCWSTR, LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, ITEMIDLIST**, int> IEParseDisplayName;

        [NativeTypeName("HRESULT (HRESULT, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, ushort*, int> DisplayParseError;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, uint, int> NavigateToPidl;

        [NativeTypeName("HRESULT (BNSTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BNSTATE, int> SetNavigateState;

        [NativeTypeName("HRESULT (BNSTATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BNSTATE*, int> GetNavigateState;

        [NativeTypeName("HRESULT (IShellView *, LPCITEMIDLIST, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView*, ITEMIDLIST*, BOOL*, int> NotifyRedirect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UpdateWindowList;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UpdateBackForwardState;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetFlags;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFlags;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CanNavigateNow;

        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetPidl;

        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> SetReferrer;

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetBrowserIndex;

        [NativeTypeName("HRESULT (DWORD, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown**, int> GetBrowserByIndex;

        [NativeTypeName("HRESULT (IOleObject **, IStream **, IBindCtx **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleObject**, IStream**, IBindCtx**, int> GetHistoryObject;

        [NativeTypeName("HRESULT (IOleObject *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleObject*, BOOL, int> SetHistoryObject;

        [NativeTypeName("HRESULT (IOleObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleObject*, int> CacheOLEServer;

        [NativeTypeName("HRESULT (VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, VARIANT*, int> GetSetCodePage;

        [NativeTypeName("HRESULT (IShellView *, BOOL, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView*, BOOL, VARIANT*, VARIANT*, int> OnHttpEquiv;

        [NativeTypeName("HRESULT (HPALETTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HPALETTE*, int> GetPalette;

        [NativeTypeName("HRESULT (BOOL, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int, int> RegisterWindow;
    }
}
