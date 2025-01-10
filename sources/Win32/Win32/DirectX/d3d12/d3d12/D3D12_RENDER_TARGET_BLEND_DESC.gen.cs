// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_RENDER_TARGET_BLEND_DESC
{
    public BOOL BlendEnable;
    public BOOL LogicOpEnable;
    public D3D12_BLEND SrcBlend;
    public D3D12_BLEND DestBlend;
    public D3D12_BLEND_OP BlendOp;
    public D3D12_BLEND SrcBlendAlpha;
    public D3D12_BLEND DestBlendAlpha;
    public D3D12_BLEND_OP BlendOpAlpha;
    public D3D12_LOGIC_OP LogicOp;

    [NativeTypeName("UINT8")]
    public byte RenderTargetWriteMask;
}
