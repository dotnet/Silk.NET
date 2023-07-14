// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH264CapabilityFlagsEXT")]
    public enum VideoEncodeH264CapabilityFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"HrdComplianceBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_EXT")]
        VideoEncodeH264CapabilityHrdComplianceBitExt = 1,
        [Obsolete("Deprecated in favour of \"PredictionWeightTableGeneratedBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_EXT")]
        VideoEncodeH264CapabilityPredictionWeightTableGeneratedBitExt = 2,
        [Obsolete("Deprecated in favour of \"RowUnalignedSliceBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_EXT")]
        VideoEncodeH264CapabilityRowUnalignedSliceBitExt = 4,
        [Obsolete("Deprecated in favour of \"DifferentSliceTypeBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXT")]
        VideoEncodeH264CapabilityDifferentSliceTypeBitExt = 8,
        [Obsolete("Deprecated in favour of \"BFrameInL0ListBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_EXT")]
        VideoEncodeH264CapabilityBFrameInL0ListBitExt = 16,
        [Obsolete("Deprecated in favour of \"BFrameInL1ListBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT")]
        VideoEncodeH264CapabilityBFrameInL1ListBitExt = 32,
        [Obsolete("Deprecated in favour of \"PerPictureTypeMinMaxQPBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_EXT")]
        VideoEncodeH264CapabilityPerPictureTypeMinMaxQPBitExt = 64,
        [Obsolete("Deprecated in favour of \"PerSliceConstantQPBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_EXT")]
        VideoEncodeH264CapabilityPerSliceConstantQPBitExt = 128,
        [Obsolete("Deprecated in favour of \"GeneratePrefixNaluBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_EXT")]
        VideoEncodeH264CapabilityGeneratePrefixNaluBitExt = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_EXT")]
        HrdComplianceBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_EXT")]
        PredictionWeightTableGeneratedBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_EXT")]
        RowUnalignedSliceBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXT")]
        DifferentSliceTypeBitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_EXT")]
        BFrameInL0ListBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT")]
        BFrameInL1ListBitExt = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_EXT")]
        PerPictureTypeMinMaxQPBitExt = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_EXT")]
        PerSliceConstantQPBitExt = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_EXT")]
        GeneratePrefixNaluBitExt = 256,
    }
}
