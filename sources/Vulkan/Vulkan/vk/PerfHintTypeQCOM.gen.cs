// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerfHintTypeQCOM")]
public enum PerfHintTypeQCOM : uint
{
    [NativeName("VK_PERF_HINT_TYPE_DEFAULT_QCOM")]
    Default = 0,

    [NativeName("VK_PERF_HINT_TYPE_FREQUENCY_MIN_QCOM")]
    FrequencyMin = 1,

    [NativeName("VK_PERF_HINT_TYPE_FREQUENCY_MAX_QCOM")]
    FrequencyMax = 2,

    [NativeName("VK_PERF_HINT_TYPE_FREQUENCY_SCALED_QCOM")]
    FrequencyScaled = 3,
}
