// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_VIEWPORT : D3D12_VIEWPORT")]
[NativeInheritance("D3D12_VIEWPORT")]
public partial struct D3D12_VIEWPORT
{
    public D3D12_VIEWPORT(
        float topLeftX,
        float topLeftY,
        float width,
        float height,
        float minDepth = (0.0f),
        float maxDepth = (1.0f)
    )
    {
        TopLeftX = topLeftX;
        TopLeftY = topLeftY;
        Width = width;
        Height = height;
        MinDepth = minDepth;
        MaxDepth = maxDepth;
    }
}
