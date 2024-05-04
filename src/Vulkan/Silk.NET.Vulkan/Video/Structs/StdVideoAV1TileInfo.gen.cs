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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1TileInfo")]
    public unsafe partial struct StdVideoAV1TileInfo
    {
        public StdVideoAV1TileInfo
        (
            StdVideoAV1TileInfoFlags? flags = null,
            byte? tileCols = null,
            byte? tileRows = null,
            ushort? contextUpdateTileId = null,
            byte? tileSizeBytesMinus1 = null,
            ushort* pMiColStarts = null,
            ushort* pMiRowStarts = null,
            ushort* pWidthInSbsMinus1 = null,
            ushort* pHeightInSbsMinus1 = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (tileCols is not null)
            {
                TileCols = tileCols.Value;
            }

            if (tileRows is not null)
            {
                TileRows = tileRows.Value;
            }

            if (contextUpdateTileId is not null)
            {
                ContextUpdateTileId = contextUpdateTileId.Value;
            }

            if (tileSizeBytesMinus1 is not null)
            {
                TileSizeBytesMinus1 = tileSizeBytesMinus1.Value;
            }

            if (pMiColStarts is not null)
            {
                PMiColStarts = pMiColStarts;
            }

            if (pMiRowStarts is not null)
            {
                PMiRowStarts = pMiRowStarts;
            }

            if (pWidthInSbsMinus1 is not null)
            {
                PWidthInSbsMinus1 = pWidthInSbsMinus1;
            }

            if (pHeightInSbsMinus1 is not null)
            {
                PHeightInSbsMinus1 = pHeightInSbsMinus1;
            }
        }


        [NativeName("Type", "StdVideoAV1TileInfoFlags")]
        [NativeName("Type.Name", "StdVideoAV1TileInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoAV1TileInfoFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "TileCols")]
        public byte TileCols;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "TileRows")]
        public byte TileRows;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "context_update_tile_id")]
        public ushort ContextUpdateTileId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "tile_size_bytes_minus_1")]
        public byte TileSizeBytesMinus1;
        [NativeName("Type", "uint8_t[7]")]
        [NativeName("Type.Name", "uint8_t[7]")]
        [NativeName("Name", "reserved1")]
        public fixed byte Reserved1[7];

        [NativeName("Type", "const uint16_t *")]
        [NativeName("Type.Name", "const uint16_t *")]
        [NativeName("Name", "pMiColStarts")]
        public ushort* PMiColStarts;

        [NativeName("Type", "const uint16_t *")]
        [NativeName("Type.Name", "const uint16_t *")]
        [NativeName("Name", "pMiRowStarts")]
        public ushort* PMiRowStarts;

        [NativeName("Type", "const uint16_t *")]
        [NativeName("Type.Name", "const uint16_t *")]
        [NativeName("Name", "pWidthInSbsMinus1")]
        public ushort* PWidthInSbsMinus1;

        [NativeName("Type", "const uint16_t *")]
        [NativeName("Type.Name", "const uint16_t *")]
        [NativeName("Name", "pHeightInSbsMinus1")]
        public ushort* PHeightInSbsMinus1;
    }
}
