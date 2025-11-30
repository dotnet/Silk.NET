// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkCoverageModulationModeNV")]
[SupportedApiProfile("vulkan")]
public enum CoverageModulationModeNV : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COVERAGE_MODULATION_MODE_NONE_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    Nonenv = 0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COVERAGE_MODULATION_MODE_RGB_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    Rgbnv = 1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COVERAGE_MODULATION_MODE_ALPHA_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    Alphanv = 2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COVERAGE_MODULATION_MODE_RGBA_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    Rgbanv = 3,
}
