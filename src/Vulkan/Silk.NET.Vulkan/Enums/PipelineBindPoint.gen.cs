// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineBindPoint")]
    public enum PipelineBindPoint : int
    {
        [NativeName("Name", "VK_PIPELINE_BIND_POINT_GRAPHICS")]
        Graphics = 0,
        [NativeName("Name", "VK_PIPELINE_BIND_POINT_COMPUTE")]
        Compute = 1,
        [NativeName("Name", "VK_PIPELINE_BIND_POINT_EXECUTION_GRAPH_AMDX")]
        ExecutionGraphAmdx = 1000134000,
        [NativeName("Name", "VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR")]
        RayTracingKhr = 1000165000,
        [NativeName("Name", "VK_PIPELINE_BIND_POINT_RAY_TRACING_NV")]
        RayTracingNV = 1000165000,
        [NativeName("Name", "VK_PIPELINE_BIND_POINT_SUBPASS_SHADING_HUAWEI")]
        SubpassShadingHuawei = 1000369003,
    }
}
