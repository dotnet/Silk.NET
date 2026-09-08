// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureSerializedBlockTypeKHR")]
[SupportedApiProfile("vulkan")]
public enum AccelerationStructureSerializedBlockTypeKHR : uint
{
    [NativeName("VK_ACCELERATION_STRUCTURE_SERIALIZED_BLOCK_TYPE_OPACITY_MICROMAP_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    OpacityMicromap = 0,
}
