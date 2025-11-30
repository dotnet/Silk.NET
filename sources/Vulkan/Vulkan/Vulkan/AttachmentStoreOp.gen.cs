// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAttachmentStoreOp")]
[SupportedApiProfile("vulkan")]
public enum AttachmentStoreOp : uint
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
    Store = 0,

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
    DontCare = 1,

    [NativeName("VK_ATTACHMENT_STORE_OP_NONE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    None = 1000301000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ATTACHMENT_STORE_OP_NONE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    Nonekhr = None,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_ATTACHMENT_STORE_OP_NONE_QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_store_ops"])]
    Noneqcom = None,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ATTACHMENT_STORE_OP_NONE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_load_store_op_none"])]
    Noneext = None,
}
