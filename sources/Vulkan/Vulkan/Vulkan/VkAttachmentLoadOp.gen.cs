// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkAttachmentLoadOp
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_ATTACHMENT_LOAD_OP_LOAD = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_ATTACHMENT_LOAD_OP_CLEAR = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_ATTACHMENT_LOAD_OP_DONT_CARE = 2,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_ATTACHMENT_LOAD_OP_NONE = 1000400000,

    [SupportedApiProfile("vulkan", ["VK_EXT_load_store_op_none"])]
    VK_ATTACHMENT_LOAD_OP_NONE_EXT = VK_ATTACHMENT_LOAD_OP_NONE,

    [SupportedApiProfile("vulkan", ["VK_KHR_load_store_op_none"])]
    VK_ATTACHMENT_LOAD_OP_NONE_KHR = VK_ATTACHMENT_LOAD_OP_NONE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_ATTACHMENT_LOAD_OP_MAX_ENUM = 0x7FFFFFFF,
}
