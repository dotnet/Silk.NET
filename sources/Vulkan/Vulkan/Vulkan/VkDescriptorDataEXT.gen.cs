// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDescriptorDataEXT
{
    [FieldOffset(0)]
    [NativeTypeName("const VkSampler *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkSampler_T** pSampler;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorImageInfo *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkDescriptorImageInfo* pCombinedImageSampler;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorImageInfo *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkDescriptorImageInfo* pInputAttachmentImage;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorImageInfo *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkDescriptorImageInfo* pSampledImage;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorImageInfo *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkDescriptorImageInfo* pStorageImage;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorAddressInfoEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkDescriptorAddressInfoEXT* pUniformTexelBuffer;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorAddressInfoEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkDescriptorAddressInfoEXT* pStorageTexelBuffer;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorAddressInfoEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkDescriptorAddressInfoEXT* pUniformBuffer;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorAddressInfoEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkDescriptorAddressInfoEXT* pStorageBuffer;

    [FieldOffset(0)]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    public ulong accelerationStructure;
}
