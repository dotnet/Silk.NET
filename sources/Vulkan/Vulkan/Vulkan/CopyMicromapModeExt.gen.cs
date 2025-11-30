// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkCopyMicromapModeEXT")]
[SupportedApiProfile("vulkan")]
public enum CopyMicromapModeExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COPY_MICROMAP_MODE_CLONE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    Cloneext = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COPY_MICROMAP_MODE_SERIALIZE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    Serializeext = 1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    Deserializeext = 2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COPY_MICROMAP_MODE_COMPACT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    Compactext = 3,
}
