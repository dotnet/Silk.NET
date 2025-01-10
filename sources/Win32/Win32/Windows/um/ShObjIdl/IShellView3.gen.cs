// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EC39FA88-F8AF-41C5-8421-38BED28F4673")]
[NativeTypeName("struct IShellView3 : IShellView2")]
[NativeInheritance("IShellView2")]
public unsafe partial struct IShellView3 : IShellView3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellView3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellView3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellView3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellView3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IShellView3, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IShellView3, BOOL, int>)((*lpVtbl)[4]))(this, fEnterMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TranslateAcceleratorW(MSG* pmsg)
    {
        return ((delegate* unmanaged<IShellView3, MSG*, int>)((*lpVtbl)[5]))(this, pmsg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnableModeless(BOOL fEnable)
    {
        return ((delegate* unmanaged<IShellView3, BOOL, int>)((*lpVtbl)[6]))(this, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UIActivate(uint uState)
    {
        return ((delegate* unmanaged<IShellView3, uint, int>)((*lpVtbl)[7]))(this, uState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Refresh()
    {
        return ((delegate* unmanaged<IShellView3, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateViewWindow(
        IShellView psvPrevious,
        [NativeTypeName("LPCFOLDERSETTINGS")] FOLDERSETTINGS* pfs,
        IShellBrowser psb,
        RECT* prcView,
        HWND* phWnd
    )
    {
        return (
            (delegate* unmanaged<
                IShellView3,
                IShellView,
                FOLDERSETTINGS*,
                IShellBrowser,
                RECT*,
                HWND*,
                int>)((*lpVtbl)[9])
        )(this, psvPrevious, pfs, psb, prcView, phWnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DestroyViewWindow()
    {
        return ((delegate* unmanaged<IShellView3, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCurrentInfo([NativeTypeName("LPFOLDERSETTINGS")] FOLDERSETTINGS* pfs)
    {
        return ((delegate* unmanaged<IShellView3, FOLDERSETTINGS*, int>)((*lpVtbl)[11]))(this, pfs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddPropertySheetPages(
        [NativeTypeName("DWORD")] uint dwReserved,
        [NativeTypeName("LPFNSVADDPROPSHEETPAGE")]
            delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> pfn,
        LPARAM lparam
    )
    {
        return (
            (delegate* unmanaged<
                IShellView3,
                uint,
                delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>,
                LPARAM,
                int>)((*lpVtbl)[12])
        )(this, dwReserved, pfn, lparam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SaveViewState()
    {
        return ((delegate* unmanaged<IShellView3, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SelectItem(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem,
        [NativeTypeName("SVSIF")] uint uFlags
    )
    {
        return ((delegate* unmanaged<IShellView3, ITEMIDLIST*, uint, int>)((*lpVtbl)[14]))(
            this,
            pidlItem,
            uFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetItemObject(uint uItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellView3, uint, Guid*, void**, int>)((*lpVtbl)[15]))(
            this,
            uItem,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetView(
        [NativeTypeName("SHELLVIEWID *")] Guid* pvid,
        [NativeTypeName("ULONG")] uint uView
    )
    {
        return ((delegate* unmanaged<IShellView3, Guid*, uint, int>)((*lpVtbl)[16]))(
            this,
            pvid,
            uView
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateViewWindow2([NativeTypeName("LPSV2CVW2_PARAMS")] SV2CVW2_PARAMS* lpParams)
    {
        return ((delegate* unmanaged<IShellView3, SV2CVW2_PARAMS*, int>)((*lpVtbl)[17]))(
            this,
            lpParams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT HandleRename([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlNew)
    {
        return ((delegate* unmanaged<IShellView3, ITEMIDLIST*, int>)((*lpVtbl)[18]))(this, pidlNew);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SelectAndPositionItem(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem,
        uint uFlags,
        POINT* ppt
    )
    {
        return ((delegate* unmanaged<IShellView3, ITEMIDLIST*, uint, POINT*, int>)((*lpVtbl)[19]))(
            this,
            pidlItem,
            uFlags,
            ppt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateViewWindow3(
        IShellBrowser psbOwner,
        IShellView psvPrev,
        [NativeTypeName("SV3CVW3_FLAGS")] uint dwViewFlags,
        FOLDERFLAGS dwMask,
        FOLDERFLAGS dwFlags,
        FOLDERVIEWMODE fvMode,
        [NativeTypeName("const SHELLVIEWID *")] Guid* pvid,
        [NativeTypeName("const RECT *")] RECT* prcView,
        HWND* phwndView
    )
    {
        return (
            (delegate* unmanaged<
                IShellView3,
                IShellBrowser,
                IShellView,
                uint,
                FOLDERFLAGS,
                FOLDERFLAGS,
                FOLDERVIEWMODE,
                Guid*,
                RECT*,
                HWND*,
                int>)((*lpVtbl)[20])
        )(this, psbOwner, psvPrev, dwViewFlags, dwMask, dwFlags, fvMode, pvid, prcView, phwndView);
    }

    public interface Interface : IShellView2.Interface
    {
        [VtblIndex(20)]
        HRESULT CreateViewWindow3(
            IShellBrowser psbOwner,
            IShellView psvPrev,
            [NativeTypeName("SV3CVW3_FLAGS")] uint dwViewFlags,
            FOLDERFLAGS dwMask,
            FOLDERFLAGS dwFlags,
            FOLDERVIEWMODE fvMode,
            [NativeTypeName("const SHELLVIEWID *")] Guid* pvid,
            [NativeTypeName("const RECT *")] RECT* prcView,
            HWND* phwndView
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

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindow;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ContextSensitiveHelp;

        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> TranslateAcceleratorW;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> EnableModeless;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UIActivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Refresh;

        [NativeTypeName(
            "HRESULT (IShellView *, LPCFOLDERSETTINGS, IShellBrowser *, RECT *, HWND *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellView,
            FOLDERSETTINGS*,
            IShellBrowser,
            RECT*,
            HWND*,
            int> CreateViewWindow;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DestroyViewWindow;

        [NativeTypeName("HRESULT (LPFOLDERSETTINGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FOLDERSETTINGS*, int> GetCurrentInfo;

        [NativeTypeName("HRESULT (DWORD, LPFNSVADDPROPSHEETPAGE, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>,
            LPARAM,
            int> AddPropertySheetPages;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SaveViewState;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, SVSIF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, uint, int> SelectItem;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetItemObject;

        [NativeTypeName("HRESULT (SHELLVIEWID *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> GetView;

        [NativeTypeName("HRESULT (LPSV2CVW2_PARAMS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SV2CVW2_PARAMS*, int> CreateViewWindow2;

        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> HandleRename;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, UINT, POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, uint, POINT*, int> SelectAndPositionItem;

        [NativeTypeName(
            "HRESULT (IShellBrowser *, IShellView *, SV3CVW3_FLAGS, FOLDERFLAGS, FOLDERFLAGS, FOLDERVIEWMODE, const SHELLVIEWID *, const RECT *, HWND *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellBrowser,
            IShellView,
            uint,
            FOLDERFLAGS,
            FOLDERFLAGS,
            FOLDERVIEWMODE,
            Guid*,
            RECT*,
            HWND*,
            int> CreateViewWindow3;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellView3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellView3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellView2"/> to <see cref = "IShellView3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellView2"/> instance to be converted </param>
    public static explicit operator IShellView3(Silk.NET.Windows.IShellView2 value)
    {
        return new IShellView3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellView3"/> to <see cref = "Silk.NET.Windows.IShellView2"/>.</summary>
    /// <param name = "value">The <see cref = "IShellView3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellView2(IShellView3 value)
    {
        return new Silk.NET.Windows.IShellView2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellView"/> to <see cref = "IShellView3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellView"/> instance to be converted </param>
    public static explicit operator IShellView3(Silk.NET.Windows.IShellView value)
    {
        return new IShellView3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellView3"/> to <see cref = "Silk.NET.Windows.IShellView"/>.</summary>
    /// <param name = "value">The <see cref = "IShellView3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellView(IShellView3 value)
    {
        return new Silk.NET.Windows.IShellView(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IShellView3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IShellView3(Silk.NET.Windows.IOleWindow value)
    {
        return new IShellView3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellView3"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IShellView3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IShellView3 value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellView3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellView3(Silk.NET.Windows.IUnknown value)
    {
        return new IShellView3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellView3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellView3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellView3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
