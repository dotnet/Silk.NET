// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDescriptorBindingFlags")]
    public enum DescriptorBindingFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"UpdateAfterBindBit\"")]
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT")]
        DescriptorBindingUpdateAfterBindBit = 1,
        [Obsolete("Deprecated in favour of \"UpdateUnusedWhilePendingBit\"")]
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT")]
        DescriptorBindingUpdateUnusedWhilePendingBit = 2,
        [Obsolete("Deprecated in favour of \"PartiallyBoundBit\"")]
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT")]
        DescriptorBindingPartiallyBoundBit = 4,
        [Obsolete("Deprecated in favour of \"VariableDescriptorCountBit\"")]
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT")]
        DescriptorBindingVariableDescriptorCountBit = 8,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT")]
        UpdateAfterBindBit = 1,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT")]
        UpdateUnusedWhilePendingBit = 2,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT")]
        PartiallyBoundBit = 4,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT")]
        VariableDescriptorCountBit = 8,
    }
}
