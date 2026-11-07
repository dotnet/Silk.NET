// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueryPipelineStatisticFlags")]
[Flags]
public enum QueryPipelineStatisticFlags : uint
{
    None = 0x0,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT")]
    InputAssemblyVerticesBit = 0x1,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT")]
    InputAssemblyPrimitivesBit = 0x2,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT")]
    VertexShaderInvocationsBit = 0x4,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT")]
    GeometryShaderInvocationsBit = 0x8,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT")]
    GeometryShaderPrimitivesBit = 0x10,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT")]
    ClippingInvocationsBit = 0x20,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT")]
    ClippingPrimitivesBit = 0x40,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT")]
    FragmentShaderInvocationsBit = 0x80,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT")]
    TessellationControlShaderPatchesBit = 0x100,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT")]
    TessellationEvaluationShaderInvocationsBit = 0x200,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT")]
    ComputeShaderInvocationsBit = 0x400,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_TASK_SHADER_INVOCATIONS_BIT_EXT")]
    TaskShaderInvocationsBitEXT = 0x800,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_MESH_SHADER_INVOCATIONS_BIT_EXT")]
    MeshShaderInvocationsBitEXT = 0x1000,

    [NativeName("VK_QUERY_PIPELINE_STATISTIC_CLUSTER_CULLING_SHADER_INVOCATIONS_BIT_HUAWEI")]
    ClusterCullingShaderInvocationsBitHUAWEI = 0x2000,
}
