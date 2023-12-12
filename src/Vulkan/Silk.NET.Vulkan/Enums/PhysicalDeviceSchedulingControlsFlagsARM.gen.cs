// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPhysicalDeviceSchedulingControlsFlagsARM")]
    public enum PhysicalDeviceSchedulingControlsFlagsARM : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ShaderCoreCountArm\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_SHADER_CORE_COUNT_ARM")]
        PhysicalDeviceSchedulingControlsShaderCoreCountArm = 1,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_SHADER_CORE_COUNT_ARM")]
        ShaderCoreCountArm = 1,
    }
}
