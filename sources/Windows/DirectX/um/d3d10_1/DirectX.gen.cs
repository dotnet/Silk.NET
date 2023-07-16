// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10CreateDevice1"]/*'/>
    [DllImport("d3d10_1", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateDevice1(IDXGIAdapter* pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, uint SDKVersion, ID3D10Device1** ppDevice);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10CreateDeviceAndSwapChain1"]/*'/>
    [DllImport("d3d10_1", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateDeviceAndSwapChain1(IDXGIAdapter* pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D10Device1** ppDevice);
}