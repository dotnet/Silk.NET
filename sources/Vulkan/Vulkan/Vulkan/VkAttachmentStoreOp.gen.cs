// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkAttachmentStoreOp
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_ATTACHMENT_STORE_OP_STORE = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_ATTACHMENT_STORE_OP_DONT_CARE = 1,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_ATTACHMENT_STORE_OP_NONE = 1000301000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_ATTACHMENT_STORE_OP_NONE_KHR = VK_ATTACHMENT_STORE_OP_NONE,

    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_store_ops"])]
    VK_ATTACHMENT_STORE_OP_NONE_QCOM = VK_ATTACHMENT_STORE_OP_NONE,

    [SupportedApiProfile("vulkan", ["VK_EXT_load_store_op_none"])]
    VK_ATTACHMENT_STORE_OP_NONE_EXT = VK_ATTACHMENT_STORE_OP_NONE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_ATTACHMENT_STORE_OP_MAX_ENUM = 0x7FFFFFFF,
}
