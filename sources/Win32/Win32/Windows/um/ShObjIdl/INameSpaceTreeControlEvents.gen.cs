// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("93D77985-B3D8-4484-8318-672CDDA002CE")]
[NativeTypeName("struct INameSpaceTreeControlEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INameSpaceTreeControlEvents
    : INameSpaceTreeControlEvents.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INameSpaceTreeControlEvents));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnItemClick(
        IShellItem psi,
        [NativeTypeName("NSTCEHITTEST")] uint nstceHitTest,
        [NativeTypeName("NSTCECLICKTYPE")] uint nstceClickType
    )
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, uint, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, psi, nstceHitTest, nstceClickType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnPropertyItemCommit(IShellItem psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, int>)((*lpVtbl)[4]))(
            this,
            psi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnItemStateChanging(
        IShellItem psi,
        [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask,
        [NativeTypeName("NSTCITEMSTATE")] uint nstcisState
    )
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, uint, uint, int>)(
                (*lpVtbl)[5]
            )
        )(this, psi, nstcisMask, nstcisState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnItemStateChanged(
        IShellItem psi,
        [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask,
        [NativeTypeName("NSTCITEMSTATE")] uint nstcisState
    )
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, uint, uint, int>)(
                (*lpVtbl)[6]
            )
        )(this, psi, nstcisMask, nstcisState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnSelectionChanged(IShellItemArray psiaSelection)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, IShellItemArray, int>)((*lpVtbl)[7])
        )(this, psiaSelection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnKeyboardInput(uint uMsg, WPARAM wParam, LPARAM lParam)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, uint, WPARAM, LPARAM, int>)(
                (*lpVtbl)[8]
            )
        )(this, uMsg, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnBeforeExpand(IShellItem psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, int>)((*lpVtbl)[9]))(
            this,
            psi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnAfterExpand(IShellItem psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, int>)((*lpVtbl)[10]))(
            this,
            psi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OnBeginLabelEdit(IShellItem psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, int>)((*lpVtbl)[11]))(
            this,
            psi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT OnEndLabelEdit(IShellItem psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, int>)((*lpVtbl)[12]))(
            this,
            psi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT OnGetToolTip(
        IShellItem psi,
        [NativeTypeName("LPWSTR")] ushort* pszTip,
        int cchTip
    )
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, ushort*, int, int>)(
                (*lpVtbl)[13]
            )
        )(this, psi, pszTip, cchTip);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT OnBeforeItemDelete(IShellItem psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, int>)((*lpVtbl)[14]))(
            this,
            psi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT OnItemAdded(IShellItem psi, BOOL fIsRoot)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, BOOL, int>)((*lpVtbl)[15])
        )(this, psi, fIsRoot);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT OnItemDeleted(IShellItem psi, BOOL fIsRoot)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, BOOL, int>)((*lpVtbl)[16])
        )(this, psi, fIsRoot);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT OnBeforeContextMenu(
        IShellItem psi,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, Guid*, void**, int>)(
                (*lpVtbl)[17]
            )
        )(this, psi, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT OnAfterContextMenu(
        IShellItem psi,
        IContextMenu pcmIn,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControlEvents,
                IShellItem,
                IContextMenu,
                Guid*,
                void**,
                int>)((*lpVtbl)[18])
        )(this, psi, pcmIn, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT OnBeforeStateImageChange(IShellItem psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, int>)((*lpVtbl)[19]))(
            this,
            psi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT OnGetDefaultIconIndex(IShellItem psi, int* piDefaultIcon, int* piOpenIcon)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlEvents, IShellItem, int*, int*, int>)(
                (*lpVtbl)[20]
            )
        )(this, psi, piDefaultIcon, piOpenIcon);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnItemClick(
            IShellItem psi,
            [NativeTypeName("NSTCEHITTEST")] uint nstceHitTest,
            [NativeTypeName("NSTCECLICKTYPE")] uint nstceClickType
        );

        [VtblIndex(4)]
        HRESULT OnPropertyItemCommit(IShellItem psi);

        [VtblIndex(5)]
        HRESULT OnItemStateChanging(
            IShellItem psi,
            [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask,
            [NativeTypeName("NSTCITEMSTATE")] uint nstcisState
        );

        [VtblIndex(6)]
        HRESULT OnItemStateChanged(
            IShellItem psi,
            [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask,
            [NativeTypeName("NSTCITEMSTATE")] uint nstcisState
        );

        [VtblIndex(7)]
        HRESULT OnSelectionChanged(IShellItemArray psiaSelection);

        [VtblIndex(8)]
        HRESULT OnKeyboardInput(uint uMsg, WPARAM wParam, LPARAM lParam);

        [VtblIndex(9)]
        HRESULT OnBeforeExpand(IShellItem psi);

        [VtblIndex(10)]
        HRESULT OnAfterExpand(IShellItem psi);

        [VtblIndex(11)]
        HRESULT OnBeginLabelEdit(IShellItem psi);

        [VtblIndex(12)]
        HRESULT OnEndLabelEdit(IShellItem psi);

        [VtblIndex(13)]
        HRESULT OnGetToolTip(IShellItem psi, [NativeTypeName("LPWSTR")] ushort* pszTip, int cchTip);

        [VtblIndex(14)]
        HRESULT OnBeforeItemDelete(IShellItem psi);

        [VtblIndex(15)]
        HRESULT OnItemAdded(IShellItem psi, BOOL fIsRoot);

        [VtblIndex(16)]
        HRESULT OnItemDeleted(IShellItem psi, BOOL fIsRoot);

        [VtblIndex(17)]
        HRESULT OnBeforeContextMenu(
            IShellItem psi,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(18)]
        HRESULT OnAfterContextMenu(
            IShellItem psi,
            IContextMenu pcmIn,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(19)]
        HRESULT OnBeforeStateImageChange(IShellItem psi);

        [VtblIndex(20)]
        HRESULT OnGetDefaultIconIndex(IShellItem psi, int* piDefaultIcon, int* piOpenIcon);
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
            "HRESULT (IShellItem *, NSTCEHITTEST, NSTCECLICKTYPE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItem, uint, uint, int> OnItemClick;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> OnPropertyItemCommit;

        [NativeTypeName(
            "HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItem, uint, uint, int> OnItemStateChanging;

        [NativeTypeName(
            "HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItem, uint, uint, int> OnItemStateChanged;

        [NativeTypeName("HRESULT (IShellItemArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray, int> OnSelectionChanged;

        [NativeTypeName("HRESULT (UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WPARAM, LPARAM, int> OnKeyboardInput;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> OnBeforeExpand;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> OnAfterExpand;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> OnBeginLabelEdit;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> OnEndLabelEdit;

        [NativeTypeName("HRESULT (IShellItem *, LPWSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, ushort*, int, int> OnGetToolTip;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> OnBeforeItemDelete;

        [NativeTypeName("HRESULT (IShellItem *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, BOOL, int> OnItemAdded;

        [NativeTypeName("HRESULT (IShellItem *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, BOOL, int> OnItemDeleted;

        [NativeTypeName("HRESULT (IShellItem *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, Guid*, void**, int> OnBeforeContextMenu;

        [NativeTypeName(
            "HRESULT (IShellItem *, IContextMenu *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IContextMenu,
            Guid*,
            void**,
            int> OnAfterContextMenu;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> OnBeforeStateImageChange;

        [NativeTypeName("HRESULT (IShellItem *, int *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int*, int*, int> OnGetDefaultIconIndex;
    }

    /// <summary>Initializes a new instance of the <see cref = "INameSpaceTreeControlEvents"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INameSpaceTreeControlEvents(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INameSpaceTreeControlEvents"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INameSpaceTreeControlEvents(Silk.NET.Windows.IUnknown value)
    {
        return new INameSpaceTreeControlEvents(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INameSpaceTreeControlEvents"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INameSpaceTreeControlEvents"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INameSpaceTreeControlEvents value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
