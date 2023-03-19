// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkQueueGlobalPriorityEXT")]
    public enum QueueGlobalPriorityEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"LowKhr\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR")]
        QueueGlobalPriorityLowKhr = 128,
        [Obsolete("Deprecated in favour of \"MediumKhr\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR")]
        QueueGlobalPriorityMediumKhr = 256,
        [Obsolete("Deprecated in favour of \"HighKhr\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR")]
        QueueGlobalPriorityHighKhr = 512,
        [Obsolete("Deprecated in favour of \"RealtimeKhr\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR")]
        QueueGlobalPriorityRealtimeKhr = 1024,
        [Obsolete("Deprecated in favour of \"LowExt\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT")]
        QueueGlobalPriorityLowExt = 128,
        [Obsolete("Deprecated in favour of \"MediumExt\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT")]
        QueueGlobalPriorityMediumExt = 256,
        [Obsolete("Deprecated in favour of \"HighExt\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT")]
        QueueGlobalPriorityHighExt = 512,
        [Obsolete("Deprecated in favour of \"RealtimeExt\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT")]
        QueueGlobalPriorityRealtimeExt = 1024,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR")]
        LowKhr = 128,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR")]
        MediumKhr = 256,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR")]
        HighKhr = 512,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR")]
        RealtimeKhr = 1024,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT")]
        LowExt = 128,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT")]
        MediumExt = 256,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT")]
        HighExt = 512,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT")]
        RealtimeExt = 1024,
    }
}
