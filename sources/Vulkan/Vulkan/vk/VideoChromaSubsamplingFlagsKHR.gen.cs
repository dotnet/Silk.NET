// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoChromaSubsamplingFlagsKHR")]
[Flags]
public enum VideoChromaSubsamplingFlagsKHR : uint
{
    [NativeName("VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_KHR")]
    SubsamplingInvalid = 0x0,

    [NativeName("VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR")]
    SubsamplingMonochromeBit = 0x1,

    [NativeName("VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR")]
    Subsampling420Bit = 0x2,

    [NativeName("VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR")]
    Subsampling422Bit = 0x4,

    [NativeName("VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR")]
    Subsampling444Bit = 0x8,
}
