// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH264StdFlagsKHR")]
    public enum VideoEncodeH264StdFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SeparateColorPlaneFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHR")]
        VideoEncodeH264StdSeparateColorPlaneFlagSetBitKhr = 1,
        [Obsolete("Deprecated in favour of \"QpprimeYZeroTransformBypassFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_KHR")]
        VideoEncodeH264StdQpprimeYZeroTransformBypassFlagSetBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ScalingMatrixPresentFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_KHR")]
        VideoEncodeH264StdScalingMatrixPresentFlagSetBitKhr = 4,
        [Obsolete("Deprecated in favour of \"ChromaQPIndexOffsetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_KHR")]
        VideoEncodeH264StdChromaQPIndexOffsetBitKhr = 8,
        [Obsolete("Deprecated in favour of \"SecondChromaQPIndexOffsetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_KHR")]
        VideoEncodeH264StdSecondChromaQPIndexOffsetBitKhr = 16,
        [Obsolete("Deprecated in favour of \"PicInitQPMinus26BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_KHR")]
        VideoEncodeH264StdPicInitQPMinus26BitKhr = 32,
        [Obsolete("Deprecated in favour of \"WeightedPredFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR")]
        VideoEncodeH264StdWeightedPredFlagSetBitKhr = 64,
        [Obsolete("Deprecated in favour of \"WeightedBipredIdcExplicitBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_KHR")]
        VideoEncodeH264StdWeightedBipredIdcExplicitBitKhr = 128,
        [Obsolete("Deprecated in favour of \"WeightedBipredIdcImplicitBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_KHR")]
        VideoEncodeH264StdWeightedBipredIdcImplicitBitKhr = 256,
        [Obsolete("Deprecated in favour of \"Transform8X8ModeFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_KHR")]
        VideoEncodeH264StdTransform8X8ModeFlagSetBitKhr = 512,
        [Obsolete("Deprecated in favour of \"DirectSpatialMVPredFlagUnsetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_KHR")]
        VideoEncodeH264StdDirectSpatialMVPredFlagUnsetBitKhr = 1024,
        [Obsolete("Deprecated in favour of \"EntropyCodingModeFlagUnsetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_KHR")]
        VideoEncodeH264StdEntropyCodingModeFlagUnsetBitKhr = 2048,
        [Obsolete("Deprecated in favour of \"EntropyCodingModeFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_KHR")]
        VideoEncodeH264StdEntropyCodingModeFlagSetBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"Direct8X8InferenceFlagUnsetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_KHR")]
        VideoEncodeH264StdDirect8X8InferenceFlagUnsetBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"ConstrainedIntraPredFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHR")]
        VideoEncodeH264StdConstrainedIntraPredFlagSetBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"DeblockingFilterDisabledBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_KHR")]
        VideoEncodeH264StdDeblockingFilterDisabledBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"DeblockingFilterEnabledBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_KHR")]
        VideoEncodeH264StdDeblockingFilterEnabledBitKhr = 65536,
        [Obsolete("Deprecated in favour of \"DeblockingFilterPartialBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_KHR")]
        VideoEncodeH264StdDeblockingFilterPartialBitKhr = 131072,
        [Obsolete("Deprecated in favour of \"SliceQPDeltaBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_KHR")]
        VideoEncodeH264StdSliceQPDeltaBitKhr = 524288,
        [Obsolete("Deprecated in favour of \"DifferentSliceQPDeltaBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHR")]
        VideoEncodeH264StdDifferentSliceQPDeltaBitKhr = 1048576,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHR")]
        SeparateColorPlaneFlagSetBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_KHR")]
        QpprimeYZeroTransformBypassFlagSetBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_KHR")]
        ScalingMatrixPresentFlagSetBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_KHR")]
        ChromaQPIndexOffsetBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_KHR")]
        SecondChromaQPIndexOffsetBitKhr = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_KHR")]
        PicInitQPMinus26BitKhr = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR")]
        WeightedPredFlagSetBitKhr = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_KHR")]
        WeightedBipredIdcExplicitBitKhr = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_KHR")]
        WeightedBipredIdcImplicitBitKhr = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_KHR")]
        Transform8X8ModeFlagSetBitKhr = 512,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_KHR")]
        DirectSpatialMVPredFlagUnsetBitKhr = 1024,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_KHR")]
        EntropyCodingModeFlagUnsetBitKhr = 2048,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_KHR")]
        EntropyCodingModeFlagSetBitKhr = 4096,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_KHR")]
        Direct8X8InferenceFlagUnsetBitKhr = 8192,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHR")]
        ConstrainedIntraPredFlagSetBitKhr = 16384,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_KHR")]
        DeblockingFilterDisabledBitKhr = 32768,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_KHR")]
        DeblockingFilterEnabledBitKhr = 65536,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_KHR")]
        DeblockingFilterPartialBitKhr = 131072,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_KHR")]
        SliceQPDeltaBitKhr = 524288,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHR")]
        DifferentSliceQPDeltaBitKhr = 1048576,
    }
}
