// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum PipelineCreateFlags
    {
        PipelineCreateDisableOptimizationBit = 1,
        PipelineCreateAllowDerivativesBit = 2,
        PipelineCreateDerivativeBit = 4,
        PipelineCreateViewIndexFromDeviceIndexBitKhr = 8,
        PipelineCreateDispatchBaseKhr = 16,
        PipelineCreateRayTracingNoNullAnyHitShadersBitKhr = 16384,
        PipelineCreateRayTracingNoNullClosestHitShadersBitKhr = 32768,
        PipelineCreateRayTracingNoNullMissShadersBitKhr = 65536,
        PipelineCreateRayTracingNoNullIntersectionShadersBitKhr = 131072,
        PipelineCreateRayTracingSkipTrianglesBitKhr = 4096,
        PipelineCreateRayTracingSkipAabbsBitKhr = 8192,
        PipelineCreateDeferCompileBitNV = 32,
        PipelineCreateCaptureStatisticsBitKhr = 64,
        PipelineCreateCaptureInternalRepresentationsBitKhr = 128,
        PipelineCreateIndirectBindableBitNV = 262144,
        PipelineCreateLibraryBitKhr = 2048,
        PipelineCreateFailOnPipelineCompileRequiredBitExt = 256,
        PipelineCreateEarlyReturnOnFailureBitExt = 512,
        PipelineCreateViewIndexFromDeviceIndexBit = 8,
        PipelineCreateDispatchBaseBit = 16,
        PipelineCreateDispatchBase = 16,
    }
}
