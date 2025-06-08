// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkAttachmentSampleCountInfoAMD
{
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_AMD_mixed_attachment_samples+VK_KHR_dynamic_rendering",
            "VK_AMD_mixed_attachment_samples+VK_VERSION_1_3",
        ]
    )]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_AMD_mixed_attachment_samples+VK_KHR_dynamic_rendering",
            "VK_AMD_mixed_attachment_samples+VK_VERSION_1_3",
        ]
    )]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_AMD_mixed_attachment_samples+VK_KHR_dynamic_rendering",
            "VK_AMD_mixed_attachment_samples+VK_VERSION_1_3",
        ]
    )]
    public uint colorAttachmentCount;

    [NativeTypeName("const VkSampleCountFlagBits *")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_AMD_mixed_attachment_samples+VK_KHR_dynamic_rendering",
            "VK_AMD_mixed_attachment_samples+VK_VERSION_1_3",
        ]
    )]
    public VkSampleCountFlags* pColorAttachmentSamples;

    [NativeTypeName("VkSampleCountFlagBits")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_AMD_mixed_attachment_samples+VK_KHR_dynamic_rendering",
            "VK_AMD_mixed_attachment_samples+VK_VERSION_1_3",
        ]
    )]
    public VkSampleCountFlags depthStencilAttachmentSamples;
}
