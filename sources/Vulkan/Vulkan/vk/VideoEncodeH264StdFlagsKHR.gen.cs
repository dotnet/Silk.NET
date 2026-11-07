// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH264StdFlagsKHR")]
[Flags]
public enum VideoEncodeH264StdFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHR")]
    SeparateColorPlaneFlagSetBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_KHR")]
    QpprimeYZeroTransformBypassFlagSetBit = 0x2,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_KHR")]
    ScalingMatrixPresentFlagSetBit = 0x4,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_KHR")]
    ChromaQpIndexOffsetBit = 0x8,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_KHR")]
    SecondChromaQpIndexOffsetBit = 0x10,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_KHR")]
    PicInitQpMinus26Bit = 0x20,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR")]
    WeightedPredFlagSetBit = 0x40,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_KHR")]
    WeightedBipredIdcExplicitBit = 0x80,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_KHR")]
    WeightedBipredIdcImplicitBit = 0x100,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_KHR")]
    Transform8x8ModeFlagSetBit = 0x200,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_KHR")]
    DirectSpatialMvPredFlagUnsetBit = 0x400,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_KHR")]
    EntropyCodingModeFlagUnsetBit = 0x800,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_KHR")]
    EntropyCodingModeFlagSetBit = 0x1000,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_KHR")]
    Direct8x8InferenceFlagUnsetBit = 0x2000,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHR")]
    ConstrainedIntraPredFlagSetBit = 0x4000,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_KHR")]
    DeblockingFilterDisabledBit = 0x8000,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_KHR")]
    DeblockingFilterEnabledBit = 0x10000,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_KHR")]
    DeblockingFilterPartialBit = 0x20000,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_KHR")]
    SliceQpDeltaBit = 0x80000,

    [NativeName("VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHR")]
    DifferentSliceQpDeltaBit = 0x100000,
}
