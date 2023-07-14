// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkQueueFlags")]
    public enum QueueFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"GraphicsBit\"")]
        [NativeName("Name", "VK_QUEUE_GRAPHICS_BIT")]
        QueueGraphicsBit = 1,
        [Obsolete("Deprecated in favour of \"ComputeBit\"")]
        [NativeName("Name", "VK_QUEUE_COMPUTE_BIT")]
        QueueComputeBit = 2,
        [Obsolete("Deprecated in favour of \"TransferBit\"")]
        [NativeName("Name", "VK_QUEUE_TRANSFER_BIT")]
        QueueTransferBit = 4,
        [Obsolete("Deprecated in favour of \"SparseBindingBit\"")]
        [NativeName("Name", "VK_QUEUE_SPARSE_BINDING_BIT")]
        QueueSparseBindingBit = 8,
        [Obsolete("Deprecated in favour of \"VideoDecodeBitKhr\"")]
        [NativeName("Name", "VK_QUEUE_VIDEO_DECODE_BIT_KHR")]
        QueueVideoDecodeBitKhr = 32,
        [Obsolete("Deprecated in favour of \"VideoEncodeBitKhr\"")]
        [NativeName("Name", "VK_QUEUE_VIDEO_ENCODE_BIT_KHR")]
        QueueVideoEncodeBitKhr = 64,
        [Obsolete("Deprecated in favour of \"OpticalFlowBitNV\"")]
        [NativeName("Name", "VK_QUEUE_OPTICAL_FLOW_BIT_NV")]
        QueueOpticalFlowBitNV = 256,
        [Obsolete("Deprecated in favour of \"ProtectedBit\"")]
        [NativeName("Name", "VK_QUEUE_PROTECTED_BIT")]
        QueueProtectedBit = 16,
        [NativeName("Name", "VK_QUEUE_GRAPHICS_BIT")]
        GraphicsBit = 1,
        [NativeName("Name", "VK_QUEUE_COMPUTE_BIT")]
        ComputeBit = 2,
        [NativeName("Name", "VK_QUEUE_TRANSFER_BIT")]
        TransferBit = 4,
        [NativeName("Name", "VK_QUEUE_SPARSE_BINDING_BIT")]
        SparseBindingBit = 8,
        [NativeName("Name", "VK_QUEUE_VIDEO_DECODE_BIT_KHR")]
        VideoDecodeBitKhr = 32,
        [NativeName("Name", "VK_QUEUE_VIDEO_ENCODE_BIT_KHR")]
        VideoEncodeBitKhr = 64,
        [NativeName("Name", "VK_QUEUE_OPTICAL_FLOW_BIT_NV")]
        OpticalFlowBitNV = 256,
        [NativeName("Name", "VK_QUEUE_PROTECTED_BIT")]
        ProtectedBit = 16,
    }
}
