// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDebugReportObjectTypeEXT")]
    public enum DebugReportObjectTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"UnknownExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT")]
        DebugReportObjectTypeUnknownExt = 0,
        [Obsolete("Deprecated in favour of \"InstanceExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT")]
        DebugReportObjectTypeInstanceExt = 1,
        [Obsolete("Deprecated in favour of \"PhysicalDeviceExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT")]
        DebugReportObjectTypePhysicalDeviceExt = 2,
        [Obsolete("Deprecated in favour of \"DeviceExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT")]
        DebugReportObjectTypeDeviceExt = 3,
        [Obsolete("Deprecated in favour of \"QueueExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT")]
        DebugReportObjectTypeQueueExt = 4,
        [Obsolete("Deprecated in favour of \"SemaphoreExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT")]
        DebugReportObjectTypeSemaphoreExt = 5,
        [Obsolete("Deprecated in favour of \"CommandBufferExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT")]
        DebugReportObjectTypeCommandBufferExt = 6,
        [Obsolete("Deprecated in favour of \"FenceExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT")]
        DebugReportObjectTypeFenceExt = 7,
        [Obsolete("Deprecated in favour of \"DeviceMemoryExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT")]
        DebugReportObjectTypeDeviceMemoryExt = 8,
        [Obsolete("Deprecated in favour of \"BufferExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT")]
        DebugReportObjectTypeBufferExt = 9,
        [Obsolete("Deprecated in favour of \"ImageExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT")]
        DebugReportObjectTypeImageExt = 10,
        [Obsolete("Deprecated in favour of \"EventExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT")]
        DebugReportObjectTypeEventExt = 11,
        [Obsolete("Deprecated in favour of \"QueryPoolExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT")]
        DebugReportObjectTypeQueryPoolExt = 12,
        [Obsolete("Deprecated in favour of \"BufferViewExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT")]
        DebugReportObjectTypeBufferViewExt = 13,
        [Obsolete("Deprecated in favour of \"ImageViewExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT")]
        DebugReportObjectTypeImageViewExt = 14,
        [Obsolete("Deprecated in favour of \"ShaderModuleExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT")]
        DebugReportObjectTypeShaderModuleExt = 15,
        [Obsolete("Deprecated in favour of \"PipelineCacheExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT")]
        DebugReportObjectTypePipelineCacheExt = 16,
        [Obsolete("Deprecated in favour of \"PipelineLayoutExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT")]
        DebugReportObjectTypePipelineLayoutExt = 17,
        [Obsolete("Deprecated in favour of \"RenderPassExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT")]
        DebugReportObjectTypeRenderPassExt = 18,
        [Obsolete("Deprecated in favour of \"PipelineExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT")]
        DebugReportObjectTypePipelineExt = 19,
        [Obsolete("Deprecated in favour of \"DescriptorSetLayoutExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT")]
        DebugReportObjectTypeDescriptorSetLayoutExt = 20,
        [Obsolete("Deprecated in favour of \"SamplerExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT")]
        DebugReportObjectTypeSamplerExt = 21,
        [Obsolete("Deprecated in favour of \"DescriptorPoolExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT")]
        DebugReportObjectTypeDescriptorPoolExt = 22,
        [Obsolete("Deprecated in favour of \"DescriptorSetExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT")]
        DebugReportObjectTypeDescriptorSetExt = 23,
        [Obsolete("Deprecated in favour of \"FramebufferExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT")]
        DebugReportObjectTypeFramebufferExt = 24,
        [Obsolete("Deprecated in favour of \"CommandPoolExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT")]
        DebugReportObjectTypeCommandPoolExt = 25,
        [Obsolete("Deprecated in favour of \"SurfaceKhrExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT")]
        DebugReportObjectTypeSurfaceKhrExt = 26,
        [Obsolete("Deprecated in favour of \"SwapchainKhrExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT")]
        DebugReportObjectTypeSwapchainKhrExt = 27,
        [Obsolete("Deprecated in favour of \"DebugReportCallbackExtExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT")]
        DebugReportObjectTypeDebugReportCallbackExtExt = 28,
        [Obsolete("Deprecated in favour of \"DebugReportExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT")]
        DebugReportObjectTypeDebugReportExt = 28,
        [Obsolete("Deprecated in favour of \"DisplayKhrExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT")]
        DebugReportObjectTypeDisplayKhrExt = 29,
        [Obsolete("Deprecated in favour of \"DisplayModeKhrExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT")]
        DebugReportObjectTypeDisplayModeKhrExt = 30,
        [Obsolete("Deprecated in favour of \"ValidationCacheExtExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT")]
        DebugReportObjectTypeValidationCacheExtExt = 33,
        [Obsolete("Deprecated in favour of \"ValidationCacheExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT")]
        DebugReportObjectTypeValidationCacheExt = 33,
        [Obsolete("Deprecated in favour of \"SamplerYcbcrConversionExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT")]
        DebugReportObjectTypeSamplerYcbcrConversionExt = 1000156000,
        [Obsolete("Deprecated in favour of \"DescriptorUpdateTemplateExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT")]
        DebugReportObjectTypeDescriptorUpdateTemplateExt = 1000085000,
        [Obsolete("Deprecated in favour of \"CUModuleNvxExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT")]
        DebugReportObjectTypeCUModuleNvxExt = 1000029000,
        [Obsolete("Deprecated in favour of \"CUFunctionNvxExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT")]
        DebugReportObjectTypeCUFunctionNvxExt = 1000029001,
        [Obsolete("Deprecated in favour of \"DescriptorUpdateTemplateKhrExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT")]
        DebugReportObjectTypeDescriptorUpdateTemplateKhrExt = 1000085000,
        [Obsolete("Deprecated in favour of \"AccelerationStructureKhrExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT")]
        DebugReportObjectTypeAccelerationStructureKhrExt = 1000150000,
        [Obsolete("Deprecated in favour of \"SamplerYcbcrConversionKhrExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT")]
        DebugReportObjectTypeSamplerYcbcrConversionKhrExt = 1000156000,
        [Obsolete("Deprecated in favour of \"AccelerationStructureNVExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT")]
        DebugReportObjectTypeAccelerationStructureNVExt = 1000165000,
        [Obsolete("Deprecated in favour of \"CudaModuleNVExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_MODULE_NV_EXT")]
        DebugReportObjectTypeCudaModuleNVExt = 1000307000,
        [Obsolete("Deprecated in favour of \"CudaFunctionNVExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_FUNCTION_NV_EXT")]
        DebugReportObjectTypeCudaFunctionNVExt = 1000307001,
        [Obsolete("Deprecated in favour of \"BufferCollectionFuchsiaExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA_EXT")]
        DebugReportObjectTypeBufferCollectionFuchsiaExt = 1000366000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT")]
        UnknownExt = 0,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT")]
        InstanceExt = 1,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT")]
        PhysicalDeviceExt = 2,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT")]
        DeviceExt = 3,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT")]
        QueueExt = 4,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT")]
        SemaphoreExt = 5,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT")]
        CommandBufferExt = 6,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT")]
        FenceExt = 7,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT")]
        DeviceMemoryExt = 8,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT")]
        BufferExt = 9,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT")]
        ImageExt = 10,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT")]
        EventExt = 11,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT")]
        QueryPoolExt = 12,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT")]
        BufferViewExt = 13,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT")]
        ImageViewExt = 14,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT")]
        ShaderModuleExt = 15,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT")]
        PipelineCacheExt = 16,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT")]
        PipelineLayoutExt = 17,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT")]
        RenderPassExt = 18,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT")]
        PipelineExt = 19,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT")]
        DescriptorSetLayoutExt = 20,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT")]
        SamplerExt = 21,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT")]
        DescriptorPoolExt = 22,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT")]
        DescriptorSetExt = 23,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT")]
        FramebufferExt = 24,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT")]
        CommandPoolExt = 25,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT")]
        SurfaceKhrExt = 26,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT")]
        SwapchainKhrExt = 27,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT")]
        DebugReportCallbackExtExt = 28,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT")]
        DebugReportExt = 28,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT")]
        DisplayKhrExt = 29,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT")]
        DisplayModeKhrExt = 30,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT")]
        ValidationCacheExtExt = 33,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT")]
        ValidationCacheExt = 33,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT")]
        SamplerYcbcrConversionExt = 1000156000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT")]
        DescriptorUpdateTemplateExt = 1000085000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT")]
        CUModuleNvxExt = 1000029000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT")]
        CUFunctionNvxExt = 1000029001,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT")]
        DescriptorUpdateTemplateKhrExt = 1000085000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT")]
        AccelerationStructureKhrExt = 1000150000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT")]
        SamplerYcbcrConversionKhrExt = 1000156000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT")]
        AccelerationStructureNVExt = 1000165000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_MODULE_NV_EXT")]
        CudaModuleNVExt = 1000307000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_FUNCTION_NV_EXT")]
        CudaFunctionNVExt = 1000307001,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA_EXT")]
        BufferCollectionFuchsiaExt = 1000366000,
    }
}
