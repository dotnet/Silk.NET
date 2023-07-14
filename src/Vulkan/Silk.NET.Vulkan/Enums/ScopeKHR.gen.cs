// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkScopeKHR")]
    public enum ScopeKHR : int
    {
        [Obsolete("Deprecated in favour of \"DeviceKhr\"")]
        [NativeName("Name", "VK_SCOPE_DEVICE_KHR")]
        ScopeDeviceKhr = 1,
        [Obsolete("Deprecated in favour of \"WorkgroupKhr\"")]
        [NativeName("Name", "VK_SCOPE_WORKGROUP_KHR")]
        ScopeWorkgroupKhr = 2,
        [Obsolete("Deprecated in favour of \"SubgroupKhr\"")]
        [NativeName("Name", "VK_SCOPE_SUBGROUP_KHR")]
        ScopeSubgroupKhr = 3,
        [Obsolete("Deprecated in favour of \"QueueFamilyKhr\"")]
        [NativeName("Name", "VK_SCOPE_QUEUE_FAMILY_KHR")]
        ScopeQueueFamilyKhr = 5,
        [NativeName("Name", "VK_SCOPE_DEVICE_KHR")]
        DeviceKhr = 1,
        [NativeName("Name", "VK_SCOPE_WORKGROUP_KHR")]
        WorkgroupKhr = 2,
        [NativeName("Name", "VK_SCOPE_SUBGROUP_KHR")]
        SubgroupKhr = 3,
        [NativeName("Name", "VK_SCOPE_QUEUE_FAMILY_KHR")]
        QueueFamilyKhr = 5,
    }
}
