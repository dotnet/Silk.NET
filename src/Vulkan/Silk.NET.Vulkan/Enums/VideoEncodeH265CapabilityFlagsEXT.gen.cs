// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265CapabilityFlagsEXT")]
    public enum VideoEncodeH265CapabilityFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SeparateColourPlaneBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SEPARATE_COLOUR_PLANE_BIT_EXT")]
        VideoEncodeH265CapabilitySeparateColourPlaneBitExt = 1,
        [Obsolete("Deprecated in favour of \"ScalingListsBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SCALING_LISTS_BIT_EXT")]
        VideoEncodeH265CapabilityScalingListsBitExt = 2,
        [Obsolete("Deprecated in favour of \"SampleAdaptiveOffsetEnabledBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SAMPLE_ADAPTIVE_OFFSET_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilitySampleAdaptiveOffsetEnabledBitExt = 4,
        [Obsolete("Deprecated in favour of \"PcmEnableBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PCM_ENABLE_BIT_EXT")]
        VideoEncodeH265CapabilityPcmEnableBitExt = 8,
        [Obsolete("Deprecated in favour of \"SpsTemporalMvpEnabledBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SPS_TEMPORAL_MVP_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilitySpsTemporalMvpEnabledBitExt = 16,
        [Obsolete("Deprecated in favour of \"HrdComplianceBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_EXT")]
        VideoEncodeH265CapabilityHrdComplianceBitExt = 32,
        [Obsolete("Deprecated in favour of \"InitQPMinus26BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_INIT_QP_MINUS26_BIT_EXT")]
        VideoEncodeH265CapabilityInitQPMinus26BitExt = 64,
        [Obsolete("Deprecated in favour of \"Log2ParallelMergeLevelMinus2BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_EXT")]
        VideoEncodeH265CapabilityLog2ParallelMergeLevelMinus2BitExt = 128,
        [Obsolete("Deprecated in favour of \"SignDataHidingEnabledBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SIGN_DATA_HIDING_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilitySignDataHidingEnabledBitExt = 256,
        [Obsolete("Deprecated in favour of \"TransformSkipEnabledBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSFORM_SKIP_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilityTransformSkipEnabledBitExt = 512,
        [Obsolete("Deprecated in favour of \"TransformSkipDisabledBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSFORM_SKIP_DISABLED_BIT_EXT")]
        VideoEncodeH265CapabilityTransformSkipDisabledBitExt = 1024,
        [Obsolete("Deprecated in favour of \"PpsSliceChromaQPOffsetsPresentBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_BIT_EXT")]
        VideoEncodeH265CapabilityPpsSliceChromaQPOffsetsPresentBitExt = 2048,
        [Obsolete("Deprecated in favour of \"WeightedPredBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_PRED_BIT_EXT")]
        VideoEncodeH265CapabilityWeightedPredBitExt = 4096,
        [Obsolete("Deprecated in favour of \"WeightedBipredBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_BIPRED_BIT_EXT")]
        VideoEncodeH265CapabilityWeightedBipredBitExt = 8192,
        [Obsolete("Deprecated in favour of \"WeightedPredNoTableBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_PRED_NO_TABLE_BIT_EXT")]
        VideoEncodeH265CapabilityWeightedPredNoTableBitExt = 16384,
        [Obsolete("Deprecated in favour of \"TransquantBypassEnabledBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSQUANT_BYPASS_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilityTransquantBypassEnabledBitExt = 32768,
        [Obsolete("Deprecated in favour of \"EntropyCodingSyncEnabledBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_ENTROPY_CODING_SYNC_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilityEntropyCodingSyncEnabledBitExt = 65536,
        [Obsolete("Deprecated in favour of \"DeblockingFilterOverrideEnabledBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DEBLOCKING_FILTER_OVERRIDE_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilityDeblockingFilterOverrideEnabledBitExt = 131072,
        [Obsolete("Deprecated in favour of \"MultipleTilePerFrameBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILE_PER_FRAME_BIT_EXT")]
        VideoEncodeH265CapabilityMultipleTilePerFrameBitExt = 262144,
        [Obsolete("Deprecated in favour of \"MultipleSlicePerTileBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_PER_TILE_BIT_EXT")]
        VideoEncodeH265CapabilityMultipleSlicePerTileBitExt = 524288,
        [Obsolete("Deprecated in favour of \"MultipleTilePerSliceBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILE_PER_SLICE_BIT_EXT")]
        VideoEncodeH265CapabilityMultipleTilePerSliceBitExt = 1048576,
        [Obsolete("Deprecated in favour of \"SliceSegmentCtbCountBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SLICE_SEGMENT_CTB_COUNT_BIT_EXT")]
        VideoEncodeH265CapabilitySliceSegmentCtbCountBitExt = 2097152,
        [Obsolete("Deprecated in favour of \"RowUnalignedSliceSegmentBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_EXT")]
        VideoEncodeH265CapabilityRowUnalignedSliceSegmentBitExt = 4194304,
        [Obsolete("Deprecated in favour of \"DependentSliceSegmentBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DEPENDENT_SLICE_SEGMENT_BIT_EXT")]
        VideoEncodeH265CapabilityDependentSliceSegmentBitExt = 8388608,
        [Obsolete("Deprecated in favour of \"DifferentSliceTypeBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXT")]
        VideoEncodeH265CapabilityDifferentSliceTypeBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"BFrameInL1ListBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT")]
        VideoEncodeH265CapabilityBFrameInL1ListBitExt = 33554432,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SEPARATE_COLOUR_PLANE_BIT_EXT")]
        SeparateColourPlaneBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SCALING_LISTS_BIT_EXT")]
        ScalingListsBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SAMPLE_ADAPTIVE_OFFSET_ENABLED_BIT_EXT")]
        SampleAdaptiveOffsetEnabledBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PCM_ENABLE_BIT_EXT")]
        PcmEnableBitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SPS_TEMPORAL_MVP_ENABLED_BIT_EXT")]
        SpsTemporalMvpEnabledBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_EXT")]
        HrdComplianceBitExt = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_INIT_QP_MINUS26_BIT_EXT")]
        InitQPMinus26BitExt = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_EXT")]
        Log2ParallelMergeLevelMinus2BitExt = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SIGN_DATA_HIDING_ENABLED_BIT_EXT")]
        SignDataHidingEnabledBitExt = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSFORM_SKIP_ENABLED_BIT_EXT")]
        TransformSkipEnabledBitExt = 512,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSFORM_SKIP_DISABLED_BIT_EXT")]
        TransformSkipDisabledBitExt = 1024,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_BIT_EXT")]
        PpsSliceChromaQPOffsetsPresentBitExt = 2048,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_PRED_BIT_EXT")]
        WeightedPredBitExt = 4096,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_BIPRED_BIT_EXT")]
        WeightedBipredBitExt = 8192,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_PRED_NO_TABLE_BIT_EXT")]
        WeightedPredNoTableBitExt = 16384,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSQUANT_BYPASS_ENABLED_BIT_EXT")]
        TransquantBypassEnabledBitExt = 32768,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_ENTROPY_CODING_SYNC_ENABLED_BIT_EXT")]
        EntropyCodingSyncEnabledBitExt = 65536,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DEBLOCKING_FILTER_OVERRIDE_ENABLED_BIT_EXT")]
        DeblockingFilterOverrideEnabledBitExt = 131072,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILE_PER_FRAME_BIT_EXT")]
        MultipleTilePerFrameBitExt = 262144,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_PER_TILE_BIT_EXT")]
        MultipleSlicePerTileBitExt = 524288,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILE_PER_SLICE_BIT_EXT")]
        MultipleTilePerSliceBitExt = 1048576,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SLICE_SEGMENT_CTB_COUNT_BIT_EXT")]
        SliceSegmentCtbCountBitExt = 2097152,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_EXT")]
        RowUnalignedSliceSegmentBitExt = 4194304,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DEPENDENT_SLICE_SEGMENT_BIT_EXT")]
        DependentSliceSegmentBitExt = 8388608,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXT")]
        DifferentSliceTypeBitExt = 16777216,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT")]
        BFrameInL1ListBitExt = 33554432,
    }
}
