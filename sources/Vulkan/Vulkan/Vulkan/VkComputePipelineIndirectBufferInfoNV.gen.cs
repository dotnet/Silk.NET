// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkComputePipelineIndirectBufferInfoNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    public void* pNext;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    public ulong deviceAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    public ulong size;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    public ulong pipelineDeviceAddressCaptureReplay;
}
