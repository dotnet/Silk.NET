// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeRgbChromaOffsetFlagsVALVE")]
[Flags]
public enum VideoEncodeRgbChromaOffsetFlagsVALVE : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_ENCODE_RGB_CHROMA_OFFSET_COSITED_EVEN_BIT_VALVE")]
    CositedEvenBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_RGB_CHROMA_OFFSET_MIDPOINT_BIT_VALVE")]
    MidpointBit = 0x2,
}
