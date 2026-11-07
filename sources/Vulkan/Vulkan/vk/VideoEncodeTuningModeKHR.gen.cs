// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeTuningModeKHR")]
public enum VideoEncodeTuningModeKHR : uint
{
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_DEFAULT_KHR")]
    Default = 0,

    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_HIGH_QUALITY_KHR")]
    HighQuality = 1,

    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_LOW_LATENCY_KHR")]
    LowLatency = 2,

    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_ULTRA_LOW_LATENCY_KHR")]
    UltraLowLatency = 3,

    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_LOSSLESS_KHR")]
    Lossless = 4,
}
