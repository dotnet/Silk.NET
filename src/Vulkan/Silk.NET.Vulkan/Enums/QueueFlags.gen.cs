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
    [NativeName("Name", "VkQueueFlags")]
    public enum QueueFlags
    {
        [NativeName("Name", "VK_QUEUE_GRAPHICS_BIT")]
        QueueGraphicsBit = 1,
        [NativeName("Name", "VK_QUEUE_COMPUTE_BIT")]
        QueueComputeBit = 2,
        [NativeName("Name", "VK_QUEUE_TRANSFER_BIT")]
        QueueTransferBit = 4,
        [NativeName("Name", "VK_QUEUE_SPARSE_BINDING_BIT")]
        QueueSparseBindingBit = 8,
        [NativeName("Name", "VK_QUEUE_RESERVED_6_BIT_KHR")]
        QueueReserved6BitKhr = 64,
        [NativeName("Name", "VK_QUEUE_RESERVED_5_BIT_KHR")]
        QueueReserved5BitKhr = 32,
        [NativeName("Name", "VK_QUEUE_PROTECTED_BIT")]
        QueueProtectedBit = 16,
    }
}
