// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkShaderStageFlags")]
    public enum ShaderStageFlags : int
    {
        [NativeName("Name", "VK_SHADER_STAGE_VERTEX_BIT")]
        ShaderStageVertexBit = 1,
        [NativeName("Name", "VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT")]
        ShaderStageTessellationControlBit = 2,
        [NativeName("Name", "VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT")]
        ShaderStageTessellationEvaluationBit = 4,
        [NativeName("Name", "VK_SHADER_STAGE_GEOMETRY_BIT")]
        ShaderStageGeometryBit = 8,
        [NativeName("Name", "VK_SHADER_STAGE_FRAGMENT_BIT")]
        ShaderStageFragmentBit = 16,
        [NativeName("Name", "VK_SHADER_STAGE_COMPUTE_BIT")]
        ShaderStageComputeBit = 32,
        [NativeName("Name", "VK_SHADER_STAGE_ALL_GRAPHICS")]
        ShaderStageAllGraphics = 31,
        [NativeName("Name", "VK_SHADER_STAGE_ALL")]
        ShaderStageAll = 2147483647,
        [NativeName("Name", "VK_SHADER_STAGE_RAYGEN_BIT_KHR")]
        ShaderStageRaygenBitKhr = 256,
        [NativeName("Name", "VK_SHADER_STAGE_ANY_HIT_BIT_KHR")]
        ShaderStageAnyHitBitKhr = 512,
        [NativeName("Name", "VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR")]
        ShaderStageClosestHitBitKhr = 1024,
        [NativeName("Name", "VK_SHADER_STAGE_MISS_BIT_KHR")]
        ShaderStageMissBitKhr = 2048,
        [NativeName("Name", "VK_SHADER_STAGE_INTERSECTION_BIT_KHR")]
        ShaderStageIntersectionBitKhr = 4096,
        [NativeName("Name", "VK_SHADER_STAGE_CALLABLE_BIT_KHR")]
        ShaderStageCallableBitKhr = 8192,
        [NativeName("Name", "VK_SHADER_STAGE_RAYGEN_BIT_NV")]
        ShaderStageRaygenBitNV = 256,
        [NativeName("Name", "VK_SHADER_STAGE_ANY_HIT_BIT_NV")]
        ShaderStageAnyHitBitNV = 512,
        [NativeName("Name", "VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV")]
        ShaderStageClosestHitBitNV = 1024,
        [NativeName("Name", "VK_SHADER_STAGE_MISS_BIT_NV")]
        ShaderStageMissBitNV = 2048,
        [NativeName("Name", "VK_SHADER_STAGE_INTERSECTION_BIT_NV")]
        ShaderStageIntersectionBitNV = 4096,
        [NativeName("Name", "VK_SHADER_STAGE_CALLABLE_BIT_NV")]
        ShaderStageCallableBitNV = 8192,
        [NativeName("Name", "VK_SHADER_STAGE_TASK_BIT_NV")]
        ShaderStageTaskBitNV = 64,
        [NativeName("Name", "VK_SHADER_STAGE_MESH_BIT_NV")]
        ShaderStageMeshBitNV = 128,
        [NativeName("Name", "VK_SHADER_STAGE_SUBPASS_SHADING_BIT_HUAWEI")]
        ShaderStageSubpassShadingBitHuawei = 16384,
    }
}
