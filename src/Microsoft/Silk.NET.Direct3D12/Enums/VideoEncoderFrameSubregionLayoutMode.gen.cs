// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
    public enum VideoEncoderFrameSubregionLayoutMode : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_FULL_FRAME")]
        VideoEncoderFrameSubregionLayoutModeFullFrame = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_BYTES_PER_SUBREGION")]
        VideoEncoderFrameSubregionLayoutModeBytesPerSubregion = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_SQUARE_UNITS_PER_SUBREGION_ROW_UNALIGNED")]
        VideoEncoderFrameSubregionLayoutModeSquareUnitsPerSubregionRowUnaligned = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_ROWS_PER_SUBREGION")]
        VideoEncoderFrameSubregionLayoutModeUniformPartitioningRowsPerSubregion = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_SUBREGIONS_PER_FRAME")]
        VideoEncoderFrameSubregionLayoutModeUniformPartitioningSubregionsPerFrame = 0x4,
    }
}
