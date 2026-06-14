// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectCommandsLayoutPushDataTokenNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct IndirectCommandsLayoutPushDataTokenNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap", "VK_NV_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public StructureType SType = StructureType.IndirectCommandsLayoutPushDataTokenNV;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap", "VK_NV_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("pushDataOffset")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap", "VK_NV_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public uint PushDataOffset;

    [NativeName("pushDataSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap", "VK_NV_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public uint PushDataSize;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap", "VK_NV_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public IndirectCommandsLayoutPushDataTokenNV() { }
}
