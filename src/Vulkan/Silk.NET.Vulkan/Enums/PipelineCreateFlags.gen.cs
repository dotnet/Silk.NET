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
    [NativeName("Name", "VkPipelineCreateFlags")]
    public enum PipelineCreateFlags : int
    {
        [NativeName("Name", "VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT")]
        PipelineCreateDisableOptimizationBit = 1,
        [NativeName("Name", "VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT")]
        PipelineCreateAllowDerivativesBit = 2,
        [NativeName("Name", "VK_PIPELINE_CREATE_DERIVATIVE_BIT")]
        PipelineCreateDerivativeBit = 4,
        [NativeName("Name", "VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR")]
        PipelineCreateViewIndexFromDeviceIndexBitKhr = 8,
        [NativeName("Name", "VK_PIPELINE_CREATE_DISPATCH_BASE_KHR")]
        PipelineCreateDispatchBaseKhr = 16,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
        PipelineCreateRayTracingNoNullAnyHitShadersBitKhr = 16384,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
        PipelineCreateRayTracingNoNullClosestHitShadersBitKhr = 32768,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
        PipelineCreateRayTracingNoNullMissShadersBitKhr = 65536,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
        PipelineCreateRayTracingNoNullIntersectionShadersBitKhr = 131072,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
        PipelineCreateRayTracingSkipTrianglesBitKhr = 4096,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
        PipelineCreateRayTracingSkipAabbsBitKhr = 8192,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
        PipelineCreateRayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        [NativeName("Name", "VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV")]
        PipelineCreateDeferCompileBitNV = 32,
        [NativeName("Name", "VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR")]
        PipelineCreateCaptureStatisticsBitKhr = 64,
        [NativeName("Name", "VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
        PipelineCreateCaptureInternalRepresentationsBitKhr = 128,
        [NativeName("Name", "VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV")]
        PipelineCreateIndirectBindableBitNV = 262144,
        [NativeName("Name", "VK_PIPELINE_CREATE_LIBRARY_BIT_KHR")]
        PipelineCreateLibraryBitKhr = 2048,
        [NativeName("Name", "VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT")]
        PipelineCreateFailOnPipelineCompileRequiredBitExt = 256,
        [NativeName("Name", "VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT")]
        PipelineCreateEarlyReturnOnFailureBitExt = 512,
        [NativeName("Name", "VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
        PipelineCreateViewIndexFromDeviceIndexBit = 8,
        [NativeName("Name", "VK_PIPELINE_CREATE_DISPATCH_BASE_BIT")]
        PipelineCreateDispatchBaseBit = 16,
        [NativeName("Name", "VK_PIPELINE_CREATE_DISPATCH_BASE")]
        PipelineCreateDispatchBase = 16,
    }
}
