// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265StdFlagsKHR")]
    public enum VideoEncodeH265StdFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SeparateColorPlaneFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdSeparateColorPlaneFlagSetBitKhr = 1,
        [Obsolete("Deprecated in favour of \"SampleAdaptiveOffsetEnabledFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdSampleAdaptiveOffsetEnabledFlagSetBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ScalingListDataPresentFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdScalingListDataPresentFlagSetBitKhr = 4,
        [Obsolete("Deprecated in favour of \"PcmEnabledFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdPcmEnabledFlagSetBitKhr = 8,
        [Obsolete("Deprecated in favour of \"SpsTemporalMvpEnabledFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdSpsTemporalMvpEnabledFlagSetBitKhr = 16,
        [Obsolete("Deprecated in favour of \"InitQPMinus26BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_KHR")]
        VideoEncodeH265StdInitQPMinus26BitKhr = 32,
        [Obsolete("Deprecated in favour of \"WeightedPredFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdWeightedPredFlagSetBitKhr = 64,
        [Obsolete("Deprecated in favour of \"WeightedBipredFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdWeightedBipredFlagSetBitKhr = 128,
        [Obsolete("Deprecated in favour of \"Log2ParallelMergeLevelMinus2BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_KHR")]
        VideoEncodeH265StdLog2ParallelMergeLevelMinus2BitKhr = 256,
        [Obsolete("Deprecated in favour of \"SignDataHidingEnabledFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdSignDataHidingEnabledFlagSetBitKhr = 512,
        [Obsolete("Deprecated in favour of \"TransformSkipEnabledFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdTransformSkipEnabledFlagSetBitKhr = 1024,
        [Obsolete("Deprecated in favour of \"TransformSkipEnabledFlagUnsetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_KHR")]
        VideoEncodeH265StdTransformSkipEnabledFlagUnsetBitKhr = 2048,
        [Obsolete("Deprecated in favour of \"PpsSliceChromaQPOffsetsPresentFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdPpsSliceChromaQPOffsetsPresentFlagSetBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"TransquantBypassEnabledFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdTransquantBypassEnabledFlagSetBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"ConstrainedIntraPredFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdConstrainedIntraPredFlagSetBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"EntropyCodingSyncEnabledFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdEntropyCodingSyncEnabledFlagSetBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"DeblockingFilterOverrideEnabledFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdDeblockingFilterOverrideEnabledFlagSetBitKhr = 65536,
        [Obsolete("Deprecated in favour of \"DependentSliceSegmentsEnabledFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdDependentSliceSegmentsEnabledFlagSetBitKhr = 131072,
        [Obsolete("Deprecated in favour of \"DependentSliceSegmentFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_KHR")]
        VideoEncodeH265StdDependentSliceSegmentFlagSetBitKhr = 262144,
        [Obsolete("Deprecated in favour of \"SliceQPDeltaBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SLICE_QP_DELTA_BIT_KHR")]
        VideoEncodeH265StdSliceQPDeltaBitKhr = 524288,
        [Obsolete("Deprecated in favour of \"DifferentSliceQPDeltaBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHR")]
        VideoEncodeH265StdDifferentSliceQPDeltaBitKhr = 1048576,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHR")]
        SeparateColorPlaneFlagSetBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_KHR")]
        SampleAdaptiveOffsetEnabledFlagSetBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_KHR")]
        ScalingListDataPresentFlagSetBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_KHR")]
        PcmEnabledFlagSetBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_KHR")]
        SpsTemporalMvpEnabledFlagSetBitKhr = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_KHR")]
        InitQPMinus26BitKhr = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR")]
        WeightedPredFlagSetBitKhr = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_KHR")]
        WeightedBipredFlagSetBitKhr = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_KHR")]
        Log2ParallelMergeLevelMinus2BitKhr = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_KHR")]
        SignDataHidingEnabledFlagSetBitKhr = 512,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_KHR")]
        TransformSkipEnabledFlagSetBitKhr = 1024,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_KHR")]
        TransformSkipEnabledFlagUnsetBitKhr = 2048,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_KHR")]
        PpsSliceChromaQPOffsetsPresentFlagSetBitKhr = 4096,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_KHR")]
        TransquantBypassEnabledFlagSetBitKhr = 8192,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHR")]
        ConstrainedIntraPredFlagSetBitKhr = 16384,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_KHR")]
        EntropyCodingSyncEnabledFlagSetBitKhr = 32768,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_KHR")]
        DeblockingFilterOverrideEnabledFlagSetBitKhr = 65536,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_KHR")]
        DependentSliceSegmentsEnabledFlagSetBitKhr = 131072,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_KHR")]
        DependentSliceSegmentFlagSetBitKhr = 262144,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_SLICE_QP_DELTA_BIT_KHR")]
        SliceQPDeltaBitKhr = 524288,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHR")]
        DifferentSliceQPDeltaBitKhr = 1048576,
    }
}
