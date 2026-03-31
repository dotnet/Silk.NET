// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMaintenance7PropertiesKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceMaintenance7PropertiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public void* PNext;

    [NativeName("robustFragmentShadingRateAttachmentAccess")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint RobustFragmentShadingRateAttachmentAccess;

    [NativeName("separateDepthStencilAttachmentAccess")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint SeparateDepthStencilAttachmentAccess;

    [NativeName("maxDescriptorSetTotalUniformBuffersDynamic")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetTotalUniformBuffersDynamic;

    [NativeName("maxDescriptorSetTotalStorageBuffersDynamic")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetTotalStorageBuffersDynamic;

    [NativeName("maxDescriptorSetTotalBuffersDynamic")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetTotalBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindTotalBuffersDynamic")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
}
