// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS")]
    public enum VideoEncoderAV1SegmentationModeFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_NONE")]
        VideoEncoderAV1SegmentationModeFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Disabled\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_DISABLED")]
        VideoEncoderAV1SegmentationModeFlagDisabled = 0x1,
        [Obsolete("Deprecated in favour of \"AltQ\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_Q")]
        VideoEncoderAV1SegmentationModeFlagAltQ = 0x2,
        [Obsolete("Deprecated in favour of \"AltLFYV\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_Y_V")]
        VideoEncoderAV1SegmentationModeFlagAltLFYV = 0x4,
        [Obsolete("Deprecated in favour of \"AltLFYH\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_Y_H")]
        VideoEncoderAV1SegmentationModeFlagAltLFYH = 0x8,
        [Obsolete("Deprecated in favour of \"AltLFU\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_U")]
        VideoEncoderAV1SegmentationModeFlagAltLFU = 0x10,
        [Obsolete("Deprecated in favour of \"AltLFV\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_V")]
        VideoEncoderAV1SegmentationModeFlagAltLFV = 0x20,
        [Obsolete("Deprecated in favour of \"RefFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_REF_FRAME")]
        VideoEncoderAV1SegmentationModeFlagRefFrame = 0x40,
        [Obsolete("Deprecated in favour of \"AltSkip\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_SKIP")]
        VideoEncoderAV1SegmentationModeFlagAltSkip = 0x80,
        [Obsolete("Deprecated in favour of \"AltGlobalmv\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_GLOBALMV")]
        VideoEncoderAV1SegmentationModeFlagAltGlobalmv = 0x100,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_DISABLED")]
        Disabled = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_Q")]
        AltQ = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_Y_V")]
        AltLFYV = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_Y_H")]
        AltLFYH = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_U")]
        AltLFU = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_V")]
        AltLFV = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_REF_FRAME")]
        RefFrame = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_SKIP")]
        AltSkip = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_GLOBALMV")]
        AltGlobalmv = 0x100,
    }
}
