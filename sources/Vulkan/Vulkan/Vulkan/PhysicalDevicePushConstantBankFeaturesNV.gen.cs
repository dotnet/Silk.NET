// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDevicePushConstantBankFeaturesNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDevicePushConstantBankFeaturesNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public StructureType SType = StructureType.PhysicalDevicePushConstantBankFeaturesNV;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public void* PNext;

    [NativeName("pushConstantBank")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public MaybeBool<uint> PushConstantBank;

    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public PhysicalDevicePushConstantBankFeaturesNV() { }
}
