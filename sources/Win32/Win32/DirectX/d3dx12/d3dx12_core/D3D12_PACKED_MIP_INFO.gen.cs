// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_PACKED_MIP_INFO : D3D12_PACKED_MIP_INFO")]
[NativeInheritance("D3D12_PACKED_MIP_INFO")]
public partial struct D3D12_PACKED_MIP_INFO
{
    public D3D12_PACKED_MIP_INFO(
        [NativeTypeName("UINT8")] byte numStandardMips,
        [NativeTypeName("UINT8")] byte numPackedMips,
        uint numTilesForPackedMips,
        uint startTileIndexInOverallResource
    )
    {
        NumStandardMips = numStandardMips;
        NumPackedMips = numPackedMips;
        NumTilesForPackedMips = numTilesForPackedMips;
        StartTileIndexInOverallResource = startTileIndexInOverallResource;
    }
}
