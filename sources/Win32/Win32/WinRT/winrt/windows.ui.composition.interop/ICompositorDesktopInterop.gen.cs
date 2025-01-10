// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("29E691FA-4567-4DCA-B319-D0F207EB6807")]
[NativeTypeName("struct ICompositorDesktopInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositorDesktopInterop
    : ICompositorDesktopInterop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositorDesktopInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositorDesktopInterop, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositorDesktopInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositorDesktopInterop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDesktopWindowTarget(
        HWND hwndTarget,
        BOOL isTopmost,
        IDesktopWindowTarget* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositorDesktopInterop,
                HWND,
                BOOL,
                IDesktopWindowTarget*,
                int>)((*lpVtbl)[3])
        )(this, hwndTarget, isTopmost, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnsureOnThread([NativeTypeName("DWORD")] uint threadId)
    {
        return ((delegate* unmanaged<ICompositorDesktopInterop, uint, int>)((*lpVtbl)[4]))(
            this,
            threadId
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateDesktopWindowTarget(
            HWND hwndTarget,
            BOOL isTopmost,
            IDesktopWindowTarget* result
        );

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

        [NativeTypeName(
            "HRESULT (HWND, BOOL, IDesktopWindowTarget **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            BOOL,
            IDesktopWindowTarget*,
            int> CreateDesktopWindowTarget;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> EnsureOnThread;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositorDesktopInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositorDesktopInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositorDesktopInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositorDesktopInterop(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositorDesktopInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositorDesktopInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositorDesktopInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositorDesktopInterop value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
