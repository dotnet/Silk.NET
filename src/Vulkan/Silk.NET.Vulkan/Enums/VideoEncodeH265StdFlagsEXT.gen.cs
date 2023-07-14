// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265StdFlagsEXT")]
    public enum VideoEncodeH265StdFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SeparateColorPlaneFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdSeparateColorPlaneFlagSetBitExt = 1,
        [Obsolete("Deprecated in favour of \"SampleAdaptiveOffsetEnabledFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdSampleAdaptiveOffsetEnabledFlagSetBitExt = 2,
        [Obsolete("Deprecated in favour of \"ScalingListDataPresentFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdScalingListDataPresentFlagSetBitExt = 4,
        [Obsolete("Deprecated in favour of \"PcmEnabledFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdPcmEnabledFlagSetBitExt = 8,
        [Obsolete("Deprecated in favour of \"SpsTemporalMvpEnabledFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdSpsTemporalMvpEnabledFlagSetBitExt = 16,
        [Obsolete("Deprecated in favour of \"InitQPMinus26BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_EXT")]
        VideoEncodeH265StdInitQPMinus26BitExt = 32,
        [Obsolete("Deprecated in favour of \"WeightedPredFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdWeightedPredFlagSetBitExt = 64,
        [Obsolete("Deprecated in favour of \"WeightedBipredFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdWeightedBipredFlagSetBitExt = 128,
        [Obsolete("Deprecated in favour of \"Log2ParallelMergeLevelMinus2BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_EXT")]
        VideoEncodeH265StdLog2ParallelMergeLevelMinus2BitExt = 256,
        [Obsolete("Deprecated in favour of \"SignDataHidingEnabledFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdSignDataHidingEnabledFlagSetBitExt = 512,
        [Obsolete("Deprecated in favour of \"TransformSkipEnabledFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdTransformSkipEnabledFlagSetBitExt = 1024,
        [Obsolete("Deprecated in favour of \"TransformSkipEnabledFlagUnsetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_EXT")]
        VideoEncodeH265StdTransformSkipEnabledFlagUnsetBitExt = 2048,
        [Obsolete("Deprecated in favour of \"PpsSliceChromaQPOffsetsPresentFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdPpsSliceChromaQPOffsetsPresentFlagSetBitExt = 4096,
        [Obsolete("Deprecated in favour of \"TransquantBypassEnabledFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdTransquantBypassEnabledFlagSetBitExt = 8192,
        [Obsolete("Deprecated in favour of \"ConstrainedIntraPredFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdConstrainedIntraPredFlagSetBitExt = 16384,
        [Obsolete("Deprecated in favour of \"EntropyCodingSyncEnabledFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdEntropyCodingSyncEnabledFlagSetBitExt = 32768,
        [Obsolete("Deprecated in favour of \"DeblockingFilterOverrideEnabledFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdDeblockingFilterOverrideEnabledFlagSetBitExt = 65536,
        [Obsolete("Deprecated in favour of \"DependentSliceSegmentsEnabledFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdDependentSliceSegmentsEnabledFlagSetBitExt = 131072,
        [Obsolete("Deprecated in favour of \"DependentSliceSegmentFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_EXT")]
        VideoEncodeH265StdDependentSliceSegmentFlagSetBitExt = 262144,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_EXT")]
        SeparateColorPlaneFlagSetBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_EXT")]
        SampleAdaptiveOffsetEnabledFlagSetBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_EXT")]
        ScalingListDataPresentFlagSetBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_EXT")]
        PcmEnabledFlagSetBitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_EXT")]
        SpsTemporalMvpEnabledFlagSetBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_EXT")]
        InitQPMinus26BitExt = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_EXT")]
        WeightedPredFlagSetBitExt = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_EXT")]
        WeightedBipredFlagSetBitExt = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_EXT")]
        Log2ParallelMergeLevelMinus2BitExt = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_EXT")]
        SignDataHidingEnabledFlagSetBitExt = 512,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_EXT")]
        TransformSkipEnabledFlagSetBitExt = 1024,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_EXT")]
        TransformSkipEnabledFlagUnsetBitExt = 2048,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_EXT")]
        PpsSliceChromaQPOffsetsPresentFlagSetBitExt = 4096,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_EXT")]
        TransquantBypassEnabledFlagSetBitExt = 8192,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_EXT")]
        ConstrainedIntraPredFlagSetBitExt = 16384,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_EXT")]
        EntropyCodingSyncEnabledFlagSetBitExt = 32768,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_EXT")]
        DeblockingFilterOverrideEnabledFlagSetBitExt = 65536,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_EXT")]
        DependentSliceSegmentsEnabledFlagSetBitExt = 131072,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_EXT")]
        DependentSliceSegmentFlagSetBitExt = 262144,
    }
}
