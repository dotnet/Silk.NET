// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkQueryPipelineStatisticFlags")]
    public enum QueryPipelineStatisticFlags : int
    {
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT")]
        QueryPipelineStatisticInputAssemblyVerticesBit = 1,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT")]
        QueryPipelineStatisticInputAssemblyPrimitivesBit = 2,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT")]
        QueryPipelineStatisticVertexShaderInvocationsBit = 4,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT")]
        QueryPipelineStatisticGeometryShaderInvocationsBit = 8,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT")]
        QueryPipelineStatisticGeometryShaderPrimitivesBit = 16,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT")]
        QueryPipelineStatisticClippingInvocationsBit = 32,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT")]
        QueryPipelineStatisticClippingPrimitivesBit = 64,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT")]
        QueryPipelineStatisticFragmentShaderInvocationsBit = 128,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT")]
        QueryPipelineStatisticTessellationControlShaderPatchesBit = 256,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT")]
        QueryPipelineStatisticTessellationEvaluationShaderInvocationsBit = 512,
        [NativeName("Name", "VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT")]
        QueryPipelineStatisticComputeShaderInvocationsBit = 1024,
    }
}
