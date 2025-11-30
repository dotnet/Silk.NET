// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAttachmentLoadOp")]
[SupportedApiProfile("vulkan")]
public enum AttachmentLoadOp : uint
{
    [NativeName("VK_ATTACHMENT_LOAD_OP_LOAD")]
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
    Load = 0,

    [NativeName("VK_ATTACHMENT_LOAD_OP_CLEAR")]
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
    Clear = 1,

    [NativeName("VK_ATTACHMENT_LOAD_OP_DONT_CARE")]
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
    DontCare = 2,

    [NativeName("VK_ATTACHMENT_LOAD_OP_NONE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    None = 1000400000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ATTACHMENT_LOAD_OP_NONE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_load_store_op_none"])]
    NoneEXT = None,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ATTACHMENT_LOAD_OP_NONE_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_load_store_op_none"])]
    NoneKHR = None,
}
