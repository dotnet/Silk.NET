// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10misc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateDevice(
        IDXGIAdapter pAdapter,
        D3D10_DRIVER_TYPE DriverType,
        HMODULE Software,
        uint Flags,
        uint SDKVersion,
        ID3D10Device* ppDevice
    );

    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateDeviceAndSwapChain(
        IDXGIAdapter pAdapter,
        D3D10_DRIVER_TYPE DriverType,
        HMODULE Software,
        uint Flags,
        uint SDKVersion,
        DXGI_SWAP_CHAIN_DESC* pSwapChainDesc,
        IDXGISwapChain* ppSwapChain,
        ID3D10Device* ppDevice
    );

    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateBlob(
        [NativeTypeName("SIZE_T")] nuint NumBytes,
        [NativeTypeName("LPD3D10BLOB *")] ID3DBlob* ppBuffer
    );
}
