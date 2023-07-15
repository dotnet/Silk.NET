// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents"]/*'/>
[Guid("93D77985-B3D8-4484-8318-672CDDA002CE")]
[NativeTypeName("struct INameSpaceTreeControlEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INameSpaceTreeControlEvents : INameSpaceTreeControlEvents.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INameSpaceTreeControlEvents));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, Guid*, void**, int> )(lpVtbl[0]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, uint> )(lpVtbl[1]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, uint> )(lpVtbl[2]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnItemClick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnItemClick(IShellItem* psi, [NativeTypeName("NSTCEHITTEST")] uint nstceHitTest, [NativeTypeName("NSTCECLICKTYPE")] uint nstceClickType)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, uint, uint, int> )(lpVtbl[3]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, nstceHitTest, nstceClickType);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnPropertyItemCommit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnPropertyItemCommit(IShellItem* psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int> )(lpVtbl[4]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnItemStateChanging"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnItemStateChanging(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisState)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, uint, uint, int> )(lpVtbl[5]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisState);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnItemStateChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnItemStateChanged(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisState)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, uint, uint, int> )(lpVtbl[6]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisState);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnSelectionChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnSelectionChanged(IShellItemArray* psiaSelection)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItemArray*, int> )(lpVtbl[7]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psiaSelection);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnKeyboardInput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnKeyboardInput(uint uMsg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, uint, WPARAM, LPARAM, int> )(lpVtbl[8]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnBeforeExpand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnBeforeExpand(IShellItem* psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int> )(lpVtbl[9]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnAfterExpand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnAfterExpand(IShellItem* psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int> )(lpVtbl[10]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnBeginLabelEdit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OnBeginLabelEdit(IShellItem* psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int> )(lpVtbl[11]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnEndLabelEdit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT OnEndLabelEdit(IShellItem* psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int> )(lpVtbl[12]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnGetToolTip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT OnGetToolTip(IShellItem* psi, [NativeTypeName("LPWSTR")] ushort* pszTip, int cchTip)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, ushort*, int, int> )(lpVtbl[13]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, pszTip, cchTip);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnBeforeItemDelete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT OnBeforeItemDelete(IShellItem* psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int> )(lpVtbl[14]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnItemAdded"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT OnItemAdded(IShellItem* psi, BOOL fIsRoot)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, BOOL, int> )(lpVtbl[15]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, fIsRoot);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnItemDeleted"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT OnItemDeleted(IShellItem* psi, BOOL fIsRoot)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, BOOL, int> )(lpVtbl[16]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, fIsRoot);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnBeforeContextMenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT OnBeforeContextMenu(IShellItem* psi, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, Guid*, void**, int> )(lpVtbl[17]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, riid, ppv);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnAfterContextMenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT OnAfterContextMenu(IShellItem* psi, IContextMenu* pcmIn, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, IContextMenu*, Guid*, void**, int> )(lpVtbl[18]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, pcmIn, riid, ppv);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnBeforeStateImageChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT OnBeforeStateImageChange(IShellItem* psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int> )(lpVtbl[19]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='INameSpaceTreeControlEvents.xml' path='doc/member[@name="INameSpaceTreeControlEvents.OnGetDefaultIconIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT OnGetDefaultIconIndex(IShellItem* psi, int* piDefaultIcon, int* piOpenIcon)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int*, int*, int> )(lpVtbl[20]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, piDefaultIcon, piOpenIcon);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnItemClick(IShellItem* psi, [NativeTypeName("NSTCEHITTEST")] uint nstceHitTest, [NativeTypeName("NSTCECLICKTYPE")] uint nstceClickType);
        [VtblIndex(4)]
        HRESULT OnPropertyItemCommit(IShellItem* psi);
        [VtblIndex(5)]
        HRESULT OnItemStateChanging(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisState);
        [VtblIndex(6)]
        HRESULT OnItemStateChanged(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisState);
        [VtblIndex(7)]
        HRESULT OnSelectionChanged(IShellItemArray* psiaSelection);
        [VtblIndex(8)]
        HRESULT OnKeyboardInput(uint uMsg, WPARAM wParam, LPARAM lParam);
        [VtblIndex(9)]
        HRESULT OnBeforeExpand(IShellItem* psi);
        [VtblIndex(10)]
        HRESULT OnAfterExpand(IShellItem* psi);
        [VtblIndex(11)]
        HRESULT OnBeginLabelEdit(IShellItem* psi);
        [VtblIndex(12)]
        HRESULT OnEndLabelEdit(IShellItem* psi);
        [VtblIndex(13)]
        HRESULT OnGetToolTip(IShellItem* psi, [NativeTypeName("LPWSTR")] ushort* pszTip, int cchTip);
        [VtblIndex(14)]
        HRESULT OnBeforeItemDelete(IShellItem* psi);
        [VtblIndex(15)]
        HRESULT OnItemAdded(IShellItem* psi, BOOL fIsRoot);
        [VtblIndex(16)]
        HRESULT OnItemDeleted(IShellItem* psi, BOOL fIsRoot);
        [VtblIndex(17)]
        HRESULT OnBeforeContextMenu(IShellItem* psi, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(18)]
        HRESULT OnAfterContextMenu(IShellItem* psi, IContextMenu* pcmIn, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(19)]
        HRESULT OnBeforeStateImageChange(IShellItem* psi);
        [VtblIndex(20)]
        HRESULT OnGetDefaultIconIndex(IShellItem* psi, int* piDefaultIcon, int* piOpenIcon);
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
        [NativeTypeName("HRESULT (IShellItem *, NSTCEHITTEST, NSTCECLICKTYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, uint, uint, int> OnItemClick;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> OnPropertyItemCommit;
        [NativeTypeName("HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, uint, uint, int> OnItemStateChanging;
        [NativeTypeName("HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, uint, uint, int> OnItemStateChanged;
        [NativeTypeName("HRESULT (IShellItemArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray*, int> OnSelectionChanged;
        [NativeTypeName("HRESULT (UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WPARAM, LPARAM, int> OnKeyboardInput;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> OnBeforeExpand;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> OnAfterExpand;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> OnBeginLabelEdit;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> OnEndLabelEdit;
        [NativeTypeName("HRESULT (IShellItem *, LPWSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, ushort*, int, int> OnGetToolTip;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> OnBeforeItemDelete;
        [NativeTypeName("HRESULT (IShellItem *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, BOOL, int> OnItemAdded;
        [NativeTypeName("HRESULT (IShellItem *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, BOOL, int> OnItemDeleted;
        [NativeTypeName("HRESULT (IShellItem *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, Guid*, void**, int> OnBeforeContextMenu;
        [NativeTypeName("HRESULT (IShellItem *, IContextMenu *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, IContextMenu*, Guid*, void**, int> OnAfterContextMenu;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> OnBeforeStateImageChange;
        [NativeTypeName("HRESULT (IShellItem *, int *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int*, int*, int> OnGetDefaultIconIndex;
    }
}