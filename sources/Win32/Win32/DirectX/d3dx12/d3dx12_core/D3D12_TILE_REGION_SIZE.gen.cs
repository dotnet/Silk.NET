// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_TILE_REGION_SIZE : D3D12_TILE_REGION_SIZE")]
[NativeInheritance("D3D12_TILE_REGION_SIZE")]
public partial struct D3D12_TILE_REGION_SIZE
{
    public D3D12_TILE_REGION_SIZE(
        uint numTiles,
        BOOL useBox,
        uint width,
        [NativeTypeName("UINT16")] ushort height,
        [NativeTypeName("UINT16")] ushort depth
    )
    {
        NumTiles = numTiles;
        UseBox = useBox;
        Width = width;
        Height = height;
        Depth = depth;
    }
}
