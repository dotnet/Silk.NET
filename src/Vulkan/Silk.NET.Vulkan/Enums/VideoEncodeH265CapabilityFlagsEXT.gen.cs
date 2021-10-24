// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkVideoEncodeH265CapabilityFlagsEXT")]
    public enum VideoEncodeH265CapabilityFlagsEXT : int
    {
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_WEIGHTED_BI_PRED_IMPLICIT_BIT_EXT")]
        VideoEncodeH265CapabilityWeightedBIPredImplicitBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_TRANSFORM_8X8_BIT_EXT")]
        VideoEncodeH265CapabilityTransform8X8BitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_CHROMA_QP_OFFSET_BIT_EXT")]
        VideoEncodeH265CapabilityChromaQPOffsetBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_SECOND_CHROMA_QP_OFFSET_BIT_EXT")]
        VideoEncodeH265CapabilitySecondChromaQPOffsetBitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DEBLOCKING_FILTER_DISABLED_BIT_EXT")]
        VideoEncodeH265CapabilityDeblockingFilterDisabledBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DEBLOCKING_FILTER_ENABLED_BIT_EXT")]
        VideoEncodeH265CapabilityDeblockingFilterEnabledBitExt = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_DEBLOCKING_FILTER_PARTIAL_BIT_EXT")]
        VideoEncodeH265CapabilityDeblockingFilterPartialBitExt = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_PER_FRAME_BIT_EXT")]
        VideoEncodeH265CapabilityMultipleSlicePerFrameBitExt = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CAPABILITY_EVENLY_DISTRIBUTED_SLICE_SIZE_BIT_EXT")]
        VideoEncodeH265CapabilityEvenlyDistributedSliceSizeBitExt = 256,
    }
}
