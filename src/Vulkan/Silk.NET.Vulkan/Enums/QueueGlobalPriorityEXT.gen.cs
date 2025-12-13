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
        [Obsolete("Deprecated in favour of \"Low\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_LOW")]
        QueueGlobalPriorityLow = 128,
        [Obsolete("Deprecated in favour of \"Medium\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_MEDIUM")]
        QueueGlobalPriorityMedium = 256,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_HIGH")]
        QueueGlobalPriorityHigh = 512,
        [Obsolete("Deprecated in favour of \"Realtime\"")]
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_REALTIME")]
        QueueGlobalPriorityRealtime = 1024,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_LOW")]
        Low = 128,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_MEDIUM")]
        Medium = 256,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_HIGH")]
        High = 512,
        [NativeName("Name", "VK_QUEUE_GLOBAL_PRIORITY_REALTIME")]
        Realtime = 1024,
    }
}
