// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkImageViewHandleInfoNVX
{
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public void* pNext;

    [NativeTypeName("VkImageView")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public VkImageView_T* imageView;

    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public VkDescriptorType descriptorType;

    [NativeTypeName("VkSampler")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public VkSampler_T* sampler;
}
