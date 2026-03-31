// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAttachmentStoreOp")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkAttachmentStoreOp : uint
{
    [NativeName("VK_ATTACHMENT_STORE_OP_STORE")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkAttachmentStoreOpStore = 0,

    [NativeName("VK_ATTACHMENT_STORE_OP_DONT_CARE")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkAttachmentStoreOpDontCare = 1,

    [NativeName("VK_ATTACHMENT_STORE_OP_NONE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkAttachmentStoreOpNone = 1000301000,

    [NativeName("VK_ATTACHMENT_STORE_OP_NONE_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkAttachmentStoreOpNoneKHR = VkAttachmentStoreOpNone,

    [NativeName("VK_ATTACHMENT_STORE_OP_NONE_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_store_ops"])]
    VkAttachmentStoreOpNoneQCOM = VkAttachmentStoreOpNone,

    [NativeName("VK_ATTACHMENT_STORE_OP_NONE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_load_store_op_none"])]
    VkAttachmentStoreOpNoneEXT = VkAttachmentStoreOpNone,

    [NativeName("VK_ATTACHMENT_STORE_OP_MAX_ENUM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkAttachmentStoreOpMaxEnum = 0x7FFFFFFF,
}
