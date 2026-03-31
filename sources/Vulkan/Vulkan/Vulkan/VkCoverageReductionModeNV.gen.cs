// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkCoverageReductionModeNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkCoverageReductionModeNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_COVERAGE_REDUCTION_MODE_MERGE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    VkCoverageReductionModeMerge = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    VkCoverageReductionModeTruncate = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_COVERAGE_REDUCTION_MODE_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    VkCoverageReductionModeMaxEnum = 0x7FFFFFFF,
}
