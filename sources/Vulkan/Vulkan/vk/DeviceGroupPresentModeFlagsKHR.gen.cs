// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceGroupPresentModeFlagsKHR")]
[Flags]
public enum DeviceGroupPresentModeFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR")]
    LocalBit = 0x1,

    [NativeName("VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR")]
    RemoteBit = 0x2,

    [NativeName("VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR")]
    SumBit = 0x4,

    [NativeName("VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR")]
    LocalMultiDeviceBit = 0x8,
}
