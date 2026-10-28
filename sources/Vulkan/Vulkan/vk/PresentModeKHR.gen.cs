// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentModeKHR")]
public enum PresentModeKHR : uint
{
    [NativeName("VK_PRESENT_MODE_IMMEDIATE_KHR")]
    Immediate = 0,

    [NativeName("VK_PRESENT_MODE_MAILBOX_KHR")]
    Mailbox = 1,

    [NativeName("VK_PRESENT_MODE_FIFO_KHR")]
    Fifo = 2,

    [NativeName("VK_PRESENT_MODE_FIFO_RELAXED_KHR")]
    FifoRelaxed = 3,

    [NativeName("VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR")]
    SharedDemandRefresh = 1000111000,

    [NativeName("VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR")]
    SharedContinuousRefresh = 1000111001,

    [NativeName("VK_PRESENT_MODE_FIFO_LATEST_READY_KHR")]
    FifoLatestReady = 1000361000,

    [NativeName("VK_PRESENT_MODE_FIFO_LATEST_READY_EXT")]
    FifoLatestReadyEXT = FifoLatestReady,
}
