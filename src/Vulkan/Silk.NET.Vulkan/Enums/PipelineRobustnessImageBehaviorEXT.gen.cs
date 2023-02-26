// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineRobustnessImageBehaviorEXT")]
    public enum PipelineRobustnessImageBehaviorEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DeviceDefaultExt\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT_EXT")]
        PipelineRobustnessImageBehaviorDeviceDefaultExt = 0,
        [Obsolete("Deprecated in favour of \"DisabledExt\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED_EXT")]
        PipelineRobustnessImageBehaviorDisabledExt = 1,
        [Obsolete("Deprecated in favour of \"RobustImageAccessExt\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_EXT")]
        PipelineRobustnessImageBehaviorRobustImageAccessExt = 2,
        [Obsolete("Deprecated in favour of \"RobustImageAccess2Ext\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2_EXT")]
        PipelineRobustnessImageBehaviorRobustImageAccess2Ext = 3,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT_EXT")]
        DeviceDefaultExt = 0,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED_EXT")]
        DisabledExt = 1,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_EXT")]
        RobustImageAccessExt = 2,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2_EXT")]
        RobustImageAccess2Ext = 3,
    }
}
