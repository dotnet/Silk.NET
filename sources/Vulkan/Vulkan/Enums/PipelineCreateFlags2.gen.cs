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

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_BUILT_IN_PRIMITIVES_BIT_KHR")]
    RayTracingSkipBuiltInPrimitivesBitkhr = 0x1000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_SPHERES_AND_LINEAR_SWEPT_SPHERES_BIT_NV")]
    RayTracingAllowSpheresAndLinearSweptSpheresBitnv = 0x200000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_ENABLE_LEGACY_DITHERING_BIT_EXT")]
    EnableLegacyDitheringBitext = 0x400000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT_KHR")]
    DisableOptimizationBitkhr = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT_KHR")]
    AllowDerivativesBitkhr = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_DERIVATIVE_BIT_KHR")]
    DerivativeBitkhr = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR")]
    ViewIndexFromDeviceIndexBitkhr = 0x8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT_KHR")]
    DispatchBaseBitkhr = 0x10,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_DEFER_COMPILE_BIT_NV")]
    DeferCompileBitnv = 0x20,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_CAPTURE_STATISTICS_BIT_KHR")]
    CaptureStatisticsBitkhr = 0x40,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
    CaptureInternalRepresentationsBitkhr = 0x80,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_KHR")]
    FailOnPipelineCompileRequiredBitkhr = 0x100,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT_KHR")]
    EarlyReturnOnFailureBitkhr = 0x200,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_LINK_TIME_OPTIMIZATION_BIT_EXT")]
    LinkTimeOptimizationBitext = 0x400,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
    RetainLinkTimeOptimizationInfoBitext = 0x800000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_LIBRARY_BIT_KHR")]
    LibraryBitkhr = 0x800,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
    RayTracingSkipTrianglesBitkhr = 0x1000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
    RayTracingSkipAabbsBitkhr = 0x2000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
    RayTracingNoNullAnyHitShadersBitkhr = 0x4000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
    RayTracingNoNullClosestHitShadersBitkhr = 0x8000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
    RayTracingNoNullMissShadersBitkhr = 0x10000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
    RayTracingNoNullIntersectionShadersBitkhr = 0x20000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
    RayTracingShaderGroupHandleCaptureReplayBitkhr = 0x80000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_NV")]
    IndirectBindableBitnv = 0x40000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
    RayTracingAllowMotionBitnv = 0x100000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    RenderingFragmentShadingRateAttachmentBitkhr = 0x200000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
    RenderingFragmentDensityMapAttachmentBitext = 0x400000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
    RayTracingOpacityMicromapBitext = 0x1000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    ColorAttachmentFeedbackLoopBitext = 0x2000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    DepthStencilAttachmentFeedbackLoopBitext = 0x4000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT_EXT")]
    NoProtectedAccessBitext = 0x8000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT_EXT")]
    ProtectedAccessOnlyBitext = 0x40000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV")]
    RayTracingDisplacementMicromapBitnv = 0x10000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_DESCRIPTOR_BUFFER_BIT_EXT")]
    DescriptorBufferBitext = 0x20000000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_DISALLOW_OPACITY_MICROMAP_BIT_ARM")]
    DisallowOpacityMicromapBitarm = 0x2000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_CAPTURE_DATA_BIT_KHR")]
    CaptureDataBitkhr = 0x80000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_EXT")]
    IndirectBindableBitext = 0x4000000000,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
    PerLayerFragmentDensityBitvalve = 0x10000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_2_64_BIT_INDEXING_BIT_EXT")]
    X64BitIndexingBitext = 0x80000000000,
}
