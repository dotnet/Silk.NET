// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBuildMicromapFlagsEXT")]
[Flags]
public enum BuildMicromapFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT")]
    PreferFastTraceBit = 0x1,

    [NativeName("VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT")]
    PreferFastBuildBit = 0x2,

    [NativeName("VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT")]
    AllowCompactionBit = 0x4,
}
