// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("000214E3-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellView : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IShellView : IShellView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellView));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellView, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellView, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellView, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IShellView, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IShellView, BOOL, int>)((*lpVtbl)[4]))(this, fEnterMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TranslateAcceleratorW(MSG* pmsg)
    {
        return ((delegate* unmanaged<IShellView, MSG*, int>)((*lpVtbl)[5]))(this, pmsg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnableModeless(BOOL fEnable)
    {
        return ((delegate* unmanaged<IShellView, BOOL, int>)((*lpVtbl)[6]))(this, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UIActivate(uint uState)
    {
        return ((delegate* unmanaged<IShellView, uint, int>)((*lpVtbl)[7]))(this, uState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Refresh()
    {
        return ((delegate* unmanaged<IShellView, int>)((*lpVtbl)[8]))(this);
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
                IShellView,
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
        return ((delegate* unmanaged<IShellView, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCurrentInfo([NativeTypeName("LPFOLDERSETTINGS")] FOLDERSETTINGS* pfs)
    {
        return ((delegate* unmanaged<IShellView, FOLDERSETTINGS*, int>)((*lpVtbl)[11]))(this, pfs);
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
                IShellView,
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
        return ((delegate* unmanaged<IShellView, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SelectItem(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem,
        [NativeTypeName("SVSIF")] uint uFlags
    )
    {
        return ((delegate* unmanaged<IShellView, ITEMIDLIST*, uint, int>)((*lpVtbl)[14]))(
            this,
            pidlItem,
            uFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetItemObject(uint uItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellView, uint, Guid*, void**, int>)((*lpVtbl)[15]))(
            this,
            uItem,
            riid,
            ppv
        );
    }

    public interface Interface : IOleWindow.Interface
    {
        [VtblIndex(5)]
        HRESULT TranslateAcceleratorW(MSG* pmsg);

        [VtblIndex(6)]
        HRESULT EnableModeless(BOOL fEnable);

        [VtblIndex(7)]
        HRESULT UIActivate(uint uState);

        [VtblIndex(8)]
        HRESULT Refresh();

        [VtblIndex(9)]
        HRESULT CreateViewWindow(
            IShellView psvPrevious,
            [NativeTypeName("LPCFOLDERSETTINGS")] FOLDERSETTINGS* pfs,
            IShellBrowser psb,
            RECT* prcView,
            HWND* phWnd
        );

        [VtblIndex(10)]
        HRESULT DestroyViewWindow();

        [VtblIndex(11)]
        HRESULT GetCurrentInfo([NativeTypeName("LPFOLDERSETTINGS")] FOLDERSETTINGS* pfs);

        [VtblIndex(13)]
        HRESULT SaveViewState();

        [VtblIndex(14)]
        HRESULT SelectItem(
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem,
            [NativeTypeName("SVSIF")] uint uFlags
        );

        [VtblIndex(15)]
        HRESULT GetItemObject(uint uItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellView"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellView(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IShellView"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IShellView(Silk.NET.Windows.IOleWindow value)
    {
        return new IShellView(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellView"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IShellView"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IShellView value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellView"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellView(Silk.NET.Windows.IUnknown value)
    {
        return new IShellView(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellView"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellView"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellView value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
