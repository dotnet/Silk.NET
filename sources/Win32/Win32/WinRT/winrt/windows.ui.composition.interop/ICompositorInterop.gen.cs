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

[Guid("25297D5C-3AD4-4C9C-B5CF-E36A38512330")]
[NativeTypeName("struct ICompositorInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositorInterop : ICompositorInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositorInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositorInterop, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositorInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositorInterop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateCompositionSurfaceForHandle(HANDLE swapChain, ICompositionSurface* result)
    {
        return (
            (delegate* unmanaged<ICompositorInterop, HANDLE, ICompositionSurface*, int>)(
                (*lpVtbl)[3]
            )
        )(this, swapChain, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateCompositionSurfaceForSwapChain(
        IUnknown swapChain,
        ICompositionSurface* result
    )
    {
        return (
            (delegate* unmanaged<ICompositorInterop, IUnknown, ICompositionSurface*, int>)(
                (*lpVtbl)[4]
            )
        )(this, swapChain, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateGraphicsDevice(
        IUnknown renderingDevice,
        ICompositionGraphicsDevice* result
    )
    {
        return (
            (delegate* unmanaged<ICompositorInterop, IUnknown, ICompositionGraphicsDevice*, int>)(
                (*lpVtbl)[5]
            )
        )(this, renderingDevice, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateCompositionSurfaceForHandle(HANDLE swapChain, ICompositionSurface* result);

        [VtblIndex(4)]
        HRESULT CreateCompositionSurfaceForSwapChain(
            IUnknown swapChain,
            ICompositionSurface* result
        );

        [VtblIndex(5)]
        HRESULT CreateGraphicsDevice(IUnknown renderingDevice, ICompositionGraphicsDevice* result);
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
            "HRESULT (HANDLE, ICompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HANDLE,
            ICompositionSurface*,
            int> CreateCompositionSurfaceForHandle;

        [NativeTypeName(
            "HRESULT (IUnknown *, ICompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            ICompositionSurface*,
            int> CreateCompositionSurfaceForSwapChain;

        [NativeTypeName(
            "HRESULT (IUnknown *, ICompositionGraphicsDevice **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            ICompositionGraphicsDevice*,
            int> CreateGraphicsDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositorInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositorInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositorInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositorInterop(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositorInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositorInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositorInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositorInterop value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
