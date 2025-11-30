// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDebugReportObjectTypeEXT")]
[SupportedApiProfile("vulkan")]
public enum DebugReportObjectTypeExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Unknownext = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Instanceext = 1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PhysicalDeviceext = 2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Deviceext = 3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Queueext = 4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Semaphoreext = 5,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    CommandBufferext = 6,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Fenceext = 7,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DeviceMemoryext = 8,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Bufferext = 9,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Imageext = 10,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Eventext = 11,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    QueryPoolext = 12,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    BufferViewext = 13,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ImageViewext = 14,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ShaderModuleext = 15,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PipelineCacheext = 16,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PipelineLayoutext = 17,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    RenderPassext = 18,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Pipelineext = 19,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DescriptorSetLayoutext = 20,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Samplerext = 21,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DescriptorPoolext = 22,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DescriptorSetext = 23,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    Framebufferext = 24,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    CommandPoolext = 25,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    SurfaceKhrext = 26,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    SwapchainKhrext = 27,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DebugReportCallbackExtext = 28,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DisplayKhrext = 29,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DisplayModeKhrext = 30,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ValidationCacheExtext = 33,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    SamplerYcbcrConversionext = 1000156000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    DescriptorUpdateTemplateext = 1000085000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    CuModuleNvxext = 1000029000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    CuFunctionNvxext = 1000029001,

    [NameAffix("Suffix", "EXT", 0)]
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
    AccelerationStructureKhrext = 1000150000,

    [NameAffix("Suffix", "EXT", 0)]
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
    AccelerationStructureNvext = 1000165000,

    [NameAffix("Suffix", "EXT", 0)]
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
    CudaModuleNvext = 1000307000,

    [NameAffix("Suffix", "EXT", 0)]
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
    CudaFunctionNvext = 1000307001,

    [NameAffix("Suffix", "EXT", 0)]
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
    BufferCollectionFuchsiaext = 1000366000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_descriptor_update_template"],
        RequireAll = true
    )]
    DescriptorUpdateTemplateKhrext = DescriptorUpdateTemplateext,

    [NameAffix("Suffix", "EXT", 0)]
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
    SamplerYcbcrConversionKhrext = SamplerYcbcrConversionext,
}
