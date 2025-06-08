// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceVulkan13Features
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint robustImageAccess;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint inlineUniformBlock;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint descriptorBindingInlineUniformBlockUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint pipelineCreationCacheControl;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint privateData;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint shaderDemoteToHelperInvocation;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint shaderTerminateInvocation;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint subgroupSizeControl;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint computeFullSubgroups;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint synchronization2;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    public uint textureCompressionASTC_HDR;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint shaderZeroInitializeWorkgroupMemory;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint dynamicRendering;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint shaderIntegerDotProduct;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint maintenance4;
}
