// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPresentStageFlagsEXT")]
    public enum PresentStageFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"QueueOperationsEndBitExt\"")]
        [NativeName("Name", "VK_PRESENT_STAGE_QUEUE_OPERATIONS_END_BIT_EXT")]
        PresentStageQueueOperationsEndBitExt = 1,
        [Obsolete("Deprecated in favour of \"RequestDequeuedBitExt\"")]
        [NativeName("Name", "VK_PRESENT_STAGE_REQUEST_DEQUEUED_BIT_EXT")]
        PresentStageRequestDequeuedBitExt = 2,
        [Obsolete("Deprecated in favour of \"ImageFirstPixelOutBitExt\"")]
        [NativeName("Name", "VK_PRESENT_STAGE_IMAGE_FIRST_PIXEL_OUT_BIT_EXT")]
        PresentStageImageFirstPixelOutBitExt = 4,
        [Obsolete("Deprecated in favour of \"ImageFirstPixelVisibleBitExt\"")]
        [NativeName("Name", "VK_PRESENT_STAGE_IMAGE_FIRST_PIXEL_VISIBLE_BIT_EXT")]
        PresentStageImageFirstPixelVisibleBitExt = 8,
        [NativeName("Name", "VK_PRESENT_STAGE_QUEUE_OPERATIONS_END_BIT_EXT")]
        QueueOperationsEndBitExt = 1,
        [NativeName("Name", "VK_PRESENT_STAGE_REQUEST_DEQUEUED_BIT_EXT")]
        RequestDequeuedBitExt = 2,
        [NativeName("Name", "VK_PRESENT_STAGE_IMAGE_FIRST_PIXEL_OUT_BIT_EXT")]
        ImageFirstPixelOutBitExt = 4,
        [NativeName("Name", "VK_PRESENT_STAGE_IMAGE_FIRST_PIXEL_VISIBLE_BIT_EXT")]
        ImageFirstPixelVisibleBitExt = 8,
    }
}
