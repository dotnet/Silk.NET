// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugReportObjectTypeEXT")]
public enum DebugReportObjectTypeEXT : uint
{
    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT")]
    Unknown = 0,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT")]
    Instance = 1,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT")]
    PhysicalDevice = 2,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT")]
    Device = 3,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT")]
    Queue = 4,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT")]
    Semaphore = 5,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT")]
    CommandBuffer = 6,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT")]
    Fence = 7,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT")]
    DeviceMemory = 8,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT")]
    Buffer = 9,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT")]
    Image = 10,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT")]
    Event = 11,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT")]
    QueryPool = 12,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT")]
    BufferView = 13,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT")]
    ImageView = 14,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT")]
    ShaderModule = 15,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT")]
    PipelineCache = 16,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT")]
    PipelineLayout = 17,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT")]
    RenderPass = 18,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT")]
    Pipeline = 19,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT")]
    DescriptorSetLayout = 20,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT")]
    Sampler = 21,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT")]
    DescriptorPool = 22,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT")]
    DescriptorSet = 23,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT")]
    Framebuffer = 24,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT")]
    CommandPool = 25,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT")]
    SurfaceKhr = 26,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT")]
    SwapchainKhr = 27,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT")]
    DebugReportCallbackExt = 28,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT")]
    DisplayKhr = 29,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT")]
    DisplayModeKhr = 30,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT")]
    ValidationCacheExt = 33,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT")]
    SamplerYcbcrConversion = 1000156000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT")]
    DescriptorUpdateTemplate = 1000085000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT")]
    CuModuleNvx = 1000029000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT")]
    CuFunctionNvx = 1000029001,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT")]
    AccelerationStructureKhr = 1000150000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT")]
    AccelerationStructureNv = 1000165000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_MODULE_NV_EXT")]
    CudaModuleNv = 1000307000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_FUNCTION_NV_EXT")]
    CudaFunctionNv = 1000307001,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA_EXT")]
    BufferCollectionFuchsia = 1000366000,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT")]
    DescriptorUpdateTemplateKhr = DescriptorUpdateTemplate,

    [NativeName("VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT")]
    SamplerYcbcrConversionKhr = SamplerYcbcrConversion,
}
