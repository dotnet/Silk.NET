// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPointClippingBehavior")]
[SupportedApiProfile("vulkan")]
public enum PointClippingBehavior : uint
{
    [NativeName("VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    AllClipPlanes = 0,

    [NativeName("VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    UserClipPlanesOnly = 1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    AllClipPlanesKHR = AllClipPlanes,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    UserClipPlanesOnlyKHR = UserClipPlanesOnly,
}
