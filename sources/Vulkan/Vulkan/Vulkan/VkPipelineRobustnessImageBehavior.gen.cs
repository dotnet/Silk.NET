// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkPipelineRobustnessImageBehavior
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT = 0,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED = 1,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS = 2,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2 = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT_EXT =
        VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED_EXT =
        VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_EXT =
        VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2_EXT =
        VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_MAX_ENUM = 0x7FFFFFFF,
}
