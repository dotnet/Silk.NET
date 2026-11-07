// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkEventCreateFlags")]
[Flags]
public enum EventCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_EVENT_CREATE_DEVICE_ONLY_BIT")]
    DeviceOnlyBit = 0x1,

    [NativeName("VK_EVENT_CREATE_DEVICE_ONLY_BIT_KHR")]
    DeviceOnlyBitKHR = DeviceOnlyBit,
}
