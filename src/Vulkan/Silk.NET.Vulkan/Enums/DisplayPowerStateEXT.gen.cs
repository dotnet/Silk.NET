// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDisplayPowerStateEXT")]
    public enum DisplayPowerStateEXT : int
    {
        [NativeName("Name", "VK_DISPLAY_POWER_STATE_OFF_EXT")]
        DisplayPowerStateOffExt = 0,
        [NativeName("Name", "VK_DISPLAY_POWER_STATE_SUSPEND_EXT")]
        DisplayPowerStateSuspendExt = 1,
        [NativeName("Name", "VK_DISPLAY_POWER_STATE_ON_EXT")]
        DisplayPowerStateOnExt = 2,
    }
}
