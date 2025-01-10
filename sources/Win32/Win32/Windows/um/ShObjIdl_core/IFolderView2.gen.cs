// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1AF3A467-214F-4298-908E-06B03E0B39F9")]
[NativeTypeName("struct IFolderView2 : IFolderView")]
[NativeInheritance("IFolderView")]
public unsafe partial struct IFolderView2 : IFolderView2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFolderView2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFolderView2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFolderView2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFolderView2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrentViewMode(uint* pViewMode)
    {
        return ((delegate* unmanaged<IFolderView2, uint*, int>)((*lpVtbl)[3]))(this, pViewMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCurrentViewMode(uint ViewMode)
    {
        return ((delegate* unmanaged<IFolderView2, uint, int>)((*lpVtbl)[4]))(this, ViewMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFolder([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IFolderView2, Guid*, void**, int>)((*lpVtbl)[5]))(
            this,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Item(int iItemIndex, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<IFolderView2, int, ITEMIDLIST**, int>)((*lpVtbl)[6]))(
            this,
            iItemIndex,
            ppidl
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ItemCount(uint uFlags, int* pcItems)
    {
        return ((delegate* unmanaged<IFolderView2, uint, int*, int>)((*lpVtbl)[7]))(
            this,
            uFlags,
            pcItems
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Items(uint uFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IFolderView2, uint, Guid*, void**, int>)((*lpVtbl)[8]))(
            this,
            uFlags,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSelectionMarkedItem(int* piItem)
    {
        return ((delegate* unmanaged<IFolderView2, int*, int>)((*lpVtbl)[9]))(this, piItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFocusedItem(int* piItem)
    {
        return ((delegate* unmanaged<IFolderView2, int*, int>)((*lpVtbl)[10]))(this, piItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetItemPosition([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, POINT* ppt)
    {
        return ((delegate* unmanaged<IFolderView2, ITEMIDLIST*, POINT*, int>)((*lpVtbl)[11]))(
            this,
            pidl,
            ppt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSpacing(POINT* ppt)
    {
        return ((delegate* unmanaged<IFolderView2, POINT*, int>)((*lpVtbl)[12]))(this, ppt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDefaultSpacing(POINT* ppt)
    {
        return ((delegate* unmanaged<IFolderView2, POINT*, int>)((*lpVtbl)[13]))(this, ppt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetAutoArrange()
    {
        return ((delegate* unmanaged<IFolderView2, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SelectItem(int iItem, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IFolderView2, int, uint, int>)((*lpVtbl)[15]))(
            this,
            iItem,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SelectAndPositionItems(
        uint cidl,
        [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl,
        POINT* apt,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<IFolderView2, uint, ITEMIDLIST**, POINT*, uint, int>)(
                (*lpVtbl)[16]
            )
        )(this, cidl, apidl, apt, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetGroupBy(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
        BOOL fAscending
    )
    {
        return ((delegate* unmanaged<IFolderView2, PROPERTYKEY*, BOOL, int>)((*lpVtbl)[17]))(
            this,
            key,
            fAscending
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetGroupBy(PROPERTYKEY* pkey, BOOL* pfAscending)
    {
        return ((delegate* unmanaged<IFolderView2, PROPERTYKEY*, BOOL*, int>)((*lpVtbl)[18]))(
            this,
            pkey,
            pfAscending
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [Obsolete]
    public HRESULT SetViewProperty(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar
    )
    {
        return (
            (delegate* unmanaged<IFolderView2, ITEMIDLIST*, PROPERTYKEY*, PROPVARIANT*, int>)(
                (*lpVtbl)[19]
            )
        )(this, pidl, propkey, propvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [Obsolete]
    public HRESULT GetViewProperty(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
        PROPVARIANT* ppropvar
    )
    {
        return (
            (delegate* unmanaged<IFolderView2, ITEMIDLIST*, PROPERTYKEY*, PROPVARIANT*, int>)(
                (*lpVtbl)[20]
            )
        )(this, pidl, propkey, ppropvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [Obsolete]
    public HRESULT SetTileViewProperties(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("LPCWSTR")] ushort* pszPropList
    )
    {
        return ((delegate* unmanaged<IFolderView2, ITEMIDLIST*, ushort*, int>)((*lpVtbl)[21]))(
            this,
            pidl,
            pszPropList
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [Obsolete]
    public HRESULT SetExtendedTileViewProperties(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("LPCWSTR")] ushort* pszPropList
    )
    {
        return ((delegate* unmanaged<IFolderView2, ITEMIDLIST*, ushort*, int>)((*lpVtbl)[22]))(
            this,
            pidl,
            pszPropList
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetText(FVTEXTTYPE iType, [NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IFolderView2, FVTEXTTYPE, ushort*, int>)((*lpVtbl)[23]))(
            this,
            iType,
            pwszText
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetCurrentFolderFlags(
        [NativeTypeName("DWORD")] uint dwMask,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<IFolderView2, uint, uint, int>)((*lpVtbl)[24]))(
            this,
            dwMask,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetCurrentFolderFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IFolderView2, uint*, int>)((*lpVtbl)[25]))(this, pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetSortColumnCount(int* pcColumns)
    {
        return ((delegate* unmanaged<IFolderView2, int*, int>)((*lpVtbl)[26]))(this, pcColumns);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetSortColumns(
        [NativeTypeName("const SORTCOLUMN *")] SORTCOLUMN* rgSortColumns,
        int cColumns
    )
    {
        return ((delegate* unmanaged<IFolderView2, SORTCOLUMN*, int, int>)((*lpVtbl)[27]))(
            this,
            rgSortColumns,
            cColumns
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetSortColumns(SORTCOLUMN* rgSortColumns, int cColumns)
    {
        return ((delegate* unmanaged<IFolderView2, SORTCOLUMN*, int, int>)((*lpVtbl)[28]))(
            this,
            rgSortColumns,
            cColumns
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetItem(int iItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IFolderView2, int, Guid*, void**, int>)((*lpVtbl)[29]))(
            this,
            iItem,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetVisibleItem(int iStart, BOOL fPrevious, int* piItem)
    {
        return ((delegate* unmanaged<IFolderView2, int, BOOL, int*, int>)((*lpVtbl)[30]))(
            this,
            iStart,
            fPrevious,
            piItem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetSelectedItem(int iStart, int* piItem)
    {
        return ((delegate* unmanaged<IFolderView2, int, int*, int>)((*lpVtbl)[31]))(
            this,
            iStart,
            piItem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetSelection(BOOL fNoneImpliesFolder, IShellItemArray* ppsia)
    {
        return ((delegate* unmanaged<IFolderView2, BOOL, IShellItemArray*, int>)((*lpVtbl)[32]))(
            this,
            fNoneImpliesFolder,
            ppsia
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetSelectionState(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    )
    {
        return ((delegate* unmanaged<IFolderView2, ITEMIDLIST*, uint*, int>)((*lpVtbl)[33]))(
            this,
            pidl,
            pdwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT InvokeVerbOnSelection([NativeTypeName("LPCSTR")] sbyte* pszVerb)
    {
        return ((delegate* unmanaged<IFolderView2, sbyte*, int>)((*lpVtbl)[34]))(this, pszVerb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetViewModeAndIconSize(FOLDERVIEWMODE uViewMode, int iImageSize)
    {
        return ((delegate* unmanaged<IFolderView2, FOLDERVIEWMODE, int, int>)((*lpVtbl)[35]))(
            this,
            uViewMode,
            iImageSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetViewModeAndIconSize(FOLDERVIEWMODE* puViewMode, int* piImageSize)
    {
        return ((delegate* unmanaged<IFolderView2, FOLDERVIEWMODE*, int*, int>)((*lpVtbl)[36]))(
            this,
            puViewMode,
            piImageSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetGroupSubsetCount(uint cVisibleRows)
    {
        return ((delegate* unmanaged<IFolderView2, uint, int>)((*lpVtbl)[37]))(this, cVisibleRows);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT GetGroupSubsetCount(uint* pcVisibleRows)
    {
        return ((delegate* unmanaged<IFolderView2, uint*, int>)((*lpVtbl)[38]))(
            this,
            pcVisibleRows
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetRedraw(BOOL fRedrawOn)
    {
        return ((delegate* unmanaged<IFolderView2, BOOL, int>)((*lpVtbl)[39]))(this, fRedrawOn);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT IsMoveInSameFolder()
    {
        return ((delegate* unmanaged<IFolderView2, int>)((*lpVtbl)[40]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT DoRename()
    {
        return ((delegate* unmanaged<IFolderView2, int>)((*lpVtbl)[41]))(this);
    }

    public interface Interface : IFolderView.Interface
    {
        [VtblIndex(17)]
        HRESULT SetGroupBy(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
            BOOL fAscending
        );

        [VtblIndex(18)]
        HRESULT GetGroupBy(PROPERTYKEY* pkey, BOOL* pfAscending);

        [VtblIndex(19)]
        [Obsolete]
        HRESULT SetViewProperty(
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
            [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar
        );

        [VtblIndex(20)]
        [Obsolete]
        HRESULT GetViewProperty(
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
            PROPVARIANT* ppropvar
        );

        [VtblIndex(21)]
        [Obsolete]
        HRESULT SetTileViewProperties(
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
            [NativeTypeName("LPCWSTR")] ushort* pszPropList
        );

        [VtblIndex(22)]
        [Obsolete]
        HRESULT SetExtendedTileViewProperties(
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
            [NativeTypeName("LPCWSTR")] ushort* pszPropList
        );

        [VtblIndex(23)]
        HRESULT SetText(FVTEXTTYPE iType, [NativeTypeName("LPCWSTR")] ushort* pwszText);

        [VtblIndex(24)]
        HRESULT SetCurrentFolderFlags(
            [NativeTypeName("DWORD")] uint dwMask,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(25)]
        HRESULT GetCurrentFolderFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(26)]
        HRESULT GetSortColumnCount(int* pcColumns);

        [VtblIndex(27)]
        HRESULT SetSortColumns(
            [NativeTypeName("const SORTCOLUMN *")] SORTCOLUMN* rgSortColumns,
            int cColumns
        );

        [VtblIndex(28)]
        HRESULT GetSortColumns(SORTCOLUMN* rgSortColumns, int cColumns);

        [VtblIndex(29)]
        HRESULT GetItem(int iItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(30)]
        HRESULT GetVisibleItem(int iStart, BOOL fPrevious, int* piItem);

        [VtblIndex(31)]
        HRESULT GetSelectedItem(int iStart, int* piItem);

        [VtblIndex(32)]
        HRESULT GetSelection(BOOL fNoneImpliesFolder, IShellItemArray* ppsia);

        [VtblIndex(33)]
        HRESULT GetSelectionState(
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
            [NativeTypeName("DWORD *")] uint* pdwFlags
        );

        [VtblIndex(34)]
        HRESULT InvokeVerbOnSelection([NativeTypeName("LPCSTR")] sbyte* pszVerb);

        [VtblIndex(35)]
        HRESULT SetViewModeAndIconSize(FOLDERVIEWMODE uViewMode, int iImageSize);

        [VtblIndex(36)]
        HRESULT GetViewModeAndIconSize(FOLDERVIEWMODE* puViewMode, int* piImageSize);

        [VtblIndex(37)]
        HRESULT SetGroupSubsetCount(uint cVisibleRows);

        [VtblIndex(38)]
        HRESULT GetGroupSubsetCount(uint* pcVisibleRows);

        [VtblIndex(39)]
        HRESULT SetRedraw(BOOL fRedrawOn);

        [VtblIndex(40)]
        HRESULT IsMoveInSameFolder();

        [VtblIndex(41)]
        HRESULT DoRename();
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentViewMode;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCurrentViewMode;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetFolder;

        [NativeTypeName("HRESULT (int, LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ITEMIDLIST**, int> Item;

        [NativeTypeName("HRESULT (UINT, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int*, int> ItemCount;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> Items;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetSelectionMarkedItem;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetFocusedItem;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, POINT*, int> GetItemPosition;

        [NativeTypeName("HRESULT (POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, int> GetSpacing;

        [NativeTypeName("HRESULT (POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, int> GetDefaultSpacing;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetAutoArrange;

        [NativeTypeName("HRESULT (int, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, int> SelectItem;

        [NativeTypeName("HRESULT (UINT, LPCITEMIDLIST *, POINT *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ITEMIDLIST**,
            POINT*,
            uint,
            int> SelectAndPositionItems;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, BOOL, int> SetGroupBy;

        [NativeTypeName("HRESULT (PROPERTYKEY *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, BOOL*, int> GetGroupBy;

        [NativeTypeName(
            "HRESULT (LPCITEMIDLIST, const PROPERTYKEY &, const PROPVARIANT &) __attribute__((stdcall))"
        )]
        [Obsolete]
        public delegate* unmanaged<
            TSelf*,
            ITEMIDLIST*,
            PROPERTYKEY*,
            PROPVARIANT*,
            int> SetViewProperty;

        [NativeTypeName(
            "HRESULT (LPCITEMIDLIST, const PROPERTYKEY &, PROPVARIANT *) __attribute__((stdcall))"
        )]
        [Obsolete]
        public delegate* unmanaged<
            TSelf*,
            ITEMIDLIST*,
            PROPERTYKEY*,
            PROPVARIANT*,
            int> GetViewProperty;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, LPCWSTR) __attribute__((stdcall))")]
        [Obsolete]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, ushort*, int> SetTileViewProperties;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, LPCWSTR) __attribute__((stdcall))")]
        [Obsolete]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, ushort*, int> SetExtendedTileViewProperties;

        [NativeTypeName("HRESULT (FVTEXTTYPE, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FVTEXTTYPE, ushort*, int> SetText;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetCurrentFolderFlags;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentFolderFlags;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetSortColumnCount;

        [NativeTypeName("HRESULT (const SORTCOLUMN *, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SORTCOLUMN*, int, int> SetSortColumns;

        [NativeTypeName("HRESULT (SORTCOLUMN *, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SORTCOLUMN*, int, int> GetSortColumns;

        [NativeTypeName("HRESULT (int, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, void**, int> GetItem;

        [NativeTypeName("HRESULT (int, BOOL, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, BOOL, int*, int> GetVisibleItem;

        [NativeTypeName("HRESULT (int, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetSelectedItem;

        [NativeTypeName("HRESULT (BOOL, IShellItemArray **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, IShellItemArray*, int> GetSelection;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, uint*, int> GetSelectionState;

        [NativeTypeName("HRESULT (LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int> InvokeVerbOnSelection;

        [NativeTypeName("HRESULT (FOLDERVIEWMODE, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FOLDERVIEWMODE, int, int> SetViewModeAndIconSize;

        [NativeTypeName("HRESULT (FOLDERVIEWMODE *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FOLDERVIEWMODE*, int*, int> GetViewModeAndIconSize;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetGroupSubsetCount;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetGroupSubsetCount;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetRedraw;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsMoveInSameFolder;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DoRename;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFolderView2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFolderView2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IFolderView"/> to <see cref = "IFolderView2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IFolderView"/> instance to be converted </param>
    public static explicit operator IFolderView2(Silk.NET.Windows.IFolderView value)
    {
        return new IFolderView2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFolderView2"/> to <see cref = "Silk.NET.Windows.IFolderView"/>.</summary>
    /// <param name = "value">The <see cref = "IFolderView2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IFolderView(IFolderView2 value)
    {
        return new Silk.NET.Windows.IFolderView(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFolderView2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFolderView2(Silk.NET.Windows.IUnknown value)
    {
        return new IFolderView2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFolderView2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFolderView2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFolderView2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
