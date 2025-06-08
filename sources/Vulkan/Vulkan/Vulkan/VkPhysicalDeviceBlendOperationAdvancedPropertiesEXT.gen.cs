// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    public uint advancedBlendMaxColorAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    public uint advancedBlendIndependentBlend;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    public uint advancedBlendNonPremultipliedSrcColor;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    public uint advancedBlendNonPremultipliedDstColor;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    public uint advancedBlendCorrelatedOverlap;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    public uint advancedBlendAllOperations;
}
