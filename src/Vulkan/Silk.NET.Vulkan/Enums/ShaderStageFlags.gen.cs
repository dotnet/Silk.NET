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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"VertexBit\"")]
        [NativeName("Name", "VK_SHADER_STAGE_VERTEX_BIT")]
        ShaderStageVertexBit = 1,
        [Obsolete("Deprecated in favour of \"TessellationControlBit\"")]
        [NativeName("Name", "VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT")]
        ShaderStageTessellationControlBit = 2,
        [Obsolete("Deprecated in favour of \"TessellationEvaluationBit\"")]
        [NativeName("Name", "VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT")]
        ShaderStageTessellationEvaluationBit = 4,
        [Obsolete("Deprecated in favour of \"GeometryBit\"")]
        [NativeName("Name", "VK_SHADER_STAGE_GEOMETRY_BIT")]
        ShaderStageGeometryBit = 8,
        [Obsolete("Deprecated in favour of \"FragmentBit\"")]
        [NativeName("Name", "VK_SHADER_STAGE_FRAGMENT_BIT")]
        ShaderStageFragmentBit = 16,
        [Obsolete("Deprecated in favour of \"ComputeBit\"")]
        [NativeName("Name", "VK_SHADER_STAGE_COMPUTE_BIT")]
        ShaderStageComputeBit = 32,
        [Obsolete("Deprecated in favour of \"AllGraphics\"")]
        [NativeName("Name", "VK_SHADER_STAGE_ALL_GRAPHICS")]
        ShaderStageAllGraphics = 31,
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "VK_SHADER_STAGE_ALL")]
        ShaderStageAll = 2147483647,
        [Obsolete("Deprecated in favour of \"RaygenBitKhr\"")]
        [NativeName("Name", "VK_SHADER_STAGE_RAYGEN_BIT_KHR")]
        ShaderStageRaygenBitKhr = 256,
        [Obsolete("Deprecated in favour of \"AnyHitBitKhr\"")]
        [NativeName("Name", "VK_SHADER_STAGE_ANY_HIT_BIT_KHR")]
        ShaderStageAnyHitBitKhr = 512,
        [Obsolete("Deprecated in favour of \"ClosestHitBitKhr\"")]
        [NativeName("Name", "VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR")]
        ShaderStageClosestHitBitKhr = 1024,
        [Obsolete("Deprecated in favour of \"MissBitKhr\"")]
        [NativeName("Name", "VK_SHADER_STAGE_MISS_BIT_KHR")]
        ShaderStageMissBitKhr = 2048,
        [Obsolete("Deprecated in favour of \"IntersectionBitKhr\"")]
        [NativeName("Name", "VK_SHADER_STAGE_INTERSECTION_BIT_KHR")]
        ShaderStageIntersectionBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"CallableBitKhr\"")]
        [NativeName("Name", "VK_SHADER_STAGE_CALLABLE_BIT_KHR")]
        ShaderStageCallableBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"RaygenBitNV\"")]
        [NativeName("Name", "VK_SHADER_STAGE_RAYGEN_BIT_NV")]
        ShaderStageRaygenBitNV = 256,
        [Obsolete("Deprecated in favour of \"AnyHitBitNV\"")]
        [NativeName("Name", "VK_SHADER_STAGE_ANY_HIT_BIT_NV")]
        ShaderStageAnyHitBitNV = 512,
        [Obsolete("Deprecated in favour of \"ClosestHitBitNV\"")]
        [NativeName("Name", "VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV")]
        ShaderStageClosestHitBitNV = 1024,
        [Obsolete("Deprecated in favour of \"MissBitNV\"")]
        [NativeName("Name", "VK_SHADER_STAGE_MISS_BIT_NV")]
        ShaderStageMissBitNV = 2048,
        [Obsolete("Deprecated in favour of \"IntersectionBitNV\"")]
        [NativeName("Name", "VK_SHADER_STAGE_INTERSECTION_BIT_NV")]
        ShaderStageIntersectionBitNV = 4096,
        [Obsolete("Deprecated in favour of \"CallableBitNV\"")]
        [NativeName("Name", "VK_SHADER_STAGE_CALLABLE_BIT_NV")]
        ShaderStageCallableBitNV = 8192,
        [Obsolete("Deprecated in favour of \"TaskBitNV\"")]
        [NativeName("Name", "VK_SHADER_STAGE_TASK_BIT_NV")]
        ShaderStageTaskBitNV = 64,
        [Obsolete("Deprecated in favour of \"MeshBitNV\"")]
        [NativeName("Name", "VK_SHADER_STAGE_MESH_BIT_NV")]
        ShaderStageMeshBitNV = 128,
        [Obsolete("Deprecated in favour of \"TaskBitExt\"")]
        [NativeName("Name", "VK_SHADER_STAGE_TASK_BIT_EXT")]
        ShaderStageTaskBitExt = 64,
        [Obsolete("Deprecated in favour of \"MeshBitExt\"")]
        [NativeName("Name", "VK_SHADER_STAGE_MESH_BIT_EXT")]
        ShaderStageMeshBitExt = 128,
        [Obsolete("Deprecated in favour of \"SubpassShadingBitHuawei\"")]
        [NativeName("Name", "VK_SHADER_STAGE_SUBPASS_SHADING_BIT_HUAWEI")]
        ShaderStageSubpassShadingBitHuawei = 16384,
        [Obsolete("Deprecated in favour of \"ClusterCullingBitHuawei\"")]
        [NativeName("Name", "VK_SHADER_STAGE_CLUSTER_CULLING_BIT_HUAWEI")]
        ShaderStageClusterCullingBitHuawei = 524288,
        [NativeName("Name", "VK_SHADER_STAGE_VERTEX_BIT")]
        VertexBit = 1,
        [NativeName("Name", "VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT")]
        TessellationControlBit = 2,
        [NativeName("Name", "VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT")]
        TessellationEvaluationBit = 4,
        [NativeName("Name", "VK_SHADER_STAGE_GEOMETRY_BIT")]
        GeometryBit = 8,
        [NativeName("Name", "VK_SHADER_STAGE_FRAGMENT_BIT")]
        FragmentBit = 16,
        [NativeName("Name", "VK_SHADER_STAGE_COMPUTE_BIT")]
        ComputeBit = 32,
        [NativeName("Name", "VK_SHADER_STAGE_ALL_GRAPHICS")]
        AllGraphics = 31,
        [NativeName("Name", "VK_SHADER_STAGE_ALL")]
        All = 2147483647,
        [NativeName("Name", "VK_SHADER_STAGE_RAYGEN_BIT_KHR")]
        RaygenBitKhr = 256,
        [NativeName("Name", "VK_SHADER_STAGE_ANY_HIT_BIT_KHR")]
        AnyHitBitKhr = 512,
        [NativeName("Name", "VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR")]
        ClosestHitBitKhr = 1024,
        [NativeName("Name", "VK_SHADER_STAGE_MISS_BIT_KHR")]
        MissBitKhr = 2048,
        [NativeName("Name", "VK_SHADER_STAGE_INTERSECTION_BIT_KHR")]
        IntersectionBitKhr = 4096,
        [NativeName("Name", "VK_SHADER_STAGE_CALLABLE_BIT_KHR")]
        CallableBitKhr = 8192,
        [NativeName("Name", "VK_SHADER_STAGE_RAYGEN_BIT_NV")]
        RaygenBitNV = 256,
        [NativeName("Name", "VK_SHADER_STAGE_ANY_HIT_BIT_NV")]
        AnyHitBitNV = 512,
        [NativeName("Name", "VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV")]
        ClosestHitBitNV = 1024,
        [NativeName("Name", "VK_SHADER_STAGE_MISS_BIT_NV")]
        MissBitNV = 2048,
        [NativeName("Name", "VK_SHADER_STAGE_INTERSECTION_BIT_NV")]
        IntersectionBitNV = 4096,
        [NativeName("Name", "VK_SHADER_STAGE_CALLABLE_BIT_NV")]
        CallableBitNV = 8192,
        [NativeName("Name", "VK_SHADER_STAGE_TASK_BIT_NV")]
        TaskBitNV = 64,
        [NativeName("Name", "VK_SHADER_STAGE_MESH_BIT_NV")]
        MeshBitNV = 128,
        [NativeName("Name", "VK_SHADER_STAGE_TASK_BIT_EXT")]
        TaskBitExt = 64,
        [NativeName("Name", "VK_SHADER_STAGE_MESH_BIT_EXT")]
        MeshBitExt = 128,
        [NativeName("Name", "VK_SHADER_STAGE_SUBPASS_SHADING_BIT_HUAWEI")]
        SubpassShadingBitHuawei = 16384,
        [NativeName("Name", "VK_SHADER_STAGE_CLUSTER_CULLING_BIT_HUAWEI")]
        ClusterCullingBitHuawei = 524288,
    }
}
