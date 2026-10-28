// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineExecutableStatisticFormatKHR")]
public enum PipelineExecutableStatisticFormatKHR : uint
{
    [NativeName("VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR")]
    Bool32 = 0,

    [NativeName("VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR")]
    Int64 = 1,

    [NativeName("VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR")]
    Uint64 = 2,

    [NativeName("VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR")]
    Float64 = 3,
}
