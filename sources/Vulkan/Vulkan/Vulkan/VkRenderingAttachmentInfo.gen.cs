// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkRenderingAttachmentInfo
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public void* pNext;

    [NativeTypeName("VkImageView")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkImageView_T* imageView;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkImageLayout imageLayout;

    [NativeTypeName("VkResolveModeFlagBits")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkResolveModeFlags resolveMode;

    [NativeTypeName("VkImageView")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkImageView_T* resolveImageView;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkImageLayout resolveImageLayout;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkAttachmentLoadOp loadOp;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkAttachmentStoreOp storeOp;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkClearValue clearValue;
}
