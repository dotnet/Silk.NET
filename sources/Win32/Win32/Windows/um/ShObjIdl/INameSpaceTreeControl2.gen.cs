// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7CC7AED8-290E-49BC-8945-C1401CC9306C")]
[NativeTypeName("struct INameSpaceTreeControl2 : INameSpaceTreeControl")]
[NativeInheritance("INameSpaceTreeControl")]
public unsafe partial struct INameSpaceTreeControl2 : INameSpaceTreeControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INameSpaceTreeControl2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<INameSpaceTreeControl2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(
        HWND hwndParent,
        RECT* prc,
        [NativeTypeName("NSTCSTYLE")] uint nsctsFlags
    )
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, HWND, RECT*, uint, int>)((*lpVtbl)[3])
        )(this, hwndParent, prc, nsctsFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TreeAdvise(IUnknown punk, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, IUnknown, uint*, int>)((*lpVtbl)[4]))(
            this,
            punk,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TreeUnadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, uint, int>)((*lpVtbl)[5]))(
            this,
            dwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AppendRoot(
        IShellItem psiRoot,
        [NativeTypeName("SHCONTF")] uint grfEnumFlags,
        [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle,
        IShellItemFilter pif
    )
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControl2,
                IShellItem,
                uint,
                uint,
                IShellItemFilter,
                int>)((*lpVtbl)[6])
        )(this, psiRoot, grfEnumFlags, grfRootStyle, pif);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertRoot(
        int iIndex,
        IShellItem psiRoot,
        [NativeTypeName("SHCONTF")] uint grfEnumFlags,
        [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle,
        IShellItemFilter pif
    )
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControl2,
                int,
                IShellItem,
                uint,
                uint,
                IShellItemFilter,
                int>)((*lpVtbl)[7])
        )(this, iIndex, psiRoot, grfEnumFlags, grfRootStyle, pif);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveRoot(IShellItem psiRoot)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, IShellItem, int>)((*lpVtbl)[8]))(
            this,
            psiRoot
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAllRoots()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetRootItems(IShellItemArray* ppsiaRootItems)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, IShellItemArray*, int>)((*lpVtbl)[10])
        )(this, ppsiaRootItems);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetItemState(
        IShellItem psi,
        [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask,
        [NativeTypeName("NSTCITEMSTATE")] uint nstcisFlags
    )
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, IShellItem, uint, uint, int>)(
                (*lpVtbl)[11]
            )
        )(this, psi, nstcisMask, nstcisFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetItemState(
        IShellItem psi,
        [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask,
        [NativeTypeName("NSTCITEMSTATE *")] uint* pnstcisFlags
    )
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, IShellItem, uint, uint*, int>)(
                (*lpVtbl)[12]
            )
        )(this, psi, nstcisMask, pnstcisFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetSelectedItems(IShellItemArray* psiaItems)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, IShellItemArray*, int>)((*lpVtbl)[13])
        )(this, psiaItems);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetItemCustomState(IShellItem psi, int* piStateNumber)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, IShellItem, int*, int>)((*lpVtbl)[14])
        )(this, psi, piStateNumber);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetItemCustomState(IShellItem psi, int iStateNumber)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, IShellItem, int, int>)((*lpVtbl)[15]))(
            this,
            psi,
            iStateNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnsureItemVisible(IShellItem psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, IShellItem, int>)((*lpVtbl)[16]))(
            this,
            psi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTheme([NativeTypeName("LPCWSTR")] ushort* pszTheme)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, ushort*, int>)((*lpVtbl)[17]))(
            this,
            pszTheme
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetNextItem(IShellItem psi, NSTCGNI nstcgi, IShellItem* ppsiNext)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, IShellItem, NSTCGNI, IShellItem*, int>)(
                (*lpVtbl)[18]
            )
        )(this, psi, nstcgi, ppsiNext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT HitTest(POINT* ppt, IShellItem* ppsiOut)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, POINT*, IShellItem*, int>)((*lpVtbl)[19])
        )(this, ppt, ppsiOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetItemRect(IShellItem psi, RECT* prect)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, IShellItem, RECT*, int>)((*lpVtbl)[20])
        )(this, psi, prect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CollapseAll()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetControlStyle(
        [NativeTypeName("NSTCSTYLE")] uint nstcsMask,
        [NativeTypeName("NSTCSTYLE")] uint nstcsStyle
    )
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, uint, uint, int>)((*lpVtbl)[22]))(
            this,
            nstcsMask,
            nstcsStyle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetControlStyle(
        [NativeTypeName("NSTCSTYLE")] uint nstcsMask,
        [NativeTypeName("NSTCSTYLE *")] uint* pnstcsStyle
    )
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2, uint, uint*, int>)((*lpVtbl)[23]))(
            this,
            nstcsMask,
            pnstcsStyle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2 nstcsStyle)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, NSTCSTYLE2, NSTCSTYLE2, int>)(
                (*lpVtbl)[24]
            )
        )(this, nstcsMask, nstcsStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2* pnstcsStyle)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControl2, NSTCSTYLE2, NSTCSTYLE2*, int>)(
                (*lpVtbl)[25]
            )
        )(this, nstcsMask, pnstcsStyle);
    }

    public interface Interface : INameSpaceTreeControl.Interface
    {
        [VtblIndex(22)]
        HRESULT SetControlStyle(
            [NativeTypeName("NSTCSTYLE")] uint nstcsMask,
            [NativeTypeName("NSTCSTYLE")] uint nstcsStyle
        );

        [VtblIndex(23)]
        HRESULT GetControlStyle(
            [NativeTypeName("NSTCSTYLE")] uint nstcsMask,
            [NativeTypeName("NSTCSTYLE *")] uint* pnstcsStyle
        );

        [VtblIndex(24)]
        HRESULT SetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2 nstcsStyle);

        [VtblIndex(25)]
        HRESULT GetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2* pnstcsStyle);
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

        [NativeTypeName("HRESULT (HWND, RECT *, NSTCSTYLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, RECT*, uint, int> Initialize;

        [NativeTypeName("HRESULT (IUnknown *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint*, int> TreeAdvise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> TreeUnadvise;

        [NativeTypeName(
            "HRESULT (IShellItem *, SHCONTF, NSTCROOTSTYLE, IShellItemFilter *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            uint,
            uint,
            IShellItemFilter,
            int> AppendRoot;

        [NativeTypeName(
            "HRESULT (int, IShellItem *, SHCONTF, NSTCROOTSTYLE, IShellItemFilter *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            IShellItem,
            uint,
            uint,
            IShellItemFilter,
            int> InsertRoot;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> RemoveRoot;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllRoots;

        [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray*, int> GetRootItems;

        [NativeTypeName(
            "HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItem, uint, uint, int> SetItemState;

        [NativeTypeName(
            "HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItem, uint, uint*, int> GetItemState;

        [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray*, int> GetSelectedItems;

        [NativeTypeName("HRESULT (IShellItem *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int*, int> GetItemCustomState;

        [NativeTypeName("HRESULT (IShellItem *, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int, int> SetItemCustomState;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> EnsureItemVisible;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetTheme;

        [NativeTypeName("HRESULT (IShellItem *, NSTCGNI, IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, NSTCGNI, IShellItem*, int> GetNextItem;

        [NativeTypeName("HRESULT (POINT *, IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, IShellItem*, int> HitTest;

        [NativeTypeName("HRESULT (IShellItem *, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, RECT*, int> GetItemRect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CollapseAll;

        [NativeTypeName("HRESULT (NSTCSTYLE, NSTCSTYLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetControlStyle;

        [NativeTypeName("HRESULT (NSTCSTYLE, NSTCSTYLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetControlStyle;

        [NativeTypeName("HRESULT (NSTCSTYLE2, NSTCSTYLE2) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, NSTCSTYLE2, NSTCSTYLE2, int> SetControlStyle2;

        [NativeTypeName("HRESULT (NSTCSTYLE2, NSTCSTYLE2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, NSTCSTYLE2, NSTCSTYLE2*, int> GetControlStyle2;
    }

    /// <summary>Initializes a new instance of the <see cref = "INameSpaceTreeControl2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INameSpaceTreeControl2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.INameSpaceTreeControl"/> to <see cref = "INameSpaceTreeControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.INameSpaceTreeControl"/> instance to be converted </param>
    public static explicit operator INameSpaceTreeControl2(
        Silk.NET.Windows.INameSpaceTreeControl value
    )
    {
        return new INameSpaceTreeControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INameSpaceTreeControl2"/> to <see cref = "Silk.NET.Windows.INameSpaceTreeControl"/>.</summary>
    /// <param name = "value">The <see cref = "INameSpaceTreeControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.INameSpaceTreeControl(
        INameSpaceTreeControl2 value
    )
    {
        return new Silk.NET.Windows.INameSpaceTreeControl(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INameSpaceTreeControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INameSpaceTreeControl2(Silk.NET.Windows.IUnknown value)
    {
        return new INameSpaceTreeControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INameSpaceTreeControl2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INameSpaceTreeControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INameSpaceTreeControl2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
