// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8278F932-2A3E-11D2-838F-00C04FD918D0")]
[NativeTypeName("struct ITrackShellMenu : IShellMenu")]
[NativeInheritance("IShellMenu")]
public unsafe partial struct ITrackShellMenu : ITrackShellMenu.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITrackShellMenu));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITrackShellMenu, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITrackShellMenu, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITrackShellMenu, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(
        IShellMenuCallback psmc,
        uint uId,
        uint uIdAncestor,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<ITrackShellMenu, IShellMenuCallback, uint, uint, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, psmc, uId, uIdAncestor, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMenuInfo(
        IShellMenuCallback* ppsmc,
        uint* puId,
        uint* puIdAncestor,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    )
    {
        return (
            (delegate* unmanaged<ITrackShellMenu, IShellMenuCallback*, uint*, uint*, uint*, int>)(
                (*lpVtbl)[4]
            )
        )(this, ppsmc, puId, puIdAncestor, pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetShellFolder(
        IShellFolder psf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
        HKEY hKey,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<ITrackShellMenu, IShellFolder, ITEMIDLIST*, HKEY, uint, int>)(
                (*lpVtbl)[5]
            )
        )(this, psf, pidlFolder, hKey, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetShellFolder(
        [NativeTypeName("DWORD *")] uint* pdwFlags,
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<ITrackShellMenu, uint*, ITEMIDLIST**, Guid*, void**, int>)(
                (*lpVtbl)[6]
            )
        )(this, pdwFlags, ppidl, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMenu(HMENU hmenu, HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu, HMENU, HWND, uint, int>)((*lpVtbl)[7]))(
            this,
            hmenu,
            hwnd,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMenu(HMENU* phmenu, HWND* phwnd, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu, HMENU*, HWND*, uint*, int>)((*lpVtbl)[8]))(
            this,
            phmenu,
            phwnd,
            pdwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InvalidateItem(
        [NativeTypeName("LPSMDATA")] SMDATA* psmd,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<ITrackShellMenu, SMDATA*, uint, int>)((*lpVtbl)[9]))(
            this,
            psmd,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetState([NativeTypeName("LPSMDATA")] SMDATA* psmd)
    {
        return ((delegate* unmanaged<ITrackShellMenu, SMDATA*, int>)((*lpVtbl)[10]))(this, psmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetMenuToolbar(IUnknown punk, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITrackShellMenu, IUnknown, uint, int>)((*lpVtbl)[11]))(
            this,
            punk,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetObscured(
        HWND hwndTB,
        IUnknown punkBand,
        [NativeTypeName("DWORD")] uint dwSMSetFlags
    )
    {
        return ((delegate* unmanaged<ITrackShellMenu, HWND, IUnknown, uint, int>)((*lpVtbl)[12]))(
            this,
            hwndTB,
            punkBand,
            dwSMSetFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Popup(
        HWND hwnd,
        POINTL* ppt,
        RECTL* prcExclude,
        [NativeTypeName("MP_POPUPFLAGS")] int dwFlags
    )
    {
        return (
            (delegate* unmanaged<ITrackShellMenu, HWND, POINTL*, RECTL*, int, int>)((*lpVtbl)[13])
        )(this, hwnd, ppt, prcExclude, dwFlags);
    }

    public interface Interface : IShellMenu.Interface
    {
        [VtblIndex(12)]
        HRESULT SetObscured(
            HWND hwndTB,
            IUnknown punkBand,
            [NativeTypeName("DWORD")] uint dwSMSetFlags
        );

        [VtblIndex(13)]
        HRESULT Popup(
            HWND hwnd,
            POINTL* ppt,
            RECTL* prcExclude,
            [NativeTypeName("MP_POPUPFLAGS")] int dwFlags
        );
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

        [NativeTypeName(
            "HRESULT (IShellMenuCallback *, UINT, UINT, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellMenuCallback, uint, uint, uint, int> Initialize;

        [NativeTypeName(
            "HRESULT (IShellMenuCallback **, UINT *, UINT *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellMenuCallback*,
            uint*,
            uint*,
            uint*,
            int> GetMenuInfo;

        [NativeTypeName(
            "HRESULT (IShellFolder *, LPCITEMIDLIST, HKEY, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellFolder,
            ITEMIDLIST*,
            HKEY,
            uint,
            int> SetShellFolder;

        [NativeTypeName(
            "HRESULT (DWORD *, LPITEMIDLIST *, const IID &, void **) __attribute__((stdcall))"
        )]
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
        public delegate* unmanaged<TSelf*, IUnknown, uint, int> SetMenuToolbar;

        [NativeTypeName("HRESULT (HWND, IUnknown *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IUnknown, uint, int> SetObscured;

        [NativeTypeName(
            "HRESULT (HWND, POINTL *, RECTL *, MP_POPUPFLAGS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HWND, POINTL*, RECTL*, int, int> Popup;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITrackShellMenu"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITrackShellMenu(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellMenu"/> to <see cref = "ITrackShellMenu"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellMenu"/> instance to be converted </param>
    public static explicit operator ITrackShellMenu(Silk.NET.Windows.IShellMenu value)
    {
        return new ITrackShellMenu(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITrackShellMenu"/> to <see cref = "Silk.NET.Windows.IShellMenu"/>.</summary>
    /// <param name = "value">The <see cref = "ITrackShellMenu"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellMenu(ITrackShellMenu value)
    {
        return new Silk.NET.Windows.IShellMenu(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITrackShellMenu"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITrackShellMenu(Silk.NET.Windows.IUnknown value)
    {
        return new ITrackShellMenu(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITrackShellMenu"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITrackShellMenu"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITrackShellMenu value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
