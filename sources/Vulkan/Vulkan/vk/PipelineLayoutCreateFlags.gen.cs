// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineLayoutCreateFlags")]
[Flags]
public enum PipelineLayoutCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT")]
    IndependentSetsBitEXT = 0x2,

    [NativeName("VK_PIPELINE_LAYOUT_CREATE_NO_TASK_SHADER_BIT_KHR")]
    NoTaskShaderBitKHR = 0x4,
}
