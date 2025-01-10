// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("43BEBD4E-ADD5-4035-8F85-5608D08E9DC9")]
[NativeTypeName("struct ISwapChainBackgroundPanelNative : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ISwapChainBackgroundPanelNative
    : ISwapChainBackgroundPanelNative.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISwapChainBackgroundPanelNative));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISwapChainBackgroundPanelNative, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISwapChainBackgroundPanelNative, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISwapChainBackgroundPanelNative, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSwapChain(IDXGISwapChain swapChain)
    {
        return (
            (delegate* unmanaged<ISwapChainBackgroundPanelNative, IDXGISwapChain, int>)(
                (*lpVtbl)[3]
            )
        )(this, swapChain);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSwapChain(IDXGISwapChain swapChain);
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
        public delegate* unmanaged<TSelf*, IDXGISwapChain, int> SetSwapChain;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISwapChainBackgroundPanelNative"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISwapChainBackgroundPanelNative(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISwapChainBackgroundPanelNative"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISwapChainBackgroundPanelNative(Silk.NET.Windows.IUnknown value)
    {
        return new ISwapChainBackgroundPanelNative(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISwapChainBackgroundPanelNative"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISwapChainBackgroundPanelNative"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISwapChainBackgroundPanelNative value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
