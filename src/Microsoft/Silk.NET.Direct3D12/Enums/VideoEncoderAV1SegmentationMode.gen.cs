// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE")]
    public enum VideoEncoderAV1SegmentationMode : int
    {
        [Obsolete("Deprecated in favour of \"Disabled\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_DISABLED")]
        VideoEncoderAV1SegmentationModeDisabled = 0x0,
        [Obsolete("Deprecated in favour of \"AltQ\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_Q")]
        VideoEncoderAV1SegmentationModeAltQ = 0x1,
        [Obsolete("Deprecated in favour of \"AltLFYV\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_Y_V")]
        VideoEncoderAV1SegmentationModeAltLFYV = 0x2,
        [Obsolete("Deprecated in favour of \"AltLFYH\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_Y_H")]
        VideoEncoderAV1SegmentationModeAltLFYH = 0x3,
        [Obsolete("Deprecated in favour of \"AltLFU\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_U")]
        VideoEncoderAV1SegmentationModeAltLFU = 0x4,
        [Obsolete("Deprecated in favour of \"AltLFV\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_V")]
        VideoEncoderAV1SegmentationModeAltLFV = 0x5,
        [Obsolete("Deprecated in favour of \"AltRefFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_REF_FRAME")]
        VideoEncoderAV1SegmentationModeAltRefFrame = 0x6,
        [Obsolete("Deprecated in favour of \"AltSkip\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_SKIP")]
        VideoEncoderAV1SegmentationModeAltSkip = 0x7,
        [Obsolete("Deprecated in favour of \"AltGlobalmv\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_GLOBALMV")]
        VideoEncoderAV1SegmentationModeAltGlobalmv = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_DISABLED")]
        Disabled = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_Q")]
        AltQ = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_Y_V")]
        AltLFYV = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_Y_H")]
        AltLFYH = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_U")]
        AltLFU = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_V")]
        AltLFV = 0x5,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_REF_FRAME")]
        AltRefFrame = 0x6,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_SKIP")]
        AltSkip = 0x7,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_GLOBALMV")]
        AltGlobalmv = 0x8,
    }
}
