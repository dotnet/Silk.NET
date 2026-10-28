// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineRobustnessBufferBehavior")]
public enum PipelineRobustnessBufferBehavior : uint
{
    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT")]
    DeviceDefault = 0,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED")]
    Disabled = 1,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS")]
    RobustBufferAccess = 2,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2")]
    RobustBufferAccess2 = 3,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT_EXT")]
    DeviceDefaultEXT = DeviceDefault,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED_EXT")]
    DisabledEXT = Disabled,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_EXT")]
    RobustBufferAccessEXT = RobustBufferAccess,

    [NativeName("VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2_EXT")]
    RobustBufferAccess2EXT = RobustBufferAccess2,
}
