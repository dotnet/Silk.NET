// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
    public enum VideoEncoderFrameSubregionLayoutMode : int
    {
        [Obsolete("Deprecated in favour of \"FullFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_FULL_FRAME")]
        VideoEncoderFrameSubregionLayoutModeFullFrame = 0x0,
        [Obsolete("Deprecated in favour of \"BytesPerSubregion\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_BYTES_PER_SUBREGION")]
        VideoEncoderFrameSubregionLayoutModeBytesPerSubregion = 0x1,
        [Obsolete("Deprecated in favour of \"SquareUnitsPerSubregionRowUnaligned\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_SQUARE_UNITS_PER_SUBREGION_ROW_UNALIGNED")]
        VideoEncoderFrameSubregionLayoutModeSquareUnitsPerSubregionRowUnaligned = 0x2,
        [Obsolete("Deprecated in favour of \"UniformPartitioningRowsPerSubregion\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_ROWS_PER_SUBREGION")]
        VideoEncoderFrameSubregionLayoutModeUniformPartitioningRowsPerSubregion = 0x3,
        [Obsolete("Deprecated in favour of \"UniformPartitioningSubregionsPerFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_SUBREGIONS_PER_FRAME")]
        VideoEncoderFrameSubregionLayoutModeUniformPartitioningSubregionsPerFrame = 0x4,
        [Obsolete("Deprecated in favour of \"UniformGridPartition\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_GRID_PARTITION")]
        VideoEncoderFrameSubregionLayoutModeUniformGridPartition = 0x5,
        [Obsolete("Deprecated in favour of \"ConfigurableGridPartition\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_CONFIGURABLE_GRID_PARTITION")]
        VideoEncoderFrameSubregionLayoutModeConfigurableGridPartition = 0x6,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_FULL_FRAME")]
        FullFrame = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_BYTES_PER_SUBREGION")]
        BytesPerSubregion = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_SQUARE_UNITS_PER_SUBREGION_ROW_UNALIGNED")]
        SquareUnitsPerSubregionRowUnaligned = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_ROWS_PER_SUBREGION")]
        UniformPartitioningRowsPerSubregion = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_SUBREGIONS_PER_FRAME")]
        UniformPartitioningSubregionsPerFrame = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_GRID_PARTITION")]
        UniformGridPartition = 0x5,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_CONFIGURABLE_GRID_PARTITION")]
        ConfigurableGridPartition = 0x6,
    }
}
