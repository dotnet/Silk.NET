// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_SUBRESOURCE_TILING : D3D12_SUBRESOURCE_TILING")]
[NativeInheritance("D3D12_SUBRESOURCE_TILING")]
public partial struct D3D12_SUBRESOURCE_TILING
{
    public D3D12_SUBRESOURCE_TILING(
        uint widthInTiles,
        [NativeTypeName("UINT16")] ushort heightInTiles,
        [NativeTypeName("UINT16")] ushort depthInTiles,
        uint startTileIndexInOverallResource
    )
    {
        WidthInTiles = widthInTiles;
        HeightInTiles = heightInTiles;
        DepthInTiles = depthInTiles;
        StartTileIndexInOverallResource = startTileIndexInOverallResource;
    }
}
