// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAntiLagModeAMD")]
public enum AntiLagModeAMD : uint
{
    [NativeName("VK_ANTI_LAG_MODE_DRIVER_CONTROL_AMD")]
    DriverControl = 0,

    [NativeName("VK_ANTI_LAG_MODE_ON_AMD")]
    On = 1,

    [NativeName("VK_ANTI_LAG_MODE_OFF_AMD")]
    Off = 2,
}
