// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGpaSampleTypeAMD")]
public enum GpaSampleTypeAMD : uint
{
    [NativeName("VK_GPA_SAMPLE_TYPE_CUMULATIVE_AMD")]
    Cumulative = 0,

    [NativeName("VK_GPA_SAMPLE_TYPE_TRACE_AMD")]
    Trace = 1,

    [NativeName("VK_GPA_SAMPLE_TYPE_TIMING_AMD")]
    Timing = 2,
}
