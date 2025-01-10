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

[Guid("D5A2F60C-37B2-44A2-937B-8D8EB9726821")]
[NativeTypeName("struct ISwapChainPanelNative2 : ISwapChainPanelNative")]
[NativeInheritance("ISwapChainPanelNative")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ISwapChainPanelNative2 : ISwapChainPanelNative2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISwapChainPanelNative2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISwapChainPanelNative2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISwapChainPanelNative2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISwapChainPanelNative2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSwapChain(IDXGISwapChain swapChain)
    {
        return ((delegate* unmanaged<ISwapChainPanelNative2, IDXGISwapChain, int>)((*lpVtbl)[3]))(
            this,
            swapChain
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSwapChainHandle(HANDLE swapChainHandle)
    {
        return ((delegate* unmanaged<ISwapChainPanelNative2, HANDLE, int>)((*lpVtbl)[4]))(
            this,
            swapChainHandle
        );
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
        public delegate* unmanaged<TSelf*, IDXGISwapChain, int> SetSwapChain;

        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> SetSwapChainHandle;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISwapChainPanelNative2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISwapChainPanelNative2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.ISwapChainPanelNative"/> to <see cref = "ISwapChainPanelNative2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.ISwapChainPanelNative"/> instance to be converted </param>
    public static explicit operator ISwapChainPanelNative2(
        Silk.NET.WinRT.ISwapChainPanelNative value
    )
    {
        return new ISwapChainPanelNative2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISwapChainPanelNative2"/> to <see cref = "Silk.NET.WinRT.ISwapChainPanelNative"/>.</summary>
    /// <param name = "value">The <see cref = "ISwapChainPanelNative2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.ISwapChainPanelNative(
        ISwapChainPanelNative2 value
    )
    {
        return new Silk.NET.WinRT.ISwapChainPanelNative(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISwapChainPanelNative2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISwapChainPanelNative2(Silk.NET.Windows.IUnknown value)
    {
        return new ISwapChainPanelNative2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISwapChainPanelNative2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISwapChainPanelNative2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISwapChainPanelNative2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
