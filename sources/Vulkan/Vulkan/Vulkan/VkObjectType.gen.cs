// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkObjectType
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_UNKNOWN = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_INSTANCE = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_PHYSICAL_DEVICE = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_DEVICE = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_QUEUE = 4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_SEMAPHORE = 5,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_COMMAND_BUFFER = 6,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_FENCE = 7,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_DEVICE_MEMORY = 8,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_BUFFER = 9,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_IMAGE = 10,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_EVENT = 11,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_QUERY_POOL = 12,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_BUFFER_VIEW = 13,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_IMAGE_VIEW = 14,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_SHADER_MODULE = 15,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_PIPELINE_CACHE = 16,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_PIPELINE_LAYOUT = 17,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_RENDER_PASS = 18,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_PIPELINE = 19,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT = 20,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_SAMPLER = 21,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_DESCRIPTOR_POOL = 22,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_DESCRIPTOR_SET = 23,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_FRAMEBUFFER = 24,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_COMMAND_POOL = 25,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION = 1000156000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE = 1000085000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_OBJECT_TYPE_PRIVATE_DATA_SLOT = 1000295000,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_OBJECT_TYPE_SURFACE_KHR = 1000000000,

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    VK_OBJECT_TYPE_SWAPCHAIN_KHR = 1000001000,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_OBJECT_TYPE_DISPLAY_KHR = 1000002000,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_OBJECT_TYPE_DISPLAY_MODE_KHR = 1000002001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT = 1000011000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_OBJECT_TYPE_VIDEO_SESSION_KHR = 1000023000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_OBJECT_TYPE_VIDEO_SESSION_PARAMETERS_KHR = 1000023001,

    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    VK_OBJECT_TYPE_CU_MODULE_NVX = 1000029000,

    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    VK_OBJECT_TYPE_CU_FUNCTION_NVX = 1000029001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT = 1000128000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR = 1000150000,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    VK_OBJECT_TYPE_VALIDATION_CACHE_EXT = 1000160000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV = 1000165000,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_OBJECT_TYPE_PERFORMANCE_CONFIGURATION_INTEL = 1000210000,

    [SupportedApiProfile("vulkan", ["VK_KHR_deferred_host_operations"])]
    VK_OBJECT_TYPE_DEFERRED_OPERATION_KHR = 1000268000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NV = 1000277000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA = 1000366000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_OBJECT_TYPE_MICROMAP_EXT = 1000396000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_OBJECT_TYPE_OPTICAL_FLOW_SESSION_NV = 1000464000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_OBJECT_TYPE_SHADER_EXT = 1000482000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_OBJECT_TYPE_PIPELINE_BINARY_KHR = 1000483000,

    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    VK_OBJECT_TYPE_EXTERNAL_COMPUTE_QUEUE_NV = 1000556000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_EXT = 1000572000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_OBJECT_TYPE_INDIRECT_EXECUTION_SET_EXT = 1000572001,

    [SupportedApiProfile("vulkan", ["VK_KHR_descriptor_update_template"])]
    VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR = VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR = VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    VK_OBJECT_TYPE_PRIVATE_DATA_SLOT_EXT = VK_OBJECT_TYPE_PRIVATE_DATA_SLOT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_OBJECT_TYPE_MAX_ENUM = 0x7FFFFFFF,
}
