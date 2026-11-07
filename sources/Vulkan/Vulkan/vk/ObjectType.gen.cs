// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkObjectType")]
public enum ObjectType : uint
{
    [NativeName("VK_OBJECT_TYPE_UNKNOWN")]
    Unknown = 0,

    [NativeName("VK_OBJECT_TYPE_INSTANCE")]
    Instance = 1,

    [NativeName("VK_OBJECT_TYPE_PHYSICAL_DEVICE")]
    PhysicalDevice = 2,

    [NativeName("VK_OBJECT_TYPE_DEVICE")]
    Device = 3,

    [NativeName("VK_OBJECT_TYPE_QUEUE")]
    Queue = 4,

    [NativeName("VK_OBJECT_TYPE_SEMAPHORE")]
    Semaphore = 5,

    [NativeName("VK_OBJECT_TYPE_COMMAND_BUFFER")]
    CommandBuffer = 6,

    [NativeName("VK_OBJECT_TYPE_FENCE")]
    Fence = 7,

    [NativeName("VK_OBJECT_TYPE_DEVICE_MEMORY")]
    DeviceMemory = 8,

    [NativeName("VK_OBJECT_TYPE_BUFFER")]
    Buffer = 9,

    [NativeName("VK_OBJECT_TYPE_IMAGE")]
    Image = 10,

    [NativeName("VK_OBJECT_TYPE_EVENT")]
    Event = 11,

    [NativeName("VK_OBJECT_TYPE_QUERY_POOL")]
    QueryPool = 12,

    [NativeName("VK_OBJECT_TYPE_BUFFER_VIEW")]
    BufferView = 13,

    [NativeName("VK_OBJECT_TYPE_IMAGE_VIEW")]
    ImageView = 14,

    [NativeName("VK_OBJECT_TYPE_SHADER_MODULE")]
    ShaderModule = 15,

    [NativeName("VK_OBJECT_TYPE_PIPELINE_CACHE")]
    PipelineCache = 16,

    [NativeName("VK_OBJECT_TYPE_PIPELINE_LAYOUT")]
    PipelineLayout = 17,

    [NativeName("VK_OBJECT_TYPE_RENDER_PASS")]
    RenderPass = 18,

    [NativeName("VK_OBJECT_TYPE_PIPELINE")]
    Pipeline = 19,

    [NativeName("VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT")]
    DescriptorSetLayout = 20,

    [NativeName("VK_OBJECT_TYPE_SAMPLER")]
    Sampler = 21,

    [NativeName("VK_OBJECT_TYPE_DESCRIPTOR_POOL")]
    DescriptorPool = 22,

    [NativeName("VK_OBJECT_TYPE_DESCRIPTOR_SET")]
    DescriptorSet = 23,

    [NativeName("VK_OBJECT_TYPE_FRAMEBUFFER")]
    Framebuffer = 24,

    [NativeName("VK_OBJECT_TYPE_COMMAND_POOL")]
    CommandPool = 25,

    [NativeName("VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE")]
    DescriptorUpdateTemplate = 1000085000,

    [NativeName("VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION")]
    SamplerYcbcrConversion = 1000156000,

    [NativeName("VK_OBJECT_TYPE_PRIVATE_DATA_SLOT")]
    PrivateDataSlot = 1000295000,

    [NativeName("VK_OBJECT_TYPE_SURFACE_KHR")]
    SurfaceKHR = 1000000000,

    [NativeName("VK_OBJECT_TYPE_SWAPCHAIN_KHR")]
    SwapchainKHR = 1000001000,

    [NativeName("VK_OBJECT_TYPE_DISPLAY_KHR")]
    DisplayKHR = 1000002000,

    [NativeName("VK_OBJECT_TYPE_DISPLAY_MODE_KHR")]
    DisplayModeKHR = 1000002001,

    [NativeName("VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT")]
    DebugReportCallbackEXT = 1000011000,

    [NativeName("VK_OBJECT_TYPE_VIDEO_SESSION_KHR")]
    VideoSessionKHR = 1000023000,

    [NativeName("VK_OBJECT_TYPE_VIDEO_SESSION_PARAMETERS_KHR")]
    VideoSessionParametersKHR = 1000023001,

    [NativeName("VK_OBJECT_TYPE_CU_MODULE_NVX")]
    CuModuleNVX = 1000029000,

    [NativeName("VK_OBJECT_TYPE_CU_FUNCTION_NVX")]
    CuFunctionNVX = 1000029001,

    [NativeName("VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT")]
    DebugUtilsMessengerEXT = 1000128000,

    [NativeName("VK_OBJECT_TYPE_GPA_SESSION_AMD")]
    GpaSessionAMD = 1000133000,

    [NativeName("VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR")]
    AccelerationStructureKHR = 1000150000,

    [NativeName("VK_OBJECT_TYPE_VALIDATION_CACHE_EXT")]
    ValidationCacheEXT = 1000160000,

    [NativeName("VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV")]
    AccelerationStructureNV = 1000165000,

    [NativeName("VK_OBJECT_TYPE_PERFORMANCE_CONFIGURATION_INTEL")]
    PerformanceConfigurationINTEL = 1000210000,

    [NativeName("VK_OBJECT_TYPE_DEFERRED_OPERATION_KHR")]
    DeferredOperationKHR = 1000268000,

    [NativeName("VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NV")]
    IndirectCommandsLayoutNV = 1000277000,

    [NativeName("VK_OBJECT_TYPE_CUDA_MODULE_NV")]
    CudaModuleNV = 1000307000,

    [NativeName("VK_OBJECT_TYPE_CUDA_FUNCTION_NV")]
    CudaFunctionNV = 1000307001,

    [NativeName("VK_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA")]
    BufferCollectionFUCHSIA = 1000366000,

    [NativeName("VK_OBJECT_TYPE_MICROMAP_EXT")]
    MicromapEXT = 1000396000,

    [NativeName("VK_OBJECT_TYPE_TENSOR_ARM")]
    TensorARM = 1000460000,

    [NativeName("VK_OBJECT_TYPE_TENSOR_VIEW_ARM")]
    TensorViewARM = 1000460001,

    [NativeName("VK_OBJECT_TYPE_OPTICAL_FLOW_SESSION_NV")]
    OpticalFlowSessionNV = 1000464000,

    [NativeName("VK_OBJECT_TYPE_SHADER_EXT")]
    ShaderEXT = 1000482000,

    [NativeName("VK_OBJECT_TYPE_PIPELINE_BINARY_KHR")]
    PipelineBinaryKHR = 1000483000,

    [NativeName("VK_OBJECT_TYPE_DATA_GRAPH_PIPELINE_SESSION_ARM")]
    DataGraphPipelineSessionARM = 1000507000,

    [NativeName("VK_OBJECT_TYPE_EXTERNAL_COMPUTE_QUEUE_NV")]
    ExternalComputeQueueNV = 1000556000,

    [NativeName("VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_EXT")]
    IndirectCommandsLayoutEXT = 1000572000,

    [NativeName("VK_OBJECT_TYPE_INDIRECT_EXECUTION_SET_EXT")]
    IndirectExecutionSetEXT = 1000572001,

    [NativeName("VK_OBJECT_TYPE_SHADER_INSTRUMENTATION_ARM")]
    ShaderInstrumentationARM = 1000607000,

    [NativeName("VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR")]
    DescriptorUpdateTemplateKHR = DescriptorUpdateTemplate,

    [NativeName("VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR")]
    SamplerYcbcrConversionKHR = SamplerYcbcrConversion,

    [NativeName("VK_OBJECT_TYPE_PRIVATE_DATA_SLOT_EXT")]
    PrivateDataSlotEXT = PrivateDataSlot,
}
