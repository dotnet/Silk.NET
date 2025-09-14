// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineRobustnessImageBehavior")]
    public enum PipelineRobustnessImageBehavior : int
    {
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT")]
        DeviceDefault = 0,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED")]
        Disabled = 1,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS")]
        RobustImageAccess = 2,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2")]
        RobustImageAccess2 = 3,
    }
}
