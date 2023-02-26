// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineRobustnessBufferBehaviorEXT")]
    public enum PipelineRobustnessBufferBehaviorEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DeviceDefaultExt\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT_EXT")]
        PipelineRobustnessBufferBehaviorDeviceDefaultExt = 0,
        [Obsolete("Deprecated in favour of \"DisabledExt\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED_EXT")]
        PipelineRobustnessBufferBehaviorDisabledExt = 1,
        [Obsolete("Deprecated in favour of \"RobustBufferAccessExt\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_EXT")]
        PipelineRobustnessBufferBehaviorRobustBufferAccessExt = 2,
        [Obsolete("Deprecated in favour of \"RobustBufferAccess2Ext\"")]
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2_EXT")]
        PipelineRobustnessBufferBehaviorRobustBufferAccess2Ext = 3,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT_EXT")]
        DeviceDefaultExt = 0,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED_EXT")]
        DisabledExt = 1,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_EXT")]
        RobustBufferAccessExt = 2,
        [NativeName("Name", "VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2_EXT")]
        RobustBufferAccess2Ext = 3,
    }
}
