// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ImageViewHandleInfoNVX
{
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public void* PNext;

    [NativeTypeName("VkImageView")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public ImageViewTHandle ImageView;

    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public DescriptorType DescriptorType;

    [NativeTypeName("VkSampler")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public SamplerTHandle Sampler;
}
