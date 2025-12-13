// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineCreateFlags2")]
    public enum PipelineCreateFlags2 : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Vk2DisableOptimizationBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT")]
        PipelineCreate2DisableOptimizationBit = 1,
        [Obsolete("Deprecated in favour of \"Vk2AllowDerivativesBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT")]
        PipelineCreate2AllowDerivativesBit = 2,
        [Obsolete("Deprecated in favour of \"Vk2DerivativeBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DERIVATIVE_BIT")]
        PipelineCreate2DerivativeBit = 4,
        [Obsolete("Deprecated in favour of \"Vk2ViewIndexFromDeviceIndexBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
        PipelineCreate2ViewIndexFromDeviceIndexBit = 8,
        [Obsolete("Deprecated in favour of \"Vk2DispatchBaseBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT")]
        PipelineCreate2DispatchBaseBit = 16,
        [Obsolete("Deprecated in favour of \"Vk2FailOnPipelineCompileRequiredBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT")]
        PipelineCreate2FailOnPipelineCompileRequiredBit = 256,
        [Obsolete("Deprecated in favour of \"Vk2EarlyReturnOnFailureBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT")]
        PipelineCreate2EarlyReturnOnFailureBit = 512,
        [Obsolete("Deprecated in favour of \"Vk2NoProtectedAccessBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT")]
        PipelineCreate2NoProtectedAccessBit = 134217728,
        [Obsolete("Deprecated in favour of \"Vk2ProtectedAccessOnlyBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT")]
        PipelineCreate2ProtectedAccessOnlyBit = 1073741824,
        [Obsolete("Deprecated in favour of \"Vk2ExecutionGraphBitAmdx\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_EXECUTION_GRAPH_BIT_AMDX")]
        PipelineCreate2ExecutionGraphBitAmdx = 4294967296,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingSkipBuiltInPrimitivesBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_BUILT_IN_PRIMITIVES_BIT_KHR")]
        PipelineCreate2RayTracingSkipBuiltInPrimitivesBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingAllowSpheresAndLinearSweptSpheresBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_SPHERES_AND_LINEAR_SWEPT_SPHERES_BIT_NV")]
        PipelineCreate2RayTracingAllowSpheresAndLinearSweptSpheresBitNV = 8589934592,
        [Obsolete("Deprecated in favour of \"Vk2EnableLegacyDitheringBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_ENABLE_LEGACY_DITHERING_BIT_EXT")]
        PipelineCreate2EnableLegacyDitheringBitExt = 17179869184,
        [Obsolete("Deprecated in favour of \"Vk2DeferCompileBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DEFER_COMPILE_BIT_NV")]
        PipelineCreate2DeferCompileBitNV = 32,
        [Obsolete("Deprecated in favour of \"Vk2CaptureStatisticsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_STATISTICS_BIT_KHR")]
        PipelineCreate2CaptureStatisticsBitKhr = 64,
        [Obsolete("Deprecated in favour of \"Vk2CaptureInternalRepresentationsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
        PipelineCreate2CaptureInternalRepresentationsBitKhr = 128,
        [Obsolete("Deprecated in favour of \"Vk2LinkTimeOptimizationBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_LINK_TIME_OPTIMIZATION_BIT_EXT")]
        PipelineCreate2LinkTimeOptimizationBitExt = 1024,
        [Obsolete("Deprecated in favour of \"Vk2RetainLinkTimeOptimizationInfoBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
        PipelineCreate2RetainLinkTimeOptimizationInfoBitExt = 8388608,
        [Obsolete("Deprecated in favour of \"Vk2LibraryBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_LIBRARY_BIT_KHR")]
        PipelineCreate2LibraryBitKhr = 2048,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingSkipTrianglesBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
        PipelineCreate2RayTracingSkipTrianglesBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingSkipAabbsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
        PipelineCreate2RayTracingSkipAabbsBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingNoNullAnyHitShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
        PipelineCreate2RayTracingNoNullAnyHitShadersBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingNoNullClosestHitShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
        PipelineCreate2RayTracingNoNullClosestHitShadersBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingNoNullMissShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
        PipelineCreate2RayTracingNoNullMissShadersBitKhr = 65536,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingNoNullIntersectionShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
        PipelineCreate2RayTracingNoNullIntersectionShadersBitKhr = 131072,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingShaderGroupHandleCaptureReplayBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
        PipelineCreate2RayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        [Obsolete("Deprecated in favour of \"Vk2IndirectBindableBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_NV")]
        PipelineCreate2IndirectBindableBitNV = 262144,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingAllowMotionBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
        PipelineCreate2RayTracingAllowMotionBitNV = 1048576,
        [Obsolete("Deprecated in favour of \"Vk2RenderingFragmentShadingRateAttachmentBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        PipelineCreate2RenderingFragmentShadingRateAttachmentBitKhr = 2097152,
        [Obsolete("Deprecated in favour of \"Vk2RenderingFragmentDensityMapAttachmentBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
        PipelineCreate2RenderingFragmentDensityMapAttachmentBitExt = 4194304,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingOpacityMicromapBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
        PipelineCreate2RayTracingOpacityMicromapBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"Vk2ColorAttachmentFeedbackLoopBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        PipelineCreate2ColorAttachmentFeedbackLoopBitExt = 33554432,
        [Obsolete("Deprecated in favour of \"Vk2DepthStencilAttachmentFeedbackLoopBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        PipelineCreate2DepthStencilAttachmentFeedbackLoopBitExt = 67108864,
        [Obsolete("Deprecated in favour of \"Vk2RayTracingDisplacementMicromapBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV")]
        PipelineCreate2RayTracingDisplacementMicromapBitNV = 268435456,
        [Obsolete("Deprecated in favour of \"Vk2DescriptorBufferBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DESCRIPTOR_BUFFER_BIT_EXT")]
        PipelineCreate2DescriptorBufferBitExt = 536870912,
        [Obsolete("Deprecated in favour of \"Vk2DisallowOpacityMicromapBitArm\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISALLOW_OPACITY_MICROMAP_BIT_ARM")]
        PipelineCreate2DisallowOpacityMicromapBitArm = 137438953472,
        [Obsolete("Deprecated in favour of \"Vk2CaptureDataBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_DATA_BIT_KHR")]
        PipelineCreate2CaptureDataBitKhr = 2147483648,
        [Obsolete("Deprecated in favour of \"Vk2IndirectBindableBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_EXT")]
        PipelineCreate2IndirectBindableBitExt = 274877906944,
        [Obsolete("Deprecated in favour of \"Vk2PerLayerFragmentDensityBitValve\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
        PipelineCreate2PerLayerFragmentDensityBitValve = 1099511627776,
        [Obsolete("Deprecated in favour of \"Vk264BitIndexingBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_64_BIT_INDEXING_BIT_EXT")]
        PipelineCreate264BitIndexingBitExt = 8796093022208,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT")]
        Vk2DisableOptimizationBit = 1,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT")]
        Vk2AllowDerivativesBit = 2,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DERIVATIVE_BIT")]
        Vk2DerivativeBit = 4,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
        Vk2ViewIndexFromDeviceIndexBit = 8,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT")]
        Vk2DispatchBaseBit = 16,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT")]
        Vk2FailOnPipelineCompileRequiredBit = 256,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT")]
        Vk2EarlyReturnOnFailureBit = 512,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT")]
        Vk2NoProtectedAccessBit = 134217728,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT")]
        Vk2ProtectedAccessOnlyBit = 1073741824,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_EXECUTION_GRAPH_BIT_AMDX")]
        Vk2ExecutionGraphBitAmdx = 4294967296,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_BUILT_IN_PRIMITIVES_BIT_KHR")]
        Vk2RayTracingSkipBuiltInPrimitivesBitKhr = 4096,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_SPHERES_AND_LINEAR_SWEPT_SPHERES_BIT_NV")]
        Vk2RayTracingAllowSpheresAndLinearSweptSpheresBitNV = 8589934592,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_ENABLE_LEGACY_DITHERING_BIT_EXT")]
        Vk2EnableLegacyDitheringBitExt = 17179869184,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DEFER_COMPILE_BIT_NV")]
        Vk2DeferCompileBitNV = 32,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_STATISTICS_BIT_KHR")]
        Vk2CaptureStatisticsBitKhr = 64,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
        Vk2CaptureInternalRepresentationsBitKhr = 128,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_LINK_TIME_OPTIMIZATION_BIT_EXT")]
        Vk2LinkTimeOptimizationBitExt = 1024,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
        Vk2RetainLinkTimeOptimizationInfoBitExt = 8388608,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_LIBRARY_BIT_KHR")]
        Vk2LibraryBitKhr = 2048,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
        Vk2RayTracingSkipTrianglesBitKhr = 4096,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
        Vk2RayTracingSkipAabbsBitKhr = 8192,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
        Vk2RayTracingNoNullAnyHitShadersBitKhr = 16384,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
        Vk2RayTracingNoNullClosestHitShadersBitKhr = 32768,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
        Vk2RayTracingNoNullMissShadersBitKhr = 65536,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
        Vk2RayTracingNoNullIntersectionShadersBitKhr = 131072,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
        Vk2RayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_NV")]
        Vk2IndirectBindableBitNV = 262144,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
        Vk2RayTracingAllowMotionBitNV = 1048576,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        Vk2RenderingFragmentShadingRateAttachmentBitKhr = 2097152,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
        Vk2RenderingFragmentDensityMapAttachmentBitExt = 4194304,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
        Vk2RayTracingOpacityMicromapBitExt = 16777216,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        Vk2ColorAttachmentFeedbackLoopBitExt = 33554432,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        Vk2DepthStencilAttachmentFeedbackLoopBitExt = 67108864,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV")]
        Vk2RayTracingDisplacementMicromapBitNV = 268435456,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DESCRIPTOR_BUFFER_BIT_EXT")]
        Vk2DescriptorBufferBitExt = 536870912,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISALLOW_OPACITY_MICROMAP_BIT_ARM")]
        Vk2DisallowOpacityMicromapBitArm = 137438953472,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_CAPTURE_DATA_BIT_KHR")]
        Vk2CaptureDataBitKhr = 2147483648,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_EXT")]
        Vk2IndirectBindableBitExt = 274877906944,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
        Vk2PerLayerFragmentDensityBitValve = 1099511627776,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_64_BIT_INDEXING_BIT_EXT")]
        Vk264BitIndexingBitExt = 8796093022208,
    }
}
