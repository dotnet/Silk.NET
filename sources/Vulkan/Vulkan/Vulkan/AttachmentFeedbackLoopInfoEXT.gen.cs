// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct AttachmentFeedbackLoopInfoEXT
{
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_unified_image_layouts+VK_EXT_attachment_feedback_loop_layout+VK_KHR_dynamic_rendering",
            "VK_KHR_unified_image_layouts+VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_unified_image_layouts+VK_EXT_attachment_feedback_loop_layout+VK_KHR_dynamic_rendering",
            "VK_KHR_unified_image_layouts+VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_unified_image_layouts+VK_EXT_attachment_feedback_loop_layout+VK_KHR_dynamic_rendering",
            "VK_KHR_unified_image_layouts+VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    public uint FeedbackLoopEnable;
}
