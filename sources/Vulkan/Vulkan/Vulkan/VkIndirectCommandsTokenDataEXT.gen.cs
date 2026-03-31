// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectCommandsTokenDataEXT")]
[StructLayout(LayoutKind.Explicit)]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkIndirectCommandsTokenDataEXT
{
    [NativeName("pPushConstant")]
    [FieldOffset(0)]
    [NativeTypeName("const VkIndirectCommandsPushConstantTokenEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkIndirectCommandsPushConstantTokenEXT* PPushConstant;

    [NativeName("pVertexBuffer")]
    [FieldOffset(0)]
    [NativeTypeName("const VkIndirectCommandsVertexBufferTokenEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkIndirectCommandsVertexBufferTokenEXT* PVertexBuffer;

    [NativeName("pIndexBuffer")]
    [FieldOffset(0)]
    [NativeTypeName("const VkIndirectCommandsIndexBufferTokenEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkIndirectCommandsIndexBufferTokenEXT* PIndexBuffer;

    [NativeName("pExecutionSet")]
    [FieldOffset(0)]
    [NativeTypeName("const VkIndirectCommandsExecutionSetTokenEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkIndirectCommandsExecutionSetTokenEXT* PExecutionSet;
}
