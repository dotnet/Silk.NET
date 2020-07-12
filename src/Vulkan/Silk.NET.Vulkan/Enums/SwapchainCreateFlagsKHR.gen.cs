// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkSwapchainCreateFlagsKHR")]
    public enum SwapchainCreateFlagsKHR
    {
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
        SwapchainCreateSplitInstanceBindRegionsBitKhr = 1,
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR")]
        SwapchainCreateProtectedBitKhr = 2,
        [NativeName("Name", "VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR")]
        SwapchainCreateMutableFormatBitKhr = 4,
    }
}
