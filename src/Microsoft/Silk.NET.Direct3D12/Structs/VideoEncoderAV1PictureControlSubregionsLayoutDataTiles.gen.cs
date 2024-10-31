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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES")]
    public unsafe partial struct VideoEncoderAV1PictureControlSubregionsLayoutDataTiles
    {
        public VideoEncoderAV1PictureControlSubregionsLayoutDataTiles
        (
            ulong? rowCount = null,
            ulong? colCount = null,
            ulong? contextUpdateTileId = null
        ) : this()
        {
            if (rowCount is not null)
            {
                RowCount = rowCount.Value;
            }

            if (colCount is not null)
            {
                ColCount = colCount.Value;
            }

            if (contextUpdateTileId is not null)
            {
                ContextUpdateTileId = contextUpdateTileId.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "RowCount")]
        public ulong RowCount;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "ColCount")]
        public ulong ColCount;
        [NativeName("Type", "UINT64[64]")]
        [NativeName("Type.Name", "UINT64[64]")]
        [NativeName("Name", "RowHeights")]
        public fixed ulong RowHeights[64];
        [NativeName("Type", "UINT64[64]")]
        [NativeName("Type.Name", "UINT64[64]")]
        [NativeName("Name", "ColWidths")]
        public fixed ulong ColWidths[64];

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "ContextUpdateTileId")]
        public ulong ContextUpdateTileId;
    }
}
