// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkMemoryDecompressionMethodFlagsEXT")]
[Transformed]
[Flags]
public enum VkMemoryDecompressionMethodFlagsEXT : ulong
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_EXT")]
    VkMemoryDecompressionMethodGdeflate1x0Bit = unchecked((ulong)0x00000001UL),

    [NativeName("VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkMemoryDecompressionMethodGdeflate1x0BitNV = unchecked((ulong)0x00000001UL),
}
