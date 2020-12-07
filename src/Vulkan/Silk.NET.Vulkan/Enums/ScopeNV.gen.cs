// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkScopeNV")]
    public enum ScopeNV
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
