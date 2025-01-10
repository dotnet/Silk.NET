// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_RASTERIZER_DESC1 : D3D12_RASTERIZER_DESC1")]
[NativeInheritance("D3D12_RASTERIZER_DESC1")]
public unsafe partial struct D3D12_RASTERIZER_DESC1
{
    public D3D12_RASTERIZER_DESC1(
        [NativeTypeName("const D3D12_RASTERIZER_DESC &")] D3D12_RASTERIZER_DESC* o
    )
    {
        FillMode = o->FillMode;
        CullMode = o->CullMode;
        FrontCounterClockwise = o->FrontCounterClockwise;
        DepthBias = (float)(o->DepthBias);
        DepthBiasClamp = o->DepthBiasClamp;
        SlopeScaledDepthBias = o->SlopeScaledDepthBias;
        DepthClipEnable = o->DepthClipEnable;
        MultisampleEnable = o->MultisampleEnable;
        AntialiasedLineEnable = o->AntialiasedLineEnable;
        ForcedSampleCount = o->ForcedSampleCount;
        ConservativeRaster = o->ConservativeRaster;
    }

    public D3D12_RASTERIZER_DESC1(
        D3D12_FILL_MODE fillMode,
        D3D12_CULL_MODE cullMode,
        BOOL frontCounterClockwise,
        float depthBias,
        float depthBiasClamp,
        float slopeScaledDepthBias,
        BOOL depthClipEnable,
        BOOL multisampleEnable,
        BOOL antialiasedLineEnable,
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
        MultisampleEnable = multisampleEnable;
        AntialiasedLineEnable = antialiasedLineEnable;
        ForcedSampleCount = forcedSampleCount;
        ConservativeRaster = conservativeRaster;
    }
}
