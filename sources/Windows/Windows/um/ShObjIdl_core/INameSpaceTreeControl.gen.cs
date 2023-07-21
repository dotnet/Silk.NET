// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl"]/*' />
[Guid("028212A3-B627-47E9-8856-C14265554E4F")]
[NativeTypeName("struct INameSpaceTreeControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INameSpaceTreeControl : INameSpaceTreeControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INameSpaceTreeControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, uint>)(lpVtbl[1]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, uint>)(lpVtbl[2]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(HWND hwndParent, RECT* prc, [NativeTypeName("NSTCSTYLE")] uint nsctsFlags)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, HWND, RECT*, uint, int>)(lpVtbl[3]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), hwndParent, prc, nsctsFlags);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.TreeAdvise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TreeAdvise(IUnknown* punk, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IUnknown*, uint*, int>)(lpVtbl[4]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), punk, pdwCookie);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.TreeUnadvise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TreeUnadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, uint, int>)(lpVtbl[5]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.AppendRoot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AppendRoot(IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, uint, uint, IShellItemFilter*, int>)(lpVtbl[6]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psiRoot, grfEnumFlags, grfRootStyle, pif);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.InsertRoot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertRoot(int iIndex, IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, int, IShellItem*, uint, uint, IShellItemFilter*, int>)(lpVtbl[7]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), iIndex, psiRoot, grfEnumFlags, grfRootStyle, pif);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.RemoveRoot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveRoot(IShellItem* psiRoot)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int>)(lpVtbl[8]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psiRoot);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.RemoveAllRoots"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAllRoots()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, int>)(lpVtbl[9]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.GetRootItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetRootItems(IShellItemArray** ppsiaRootItems)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItemArray**, int>)(lpVtbl[10]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), ppsiaRootItems);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.SetItemState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisFlags)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, uint, uint, int>)(lpVtbl[11]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisFlags);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.GetItemState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE *")] uint* pnstcisFlags)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, uint, uint*, int>)(lpVtbl[12]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, nstcisMask, pnstcisFlags);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.GetSelectedItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetSelectedItems(IShellItemArray** psiaItems)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItemArray**, int>)(lpVtbl[13]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psiaItems);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.GetItemCustomState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetItemCustomState(IShellItem* psi, int* piStateNumber)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int*, int>)(lpVtbl[14]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, piStateNumber);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.SetItemCustomState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetItemCustomState(IShellItem* psi, int iStateNumber)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int, int>)(lpVtbl[15]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, iStateNumber);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.EnsureItemVisible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnsureItemVisible(IShellItem* psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int>)(lpVtbl[16]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.SetTheme"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTheme([NativeTypeName("LPCWSTR")] ushort* pszTheme)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, ushort*, int>)(lpVtbl[17]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), pszTheme);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.GetNextItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetNextItem(IShellItem* psi, NSTCGNI nstcgi, IShellItem** ppsiNext)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, NSTCGNI, IShellItem**, int>)(lpVtbl[18]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, nstcgi, ppsiNext);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.HitTest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT HitTest(POINT* ppt, IShellItem** ppsiOut)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, POINT*, IShellItem**, int>)(lpVtbl[19]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), ppt, ppsiOut);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.GetItemRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetItemRect(IShellItem* psi, RECT* prect)
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, RECT*, int>)(lpVtbl[20]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, prect);
    }

    /// <include file='INameSpaceTreeControl.xml' path='doc/member[@name="INameSpaceTreeControl.CollapseAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CollapseAll()
    {
        return ((delegate* unmanaged<INameSpaceTreeControl*, int>)(lpVtbl[21]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(HWND hwndParent, RECT* prc, [NativeTypeName("NSTCSTYLE")] uint nsctsFlags);

        [VtblIndex(4)]
        HRESULT TreeAdvise(IUnknown* punk, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [VtblIndex(5)]
        HRESULT TreeUnadvise([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(6)]
        HRESULT AppendRoot(IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif);

        [VtblIndex(7)]
        HRESULT InsertRoot(int iIndex, IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif);

        [VtblIndex(8)]
        HRESULT RemoveRoot(IShellItem* psiRoot);

        [VtblIndex(9)]
        HRESULT RemoveAllRoots();

        [VtblIndex(10)]
        HRESULT GetRootItems(IShellItemArray** ppsiaRootItems);

        [VtblIndex(11)]
        HRESULT SetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisFlags);

        [VtblIndex(12)]
        HRESULT GetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE *")] uint* pnstcisFlags);

        [VtblIndex(13)]
        HRESULT GetSelectedItems(IShellItemArray** psiaItems);

        [VtblIndex(14)]
        HRESULT GetItemCustomState(IShellItem* psi, int* piStateNumber);

        [VtblIndex(15)]
        HRESULT SetItemCustomState(IShellItem* psi, int iStateNumber);

        [VtblIndex(16)]
        HRESULT EnsureItemVisible(IShellItem* psi);

        [VtblIndex(17)]
        HRESULT SetTheme([NativeTypeName("LPCWSTR")] ushort* pszTheme);

        [VtblIndex(18)]
        HRESULT GetNextItem(IShellItem* psi, NSTCGNI nstcgi, IShellItem** ppsiNext);

        [VtblIndex(19)]
        HRESULT HitTest(POINT* ppt, IShellItem** ppsiOut);

        [VtblIndex(20)]
        HRESULT GetItemRect(IShellItem* psi, RECT* prect);

        [VtblIndex(21)]
        HRESULT CollapseAll();
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
    }
}
