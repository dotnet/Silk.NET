// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineCreateFlags")]
[Flags]
public enum PipelineCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT")]
    DisableOptimizationBit = 0x1,

    [NativeName("VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT")]
    AllowDerivativesBit = 0x2,

    [NativeName("VK_PIPELINE_CREATE_DERIVATIVE_BIT")]
    DerivativeBit = 0x4,

    [NativeName("VK_PIPELINE_CREATE_DISPATCH_BASE_BIT")]
    DispatchBaseBit = 0x10,

    [NativeName("VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
    ViewIndexFromDeviceIndexBit = 0x8,

    [NativeName("VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT")]
    FailOnPipelineCompileRequiredBit = 0x100,

    [NativeName("VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT")]
    EarlyReturnOnFailureBit = 0x200,

    [NativeName("VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT")]
    NoProtectedAccessBit = 0x8000000,

    [NativeName("VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT")]
    ProtectedAccessOnlyBit = 0x40000000,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
    RayTracingNoNullAnyHitShadersBitKHR = 0x4000,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
    RayTracingNoNullClosestHitShadersBitKHR = 0x8000,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
    RayTracingNoNullMissShadersBitKHR = 0x10000,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
    RayTracingNoNullIntersectionShadersBitKHR = 0x20000,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
    RayTracingSkipTrianglesBitKHR = 0x1000,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
    RayTracingSkipAabbsBitKHR = 0x2000,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
    RayTracingShaderGroupHandleCaptureReplayBitKHR = 0x80000,

    [NativeName("VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV")]
    DeferCompileBitNV = 0x20,

    [NativeName("VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
    RenderingFragmentDensityMapAttachmentBitEXT = 0x400000,

    [NativeName("VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    RenderingFragmentShadingRateAttachmentBitKHR = 0x200000,

    [NativeName("VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR")]
    CaptureStatisticsBitKHR = 0x40,

    [NativeName("VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
    CaptureInternalRepresentationsBitKHR = 0x80,

    [NativeName("VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV")]
    IndirectBindableBitNV = 0x40000,

    [NativeName("VK_PIPELINE_CREATE_LIBRARY_BIT_KHR")]
    LibraryBitKHR = 0x800,

    [NativeName("VK_PIPELINE_CREATE_DESCRIPTOR_BUFFER_BIT_EXT")]
    DescriptorBufferBitEXT = 0x20000000,

    [NativeName("VK_PIPELINE_CREATE_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
    RetainLinkTimeOptimizationInfoBitEXT = 0x800000,

    [NativeName("VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT")]
    LinkTimeOptimizationBitEXT = 0x400,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
    RayTracingAllowMotionBitNV = 0x100000,

    [NativeName("VK_PIPELINE_CREATE_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    ColorAttachmentFeedbackLoopBitEXT = 0x2000000,

    [NativeName("VK_PIPELINE_CREATE_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    DepthStencilAttachmentFeedbackLoopBitEXT = 0x4000000,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV")]
    RayTracingDisplacementMicromapBitNV = 0x10000000,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_OPACITY_MICROMAP_BIT_KHR")]
    RayTracingOpacityMicromapBitKHR = 0x1000000,

    [NativeName("VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR")]
    ViewIndexFromDeviceIndexBitKHR = ViewIndexFromDeviceIndexBit,

    [NativeName("VK_PIPELINE_CREATE_DISPATCH_BASE_BIT_KHR")]
    DispatchBaseBitKHR = DispatchBaseBit,

    [NativeName("VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT")]
    FailOnPipelineCompileRequiredBitEXT = FailOnPipelineCompileRequiredBit,

    [NativeName("VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT")]
    EarlyReturnOnFailureBitEXT = EarlyReturnOnFailureBit,

    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
    RayTracingOpacityMicromapBitEXT = RayTracingOpacityMicromapBitKHR,

    [NativeName("VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT_EXT")]
    NoProtectedAccessBitEXT = NoProtectedAccessBit,

    [NativeName("VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT_EXT")]
    ProtectedAccessOnlyBitEXT = ProtectedAccessOnlyBit,
}
