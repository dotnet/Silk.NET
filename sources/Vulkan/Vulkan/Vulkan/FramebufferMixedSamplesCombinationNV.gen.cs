// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct FramebufferMixedSamplesCombinationNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    public CoverageReductionModeNV CoverageReductionMode;

    [NativeTypeName("VkSampleCountFlagBits")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    public SampleCountFlags RasterizationSamples;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    public uint DepthStencilSamples;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    public uint ColorSamples;
}
