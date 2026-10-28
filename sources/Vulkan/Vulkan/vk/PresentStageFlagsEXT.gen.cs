// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentStageFlagsEXT")]
[Flags]
public enum PresentStageFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_PRESENT_STAGE_QUEUE_OPERATIONS_END_BIT_EXT")]
    QueueOperationsEndBit = 0x1,

    [NativeName("VK_PRESENT_STAGE_REQUEST_DEQUEUED_BIT_EXT")]
    RequestDequeuedBit = 0x2,

    [NativeName("VK_PRESENT_STAGE_IMAGE_FIRST_PIXEL_OUT_BIT_EXT")]
    ImageFirstPixelOutBit = 0x4,

    [NativeName("VK_PRESENT_STAGE_IMAGE_FIRST_PIXEL_VISIBLE_BIT_EXT")]
    ImageFirstPixelVisibleBit = 0x8,
}
