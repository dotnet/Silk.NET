// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPresentModeKHR")]
    public enum PresentModeKHR
    {
        [NativeName("Name", "VK_PRESENT_MODE_IMMEDIATE_KHR")]
        PresentModeImmediateKhr = 0,
        [NativeName("Name", "VK_PRESENT_MODE_MAILBOX_KHR")]
        PresentModeMailboxKhr = 1,
        [NativeName("Name", "VK_PRESENT_MODE_FIFO_KHR")]
        PresentModeFifoKhr = 2,
        [NativeName("Name", "VK_PRESENT_MODE_FIFO_RELAXED_KHR")]
        PresentModeFifoRelaxedKhr = 3,
        [NativeName("Name", "VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR")]
        PresentModeSharedDemandRefreshKhr = 1000111000,
        [NativeName("Name", "VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR")]
        PresentModeSharedContinuousRefreshKhr = 1000111001,
    }
}
