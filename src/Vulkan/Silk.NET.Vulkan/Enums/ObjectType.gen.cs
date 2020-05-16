// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public enum ObjectType
    {
        Unknown = 0,
        Instance = 1,
        PhysicalDevice = 2,
        Device = 3,
        Queue = 4,
        Semaphore = 5,
        CommandBuffer = 6,
        Fence = 7,
        DeviceMemory = 8,
        Buffer = 9,
        Image = 10,
        Event = 11,
        QueryPool = 12,
        BufferView = 13,
        ImageView = 14,
        ShaderModule = 15,
        PipelineCache = 16,
        PipelineLayout = 17,
        RenderPass = 18,
        Pipeline = 19,
        DescriptorSetLayout = 20,
        Sampler = 21,
        DescriptorPool = 22,
        DescriptorSet = 23,
        Framebuffer = 24,
        CommandPool = 25,
        SurfaceKhr = 1000000000,
        SwapchainKhr = 1000001000,
        DisplayKhr = 1000002000,
        DisplayModeKhr = 1000002001,
        DebugReportCallbackExt = 1000011000,
        DescriptorUpdateTemplateKhr = 1000085000,
        DebugUtilsMessengerExt = 1000128000,
        AccelerationStructureKhr = 1000165000,
        SamplerYcbcrConversionKhr = 1000156000,
        ValidationCacheExt = 1000160000,
        AccelerationStructureNV = 1000165000,
        PerformanceConfigurationIntel = 1000210000,
        DeferredOperationKhr = 1000268000,
        IndirectCommandsLayoutNV = 1000277000,
        PrivateDataSlotExt = 1000295000,
        SamplerYcbcrConversion = 1000156000,
        DescriptorUpdateTemplate = 1000085000,
    }
}
