// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_driverUUID_e__FixedBuffer")]
[InlineArray(16)]
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
public partial struct PhysicalDeviceVulkan11PropertiesDriverUUID
{
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public byte E0;
}
