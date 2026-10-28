// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDisplayPowerStateEXT")]
public enum DisplayPowerStateEXT : uint
{
    [NativeName("VK_DISPLAY_POWER_STATE_OFF_EXT")]
    Off = 0,

    [NativeName("VK_DISPLAY_POWER_STATE_SUSPEND_EXT")]
    Suspend = 1,

    [NativeName("VK_DISPLAY_POWER_STATE_ON_EXT")]
    On = 2,
}
