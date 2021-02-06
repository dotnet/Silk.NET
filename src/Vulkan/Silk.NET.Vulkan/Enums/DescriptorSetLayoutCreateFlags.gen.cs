// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkDescriptorSetLayoutCreateFlags")]
    public enum DescriptorSetLayoutCreateFlags : int
    {
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR")]
        DescriptorSetLayoutCreatePushDescriptorBitKhr = 1,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT")]
        DescriptorSetLayoutCreateUpdateAfterBindPoolBitExt = 2,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE")]
        DescriptorSetLayoutCreateHostOnlyPoolBitValve = 4,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT")]
        DescriptorSetLayoutCreateUpdateAfterBindPoolBit = 2,
    }
}
