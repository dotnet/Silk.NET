// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSwapchainUsageFlags")]
[Flags]
public enum SwapchainUsageFlags : ulong
{
    None = 0x0,

    [NativeName("XR_SWAPCHAIN_USAGE_COLOR_ATTACHMENT_BIT")]
    ColorAttachmentBit = 0x1,

    [NativeName("XR_SWAPCHAIN_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT")]
    DepthStencilAttachmentBit = 0x2,

    [NativeName("XR_SWAPCHAIN_USAGE_UNORDERED_ACCESS_BIT")]
    UnorderedAccessBit = 0x4,

    [NativeName("XR_SWAPCHAIN_USAGE_TRANSFER_SRC_BIT")]
    TransferSrcBit = 0x8,

    [NativeName("XR_SWAPCHAIN_USAGE_TRANSFER_DST_BIT")]
    TransferDstBit = 0x10,

    [NativeName("XR_SWAPCHAIN_USAGE_SAMPLED_BIT")]
    SampledBit = 0x20,

    [NativeName("XR_SWAPCHAIN_USAGE_MUTABLE_FORMAT_BIT")]
    MutableFormatBit = 0x40,

    [NativeName("XR_SWAPCHAIN_USAGE_INPUT_ATTACHMENT_BIT_MND")]
    InputAttachmentBitMND = 0x80,

    [NativeName("XR_SWAPCHAIN_USAGE_INPUT_ATTACHMENT_BIT_KHR")]
    InputAttachmentBitKHR = 0x80,
}
