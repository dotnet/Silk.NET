// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineRobustnessImageBehavior")]
public enum PipelineRobustnessImageBehavior : uint
{
    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT")]
    DeviceDefault = 0,

    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED")]
    Disabled = 1,

    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS")]
    RobustImageAccess = 2,

    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2")]
    RobustImageAccess2 = 3,

    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT_EXT")]
    DeviceDefaultEXT = DeviceDefault,

    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED_EXT")]
    DisabledEXT = Disabled,

    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_EXT")]
    RobustImageAccessEXT = RobustImageAccess,

    [NativeName("VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2_EXT")]
    RobustImageAccess2EXT = RobustImageAccess2,
}
