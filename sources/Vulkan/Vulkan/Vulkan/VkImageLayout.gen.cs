// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkImageLayout
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_IMAGE_LAYOUT_UNDEFINED = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_IMAGE_LAYOUT_GENERAL = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL = 4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL = 5,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL = 6,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL = 7,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_IMAGE_LAYOUT_PREINITIALIZED = 8,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL = 1000117000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL = 1000117001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL = 1000241000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL = 1000241001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL = 1000241002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL = 1000241003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL = 1000314000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL = 1000314001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ = 1000232000,

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    VK_IMAGE_LAYOUT_PRESENT_SRC_KHR = 1000001002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_IMAGE_LAYOUT_VIDEO_DECODE_DST_KHR = 1000024000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_IMAGE_LAYOUT_VIDEO_DECODE_SRC_KHR = 1000024001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_IMAGE_LAYOUT_VIDEO_DECODE_DPB_KHR = 1000024002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR = 1000111000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT = 1000218000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR = 1000164003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_IMAGE_LAYOUT_VIDEO_ENCODE_DST_KHR = 1000299000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_IMAGE_LAYOUT_VIDEO_ENCODE_SRC_KHR = 1000299001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_IMAGE_LAYOUT_VIDEO_ENCODE_DPB_KHR = 1000299002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_layout"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    VK_IMAGE_LAYOUT_ATTACHMENT_FEEDBACK_LOOP_OPTIMAL_EXT = 1000339000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VK_IMAGE_LAYOUT_VIDEO_ENCODE_QUANTIZATION_MAP_KHR = 1000553000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_zero_initialize_device_memory"],
        ImpliesSets = [
            "VK_EXT_zero_initialize_device_memory+VK_KHR_get_physical_device_properties2",
            "VK_EXT_zero_initialize_device_memory+VK_VERSION_1_1",
        ]
    )]
    VK_IMAGE_LAYOUT_ZERO_INITIALIZED_EXT = 1000620000,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL_KHR =
        VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL_KHR =
        VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV =
        VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ_KHR = VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_IMAGE_LAYOUT_MAX_ENUM = 0x7FFFFFFF,
}
