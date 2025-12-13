// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPresentTimingInfoFlagsEXT")]
    public enum PresentTimingInfoFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"RelativeTimeBitExt\"")]
        [NativeName("Name", "VK_PRESENT_TIMING_INFO_PRESENT_AT_RELATIVE_TIME_BIT_EXT")]
        PresentTimingInfoPresentATRelativeTimeBitExt = 1,
        [Obsolete("Deprecated in favour of \"NearestRefreshCycleBitExt\"")]
        [NativeName("Name", "VK_PRESENT_TIMING_INFO_PRESENT_AT_NEAREST_REFRESH_CYCLE_BIT_EXT")]
        PresentTimingInfoPresentATNearestRefreshCycleBitExt = 2,
        [NativeName("Name", "VK_PRESENT_TIMING_INFO_PRESENT_AT_RELATIVE_TIME_BIT_EXT")]
        RelativeTimeBitExt = 1,
        [NativeName("Name", "VK_PRESENT_TIMING_INFO_PRESENT_AT_NEAREST_REFRESH_CYCLE_BIT_EXT")]
        NearestRefreshCycleBitExt = 2,
    }
}
