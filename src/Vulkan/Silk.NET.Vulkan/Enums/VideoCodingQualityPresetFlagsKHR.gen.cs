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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"NormalBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODING_QUALITY_PRESET_NORMAL_BIT_KHR")]
        VideoCodingQualityPresetNormalBitKhr = 1,
        [Obsolete("Deprecated in favour of \"PowerBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODING_QUALITY_PRESET_POWER_BIT_KHR")]
        VideoCodingQualityPresetPowerBitKhr = 2,
        [Obsolete("Deprecated in favour of \"QualityBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODING_QUALITY_PRESET_QUALITY_BIT_KHR")]
        VideoCodingQualityPresetQualityBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_CODING_QUALITY_PRESET_NORMAL_BIT_KHR")]
        NormalBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_CODING_QUALITY_PRESET_POWER_BIT_KHR")]
        PowerBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_CODING_QUALITY_PRESET_QUALITY_BIT_KHR")]
        QualityBitKhr = 4,
    }
}
