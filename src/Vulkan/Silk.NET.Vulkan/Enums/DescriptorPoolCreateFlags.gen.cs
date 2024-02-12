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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"FreeDescriptorSetBit\"")]
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT")]
        DescriptorPoolCreateFreeDescriptorSetBit = 1,
        [Obsolete("Deprecated in favour of \"UpdateAfterBindBitExt\"")]
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT")]
        DescriptorPoolCreateUpdateAfterBindBitExt = 2,
        [Obsolete("Deprecated in favour of \"HostOnlyBitValve\"")]
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE")]
        DescriptorPoolCreateHostOnlyBitValve = 4,
        [Obsolete("Deprecated in favour of \"HostOnlyBitExt\"")]
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT")]
        DescriptorPoolCreateHostOnlyBitExt = 4,
        [Obsolete("Deprecated in favour of \"AllowOverallocationSetsBitNV\"")]
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_SETS_BIT_NV")]
        DescriptorPoolCreateAllowOverallocationSetsBitNV = 8,
        [Obsolete("Deprecated in favour of \"AllowOverallocationPoolsBitNV\"")]
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_POOLS_BIT_NV")]
        DescriptorPoolCreateAllowOverallocationPoolsBitNV = 16,
        [Obsolete("Deprecated in favour of \"UpdateAfterBindBit\"")]
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT")]
        DescriptorPoolCreateUpdateAfterBindBit = 2,
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT")]
        FreeDescriptorSetBit = 1,
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT")]
        UpdateAfterBindBitExt = 2,
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE")]
        HostOnlyBitValve = 4,
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT")]
        HostOnlyBitExt = 4,
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_SETS_BIT_NV")]
        AllowOverallocationSetsBitNV = 8,
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_POOLS_BIT_NV")]
        AllowOverallocationPoolsBitNV = 16,
        [NativeName("Name", "VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT")]
        UpdateAfterBindBit = 2,
    }
}
