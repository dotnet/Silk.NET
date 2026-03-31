// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkSurfaceCounterFlagBitsEXT")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkSurfaceCounterFlagsEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_SURFACE_COUNTER_VBLANK_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VkSurfaceCounterVblankBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_SURFACE_COUNTER_FLAG_BITS_MAX_ENUM_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VkSurfaceCounterFlagBitsMaxEnum = 0x7FFFFFFF,
}
