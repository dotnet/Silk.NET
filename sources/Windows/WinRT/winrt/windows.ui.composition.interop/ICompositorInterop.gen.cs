// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ICompositorInterop.xml' path='doc/member[@name="ICompositorInterop"]/*'/>
[Guid("25297D5C-3AD4-4C9C-B5CF-E36A38512330")]
[NativeTypeName("struct ICompositorInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositorInterop : ICompositorInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositorInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositorInterop*, Guid*, void**, int> )(lpVtbl[0]))((ICompositorInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositorInterop*, uint> )(lpVtbl[1]))((ICompositorInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositorInterop*, uint> )(lpVtbl[2]))((ICompositorInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositorInterop.xml' path='doc/member[@name="ICompositorInterop.CreateCompositionSurfaceForHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateCompositionSurfaceForHandle(HANDLE swapChain, [NativeTypeName("ICompositionSurface **")] void** result)
    {
        return ((delegate* unmanaged<ICompositorInterop*, HANDLE, void**, int> )(lpVtbl[3]))((ICompositorInterop*)Unsafe.AsPointer(ref this), swapChain, result);
    }

    /// <include file='ICompositorInterop.xml' path='doc/member[@name="ICompositorInterop.CreateCompositionSurfaceForSwapChain"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateCompositionSurfaceForSwapChain(IUnknown* swapChain, [NativeTypeName("ICompositionSurface **")] void** result)
    {
        return ((delegate* unmanaged<ICompositorInterop*, IUnknown*, void**, int> )(lpVtbl[4]))((ICompositorInterop*)Unsafe.AsPointer(ref this), swapChain, result);
    }

    /// <include file='ICompositorInterop.xml' path='doc/member[@name="ICompositorInterop.CreateGraphicsDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateGraphicsDevice(IUnknown* renderingDevice, [NativeTypeName("ICompositionGraphicsDevice **")] void** result)
    {
        return ((delegate* unmanaged<ICompositorInterop*, IUnknown*, void**, int> )(lpVtbl[5]))((ICompositorInterop*)Unsafe.AsPointer(ref this), renderingDevice, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateCompositionSurfaceForHandle(HANDLE swapChain, [NativeTypeName("ICompositionSurface **")] void** result);
        [VtblIndex(4)]
        HRESULT CreateCompositionSurfaceForSwapChain(IUnknown* swapChain, [NativeTypeName("ICompositionSurface **")] void** result);
        [VtblIndex(5)]
        HRESULT CreateGraphicsDevice(IUnknown* renderingDevice, [NativeTypeName("ICompositionGraphicsDevice **")] void** result);
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
        [NativeTypeName("HRESULT (HANDLE, ICompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, void**, int> CreateCompositionSurfaceForHandle;
        [NativeTypeName("HRESULT (IUnknown *, ICompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, void**, int> CreateCompositionSurfaceForSwapChain;
        [NativeTypeName("HRESULT (IUnknown *, ICompositionGraphicsDevice **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, void**, int> CreateGraphicsDevice;
    }
}