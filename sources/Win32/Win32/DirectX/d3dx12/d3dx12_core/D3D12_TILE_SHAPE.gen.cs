// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_TILE_SHAPE : D3D12_TILE_SHAPE")]
[NativeInheritance("D3D12_TILE_SHAPE")]
public partial struct D3D12_TILE_SHAPE
{
    public D3D12_TILE_SHAPE(uint widthInTexels, uint heightInTexels, uint depthInTexels)
    {
        WidthInTexels = widthInTexels;
        HeightInTexels = heightInTexels;
        DepthInTexels = depthInTexels;
    }
}
