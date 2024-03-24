// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH264CapabilityFlagsKHR")]
    public enum VideoEncodeH264CapabilityFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"HrdComplianceBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_KHR")]
        VideoEncodeH264CapabilityHrdComplianceBitKhr = 1,
        [Obsolete("Deprecated in favour of \"PredictionWeightTableGeneratedBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHR")]
        VideoEncodeH264CapabilityPredictionWeightTableGeneratedBitKhr = 2,
        [Obsolete("Deprecated in favour of \"RowUnalignedSliceBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_KHR")]
        VideoEncodeH264CapabilityRowUnalignedSliceBitKhr = 4,
        [Obsolete("Deprecated in favour of \"DifferentSliceTypeBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_KHR")]
        VideoEncodeH264CapabilityDifferentSliceTypeBitKhr = 8,
        [Obsolete("Deprecated in favour of \"BFrameInL0ListBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHR")]
        VideoEncodeH264CapabilityBFrameInL0ListBitKhr = 16,
        [Obsolete("Deprecated in favour of \"BFrameInL1ListBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHR")]
        VideoEncodeH264CapabilityBFrameInL1ListBitKhr = 32,
        [Obsolete("Deprecated in favour of \"PerPictureTypeMinMaxQPBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHR")]
        VideoEncodeH264CapabilityPerPictureTypeMinMaxQPBitKhr = 64,
        [Obsolete("Deprecated in favour of \"PerSliceConstantQPBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_KHR")]
        VideoEncodeH264CapabilityPerSliceConstantQPBitKhr = 128,
        [Obsolete("Deprecated in favour of \"GeneratePrefixNaluBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_KHR")]
        VideoEncodeH264CapabilityGeneratePrefixNaluBitKhr = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_KHR")]
        HrdComplianceBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHR")]
        PredictionWeightTableGeneratedBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_KHR")]
        RowUnalignedSliceBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_KHR")]
        DifferentSliceTypeBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHR")]
        BFrameInL0ListBitKhr = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHR")]
        BFrameInL1ListBitKhr = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHR")]
        PerPictureTypeMinMaxQPBitKhr = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_KHR")]
        PerSliceConstantQPBitKhr = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_KHR")]
        GeneratePrefixNaluBitKhr = 256,
    }
}
