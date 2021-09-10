// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkVideoEncodeH264CapabilityFlagsEXT")]
    public enum VideoEncodeH264CapabilityFlagsEXT : int
    {
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_CABAC_BIT_EXT")]
        VideoEncodeH264CapabilityCabacBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_CAVLC_BIT_EXT")]
        VideoEncodeH264CapabilityCavlcBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_BI_PRED_IMPLICIT_BIT_EXT")]
        VideoEncodeH264CapabilityWeightedBIPredImplicitBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_TRANSFORM_8X8_BIT_EXT")]
        VideoEncodeH264CapabilityTransform8X8BitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_CHROMA_QP_OFFSET_BIT_EXT")]
        VideoEncodeH264CapabilityChromaQPOffsetBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_SECOND_CHROMA_QP_OFFSET_BIT_EXT")]
        VideoEncodeH264CapabilitySecondChromaQPOffsetBitExt = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_DISABLED_BIT_EXT")]
        VideoEncodeH264CapabilityDeblockingFilterDisabledBitExt = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_ENABLED_BIT_EXT")]
        VideoEncodeH264CapabilityDeblockingFilterEnabledBitExt = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_PARTIAL_BIT_EXT")]
        VideoEncodeH264CapabilityDeblockingFilterPartialBitExt = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_MULTIPLE_SLICE_PER_FRAME_BIT_EXT")]
        VideoEncodeH264CapabilityMultipleSlicePerFrameBitExt = 512,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_EVENLY_DISTRIBUTED_SLICE_SIZE_BIT_EXT")]
        VideoEncodeH264CapabilityEvenlyDistributedSliceSizeBitExt = 1024,
    }
}
