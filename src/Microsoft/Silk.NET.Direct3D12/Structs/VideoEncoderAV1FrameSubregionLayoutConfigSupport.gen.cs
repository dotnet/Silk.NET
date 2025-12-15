// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_SUPPORT")]
    public unsafe partial struct VideoEncoderAV1FrameSubregionLayoutConfigSupport
    {
        public VideoEncoderAV1FrameSubregionLayoutConfigSupport
        (
            Silk.NET.Core.Bool32? use128SuperBlocks = null,
            VideoEncoderAV1PictureControlSubregionsLayoutDataTiles? tilesConfiguration = null,
            VideoEncoderAV1FrameSubregionLayoutConfigValidationFlags? validationFlags = null,
            uint? minTileRows = null,
            uint? maxTileRows = null,
            uint? minTileCols = null,
            uint? maxTileCols = null,
            uint? minTileWidth = null,
            uint? maxTileWidth = null,
            uint? minTileArea = null,
            uint? maxTileArea = null,
            uint? tileSizeBytesMinus1 = null
        ) : this()
        {
            if (use128SuperBlocks is not null)
            {
                Use128SuperBlocks = use128SuperBlocks.Value;
            }

            if (tilesConfiguration is not null)
            {
                TilesConfiguration = tilesConfiguration.Value;
            }

            if (validationFlags is not null)
            {
                ValidationFlags = validationFlags.Value;
            }

            if (minTileRows is not null)
            {
                MinTileRows = minTileRows.Value;
            }

            if (maxTileRows is not null)
            {
                MaxTileRows = maxTileRows.Value;
            }

            if (minTileCols is not null)
            {
                MinTileCols = minTileCols.Value;
            }

            if (maxTileCols is not null)
            {
                MaxTileCols = maxTileCols.Value;
            }

            if (minTileWidth is not null)
            {
                MinTileWidth = minTileWidth.Value;
            }

            if (maxTileWidth is not null)
            {
                MaxTileWidth = maxTileWidth.Value;
            }

            if (minTileArea is not null)
            {
                MinTileArea = minTileArea.Value;
            }

            if (maxTileArea is not null)
            {
                MaxTileArea = maxTileArea.Value;
            }

            if (tileSizeBytesMinus1 is not null)
            {
                TileSizeBytesMinus1 = tileSizeBytesMinus1.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Use128SuperBlocks")]
        public Silk.NET.Core.Bool32 Use128SuperBlocks;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES")]
        [NativeName("Name", "TilesConfiguration")]
        public VideoEncoderAV1PictureControlSubregionsLayoutDataTiles TilesConfiguration;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAGS")]
        [NativeName("Name", "ValidationFlags")]
        public VideoEncoderAV1FrameSubregionLayoutConfigValidationFlags ValidationFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MinTileRows")]
        public uint MinTileRows;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxTileRows")]
        public uint MaxTileRows;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MinTileCols")]
        public uint MinTileCols;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxTileCols")]
        public uint MaxTileCols;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MinTileWidth")]
        public uint MinTileWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxTileWidth")]
        public uint MaxTileWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MinTileArea")]
        public uint MinTileArea;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxTileArea")]
        public uint MaxTileArea;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TileSizeBytesMinus1")]
        public uint TileSizeBytesMinus1;
    }
}
