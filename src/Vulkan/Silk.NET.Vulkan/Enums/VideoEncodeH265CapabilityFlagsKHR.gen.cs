// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265CapabilityFlagsKHR")]
    public enum VideoEncodeH265CapabilityFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"HrdComplianceBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_KHR")]
        VideoEncodeH265CapabilityHrdComplianceBitKhr = 1,
        [Obsolete("Deprecated in favour of \"PredictionWeightTableGeneratedBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHR")]
        VideoEncodeH265CapabilityPredictionWeightTableGeneratedBitKhr = 2,
        [Obsolete("Deprecated in favour of \"RowUnalignedSliceSegmentBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_KHR")]
        VideoEncodeH265CapabilityRowUnalignedSliceSegmentBitKhr = 4,
        [Obsolete("Deprecated in favour of \"DifferentSliceSegmentTypeBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_SEGMENT_TYPE_BIT_KHR")]
        VideoEncodeH265CapabilityDifferentSliceSegmentTypeBitKhr = 8,
        [Obsolete("Deprecated in favour of \"BFrameInL0ListBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHR")]
        VideoEncodeH265CapabilityBFrameInL0ListBitKhr = 16,
        [Obsolete("Deprecated in favour of \"BFrameInL1ListBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHR")]
        VideoEncodeH265CapabilityBFrameInL1ListBitKhr = 32,
        [Obsolete("Deprecated in favour of \"PerPictureTypeMinMaxQPBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHR")]
        VideoEncodeH265CapabilityPerPictureTypeMinMaxQPBitKhr = 64,
        [Obsolete("Deprecated in favour of \"PerSliceSegmentConstantQPBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PER_SLICE_SEGMENT_CONSTANT_QP_BIT_KHR")]
        VideoEncodeH265CapabilityPerSliceSegmentConstantQPBitKhr = 128,
        [Obsolete("Deprecated in favour of \"MultipleTilesPerSliceSegmentBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILES_PER_SLICE_SEGMENT_BIT_KHR")]
        VideoEncodeH265CapabilityMultipleTilesPerSliceSegmentBitKhr = 256,
        [Obsolete("Deprecated in favour of \"MultipleSliceSegmentsPerTileBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_SEGMENTS_PER_TILE_BIT_KHR")]
        VideoEncodeH265CapabilityMultipleSliceSegmentsPerTileBitKhr = 512,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_KHR")]
        HrdComplianceBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHR")]
        PredictionWeightTableGeneratedBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_KHR")]
        RowUnalignedSliceSegmentBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_SEGMENT_TYPE_BIT_KHR")]
        DifferentSliceSegmentTypeBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHR")]
        BFrameInL0ListBitKhr = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHR")]
        BFrameInL1ListBitKhr = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHR")]
        PerPictureTypeMinMaxQPBitKhr = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PER_SLICE_SEGMENT_CONSTANT_QP_BIT_KHR")]
        PerSliceSegmentConstantQPBitKhr = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILES_PER_SLICE_SEGMENT_BIT_KHR")]
        MultipleTilesPerSliceSegmentBitKhr = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_SEGMENTS_PER_TILE_BIT_KHR")]
        MultipleSliceSegmentsPerTileBitKhr = 512,
    }
}
