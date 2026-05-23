// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkConformanceVersion")]
[SupportedApiProfile("vulkan")]
public partial struct ConformanceVersion
{
    [NativeName("major")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    public byte Major;

    [NativeName("minor")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    public byte Minor;

    [NativeName("subminor")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    public byte Subminor;

    [NativeName("patch")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    public byte Patch;
}
