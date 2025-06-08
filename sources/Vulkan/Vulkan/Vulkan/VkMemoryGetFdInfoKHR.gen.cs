// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkMemoryGetFdInfoKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkDeviceMemory")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    public VkDeviceMemory_T* memory;

    [NativeTypeName("VkExternalMemoryHandleTypeFlagBits")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    public VkExternalMemoryHandleTypeFlags handleType;
}
