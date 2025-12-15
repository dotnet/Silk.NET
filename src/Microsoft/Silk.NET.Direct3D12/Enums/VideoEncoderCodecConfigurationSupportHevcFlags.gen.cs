// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS")]
    public enum VideoEncoderCodecConfigurationSupportHevcFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_NONE")]
        VideoEncoderCodecConfigurationSupportHevcFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"BframeLtrCombinedSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_BFRAME_LTR_COMBINED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagBframeLtrCombinedSupport = 0x1,
        [Obsolete("Deprecated in favour of \"IntraSliceConstrainedEncodingSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_INTRA_SLICE_CONSTRAINED_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagIntraSliceConstrainedEncodingSupport = 0x2,
        [Obsolete("Deprecated in favour of \"ConstrainedIntrapredictionSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CONSTRAINED_INTRAPREDICTION_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagConstrainedIntrapredictionSupport = 0x4,
        [Obsolete("Deprecated in favour of \"SaoFilterSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_SAO_FILTER_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagSaoFilterSupport = 0x8,
        [Obsolete("Deprecated in favour of \"AsymetricMotionPartitionSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_ASYMETRIC_MOTION_PARTITION_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagAsymetricMotionPartitionSupport = 0x10,
        [Obsolete("Deprecated in favour of \"AsymetricMotionPartitionRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_ASYMETRIC_MOTION_PARTITION_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagAsymetricMotionPartitionRequired = 0x20,
        [Obsolete("Deprecated in favour of \"TransformSkipSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagTransformSkipSupport = 0x40,
        [Obsolete("Deprecated in favour of \"DisablingLoopFilterAcrossSlicesSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_DISABLING_LOOP_FILTER_ACROSS_SLICES_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagDisablingLoopFilterAcrossSlicesSupport = 0x80,
        [Obsolete("Deprecated in favour of \"PFramesImplementedAsLowDelayBFrames\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_P_FRAMES_IMPLEMENTED_AS_LOW_DELAY_B_FRAMES")]
        VideoEncoderCodecConfigurationSupportHevcFlagPFramesImplementedAsLowDelayBFrames = 0x100,
        [Obsolete("Deprecated in favour of \"NumRefIdxActiveOverrideFlagSliceSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_NUM_REF_IDX_ACTIVE_OVERRIDE_FLAG_SLICE_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagNumRefIdxActiveOverrideFlagSliceSupport = 0x200,
        [Obsolete("Deprecated in favour of \"TransformSkipRotationEnabledSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_ROTATION_ENABLED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagTransformSkipRotationEnabledSupport = 0x400,
        [Obsolete("Deprecated in favour of \"TransformSkipRotationEnabledRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_ROTATION_ENABLED_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagTransformSkipRotationEnabledRequired = 0x800,
        [Obsolete("Deprecated in favour of \"TransformSkipContextEnabledSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_CONTEXT_ENABLED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagTransformSkipContextEnabledSupport = 0x1000,
        [Obsolete("Deprecated in favour of \"TransformSkipContextEnabledRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_CONTEXT_ENABLED_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagTransformSkipContextEnabledRequired = 0x2000,
        [Obsolete("Deprecated in favour of \"ImplicitRdpcmEnabledSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_IMPLICIT_RDPCM_ENABLED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagImplicitRdpcmEnabledSupport = 0x4000,
        [Obsolete("Deprecated in favour of \"ImplicitRdpcmEnabledRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_IMPLICIT_RDPCM_ENABLED_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagImplicitRdpcmEnabledRequired = 0x8000,
        [Obsolete("Deprecated in favour of \"ExplicitRdpcmEnabledSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_EXPLICIT_RDPCM_ENABLED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagExplicitRdpcmEnabledSupport = 0x10000,
        [Obsolete("Deprecated in favour of \"ExplicitRdpcmEnabledRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_EXPLICIT_RDPCM_ENABLED_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagExplicitRdpcmEnabledRequired = 0x20000,
        [Obsolete("Deprecated in favour of \"ExtendedPrecisionProcessingSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_EXTENDED_PRECISION_PROCESSING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagExtendedPrecisionProcessingSupport = 0x40000,
        [Obsolete("Deprecated in favour of \"ExtendedPrecisionProcessingRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_EXTENDED_PRECISION_PROCESSING_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagExtendedPrecisionProcessingRequired = 0x80000,
        [Obsolete("Deprecated in favour of \"IntraSmoothingDisabledSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_INTRA_SMOOTHING_DISABLED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagIntraSmoothingDisabledSupport = 0x100000,
        [Obsolete("Deprecated in favour of \"IntraSmoothingDisabledRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_INTRA_SMOOTHING_DISABLED_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagIntraSmoothingDisabledRequired = 0x200000,
        [Obsolete("Deprecated in favour of \"HighPrecisionOffsetsEnabledSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_HIGH_PRECISION_OFFSETS_ENABLED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagHighPrecisionOffsetsEnabledSupport = 0x400000,
        [Obsolete("Deprecated in favour of \"HighPrecisionOffsetsEnabledRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_HIGH_PRECISION_OFFSETS_ENABLED_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagHighPrecisionOffsetsEnabledRequired = 0x800000,
        [Obsolete("Deprecated in favour of \"PersistentRiceAdaptationEnabledSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_PERSISTENT_RICE_ADAPTATION_ENABLED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagPersistentRiceAdaptationEnabledSupport = 0x1000000,
        [Obsolete("Deprecated in favour of \"PersistentRiceAdaptationEnabledRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_PERSISTENT_RICE_ADAPTATION_ENABLED_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagPersistentRiceAdaptationEnabledRequired = 0x2000000,
        [Obsolete("Deprecated in favour of \"CabacBypassAlignmentEnabledSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CABAC_BYPASS_ALIGNMENT_ENABLED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagCabacBypassAlignmentEnabledSupport = 0x4000000,
        [Obsolete("Deprecated in favour of \"CabacBypassAlignmentEnabledRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CABAC_BYPASS_ALIGNMENT_ENABLED_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagCabacBypassAlignmentEnabledRequired = 0x8000000,
        [Obsolete("Deprecated in favour of \"CrossComponentPredictionEnabledFlagSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CROSS_COMPONENT_PREDICTION_ENABLED_FLAG_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagCrossComponentPredictionEnabledFlagSupport = 0x10000000,
        [Obsolete("Deprecated in favour of \"CrossComponentPredictionEnabledFlagRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CROSS_COMPONENT_PREDICTION_ENABLED_FLAG_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagCrossComponentPredictionEnabledFlagRequired = 0x20000000,
        [Obsolete("Deprecated in favour of \"ChromaQPOffsetListEnabledFlagSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CHROMA_QP_OFFSET_LIST_ENABLED_FLAG_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagChromaQPOffsetListEnabledFlagSupport = 0x40000000,
        [Obsolete("Deprecated in favour of \"ChromaQPOffsetListEnabledFlagRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CHROMA_QP_OFFSET_LIST_ENABLED_FLAG_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagChromaQPOffsetListEnabledFlagRequired = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_BFRAME_LTR_COMBINED_SUPPORT")]
        BframeLtrCombinedSupport = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_INTRA_SLICE_CONSTRAINED_ENCODING_SUPPORT")]
        IntraSliceConstrainedEncodingSupport = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CONSTRAINED_INTRAPREDICTION_SUPPORT")]
        ConstrainedIntrapredictionSupport = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_SAO_FILTER_SUPPORT")]
        SaoFilterSupport = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_ASYMETRIC_MOTION_PARTITION_SUPPORT")]
        AsymetricMotionPartitionSupport = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_ASYMETRIC_MOTION_PARTITION_REQUIRED")]
        AsymetricMotionPartitionRequired = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_SUPPORT")]
        TransformSkipSupport = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_DISABLING_LOOP_FILTER_ACROSS_SLICES_SUPPORT")]
        DisablingLoopFilterAcrossSlicesSupport = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_P_FRAMES_IMPLEMENTED_AS_LOW_DELAY_B_FRAMES")]
        PFramesImplementedAsLowDelayBFrames = 0x100,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_NUM_REF_IDX_ACTIVE_OVERRIDE_FLAG_SLICE_SUPPORT")]
        NumRefIdxActiveOverrideFlagSliceSupport = 0x200,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_ROTATION_ENABLED_SUPPORT")]
        TransformSkipRotationEnabledSupport = 0x400,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_ROTATION_ENABLED_REQUIRED")]
        TransformSkipRotationEnabledRequired = 0x800,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_CONTEXT_ENABLED_SUPPORT")]
        TransformSkipContextEnabledSupport = 0x1000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_CONTEXT_ENABLED_REQUIRED")]
        TransformSkipContextEnabledRequired = 0x2000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_IMPLICIT_RDPCM_ENABLED_SUPPORT")]
        ImplicitRdpcmEnabledSupport = 0x4000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_IMPLICIT_RDPCM_ENABLED_REQUIRED")]
        ImplicitRdpcmEnabledRequired = 0x8000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_EXPLICIT_RDPCM_ENABLED_SUPPORT")]
        ExplicitRdpcmEnabledSupport = 0x10000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_EXPLICIT_RDPCM_ENABLED_REQUIRED")]
        ExplicitRdpcmEnabledRequired = 0x20000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_EXTENDED_PRECISION_PROCESSING_SUPPORT")]
        ExtendedPrecisionProcessingSupport = 0x40000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_EXTENDED_PRECISION_PROCESSING_REQUIRED")]
        ExtendedPrecisionProcessingRequired = 0x80000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_INTRA_SMOOTHING_DISABLED_SUPPORT")]
        IntraSmoothingDisabledSupport = 0x100000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_INTRA_SMOOTHING_DISABLED_REQUIRED")]
        IntraSmoothingDisabledRequired = 0x200000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_HIGH_PRECISION_OFFSETS_ENABLED_SUPPORT")]
        HighPrecisionOffsetsEnabledSupport = 0x400000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_HIGH_PRECISION_OFFSETS_ENABLED_REQUIRED")]
        HighPrecisionOffsetsEnabledRequired = 0x800000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_PERSISTENT_RICE_ADAPTATION_ENABLED_SUPPORT")]
        PersistentRiceAdaptationEnabledSupport = 0x1000000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_PERSISTENT_RICE_ADAPTATION_ENABLED_REQUIRED")]
        PersistentRiceAdaptationEnabledRequired = 0x2000000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CABAC_BYPASS_ALIGNMENT_ENABLED_SUPPORT")]
        CabacBypassAlignmentEnabledSupport = 0x4000000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CABAC_BYPASS_ALIGNMENT_ENABLED_REQUIRED")]
        CabacBypassAlignmentEnabledRequired = 0x8000000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CROSS_COMPONENT_PREDICTION_ENABLED_FLAG_SUPPORT")]
        CrossComponentPredictionEnabledFlagSupport = 0x10000000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CROSS_COMPONENT_PREDICTION_ENABLED_FLAG_REQUIRED")]
        CrossComponentPredictionEnabledFlagRequired = 0x20000000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CHROMA_QP_OFFSET_LIST_ENABLED_FLAG_SUPPORT")]
        ChromaQPOffsetListEnabledFlagSupport = 0x40000000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CHROMA_QP_OFFSET_LIST_ENABLED_FLAG_REQUIRED")]
        ChromaQPOffsetListEnabledFlagRequired = unchecked((int) 0xFFFFFFFF80000000),
    }
}
