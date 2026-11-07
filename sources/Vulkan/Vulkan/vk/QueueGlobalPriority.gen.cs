// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueueGlobalPriority")]
public enum QueueGlobalPriority : uint
{
    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_LOW")]
    Low = 128,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_MEDIUM")]
    Medium = 256,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_HIGH")]
    High = 512,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_REALTIME")]
    Realtime = 1024,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT")]
    LowEXT = Low,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT")]
    MediumEXT = Medium,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT")]
    HighEXT = High,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT")]
    RealtimeEXT = Realtime,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR")]
    LowKHR = Low,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR")]
    MediumKHR = Medium,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR")]
    HighKHR = High,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR")]
    RealtimeKHR = Realtime,
}
