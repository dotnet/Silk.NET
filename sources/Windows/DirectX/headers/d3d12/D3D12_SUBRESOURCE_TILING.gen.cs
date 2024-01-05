// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_SUBRESOURCE_TILING.xml' path='doc/member[@name="D3D12_SUBRESOURCE_TILING"]/*'/>
public partial struct D3D12_SUBRESOURCE_TILING
{
    /// <include file='D3D12_SUBRESOURCE_TILING.xml' path='doc/member[@name="D3D12_SUBRESOURCE_TILING.WidthInTiles"]/*'/>

    public uint WidthInTiles;

    /// <include file='D3D12_SUBRESOURCE_TILING.xml' path='doc/member[@name="D3D12_SUBRESOURCE_TILING.HeightInTiles"]/*'/>

    [NativeTypeName("UINT16")]
    public ushort HeightInTiles;

    /// <include file='D3D12_SUBRESOURCE_TILING.xml' path='doc/member[@name="D3D12_SUBRESOURCE_TILING.DepthInTiles"]/*'/>

    [NativeTypeName("UINT16")]
    public ushort DepthInTiles;

    /// <include file='D3D12_SUBRESOURCE_TILING.xml' path='doc/member[@name="D3D12_SUBRESOURCE_TILING.StartTileIndexInOverallResource"]/*'/>

    public uint StartTileIndexInOverallResource;
}
