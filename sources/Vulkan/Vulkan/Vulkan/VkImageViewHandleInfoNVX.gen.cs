// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageViewHandleInfoNVX")]
[NameAffix("Suffix", "KhronosVendor", "NVX")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkImageViewHandleInfoNVX
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public void* PNext;

    [NativeName("imageView")]
    [NativeTypeName("VkImageView")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public VkImageViewHandle ImageView;

    [NativeName("descriptorType")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public VkDescriptorType DescriptorType;

    [NativeName("sampler")]
    [NativeTypeName("VkSampler")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public VkSamplerHandle Sampler;
}
