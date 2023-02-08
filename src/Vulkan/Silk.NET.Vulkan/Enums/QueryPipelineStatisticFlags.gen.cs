// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkQueryPipelineStatisticFlags")]
    public enum QueryPipelineStatisticFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"InputAssemblyVerticesBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT")]
        QueryPipelineStatisticInputAssemblyVerticesBit = 1,
        [Obsolete("Deprecated in favour of \"InputAssemblyPrimitivesBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT")]
        QueryPipelineStatisticInputAssemblyPrimitivesBit = 2,
        [Obsolete("Deprecated in favour of \"VertexShaderInvocationsBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT")]
        QueryPipelineStatisticVertexShaderInvocationsBit = 4,
        [Obsolete("Deprecated in favour of \"GeometryShaderInvocationsBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT")]
        QueryPipelineStatisticGeometryShaderInvocationsBit = 8,
        [Obsolete("Deprecated in favour of \"GeometryShaderPrimitivesBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT")]
        QueryPipelineStatisticGeometryShaderPrimitivesBit = 16,
        [Obsolete("Deprecated in favour of \"ClippingInvocationsBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT")]
        QueryPipelineStatisticClippingInvocationsBit = 32,
        [Obsolete("Deprecated in favour of \"ClippingPrimitivesBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT")]
        QueryPipelineStatisticClippingPrimitivesBit = 64,
        [Obsolete("Deprecated in favour of \"FragmentShaderInvocationsBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT")]
        QueryPipelineStatisticFragmentShaderInvocationsBit = 128,
        [Obsolete("Deprecated in favour of \"TessellationControlShaderPatchesBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT")]
        QueryPipelineStatisticTessellationControlShaderPatchesBit = 256,
        [Obsolete("Deprecated in favour of \"TessellationEvaluationShaderInvocationsBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT")]
        QueryPipelineStatisticTessellationEvaluationShaderInvocationsBit = 512,
        [Obsolete("Deprecated in favour of \"ComputeShaderInvocationsBit\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT")]
        QueryPipelineStatisticComputeShaderInvocationsBit = 1024,
        [Obsolete("Deprecated in favour of \"TaskShaderInvocationsBitExt\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_TASK_SHADER_INVOCATIONS_BIT_EXT")]
        QueryPipelineStatisticTaskShaderInvocationsBitExt = 2048,
        [Obsolete("Deprecated in favour of \"MeshShaderInvocationsBitExt\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_MESH_SHADER_INVOCATIONS_BIT_EXT")]
        QueryPipelineStatisticMeshShaderInvocationsBitExt = 4096,
        [Obsolete("Deprecated in favour of \"ClusterCullingShaderInvocationsBitHuawei\"")]
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_CLUSTER_CULLING_SHADER_INVOCATIONS_BIT_HUAWEI")]
        QueryPipelineStatisticClusterCullingShaderInvocationsBitHuawei = 8192,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT")]
        InputAssemblyVerticesBit = 1,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT")]
        InputAssemblyPrimitivesBit = 2,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT")]
        VertexShaderInvocationsBit = 4,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT")]
        GeometryShaderInvocationsBit = 8,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT")]
        GeometryShaderPrimitivesBit = 16,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT")]
        ClippingInvocationsBit = 32,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT")]
        ClippingPrimitivesBit = 64,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT")]
        FragmentShaderInvocationsBit = 128,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT")]
        TessellationControlShaderPatchesBit = 256,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT")]
        TessellationEvaluationShaderInvocationsBit = 512,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT")]
        ComputeShaderInvocationsBit = 1024,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_TASK_SHADER_INVOCATIONS_BIT_EXT")]
        TaskShaderInvocationsBitExt = 2048,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_MESH_SHADER_INVOCATIONS_BIT_EXT")]
        MeshShaderInvocationsBitExt = 4096,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_CLUSTER_CULLING_SHADER_INVOCATIONS_BIT_HUAWEI")]
        ClusterCullingShaderInvocationsBitHuawei = 8192,
    }
}
