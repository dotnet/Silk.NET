// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS")]
    public enum VideoEncoderCodecConfigurationHevcFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_NONE")]
        VideoEncoderCodecConfigurationHevcFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"DisableLoopFilterAcrossSlices\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_DISABLE_LOOP_FILTER_ACROSS_SLICES")]
        VideoEncoderCodecConfigurationHevcFlagDisableLoopFilterAcrossSlices = 0x1,
        [Obsolete("Deprecated in favour of \"AllowRequestIntraConstrainedSlices\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES")]
        VideoEncoderCodecConfigurationHevcFlagAllowRequestIntraConstrainedSlices = 0x2,
        [Obsolete("Deprecated in favour of \"EnableSaoFilter\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_SAO_FILTER")]
        VideoEncoderCodecConfigurationHevcFlagEnableSaoFilter = 0x4,
        [Obsolete("Deprecated in favour of \"EnableLongTermReferences\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_LONG_TERM_REFERENCES")]
        VideoEncoderCodecConfigurationHevcFlagEnableLongTermReferences = 0x8,
        [Obsolete("Deprecated in favour of \"UseAsymetricMotionPartition\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_ASYMETRIC_MOTION_PARTITION")]
        VideoEncoderCodecConfigurationHevcFlagUseAsymetricMotionPartition = 0x10,
        [Obsolete("Deprecated in favour of \"EnableTransformSkipping\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_TRANSFORM_SKIPPING")]
        VideoEncoderCodecConfigurationHevcFlagEnableTransformSkipping = 0x20,
        [Obsolete("Deprecated in favour of \"UseConstrainedIntraprediction\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_CONSTRAINED_INTRAPREDICTION")]
        VideoEncoderCodecConfigurationHevcFlagUseConstrainedIntraprediction = 0x40,
        [Obsolete("Deprecated in favour of \"TransformSkipRotation\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_TRANSFORM_SKIP_ROTATION")]
        VideoEncoderCodecConfigurationHevcFlagTransformSkipRotation = 0x80,
        [Obsolete("Deprecated in favour of \"TransformSkipContext\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_TRANSFORM_SKIP_CONTEXT")]
        VideoEncoderCodecConfigurationHevcFlagTransformSkipContext = 0x100,
        [Obsolete("Deprecated in favour of \"ImplicitRdpcm\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_IMPLICIT_RDPCM")]
        VideoEncoderCodecConfigurationHevcFlagImplicitRdpcm = 0x200,
        [Obsolete("Deprecated in favour of \"ExplicitRdpcm\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_EXPLICIT_RDPCM")]
        VideoEncoderCodecConfigurationHevcFlagExplicitRdpcm = 0x400,
        [Obsolete("Deprecated in favour of \"ExtendedPrecisionProcessing\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_EXTENDED_PRECISION_PROCESSING")]
        VideoEncoderCodecConfigurationHevcFlagExtendedPrecisionProcessing = 0x800,
        [Obsolete("Deprecated in favour of \"IntraSmoothingDisabled\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_INTRA_SMOOTHING_DISABLED")]
        VideoEncoderCodecConfigurationHevcFlagIntraSmoothingDisabled = 0x1000,
        [Obsolete("Deprecated in favour of \"HighPrecisionOffsets\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_HIGH_PRECISION_OFFSETS")]
        VideoEncoderCodecConfigurationHevcFlagHighPrecisionOffsets = 0x2000,
        [Obsolete("Deprecated in favour of \"PersistentRiceAdaptation\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_PERSISTENT_RICE_ADAPTATION")]
        VideoEncoderCodecConfigurationHevcFlagPersistentRiceAdaptation = 0x4000,
        [Obsolete("Deprecated in favour of \"CabacBypassAlignment\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_CABAC_BYPASS_ALIGNMENT")]
        VideoEncoderCodecConfigurationHevcFlagCabacBypassAlignment = 0x8000,
        [Obsolete("Deprecated in favour of \"SeparateColourPlane\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_SEPARATE_COLOUR_PLANE")]
        VideoEncoderCodecConfigurationHevcFlagSeparateColourPlane = 0x10000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_DISABLE_LOOP_FILTER_ACROSS_SLICES")]
        DisableLoopFilterAcrossSlices = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES")]
        AllowRequestIntraConstrainedSlices = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_SAO_FILTER")]
        EnableSaoFilter = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_LONG_TERM_REFERENCES")]
        EnableLongTermReferences = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_ASYMETRIC_MOTION_PARTITION")]
        UseAsymetricMotionPartition = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_TRANSFORM_SKIPPING")]
        EnableTransformSkipping = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_CONSTRAINED_INTRAPREDICTION")]
        UseConstrainedIntraprediction = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_TRANSFORM_SKIP_ROTATION")]
        TransformSkipRotation = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_TRANSFORM_SKIP_CONTEXT")]
        TransformSkipContext = 0x100,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_IMPLICIT_RDPCM")]
        ImplicitRdpcm = 0x200,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_EXPLICIT_RDPCM")]
        ExplicitRdpcm = 0x400,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_EXTENDED_PRECISION_PROCESSING")]
        ExtendedPrecisionProcessing = 0x800,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_INTRA_SMOOTHING_DISABLED")]
        IntraSmoothingDisabled = 0x1000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_HIGH_PRECISION_OFFSETS")]
        HighPrecisionOffsets = 0x2000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_PERSISTENT_RICE_ADAPTATION")]
        PersistentRiceAdaptation = 0x4000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_CABAC_BYPASS_ALIGNMENT")]
        CabacBypassAlignment = 0x8000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_SEPARATE_COLOUR_PLANE")]
        SeparateColourPlane = 0x10000,
    }
}
