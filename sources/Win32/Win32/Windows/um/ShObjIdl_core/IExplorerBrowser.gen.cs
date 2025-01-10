// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DFD3B6B5-C10C-4BE9-85F6-A66969F402F6")]
[NativeTypeName("struct IExplorerBrowser : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExplorerBrowser : IExplorerBrowser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExplorerBrowser));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExplorerBrowser, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IExplorerBrowser, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExplorerBrowser, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(
        HWND hwndParent,
        [NativeTypeName("const RECT *")] RECT* prc,
        [NativeTypeName("const FOLDERSETTINGS *")] FOLDERSETTINGS* pfs
    )
    {
        return (
            (delegate* unmanaged<IExplorerBrowser, HWND, RECT*, FOLDERSETTINGS*, int>)((*lpVtbl)[3])
        )(this, hwndParent, prc, pfs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Destroy()
    {
        return ((delegate* unmanaged<IExplorerBrowser, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetRect(HDWP* phdwp, RECT rcBrowser)
    {
        return ((delegate* unmanaged<IExplorerBrowser, HDWP*, RECT, int>)((*lpVtbl)[5]))(
            this,
            phdwp,
            rcBrowser
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPropertyBag([NativeTypeName("LPCWSTR")] ushort* pszPropertyBag)
    {
        return ((delegate* unmanaged<IExplorerBrowser, ushort*, int>)((*lpVtbl)[6]))(
            this,
            pszPropertyBag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetEmptyText([NativeTypeName("LPCWSTR")] ushort* pszEmptyText)
    {
        return ((delegate* unmanaged<IExplorerBrowser, ushort*, int>)((*lpVtbl)[7]))(
            this,
            pszEmptyText
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFolderSettings([NativeTypeName("const FOLDERSETTINGS *")] FOLDERSETTINGS* pfs)
    {
        return ((delegate* unmanaged<IExplorerBrowser, FOLDERSETTINGS*, int>)((*lpVtbl)[8]))(
            this,
            pfs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Advise(IExplorerBrowserEvents psbe, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return (
            (delegate* unmanaged<IExplorerBrowser, IExplorerBrowserEvents, uint*, int>)(
                (*lpVtbl)[9]
            )
        )(this, psbe, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IExplorerBrowser, uint, int>)((*lpVtbl)[10]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetOptions(EXPLORER_BROWSER_OPTIONS dwFlag)
    {
        return (
            (delegate* unmanaged<IExplorerBrowser, EXPLORER_BROWSER_OPTIONS, int>)((*lpVtbl)[11])
        )(this, dwFlag);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetOptions(EXPLORER_BROWSER_OPTIONS* pdwFlag)
    {
        return (
            (delegate* unmanaged<IExplorerBrowser, EXPLORER_BROWSER_OPTIONS*, int>)((*lpVtbl)[12])
        )(this, pdwFlag);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT BrowseToIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint uFlags)
    {
        return ((delegate* unmanaged<IExplorerBrowser, ITEMIDLIST*, uint, int>)((*lpVtbl)[13]))(
            this,
            pidl,
            uFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT BrowseToObject(IUnknown punk, uint uFlags)
    {
        return ((delegate* unmanaged<IExplorerBrowser, IUnknown, uint, int>)((*lpVtbl)[14]))(
            this,
            punk,
            uFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT FillFromObject(IUnknown punk, EXPLORER_BROWSER_FILL_FLAGS dwFlags)
    {
        return (
            (delegate* unmanaged<IExplorerBrowser, IUnknown, EXPLORER_BROWSER_FILL_FLAGS, int>)(
                (*lpVtbl)[15]
            )
        )(this, punk, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RemoveAll()
    {
        return ((delegate* unmanaged<IExplorerBrowser, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetCurrentView([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IExplorerBrowser, Guid*, void**, int>)((*lpVtbl)[17]))(
            this,
            riid,
            ppv
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(
            HWND hwndParent,
            [NativeTypeName("const RECT *")] RECT* prc,
            [NativeTypeName("const FOLDERSETTINGS *")] FOLDERSETTINGS* pfs
        );

        [VtblIndex(4)]
        HRESULT Destroy();

        [VtblIndex(5)]
        HRESULT SetRect(HDWP* phdwp, RECT rcBrowser);

        [VtblIndex(6)]
        HRESULT SetPropertyBag([NativeTypeName("LPCWSTR")] ushort* pszPropertyBag);

        [VtblIndex(7)]
        HRESULT SetEmptyText([NativeTypeName("LPCWSTR")] ushort* pszEmptyText);

        [VtblIndex(8)]
        HRESULT SetFolderSettings([NativeTypeName("const FOLDERSETTINGS *")] FOLDERSETTINGS* pfs);

        [VtblIndex(9)]
        HRESULT Advise(IExplorerBrowserEvents psbe, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [VtblIndex(10)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(11)]
        HRESULT SetOptions(EXPLORER_BROWSER_OPTIONS dwFlag);

        [VtblIndex(12)]
        HRESULT GetOptions(EXPLORER_BROWSER_OPTIONS* pdwFlag);

        [VtblIndex(13)]
        HRESULT BrowseToIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint uFlags);

        [VtblIndex(14)]
        HRESULT BrowseToObject(IUnknown punk, uint uFlags);

        [VtblIndex(15)]
        HRESULT FillFromObject(IUnknown punk, EXPLORER_BROWSER_FILL_FLAGS dwFlags);

        [VtblIndex(16)]
        HRESULT RemoveAll();

        [VtblIndex(17)]
        HRESULT GetCurrentView([NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
            "HRESULT (HWND, const RECT *, const FOLDERSETTINGS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HWND, RECT*, FOLDERSETTINGS*, int> Initialize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Destroy;

        [NativeTypeName("HRESULT (HDWP *, RECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDWP*, RECT, int> SetRect;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetPropertyBag;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetEmptyText;

        [NativeTypeName("HRESULT (const FOLDERSETTINGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FOLDERSETTINGS*, int> SetFolderSettings;

        [NativeTypeName("HRESULT (IExplorerBrowserEvents *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IExplorerBrowserEvents, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;

        [NativeTypeName("HRESULT (EXPLORER_BROWSER_OPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EXPLORER_BROWSER_OPTIONS, int> SetOptions;

        [NativeTypeName("HRESULT (EXPLORER_BROWSER_OPTIONS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EXPLORER_BROWSER_OPTIONS*, int> GetOptions;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, uint, int> BrowseToIDList;

        [NativeTypeName("HRESULT (IUnknown *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint, int> BrowseToObject;

        [NativeTypeName(
            "HRESULT (IUnknown *, EXPLORER_BROWSER_FILL_FLAGS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            EXPLORER_BROWSER_FILL_FLAGS,
            int> FillFromObject;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAll;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetCurrentView;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExplorerBrowser"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExplorerBrowser(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExplorerBrowser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExplorerBrowser(Silk.NET.Windows.IUnknown value)
    {
        return new IExplorerBrowser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExplorerBrowser"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExplorerBrowser"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IExplorerBrowser value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
