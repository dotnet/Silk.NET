// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("29EC8E6C-46D3-411F-BAAA-611A6C9CAC66")]
[NativeTypeName("struct IShellFolderViewDual3 : IShellFolderViewDual2")]
[NativeInheritance("IShellFolderViewDual2")]
public unsafe partial struct IShellFolderViewDual3 : IShellFolderViewDual3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellFolderViewDual3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellFolderViewDual3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IShellFolderViewDual3, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IShellFolderViewDual3, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IShellFolderViewDual3,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Application(IDispatch* ppid)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, IDispatch*, int>)((*lpVtbl)[7]))(
            this,
            ppid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Parent(IDispatch* ppid)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, IDispatch*, int>)((*lpVtbl)[8]))(
            this,
            ppid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Folder(Folder* ppid)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, Folder*, int>)((*lpVtbl)[9]))(
            this,
            ppid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SelectedItems(FolderItems* ppid)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, FolderItems*, int>)((*lpVtbl)[10]))(
            this,
            ppid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_FocusedItem(FolderItem* ppid)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, FolderItem*, int>)((*lpVtbl)[11]))(
            this,
            ppid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SelectItem(VARIANT* pvfi, int dwFlags)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, VARIANT*, int, int>)((*lpVtbl)[12]))(
            this,
            pvfi,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT PopupItemMenu(
        FolderItem pfi,
        VARIANT vx,
        VARIANT vy,
        [NativeTypeName("BSTR *")] ushort** pbs
    )
    {
        return (
            (delegate* unmanaged<
                IShellFolderViewDual3,
                FolderItem,
                VARIANT,
                VARIANT,
                ushort**,
                int>)((*lpVtbl)[13])
        )(this, pfi, vx, vy, pbs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Script(IDispatch* ppDisp)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, IDispatch*, int>)((*lpVtbl)[14]))(
            this,
            ppDisp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ViewOptions([NativeTypeName("long *")] int* plViewOptions)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, int*, int>)((*lpVtbl)[15]))(
            this,
            plViewOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CurrentViewMode(uint* pViewMode)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, uint*, int>)((*lpVtbl)[16]))(
            this,
            pViewMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_CurrentViewMode(uint ViewMode)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, uint, int>)((*lpVtbl)[17]))(
            this,
            ViewMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SelectItemRelative(int iRelative)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, int, int>)((*lpVtbl)[18]))(
            this,
            iRelative
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_GroupBy([NativeTypeName("BSTR *")] ushort** pbstrGroupBy)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, ushort**, int>)((*lpVtbl)[19]))(
            this,
            pbstrGroupBy
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_GroupBy([NativeTypeName("BSTR")] ushort* bstrGroupBy)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, ushort*, int>)((*lpVtbl)[20]))(
            this,
            bstrGroupBy
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_FolderFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, uint*, int>)((*lpVtbl)[21]))(
            this,
            pdwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_FolderFlags([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, uint, int>)((*lpVtbl)[22]))(
            this,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_SortColumns([NativeTypeName("BSTR *")] ushort** pbstrSortColumns)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, ushort**, int>)((*lpVtbl)[23]))(
            this,
            pbstrSortColumns
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_SortColumns([NativeTypeName("BSTR")] ushort* bstrSortColumns)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, ushort*, int>)((*lpVtbl)[24]))(
            this,
            bstrSortColumns
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_IconSize(int iIconSize)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, int, int>)((*lpVtbl)[25]))(
            this,
            iIconSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_IconSize(int* piIconSize)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, int*, int>)((*lpVtbl)[26]))(
            this,
            piIconSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT FilterView([NativeTypeName("BSTR")] ushort* bstrFilterText)
    {
        return ((delegate* unmanaged<IShellFolderViewDual3, ushort*, int>)((*lpVtbl)[27]))(
            this,
            bstrFilterText
        );
    }

    public interface Interface : IShellFolderViewDual2.Interface
    {
        [VtblIndex(19)]
        HRESULT get_GroupBy([NativeTypeName("BSTR *")] ushort** pbstrGroupBy);

        [VtblIndex(20)]
        HRESULT put_GroupBy([NativeTypeName("BSTR")] ushort* bstrGroupBy);

        [VtblIndex(21)]
        HRESULT get_FolderFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(22)]
        HRESULT put_FolderFlags([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(23)]
        HRESULT get_SortColumns([NativeTypeName("BSTR *")] ushort** pbstrSortColumns);

        [VtblIndex(24)]
        HRESULT put_SortColumns([NativeTypeName("BSTR")] ushort* bstrSortColumns);

        [VtblIndex(25)]
        HRESULT put_IconSize(int iIconSize);

        [VtblIndex(26)]
        HRESULT get_IconSize(int* piIconSize);

        [VtblIndex(27)]
        HRESULT FilterView([NativeTypeName("BSTR")] ushort* bstrFilterText);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Application;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Parent;

        [NativeTypeName("HRESULT (Folder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Folder*, int> get_Folder;

        [NativeTypeName("HRESULT (FolderItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItems*, int> SelectedItems;

        [NativeTypeName("HRESULT (FolderItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItem*, int> get_FocusedItem;

        [NativeTypeName("HRESULT (VARIANT *, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int, int> SelectItem;

        [NativeTypeName(
            "HRESULT (FolderItem *, VARIANT, VARIANT, BSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            FolderItem,
            VARIANT,
            VARIANT,
            ushort**,
            int> PopupItemMenu;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Script;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ViewOptions;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CurrentViewMode;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_CurrentViewMode;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SelectItemRelative;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_GroupBy;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_GroupBy;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_FolderFlags;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_FolderFlags;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_SortColumns;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_SortColumns;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_IconSize;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_IconSize;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> FilterView;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellFolderViewDual3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellFolderViewDual3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellFolderViewDual2"/> to <see cref = "IShellFolderViewDual3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellFolderViewDual2"/> instance to be converted </param>
    public static explicit operator IShellFolderViewDual3(
        Silk.NET.Windows.IShellFolderViewDual2 value
    )
    {
        return new IShellFolderViewDual3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellFolderViewDual3"/> to <see cref = "Silk.NET.Windows.IShellFolderViewDual2"/>.</summary>
    /// <param name = "value">The <see cref = "IShellFolderViewDual3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellFolderViewDual2(
        IShellFolderViewDual3 value
    )
    {
        return new Silk.NET.Windows.IShellFolderViewDual2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellFolderViewDual"/> to <see cref = "IShellFolderViewDual3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellFolderViewDual"/> instance to be converted </param>
    public static explicit operator IShellFolderViewDual3(
        Silk.NET.Windows.IShellFolderViewDual value
    )
    {
        return new IShellFolderViewDual3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellFolderViewDual3"/> to <see cref = "Silk.NET.Windows.IShellFolderViewDual"/>.</summary>
    /// <param name = "value">The <see cref = "IShellFolderViewDual3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellFolderViewDual(
        IShellFolderViewDual3 value
    )
    {
        return new Silk.NET.Windows.IShellFolderViewDual(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IShellFolderViewDual3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IShellFolderViewDual3(Silk.NET.Windows.IDispatch value)
    {
        return new IShellFolderViewDual3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellFolderViewDual3"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IShellFolderViewDual3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IShellFolderViewDual3 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellFolderViewDual3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellFolderViewDual3(Silk.NET.Windows.IUnknown value)
    {
        return new IShellFolderViewDual3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellFolderViewDual3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellFolderViewDual3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellFolderViewDual3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
