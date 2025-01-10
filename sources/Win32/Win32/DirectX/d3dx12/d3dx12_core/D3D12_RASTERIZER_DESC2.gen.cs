// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using static Silk.NET.DirectX.D3D12_LINE_RASTERIZATION_MODE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_RASTERIZER_DESC2 : D3D12_RASTERIZER_DESC2")]
[NativeInheritance("D3D12_RASTERIZER_DESC2")]
public unsafe partial struct D3D12_RASTERIZER_DESC2
{
    public D3D12_RASTERIZER_DESC2(
        [NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] D3D12_RASTERIZER_DESC1* o
    )
    {
        FillMode = o->FillMode;
        CullMode = o->CullMode;
        FrontCounterClockwise = o->FrontCounterClockwise;
        DepthBias = o->DepthBias;
        DepthBiasClamp = o->DepthBiasClamp;
        SlopeScaledDepthBias = o->SlopeScaledDepthBias;
        DepthClipEnable = o->DepthClipEnable;
        LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_ALIASED;
        if ((o->MultisampleEnable) != 0)
        {
            LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_WIDE;
        }
        else if ((o->AntialiasedLineEnable) != 0)
        {
            LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_ALPHA_ANTIALIASED;
        }
        ForcedSampleCount = o->ForcedSampleCount;
        ConservativeRaster = o->ConservativeRaster;
    }

    public D3D12_RASTERIZER_DESC2(
        D3D12_FILL_MODE fillMode,
        D3D12_CULL_MODE cullMode,
        BOOL frontCounterClockwise,
        float depthBias,
        float depthBiasClamp,
        float slopeScaledDepthBias,
        BOOL depthClipEnable,
        D3D12_LINE_RASTERIZATION_MODE lineRasterizationMode,
        uint forcedSampleCount,
        D3D12_CONSERVATIVE_RASTERIZATION_MODE conservativeRaster
    )
    {
        FillMode = fillMode;
        CullMode = cullMode;
        FrontCounterClockwise = frontCounterClockwise;
        DepthBias = depthBias;
        DepthBiasClamp = depthBiasClamp;
        SlopeScaledDepthBias = slopeScaledDepthBias;
        DepthClipEnable = depthClipEnable;
        LineRasterizationMode = lineRasterizationMode;
        ForcedSampleCount = forcedSampleCount;
        ConservativeRaster = conservativeRaster;
    }
}
