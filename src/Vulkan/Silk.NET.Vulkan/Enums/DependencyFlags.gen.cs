// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDependencyFlags")]
    public enum DependencyFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ByRegionBit\"")]
        [NativeName("Name", "VK_DEPENDENCY_BY_REGION_BIT")]
        DependencyByRegionBit = 1,
        [Obsolete("Deprecated in favour of \"ViewLocalBitKhr\"")]
        [NativeName("Name", "VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR")]
        DependencyViewLocalBitKhr = 2,
        [Obsolete("Deprecated in favour of \"DeviceGroupBitKhr\"")]
        [NativeName("Name", "VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR")]
        DependencyDeviceGroupBitKhr = 4,
        [Obsolete("Deprecated in favour of \"FeedbackLoopBitExt\"")]
        [NativeName("Name", "VK_DEPENDENCY_FEEDBACK_LOOP_BIT_EXT")]
        DependencyFeedbackLoopBitExt = 8,
        [Obsolete("Deprecated in favour of \"DeviceGroupBit\"")]
        [NativeName("Name", "VK_DEPENDENCY_DEVICE_GROUP_BIT")]
        DependencyDeviceGroupBit = 4,
        [Obsolete("Deprecated in favour of \"ViewLocalBit\"")]
        [NativeName("Name", "VK_DEPENDENCY_VIEW_LOCAL_BIT")]
        DependencyViewLocalBit = 2,
        [NativeName("Name", "VK_DEPENDENCY_BY_REGION_BIT")]
        ByRegionBit = 1,
        [NativeName("Name", "VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR")]
        ViewLocalBitKhr = 2,
        [NativeName("Name", "VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR")]
        DeviceGroupBitKhr = 4,
        [NativeName("Name", "VK_DEPENDENCY_FEEDBACK_LOOP_BIT_EXT")]
        FeedbackLoopBitExt = 8,
        [NativeName("Name", "VK_DEPENDENCY_DEVICE_GROUP_BIT")]
        DeviceGroupBit = 4,
        [NativeName("Name", "VK_DEPENDENCY_VIEW_LOCAL_BIT")]
        ViewLocalBit = 2,
    }
}
