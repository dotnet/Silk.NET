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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PushDescriptorBitKhr\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR")]
        DescriptorSetLayoutCreatePushDescriptorBitKhr = 1,
        [Obsolete("Deprecated in favour of \"UpdateAfterBindPoolBitExt\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT")]
        DescriptorSetLayoutCreateUpdateAfterBindPoolBitExt = 2,
        [Obsolete("Deprecated in favour of \"DescriptorBufferBitExt\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_DESCRIPTOR_BUFFER_BIT_EXT")]
        DescriptorSetLayoutCreateDescriptorBufferBitExt = 16,
        [Obsolete("Deprecated in favour of \"EmbeddedImmutableSamplersBitExt\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_EMBEDDED_IMMUTABLE_SAMPLERS_BIT_EXT")]
        DescriptorSetLayoutCreateEmbeddedImmutableSamplersBitExt = 32,
        [Obsolete("Deprecated in favour of \"HostOnlyPoolBitValve\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE")]
        DescriptorSetLayoutCreateHostOnlyPoolBitValve = 4,
        [Obsolete("Deprecated in favour of \"IndirectBindableBitNV\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_INDIRECT_BINDABLE_BIT_NV")]
        DescriptorSetLayoutCreateIndirectBindableBitNV = 128,
        [Obsolete("Deprecated in favour of \"HostOnlyPoolBitExt\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_EXT")]
        DescriptorSetLayoutCreateHostOnlyPoolBitExt = 4,
        [Obsolete("Deprecated in favour of \"PerStageBitNV\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_PER_STAGE_BIT_NV")]
        DescriptorSetLayoutCreatePerStageBitNV = 64,
        [Obsolete("Deprecated in favour of \"UpdateAfterBindPoolBit\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT")]
        DescriptorSetLayoutCreateUpdateAfterBindPoolBit = 2,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR")]
        PushDescriptorBitKhr = 1,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT")]
        UpdateAfterBindPoolBitExt = 2,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_DESCRIPTOR_BUFFER_BIT_EXT")]
        DescriptorBufferBitExt = 16,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_EMBEDDED_IMMUTABLE_SAMPLERS_BIT_EXT")]
        EmbeddedImmutableSamplersBitExt = 32,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE")]
        HostOnlyPoolBitValve = 4,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_INDIRECT_BINDABLE_BIT_NV")]
        IndirectBindableBitNV = 128,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_EXT")]
        HostOnlyPoolBitExt = 4,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_PER_STAGE_BIT_NV")]
        PerStageBitNV = 64,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT")]
        UpdateAfterBindPoolBit = 2,
    }
}
