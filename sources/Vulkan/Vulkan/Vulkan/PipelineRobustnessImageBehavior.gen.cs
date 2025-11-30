// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineRobustnessImageBehavior")]
[SupportedApiProfile("vulkan")]
public enum PipelineRobustnessImageBehavior : uint
{
    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    DeviceDefault = 0,

    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    Disabled = 1,

    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    RobustImageAccess = 2,

    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    RobustImageAccess2 = 3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    DeviceDefaultext = DeviceDefault,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    Disabledext = Disabled,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    RobustImageAccessext = RobustImageAccess,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    RobustImageAccess2Ext = RobustImageAccess2,
}
