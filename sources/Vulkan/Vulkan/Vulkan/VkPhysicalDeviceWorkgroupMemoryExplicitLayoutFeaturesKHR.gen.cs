// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_workgroup_memory_explicit_layout"],
        ImpliesSets = [
            "VK_KHR_workgroup_memory_explicit_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_workgroup_memory_explicit_layout+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_workgroup_memory_explicit_layout"],
        ImpliesSets = [
            "VK_KHR_workgroup_memory_explicit_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_workgroup_memory_explicit_layout+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_workgroup_memory_explicit_layout"],
        ImpliesSets = [
            "VK_KHR_workgroup_memory_explicit_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_workgroup_memory_explicit_layout+VK_VERSION_1_1",
        ]
    )]
    public uint workgroupMemoryExplicitLayout;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_workgroup_memory_explicit_layout"],
        ImpliesSets = [
            "VK_KHR_workgroup_memory_explicit_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_workgroup_memory_explicit_layout+VK_VERSION_1_1",
        ]
    )]
    public uint workgroupMemoryExplicitLayoutScalarBlockLayout;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_workgroup_memory_explicit_layout"],
        ImpliesSets = [
            "VK_KHR_workgroup_memory_explicit_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_workgroup_memory_explicit_layout+VK_VERSION_1_1",
        ]
    )]
    public uint workgroupMemoryExplicitLayout8BitAccess;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_workgroup_memory_explicit_layout"],
        ImpliesSets = [
            "VK_KHR_workgroup_memory_explicit_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_workgroup_memory_explicit_layout+VK_VERSION_1_1",
        ]
    )]
    public uint workgroupMemoryExplicitLayout16BitAccess;
}
