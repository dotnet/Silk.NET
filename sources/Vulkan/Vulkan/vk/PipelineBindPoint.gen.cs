// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineBindPoint")]
public enum PipelineBindPoint : uint
{
    [NativeName("VK_PIPELINE_BIND_POINT_GRAPHICS")]
    Graphics = 0,

    [NativeName("VK_PIPELINE_BIND_POINT_COMPUTE")]
    Compute = 1,

    [NativeName("VK_PIPELINE_BIND_POINT_EXECUTION_GRAPH_AMDX")]
    ExecutionGraphAMDX = 1000134000,

    [NativeName("VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR")]
    RayTracingKHR = 1000165000,

    [NativeName("VK_PIPELINE_BIND_POINT_SUBPASS_SHADING_HUAWEI")]
    SubpassShadingHUAWEI = 1000369003,

    [NativeName("VK_PIPELINE_BIND_POINT_DATA_GRAPH_ARM")]
    DataGraphARM = 1000507000,

    [NativeName("VK_PIPELINE_BIND_POINT_RAY_TRACING_NV")]
    RayTracingNV = RayTracingKHR,
}
