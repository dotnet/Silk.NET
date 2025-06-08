// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkPipelineCreateFlags
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_PIPELINE_CREATE_DERIVATIVE_BIT = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_PIPELINE_CREATE_DISPATCH_BASE_BIT = 0x00000010,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT = 0x00000100,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT = 0x00000200,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT = 0x08000000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT = 0x40000000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR = 0x00004000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR = 0x00008000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR = 0x00010000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR = 0x00020000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR = 0x00001000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR = 0x00002000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR = 0x00080000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV = 0x00000020,

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
    VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = 0x00400000,

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
    VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00200000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR = 0x00000040,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR = 0x00000080,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV = 0x00040000,

    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    VK_PIPELINE_CREATE_LIBRARY_BIT_KHR = 0x00000800,

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
    VK_PIPELINE_CREATE_DESCRIPTOR_BUFFER_BIT_EXT = 0x20000000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT = 0x00800000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT = 0x00000400,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VK_PIPELINE_CREATE_RAY_TRACING_ALLOW_MOTION_BIT_NV = 0x00100000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_layout"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 0x02000000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_layout"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 0x04000000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_PIPELINE_CREATE_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT = 0x01000000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_PIPELINE_CREATE_DISPATCH_BASE = VK_PIPELINE_CREATE_DISPATCH_BASE_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR =
        VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VK_PIPELINE_CREATE_DISPATCH_BASE_KHR = VK_PIPELINE_CREATE_DISPATCH_BASE,

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
    VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT =
        VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT,

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
    VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR =
        VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_creation_cache_control"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT =
        VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_creation_cache_control"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT =
        VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_protected_access"],
        ImpliesSets = [
            "VK_EXT_pipeline_protected_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_protected_access+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT_EXT = VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_protected_access"],
        ImpliesSets = [
            "VK_EXT_pipeline_protected_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_protected_access+VK_VERSION_1_1",
        ]
    )]
    VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT_EXT = VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_PIPELINE_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
