// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSwapchainCreateFlagsKHR")]
[Flags]
public enum SwapchainCreateFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
    SplitInstanceBindRegionsBit = 0x1,

    [NativeName("VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR")]
    ProtectedBit = 0x2,

    [NativeName("VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR")]
    MutableFormatBit = 0x4,

    [NativeName("VK_SWAPCHAIN_CREATE_PRESENT_TIMING_BIT_EXT")]
    PresentTimingBitEXT = 0x200,

    [NativeName("VK_SWAPCHAIN_CREATE_PRESENT_ID_2_BIT_KHR")]
    PresentId2Bit = 0x40,

    [NativeName("VK_SWAPCHAIN_CREATE_PRESENT_WAIT_2_BIT_KHR")]
    PresentWait2Bit = 0x80,

    [NativeName("VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_KHR")]
    DeferredMemoryAllocationBit = 0x8,

    [NativeName("VK_SWAPCHAIN_CREATE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXT")]
    MultisampledRenderToSingleSampledBitEXT = 0x100,

    [NativeName("VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT")]
    DeferredMemoryAllocationBitEXT = DeferredMemoryAllocationBit,
}
