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
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
        SwapchainCreateSplitInstanceBindRegionsBitKhr = 1,
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR")]
        SwapchainCreateProtectedBitKhr = 2,
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR")]
        SwapchainCreateMutableFormatBitKhr = 4,
    }
}
