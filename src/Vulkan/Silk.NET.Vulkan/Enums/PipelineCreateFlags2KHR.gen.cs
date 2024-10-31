// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineCreateFlags2KHR")]
    public enum PipelineCreateFlags2KHR : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DisableOptimizationBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT_KHR")]
        PipelineCreate2DisableOptimizationBitKhr = 1,
        [Obsolete("Deprecated in favour of \"AllowDerivativesBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT_KHR")]
        PipelineCreate2AllowDerivativesBitKhr = 2,
        [Obsolete("Deprecated in favour of \"DerivativeBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DERIVATIVE_BIT_KHR")]
        PipelineCreate2DerivativeBitKhr = 4,
        [Obsolete("Deprecated in favour of \"ExecutionGraphBitAmdx\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_EXECUTION_GRAPH_BIT_AMDX")]
        PipelineCreate2ExecutionGraphBitAmdx = 4294967296,
        [Obsolete("Deprecated in favour of \"EnableLegacyDitheringBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_ENABLE_LEGACY_DITHERING_BIT_EXT")]
        PipelineCreate2EnableLegacyDitheringBitExt = 17179869184,
        [Obsolete("Deprecated in favour of \"ViewIndexFromDeviceIndexBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR")]
        PipelineCreate2ViewIndexFromDeviceIndexBitKhr = 8,
        [Obsolete("Deprecated in favour of \"DispatchBaseBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT_KHR")]
        PipelineCreate2DispatchBaseBitKhr = 16,
        [Obsolete("Deprecated in favour of \"DeferCompileBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DEFER_COMPILE_BIT_NV")]
        PipelineCreate2DeferCompileBitNV = 32,
        [Obsolete("Deprecated in favour of \"CaptureStatisticsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_STATISTICS_BIT_KHR")]
        PipelineCreate2CaptureStatisticsBitKhr = 64,
        [Obsolete("Deprecated in favour of \"CaptureInternalRepresentationsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
        PipelineCreate2CaptureInternalRepresentationsBitKhr = 128,
        [Obsolete("Deprecated in favour of \"FailOnPipelineCompileRequiredBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_KHR")]
        PipelineCreate2FailOnPipelineCompileRequiredBitKhr = 256,
        [Obsolete("Deprecated in favour of \"EarlyReturnOnFailureBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT_KHR")]
        PipelineCreate2EarlyReturnOnFailureBitKhr = 512,
        [Obsolete("Deprecated in favour of \"LinkTimeOptimizationBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_LINK_TIME_OPTIMIZATION_BIT_EXT")]
        PipelineCreate2LinkTimeOptimizationBitExt = 1024,
        [Obsolete("Deprecated in favour of \"RetainLinkTimeOptimizationInfoBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
        PipelineCreate2RetainLinkTimeOptimizationInfoBitExt = 8388608,
        [Obsolete("Deprecated in favour of \"LibraryBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_LIBRARY_BIT_KHR")]
        PipelineCreate2LibraryBitKhr = 2048,
        [Obsolete("Deprecated in favour of \"RayTracingSkipTrianglesBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
        PipelineCreate2RayTracingSkipTrianglesBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"RayTracingSkipAabbsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
        PipelineCreate2RayTracingSkipAabbsBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"RayTracingNoNullAnyHitShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
        PipelineCreate2RayTracingNoNullAnyHitShadersBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"RayTracingNoNullClosestHitShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
        PipelineCreate2RayTracingNoNullClosestHitShadersBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"RayTracingNoNullMissShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
        PipelineCreate2RayTracingNoNullMissShadersBitKhr = 65536,
        [Obsolete("Deprecated in favour of \"RayTracingNoNullIntersectionShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
        PipelineCreate2RayTracingNoNullIntersectionShadersBitKhr = 131072,
        [Obsolete("Deprecated in favour of \"RayTracingShaderGroupHandleCaptureReplayBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
        PipelineCreate2RayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        [Obsolete("Deprecated in favour of \"IndirectBindableBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_NV")]
        PipelineCreate2IndirectBindableBitNV = 262144,
        [Obsolete("Deprecated in favour of \"RayTracingAllowMotionBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
        PipelineCreate2RayTracingAllowMotionBitNV = 1048576,
        [Obsolete("Deprecated in favour of \"RenderingFragmentShadingRateAttachmentBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        PipelineCreate2RenderingFragmentShadingRateAttachmentBitKhr = 2097152,
        [Obsolete("Deprecated in favour of \"RenderingFragmentDensityMapAttachmentBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
        PipelineCreate2RenderingFragmentDensityMapAttachmentBitExt = 4194304,
        [Obsolete("Deprecated in favour of \"RayTracingOpacityMicromapBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
        PipelineCreate2RayTracingOpacityMicromapBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"ColorAttachmentFeedbackLoopBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        PipelineCreate2ColorAttachmentFeedbackLoopBitExt = 33554432,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentFeedbackLoopBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        PipelineCreate2DepthStencilAttachmentFeedbackLoopBitExt = 67108864,
        [Obsolete("Deprecated in favour of \"NoProtectedAccessBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT_EXT")]
        PipelineCreate2NoProtectedAccessBitExt = 134217728,
        [Obsolete("Deprecated in favour of \"ProtectedAccessOnlyBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT_EXT")]
        PipelineCreate2ProtectedAccessOnlyBitExt = 1073741824,
        [Obsolete("Deprecated in favour of \"RayTracingDisplacementMicromapBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV")]
        PipelineCreate2RayTracingDisplacementMicromapBitNV = 268435456,
        [Obsolete("Deprecated in favour of \"DescriptorBufferBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DESCRIPTOR_BUFFER_BIT_EXT")]
        PipelineCreate2DescriptorBufferBitExt = 536870912,
        [Obsolete("Deprecated in favour of \"CaptureDataBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_DATA_BIT_KHR")]
        PipelineCreate2CaptureDataBitKhr = 2147483648,
        [Obsolete("Deprecated in favour of \"IndirectBindableBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_EXT")]
        PipelineCreate2IndirectBindableBitExt = 274877906944,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT_KHR")]
        DisableOptimizationBitKhr = 1,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT_KHR")]
        AllowDerivativesBitKhr = 2,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DERIVATIVE_BIT_KHR")]
        DerivativeBitKhr = 4,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_EXECUTION_GRAPH_BIT_AMDX")]
        ExecutionGraphBitAmdx = 4294967296,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_ENABLE_LEGACY_DITHERING_BIT_EXT")]
        EnableLegacyDitheringBitExt = 17179869184,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR")]
        ViewIndexFromDeviceIndexBitKhr = 8,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT_KHR")]
        DispatchBaseBitKhr = 16,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DEFER_COMPILE_BIT_NV")]
        DeferCompileBitNV = 32,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_STATISTICS_BIT_KHR")]
        CaptureStatisticsBitKhr = 64,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
        CaptureInternalRepresentationsBitKhr = 128,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_KHR")]
        FailOnPipelineCompileRequiredBitKhr = 256,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT_KHR")]
        EarlyReturnOnFailureBitKhr = 512,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_LINK_TIME_OPTIMIZATION_BIT_EXT")]
        LinkTimeOptimizationBitExt = 1024,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
        RetainLinkTimeOptimizationInfoBitExt = 8388608,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_LIBRARY_BIT_KHR")]
        LibraryBitKhr = 2048,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
        RayTracingSkipTrianglesBitKhr = 4096,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
        RayTracingSkipAabbsBitKhr = 8192,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
        RayTracingNoNullAnyHitShadersBitKhr = 16384,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
        RayTracingNoNullClosestHitShadersBitKhr = 32768,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
        RayTracingNoNullMissShadersBitKhr = 65536,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
        RayTracingNoNullIntersectionShadersBitKhr = 131072,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
        RayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_NV")]
        IndirectBindableBitNV = 262144,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
        RayTracingAllowMotionBitNV = 1048576,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        RenderingFragmentShadingRateAttachmentBitKhr = 2097152,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
        RenderingFragmentDensityMapAttachmentBitExt = 4194304,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
        RayTracingOpacityMicromapBitExt = 16777216,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        ColorAttachmentFeedbackLoopBitExt = 33554432,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        DepthStencilAttachmentFeedbackLoopBitExt = 67108864,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT_EXT")]
        NoProtectedAccessBitExt = 134217728,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT_EXT")]
        ProtectedAccessOnlyBitExt = 1073741824,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV")]
        RayTracingDisplacementMicromapBitNV = 268435456,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DESCRIPTOR_BUFFER_BIT_EXT")]
        DescriptorBufferBitExt = 536870912,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_DATA_BIT_KHR")]
        CaptureDataBitKhr = 2147483648,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_EXT")]
        IndirectBindableBitExt = 274877906944,
    }
}
