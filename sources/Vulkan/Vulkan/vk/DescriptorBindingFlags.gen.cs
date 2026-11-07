// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorBindingFlags")]
[Flags]
public enum DescriptorBindingFlags : uint
{
    None = 0x0,

    [NativeName("VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT")]
    UpdateAfterBindBit = 0x1,

    [NativeName("VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT")]
    UpdateUnusedWhilePendingBit = 0x2,

    [NativeName("VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT")]
    PartiallyBoundBit = 0x4,

    [NativeName("VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT")]
    VariableDescriptorCountBit = 0x8,

    [NativeName("VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT")]
    UpdateAfterBindBitEXT = UpdateAfterBindBit,

    [NativeName("VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT_EXT")]
    UpdateUnusedWhilePendingBitEXT = UpdateUnusedWhilePendingBit,

    [NativeName("VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT")]
    PartiallyBoundBitEXT = PartiallyBoundBit,

    [NativeName("VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT_EXT")]
    VariableDescriptorCountBitEXT = VariableDescriptorCountBit,
}
