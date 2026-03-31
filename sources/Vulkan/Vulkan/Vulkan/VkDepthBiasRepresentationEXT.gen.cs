// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkDepthBiasRepresentationEXT")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDepthBiasRepresentationEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORMAT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    VkDepthBiasRepresentationLeastRepresentableValueFormat = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORCE_UNORM_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    VkDepthBiasRepresentationLeastRepresentableValueForceUnorm = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEPTH_BIAS_REPRESENTATION_FLOAT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    VkDepthBiasRepresentationFloat = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEPTH_BIAS_REPRESENTATION_MAX_ENUM_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    VkDepthBiasRepresentationMaxEnum = 0x7FFFFFFF,
}
