// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkRenderingAttachmentFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum RenderingAttachmentFlagsKHR : uint
{
    None = 0x0,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_RENDERING_ATTACHMENT_INPUT_ATTACHMENT_FEEDBACK_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_maintenance10+VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_maintenance10+VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
            "VK_KHR_maintenance10+VK_VERSION_1_4+VK_KHR_dynamic_rendering",
            "VK_KHR_maintenance10+VK_VERSION_1_4+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    InputAttachmentFeedbackBitKHR = 0x1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_RENDERING_ATTACHMENT_RESOLVE_SKIP_TRANSFER_FUNCTION_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10+VK_KHR_dynamic_rendering", "VK_KHR_maintenance10+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    ResolveSkipTransferFunctionBitKHR = 0x2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_RENDERING_ATTACHMENT_RESOLVE_ENABLE_TRANSFER_FUNCTION_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10+VK_KHR_dynamic_rendering", "VK_KHR_maintenance10+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    ResolveEnableTransferFunctionBitKHR = 0x4,
}
