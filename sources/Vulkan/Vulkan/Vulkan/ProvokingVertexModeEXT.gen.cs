// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("EXT", 0)]
[NativeName("VkProvokingVertexModeEXT")]
[SupportedApiProfile("vulkan")]
public enum ProvokingVertexModeEXT : uint
{
    [NameSuffix("EXT", 0)]
    [NativeName("VK_PROVOKING_VERTEX_MODE_FIRST_VERTEX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    FirstVertexEXT = 0,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_PROVOKING_VERTEX_MODE_LAST_VERTEX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    LastVertexEXT = 1,
}
