// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineCreateFlagBits")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum PipelineCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    DisableOptimizationBit = 0x1,

    [NativeName("VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    AllowDerivativesBit = 0x2,

    [NativeName("VK_PIPELINE_CREATE_DERIVATIVE_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    DerivativeBit = 0x4,

    [NativeName("VK_PIPELINE_CREATE_DISPATCH_BASE_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    DispatchBaseBit = 0x10,

    [NativeName("VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    ViewIndexFromDeviceIndexBit = 0x8,

    [NativeName("VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    FailOnPipelineCompileRequiredBit = 0x100,

    [NativeName("VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    EarlyReturnOnFailureBit = 0x200,

    [NativeName("VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    NoProtectedAccessBit = 0x8000000,

    [NativeName("VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    ProtectedAccessOnlyBit = 0x40000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingNoNullAnyHitShadersBitkhr = 0x4000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingNoNullClosestHitShadersBitkhr = 0x8000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingNoNullMissShadersBitkhr = 0x10000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingNoNullIntersectionShadersBitkhr = 0x20000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingSkipTrianglesBitkhr = 0x1000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingSkipAabbsBitkhr = 0x2000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingShaderGroupHandleCaptureReplayBitkhr = 0x80000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    DeferCompileBitnv = 0x20,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_fragment_density_map+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    RenderingFragmentDensityMapAttachmentBitext = 0x400000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_fragment_shading_rate+VK_KHR_dynamic_rendering",
            "VK_KHR_fragment_shading_rate+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    RenderingFragmentShadingRateAttachmentBitkhr = 0x200000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    CaptureStatisticsBitkhr = 0x40,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    CaptureInternalRepresentationsBitkhr = 0x80,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    IndirectBindableBitnv = 0x40000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_LIBRARY_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    LibraryBitkhr = 0x800,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_DESCRIPTOR_BUFFER_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    DescriptorBufferBitext = 0x20000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    RetainLinkTimeOptimizationInfoBitext = 0x800000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    LinkTimeOptimizationBitext = 0x400,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_ALLOW_MOTION_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    RayTracingAllowMotionBitnv = 0x100000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_layout"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    ColorAttachmentFeedbackLoopBitext = 0x2000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_layout"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    DepthStencilAttachmentFeedbackLoopBitext = 0x4000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    RayTracingOpacityMicromapBitext = 0x1000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    ViewIndexFromDeviceIndexBitkhr = ViewIndexFromDeviceIndexBit,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_CREATE_DISPATCH_BASE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    DispatchBaseBitkhr = DispatchBaseBit,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_creation_cache_control"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        ]
    )]
    FailOnPipelineCompileRequiredBitext = FailOnPipelineCompileRequiredBit,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_creation_cache_control"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        ]
    )]
    EarlyReturnOnFailureBitext = EarlyReturnOnFailureBit,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_protected_access"],
        ImpliesSets = [
            "VK_EXT_pipeline_protected_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_protected_access+VK_VERSION_1_1",
        ]
    )]
    NoProtectedAccessBitext = NoProtectedAccessBit,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_protected_access"],
        ImpliesSets = [
            "VK_EXT_pipeline_protected_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_protected_access+VK_VERSION_1_1",
        ]
    )]
    ProtectedAccessOnlyBitext = ProtectedAccessOnlyBit,
}
