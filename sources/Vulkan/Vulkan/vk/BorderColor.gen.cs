// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBorderColor")]
public enum BorderColor : uint
{
    [NativeName("VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK")]
    FloatTransparentBlack = 0,

    [NativeName("VK_BORDER_COLOR_INT_TRANSPARENT_BLACK")]
    IntTransparentBlack = 1,

    [NativeName("VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK")]
    FloatOpaqueBlack = 2,

    [NativeName("VK_BORDER_COLOR_INT_OPAQUE_BLACK")]
    IntOpaqueBlack = 3,

    [NativeName("VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE")]
    FloatOpaqueWhite = 4,

    [NativeName("VK_BORDER_COLOR_INT_OPAQUE_WHITE")]
    IntOpaqueWhite = 5,

    [NativeName("VK_BORDER_COLOR_FLOAT_CUSTOM_EXT")]
    FloatCustomEXT = 1000287003,

    [NativeName("VK_BORDER_COLOR_INT_CUSTOM_EXT")]
    IntCustomEXT = 1000287004,
}
