// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAGS")]
    public enum VideoEncoderAV1FrameSubregionLayoutConfigValidationFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_NONE")]
        VideoEncoderAV1FrameSubregionLayoutConfigValidationFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"NotSpecified\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_NOT_SPECIFIED")]
        VideoEncoderAV1FrameSubregionLayoutConfigValidationFlagNotSpecified = 0x1,
        [Obsolete("Deprecated in favour of \"CodecConstraint\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_CODEC_CONSTRAINT")]
        VideoEncoderAV1FrameSubregionLayoutConfigValidationFlagCodecConstraint = 0x2,
        [Obsolete("Deprecated in favour of \"HardwareConstraint\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_HARDWARE_CONSTRAINT")]
        VideoEncoderAV1FrameSubregionLayoutConfigValidationFlagHardwareConstraint = 0x4,
        [Obsolete("Deprecated in favour of \"RowsCount\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_ROWS_COUNT")]
        VideoEncoderAV1FrameSubregionLayoutConfigValidationFlagRowsCount = 0x8,
        [Obsolete("Deprecated in favour of \"ColsCount\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_COLS_COUNT")]
        VideoEncoderAV1FrameSubregionLayoutConfigValidationFlagColsCount = 0x10,
        [Obsolete("Deprecated in favour of \"Width\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_WIDTH")]
        VideoEncoderAV1FrameSubregionLayoutConfigValidationFlagWidth = 0x20,
        [Obsolete("Deprecated in favour of \"Area\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_AREA")]
        VideoEncoderAV1FrameSubregionLayoutConfigValidationFlagArea = 0x40,
        [Obsolete("Deprecated in favour of \"TotalTiles\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_TOTAL_TILES")]
        VideoEncoderAV1FrameSubregionLayoutConfigValidationFlagTotalTiles = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_NOT_SPECIFIED")]
        NotSpecified = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_CODEC_CONSTRAINT")]
        CodecConstraint = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_HARDWARE_CONSTRAINT")]
        HardwareConstraint = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_ROWS_COUNT")]
        RowsCount = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_COLS_COUNT")]
        ColsCount = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_WIDTH")]
        Width = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_AREA")]
        Area = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_FLAG_TOTAL_TILES")]
        TotalTiles = 0x80,
    }
}
