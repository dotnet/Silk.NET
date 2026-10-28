// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFragmentShadingRateCombinerOpKHR")]
public enum FragmentShadingRateCombinerOpKHR : uint
{
    [NativeName("VK_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_KHR")]
    Keep = 0,

    [NativeName("VK_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_KHR")]
    Replace = 1,

    [NativeName("VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_KHR")]
    Min = 2,

    [NativeName("VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_KHR")]
    Max = 3,

    [NativeName("VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_KHR")]
    Mul = 4,
}
