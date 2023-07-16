// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ISwapChainPanelNative2.xml' path='doc/member[@name="ISwapChainPanelNative2"]/*'/>
[Guid("D5A2F60C-37B2-44A2-937B-8D8EB9726821")]
[NativeTypeName("struct ISwapChainPanelNative2 : ISwapChainPanelNative")]
[NativeInheritance("ISwapChainPanelNative")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ISwapChainPanelNative2 : ISwapChainPanelNative2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISwapChainPanelNative2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISwapChainPanelNative2*, Guid*, void**, int> )(lpVtbl[0]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISwapChainPanelNative2*, uint> )(lpVtbl[1]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISwapChainPanelNative2*, uint> )(lpVtbl[2]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISwapChainPanelNative.SetSwapChain"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSwapChain(IDXGISwapChain* swapChain)
    {
        return ((delegate* unmanaged<ISwapChainPanelNative2*, IDXGISwapChain*, int> )(lpVtbl[3]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this), swapChain);
    }

    /// <include file='ISwapChainPanelNative2.xml' path='doc/member[@name="ISwapChainPanelNative2.SetSwapChainHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSwapChainHandle(HANDLE swapChainHandle)
    {
        return ((delegate* unmanaged<ISwapChainPanelNative2*, HANDLE, int> )(lpVtbl[4]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this), swapChainHandle);
    }

    public interface Interface : ISwapChainPanelNative.Interface
    {
        [VtblIndex(4)]
        HRESULT SetSwapChainHandle(HANDLE swapChainHandle);
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
        [NativeTypeName("HRESULT (IDXGISwapChain *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGISwapChain*, int> SetSwapChain;
        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> SetSwapChainHandle;
    }
}