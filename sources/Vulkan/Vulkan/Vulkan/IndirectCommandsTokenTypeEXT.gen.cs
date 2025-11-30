// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkIndirectCommandsTokenTypeEXT")]
[SupportedApiProfile("vulkan")]
public enum IndirectCommandsTokenTypeEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_EXECUTION_SET_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    ExecutionSetext = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    PushConstantext = 1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_SEQUENCE_INDEX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    SequenceIndexext = 2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    IndexBufferext = 3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VertexBufferext = 4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    DrawIndexedext = 5,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    Drawext = 6,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_COUNT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    DrawIndexedCountext = 7,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_COUNT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    DrawCountext = 8,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    Dispatchext = 9,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands", "VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    DrawMeshTasksNvext = 1000202002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_NV_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands", "VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    DrawMeshTasksCountNvext = 1000202003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands", "VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"],
        RequireAll = true
    )]
    DrawMeshTasksext = 1000328000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands", "VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"],
        RequireAll = true
    )]
    DrawMeshTasksCountext = 1000328001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_TRACE_RAYS2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands", "VK_KHR_ray_tracing_maintenance1"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    TraceRays2Ext = 1000386004,
}
