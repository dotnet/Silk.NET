// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265StdFlagsKHR")]
[Flags]
public enum VideoEncodeH265StdFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHR")]
    SeparateColorPlaneFlagSetBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_KHR")]
    SampleAdaptiveOffsetEnabledFlagSetBit = 0x2,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_KHR")]
    ScalingListDataPresentFlagSetBit = 0x4,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_KHR")]
    PcmEnabledFlagSetBit = 0x8,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_KHR")]
    SpsTemporalMvpEnabledFlagSetBit = 0x10,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_KHR")]
    InitQpMinus26Bit = 0x20,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR")]
    WeightedPredFlagSetBit = 0x40,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_KHR")]
    WeightedBipredFlagSetBit = 0x80,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_KHR")]
    Log2ParallelMergeLevelMinus2Bit = 0x100,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_KHR")]
    SignDataHidingEnabledFlagSetBit = 0x200,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_KHR")]
    TransformSkipEnabledFlagSetBit = 0x400,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_KHR")]
    TransformSkipEnabledFlagUnsetBit = 0x800,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_KHR")]
    PpsSliceChromaQpOffsetsPresentFlagSetBit = 0x1000,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_KHR")]
    TransquantBypassEnabledFlagSetBit = 0x2000,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHR")]
    ConstrainedIntraPredFlagSetBit = 0x4000,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_KHR")]
    EntropyCodingSyncEnabledFlagSetBit = 0x8000,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_KHR")]
    DeblockingFilterOverrideEnabledFlagSetBit = 0x10000,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_KHR")]
    DependentSliceSegmentsEnabledFlagSetBit = 0x20000,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_KHR")]
    DependentSliceSegmentFlagSetBit = 0x40000,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_SLICE_QP_DELTA_BIT_KHR")]
    SliceQpDeltaBit = 0x80000,

    [NativeName("VK_VIDEO_ENCODE_H265_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHR")]
    DifferentSliceQpDeltaBit = 0x100000,
}
