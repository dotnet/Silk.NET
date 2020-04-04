// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum PipelineStageFlags
    {
        PipelineStageTopOfPipeBit = 1,
        PipelineStageDrawIndirectBit = 2,
        PipelineStageVertexInputBit = 4,
        PipelineStageVertexShaderBit = 8,
        PipelineStageTessellationControlShaderBit = 16,
        PipelineStageTessellationEvaluationShaderBit = 32,
        PipelineStageGeometryShaderBit = 64,
        PipelineStageFragmentShaderBit = 128,
        PipelineStageEarlyFragmentTestsBit = 256,
        PipelineStageLateFragmentTestsBit = 512,
        PipelineStageColorAttachmentOutputBit = 1024,
        PipelineStageComputeShaderBit = 2048,
        PipelineStageTransferBit = 4096,
        PipelineStageBottomOfPipeBit = 8192,
        PipelineStageHostBit = 16384,
        PipelineStageAllGraphicsBit = 32768,
        PipelineStageAllCommandsBit = 65536,
        PipelineStageReserved27BitKhr = 134217728,
        PipelineStageReserved26BitKhr = 67108864,
        PipelineStageTransformFeedbackBitExt = 16777216,
        PipelineStageConditionalRenderingBitExt = 262144,
        PipelineStageRayTracingShaderBitKhr = 2097152,
        PipelineStageAccelerationStructureBuildBitKhr = 33554432,
        PipelineStageShadingRateImageBitNV = 4194304,
        PipelineStageRayTracingShaderBitNV = 2097152,
        PipelineStageAccelerationStructureBuildBitNV = 33554432,
        PipelineStageTaskShaderBitNV = 524288,
        PipelineStageMeshShaderBitNV = 1048576,
        PipelineStageFragmentDensityProcessBitExt = 8388608,
        PipelineStageCommandPreprocessBitNV = 131072,
    }
}
