// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EE1F7637-E138-11D1-8379-00C04FD918D0")]
[NativeTypeName("struct IShellMenu : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellMenu : IShellMenu.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellMenu));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellMenu, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellMenu, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellMenu, uint>)((*lpVtbl)[2]))(this);
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
            (delegate* unmanaged<IShellMenu, IShellMenuCallback, uint, uint, uint, int>)(
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
            (delegate* unmanaged<IShellMenu, IShellMenuCallback*, uint*, uint*, uint*, int>)(
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
            (delegate* unmanaged<IShellMenu, IShellFolder, ITEMIDLIST*, HKEY, uint, int>)(
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
            (delegate* unmanaged<IShellMenu, uint*, ITEMIDLIST**, Guid*, void**, int>)((*lpVtbl)[6])
        )(this, pdwFlags, ppidl, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMenu(HMENU hmenu, HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellMenu, HMENU, HWND, uint, int>)((*lpVtbl)[7]))(
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
        return ((delegate* unmanaged<IShellMenu, HMENU*, HWND*, uint*, int>)((*lpVtbl)[8]))(
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
        return ((delegate* unmanaged<IShellMenu, SMDATA*, uint, int>)((*lpVtbl)[9]))(
            this,
            psmd,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetState([NativeTypeName("LPSMDATA")] SMDATA* psmd)
    {
        return ((delegate* unmanaged<IShellMenu, SMDATA*, int>)((*lpVtbl)[10]))(this, psmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetMenuToolbar(IUnknown punk, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellMenu, IUnknown, uint, int>)((*lpVtbl)[11]))(
            this,
            punk,
            dwFlags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(
            IShellMenuCallback psmc,
            uint uId,
            uint uIdAncestor,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(4)]
        HRESULT GetMenuInfo(
            IShellMenuCallback* ppsmc,
            uint* puId,
            uint* puIdAncestor,
            [NativeTypeName("DWORD *")] uint* pdwFlags
        );

        [VtblIndex(5)]
        HRESULT SetShellFolder(
            IShellFolder psf,
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
            HKEY hKey,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(6)]
        HRESULT GetShellFolder(
            [NativeTypeName("DWORD *")] uint* pdwFlags,
            [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(7)]
        HRESULT SetMenu(HMENU hmenu, HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(8)]
        HRESULT GetMenu(HMENU* phmenu, HWND* phwnd, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(9)]
        HRESULT InvalidateItem(
            [NativeTypeName("LPSMDATA")] SMDATA* psmd,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(10)]
        HRESULT GetState([NativeTypeName("LPSMDATA")] SMDATA* psmd);

        [VtblIndex(11)]
        HRESULT SetMenuToolbar(IUnknown punk, [NativeTypeName("DWORD")] uint dwFlags);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellMenu"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellMenu(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellMenu"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellMenu(Silk.NET.Windows.IUnknown value)
    {
        return new IShellMenu(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellMenu"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellMenu"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellMenu value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
