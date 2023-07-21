// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITrackShellMenu.xml' path='doc/member[@name="ITrackShellMenu"]/*' />
[Guid("8278F932-2A3E-11D2-838F-00C04FD918D0")]
[NativeTypeName("struct ITrackShellMenu : IShellMenu")]
[NativeInheritance("IShellMenu")]
public unsafe partial struct ITrackShellMenu : ITrackShellMenu.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITrackShellMenu));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, Guid*, void**, int>)(lpVtbl[0]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITrackShellMenu*, uint>)(lpVtbl[1]))((ITrackShellMenu*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITrackShellMenu*, uint>)(lpVtbl[2]))((ITrackShellMenu*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellMenu.Initialize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IShellMenuCallback* psmc, uint uId, uint uIdAncestor, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, IShellMenuCallback*, uint, uint, uint, int>)(lpVtbl[3]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), psmc, uId, uIdAncestor, dwFlags);
    }

    /// <inheritdoc cref="IShellMenu.GetMenuInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMenuInfo(IShellMenuCallback** ppsmc, uint* puId, uint* puIdAncestor, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, IShellMenuCallback**, uint*, uint*, uint*, int>)(lpVtbl[4]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), ppsmc, puId, puIdAncestor, pdwFlags);
    }

    /// <inheritdoc cref="IShellMenu.SetShellFolder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetShellFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, HKEY hKey, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, IShellFolder*, ITEMIDLIST*, HKEY, uint, int>)(lpVtbl[5]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), psf, pidlFolder, hKey, dwFlags);
    }

    /// <inheritdoc cref="IShellMenu.GetShellFolder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetShellFolder([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, uint*, ITEMIDLIST**, Guid*, void**, int>)(lpVtbl[6]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), pdwFlags, ppidl, riid, ppv);
    }

    /// <inheritdoc cref="IShellMenu.SetMenu" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMenu(HMENU hmenu, HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, HMENU, HWND, uint, int>)(lpVtbl[7]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), hmenu, hwnd, dwFlags);
    }

    /// <inheritdoc cref="IShellMenu.GetMenu" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMenu(HMENU* phmenu, HWND* phwnd, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, HMENU*, HWND*, uint*, int>)(lpVtbl[8]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), phmenu, phwnd, pdwFlags);
    }

    /// <inheritdoc cref="IShellMenu.InvalidateItem" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InvalidateItem([NativeTypeName("LPSMDATA")] SMDATA* psmd, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, SMDATA*, uint, int>)(lpVtbl[9]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), psmd, dwFlags);
    }

    /// <inheritdoc cref="IShellMenu.GetState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetState([NativeTypeName("LPSMDATA")] SMDATA* psmd)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, SMDATA*, int>)(lpVtbl[10]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), psmd);
    }

    /// <inheritdoc cref="IShellMenu.SetMenuToolbar" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetMenuToolbar(IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, IUnknown*, uint, int>)(lpVtbl[11]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), punk, dwFlags);
    }

    /// <include file='ITrackShellMenu.xml' path='doc/member[@name="ITrackShellMenu.SetObscured"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetObscured(HWND hwndTB, IUnknown* punkBand, [NativeTypeName("DWORD")] uint dwSMSetFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, HWND, IUnknown*, uint, int>)(lpVtbl[12]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), hwndTB, punkBand, dwSMSetFlags);
    }

    /// <include file='ITrackShellMenu.xml' path='doc/member[@name="ITrackShellMenu.Popup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Popup(HWND hwnd, POINTL* ppt, RECTL* prcExclude, [NativeTypeName("MP_POPUPFLAGS")] int dwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu*, HWND, POINTL*, RECTL*, int, int>)(lpVtbl[13]))((ITrackShellMenu*)Unsafe.AsPointer(ref this), hwnd, ppt, prcExclude, dwFlags);
    }

    public interface Interface : IShellMenu.Interface
    {
        [VtblIndex(12)]
        HRESULT SetObscured(HWND hwndTB, IUnknown* punkBand, [NativeTypeName("DWORD")] uint dwSMSetFlags);

        [VtblIndex(13)]
        HRESULT Popup(HWND hwnd, POINTL* ppt, RECTL* prcExclude, [NativeTypeName("MP_POPUPFLAGS")] int dwFlags);
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

        [NativeTypeName("HRESULT (IShellMenuCallback *, UINT, UINT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellMenuCallback*, uint, uint, uint, int> Initialize;

        [NativeTypeName("HRESULT (IShellMenuCallback **, UINT *, UINT *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellMenuCallback**, uint*, uint*, uint*, int> GetMenuInfo;

        [NativeTypeName("HRESULT (IShellFolder *, LPCITEMIDLIST, HKEY, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellFolder*, ITEMIDLIST*, HKEY, uint, int> SetShellFolder;

        [NativeTypeName("HRESULT (DWORD *, LPITEMIDLIST *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ITEMIDLIST**, Guid*, void**, int> GetShellFolder;

        [NativeTypeName("HRESULT (HMENU, HWND, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU, HWND, uint, int> SetMenu;

        [NativeTypeName("HRESULT (HMENU *, HWND *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU*, HWND*, uint*, int> GetMenu;

        [NativeTypeName("HRESULT (LPSMDATA, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SMDATA*, uint, int> InvalidateItem;

        [NativeTypeName("HRESULT (LPSMDATA) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SMDATA*, int> GetState;

        [NativeTypeName("HRESULT (IUnknown *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint, int> SetMenuToolbar;

        [NativeTypeName("HRESULT (HWND, IUnknown *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IUnknown*, uint, int> SetObscured;

        [NativeTypeName("HRESULT (HWND, POINTL *, RECTL *, MP_POPUPFLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, POINTL*, RECTL*, int, int> Popup;
    }
}
