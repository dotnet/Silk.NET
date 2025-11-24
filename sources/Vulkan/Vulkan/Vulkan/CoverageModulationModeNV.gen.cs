// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum CoverageModulationModeNV : uint
{
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    NoneNV = 0,

    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    RgbNV = 1,

    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    AlphaNV = 2,

    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    RgbaNV = 3,
}
