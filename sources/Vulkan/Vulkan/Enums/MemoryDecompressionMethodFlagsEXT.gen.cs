// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkMemoryDecompressionMethodFlagsEXT")]
[Flags]
public enum MemoryDecompressionMethodFlagsEXT : ulong
{
    None = 0x0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_EXT")]
    Ext = 0x1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_NV")]
    Nv = 0x1,
}
