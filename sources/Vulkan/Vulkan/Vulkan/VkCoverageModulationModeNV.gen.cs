// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkCoverageModulationModeNV : uint
{
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    VK_COVERAGE_MODULATION_MODE_NONE_NV = 0,

    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    VK_COVERAGE_MODULATION_MODE_RGB_NV = 1,

    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    VK_COVERAGE_MODULATION_MODE_ALPHA_NV = 2,

    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    VK_COVERAGE_MODULATION_MODE_RGBA_NV = 3,

    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    VK_COVERAGE_MODULATION_MODE_MAX_ENUM_NV = 0x7FFFFFFF,
}
