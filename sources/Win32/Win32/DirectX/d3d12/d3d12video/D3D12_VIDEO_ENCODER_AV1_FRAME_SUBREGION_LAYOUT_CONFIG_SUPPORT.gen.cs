// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_SUPPORT
{
    public BOOL Use128SuperBlocks;
    public D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES TilesConfiguration;
    public D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAGS ValidationFlags;
    public uint MinTileRows;
    public uint MaxTileRows;
    public uint MinTileCols;
    public uint MaxTileCols;
    public uint MinTileWidth;
    public uint MaxTileWidth;
    public uint MinTileArea;
    public uint MaxTileArea;
    public uint TileSizeBytesMinus1;
}
