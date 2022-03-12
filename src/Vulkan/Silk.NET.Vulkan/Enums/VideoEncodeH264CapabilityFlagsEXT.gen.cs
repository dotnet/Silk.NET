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
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DIRECT_8X8_INFERENCE_BIT_EXT")]
        VideoEncodeH264CapabilityDirect8X8InferenceBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_SEPARATE_COLOUR_PLANE_BIT_EXT")]
        VideoEncodeH264CapabilitySeparateColourPlaneBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_BIT_EXT")]
        VideoEncodeH264CapabilityQpprimeYZeroTransformBypassBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_SCALING_LISTS_BIT_EXT")]
        VideoEncodeH264CapabilityScalingListsBitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_EXT")]
        VideoEncodeH264CapabilityHrdComplianceBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_CHROMA_QP_OFFSET_BIT_EXT")]
        VideoEncodeH264CapabilityChromaQPOffsetBitExt = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_SECOND_CHROMA_QP_OFFSET_BIT_EXT")]
        VideoEncodeH264CapabilitySecondChromaQPOffsetBitExt = 64,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_PIC_INIT_QP_MINUS26_BIT_EXT")]
        VideoEncodeH264CapabilityPicInitQPMinus26BitExt = 128,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_PRED_BIT_EXT")]
        VideoEncodeH264CapabilityWeightedPredBitExt = 256,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_BIPRED_EXPLICIT_BIT_EXT")]
        VideoEncodeH264CapabilityWeightedBipredExplicitBitExt = 512,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_BIPRED_IMPLICIT_BIT_EXT")]
        VideoEncodeH264CapabilityWeightedBipredImplicitBitExt = 1024,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_PRED_NO_TABLE_BIT_EXT")]
        VideoEncodeH264CapabilityWeightedPredNoTableBitExt = 2048,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_TRANSFORM_8X8_BIT_EXT")]
        VideoEncodeH264CapabilityTransform8X8BitExt = 4096,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_CABAC_BIT_EXT")]
        VideoEncodeH264CapabilityCabacBitExt = 8192,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_CAVLC_BIT_EXT")]
        VideoEncodeH264CapabilityCavlcBitExt = 16384,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_DISABLED_BIT_EXT")]
        VideoEncodeH264CapabilityDeblockingFilterDisabledBitExt = 32768,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_ENABLED_BIT_EXT")]
        VideoEncodeH264CapabilityDeblockingFilterEnabledBitExt = 65536,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_PARTIAL_BIT_EXT")]
        VideoEncodeH264CapabilityDeblockingFilterPartialBitExt = 131072,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DISABLE_DIRECT_SPATIAL_MV_PRED_BIT_EXT")]
        VideoEncodeH264CapabilityDisableDirectSpatialMVPredBitExt = 262144,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_MULTIPLE_SLICE_PER_FRAME_BIT_EXT")]
        VideoEncodeH264CapabilityMultipleSlicePerFrameBitExt = 524288,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_SLICE_MB_COUNT_BIT_EXT")]
        VideoEncodeH264CapabilitySliceMBCountBitExt = 1048576,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_EXT")]
        VideoEncodeH264CapabilityRowUnalignedSliceBitExt = 2097152,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXT")]
        VideoEncodeH264CapabilityDifferentSliceTypeBitExt = 4194304,
    }
}
