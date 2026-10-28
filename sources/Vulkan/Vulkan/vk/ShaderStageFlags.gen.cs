// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderStageFlags")]
[Flags]
public enum ShaderStageFlags : uint
{
    None = 0x0,

    [NativeName("VK_SHADER_STAGE_VERTEX_BIT")]
    VertexBit = 0x1,

    [NativeName("VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT")]
    TessellationControlBit = 0x2,

    [NativeName("VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT")]
    TessellationEvaluationBit = 0x4,

    [NativeName("VK_SHADER_STAGE_GEOMETRY_BIT")]
    GeometryBit = 0x8,

    [NativeName("VK_SHADER_STAGE_FRAGMENT_BIT")]
    FragmentBit = 0x10,

    [NativeName("VK_SHADER_STAGE_COMPUTE_BIT")]
    ComputeBit = 0x20,

    [NativeName("VK_SHADER_STAGE_ALL_GRAPHICS")]
    AllGraphics = 0x1F,

    [NativeName("VK_SHADER_STAGE_ALL")]
    All = 0x7FFFFFFF,

    [NativeName("VK_SHADER_STAGE_RAYGEN_BIT_KHR")]
    RaygenBitKHR = 0x100,

    [NativeName("VK_SHADER_STAGE_ANY_HIT_BIT_KHR")]
    AnyHitBitKHR = 0x200,

    [NativeName("VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR")]
    ClosestHitBitKHR = 0x400,

    [NativeName("VK_SHADER_STAGE_MISS_BIT_KHR")]
    MissBitKHR = 0x800,

    [NativeName("VK_SHADER_STAGE_INTERSECTION_BIT_KHR")]
    IntersectionBitKHR = 0x1000,

    [NativeName("VK_SHADER_STAGE_CALLABLE_BIT_KHR")]
    CallableBitKHR = 0x2000,

    [NativeName("VK_SHADER_STAGE_TASK_BIT_EXT")]
    TaskBitEXT = 0x40,

    [NativeName("VK_SHADER_STAGE_MESH_BIT_EXT")]
    MeshBitEXT = 0x80,

    [NativeName("VK_SHADER_STAGE_SUBPASS_SHADING_BIT_HUAWEI")]
    SubpassShadingBitHUAWEI = 0x4000,

    [NativeName("VK_SHADER_STAGE_CLUSTER_CULLING_BIT_HUAWEI")]
    ClusterCullingBitHUAWEI = 0x80000,

    [NativeName("VK_SHADER_STAGE_RAYGEN_BIT_NV")]
    RaygenBitNV = RaygenBitKHR,

    [NativeName("VK_SHADER_STAGE_ANY_HIT_BIT_NV")]
    AnyHitBitNV = AnyHitBitKHR,

    [NativeName("VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV")]
    ClosestHitBitNV = ClosestHitBitKHR,

    [NativeName("VK_SHADER_STAGE_MISS_BIT_NV")]
    MissBitNV = MissBitKHR,

    [NativeName("VK_SHADER_STAGE_INTERSECTION_BIT_NV")]
    IntersectionBitNV = IntersectionBitKHR,

    [NativeName("VK_SHADER_STAGE_CALLABLE_BIT_NV")]
    CallableBitNV = CallableBitKHR,

    [NativeName("VK_SHADER_STAGE_TASK_BIT_NV")]
    TaskBitNV = TaskBitEXT,

    [NativeName("VK_SHADER_STAGE_MESH_BIT_NV")]
    MeshBitNV = MeshBitEXT,
}
