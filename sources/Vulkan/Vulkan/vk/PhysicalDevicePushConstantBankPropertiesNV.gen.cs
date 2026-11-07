// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDevicePushConstantBankPropertiesNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDevicePushConstantBankPropertiesNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public StructureType SType = StructureType.PhysicalDevicePushConstantBankPropertiesNV;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public void* PNext;

    [NativeName("maxGraphicsPushConstantBanks")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public uint MaxGraphicsPushConstantBanks;

    [NativeName("maxComputePushConstantBanks")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public uint MaxComputePushConstantBanks;

    [NativeName("maxGraphicsPushDataBanks")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public uint MaxGraphicsPushDataBanks;

    [NativeName("maxComputePushDataBanks")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public uint MaxComputePushDataBanks;

    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public PhysicalDevicePushConstantBankPropertiesNV() { }
}
