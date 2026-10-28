// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureTypeKHR")]
public enum AccelerationStructureTypeKHR : uint
{
    [NativeName("VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR")]
    TopLevel = 0,

    [NativeName("VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR")]
    BottomLevel = 1,

    [NativeName("VK_ACCELERATION_STRUCTURE_TYPE_GENERIC_KHR")]
    Generic = 2,

    [NativeName("VK_ACCELERATION_STRUCTURE_TYPE_OPACITY_MICROMAP_KHR")]
    OpacityMicromap = 1000623000,

    [NativeName("VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV")]
    TopLevelNV = TopLevel,

    [NativeName("VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV")]
    BottomLevelNV = BottomLevel,
}
