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
    [NativeName("Name", "VkSemaphoreWaitFlags")]
    public enum SemaphoreWaitFlags
    {
        [NativeName("Name", "VK_SEMAPHORE_WAIT_ANY_BIT")]
        SemaphoreWaitAnyBit = 1,
    }
}
