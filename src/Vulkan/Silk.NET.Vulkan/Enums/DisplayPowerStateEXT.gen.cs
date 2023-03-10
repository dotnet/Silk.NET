// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDisplayPowerStateEXT")]
    public enum DisplayPowerStateEXT : int
    {
        [Obsolete("Deprecated in favour of \"OffExt\"")]
        [NativeName("Name", "VK_DISPLAY_POWER_STATE_OFF_EXT")]
        DisplayPowerStateOffExt = 0,
        [Obsolete("Deprecated in favour of \"SuspendExt\"")]
        [NativeName("Name", "VK_DISPLAY_POWER_STATE_SUSPEND_EXT")]
        DisplayPowerStateSuspendExt = 1,
        [Obsolete("Deprecated in favour of \"OnExt\"")]
        [NativeName("Name", "VK_DISPLAY_POWER_STATE_ON_EXT")]
        DisplayPowerStateOnExt = 2,
        [NativeName("Name", "VK_DISPLAY_POWER_STATE_OFF_EXT")]
        OffExt = 0,
        [NativeName("Name", "VK_DISPLAY_POWER_STATE_SUSPEND_EXT")]
        SuspendExt = 1,
        [NativeName("Name", "VK_DISPLAY_POWER_STATE_ON_EXT")]
        OnExt = 2,
    }
}
