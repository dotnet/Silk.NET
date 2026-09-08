// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceFragmentShaderBarycentricPropertiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex", "VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public StructureType SType = StructureType.PhysicalDeviceFragmentShaderBarycentricPropertiesKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex", "VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("triStripVertexOrderIndependentOfProvokingVertex")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex", "VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public MaybeBool<uint> TriStripVertexOrderIndependentOfProvokingVertex;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex", "VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public PhysicalDeviceFragmentShaderBarycentricPropertiesKHR() { }
}
