// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineCreateFlags2")]
[Flags]
public enum PipelineCreateFlags2 : ulong
{
    None = 0x0,

    [NativeName("VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT")]
    DisableOptimizationBit = 0x1,

    [NativeName("VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT")]
    AllowDerivativesBit = 0x2,

    [NativeName("VK_PIPELINE_CREATE_2_DERIVATIVE_BIT")]
    DerivativeBit = 0x4,

    [NativeName("VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
    ViewIndexFromDeviceIndexBit = 0x8,

    [NativeName("VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT")]
    DispatchBaseBit = 0x10,

    [NativeName("VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT")]
    FailOnPipelineCompileRequiredBit = 0x100,

    [NativeName("VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT")]
    EarlyReturnOnFailureBit = 0x200,

    [NativeName("VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT")]
    NoProtectedAccessBit = 0x8000000,

    [NativeName("VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT")]
    ProtectedAccessOnlyBit = 0x40000000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_BUILT_IN_PRIMITIVES_BIT_KHR")]
    RayTracingSkipBuiltInPrimitivesBitKHR = 0x1000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_SPHERES_AND_LINEAR_SWEPT_SPHERES_BIT_NV")]
    RayTracingAllowSpheresAndLinearSweptSpheresBitNV = 0x200000000,

    [NativeName("VK_PIPELINE_CREATE_2_ENABLE_LEGACY_DITHERING_BIT_EXT")]
    EnableLegacyDitheringBitEXT = 0x400000000,

    [NativeName("VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT_KHR")]
    DisableOptimizationBitKHR = 0x1,

    [NativeName("VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT_KHR")]
    AllowDerivativesBitKHR = 0x2,

    [NativeName("VK_PIPELINE_CREATE_2_DERIVATIVE_BIT_KHR")]
    DerivativeBitKHR = 0x4,

    [NativeName("VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR")]
    ViewIndexFromDeviceIndexBitKHR = 0x8,

    [NativeName("VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT_KHR")]
    DispatchBaseBitKHR = 0x10,

    [NativeName("VK_PIPELINE_CREATE_2_DEFER_COMPILE_BIT_NV")]
    DeferCompileBitNV = 0x20,

    [NativeName("VK_PIPELINE_CREATE_2_CAPTURE_STATISTICS_BIT_KHR")]
    CaptureStatisticsBitKHR = 0x40,

    [NativeName("VK_PIPELINE_CREATE_2_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
    CaptureInternalRepresentationsBitKHR = 0x80,

    [NativeName("VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_KHR")]
    FailOnPipelineCompileRequiredBitKHR = 0x100,

    [NativeName("VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT_KHR")]
    EarlyReturnOnFailureBitKHR = 0x200,

    [NativeName("VK_PIPELINE_CREATE_2_LINK_TIME_OPTIMIZATION_BIT_EXT")]
    LinkTimeOptimizationBitEXT = 0x400,

    [NativeName("VK_PIPELINE_CREATE_2_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
    RetainLinkTimeOptimizationInfoBitEXT = 0x800000,

    [NativeName("VK_PIPELINE_CREATE_2_LIBRARY_BIT_KHR")]
    LibraryBitKHR = 0x800,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
    RayTracingSkipTrianglesBitKHR = 0x1000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
    RayTracingSkipAabbsBitKHR = 0x2000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
    RayTracingNoNullAnyHitShadersBitKHR = 0x4000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
    RayTracingNoNullClosestHitShadersBitKHR = 0x8000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
    RayTracingNoNullMissShadersBitKHR = 0x10000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
    RayTracingNoNullIntersectionShadersBitKHR = 0x20000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
    RayTracingShaderGroupHandleCaptureReplayBitKHR = 0x80000,

    [NativeName("VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_NV")]
    IndirectBindableBitNV = 0x40000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
    RayTracingAllowMotionBitNV = 0x100000,

    [NativeName("VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    RenderingFragmentShadingRateAttachmentBitKHR = 0x200000,

    [NativeName("VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
    RenderingFragmentDensityMapAttachmentBitEXT = 0x400000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
    RayTracingOpacityMicromapBitEXT = 0x1000000,

    [NativeName("VK_PIPELINE_CREATE_2_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    ColorAttachmentFeedbackLoopBitEXT = 0x2000000,

    [NativeName("VK_PIPELINE_CREATE_2_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    DepthStencilAttachmentFeedbackLoopBitEXT = 0x4000000,

    [NativeName("VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT_EXT")]
    NoProtectedAccessBitEXT = 0x8000000,

    [NativeName("VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT_EXT")]
    ProtectedAccessOnlyBitEXT = 0x40000000,

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV")]
    RayTracingDisplacementMicromapBitNV = 0x10000000,

    [NativeName("VK_PIPELINE_CREATE_2_DESCRIPTOR_BUFFER_BIT_EXT")]
    DescriptorBufferBitEXT = 0x20000000,

    [NativeName("VK_PIPELINE_CREATE_2_DISALLOW_OPACITY_MICROMAP_BIT_ARM")]
    DisallowOpacityMicromapBitARM = 0x2000000000,

    [NativeName("VK_PIPELINE_CREATE_2_CAPTURE_DATA_BIT_KHR")]
    CaptureDataBitKHR = 0x80000000,

    [NativeName("VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_EXT")]
    IndirectBindableBitEXT = 0x4000000000,

    [NativeName("VK_PIPELINE_CREATE_2_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
    PerLayerFragmentDensityBitValve = 0x10000000000,

    [NativeName("VK_PIPELINE_CREATE_2_64_BIT_INDEXING_BIT_EXT")]
    X64BitIndexingBitEXT = 0x80000000000,
}
