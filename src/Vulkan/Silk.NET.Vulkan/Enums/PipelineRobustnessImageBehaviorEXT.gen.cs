// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineRobustnessImageBehaviorEXT")]
    public enum PipelineRobustnessImageBehaviorEXT : int
    {
        [Obsolete("Deprecated in favour of \"DeviceDefault\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT")]
        PipelineRobustnessImageBehaviorDeviceDefault = 0,
        [Obsolete("Deprecated in favour of \"Disabled\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED")]
        PipelineRobustnessImageBehaviorDisabled = 1,
        [Obsolete("Deprecated in favour of \"RobustImageAccess\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS")]
        PipelineRobustnessImageBehaviorRobustImageAccess = 2,
        [Obsolete("Deprecated in favour of \"RobustImageAccess2\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2")]
        PipelineRobustnessImageBehaviorRobustImageAccess2 = 3,
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
