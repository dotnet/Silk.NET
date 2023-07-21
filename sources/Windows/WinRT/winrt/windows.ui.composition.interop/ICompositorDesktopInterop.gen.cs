// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='ICompositorDesktopInterop.xml' path='doc/member[@name="ICompositorDesktopInterop"]/*' />
[Guid("29E691FA-4567-4DCA-B319-D0F207EB6807")]
[NativeTypeName("struct ICompositorDesktopInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositorDesktopInterop : ICompositorDesktopInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositorDesktopInterop));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositorDesktopInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICompositorDesktopInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositorDesktopInterop*, uint>)(lpVtbl[1]))((ICompositorDesktopInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositorDesktopInterop*, uint>)(lpVtbl[2]))((ICompositorDesktopInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositorDesktopInterop.xml' path='doc/member[@name="ICompositorDesktopInterop.CreateDesktopWindowTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDesktopWindowTarget(HWND hwndTarget, BOOL isTopmost, [NativeTypeName("IDesktopWindowTarget **")] void** result)
    {
        return ((delegate* unmanaged<ICompositorDesktopInterop*, HWND, BOOL, void**, int>)(lpVtbl[3]))((ICompositorDesktopInterop*)Unsafe.AsPointer(ref this), hwndTarget, isTopmost, result);
    }

    /// <include file='ICompositorDesktopInterop.xml' path='doc/member[@name="ICompositorDesktopInterop.EnsureOnThread"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnsureOnThread([NativeTypeName("DWORD")] uint threadId)
    {
        return ((delegate* unmanaged<ICompositorDesktopInterop*, uint, int>)(lpVtbl[4]))((ICompositorDesktopInterop*)Unsafe.AsPointer(ref this), threadId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateDesktopWindowTarget(HWND hwndTarget, BOOL isTopmost, [NativeTypeName("IDesktopWindowTarget **")] void** result);

        [VtblIndex(4)]
        HRESULT EnsureOnThread([NativeTypeName("DWORD")] uint threadId);
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

        [NativeTypeName("HRESULT (HWND, BOOL, IDesktopWindowTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, BOOL, void**, int> CreateDesktopWindowTarget;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> EnsureOnThread;
    }
}
