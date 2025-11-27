// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkConditionalRenderingFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum ConditionalRenderingFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    InvertedBitEXT = 0x1,
}
