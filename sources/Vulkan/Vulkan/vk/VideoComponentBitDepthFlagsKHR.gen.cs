// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoComponentBitDepthFlagsKHR")]
[Flags]
public enum VideoComponentBitDepthFlagsKHR : uint
{
    [NativeName("VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR")]
    DepthInvalid = 0x0,

    [NativeName("VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR")]
    Depth8Bit = 0x1,

    [NativeName("VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR")]
    Depth10Bit = 0x4,

    [NativeName("VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR")]
    Depth12Bit = 0x10,
}
