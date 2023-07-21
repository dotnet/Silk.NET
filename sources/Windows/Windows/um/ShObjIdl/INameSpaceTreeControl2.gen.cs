// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='INameSpaceTreeControl2.xml' path='doc/member[@name="INameSpaceTreeControl2"]/*' />
[Guid("7CC7AED8-290E-49BC-8945-C1401CC9306C")]
[NativeTypeName("struct INameSpaceTreeControl2 : INameSpaceTreeControl")]
[NativeInheritance("INameSpaceTreeControl")]
public unsafe partial struct INameSpaceTreeControl2 : INameSpaceTreeControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INameSpaceTreeControl2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, uint>)(lpVtbl[1]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, uint>)(lpVtbl[2]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="INameSpaceTreeControl.Initialize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(HWND hwndParent, RECT* prc, [NativeTypeName("NSTCSTYLE")] uint nsctsFlags)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, HWND, RECT*, uint, int>)(lpVtbl[3]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), hwndParent, prc, nsctsFlags);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.TreeAdvise" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TreeAdvise(IUnknown* punk, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IUnknown*, uint*, int>)(lpVtbl[4]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), punk, pdwCookie);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.TreeUnadvise" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TreeUnadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, uint, int>)(lpVtbl[5]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.AppendRoot" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AppendRoot(IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint, IShellItemFilter*, int>)(lpVtbl[6]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psiRoot, grfEnumFlags, grfRootStyle, pif);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.InsertRoot" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertRoot(int iIndex, IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, int, IShellItem*, uint, uint, IShellItemFilter*, int>)(lpVtbl[7]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), iIndex, psiRoot, grfEnumFlags, grfRootStyle, pif);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.RemoveRoot" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveRoot(IShellItem* psiRoot)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int>)(lpVtbl[8]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psiRoot);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.RemoveAllRoots" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAllRoots()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, int>)(lpVtbl[9]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="INameSpaceTreeControl.GetRootItems" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetRootItems(IShellItemArray** ppsiaRootItems)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItemArray**, int>)(lpVtbl[10]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), ppsiaRootItems);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.SetItemState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisFlags)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint, int>)(lpVtbl[11]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisFlags);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.GetItemState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE *")] uint* pnstcisFlags)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint*, int>)(lpVtbl[12]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, nstcisMask, pnstcisFlags);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.GetSelectedItems" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetSelectedItems(IShellItemArray** psiaItems)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItemArray**, int>)(lpVtbl[13]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psiaItems);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.GetItemCustomState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetItemCustomState(IShellItem* psi, int* piStateNumber)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int*, int>)(lpVtbl[14]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, piStateNumber);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.SetItemCustomState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetItemCustomState(IShellItem* psi, int iStateNumber)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int, int>)(lpVtbl[15]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, iStateNumber);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.EnsureItemVisible" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnsureItemVisible(IShellItem* psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int>)(lpVtbl[16]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.SetTheme" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTheme([NativeTypeName("LPCWSTR")] ushort* pszTheme)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, ushort*, int>)(lpVtbl[17]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), pszTheme);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.GetNextItem" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetNextItem(IShellItem* psi, NSTCGNI nstcgi, IShellItem** ppsiNext)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, NSTCGNI, IShellItem**, int>)(lpVtbl[18]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, nstcgi, ppsiNext);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.HitTest" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT HitTest(POINT* ppt, IShellItem** ppsiOut)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, POINT*, IShellItem**, int>)(lpVtbl[19]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), ppt, ppsiOut);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.GetItemRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetItemRect(IShellItem* psi, RECT* prect)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, RECT*, int>)(lpVtbl[20]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, prect);
    }

    /// <inheritdoc cref="INameSpaceTreeControl.CollapseAll" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CollapseAll()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, int>)(lpVtbl[21]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INameSpaceTreeControl2.xml' path='doc/member[@name="INameSpaceTreeControl2.SetControlStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetControlStyle([NativeTypeName("NSTCSTYLE")] uint nstcsMask, [NativeTypeName("NSTCSTYLE")] uint nstcsStyle)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, uint, uint, int>)(lpVtbl[22]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, nstcsStyle);
    }

    /// <include file='INameSpaceTreeControl2.xml' path='doc/member[@name="INameSpaceTreeControl2.GetControlStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetControlStyle([NativeTypeName("NSTCSTYLE")] uint nstcsMask, [NativeTypeName("NSTCSTYLE *")] uint* pnstcsStyle)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, uint, uint*, int>)(lpVtbl[23]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, pnstcsStyle);
    }

    /// <include file='INameSpaceTreeControl2.xml' path='doc/member[@name="INameSpaceTreeControl2.SetControlStyle2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2 nstcsStyle)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, NSTCSTYLE2, NSTCSTYLE2, int>)(lpVtbl[24]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, nstcsStyle);
    }

    /// <include file='INameSpaceTreeControl2.xml' path='doc/member[@name="INameSpaceTreeControl2.GetControlStyle2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2* pnstcsStyle)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl2*, NSTCSTYLE2, NSTCSTYLE2*, int>)(lpVtbl[25]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, pnstcsStyle);
    }

    public interface Interface : INameSpaceTreeControl.Interface
    {
        [VtblIndex(22)]
        HRESULT SetControlStyle([NativeTypeName("NSTCSTYLE")] uint nstcsMask, [NativeTypeName("NSTCSTYLE")] uint nstcsStyle);

        [VtblIndex(23)]
        HRESULT GetControlStyle([NativeTypeName("NSTCSTYLE")] uint nstcsMask, [NativeTypeName("NSTCSTYLE *")] uint* pnstcsStyle);

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
        public delegate* unmanaged<TSelf*, IUnknown*, uint*, int> TreeAdvise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> TreeUnadvise;

        [NativeTypeName("HRESULT (IShellItem *, SHCONTF, NSTCROOTSTYLE, IShellItemFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, uint, uint, IShellItemFilter*, int> AppendRoot;

        [NativeTypeName("HRESULT (int, IShellItem *, SHCONTF, NSTCROOTSTYLE, IShellItemFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IShellItem*, uint, uint, IShellItemFilter*, int> InsertRoot;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> RemoveRoot;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllRoots;

        [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray**, int> GetRootItems;

        [NativeTypeName("HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, uint, uint, int> SetItemState;

        [NativeTypeName("HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, uint, uint*, int> GetItemState;

        [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray**, int> GetSelectedItems;

        [NativeTypeName("HRESULT (IShellItem *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int*, int> GetItemCustomState;

        [NativeTypeName("HRESULT (IShellItem *, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int, int> SetItemCustomState;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> EnsureItemVisible;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetTheme;

        [NativeTypeName("HRESULT (IShellItem *, NSTCGNI, IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, NSTCGNI, IShellItem**, int> GetNextItem;

        [NativeTypeName("HRESULT (POINT *, IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, IShellItem**, int> HitTest;

        [NativeTypeName("HRESULT (IShellItem *, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, RECT*, int> GetItemRect;

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
}
