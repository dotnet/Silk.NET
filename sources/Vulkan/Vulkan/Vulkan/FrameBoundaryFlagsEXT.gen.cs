// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFrameBoundaryFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum FrameBoundaryFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_FRAME_BOUNDARY_FRAME_END_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    FrameEndBitEXT = 0x1,
}
