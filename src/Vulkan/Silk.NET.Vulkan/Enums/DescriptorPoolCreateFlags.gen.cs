// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDescriptorPoolCreateFlags")]
    public enum DescriptorPoolCreateFlags : int
    {
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT")]
        DescriptorPoolCreateFreeDescriptorSetBit = 1,
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT")]
        DescriptorPoolCreateUpdateAfterBindBitExt = 2,
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE")]
        DescriptorPoolCreateHostOnlyBitValve = 4,
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT")]
        DescriptorPoolCreateUpdateAfterBindBit = 2,
    }
}
