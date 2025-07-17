// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum PipelineDepthStencilStateCreateFlags : uint
{
    None = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    RasterizationOrderAttachmentDepthAccessBitEXT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    RasterizationOrderAttachmentStencilAccessBitEXT = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    RasterizationOrderAttachmentDepthAccessBitARM = RasterizationOrderAttachmentDepthAccessBitEXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    RasterizationOrderAttachmentStencilAccessBitARM =
        RasterizationOrderAttachmentStencilAccessBitEXT,
}
