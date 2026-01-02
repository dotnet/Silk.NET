// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[InlineArray(2)]
[SupportedApiProfile(
    "vulkan",
    [
        "VK_BASE_VERSION_1_0",
        "VK_BASE_VERSION_1_1",
        "VK_BASE_VERSION_1_2",
        "VK_BASE_VERSION_1_3",
        "VK_BASE_VERSION_1_4",
        "VK_COMPUTE_VERSION_1_0",
        "VK_COMPUTE_VERSION_1_1",
        "VK_COMPUTE_VERSION_1_2",
        "VK_COMPUTE_VERSION_1_3",
        "VK_COMPUTE_VERSION_1_4",
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
public partial struct PhysicalDeviceLimitsLineWidthRange
{
    [SupportedApiProfile("vulkan")]
    public float E0;
}
