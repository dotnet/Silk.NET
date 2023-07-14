// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoCodingControlFlagsKHR")]
    public enum VideoCodingControlFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ResetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR")]
        VideoCodingControlResetBitKhr = 1,
        [Obsolete("Deprecated in favour of \"EncodeRateControlBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODING_CONTROL_ENCODE_RATE_CONTROL_BIT_KHR")]
        VideoCodingControlEncodeRateControlBitKhr = 2,
        [Obsolete("Deprecated in favour of \"EncodeQualityLevelBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODING_CONTROL_ENCODE_QUALITY_LEVEL_BIT_KHR")]
        VideoCodingControlEncodeQualityLevelBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR")]
        ResetBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_CODING_CONTROL_ENCODE_RATE_CONTROL_BIT_KHR")]
        EncodeRateControlBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_CODING_CONTROL_ENCODE_QUALITY_LEVEL_BIT_KHR")]
        EncodeQualityLevelBitKhr = 4,
    }
}
