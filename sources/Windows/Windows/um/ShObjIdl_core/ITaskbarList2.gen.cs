// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITaskbarList2.xml' path='doc/member[@name="ITaskbarList2"]/*'/>
[Guid("602D4995-B13A-429B-A66E-1935E44F4317")]
[NativeTypeName("struct ITaskbarList2 : ITaskbarList")]
[NativeInheritance("ITaskbarList")]
public unsafe partial struct ITaskbarList2 : ITaskbarList2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITaskbarList2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITaskbarList2*, Guid*, void**, int> )(lpVtbl[0]))((ITaskbarList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITaskbarList2*, uint> )(lpVtbl[1]))((ITaskbarList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITaskbarList2*, uint> )(lpVtbl[2]))((ITaskbarList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITaskbarList.HrInit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT HrInit()
    {
        return ((delegate* unmanaged<ITaskbarList2*, int> )(lpVtbl[3]))((ITaskbarList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITaskbarList.AddTab"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddTab(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList2*, HWND, int> )(lpVtbl[4]))((ITaskbarList2*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <inheritdoc cref = "ITaskbarList.DeleteTab"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DeleteTab(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList2*, HWND, int> )(lpVtbl[5]))((ITaskbarList2*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <inheritdoc cref = "ITaskbarList.ActivateTab"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ActivateTab(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList2*, HWND, int> )(lpVtbl[6]))((ITaskbarList2*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <inheritdoc cref = "ITaskbarList.SetActiveAlt"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetActiveAlt(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList2*, HWND, int> )(lpVtbl[7]))((ITaskbarList2*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <include file='ITaskbarList2.xml' path='doc/member[@name="ITaskbarList2.MarkFullscreenWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MarkFullscreenWindow(HWND hwnd, BOOL fFullscreen)
    {
        return ((delegate* unmanaged<ITaskbarList2*, HWND, BOOL, int> )(lpVtbl[8]))((ITaskbarList2*)Unsafe.AsPointer(ref this), hwnd, fFullscreen);
    }

    public interface Interface : ITaskbarList.Interface
    {
        [VtblIndex(8)]
        HRESULT MarkFullscreenWindow(HWND hwnd, BOOL fFullscreen);
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
    }
}