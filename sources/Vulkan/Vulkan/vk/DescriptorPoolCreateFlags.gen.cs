// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorPoolCreateFlags")]
[Flags]
public enum DescriptorPoolCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT")]
    FreeDescriptorSetBit = 0x1,

    [NativeName("VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT")]
    UpdateAfterBindBit = 0x2,

    [NativeName("VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT")]
    HostOnlyBitEXT = 0x4,

    [NativeName("VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_SETS_BIT_NV")]
    AllowOverallocationSetsBitNV = 0x8,

    [NativeName("VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_POOLS_BIT_NV")]
    AllowOverallocationPoolsBitNV = 0x10,

    [NativeName("VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT")]
    UpdateAfterBindBitEXT = UpdateAfterBindBit,

    [NativeName("VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE")]
    HostOnlyBitVALVE = HostOnlyBitEXT,
}
