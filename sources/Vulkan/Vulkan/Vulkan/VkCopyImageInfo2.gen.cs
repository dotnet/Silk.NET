// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCopyImageInfo2
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public void* pNext;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkImage_T* srcImage;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkImageLayout srcImageLayout;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkImage_T* dstImage;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkImageLayout dstImageLayout;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint regionCount;

    [NativeTypeName("const VkImageCopy2 *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public VkImageCopy2* pRegions;
}
