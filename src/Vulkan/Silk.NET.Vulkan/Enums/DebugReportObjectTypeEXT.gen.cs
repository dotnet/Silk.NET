// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDebugReportObjectTypeEXT")]
    public enum DebugReportObjectTypeEXT : int
    {
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT")]
        DebugReportObjectTypeUnknownExt = 0,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT")]
        DebugReportObjectTypeInstanceExt = 1,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT")]
        DebugReportObjectTypePhysicalDeviceExt = 2,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT")]
        DebugReportObjectTypeDeviceExt = 3,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT")]
        DebugReportObjectTypeQueueExt = 4,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT")]
        DebugReportObjectTypeSemaphoreExt = 5,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT")]
        DebugReportObjectTypeCommandBufferExt = 6,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT")]
        DebugReportObjectTypeFenceExt = 7,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT")]
        DebugReportObjectTypeDeviceMemoryExt = 8,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT")]
        DebugReportObjectTypeBufferExt = 9,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT")]
        DebugReportObjectTypeImageExt = 10,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT")]
        DebugReportObjectTypeEventExt = 11,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT")]
        DebugReportObjectTypeQueryPoolExt = 12,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT")]
        DebugReportObjectTypeBufferViewExt = 13,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT")]
        DebugReportObjectTypeImageViewExt = 14,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT")]
        DebugReportObjectTypeShaderModuleExt = 15,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT")]
        DebugReportObjectTypePipelineCacheExt = 16,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT")]
        DebugReportObjectTypePipelineLayoutExt = 17,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT")]
        DebugReportObjectTypeRenderPassExt = 18,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT")]
        DebugReportObjectTypePipelineExt = 19,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT")]
        DebugReportObjectTypeDescriptorSetLayoutExt = 20,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT")]
        DebugReportObjectTypeSamplerExt = 21,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT")]
        DebugReportObjectTypeDescriptorPoolExt = 22,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT")]
        DebugReportObjectTypeDescriptorSetExt = 23,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT")]
        DebugReportObjectTypeFramebufferExt = 24,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT")]
        DebugReportObjectTypeCommandPoolExt = 25,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT")]
        DebugReportObjectTypeSurfaceKhrExt = 26,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT")]
        DebugReportObjectTypeSwapchainKhrExt = 27,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT")]
        DebugReportObjectTypeDebugReportCallbackExtExt = 28,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT")]
        DebugReportObjectTypeDebugReportExt = 28,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT")]
        DebugReportObjectTypeDisplayKhrExt = 29,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT")]
        DebugReportObjectTypeDisplayModeKhrExt = 30,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT")]
        DebugReportObjectTypeValidationCacheExtExt = 33,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT")]
        DebugReportObjectTypeValidationCacheExt = 33,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT")]
        DebugReportObjectTypeSamplerYcbcrConversionExt = 1000156000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT")]
        DebugReportObjectTypeDescriptorUpdateTemplateExt = 1000085000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT")]
        DebugReportObjectTypeDescriptorUpdateTemplateKhrExt = 1000085000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT")]
        DebugReportObjectTypeAccelerationStructureKhrExt = 1000150000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT")]
        DebugReportObjectTypeSamplerYcbcrConversionKhrExt = 1000156000,
        [NativeName("Name", "VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT")]
        DebugReportObjectTypeAccelerationStructureNVExt = 1000165000,
    }
}
