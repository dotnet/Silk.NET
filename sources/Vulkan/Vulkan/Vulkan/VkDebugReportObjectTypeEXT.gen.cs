// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDebugReportObjectTypeEXT : uint
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT = 2,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT = 3,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT = 4,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT = 5,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT = 6,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT = 7,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT = 8,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT = 9,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT = 10,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT = 11,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT = 12,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT = 13,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT = 14,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT = 15,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT = 16,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT = 17,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT = 18,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT = 19,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT = 20,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT = 21,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT = 22,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT = 23,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT = 24,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT = 25,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT = 26,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT = 27,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT = 28,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT = 29,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT = 30,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT = 33,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT = 1000156000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT = 1000085000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT = 1000029000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT = 1000029001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ],
        RequireAll = true
    )]
    VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT = 1000150000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT = 1000165000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_cuda_kernel_launch"],
        RequireAll = true
    )]
    VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_MODULE_NV_EXT = 1000307000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_cuda_kernel_launch"],
        RequireAll = true
    )]
    VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_FUNCTION_NV_EXT = 1000307001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA_EXT = 1000366000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT =
        VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT =
        VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_descriptor_update_template"],
        RequireAll = true
    )]
    VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT =
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT =
        VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_OBJECT_TYPE_MAX_ENUM_EXT = 0x7FFFFFFF,
}
