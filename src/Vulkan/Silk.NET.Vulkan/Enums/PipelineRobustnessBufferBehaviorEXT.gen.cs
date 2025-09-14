// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineRobustnessBufferBehaviorEXT")]
    public enum PipelineRobustnessBufferBehaviorEXT : int
    {
        [Obsolete("Deprecated in favour of \"DeviceDefault\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT")]
        PipelineRobustnessBufferBehaviorDeviceDefault = 0,
        [Obsolete("Deprecated in favour of \"Disabled\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED")]
        PipelineRobustnessBufferBehaviorDisabled = 1,
        [Obsolete("Deprecated in favour of \"RobustBufferAccess\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS")]
        PipelineRobustnessBufferBehaviorRobustBufferAccess = 2,
        [Obsolete("Deprecated in favour of \"RobustBufferAccess2\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2")]
        PipelineRobustnessBufferBehaviorRobustBufferAccess2 = 3,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT")]
        DeviceDefault = 0,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED")]
        Disabled = 1,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS")]
        RobustBufferAccess = 2,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2")]
        RobustBufferAccess2 = 3,
    }
}
