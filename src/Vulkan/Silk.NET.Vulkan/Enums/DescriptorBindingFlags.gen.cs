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
    [NativeName("Name", "VkDescriptorBindingFlags")]
    public enum DescriptorBindingFlags : int
    {
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT")]
        DescriptorBindingUpdateAfterBindBit = 1,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT")]
        DescriptorBindingUpdateUnusedWhilePendingBit = 2,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT")]
        DescriptorBindingPartiallyBoundBit = 4,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT")]
        DescriptorBindingVariableDescriptorCountBit = 8,
        [NativeName("Name", "VK_DESCRIPTOR_BINDING_RESERVED_4_BIT_QCOM")]
        DescriptorBindingReserved4BitQCom = 16,
    }
}
