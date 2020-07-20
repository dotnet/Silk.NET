// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRayTracingShaderGroupTypeKHR")]
    public enum RayTracingShaderGroupTypeKHR
    {
        [NativeName("Name", "VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR")]
        RayTracingShaderGroupTypeGeneralKhr = 0,
        [NativeName("Name", "VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR")]
        RayTracingShaderGroupTypeTrianglesHitGroupKhr = 1,
        [NativeName("Name", "VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR")]
        RayTracingShaderGroupTypeProceduralHitGroupKhr = 2,
    }
}
