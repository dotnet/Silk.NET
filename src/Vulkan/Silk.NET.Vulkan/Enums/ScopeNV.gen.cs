// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkScopeNV")]
    public enum ScopeNV : int
    {
        [NativeName("Name", "VK_SCOPE_DEVICE_NV")]
        ScopeDeviceNV = 1,
        [NativeName("Name", "VK_SCOPE_WORKGROUP_NV")]
        ScopeWorkgroupNV = 2,
        [NativeName("Name", "VK_SCOPE_SUBGROUP_NV")]
        ScopeSubgroupNV = 3,
        [NativeName("Name", "VK_SCOPE_QUEUE_FAMILY_NV")]
        ScopeQueueFamilyNV = 5,
    }
}
