// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkPhysicalDeviceMaintenance7PropertiesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceMaintenance7PropertiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public void* PNext;

    [NativeName("robustFragmentShadingRateAttachmentAccess")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint RobustFragmentShadingRateAttachmentAccess;

    [NativeName("separateDepthStencilAttachmentAccess")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint SeparateDepthStencilAttachmentAccess;

    [NativeName("maxDescriptorSetTotalUniformBuffersDynamic")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetTotalUniformBuffersDynamic;

    [NativeName("maxDescriptorSetTotalStorageBuffersDynamic")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetTotalStorageBuffersDynamic;

    [NativeName("maxDescriptorSetTotalBuffersDynamic")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetTotalBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindTotalBuffersDynamic")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
}
