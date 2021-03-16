// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkQueueGlobalPriorityEXT")]
    public enum QueueGlobalPriorityEXT : int
    {
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT")]
        QueueGlobalPriorityLowExt = 128,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT")]
        QueueGlobalPriorityMediumExt = 256,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT")]
        QueueGlobalPriorityHighExt = 512,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT")]
        QueueGlobalPriorityRealtimeExt = 1024,
    }
}
