// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkIndirectCommandsTokenTypeNV")]
[SupportedApiProfile("vulkan")]
public enum IndirectCommandsTokenTypeNV : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    ShaderGroupnv = 0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    StateFlagsnv = 1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    IndexBuffernv = 2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VertexBuffernv = 3,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    PushConstantnv = 4,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    DrawIndexednv = 5,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    Drawnv = 6,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    DrawTasksnv = 7,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader", "VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"],
        RequireAll = true
    )]
    DrawMeshTasksnv = 1000328000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    Pipelinenv = 1000428003,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    Dispatchnv = 1000428004,
}
