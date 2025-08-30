// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPresentModeKHR")]
    public enum PresentModeKHR : int
    {
        [Obsolete("Deprecated in favour of \"ImmediateKhr\"")]
        [NativeName("Name", "VK_PRESENT_MODE_IMMEDIATE_KHR")]
        PresentModeImmediateKhr = 0,
        [Obsolete("Deprecated in favour of \"MailboxKhr\"")]
        [NativeName("Name", "VK_PRESENT_MODE_MAILBOX_KHR")]
        PresentModeMailboxKhr = 1,
        [Obsolete("Deprecated in favour of \"FifoKhr\"")]
        [NativeName("Name", "VK_PRESENT_MODE_FIFO_KHR")]
        PresentModeFifoKhr = 2,
        [Obsolete("Deprecated in favour of \"FifoRelaxedKhr\"")]
        [NativeName("Name", "VK_PRESENT_MODE_FIFO_RELAXED_KHR")]
        PresentModeFifoRelaxedKhr = 3,
        [Obsolete("Deprecated in favour of \"SharedDemandRefreshKhr\"")]
        [NativeName("Name", "VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR")]
        PresentModeSharedDemandRefreshKhr = 1000111000,
        [Obsolete("Deprecated in favour of \"SharedContinuousRefreshKhr\"")]
        [NativeName("Name", "VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR")]
        PresentModeSharedContinuousRefreshKhr = 1000111001,
        [Obsolete("Deprecated in favour of \"FifoLatestReadyExt\"")]
        [NativeName("Name", "VK_PRESENT_MODE_FIFO_LATEST_READY_EXT")]
        PresentModeFifoLatestReadyExt = 1000361000,
        [NativeName("Name", "VK_PRESENT_MODE_IMMEDIATE_KHR")]
        ImmediateKhr = 0,
        [NativeName("Name", "VK_PRESENT_MODE_MAILBOX_KHR")]
        MailboxKhr = 1,
        [NativeName("Name", "VK_PRESENT_MODE_FIFO_KHR")]
        FifoKhr = 2,
        [NativeName("Name", "VK_PRESENT_MODE_FIFO_RELAXED_KHR")]
        FifoRelaxedKhr = 3,
        [NativeName("Name", "VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR")]
        SharedDemandRefreshKhr = 1000111000,
        [NativeName("Name", "VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR")]
        SharedContinuousRefreshKhr = 1000111001,
        [NativeName("Name", "VK_PRESENT_MODE_FIFO_LATEST_READY_EXT")]
        FifoLatestReadyExt = 1000361000,
    }
}
