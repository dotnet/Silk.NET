// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageTiling")]
public enum ImageTiling : uint
{
    [NativeName("VK_IMAGE_TILING_OPTIMAL")]
    Optimal = 0,

    [NativeName("VK_IMAGE_TILING_LINEAR")]
    Linear = 1,

    [NativeName("VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT")]
    DrmFormatModifierEXT = 1000158000,
}
