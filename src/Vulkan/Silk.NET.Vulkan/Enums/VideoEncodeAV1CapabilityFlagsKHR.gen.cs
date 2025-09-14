// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeAV1CapabilityFlagsKHR")]
    public enum VideoEncodeAV1CapabilityFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PerRateControlGroupMinMaxQIndexBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_PER_RATE_CONTROL_GROUP_MIN_MAX_Q_INDEX_BIT_KHR")]
        VideoEncodeAV1CapabilityPerRateControlGroupMinMaxQIndexBitKhr = 1,
        [Obsolete("Deprecated in favour of \"GenerateObuExtensionHeaderBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_GENERATE_OBU_EXTENSION_HEADER_BIT_KHR")]
        VideoEncodeAV1CapabilityGenerateObuExtensionHeaderBitKhr = 2,
        [Obsolete("Deprecated in favour of \"PrimaryReferenceCdfOnlyBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_PRIMARY_REFERENCE_CDF_ONLY_BIT_KHR")]
        VideoEncodeAV1CapabilityPrimaryReferenceCdfOnlyBitKhr = 4,
        [Obsolete("Deprecated in favour of \"FrameSizeOverrideBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_FRAME_SIZE_OVERRIDE_BIT_KHR")]
        VideoEncodeAV1CapabilityFrameSizeOverrideBitKhr = 8,
        [Obsolete("Deprecated in favour of \"MotionVectorScalingBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_MOTION_VECTOR_SCALING_BIT_KHR")]
        VideoEncodeAV1CapabilityMotionVectorScalingBitKhr = 16,
        [Obsolete("Deprecated in favour of \"CompoundPredictionIntraRefreshBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_COMPOUND_PREDICTION_INTRA_REFRESH_BIT_KHR")]
        VideoEncodeAV1CapabilityCompoundPredictionIntraRefreshBitKhr = 32,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_PER_RATE_CONTROL_GROUP_MIN_MAX_Q_INDEX_BIT_KHR")]
        PerRateControlGroupMinMaxQIndexBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_GENERATE_OBU_EXTENSION_HEADER_BIT_KHR")]
        GenerateObuExtensionHeaderBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_PRIMARY_REFERENCE_CDF_ONLY_BIT_KHR")]
        PrimaryReferenceCdfOnlyBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_FRAME_SIZE_OVERRIDE_BIT_KHR")]
        FrameSizeOverrideBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_MOTION_VECTOR_SCALING_BIT_KHR")]
        MotionVectorScalingBitKhr = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_CAPABILITY_COMPOUND_PREDICTION_INTRA_REFRESH_BIT_KHR")]
        CompoundPredictionIntraRefreshBitKhr = 32,
    }
}
