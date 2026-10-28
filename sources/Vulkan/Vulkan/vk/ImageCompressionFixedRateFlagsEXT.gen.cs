// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageCompressionFixedRateFlagsEXT")]
[Flags]
public enum ImageCompressionFixedRateFlagsEXT : uint
{
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_NONE_EXT")]
    RateNone = 0x0,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_1BPC_BIT_EXT")]
    Rate1BpcBit = 0x1,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT")]
    Rate2BpcBit = 0x2,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_3BPC_BIT_EXT")]
    Rate3BpcBit = 0x4,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_4BPC_BIT_EXT")]
    Rate4BpcBit = 0x8,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_5BPC_BIT_EXT")]
    Rate5BpcBit = 0x10,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_6BPC_BIT_EXT")]
    Rate6BpcBit = 0x20,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_7BPC_BIT_EXT")]
    Rate7BpcBit = 0x40,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_8BPC_BIT_EXT")]
    Rate8BpcBit = 0x80,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_9BPC_BIT_EXT")]
    Rate9BpcBit = 0x100,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_10BPC_BIT_EXT")]
    Rate10BpcBit = 0x200,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_11BPC_BIT_EXT")]
    Rate11BpcBit = 0x400,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_12BPC_BIT_EXT")]
    Rate12BpcBit = 0x800,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_13BPC_BIT_EXT")]
    Rate13BpcBit = 0x1000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_14BPC_BIT_EXT")]
    Rate14BpcBit = 0x2000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_15BPC_BIT_EXT")]
    Rate15BpcBit = 0x4000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_16BPC_BIT_EXT")]
    Rate16BpcBit = 0x8000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_17BPC_BIT_EXT")]
    Rate17BpcBit = 0x10000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_18BPC_BIT_EXT")]
    Rate18BpcBit = 0x20000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_19BPC_BIT_EXT")]
    Rate19BpcBit = 0x40000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_20BPC_BIT_EXT")]
    Rate20BpcBit = 0x80000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_21BPC_BIT_EXT")]
    Rate21BpcBit = 0x100000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_22BPC_BIT_EXT")]
    Rate22BpcBit = 0x200000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_23BPC_BIT_EXT")]
    Rate23BpcBit = 0x400000,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_24BPC_BIT_EXT")]
    Rate24BpcBit = 0x800000,
}
