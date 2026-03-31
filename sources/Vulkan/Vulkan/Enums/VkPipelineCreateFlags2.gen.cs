// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineCreateFlags2")]
[Transformed]
[Flags]
public enum VkPipelineCreateFlags2 : ulong
{
    [NativeName("VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT")]
    VkPipelineCreate2DisableOptimizationBit = unchecked((ulong)0x00000001UL),

    [NativeName("VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT")]
    VkPipelineCreate2AllowDerivativesBit = unchecked((ulong)0x00000002UL),

    [NativeName("VK_PIPELINE_CREATE_2_DERIVATIVE_BIT")]
    VkPipelineCreate2DerivativeBit = unchecked((ulong)0x00000004UL),

    [NativeName("VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
    VkPipelineCreate2ViewIndexFromDeviceIndexBit = unchecked((ulong)0x00000008UL),

    [NativeName("VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT")]
    VkPipelineCreate2DispatchBaseBit = unchecked((ulong)0x00000010UL),

    [NativeName("VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT")]
    VkPipelineCreate2FailOnPipelineCompileRequiredBit = unchecked((ulong)0x00000100UL),

    [NativeName("VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT")]
    VkPipelineCreate2EarlyReturnOnFailureBit = unchecked((ulong)0x00000200UL),

    [NativeName("VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT")]
    VkPipelineCreate2NoProtectedAccessBit = unchecked((ulong)0x08000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT")]
    VkPipelineCreate2ProtectedAccessOnlyBit = unchecked((ulong)0x40000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_BUILT_IN_PRIMITIVES_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2RayTracingSkipBuiltInPrimitivesBitKHR = unchecked((ulong)0x00001000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_SPHERES_AND_LINEAR_SWEPT_SPHERES_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineCreate2RayTracingAllowSpheresAndLinearSweptSpheresBitNV =
        unchecked((ulong)0x200000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_ENABLE_LEGACY_DITHERING_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2EnableLegacyDitheringBitEXT = unchecked((ulong)0x400000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2DisableOptimizationBitKHR = unchecked((ulong)0x00000001UL),

    [NativeName("VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2AllowDerivativesBitKHR = unchecked((ulong)0x00000002UL),

    [NativeName("VK_PIPELINE_CREATE_2_DERIVATIVE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2DerivativeBitKHR = unchecked((ulong)0x00000004UL),

    [NativeName("VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2ViewIndexFromDeviceIndexBitKHR = unchecked((ulong)0x00000008UL),

    [NativeName("VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2DispatchBaseBitKHR = unchecked((ulong)0x00000010UL),

    [NativeName("VK_PIPELINE_CREATE_2_DEFER_COMPILE_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineCreate2DeferCompileBitNV = unchecked((ulong)0x00000020UL),

    [NativeName("VK_PIPELINE_CREATE_2_CAPTURE_STATISTICS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2CaptureStatisticsBitKHR = unchecked((ulong)0x00000040UL),

    [NativeName("VK_PIPELINE_CREATE_2_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2CaptureInternalRepresentationsBitKHR = unchecked((ulong)0x00000080UL),

    [NativeName("VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2FailOnPipelineCompileRequiredBitKHR = unchecked((ulong)0x00000100UL),

    [NativeName("VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2EarlyReturnOnFailureBitKHR = unchecked((ulong)0x00000200UL),

    [NativeName("VK_PIPELINE_CREATE_2_LINK_TIME_OPTIMIZATION_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2LinkTimeOptimizationBitEXT = unchecked((ulong)0x00000400UL),

    [NativeName("VK_PIPELINE_CREATE_2_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2RetainLinkTimeOptimizationInfoBitEXT = unchecked((ulong)0x00800000UL),

    [NativeName("VK_PIPELINE_CREATE_2_LIBRARY_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2LibraryBitKHR = unchecked((ulong)0x00000800UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2RayTracingSkipTrianglesBitKHR = unchecked((ulong)0x00001000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2RayTracingSkipAabbsBitKHR = unchecked((ulong)0x00002000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2RayTracingNoNullAnyHitShadersBitKHR = unchecked((ulong)0x00004000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2RayTracingNoNullClosestHitShadersBitKHR = unchecked((ulong)0x00008000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2RayTracingNoNullMissShadersBitKHR = unchecked((ulong)0x00010000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2RayTracingNoNullIntersectionShadersBitKHR = unchecked((ulong)0x00020000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2RayTracingShaderGroupHandleCaptureReplayBitKHR =
        unchecked((ulong)0x00080000UL),

    [NativeName("VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineCreate2IndirectBindableBitNV = unchecked((ulong)0x00040000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineCreate2RayTracingAllowMotionBitNV = unchecked((ulong)0x00100000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2RenderingFragmentShadingRateAttachmentBitKHR = unchecked((ulong)0x00200000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2RenderingFragmentDensityMapAttachmentBitEXT = unchecked((ulong)0x00400000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2RayTracingOpacityMicromapBitEXT = unchecked((ulong)0x01000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2ColorAttachmentFeedbackLoopBitEXT = unchecked((ulong)0x02000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2DepthStencilAttachmentFeedbackLoopBitEXT = unchecked((ulong)0x04000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2NoProtectedAccessBitEXT = unchecked((ulong)0x08000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2ProtectedAccessOnlyBitEXT = unchecked((ulong)0x40000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineCreate2RayTracingDisplacementMicromapBitNV = unchecked((ulong)0x10000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_DESCRIPTOR_BUFFER_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2DescriptorBufferBitEXT = unchecked((ulong)0x20000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_DISALLOW_OPACITY_MICROMAP_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    VkPipelineCreate2DisallowOpacityMicromapBitARM = unchecked((ulong)0x2000000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_CAPTURE_DATA_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineCreate2CaptureDataBitKHR = unchecked((ulong)0x80000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2IndirectBindableBitEXT = unchecked((ulong)0x4000000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    VkPipelineCreate2PerLayerFragmentDensityBitVALVE = unchecked((ulong)0x10000000000UL),

    [NativeName("VK_PIPELINE_CREATE_2_64_BIT_INDEXING_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineCreate2x64BitIndexingBitEXT = unchecked((ulong)0x80000000000UL),
}
