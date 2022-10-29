// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoEncodeTuningModeKHR")]
    public enum VideoEncodeTuningModeKHR : int
    {
        [Obsolete("Deprecated in favour of \"DefaultKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_TUNING_MODE_DEFAULT_KHR")]
        VideoEncodeTuningModeDefaultKhr = 0,
        [Obsolete("Deprecated in favour of \"HighQualityKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_TUNING_MODE_HIGH_QUALITY_KHR")]
        VideoEncodeTuningModeHighQualityKhr = 1,
        [Obsolete("Deprecated in favour of \"LowLatencyKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_TUNING_MODE_LOW_LATENCY_KHR")]
        VideoEncodeTuningModeLowLatencyKhr = 2,
        [Obsolete("Deprecated in favour of \"UltraLowLatencyKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_TUNING_MODE_ULTRA_LOW_LATENCY_KHR")]
        VideoEncodeTuningModeUltraLowLatencyKhr = 3,
        [Obsolete("Deprecated in favour of \"LosslessKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_TUNING_MODE_LOSSLESS_KHR")]
        VideoEncodeTuningModeLosslessKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_TUNING_MODE_DEFAULT_KHR")]
        DefaultKhr = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_TUNING_MODE_HIGH_QUALITY_KHR")]
        HighQualityKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_TUNING_MODE_LOW_LATENCY_KHR")]
        LowLatencyKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_TUNING_MODE_ULTRA_LOW_LATENCY_KHR")]
        UltraLowLatencyKhr = 3,
        [NativeName("Name", "VK_VIDEO_ENCODE_TUNING_MODE_LOSSLESS_KHR")]
        LosslessKhr = 4,
    }
}
