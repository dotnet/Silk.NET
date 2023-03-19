// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSwapchainCreateFlagsKHR")]
    public enum SwapchainCreateFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SplitInstanceBindRegionsBitKhr\"")]
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
        SwapchainCreateSplitInstanceBindRegionsBitKhr = 1,
        [Obsolete("Deprecated in favour of \"ProtectedBitKhr\"")]
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR")]
        SwapchainCreateProtectedBitKhr = 2,
        [Obsolete("Deprecated in favour of \"MutableFormatBitKhr\"")]
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR")]
        SwapchainCreateMutableFormatBitKhr = 4,
        [Obsolete("Deprecated in favour of \"DeferredMemoryAllocationBitExt\"")]
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT")]
        SwapchainCreateDeferredMemoryAllocationBitExt = 8,
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
        SplitInstanceBindRegionsBitKhr = 1,
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR")]
        ProtectedBitKhr = 2,
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR")]
        MutableFormatBitKhr = 4,
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT")]
        DeferredMemoryAllocationBitExt = 8,
    }
}
