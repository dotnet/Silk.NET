// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "ARM", 0)]
[NativeName("VkPhysicalDeviceSchedulingControlsFlagsARM")]
[Flags]
public enum PhysicalDeviceSchedulingControlsFlagsARM : ulong
{
    None = 0x0,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_SHADER_CORE_COUNT_ARM")]
    ShaderCoreCountarm = 0x1,
}
