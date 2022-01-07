// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoCodingQualityPresetFlagsKHR")]
    public enum VideoCodingQualityPresetFlagsKHR : int
    {
        [NativeName("Name", "VK_VIDEO_CODING_QUALITY_PRESET_NORMAL_BIT_KHR")]
        VideoCodingQualityPresetNormalBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_CODING_QUALITY_PRESET_POWER_BIT_KHR")]
        VideoCodingQualityPresetPowerBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_CODING_QUALITY_PRESET_QUALITY_BIT_KHR")]
        VideoCodingQualityPresetQualityBitKhr = 4,
    }
}
