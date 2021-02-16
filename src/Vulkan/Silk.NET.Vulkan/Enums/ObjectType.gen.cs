// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkObjectType")]
    public enum ObjectType : int
    {
        [NativeName("Name", "VK_OBJECT_TYPE_UNKNOWN")]
        Unknown = 0,
        [NativeName("Name", "VK_OBJECT_TYPE_INSTANCE")]
        Instance = 1,
        [NativeName("Name", "VK_OBJECT_TYPE_PHYSICAL_DEVICE")]
        PhysicalDevice = 2,
        [NativeName("Name", "VK_OBJECT_TYPE_DEVICE")]
        Device = 3,
        [NativeName("Name", "VK_OBJECT_TYPE_QUEUE")]
        Queue = 4,
        [NativeName("Name", "VK_OBJECT_TYPE_SEMAPHORE")]
        Semaphore = 5,
        [NativeName("Name", "VK_OBJECT_TYPE_COMMAND_BUFFER")]
        CommandBuffer = 6,
        [NativeName("Name", "VK_OBJECT_TYPE_FENCE")]
        Fence = 7,
        [NativeName("Name", "VK_OBJECT_TYPE_DEVICE_MEMORY")]
        DeviceMemory = 8,
        [NativeName("Name", "VK_OBJECT_TYPE_BUFFER")]
        Buffer = 9,
        [NativeName("Name", "VK_OBJECT_TYPE_IMAGE")]
        Image = 10,
        [NativeName("Name", "VK_OBJECT_TYPE_EVENT")]
        Event = 11,
        [NativeName("Name", "VK_OBJECT_TYPE_QUERY_POOL")]
        QueryPool = 12,
        [NativeName("Name", "VK_OBJECT_TYPE_BUFFER_VIEW")]
        BufferView = 13,
        [NativeName("Name", "VK_OBJECT_TYPE_IMAGE_VIEW")]
        ImageView = 14,
        [NativeName("Name", "VK_OBJECT_TYPE_SHADER_MODULE")]
        ShaderModule = 15,
        [NativeName("Name", "VK_OBJECT_TYPE_PIPELINE_CACHE")]
        PipelineCache = 16,
        [NativeName("Name", "VK_OBJECT_TYPE_PIPELINE_LAYOUT")]
        PipelineLayout = 17,
        [NativeName("Name", "VK_OBJECT_TYPE_RENDER_PASS")]
        RenderPass = 18,
        [NativeName("Name", "VK_OBJECT_TYPE_PIPELINE")]
        Pipeline = 19,
        [NativeName("Name", "VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT")]
        DescriptorSetLayout = 20,
        [NativeName("Name", "VK_OBJECT_TYPE_SAMPLER")]
        Sampler = 21,
        [NativeName("Name", "VK_OBJECT_TYPE_DESCRIPTOR_POOL")]
        DescriptorPool = 22,
        [NativeName("Name", "VK_OBJECT_TYPE_DESCRIPTOR_SET")]
        DescriptorSet = 23,
        [NativeName("Name", "VK_OBJECT_TYPE_FRAMEBUFFER")]
        Framebuffer = 24,
        [NativeName("Name", "VK_OBJECT_TYPE_COMMAND_POOL")]
        CommandPool = 25,
        [NativeName("Name", "VK_OBJECT_TYPE_SURFACE_KHR")]
        SurfaceKhr = 1000000000,
        [NativeName("Name", "VK_OBJECT_TYPE_SWAPCHAIN_KHR")]
        SwapchainKhr = 1000001000,
        [NativeName("Name", "VK_OBJECT_TYPE_DISPLAY_KHR")]
        DisplayKhr = 1000002000,
        [NativeName("Name", "VK_OBJECT_TYPE_DISPLAY_MODE_KHR")]
        DisplayModeKhr = 1000002001,
        [NativeName("Name", "VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT")]
        DebugReportCallbackExt = 1000011000,
        [NativeName("Name", "VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR")]
        DescriptorUpdateTemplateKhr = 1000085000,
        [NativeName("Name", "VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT")]
        DebugUtilsMessengerExt = 1000128000,
        [NativeName("Name", "VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR")]
        AccelerationStructureKhr = 1000150000,
        [NativeName("Name", "VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR")]
        SamplerYcbcrConversionKhr = 1000156000,
        [NativeName("Name", "VK_OBJECT_TYPE_VALIDATION_CACHE_EXT")]
        ValidationCacheExt = 1000160000,
        [NativeName("Name", "VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV")]
        AccelerationStructureNV = 1000165000,
        [NativeName("Name", "VK_OBJECT_TYPE_PERFORMANCE_CONFIGURATION_INTEL")]
        PerformanceConfigurationIntel = 1000210000,
        [NativeName("Name", "VK_OBJECT_TYPE_DEFERRED_OPERATION_KHR")]
        DeferredOperationKhr = 1000268000,
        [NativeName("Name", "VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NV")]
        IndirectCommandsLayoutNV = 1000277000,
        [NativeName("Name", "VK_OBJECT_TYPE_PRIVATE_DATA_SLOT_EXT")]
        PrivateDataSlotExt = 1000295000,
        [NativeName("Name", "VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION")]
        SamplerYcbcrConversion = 1000156000,
        [NativeName("Name", "VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE")]
        DescriptorUpdateTemplate = 1000085000,
    }
}
