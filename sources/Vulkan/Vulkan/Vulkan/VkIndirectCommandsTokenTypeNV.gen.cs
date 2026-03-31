// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkIndirectCommandsTokenTypeNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkIndirectCommandsTokenTypeNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkIndirectCommandsTokenTypeShaderGroup = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkIndirectCommandsTokenTypeStateFlags = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkIndirectCommandsTokenTypeIndexBuffer = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkIndirectCommandsTokenTypeVertexBuffer = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkIndirectCommandsTokenTypePushConstant = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkIndirectCommandsTokenTypeDrawIndexed = 5,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkIndirectCommandsTokenTypeDraw = 6,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkIndirectCommandsTokenTypeDrawTasks = 7,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader", "VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"],
        RequireAll = true
    )]
    VkIndirectCommandsTokenTypeDrawMeshTasks = 1000328000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    VkIndirectCommandsTokenTypePipeline = 1000428003,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    VkIndirectCommandsTokenTypeDispatch = 1000428004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkIndirectCommandsTokenTypeMaxEnum = 0x7FFFFFFF,
}
