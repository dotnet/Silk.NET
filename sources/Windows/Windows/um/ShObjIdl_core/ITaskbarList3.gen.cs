// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3"]/*' />
[Guid("EA1AFB91-9E28-4B86-90E9-9E9F8A5EEFAF")]
[NativeTypeName("struct ITaskbarList3 : ITaskbarList2")]
[NativeInheritance("ITaskbarList2")]
public unsafe partial struct ITaskbarList3 : ITaskbarList3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITaskbarList3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITaskbarList3*, Guid*, void**, int>)(lpVtbl[0]))((ITaskbarList3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITaskbarList3*, uint>)(lpVtbl[1]))((ITaskbarList3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITaskbarList3*, uint>)(lpVtbl[2]))((ITaskbarList3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITaskbarList.HrInit" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT HrInit()
    {
        return ((delegate* unmanaged<ITaskbarList3*, int>)(lpVtbl[3]))((ITaskbarList3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITaskbarList.AddTab" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddTab(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, int>)(lpVtbl[4]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <inheritdoc cref="ITaskbarList.DeleteTab" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DeleteTab(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, int>)(lpVtbl[5]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <inheritdoc cref="ITaskbarList.ActivateTab" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ActivateTab(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, int>)(lpVtbl[6]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <inheritdoc cref="ITaskbarList.SetActiveAlt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetActiveAlt(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, int>)(lpVtbl[7]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <inheritdoc cref="ITaskbarList2.MarkFullscreenWindow" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MarkFullscreenWindow(HWND hwnd, BOOL fFullscreen)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, BOOL, int>)(lpVtbl[8]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, fFullscreen);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.SetProgressValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetProgressValue(HWND hwnd, [NativeTypeName("ULONGLONG")] ulong ullCompleted, [NativeTypeName("ULONGLONG")] ulong ullTotal)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, ulong, ulong, int>)(lpVtbl[9]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, ullCompleted, ullTotal);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.SetProgressState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetProgressState(HWND hwnd, TBPFLAG tbpFlags)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, TBPFLAG, int>)(lpVtbl[10]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, tbpFlags);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.RegisterTab"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RegisterTab(HWND hwndTab, HWND hwndMDI)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, HWND, int>)(lpVtbl[11]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab, hwndMDI);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.UnregisterTab"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UnregisterTab(HWND hwndTab)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, int>)(lpVtbl[12]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.SetTabOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetTabOrder(HWND hwndTab, HWND hwndInsertBefore)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, HWND, int>)(lpVtbl[13]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab, hwndInsertBefore);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.SetTabActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetTabActive(HWND hwndTab, HWND hwndMDI, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, HWND, uint, int>)(lpVtbl[14]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab, hwndMDI, dwReserved);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.ThumbBarAddButtons"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ThumbBarAddButtons(HWND hwnd, uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, uint, THUMBBUTTON*, int>)(lpVtbl[15]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, cButtons, pButton);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.ThumbBarUpdateButtons"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ThumbBarUpdateButtons(HWND hwnd, uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, uint, THUMBBUTTON*, int>)(lpVtbl[16]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, cButtons, pButton);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.ThumbBarSetImageList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ThumbBarSetImageList(HWND hwnd, HIMAGELIST himl)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, HIMAGELIST, int>)(lpVtbl[17]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, himl);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.SetOverlayIcon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetOverlayIcon(HWND hwnd, HICON hIcon, [NativeTypeName("LPCWSTR")] ushort* pszDescription)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, HICON, ushort*, int>)(lpVtbl[18]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, hIcon, pszDescription);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.SetThumbnailTooltip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetThumbnailTooltip(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszTip)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, ushort*, int>)(lpVtbl[19]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, pszTip);
    }

    /// <include file='ITaskbarList3.xml' path='doc/member[@name="ITaskbarList3.SetThumbnailClip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetThumbnailClip(HWND hwnd, RECT* prcClip)
    {
        return ((delegate* unmanaged<ITaskbarList3*, HWND, RECT*, int>)(lpVtbl[20]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, prcClip);
    }

    public interface Interface : ITaskbarList2.Interface
    {
        [VtblIndex(9)]
        HRESULT SetProgressValue(HWND hwnd, [NativeTypeName("ULONGLONG")] ulong ullCompleted, [NativeTypeName("ULONGLONG")] ulong ullTotal);

        [VtblIndex(10)]
        HRESULT SetProgressState(HWND hwnd, TBPFLAG tbpFlags);

        [VtblIndex(11)]
        HRESULT RegisterTab(HWND hwndTab, HWND hwndMDI);

        [VtblIndex(12)]
        HRESULT UnregisterTab(HWND hwndTab);

        [VtblIndex(13)]
        HRESULT SetTabOrder(HWND hwndTab, HWND hwndInsertBefore);

        [VtblIndex(14)]
        HRESULT SetTabActive(HWND hwndTab, HWND hwndMDI, [NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(15)]
        HRESULT ThumbBarAddButtons(HWND hwnd, uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton);

        [VtblIndex(16)]
        HRESULT ThumbBarUpdateButtons(HWND hwnd, uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton);

        [VtblIndex(17)]
        HRESULT ThumbBarSetImageList(HWND hwnd, HIMAGELIST himl);

        [VtblIndex(18)]
        HRESULT SetOverlayIcon(HWND hwnd, HICON hIcon, [NativeTypeName("LPCWSTR")] ushort* pszDescription);

        [VtblIndex(19)]
        HRESULT SetThumbnailTooltip(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszTip);

        [VtblIndex(20)]
        HRESULT SetThumbnailClip(HWND hwnd, RECT* prcClip);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HrInit;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> AddTab;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> DeleteTab;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> ActivateTab;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> SetActiveAlt;

        [NativeTypeName("HRESULT (HWND, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, BOOL, int> MarkFullscreenWindow;

        [NativeTypeName("HRESULT (HWND, ULONGLONG, ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ulong, ulong, int> SetProgressValue;

        [NativeTypeName("HRESULT (HWND, TBPFLAG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, TBPFLAG, int> SetProgressState;

        [NativeTypeName("HRESULT (HWND, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HWND, int> RegisterTab;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> UnregisterTab;

        [NativeTypeName("HRESULT (HWND, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HWND, int> SetTabOrder;

        [NativeTypeName("HRESULT (HWND, HWND, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HWND, uint, int> SetTabActive;

        [NativeTypeName("HRESULT (HWND, UINT, LPTHUMBBUTTON) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, THUMBBUTTON*, int> ThumbBarAddButtons;

        [NativeTypeName("HRESULT (HWND, UINT, LPTHUMBBUTTON) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, THUMBBUTTON*, int> ThumbBarUpdateButtons;

        [NativeTypeName("HRESULT (HWND, HIMAGELIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HIMAGELIST, int> ThumbBarSetImageList;

        [NativeTypeName("HRESULT (HWND, HICON, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HICON, ushort*, int> SetOverlayIcon;

        [NativeTypeName("HRESULT (HWND, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ushort*, int> SetThumbnailTooltip;

        [NativeTypeName("HRESULT (HWND, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, RECT*, int> SetThumbnailClip;
    }
}
