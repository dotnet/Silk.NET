// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeH264PictureLayoutFlagsKHR")]
[Flags]
public enum VideoDecodeH264PictureLayoutFlagsKHR : uint
{
    [NativeName("VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_KHR")]
    Progressive = 0x0,

    [NativeName("VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_KHR")]
    InterlacedInterleavedLinesBit = 0x1,

    [NativeName("VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_KHR")]
    InterlacedSeparatePlanesBit = 0x2,
}
