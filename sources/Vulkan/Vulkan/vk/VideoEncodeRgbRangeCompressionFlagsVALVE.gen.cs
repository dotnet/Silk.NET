// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeRgbRangeCompressionFlagsVALVE")]
[Flags]
public enum VideoEncodeRgbRangeCompressionFlagsVALVE : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_FULL_RANGE_BIT_VALVE")]
    FullRangeBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_NARROW_RANGE_BIT_VALVE")]
    NarrowRangeBit = 0x2,
}
