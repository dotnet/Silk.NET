// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkQueueGlobalPriority")]
    public enum QueueGlobalPriority : int
    {
        [NativeName("Name", "")]
        None = 0,
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
