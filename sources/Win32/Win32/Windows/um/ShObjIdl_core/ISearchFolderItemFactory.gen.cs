// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A0FFBC28-5482-4366-BE27-3E81E78E06C2")]
[NativeTypeName("struct ISearchFolderItemFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISearchFolderItemFactory
    : ISearchFolderItemFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchFolderItemFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISearchFolderItemFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISearchFolderItemFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISearchFolderItemFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszDisplayName)
    {
        return ((delegate* unmanaged<ISearchFolderItemFactory, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pszDisplayName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFolderTypeID([NativeTypeName("FOLDERTYPEID")] Guid ftid)
    {
        return ((delegate* unmanaged<ISearchFolderItemFactory, Guid, int>)((*lpVtbl)[4]))(
            this,
            ftid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFolderLogicalViewMode(FOLDERLOGICALVIEWMODE flvm)
    {
        return (
            (delegate* unmanaged<ISearchFolderItemFactory, FOLDERLOGICALVIEWMODE, int>)(
                (*lpVtbl)[5]
            )
        )(this, flvm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetIconSize(int iIconSize)
    {
        return ((delegate* unmanaged<ISearchFolderItemFactory, int, int>)((*lpVtbl)[6]))(
            this,
            iIconSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetVisibleColumns(
        uint cVisibleColumns,
        [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKey
    )
    {
        return (
            (delegate* unmanaged<ISearchFolderItemFactory, uint, PROPERTYKEY*, int>)((*lpVtbl)[7])
        )(this, cVisibleColumns, rgKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSortColumns(uint cSortColumns, SORTCOLUMN* rgSortColumns)
    {
        return (
            (delegate* unmanaged<ISearchFolderItemFactory, uint, SORTCOLUMN*, int>)((*lpVtbl)[8])
        )(this, cSortColumns, rgSortColumns);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetGroupColumn([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* keyGroup)
    {
        return ((delegate* unmanaged<ISearchFolderItemFactory, PROPERTYKEY*, int>)((*lpVtbl)[9]))(
            this,
            keyGroup
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetStacks(uint cStackKeys, PROPERTYKEY* rgStackKeys)
    {
        return (
            (delegate* unmanaged<ISearchFolderItemFactory, uint, PROPERTYKEY*, int>)((*lpVtbl)[10])
        )(this, cStackKeys, rgStackKeys);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetScope(IShellItemArray psiaScope)
    {
        return (
            (delegate* unmanaged<ISearchFolderItemFactory, IShellItemArray, int>)((*lpVtbl)[11])
        )(this, psiaScope);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetCondition(ICondition pCondition)
    {
        return ((delegate* unmanaged<ISearchFolderItemFactory, ICondition, int>)((*lpVtbl)[12]))(
            this,
            pCondition
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetShellItem([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ISearchFolderItemFactory, Guid*, void**, int>)((*lpVtbl)[13]))(
            this,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<ISearchFolderItemFactory, ITEMIDLIST**, int>)((*lpVtbl)[14]))(
            this,
            ppidl
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszDisplayName);

        [VtblIndex(4)]
        HRESULT SetFolderTypeID([NativeTypeName("FOLDERTYPEID")] Guid ftid);

        [VtblIndex(5)]
        HRESULT SetFolderLogicalViewMode(FOLDERLOGICALVIEWMODE flvm);

        [VtblIndex(6)]
        HRESULT SetIconSize(int iIconSize);

        [VtblIndex(7)]
        HRESULT SetVisibleColumns(
            uint cVisibleColumns,
            [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKey
        );

        [VtblIndex(8)]
        HRESULT SetSortColumns(uint cSortColumns, SORTCOLUMN* rgSortColumns);

        [VtblIndex(9)]
        HRESULT SetGroupColumn([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* keyGroup);

        [VtblIndex(10)]
        HRESULT SetStacks(uint cStackKeys, PROPERTYKEY* rgStackKeys);

        [VtblIndex(11)]
        HRESULT SetScope(IShellItemArray psiaScope);

        [VtblIndex(12)]
        HRESULT SetCondition(ICondition pCondition);

        [VtblIndex(13)]
        HRESULT GetShellItem([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(14)]
        HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDisplayName;

        [NativeTypeName("HRESULT (FOLDERTYPEID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> SetFolderTypeID;

        [NativeTypeName("HRESULT (FOLDERLOGICALVIEWMODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FOLDERLOGICALVIEWMODE, int> SetFolderLogicalViewMode;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetIconSize;

        [NativeTypeName("HRESULT (UINT, const PROPERTYKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PROPERTYKEY*, int> SetVisibleColumns;

        [NativeTypeName("HRESULT (UINT, SORTCOLUMN *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SORTCOLUMN*, int> SetSortColumns;

        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> SetGroupColumn;

        [NativeTypeName("HRESULT (UINT, PROPERTYKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PROPERTYKEY*, int> SetStacks;

        [NativeTypeName("HRESULT (IShellItemArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray, int> SetScope;

        [NativeTypeName("HRESULT (ICondition *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICondition, int> SetCondition;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetShellItem;

        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetIDList;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISearchFolderItemFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISearchFolderItemFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISearchFolderItemFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISearchFolderItemFactory(Silk.NET.Windows.IUnknown value)
    {
        return new ISearchFolderItemFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchFolderItemFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchFolderItemFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISearchFolderItemFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
