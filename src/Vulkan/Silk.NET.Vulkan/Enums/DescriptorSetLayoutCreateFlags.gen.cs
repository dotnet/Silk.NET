// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDescriptorSetLayoutCreateFlags")]
    public enum DescriptorSetLayoutCreateFlags : int
    {
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR")]
        DescriptorSetLayoutCreatePushDescriptorBitKhr = 1,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT")]
        DescriptorSetLayoutCreateUpdateAfterBindPoolBitExt = 2,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_4_BIT_AMD")]
        DescriptorSetLayoutCreateReserved4BitAmd = 16,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_3_BIT_AMD")]
        DescriptorSetLayoutCreateReserved3BitAmd = 8,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE")]
        DescriptorSetLayoutCreateHostOnlyPoolBitValve = 4,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT")]
        DescriptorSetLayoutCreateUpdateAfterBindPoolBit = 2,
    }
}
