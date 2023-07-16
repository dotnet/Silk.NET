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
/// <include file='ISwapChainPanelNative.xml' path='doc/member[@name="ISwapChainPanelNative"]/*'/>
[Guid("F92F19D2-3ADE-45A6-A20C-F6F1EA90554B")]
[NativeTypeName("struct ISwapChainPanelNative : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ISwapChainPanelNative : ISwapChainPanelNative.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISwapChainPanelNative));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISwapChainPanelNative*, Guid*, void**, int> )(lpVtbl[0]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISwapChainPanelNative*, uint> )(lpVtbl[1]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISwapChainPanelNative*, uint> )(lpVtbl[2]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISwapChainPanelNative.xml' path='doc/member[@name="ISwapChainPanelNative.SetSwapChain"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSwapChain(IDXGISwapChain* swapChain)
    {
        return ((delegate* unmanaged<ISwapChainPanelNative*, IDXGISwapChain*, int> )(lpVtbl[3]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this), swapChain);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSwapChain(IDXGISwapChain* swapChain);
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
    }
}