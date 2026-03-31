// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkDebugReportObjectTypeEXT")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDebugReportObjectTypeEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeUnknown = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeInstance = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypePhysicalDevice = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeDevice = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeQueue = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeSemaphore = 5,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeCommandBuffer = 6,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeFence = 7,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeDeviceMemory = 8,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeBuffer = 9,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeImage = 10,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeEvent = 11,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeQueryPool = 12,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeBufferView = 13,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeImageView = 14,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeShaderModule = 15,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypePipelineCache = 16,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypePipelineLayout = 17,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeRenderPass = 18,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypePipeline = 19,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeDescriptorSetLayout = 20,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeSampler = 21,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeDescriptorPool = 22,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeDescriptorSet = 23,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeFramebuffer = 24,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeCommandPool = 25,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeSurfaceKhr = 26,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeSwapchainKhr = 27,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeDebugReportCallbackExt = 28,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeDisplayKhr = 29,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeDisplayModeKhr = 30,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeValidationCacheExt = 33,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    VkDebugReportObjectTypeSamplerYcbcrConversion = 1000156000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    VkDebugReportObjectTypeDescriptorUpdateTemplate = 1000085000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    VkDebugReportObjectTypeCuModuleNvx = 1000029000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    VkDebugReportObjectTypeCuFunctionNvx = 1000029001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkDebugReportObjectTypeAccelerationStructureKhr = 1000150000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkDebugReportObjectTypeAccelerationStructureNv = 1000165000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkDebugReportObjectTypeCudaModuleNv = 1000307000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkDebugReportObjectTypeCudaFunctionNv = 1000307001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkDebugReportObjectTypeBufferCollectionFuchsia = 1000366000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_descriptor_update_template"],
        RequireAll = true
    )]
    VkDebugReportObjectTypeDescriptorUpdateTemplateKhr =
        VkDebugReportObjectTypeDescriptorUpdateTemplate,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkDebugReportObjectTypeSamplerYcbcrConversionKhr =
        VkDebugReportObjectTypeSamplerYcbcrConversion,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_MAX_ENUM_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportObjectTypeMaxEnum = 0x7FFFFFFF,
}
