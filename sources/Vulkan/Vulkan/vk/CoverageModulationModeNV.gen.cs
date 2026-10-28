// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCoverageModulationModeNV")]
public enum CoverageModulationModeNV : uint
{
    [NativeName("VK_COVERAGE_MODULATION_MODE_NONE_NV")]
    None = 0,

    [NativeName("VK_COVERAGE_MODULATION_MODE_RGB_NV")]
    Rgb = 1,

    [NativeName("VK_COVERAGE_MODULATION_MODE_ALPHA_NV")]
    Alpha = 2,

    [NativeName("VK_COVERAGE_MODULATION_MODE_RGBA_NV")]
    Rgba = 3,
}
