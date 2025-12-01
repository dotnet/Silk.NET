// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugReportObjectTypeEXT")]
[SupportedApiProfile("vulkan")]
public enum DebugReportObjectTypeEXT : uint
{
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    UnknownEXT = 0,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    InstanceEXT = 1,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PhysicalDeviceEXT = 2,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DeviceEXT = 3,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    QueueEXT = 4,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    SemaphoreEXT = 5,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    CommandBufferEXT = 6,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    FenceEXT = 7,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DeviceMemoryEXT = 8,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    BufferEXT = 9,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ImageEXT = 10,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    EventEXT = 11,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    QueryPoolEXT = 12,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    BufferViewEXT = 13,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ImageViewEXT = 14,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ShaderModuleEXT = 15,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PipelineCacheEXT = 16,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PipelineLayoutEXT = 17,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    RenderPassEXT = 18,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PipelineEXT = 19,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DescriptorSetLayoutEXT = 20,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    SamplerEXT = 21,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DescriptorPoolEXT = 22,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DescriptorSetEXT = 23,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    FramebufferEXT = 24,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    CommandPoolEXT = 25,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    SurfaceKhrEXT = 26,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    SwapchainKhrEXT = 27,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DebugReportCallbackExtEXT = 28,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DisplayKhrEXT = 29,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DisplayModeKhrEXT = 30,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ValidationCacheExtEXT = 33,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    SamplerYcbcrConversionEXT = 1000156000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    DescriptorUpdateTemplateEXT = 1000085000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    CuModuleNvxEXT = 1000029000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    CuFunctionNvxEXT = 1000029001,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ],
        RequireAll = true
    )]
    AccelerationStructureKhrEXT = 1000150000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    AccelerationStructureNvEXT = 1000165000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_MODULE_NV_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_cuda_kernel_launch"],
        ImpliesSets = [
            "VK_NV_cuda_kernel_launch+VK_KHR_get_physical_device_properties2",
            "VK_NV_cuda_kernel_launch+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CudaModuleNvEXT = 1000307000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_FUNCTION_NV_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_cuda_kernel_launch"],
        ImpliesSets = [
            "VK_NV_cuda_kernel_launch+VK_KHR_get_physical_device_properties2",
            "VK_NV_cuda_kernel_launch+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CudaFunctionNvEXT = 1000307001,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    BufferCollectionFuchsiaEXT = 1000366000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_descriptor_update_template"],
        RequireAll = true
    )]
    DescriptorUpdateTemplateKhrEXT = DescriptorUpdateTemplateEXT,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    SamplerYcbcrConversionKhrEXT = SamplerYcbcrConversionEXT,
}
