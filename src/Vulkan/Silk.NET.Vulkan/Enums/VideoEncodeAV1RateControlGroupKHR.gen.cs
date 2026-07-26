// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoEncodeAV1RateControlGroupKHR")]
    public enum VideoEncodeAV1RateControlGroupKHR : int
    {
        [Obsolete("Deprecated in favour of \"IntraKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR")]
        VideoEncodeAV1RateControlGroupIntraKhr = 0,
        [Obsolete("Deprecated in favour of \"PredictiveKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR")]
        VideoEncodeAV1RateControlGroupPredictiveKhr = 1,
        [Obsolete("Deprecated in favour of \"BipredictiveKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR")]
        VideoEncodeAV1RateControlGroupBipredictiveKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR")]
        IntraKhr = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR")]
        PredictiveKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR")]
        BipredictiveKhr = 2,
    }
}
