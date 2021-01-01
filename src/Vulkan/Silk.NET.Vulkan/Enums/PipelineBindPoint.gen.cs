// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
        [NativeName("Name", "VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR")]
        RayTracingKhr = 1000165000,
        [NativeName("Name", "VK_PIPELINE_BIND_POINT_RAY_TRACING_NV")]
        RayTracingNV = 1000165000,
    }
}
