// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDescriptorBindingFlagsEXT")]
    public enum DescriptorBindingFlagsEXT : int
    {
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT")]
        DescriptorBindingUpdateAfterBindBit = 1,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT")]
        DescriptorBindingUpdateUnusedWhilePendingBit = 2,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT")]
        DescriptorBindingPartiallyBoundBit = 4,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT")]
        DescriptorBindingVariableDescriptorCountBit = 8,
    }
}
