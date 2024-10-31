// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAntiLagModeAMD")]
    public enum AntiLagModeAMD : int
    {
        [Obsolete("Deprecated in favour of \"DriverControlAmd\"")]
        [NativeName("Name", "VK_ANTI_LAG_MODE_DRIVER_CONTROL_AMD")]
        AntiLagModeDriverControlAmd = 0,
        [Obsolete("Deprecated in favour of \"OnAmd\"")]
        [NativeName("Name", "VK_ANTI_LAG_MODE_ON_AMD")]
        AntiLagModeOnAmd = 1,
        [Obsolete("Deprecated in favour of \"OffAmd\"")]
        [NativeName("Name", "VK_ANTI_LAG_MODE_OFF_AMD")]
        AntiLagModeOffAmd = 2,
        [NativeName("Name", "VK_ANTI_LAG_MODE_DRIVER_CONTROL_AMD")]
        DriverControlAmd = 0,
        [NativeName("Name", "VK_ANTI_LAG_MODE_ON_AMD")]
        OnAmd = 1,
        [NativeName("Name", "VK_ANTI_LAG_MODE_OFF_AMD")]
        OffAmd = 2,
    }
}
