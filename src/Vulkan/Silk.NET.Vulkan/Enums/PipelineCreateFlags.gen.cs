// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineCreateFlags")]
    public enum PipelineCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"CreateDisableOptimizationBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT")]
        PipelineCreateDisableOptimizationBit = 1,
        [Obsolete("Deprecated in favour of \"CreateAllowDerivativesBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT")]
        PipelineCreateAllowDerivativesBit = 2,
        [Obsolete("Deprecated in favour of \"CreateDerivativeBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_DERIVATIVE_BIT")]
        PipelineCreateDerivativeBit = 4,
        [Obsolete("Deprecated in favour of \"CreateViewIndexFromDeviceIndexBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR")]
        PipelineCreateViewIndexFromDeviceIndexBitKhr = 8,
        [Obsolete("Deprecated in favour of \"CreateDispatchBaseKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_DISPATCH_BASE_KHR")]
        PipelineCreateDispatchBaseKhr = 16,
        [Obsolete("Deprecated in favour of \"CreateRayTracingNoNullAnyHitShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
        PipelineCreateRayTracingNoNullAnyHitShadersBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"CreateRayTracingNoNullClosestHitShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
        PipelineCreateRayTracingNoNullClosestHitShadersBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"CreateRayTracingNoNullMissShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
        PipelineCreateRayTracingNoNullMissShadersBitKhr = 65536,
        [Obsolete("Deprecated in favour of \"CreateRayTracingNoNullIntersectionShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
        PipelineCreateRayTracingNoNullIntersectionShadersBitKhr = 131072,
        [Obsolete("Deprecated in favour of \"CreateRayTracingSkipTrianglesBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
        PipelineCreateRayTracingSkipTrianglesBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"CreateRayTracingSkipAabbsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
        PipelineCreateRayTracingSkipAabbsBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"CreateRayTracingShaderGroupHandleCaptureReplayBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
        PipelineCreateRayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        [Obsolete("Deprecated in favour of \"CreateDeferCompileBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV")]
        PipelineCreateDeferCompileBitNV = 32,
        [Obsolete("Deprecated in favour of \"CreateRenderingFragmentDensityMapAttachmentBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
        PipelineCreateRenderingFragmentDensityMapAttachmentBitExt = 4194304,
        [Obsolete("Deprecated in favour of \"RasterizationStateCreateFragmentDensityMapAttachmentBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
        PipelineRasterizationStateCreateFragmentDensityMapAttachmentBitExt = 4194304,
        [Obsolete("Deprecated in favour of \"CreateRenderingFragmentShadingRateAttachmentBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        PipelineCreateRenderingFragmentShadingRateAttachmentBitKhr = 2097152,
        [Obsolete("Deprecated in favour of \"RasterizationStateCreateFragmentShadingRateAttachmentBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        PipelineRasterizationStateCreateFragmentShadingRateAttachmentBitKhr = 2097152,
        [Obsolete("Deprecated in favour of \"CreateCaptureStatisticsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR")]
        PipelineCreateCaptureStatisticsBitKhr = 64,
        [Obsolete("Deprecated in favour of \"CreateCaptureInternalRepresentationsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
        PipelineCreateCaptureInternalRepresentationsBitKhr = 128,
        [Obsolete("Deprecated in favour of \"CreateIndirectBindableBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV")]
        PipelineCreateIndirectBindableBitNV = 262144,
        [Obsolete("Deprecated in favour of \"CreateLibraryBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_LIBRARY_BIT_KHR")]
        PipelineCreateLibraryBitKhr = 2048,
        [Obsolete("Deprecated in favour of \"CreateFailOnPipelineCompileRequiredBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT")]
        PipelineCreateFailOnPipelineCompileRequiredBitExt = 256,
        [Obsolete("Deprecated in favour of \"CreateEarlyReturnOnFailureBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT")]
        PipelineCreateEarlyReturnOnFailureBitExt = 512,
        [Obsolete("Deprecated in favour of \"CreateDescriptorBufferBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_DESCRIPTOR_BUFFER_BIT_EXT")]
        PipelineCreateDescriptorBufferBitExt = 536870912,
        [Obsolete("Deprecated in favour of \"CreateRetainLinkTimeOptimizationInfoBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
        PipelineCreateRetainLinkTimeOptimizationInfoBitExt = 8388608,
        [Obsolete("Deprecated in favour of \"CreateLinkTimeOptimizationBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT")]
        PipelineCreateLinkTimeOptimizationBitExt = 1024,
        [Obsolete("Deprecated in favour of \"CreateRayTracingAllowMotionBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
        PipelineCreateRayTracingAllowMotionBitNV = 1048576,
        [Obsolete("Deprecated in favour of \"CreateColorAttachmentFeedbackLoopBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        PipelineCreateColorAttachmentFeedbackLoopBitExt = 33554432,
        [Obsolete("Deprecated in favour of \"CreateDepthStencilAttachmentFeedbackLoopBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        PipelineCreateDepthStencilAttachmentFeedbackLoopBitExt = 67108864,
        [Obsolete("Deprecated in favour of \"CreateRayTracingOpacityMicromapBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
        PipelineCreateRayTracingOpacityMicromapBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"CreateRayTracingDisplacementMicromapBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV")]
        PipelineCreateRayTracingDisplacementMicromapBitNV = 268435456,
        [Obsolete("Deprecated in favour of \"CreateNoProtectedAccessBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT_EXT")]
        PipelineCreateNoProtectedAccessBitExt = 134217728,
        [Obsolete("Deprecated in favour of \"CreateProtectedAccessOnlyBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT_EXT")]
        PipelineCreateProtectedAccessOnlyBitExt = 1073741824,
        [Obsolete("Deprecated in favour of \"CreateViewIndexFromDeviceIndexBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
        PipelineCreateViewIndexFromDeviceIndexBit = 8,
        [Obsolete("Deprecated in favour of \"CreateDispatchBaseBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_DISPATCH_BASE_BIT")]
        PipelineCreateDispatchBaseBit = 16,
        [Obsolete("Deprecated in favour of \"CreateDispatchBase\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_DISPATCH_BASE")]
        PipelineCreateDispatchBase = 16,
        [Obsolete("Deprecated in favour of \"CreateFailOnPipelineCompileRequiredBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT")]
        PipelineCreateFailOnPipelineCompileRequiredBit = 256,
        [Obsolete("Deprecated in favour of \"CreateEarlyReturnOnFailureBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT")]
        PipelineCreateEarlyReturnOnFailureBit = 512,
        [NativeName("Name", "VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT")]
        CreateDisableOptimizationBit = 1,
        [NativeName("Name", "VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT")]
        CreateAllowDerivativesBit = 2,
        [NativeName("Name", "VK_PIPELINE_CREATE_DERIVATIVE_BIT")]
        CreateDerivativeBit = 4,
        [NativeName("Name", "VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR")]
        CreateViewIndexFromDeviceIndexBitKhr = 8,
        [NativeName("Name", "VK_PIPELINE_CREATE_DISPATCH_BASE_KHR")]
        CreateDispatchBaseKhr = 16,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
        CreateRayTracingNoNullAnyHitShadersBitKhr = 16384,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
        CreateRayTracingNoNullClosestHitShadersBitKhr = 32768,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
        CreateRayTracingNoNullMissShadersBitKhr = 65536,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
        CreateRayTracingNoNullIntersectionShadersBitKhr = 131072,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
        CreateRayTracingSkipTrianglesBitKhr = 4096,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
        CreateRayTracingSkipAabbsBitKhr = 8192,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
        CreateRayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        [NativeName("Name", "VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV")]
        CreateDeferCompileBitNV = 32,
        [NativeName("Name", "VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
        CreateRenderingFragmentDensityMapAttachmentBitExt = 4194304,
        [NativeName("Name", "VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
        RasterizationStateCreateFragmentDensityMapAttachmentBitExt = 4194304,
        [NativeName("Name", "VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        CreateRenderingFragmentShadingRateAttachmentBitKhr = 2097152,
        [NativeName("Name", "VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        RasterizationStateCreateFragmentShadingRateAttachmentBitKhr = 2097152,
        [NativeName("Name", "VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR")]
        CreateCaptureStatisticsBitKhr = 64,
        [NativeName("Name", "VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
        CreateCaptureInternalRepresentationsBitKhr = 128,
        [NativeName("Name", "VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV")]
        CreateIndirectBindableBitNV = 262144,
        [NativeName("Name", "VK_PIPELINE_CREATE_LIBRARY_BIT_KHR")]
        CreateLibraryBitKhr = 2048,
        [NativeName("Name", "VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT")]
        CreateFailOnPipelineCompileRequiredBitExt = 256,
        [NativeName("Name", "VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT")]
        CreateEarlyReturnOnFailureBitExt = 512,
        [NativeName("Name", "VK_PIPELINE_CREATE_DESCRIPTOR_BUFFER_BIT_EXT")]
        CreateDescriptorBufferBitExt = 536870912,
        [NativeName("Name", "VK_PIPELINE_CREATE_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
        CreateRetainLinkTimeOptimizationInfoBitExt = 8388608,
        [NativeName("Name", "VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT")]
        CreateLinkTimeOptimizationBitExt = 1024,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
        CreateRayTracingAllowMotionBitNV = 1048576,
        [NativeName("Name", "VK_PIPELINE_CREATE_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        CreateColorAttachmentFeedbackLoopBitExt = 33554432,
        [NativeName("Name", "VK_PIPELINE_CREATE_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        CreateDepthStencilAttachmentFeedbackLoopBitExt = 67108864,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
        CreateRayTracingOpacityMicromapBitExt = 16777216,
        [NativeName("Name", "VK_PIPELINE_CREATE_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV")]
        CreateRayTracingDisplacementMicromapBitNV = 268435456,
        [NativeName("Name", "VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT_EXT")]
        CreateNoProtectedAccessBitExt = 134217728,
        [NativeName("Name", "VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT_EXT")]
        CreateProtectedAccessOnlyBitExt = 1073741824,
        [NativeName("Name", "VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
        CreateViewIndexFromDeviceIndexBit = 8,
        [NativeName("Name", "VK_PIPELINE_CREATE_DISPATCH_BASE_BIT")]
        CreateDispatchBaseBit = 16,
        [NativeName("Name", "VK_PIPELINE_CREATE_DISPATCH_BASE")]
        CreateDispatchBase = 16,
        [NativeName("Name", "VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT")]
        CreateFailOnPipelineCompileRequiredBit = 256,
        [NativeName("Name", "VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT")]
        CreateEarlyReturnOnFailureBit = 512,
    }
}
