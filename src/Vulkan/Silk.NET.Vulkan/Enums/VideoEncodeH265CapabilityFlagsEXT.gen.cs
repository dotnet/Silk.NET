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
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SEPARATE_COLOUR_PLANE_BIT_EXT")]
        VideoEncodeH265CapabilitySeparateColourPlaneBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SCALING_LISTS_BIT_EXT")]
        VideoEncodeH265CapabilityScalingListsBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SAMPLE_ADAPTIVE_OFFSET_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilitySampleAdaptiveOffsetEnabledBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PCM_ENABLE_BIT_EXT")]
        VideoEncodeH265CapabilityPcmEnableBitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SPS_TEMPORAL_MVP_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilitySpsTemporalMvpEnabledBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_EXT")]
        VideoEncodeH265CapabilityHrdComplianceBitExt = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_INIT_QP_MINUS26_BIT_EXT")]
        VideoEncodeH265CapabilityInitQPMinus26BitExt = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_EXT")]
        VideoEncodeH265CapabilityLog2ParallelMergeLevelMinus2BitExt = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SIGN_DATA_HIDING_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilitySignDataHidingEnabledBitExt = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSFORM_SKIP_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilityTransformSkipEnabledBitExt = 512,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_BIT_EXT")]
        VideoEncodeH265CapabilityPpsSliceChromaQPOffsetsPresentBitExt = 1024,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_PRED_BIT_EXT")]
        VideoEncodeH265CapabilityWeightedPredBitExt = 2048,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_BIPRED_BIT_EXT")]
        VideoEncodeH265CapabilityWeightedBipredBitExt = 4096,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_PRED_NO_TABLE_BIT_EXT")]
        VideoEncodeH265CapabilityWeightedPredNoTableBitExt = 8192,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSQUANT_BYPASS_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilityTransquantBypassEnabledBitExt = 16384,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_ENTROPY_CODING_SYNC_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilityEntropyCodingSyncEnabledBitExt = 32768,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DEBLOCKING_FILTER_OVERRIDE_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilityDeblockingFilterOverrideEnabledBitExt = 65536,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILE_PER_FRAME_BIT_EXT")]
        VideoEncodeH265CapabilityMultipleTilePerFrameBitExt = 131072,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_PER_TILE_BIT_EXT")]
        VideoEncodeH265CapabilityMultipleSlicePerTileBitExt = 262144,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILE_PER_SLICE_BIT_EXT")]
        VideoEncodeH265CapabilityMultipleTilePerSliceBitExt = 524288,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SLICE_SEGMENT_CTB_COUNT_BIT_EXT")]
        VideoEncodeH265CapabilitySliceSegmentCtbCountBitExt = 1048576,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_EXT")]
        VideoEncodeH265CapabilityRowUnalignedSliceSegmentBitExt = 2097152,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DEPENDENT_SLICE_SEGMENT_BIT_EXT")]
        VideoEncodeH265CapabilityDependentSliceSegmentBitExt = 4194304,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXT")]
        VideoEncodeH265CapabilityDifferentSliceTypeBitExt = 8388608,
    }
}
