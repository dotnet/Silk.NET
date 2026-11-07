// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureCompatibilityKHR")]
public enum AccelerationStructureCompatibilityKHR : uint
{
    [NativeName("VK_ACCELERATION_STRUCTURE_COMPATIBILITY_COMPATIBLE_KHR")]
    Compatible = 0,

    [NativeName("VK_ACCELERATION_STRUCTURE_COMPATIBILITY_INCOMPATIBLE_KHR")]
    Incompatible = 1,
}
