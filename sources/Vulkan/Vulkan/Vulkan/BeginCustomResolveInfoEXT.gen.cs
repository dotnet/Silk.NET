// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBeginCustomResolveInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct BeginCustomResolveInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve+VK_KHR_dynamic_rendering", "VK_EXT_custom_resolve+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.BeginCustomResolveInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve+VK_KHR_dynamic_rendering", "VK_EXT_custom_resolve+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve+VK_KHR_dynamic_rendering", "VK_EXT_custom_resolve+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public BeginCustomResolveInfoEXT() { }
}
