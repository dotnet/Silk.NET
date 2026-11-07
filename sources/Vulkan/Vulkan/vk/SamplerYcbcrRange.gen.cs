// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSamplerYcbcrRange")]
public enum SamplerYcbcrRange : uint
{
    [NativeName("VK_SAMPLER_YCBCR_RANGE_ITU_FULL")]
    ItuFull = 0,

    [NativeName("VK_SAMPLER_YCBCR_RANGE_ITU_NARROW")]
    ItuNarrow = 1,

    [NativeName("VK_SAMPLER_YCBCR_RANGE_ITU_FULL_KHR")]
    ItuFullKHR = ItuFull,

    [NativeName("VK_SAMPLER_YCBCR_RANGE_ITU_NARROW_KHR")]
    ItuNarrowKHR = ItuNarrow,
}
