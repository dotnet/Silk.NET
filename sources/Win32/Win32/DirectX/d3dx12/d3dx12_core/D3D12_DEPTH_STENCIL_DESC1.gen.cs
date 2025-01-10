// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_DEPTH_STENCIL_DESC1 : D3D12_DEPTH_STENCIL_DESC1")]
[NativeInheritance("D3D12_DEPTH_STENCIL_DESC1")]
public unsafe partial struct D3D12_DEPTH_STENCIL_DESC1
{
    public D3D12_DEPTH_STENCIL_DESC1(
        [NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* o
    )
    {
        DepthEnable = o->DepthEnable;
        DepthWriteMask = o->DepthWriteMask;
        DepthFunc = o->DepthFunc;
        StencilEnable = o->StencilEnable;
        StencilReadMask = o->StencilReadMask;
        StencilWriteMask = o->StencilWriteMask;
        FrontFace.StencilFailOp = o->FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o->FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o->FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o->FrontFace.StencilFunc;
        BackFace.StencilFailOp = o->BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o->BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o->BackFace.StencilPassOp;
        BackFace.StencilFunc = o->BackFace.StencilFunc;
        DepthBoundsTestEnable = 0;
    }

    public D3D12_DEPTH_STENCIL_DESC1(
        BOOL depthEnable,
        D3D12_DEPTH_WRITE_MASK depthWriteMask,
        D3D12_COMPARISON_FUNC depthFunc,
        BOOL stencilEnable,
        [NativeTypeName("UINT8")] byte stencilReadMask,
        [NativeTypeName("UINT8")] byte stencilWriteMask,
        D3D12_STENCIL_OP frontStencilFailOp,
        D3D12_STENCIL_OP frontStencilDepthFailOp,
        D3D12_STENCIL_OP frontStencilPassOp,
        D3D12_COMPARISON_FUNC frontStencilFunc,
        D3D12_STENCIL_OP backStencilFailOp,
        D3D12_STENCIL_OP backStencilDepthFailOp,
        D3D12_STENCIL_OP backStencilPassOp,
        D3D12_COMPARISON_FUNC backStencilFunc,
        BOOL depthBoundsTestEnable
    )
    {
        DepthEnable = depthEnable;
        DepthWriteMask = depthWriteMask;
        DepthFunc = depthFunc;
        StencilEnable = stencilEnable;
        StencilReadMask = stencilReadMask;
        StencilWriteMask = stencilWriteMask;
        FrontFace.StencilFailOp = frontStencilFailOp;
        FrontFace.StencilDepthFailOp = frontStencilDepthFailOp;
        FrontFace.StencilPassOp = frontStencilPassOp;
        FrontFace.StencilFunc = frontStencilFunc;
        BackFace.StencilFailOp = backStencilFailOp;
        BackFace.StencilDepthFailOp = backStencilDepthFailOp;
        BackFace.StencilPassOp = backStencilPassOp;
        BackFace.StencilFunc = backStencilFunc;
        DepthBoundsTestEnable = depthBoundsTestEnable;
    }
}
