// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorSetLayoutCreateFlags")]
[Flags]
public enum DescriptorSetLayoutCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT")]
    UpdateAfterBindPoolBit = 0x2,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT")]
    PushDescriptorBit = 0x1,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_DESCRIPTOR_BUFFER_BIT_EXT")]
    DescriptorBufferBitEXT = 0x10,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_EMBEDDED_IMMUTABLE_SAMPLERS_BIT_EXT")]
    EmbeddedImmutableSamplersBitEXT = 0x20,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_INDIRECT_BINDABLE_BIT_NV")]
    IndirectBindableBitNV = 0x80,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_EXT")]
    HostOnlyPoolBitEXT = 0x4,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_PER_STAGE_BIT_NV")]
    PerStageBitNV = 0x40,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR")]
    PushDescriptorBitKHR = PushDescriptorBit,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT")]
    UpdateAfterBindPoolBitEXT = UpdateAfterBindPoolBit,

    [NativeName("VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE")]
    HostOnlyPoolBitVALVE = HostOnlyPoolBitEXT,
}
