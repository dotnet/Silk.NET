// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineLayoutCreateFlagBits")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum PipelineLayoutCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    IndependentSetsBitEXT = 0x2,

    [NativeName("VK_PIPELINE_LAYOUT_CREATE_NO_TASK_SHADER_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_maintenance11+VK_EXT_shader_object+VK_EXT_mesh_shader",
            "VK_KHR_maintenance11+VK_EXT_shader_object+VK_NV_mesh_shader",
        ],
        ImpliesSets = [
            "VK_KHR_maintenance11+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance11+VK_VERSION_1_1",
        ]
    )]
    NoTaskShaderBitKHR = 0x4,
}
