// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureBuildTypeKHR")]
public enum AccelerationStructureBuildTypeKHR : uint
{
    [NativeName("VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR")]
    Host = 0,

    [NativeName("VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR")]
    Device = 1,

    [NativeName("VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR")]
    HostOrDevice = 2,
}
