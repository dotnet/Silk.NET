// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum QueryPipelineStatisticFlags
    {
        QueryPipelineStatisticInputAssemblyVerticesBit = 1,
        QueryPipelineStatisticInputAssemblyPrimitivesBit = 2,
        QueryPipelineStatisticVertexShaderInvocationsBit = 4,
        QueryPipelineStatisticGeometryShaderInvocationsBit = 8,
        QueryPipelineStatisticGeometryShaderPrimitivesBit = 16,
        QueryPipelineStatisticClippingInvocationsBit = 32,
        QueryPipelineStatisticClippingPrimitivesBit = 64,
        QueryPipelineStatisticFragmentShaderInvocationsBit = 128,
        QueryPipelineStatisticTessellationControlShaderPatchesBit = 256,
        QueryPipelineStatisticTessellationEvaluationShaderInvocationsBit = 512,
        QueryPipelineStatisticComputeShaderInvocationsBit = 1024,
    }
}
