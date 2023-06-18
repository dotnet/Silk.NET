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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"HrdComplianceBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_EXT")]
        VideoEncodeH265CapabilityHrdComplianceBitExt = 1,
        [Obsolete("Deprecated in favour of \"PredictionWeightTableGeneratedBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_EXT")]
        VideoEncodeH265CapabilityPredictionWeightTableGeneratedBitExt = 2,
        [Obsolete("Deprecated in favour of \"RowUnalignedSliceSegmentBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_EXT")]
        VideoEncodeH265CapabilityRowUnalignedSliceSegmentBitExt = 4,
        [Obsolete("Deprecated in favour of \"DifferentSliceSegmentTypeBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_SEGMENT_TYPE_BIT_EXT")]
        VideoEncodeH265CapabilityDifferentSliceSegmentTypeBitExt = 8,
        [Obsolete("Deprecated in favour of \"BFrameInL0ListBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_EXT")]
        VideoEncodeH265CapabilityBFrameInL0ListBitExt = 16,
        [Obsolete("Deprecated in favour of \"BFrameInL1ListBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT")]
        VideoEncodeH265CapabilityBFrameInL1ListBitExt = 32,
        [Obsolete("Deprecated in favour of \"PerPictureTypeMinMaxQPBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_EXT")]
        VideoEncodeH265CapabilityPerPictureTypeMinMaxQPBitExt = 64,
        [Obsolete("Deprecated in favour of \"PerSliceSegmentConstantQPBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PER_SLICE_SEGMENT_CONSTANT_QP_BIT_EXT")]
        VideoEncodeH265CapabilityPerSliceSegmentConstantQPBitExt = 128,
        [Obsolete("Deprecated in favour of \"MultipleTilesPerSliceSegmentBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILES_PER_SLICE_SEGMENT_BIT_EXT")]
        VideoEncodeH265CapabilityMultipleTilesPerSliceSegmentBitExt = 256,
        [Obsolete("Deprecated in favour of \"MultipleSliceSegmentsPerTileBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_SEGMENTS_PER_TILE_BIT_EXT")]
        VideoEncodeH265CapabilityMultipleSliceSegmentsPerTileBitExt = 512,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_EXT")]
        HrdComplianceBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_EXT")]
        PredictionWeightTableGeneratedBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_EXT")]
        RowUnalignedSliceSegmentBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_SEGMENT_TYPE_BIT_EXT")]
        DifferentSliceSegmentTypeBitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_EXT")]
        BFrameInL0ListBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT")]
        BFrameInL1ListBitExt = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_EXT")]
        PerPictureTypeMinMaxQPBitExt = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_PER_SLICE_SEGMENT_CONSTANT_QP_BIT_EXT")]
        PerSliceSegmentConstantQPBitExt = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILES_PER_SLICE_SEGMENT_BIT_EXT")]
        MultipleTilesPerSliceSegmentBitExt = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_SEGMENTS_PER_TILE_BIT_EXT")]
        MultipleSliceSegmentsPerTileBitExt = 512,
    }
}
