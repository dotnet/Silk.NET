// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_DEPTH_STENCILOP_DESC1
{
    public D3D12_STENCIL_OP StencilFailOp;
    public D3D12_STENCIL_OP StencilDepthFailOp;
    public D3D12_STENCIL_OP StencilPassOp;
    public D3D12_COMPARISON_FUNC StencilFunc;

    [NativeTypeName("UINT8")]
    public byte StencilReadMask;

    [NativeTypeName("UINT8")]
    public byte StencilWriteMask;
}
