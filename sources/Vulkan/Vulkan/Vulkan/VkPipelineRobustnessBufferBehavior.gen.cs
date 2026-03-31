// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineRobustnessBufferBehavior")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkPipelineRobustnessBufferBehavior : uint
{
    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkPipelineRobustnessBufferBehaviorDeviceDefault = 0,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkPipelineRobustnessBufferBehaviorDisabled = 1,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkPipelineRobustnessBufferBehaviorRobustBufferAccess = 2,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkPipelineRobustnessBufferBehaviorRobustBufferAccess2 = 3,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VkPipelineRobustnessBufferBehaviorDeviceDefaultEXT =
        VkPipelineRobustnessBufferBehaviorDeviceDefault,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VkPipelineRobustnessBufferBehaviorDisabledEXT = VkPipelineRobustnessBufferBehaviorDisabled,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VkPipelineRobustnessBufferBehaviorRobustBufferAccessEXT =
        VkPipelineRobustnessBufferBehaviorRobustBufferAccess,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VkPipelineRobustnessBufferBehaviorRobustBufferAccess2EXT =
        VkPipelineRobustnessBufferBehaviorRobustBufferAccess2,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_MAX_ENUM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkPipelineRobustnessBufferBehaviorMaxEnum = 0x7FFFFFFF,
}
