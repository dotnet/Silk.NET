// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("NV", 0)]
[NativeName("VkCoverageModulationModeNV")]
[SupportedApiProfile("vulkan")]
public enum CoverageModulationModeNV : uint
{
    [NameSuffix("NV", 0)]
    [NativeName("VK_COVERAGE_MODULATION_MODE_NONE_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    NoneNV = 0,

    [NameSuffix("NV", 0)]
    [NativeName("VK_COVERAGE_MODULATION_MODE_RGB_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    RgbNV = 1,

    [NameSuffix("NV", 0)]
    [NativeName("VK_COVERAGE_MODULATION_MODE_ALPHA_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    AlphaNV = 2,

    [NameSuffix("NV", 0)]
    [NativeName("VK_COVERAGE_MODULATION_MODE_RGBA_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    RgbaNV = 3,
}
