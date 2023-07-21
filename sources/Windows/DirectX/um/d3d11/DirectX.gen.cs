// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D11CalcSubresource"]/*' />
    public static uint D3D11CalcSubresource(uint MipSlice, uint ArraySlice, uint MipLevels)
    {
        return MipSlice + ArraySlice * MipLevels;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D11CreateDevice"]/*' />
    [DllImport("d3d11", ExactSpelling = true)]
    public static extern HRESULT D3D11CreateDevice(IDXGIAdapter* pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3D_FEATURE_LEVEL* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D11CreateDeviceAndSwapChain"]/*' />
    [DllImport("d3d11", ExactSpelling = true)]
    public static extern HRESULT D3D11CreateDeviceAndSwapChain(IDXGIAdapter* pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3D_FEATURE_LEVEL* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

    [NativeTypeName("#define _FACD3D11 ( 0x87c )")]
    public const int _FACD3D11 = (0x87c);

    [NativeTypeName("#define _FACD3D11DEBUG ( ( _FACD3D11 + 1 )  )")]
    public const int _FACD3D11DEBUG = (((0x87c) + 1));
}
