// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAGS")]
    public enum VideoEncoderAV1PictureControlFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_NONE")]
        VideoEncoderAV1PictureControlFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"EnableErrorResilientMode\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_ERROR_RESILIENT_MODE")]
        VideoEncoderAV1PictureControlFlagEnableErrorResilientMode = 0x1,
        [Obsolete("Deprecated in favour of \"DisableCdfUpdate\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_DISABLE_CDF_UPDATE")]
        VideoEncoderAV1PictureControlFlagDisableCdfUpdate = 0x2,
        [Obsolete("Deprecated in favour of \"EnablePaletteEncoding\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_PALETTE_ENCODING")]
        VideoEncoderAV1PictureControlFlagEnablePaletteEncoding = 0x4,
        [Obsolete("Deprecated in favour of \"EnableSkipMode\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_SKIP_MODE")]
        VideoEncoderAV1PictureControlFlagEnableSkipMode = 0x8,
        [Obsolete("Deprecated in favour of \"FrameReferenceMotionVectors\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_FRAME_REFERENCE_MOTION_VECTORS")]
        VideoEncoderAV1PictureControlFlagFrameReferenceMotionVectors = 0x10,
        [Obsolete("Deprecated in favour of \"ForceIntegerMotionVectors\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_FORCE_INTEGER_MOTION_VECTORS")]
        VideoEncoderAV1PictureControlFlagForceIntegerMotionVectors = 0x20,
        [Obsolete("Deprecated in favour of \"AllowIntraBlockCopy\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ALLOW_INTRA_BLOCK_COPY")]
        VideoEncoderAV1PictureControlFlagAllowIntraBlockCopy = 0x40,
        [Obsolete("Deprecated in favour of \"UseSuperResolution\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_USE_SUPER_RESOLUTION")]
        VideoEncoderAV1PictureControlFlagUseSuperResolution = 0x80,
        [Obsolete("Deprecated in favour of \"DisableFrameEndUpdateCdf\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_DISABLE_FRAME_END_UPDATE_CDF")]
        VideoEncoderAV1PictureControlFlagDisableFrameEndUpdateCdf = 0x100,
        [Obsolete("Deprecated in favour of \"EnableFrameSegmentationAuto\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_FRAME_SEGMENTATION_AUTO")]
        VideoEncoderAV1PictureControlFlagEnableFrameSegmentationAuto = 0x200,
        [Obsolete("Deprecated in favour of \"EnableFrameSegmentationCustom\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_FRAME_SEGMENTATION_CUSTOM")]
        VideoEncoderAV1PictureControlFlagEnableFrameSegmentationCustom = 0x400,
        [Obsolete("Deprecated in favour of \"EnableWarpedMotion\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_WARPED_MOTION")]
        VideoEncoderAV1PictureControlFlagEnableWarpedMotion = 0x800,
        [Obsolete("Deprecated in favour of \"ReducedTXSet\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_REDUCED_TX_SET")]
        VideoEncoderAV1PictureControlFlagReducedTXSet = 0x1000,
        [Obsolete("Deprecated in favour of \"MotionModeSwitchable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_MOTION_MODE_SWITCHABLE")]
        VideoEncoderAV1PictureControlFlagMotionModeSwitchable = 0x2000,
        [Obsolete("Deprecated in favour of \"AllowHighPrecisionMV\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ALLOW_HIGH_PRECISION_MV")]
        VideoEncoderAV1PictureControlFlagAllowHighPrecisionMV = 0x4000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_ERROR_RESILIENT_MODE")]
        EnableErrorResilientMode = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_DISABLE_CDF_UPDATE")]
        DisableCdfUpdate = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_PALETTE_ENCODING")]
        EnablePaletteEncoding = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_SKIP_MODE")]
        EnableSkipMode = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_FRAME_REFERENCE_MOTION_VECTORS")]
        FrameReferenceMotionVectors = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_FORCE_INTEGER_MOTION_VECTORS")]
        ForceIntegerMotionVectors = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ALLOW_INTRA_BLOCK_COPY")]
        AllowIntraBlockCopy = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_USE_SUPER_RESOLUTION")]
        UseSuperResolution = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_DISABLE_FRAME_END_UPDATE_CDF")]
        DisableFrameEndUpdateCdf = 0x100,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_FRAME_SEGMENTATION_AUTO")]
        EnableFrameSegmentationAuto = 0x200,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_FRAME_SEGMENTATION_CUSTOM")]
        EnableFrameSegmentationCustom = 0x400,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_WARPED_MOTION")]
        EnableWarpedMotion = 0x800,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_REDUCED_TX_SET")]
        ReducedTXSet = 0x1000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_MOTION_MODE_SWITCHABLE")]
        MotionModeSwitchable = 0x2000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ALLOW_HIGH_PRECISION_MV")]
        AllowHighPrecisionMV = 0x4000,
    }
}
