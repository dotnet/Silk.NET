// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFilter")]
public enum Filter : uint
{
    [NativeName("VK_FILTER_NEAREST")]
    Nearest = 0,

    [NativeName("VK_FILTER_LINEAR")]
    Linear = 1,

    [NativeName("VK_FILTER_CUBIC_EXT")]
    CubicEXT = 1000015000,

    [NativeName("VK_FILTER_CUBIC_IMG")]
    CubicIMG = CubicEXT,
}
