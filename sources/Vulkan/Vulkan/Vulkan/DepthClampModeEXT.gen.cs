// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDepthClampModeEXT")]
[SupportedApiProfile("vulkan")]
public enum DepthClampModeEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEPTH_CLAMP_MODE_VIEWPORT_RANGE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    ViewportRangeEXT = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEPTH_CLAMP_MODE_USER_DEFINED_RANGE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    UserDefinedRangeEXT = 1,
}
