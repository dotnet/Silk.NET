// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageCompressionFlagsEXT")]
[Flags]
public enum ImageCompressionFlagsEXT : uint
{
    [NativeName("VK_IMAGE_COMPRESSION_DEFAULT_EXT")]
    Default = 0x0,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
    FixedRateDefault = 0x1,

    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT")]
    FixedRateExplicit = 0x2,

    [NativeName("VK_IMAGE_COMPRESSION_DISABLED_EXT")]
    Disabled = 0x4,
}
