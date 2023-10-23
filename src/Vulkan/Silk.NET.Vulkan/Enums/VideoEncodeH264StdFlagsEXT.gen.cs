// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH264StdFlagsEXT")]
    public enum VideoEncodeH264StdFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SeparateColorPlaneFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_EXT")]
        VideoEncodeH264StdSeparateColorPlaneFlagSetBitExt = 1,
        [Obsolete("Deprecated in favour of \"QpprimeYZeroTransformBypassFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_EXT")]
        VideoEncodeH264StdQpprimeYZeroTransformBypassFlagSetBitExt = 2,
        [Obsolete("Deprecated in favour of \"ScalingMatrixPresentFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_EXT")]
        VideoEncodeH264StdScalingMatrixPresentFlagSetBitExt = 4,
        [Obsolete("Deprecated in favour of \"ChromaQPIndexOffsetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_EXT")]
        VideoEncodeH264StdChromaQPIndexOffsetBitExt = 8,
        [Obsolete("Deprecated in favour of \"SecondChromaQPIndexOffsetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_EXT")]
        VideoEncodeH264StdSecondChromaQPIndexOffsetBitExt = 16,
        [Obsolete("Deprecated in favour of \"PicInitQPMinus26BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_EXT")]
        VideoEncodeH264StdPicInitQPMinus26BitExt = 32,
        [Obsolete("Deprecated in favour of \"WeightedPredFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_EXT")]
        VideoEncodeH264StdWeightedPredFlagSetBitExt = 64,
        [Obsolete("Deprecated in favour of \"WeightedBipredIdcExplicitBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_EXT")]
        VideoEncodeH264StdWeightedBipredIdcExplicitBitExt = 128,
        [Obsolete("Deprecated in favour of \"WeightedBipredIdcImplicitBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_EXT")]
        VideoEncodeH264StdWeightedBipredIdcImplicitBitExt = 256,
        [Obsolete("Deprecated in favour of \"Transform8X8ModeFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_EXT")]
        VideoEncodeH264StdTransform8X8ModeFlagSetBitExt = 512,
        [Obsolete("Deprecated in favour of \"DirectSpatialMVPredFlagUnsetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_EXT")]
        VideoEncodeH264StdDirectSpatialMVPredFlagUnsetBitExt = 1024,
        [Obsolete("Deprecated in favour of \"EntropyCodingModeFlagUnsetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_EXT")]
        VideoEncodeH264StdEntropyCodingModeFlagUnsetBitExt = 2048,
        [Obsolete("Deprecated in favour of \"EntropyCodingModeFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_EXT")]
        VideoEncodeH264StdEntropyCodingModeFlagSetBitExt = 4096,
        [Obsolete("Deprecated in favour of \"Direct8X8InferenceFlagUnsetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_EXT")]
        VideoEncodeH264StdDirect8X8InferenceFlagUnsetBitExt = 8192,
        [Obsolete("Deprecated in favour of \"ConstrainedIntraPredFlagSetBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_EXT")]
        VideoEncodeH264StdConstrainedIntraPredFlagSetBitExt = 16384,
        [Obsolete("Deprecated in favour of \"DeblockingFilterDisabledBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_EXT")]
        VideoEncodeH264StdDeblockingFilterDisabledBitExt = 32768,
        [Obsolete("Deprecated in favour of \"DeblockingFilterEnabledBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_EXT")]
        VideoEncodeH264StdDeblockingFilterEnabledBitExt = 65536,
        [Obsolete("Deprecated in favour of \"DeblockingFilterPartialBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_EXT")]
        VideoEncodeH264StdDeblockingFilterPartialBitExt = 131072,
        [Obsolete("Deprecated in favour of \"SliceQPDeltaBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_EXT")]
        VideoEncodeH264StdSliceQPDeltaBitExt = 524288,
        [Obsolete("Deprecated in favour of \"DifferentSliceQPDeltaBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_EXT")]
        VideoEncodeH264StdDifferentSliceQPDeltaBitExt = 1048576,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_EXT")]
        SeparateColorPlaneFlagSetBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_EXT")]
        QpprimeYZeroTransformBypassFlagSetBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_EXT")]
        ScalingMatrixPresentFlagSetBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_EXT")]
        ChromaQPIndexOffsetBitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_EXT")]
        SecondChromaQPIndexOffsetBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_EXT")]
        PicInitQPMinus26BitExt = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_EXT")]
        WeightedPredFlagSetBitExt = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_EXT")]
        WeightedBipredIdcExplicitBitExt = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_EXT")]
        WeightedBipredIdcImplicitBitExt = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_EXT")]
        Transform8X8ModeFlagSetBitExt = 512,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_EXT")]
        DirectSpatialMVPredFlagUnsetBitExt = 1024,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_EXT")]
        EntropyCodingModeFlagUnsetBitExt = 2048,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_EXT")]
        EntropyCodingModeFlagSetBitExt = 4096,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_EXT")]
        Direct8X8InferenceFlagUnsetBitExt = 8192,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_EXT")]
        ConstrainedIntraPredFlagSetBitExt = 16384,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_EXT")]
        DeblockingFilterDisabledBitExt = 32768,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_EXT")]
        DeblockingFilterEnabledBitExt = 65536,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_EXT")]
        DeblockingFilterPartialBitExt = 131072,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_EXT")]
        SliceQPDeltaBitExt = 524288,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_EXT")]
        DifferentSliceQPDeltaBitExt = 1048576,
    }
}
