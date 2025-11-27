// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTessellationDomainOrigin")]
[SupportedApiProfile("vulkan")]
public enum TessellationDomainOrigin : uint
{
    [NativeName("VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT")]
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
    UpperLeft = 0,

    [NativeName("VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT")]
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
    LowerLeft = 1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    UpperLeftKHR = UpperLeft,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    LowerLeftKHR = LowerLeft,
}
