// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkOpticalFlowPerformanceLevelNV")]
    public enum OpticalFlowPerformanceLevelNV : int
    {
        [Obsolete("Deprecated in favour of \"UnknownNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_NV")]
        OpticalFlowPerformanceLevelUnknownNV = 0,
        [Obsolete("Deprecated in favour of \"SlowNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_NV")]
        OpticalFlowPerformanceLevelSlowNV = 1,
        [Obsolete("Deprecated in favour of \"MediumNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_NV")]
        OpticalFlowPerformanceLevelMediumNV = 2,
        [Obsolete("Deprecated in favour of \"FastNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_NV")]
        OpticalFlowPerformanceLevelFastNV = 3,
        [NativeName("Name", "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_NV")]
        UnknownNV = 0,
        [NativeName("Name", "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_NV")]
        SlowNV = 1,
        [NativeName("Name", "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_NV")]
        MediumNV = 2,
        [NativeName("Name", "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_NV")]
        FastNV = 3,
    }
}
