// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("41E7D1F2-A591-4F7B-A2E5-FA9C843E1C12")]
[NativeTypeName("struct IDXGIFactoryMedia : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDXGIFactoryMedia : IDXGIFactoryMedia.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactoryMedia));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIFactoryMedia, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGIFactoryMedia, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIFactoryMedia, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSwapChainForCompositionSurfaceHandle(
        IUnknown pDevice,
        HANDLE hSurface,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
        IDXGIOutput pRestrictToOutput,
        IDXGISwapChain1* ppSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIFactoryMedia,
                IUnknown,
                HANDLE,
                DXGI_SWAP_CHAIN_DESC1*,
                IDXGIOutput,
                IDXGISwapChain1*,
                int>)((*lpVtbl)[3])
        )(this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDecodeSwapChainForCompositionSurfaceHandle(
        IUnknown pDevice,
        HANDLE hSurface,
        DXGI_DECODE_SWAP_CHAIN_DESC* pDesc,
        IDXGIResource pYuvDecodeBuffers,
        IDXGIOutput pRestrictToOutput,
        IDXGIDecodeSwapChain* ppSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIFactoryMedia,
                IUnknown,
                HANDLE,
                DXGI_DECODE_SWAP_CHAIN_DESC*,
                IDXGIResource,
                IDXGIOutput,
                IDXGIDecodeSwapChain*,
                int>)((*lpVtbl)[4])
        )(this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSwapChainForCompositionSurfaceHandle(
            IUnknown pDevice,
            HANDLE hSurface,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
            IDXGIOutput pRestrictToOutput,
            IDXGISwapChain1* ppSwapChain
        );

        [VtblIndex(4)]
        HRESULT CreateDecodeSwapChainForCompositionSurfaceHandle(
            IUnknown pDevice,
            HANDLE hSurface,
            DXGI_DECODE_SWAP_CHAIN_DESC* pDesc,
            IDXGIResource pYuvDecodeBuffers,
            IDXGIOutput pRestrictToOutput,
            IDXGIDecodeSwapChain* ppSwapChain
        );
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
            "HRESULT (IUnknown *, HANDLE, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            HANDLE,
            DXGI_SWAP_CHAIN_DESC1*,
            IDXGIOutput,
            IDXGISwapChain1*,
            int> CreateSwapChainForCompositionSurfaceHandle;

        [NativeTypeName(
            "HRESULT (IUnknown *, HANDLE, DXGI_DECODE_SWAP_CHAIN_DESC *, IDXGIResource *, IDXGIOutput *, IDXGIDecodeSwapChain **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            HANDLE,
            DXGI_DECODE_SWAP_CHAIN_DESC*,
            IDXGIResource,
            IDXGIOutput,
            IDXGIDecodeSwapChain*,
            int> CreateDecodeSwapChainForCompositionSurfaceHandle;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIFactoryMedia"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIFactoryMedia(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIFactoryMedia"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIFactoryMedia(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIFactoryMedia(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactoryMedia"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactoryMedia"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIFactoryMedia value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
