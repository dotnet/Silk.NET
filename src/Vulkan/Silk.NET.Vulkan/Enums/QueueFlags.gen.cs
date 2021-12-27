// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkQueueFlags")]
    public enum QueueFlags : int
    {
        [NativeName("Name", "VK_QUEUE_GRAPHICS_BIT")]
        QueueGraphicsBit = 1,
        [NativeName("Name", "VK_QUEUE_COMPUTE_BIT")]
        QueueComputeBit = 2,
        [NativeName("Name", "VK_QUEUE_TRANSFER_BIT")]
        QueueTransferBit = 4,
        [NativeName("Name", "VK_QUEUE_SPARSE_BINDING_BIT")]
        QueueSparseBindingBit = 8,
        [NativeName("Name", "VK_QUEUE_VIDEO_DECODE_BIT_KHR")]
        QueueVideoDecodeBitKhr = 32,
        [NativeName("Name", "VK_QUEUE_VIDEO_ENCODE_BIT_KHR")]
        QueueVideoEncodeBitKhr = 64,
        [NativeName("Name", "VK_QUEUE_RESERVED_7_BIT_QCOM")]
        QueueReserved7BitQCom = 128,
        [NativeName("Name", "VK_QUEUE_PROTECTED_BIT")]
        QueueProtectedBit = 16,
    }
}
