// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFrameBoundaryFlagsEXT")]
[Flags]
public enum FrameBoundaryFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_FRAME_BOUNDARY_FRAME_END_BIT_EXT")]
    FrameEndBit = 0x1,
}
