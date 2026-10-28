// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeFlagsKHR")]
[Flags]
public enum VideoEncodeFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_BIT_KHR")]
    IntraRefreshBit = 0x4,

    [NativeName("VK_VIDEO_ENCODE_WITH_QUANTIZATION_DELTA_MAP_BIT_KHR")]
    WithQuantizationDeltaMapBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_WITH_EMPHASIS_MAP_BIT_KHR")]
    WithEmphasisMapBit = 0x2,
}
