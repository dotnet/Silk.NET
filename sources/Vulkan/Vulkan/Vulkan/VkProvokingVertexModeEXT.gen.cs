// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkProvokingVertexModeEXT")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkProvokingVertexModeEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_PROVOKING_VERTEX_MODE_FIRST_VERTEX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    VkProvokingVertexModeFirstVertex = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_PROVOKING_VERTEX_MODE_LAST_VERTEX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    VkProvokingVertexModeLastVertex = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_PROVOKING_VERTEX_MODE_MAX_ENUM_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    VkProvokingVertexModeMaxEnum = 0x7FFFFFFF,
}
