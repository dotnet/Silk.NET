// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkStructureType")]
public enum StructureType : uint
{
    [NativeName("VK_STRUCTURE_TYPE_APPLICATION_INFO")]
    ApplicationInfo = 0,

    [NativeName("VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO")]
    InstanceCreateInfo = 1,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO")]
    DeviceQueueCreateInfo = 2,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO")]
    DeviceCreateInfo = 3,

    [NativeName("VK_STRUCTURE_TYPE_SUBMIT_INFO")]
    SubmitInfo = 4,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO")]
    MemoryAllocateInfo = 5,

    [NativeName("VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE")]
    MappedMemoryRange = 6,

    [NativeName("VK_STRUCTURE_TYPE_BIND_SPARSE_INFO")]
    BindSparseInfo = 7,

    [NativeName("VK_STRUCTURE_TYPE_FENCE_CREATE_INFO")]
    FenceCreateInfo = 8,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO")]
    SemaphoreCreateInfo = 9,

    [NativeName("VK_STRUCTURE_TYPE_EVENT_CREATE_INFO")]
    EventCreateInfo = 10,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO")]
    QueryPoolCreateInfo = 11,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO")]
    BufferCreateInfo = 12,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO")]
    BufferViewCreateInfo = 13,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO")]
    ImageCreateInfo = 14,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO")]
    ImageViewCreateInfo = 15,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO")]
    ShaderModuleCreateInfo = 16,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO")]
    PipelineCacheCreateInfo = 17,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO")]
    PipelineShaderStageCreateInfo = 18,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO")]
    PipelineVertexInputStateCreateInfo = 19,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO")]
    PipelineInputAssemblyStateCreateInfo = 20,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO")]
    PipelineTessellationStateCreateInfo = 21,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO")]
    PipelineViewportStateCreateInfo = 22,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO")]
    PipelineRasterizationStateCreateInfo = 23,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO")]
    PipelineMultisampleStateCreateInfo = 24,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO")]
    PipelineDepthStencilStateCreateInfo = 25,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO")]
    PipelineColorBlendStateCreateInfo = 26,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO")]
    PipelineDynamicStateCreateInfo = 27,

    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO")]
    GraphicsPipelineCreateInfo = 28,

    [NativeName("VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO")]
    ComputePipelineCreateInfo = 29,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO")]
    PipelineLayoutCreateInfo = 30,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO")]
    SamplerCreateInfo = 31,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO")]
    DescriptorSetLayoutCreateInfo = 32,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO")]
    DescriptorPoolCreateInfo = 33,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO")]
    DescriptorSetAllocateInfo = 34,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET")]
    WriteDescriptorSet = 35,

    [NativeName("VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET")]
    CopyDescriptorSet = 36,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO")]
    FramebufferCreateInfo = 37,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO")]
    RenderPassCreateInfo = 38,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO")]
    CommandPoolCreateInfo = 39,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO")]
    CommandBufferAllocateInfo = 40,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO")]
    CommandBufferInheritanceInfo = 41,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO")]
    CommandBufferBeginInfo = 42,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO")]
    RenderPassBeginInfo = 43,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER")]
    BufferMemoryBarrier = 44,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER")]
    ImageMemoryBarrier = 45,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER")]
    MemoryBarrier = 46,

    [NativeName("VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO")]
    LoaderInstanceCreateInfo = 47,

    [NativeName("VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO")]
    LoaderDeviceCreateInfo = 48,

    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO")]
    BindBufferMemoryInfo = 1000157000,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO")]
    BindImageMemoryInfo = 1000157001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS")]
    MemoryDedicatedRequirements = 1000127000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO")]
    MemoryDedicatedAllocateInfo = 1000127001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO")]
    MemoryAllocateFlagsInfo = 1000060000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO")]
    DeviceGroupCommandBufferBeginInfo = 1000060004,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO")]
    DeviceGroupSubmitInfo = 1000060005,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO")]
    DeviceGroupBindSparseInfo = 1000060006,

    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO")]
    BindBufferMemoryDeviceGroupInfo = 1000060013,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO")]
    BindImageMemoryDeviceGroupInfo = 1000060014,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES")]
    PhysicalDeviceGroupProperties = 1000070000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO")]
    DeviceGroupDeviceCreateInfo = 1000070001,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2")]
    BufferMemoryRequirementsInfo2 = 1000146000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2")]
    ImageMemoryRequirementsInfo2 = 1000146001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2")]
    ImageSparseMemoryRequirementsInfo2 = 1000146002,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2")]
    MemoryRequirements2 = 1000146003,

    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2")]
    SparseImageMemoryRequirements2 = 1000146004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2")]
    PhysicalDeviceFeatures2 = 1000059000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2")]
    PhysicalDeviceProperties2 = 1000059001,

    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2")]
    FormatProperties2 = 1000059002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2")]
    ImageFormatProperties2 = 1000059003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2")]
    PhysicalDeviceImageFormatInfo2 = 1000059004,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2")]
    QueueFamilyProperties2 = 1000059005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2")]
    PhysicalDeviceMemoryProperties2 = 1000059006,

    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2")]
    SparseImageFormatProperties2 = 1000059007,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2")]
    PhysicalDeviceSparseImageFormatInfo2 = 1000059008,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO")]
    ImageViewUsageCreateInfo = 1000117002,

    [NativeName("VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO")]
    ProtectedSubmitInfo = 1000145000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES")]
    PhysicalDeviceProtectedMemoryFeatures = 1000145001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES")]
    PhysicalDeviceProtectedMemoryProperties = 1000145002,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2")]
    DeviceQueueInfo2 = 1000145003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO")]
    PhysicalDeviceExternalImageFormatInfo = 1000071000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES")]
    ExternalImageFormatProperties = 1000071001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO")]
    PhysicalDeviceExternalBufferInfo = 1000071002,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES")]
    ExternalBufferProperties = 1000071003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES")]
    PhysicalDeviceIdProperties = 1000071004,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO")]
    ExternalMemoryBufferCreateInfo = 1000072000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO")]
    ExternalMemoryImageCreateInfo = 1000072001,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO")]
    ExportMemoryAllocateInfo = 1000072002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO")]
    PhysicalDeviceExternalFenceInfo = 1000112000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES")]
    ExternalFenceProperties = 1000112001,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO")]
    ExportFenceCreateInfo = 1000113000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO")]
    ExportSemaphoreCreateInfo = 1000077000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO")]
    PhysicalDeviceExternalSemaphoreInfo = 1000076000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES")]
    ExternalSemaphoreProperties = 1000076001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES")]
    PhysicalDeviceSubgroupProperties = 1000094000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES")]
    PhysicalDevice16BitStorageFeatures = 1000083000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES")]
    PhysicalDeviceVariablePointersFeatures = 1000120000,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO")]
    DescriptorUpdateTemplateCreateInfo = 1000085000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES")]
    PhysicalDeviceMaintenance3Properties = 1000168000,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT")]
    DescriptorSetLayoutSupport = 1000168001,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO")]
    SamplerYcbcrConversionCreateInfo = 1000156000,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO")]
    SamplerYcbcrConversionInfo = 1000156001,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO")]
    BindImagePlaneMemoryInfo = 1000156002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO")]
    ImagePlaneMemoryRequirementsInfo = 1000156003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES")]
    PhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES")]
    SamplerYcbcrConversionImageFormatProperties = 1000156005,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO")]
    DeviceGroupRenderPassBeginInfo = 1000060003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES")]
    PhysicalDevicePointClippingProperties = 1000117000,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO")]
    RenderPassInputAttachmentAspectCreateInfo = 1000117001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO")]
    PipelineTessellationDomainOriginStateCreateInfo = 1000117003,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO")]
    RenderPassMultiviewCreateInfo = 1000053000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES")]
    PhysicalDeviceMultiviewFeatures = 1000053001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES")]
    PhysicalDeviceMultiviewProperties = 1000053002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES")]
    PhysicalDeviceShaderDrawParametersFeatures = 1000063000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES")]
    PhysicalDeviceDriverProperties = 1000196000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_FEATURES")]
    PhysicalDeviceVulkan1x1Features = 49,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES")]
    PhysicalDeviceVulkan1x1Properties = 50,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES")]
    PhysicalDeviceVulkan1x2Features = 51,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES")]
    PhysicalDeviceVulkan1x2Properties = 52,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO")]
    ImageFormatListCreateInfo = 1000147000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES")]
    PhysicalDeviceVulkanMemoryModelFeatures = 1000211000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES")]
    PhysicalDeviceHostQueryResetFeatures = 1000261000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES")]
    PhysicalDeviceTimelineSemaphoreFeatures = 1000207000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES")]
    PhysicalDeviceTimelineSemaphoreProperties = 1000207001,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO")]
    SemaphoreTypeCreateInfo = 1000207002,

    [NativeName("VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO")]
    TimelineSemaphoreSubmitInfo = 1000207003,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO")]
    SemaphoreWaitInfo = 1000207004,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO")]
    SemaphoreSignalInfo = 1000207005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES")]
    PhysicalDeviceBufferDeviceAddressFeatures = 1000257000,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO")]
    BufferDeviceAddressInfo = 1000244001,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO")]
    BufferOpaqueCaptureAddressCreateInfo = 1000257002,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO")]
    MemoryOpaqueCaptureAddressAllocateInfo = 1000257003,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO")]
    DeviceMemoryOpaqueCaptureAddressInfo = 1000257004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES")]
    PhysicalDevice8BitStorageFeatures = 1000177000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES")]
    PhysicalDeviceShaderAtomicInt64Features = 1000180000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES")]
    PhysicalDeviceShaderFloat16Int8Features = 1000082000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES")]
    PhysicalDeviceFloatControlsProperties = 1000197000,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO")]
    DescriptorSetLayoutBindingFlagsCreateInfo = 1000161000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES")]
    PhysicalDeviceDescriptorIndexingFeatures = 1000161001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES")]
    PhysicalDeviceDescriptorIndexingProperties = 1000161002,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO")]
    DescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT")]
    DescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES")]
    PhysicalDeviceScalarBlockLayoutFeatures = 1000221000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES")]
    PhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO")]
    SamplerReductionModeCreateInfo = 1000130001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES")]
    PhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES")]
    PhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2")]
    AttachmentDescription2 = 1000109000,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2")]
    AttachmentReference2 = 1000109001,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2")]
    SubpassDescription2 = 1000109002,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2")]
    SubpassDependency2 = 1000109003,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2")]
    RenderPassCreateInfo2 = 1000109004,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO")]
    SubpassBeginInfo = 1000109005,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_END_INFO")]
    SubpassEndInfo = 1000109006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES")]
    PhysicalDeviceDepthStencilResolveProperties = 1000199000,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE")]
    SubpassDescriptionDepthStencilResolve = 1000199001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO")]
    ImageStencilUsageCreateInfo = 1000246000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES")]
    PhysicalDeviceImagelessFramebufferFeatures = 1000108000,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO")]
    FramebufferAttachmentsCreateInfo = 1000108001,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO")]
    FramebufferAttachmentImageInfo = 1000108002,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO")]
    RenderPassAttachmentBeginInfo = 1000108003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES")]
    PhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT")]
    AttachmentReferenceStencilLayout = 1000241001,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT")]
    AttachmentDescriptionStencilLayout = 1000241002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_FEATURES")]
    PhysicalDeviceVulkan1x3Features = 53,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_PROPERTIES")]
    PhysicalDeviceVulkan1x3Properties = 54,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES")]
    PhysicalDeviceToolProperties = 1000245000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES")]
    PhysicalDevicePrivateDataFeatures = 1000295000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO")]
    DevicePrivateDataCreateInfo = 1000295001,

    [NativeName("VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO")]
    PrivateDataSlotCreateInfo = 1000295002,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER_2")]
    MemoryBarrier2 = 1000314000,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2")]
    BufferMemoryBarrier2 = 1000314001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2")]
    ImageMemoryBarrier2 = 1000314002,

    [NativeName("VK_STRUCTURE_TYPE_DEPENDENCY_INFO")]
    DependencyInfo = 1000314003,

    [NativeName("VK_STRUCTURE_TYPE_SUBMIT_INFO_2")]
    SubmitInfo2 = 1000314004,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO")]
    SemaphoreSubmitInfo = 1000314005,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO")]
    CommandBufferSubmitInfo = 1000314006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES")]
    PhysicalDeviceSynchronization2Features = 1000314007,

    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2")]
    CopyBufferInfo2 = 1000337000,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2")]
    CopyImageInfo2 = 1000337001,

    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2")]
    CopyBufferToImageInfo2 = 1000337002,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2")]
    CopyImageToBufferInfo2 = 1000337003,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COPY_2")]
    BufferCopy2 = 1000337006,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COPY_2")]
    ImageCopy2 = 1000337007,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2")]
    BufferImageCopy2 = 1000337009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES")]
    PhysicalDeviceTextureCompressionAstcHdrFeatures = 1000066000,

    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3")]
    FormatProperties3 = 1000360000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES")]
    PhysicalDeviceMaintenance4Features = 1000413000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES")]
    PhysicalDeviceMaintenance4Properties = 1000413001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS")]
    DeviceBufferMemoryRequirements = 1000413002,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS")]
    DeviceImageMemoryRequirements = 1000413003,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO")]
    PipelineCreationFeedbackCreateInfo = 1000192000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES")]
    PhysicalDeviceShaderTerminateInvocationFeatures = 1000215000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES")]
    PhysicalDeviceShaderDemoteToHelperInvocationFeatures = 1000276000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES")]
    PhysicalDevicePipelineCreationCacheControlFeatures = 1000297000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES")]
    PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures = 1000325000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES")]
    PhysicalDeviceImageRobustnessFeatures = 1000335000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES")]
    PhysicalDeviceSubgroupSizeControlProperties = 1000225000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO")]
    PipelineShaderStageRequiredSubgroupSizeCreateInfo = 1000225001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES")]
    PhysicalDeviceSubgroupSizeControlFeatures = 1000225002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES")]
    PhysicalDeviceInlineUniformBlockFeatures = 1000138000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES")]
    PhysicalDeviceInlineUniformBlockProperties = 1000138001,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK")]
    WriteDescriptorSetInlineUniformBlock = 1000138002,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO")]
    DescriptorPoolInlineUniformBlockCreateInfo = 1000138003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES")]
    PhysicalDeviceShaderIntegerDotProductFeatures = 1000280000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES")]
    PhysicalDeviceShaderIntegerDotProductProperties = 1000280001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES")]
    PhysicalDeviceTexelBufferAlignmentProperties = 1000281001,

    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2")]
    BlitImageInfo2 = 1000337004,

    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2")]
    ResolveImageInfo2 = 1000337005,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_BLIT_2")]
    ImageBlit2 = 1000337008,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2")]
    ImageResolve2 = 1000337010,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INFO")]
    RenderingInfo = 1000044000,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO")]
    RenderingAttachmentInfo = 1000044001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO")]
    PipelineRenderingCreateInfo = 1000044002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES")]
    PhysicalDeviceDynamicRenderingFeatures = 1000044003,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO")]
    CommandBufferInheritanceRenderingInfo = 1000044004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_4_FEATURES")]
    PhysicalDeviceVulkan1x4Features = 55,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_4_PROPERTIES")]
    PhysicalDeviceVulkan1x4Properties = 56,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO")]
    DeviceQueueGlobalPriorityCreateInfo = 1000174000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES")]
    PhysicalDeviceGlobalPriorityQueryFeatures = 1000388000,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES")]
    QueueFamilyGlobalPriorityProperties = 1000388001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES")]
    PhysicalDeviceIndexTypeUint8Features = 1000265000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MAP_INFO")]
    MemoryMapInfo = 1000271000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO")]
    MemoryUnmapInfo = 1000271001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES")]
    PhysicalDeviceMaintenance5Features = 1000470000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES")]
    PhysicalDeviceMaintenance5Properties = 1000470001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO")]
    DeviceImageSubresourceInfo = 1000470004,

    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2")]
    SubresourceLayout2 = 1000338002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2")]
    ImageSubresource2 = 1000338003,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO")]
    BufferUsageFlags2CreateInfo = 1000470006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES")]
    PhysicalDeviceMaintenance6Features = 1000545000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES")]
    PhysicalDeviceMaintenance6Properties = 1000545001,

    [NativeName("VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS")]
    BindMemoryStatus = 1000545002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES")]
    PhysicalDeviceHostImageCopyFeatures = 1000270000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES")]
    PhysicalDeviceHostImageCopyProperties = 1000270001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY")]
    MemoryToImageCopy = 1000270002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY")]
    ImageToMemoryCopy = 1000270003,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO")]
    CopyImageToMemoryInfo = 1000270004,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO")]
    CopyMemoryToImageInfo = 1000270005,

    [NativeName("VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO")]
    HostImageLayoutTransitionInfo = 1000270006,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO")]
    CopyImageToImageInfo = 1000270007,

    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE")]
    SubresourceHostMemcpySize = 1000270008,

    [NativeName("VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY")]
    HostImageCopyDevicePerformanceQuery = 1000270009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES")]
    PhysicalDeviceShaderSubgroupRotateFeatures = 1000416000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES")]
    PhysicalDeviceShaderFloatControls2Features = 1000528000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES")]
    PhysicalDeviceShaderExpectAssumeFeatures = 1000544000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO")]
    PipelineCreateFlags2CreateInfo = 1000470005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES")]
    PhysicalDevicePushDescriptorProperties = 1000080000,

    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO")]
    BindDescriptorSetsInfo = 1000545003,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO")]
    PushConstantsInfo = 1000545004,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO")]
    PushDescriptorSetInfo = 1000545005,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO")]
    PushDescriptorSetWithTemplateInfo = 1000545006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES")]
    PhysicalDevicePipelineProtectedAccessFeatures = 1000466000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO")]
    PipelineRobustnessCreateInfo = 1000068000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES")]
    PhysicalDevicePipelineRobustnessFeatures = 1000068001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES")]
    PhysicalDevicePipelineRobustnessProperties = 1000068002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES")]
    PhysicalDeviceLineRasterizationFeatures = 1000259000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO")]
    PipelineRasterizationLineStateCreateInfo = 1000259001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES")]
    PhysicalDeviceLineRasterizationProperties = 1000259002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES")]
    PhysicalDeviceVertexAttributeDivisorProperties = 1000525000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO")]
    PipelineVertexInputDivisorStateCreateInfo = 1000190001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES")]
    PhysicalDeviceVertexAttributeDivisorFeatures = 1000190002,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_AREA_INFO")]
    RenderingAreaInfo = 1000470003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES")]
    PhysicalDeviceDynamicRenderingLocalReadFeatures = 1000232000,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO")]
    RenderingAttachmentLocationInfo = 1000232001,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO")]
    RenderingInputAttachmentIndexInfo = 1000232002,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR")]
    SwapchainCreateInfoKHR = 1000001000,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_INFO_KHR")]
    PresentInfoKHR = 1000001001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR")]
    DeviceGroupPresentCapabilitiesKHR = 1000060007,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR")]
    ImageSwapchainCreateInfoKHR = 1000060008,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR")]
    BindImageMemorySwapchainInfoKHR = 1000060009,

    [NativeName("VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR")]
    AcquireNextImageInfoKHR = 1000060010,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR")]
    DeviceGroupPresentInfoKHR = 1000060011,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR")]
    DeviceGroupSwapchainCreateInfoKHR = 1000060012,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR")]
    DisplayModeCreateInfoKHR = 1000002000,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR")]
    DisplaySurfaceCreateInfoKHR = 1000002001,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR")]
    DisplayPresentInfoKHR = 1000003000,

    [NativeName("VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR")]
    XlibSurfaceCreateInfoKHR = 1000004000,

    [NativeName("VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR")]
    XcbSurfaceCreateInfoKHR = 1000005000,

    [NativeName("VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR")]
    WaylandSurfaceCreateInfoKHR = 1000006000,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR")]
    AndroidSurfaceCreateInfoKHR = 1000008000,

    [NativeName("VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR")]
    Win32SurfaceCreateInfoKHR = 1000009000,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT")]
    DebugReportCallbackCreateInfoEXT = 1000011000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD")]
    PipelineRasterizationStateRasterizationOrderAMD = 1000018000,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT")]
    DebugMarkerObjectNameInfoEXT = 1000022000,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT")]
    DebugMarkerObjectTagInfoEXT = 1000022001,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT")]
    DebugMarkerMarkerInfoEXT = 1000022002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR")]
    VideoProfileInfoKHR = 1000023000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR")]
    VideoCapabilitiesKHR = 1000023001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR")]
    VideoPictureResourceInfoKHR = 1000023002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR")]
    VideoSessionMemoryRequirementsKHR = 1000023003,

    [NativeName("VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR")]
    BindVideoSessionMemoryInfoKHR = 1000023004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR")]
    VideoSessionCreateInfoKHR = 1000023005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    VideoSessionParametersCreateInfoKHR = 1000023006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR")]
    VideoSessionParametersUpdateInfoKHR = 1000023007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR")]
    VideoBeginCodingInfoKHR = 1000023008,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR")]
    VideoEndCodingInfoKHR = 1000023009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR")]
    VideoCodingControlInfoKHR = 1000023010,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR")]
    VideoReferenceSlotInfoKHR = 1000023011,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR")]
    QueueFamilyVideoPropertiesKHR = 1000023012,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR")]
    VideoProfileListInfoKHR = 1000023013,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR")]
    PhysicalDeviceVideoFormatInfoKHR = 1000023014,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR")]
    VideoFormatPropertiesKHR = 1000023015,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR")]
    QueueFamilyQueryResultStatusPropertiesKHR = 1000023016,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR")]
    VideoDecodeInfoKHR = 1000024000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR")]
    VideoDecodeCapabilitiesKHR = 1000024001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR")]
    VideoDecodeUsageInfoKHR = 1000024002,

    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV")]
    DedicatedAllocationImageCreateInfoNV = 1000026000,

    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV")]
    DedicatedAllocationBufferCreateInfoNV = 1000026001,

    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV")]
    DedicatedAllocationMemoryAllocateInfoNV = 1000026002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT")]
    PhysicalDeviceTransformFeedbackFeaturesEXT = 1000028000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT")]
    PhysicalDeviceTransformFeedbackPropertiesEXT = 1000028001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT")]
    PipelineRasterizationStateStreamCreateInfoEXT = 1000028002,

    [NativeName("VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX")]
    CuModuleCreateInfoNVX = 1000029000,

    [NativeName("VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX")]
    CuFunctionCreateInfoNVX = 1000029001,

    [NativeName("VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX")]
    CuLaunchInfoNVX = 1000029002,

    [NativeName("VK_STRUCTURE_TYPE_CU_MODULE_TEXTURING_MODE_CREATE_INFO_NVX")]
    CuModuleTexturingModeCreateInfoNVX = 1000029004,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX")]
    ImageViewHandleInfoNVX = 1000030000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX")]
    ImageViewAddressPropertiesNVX = 1000030001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_KHR")]
    VideoEncodeH264CapabilitiesKHR = 1000038000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    VideoEncodeH264SessionParametersCreateInfoKHR = 1000038001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR")]
    VideoEncodeH264SessionParametersAddInfoKHR = 1000038002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_KHR")]
    VideoEncodeH264PictureInfoKHR = 1000038003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_KHR")]
    VideoEncodeH264DpbSlotInfoKHR = 1000038004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_KHR")]
    VideoEncodeH264NaluSliceInfoKHR = 1000038005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_GOP_REMAINING_FRAME_INFO_KHR")]
    VideoEncodeH264GopRemainingFrameInfoKHR = 1000038006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_KHR")]
    VideoEncodeH264ProfileInfoKHR = 1000038007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_KHR")]
    VideoEncodeH264RateControlInfoKHR = 1000038008,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_KHR")]
    VideoEncodeH264RateControlLayerInfoKHR = 1000038009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_KHR")]
    VideoEncodeH264SessionCreateInfoKHR = 1000038010,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUALITY_LEVEL_PROPERTIES_KHR")]
    VideoEncodeH264QualityLevelPropertiesKHR = 1000038011,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_GET_INFO_KHR")]
    VideoEncodeH264SessionParametersGetInfoKHR = 1000038012,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    VideoEncodeH264SessionParametersFeedbackInfoKHR = 1000038013,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_KHR")]
    VideoEncodeH265CapabilitiesKHR = 1000039000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    VideoEncodeH265SessionParametersCreateInfoKHR = 1000039001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR")]
    VideoEncodeH265SessionParametersAddInfoKHR = 1000039002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PICTURE_INFO_KHR")]
    VideoEncodeH265PictureInfoKHR = 1000039003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_KHR")]
    VideoEncodeH265DpbSlotInfoKHR = 1000039004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_KHR")]
    VideoEncodeH265NaluSliceSegmentInfoKHR = 1000039005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_GOP_REMAINING_FRAME_INFO_KHR")]
    VideoEncodeH265GopRemainingFrameInfoKHR = 1000039006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_KHR")]
    VideoEncodeH265ProfileInfoKHR = 1000039007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_KHR")]
    VideoEncodeH265RateControlInfoKHR = 1000039009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_KHR")]
    VideoEncodeH265RateControlLayerInfoKHR = 1000039010,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_KHR")]
    VideoEncodeH265SessionCreateInfoKHR = 1000039011,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUALITY_LEVEL_PROPERTIES_KHR")]
    VideoEncodeH265QualityLevelPropertiesKHR = 1000039012,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_GET_INFO_KHR")]
    VideoEncodeH265SessionParametersGetInfoKHR = 1000039013,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    VideoEncodeH265SessionParametersFeedbackInfoKHR = 1000039014,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR")]
    VideoDecodeH264CapabilitiesKHR = 1000040000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR")]
    VideoDecodeH264PictureInfoKHR = 1000040001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR")]
    VideoDecodeH264ProfileInfoKHR = 1000040003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    VideoDecodeH264SessionParametersCreateInfoKHR = 1000040004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR")]
    VideoDecodeH264SessionParametersAddInfoKHR = 1000040005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR")]
    VideoDecodeH264DpbSlotInfoKHR = 1000040006,

    [NativeName("VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD")]
    TextureLodGatherFormatPropertiesAMD = 1000041000,

    [NativeName("VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP")]
    StreamDescriptorSurfaceCreateInfoGGP = 1000049000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV")]
    PhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV")]
    ExternalMemoryImageCreateInfoNV = 1000056000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV")]
    ExportMemoryAllocateInfoNV = 1000056001,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV")]
    ImportMemoryWin32HandleInfoNV = 1000057000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV")]
    ExportMemoryWin32HandleInfoNV = 1000057001,

    [NativeName("VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV")]
    Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,

    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT")]
    ValidationFlagsEXT = 1000061000,

    [NativeName("VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN")]
    ViSurfaceCreateInfoNN = 1000062000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT")]
    ImageViewAstcDecodeModeEXT = 1000067000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT")]
    PhysicalDeviceAstcDecodeFeaturesEXT = 1000067001,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR")]
    ImportMemoryWin32HandleInfoKHR = 1000073000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR")]
    ExportMemoryWin32HandleInfoKHR = 1000073001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR")]
    MemoryWin32HandlePropertiesKHR = 1000073002,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR")]
    MemoryGetWin32HandleInfoKHR = 1000073003,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR")]
    ImportMemoryFdInfoKHR = 1000074000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR")]
    MemoryFdPropertiesKHR = 1000074001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR")]
    MemoryGetFdInfoKHR = 1000074002,

    [NativeName("VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR")]
    Win32KeyedMutexAcquireReleaseInfoKHR = 1000075000,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR")]
    ImportSemaphoreWin32HandleInfoKHR = 1000078000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR")]
    ExportSemaphoreWin32HandleInfoKHR = 1000078001,

    [NativeName("VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR")]
    D3D12FenceSubmitInfoKHR = 1000078002,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR")]
    SemaphoreGetWin32HandleInfoKHR = 1000078003,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR")]
    ImportSemaphoreFdInfoKHR = 1000079000,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR")]
    SemaphoreGetFdInfoKHR = 1000079001,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT")]
    CommandBufferInheritanceConditionalRenderingInfoEXT = 1000081000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT")]
    PhysicalDeviceConditionalRenderingFeaturesEXT = 1000081001,

    [NativeName("VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT")]
    ConditionalRenderingBeginInfoEXT = 1000081002,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR")]
    PresentRegionsKHR = 1000084000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV")]
    PipelineViewportWScalingStateCreateInfoNV = 1000087000,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT")]
    SurfaceCapabilities2EXT = 1000090000,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT")]
    DisplayPowerInfoEXT = 1000091000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT")]
    DeviceEventInfoEXT = 1000091001,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT")]
    DisplayEventInfoEXT = 1000091002,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT")]
    SwapchainCounterCreateInfoEXT = 1000091003,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE")]
    PresentTimesInfoGOOGLE = 1000092000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX")]
    PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX = 1000097000,

    [NativeName("VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX")]
    MultiviewPerViewAttributesInfoNVX = 1000044009,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV")]
    PipelineViewportSwizzleStateCreateInfoNV = 1000098000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT")]
    PhysicalDeviceDiscardRectanglePropertiesEXT = 1000099000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT")]
    PipelineDiscardRectangleStateCreateInfoEXT = 1000099001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT")]
    PhysicalDeviceConservativeRasterizationPropertiesEXT = 1000101000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT")]
    PipelineRasterizationConservativeStateCreateInfoEXT = 1000101001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT")]
    PhysicalDeviceDepthClipEnableFeaturesEXT = 1000102000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT")]
    PipelineRasterizationDepthClipStateCreateInfoEXT = 1000102001,

    [NativeName("VK_STRUCTURE_TYPE_HDR_METADATA_EXT")]
    HdrMetadataEXT = 1000105000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RELAXED_LINE_RASTERIZATION_FEATURES_IMG")]
    PhysicalDeviceRelaxedLineRasterizationFeaturesIMG = 1000110000,

    [NativeName("VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR")]
    SharedPresentSurfaceCapabilitiesKHR = 1000111000,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR")]
    ImportFenceWin32HandleInfoKHR = 1000114000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR")]
    ExportFenceWin32HandleInfoKHR = 1000114001,

    [NativeName("VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR")]
    FenceGetWin32HandleInfoKHR = 1000114002,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR")]
    ImportFenceFdInfoKHR = 1000115000,

    [NativeName("VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR")]
    FenceGetFdInfoKHR = 1000115001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR")]
    PhysicalDevicePerformanceQueryFeaturesKHR = 1000116000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR")]
    PhysicalDevicePerformanceQueryPropertiesKHR = 1000116001,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR")]
    QueryPoolPerformanceCreateInfoKHR = 1000116002,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR")]
    PerformanceQuerySubmitInfoKHR = 1000116003,

    [NativeName("VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR")]
    AcquireProfilingLockInfoKHR = 1000116004,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR")]
    PerformanceCounterKHR = 1000116005,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR")]
    PerformanceCounterDescriptionKHR = 1000116006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR")]
    PhysicalDeviceSurfaceInfo2KHR = 1000119000,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR")]
    SurfaceCapabilities2KHR = 1000119001,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR")]
    SurfaceFormat2KHR = 1000119002,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR")]
    DisplayProperties2KHR = 1000121000,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR")]
    DisplayPlaneProperties2KHR = 1000121001,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR")]
    DisplayModeProperties2KHR = 1000121002,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR")]
    DisplayPlaneInfo2KHR = 1000121003,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR")]
    DisplayPlaneCapabilities2KHR = 1000121004,

    [NativeName("VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK")]
    IosSurfaceCreateInfoMVK = 1000122000,

    [NativeName("VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK")]
    MacosSurfaceCreateInfoMVK = 1000123000,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
    DebugUtilsObjectNameInfoEXT = 1000128000,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT")]
    DebugUtilsObjectTagInfoEXT = 1000128001,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT")]
    DebugUtilsLabelEXT = 1000128002,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
    DebugUtilsMessengerCallbackDataEXT = 1000128003,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
    DebugUtilsMessengerCreateInfoEXT = 1000128004,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID")]
    AndroidHardwareBufferUsageANDROID = 1000129000,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID")]
    AndroidHardwareBufferPropertiesANDROID = 1000129001,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID")]
    AndroidHardwareBufferFormatPropertiesANDROID = 1000129002,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID")]
    ImportAndroidHardwareBufferInfoANDROID = 1000129003,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID")]
    MemoryGetAndroidHardwareBufferInfoANDROID = 1000129004,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID")]
    ExternalFormatANDROID = 1000129005,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID")]
    AndroidHardwareBufferFormatProperties2ANDROID = 1000129006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GPA_FEATURES_AMD")]
    PhysicalDeviceGpaFeaturesAMD = 1000133000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GPA_PROPERTIES_AMD")]
    PhysicalDeviceGpaPropertiesAMD = 1000133001,

    [NativeName("VK_STRUCTURE_TYPE_GPA_SAMPLE_BEGIN_INFO_AMD")]
    GpaSampleBeginInfoAMD = 1000133002,

    [NativeName("VK_STRUCTURE_TYPE_GPA_SESSION_CREATE_INFO_AMD")]
    GpaSessionCreateInfoAMD = 1000133003,

    [NativeName("VK_STRUCTURE_TYPE_GPA_DEVICE_CLOCK_MODE_INFO_AMD")]
    GpaDeviceClockModeInfoAMD = 1000133004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GPA_PROPERTIES_2_AMD")]
    PhysicalDeviceGpaProperties2AMD = 1000133005,

    [NativeName("VK_STRUCTURE_TYPE_GPA_DEVICE_GET_CLOCK_INFO_AMD")]
    GpaDeviceGetClockInfoAMD = 1000133006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ENQUEUE_FEATURES_AMDX")]
    PhysicalDeviceShaderEnqueueFeaturesAMDX = 1000134000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ENQUEUE_PROPERTIES_AMDX")]
    PhysicalDeviceShaderEnqueuePropertiesAMDX = 1000134001,

    [NativeName("VK_STRUCTURE_TYPE_EXECUTION_GRAPH_PIPELINE_SCRATCH_SIZE_AMDX")]
    ExecutionGraphPipelineScratchSizeAMDX = 1000134002,

    [NativeName("VK_STRUCTURE_TYPE_EXECUTION_GRAPH_PIPELINE_CREATE_INFO_AMDX")]
    ExecutionGraphPipelineCreateInfoAMDX = 1000134003,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_NODE_CREATE_INFO_AMDX")]
    PipelineShaderStageNodeCreateInfoAMDX = 1000134004,

    [NativeName("VK_STRUCTURE_TYPE_TEXEL_BUFFER_DESCRIPTOR_INFO_EXT")]
    TexelBufferDescriptorInfoEXT = 1000135000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_DESCRIPTOR_INFO_EXT")]
    ImageDescriptorInfoEXT = 1000135001,

    [NativeName("VK_STRUCTURE_TYPE_RESOURCE_DESCRIPTOR_INFO_EXT")]
    ResourceDescriptorInfoEXT = 1000135002,

    [NativeName("VK_STRUCTURE_TYPE_BIND_HEAP_INFO_EXT")]
    BindHeapInfoEXT = 1000135003,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DATA_INFO_EXT")]
    PushDataInfoEXT = 1000135004,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_AND_BINDING_MAPPING_EXT")]
    DescriptorSetAndBindingMappingEXT = 1000135005,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_DESCRIPTOR_SET_AND_BINDING_MAPPING_INFO_EXT")]
    ShaderDescriptorSetAndBindingMappingInfoEXT = 1000135006,

    [NativeName("VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DATA_CREATE_INFO_EXT")]
    OpaqueCaptureDataCreateInfoEXT = 1000135007,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_HEAP_PROPERTIES_EXT")]
    PhysicalDeviceDescriptorHeapPropertiesEXT = 1000135008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_HEAP_FEATURES_EXT")]
    PhysicalDeviceDescriptorHeapFeaturesEXT = 1000135009,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_DESCRIPTOR_HEAP_INFO_EXT")]
    CommandBufferInheritanceDescriptorHeapInfoEXT = 1000135010,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_INDEX_CREATE_INFO_EXT")]
    SamplerCustomBorderColorIndexCreateInfoEXT = 1000135011,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_PUSH_DATA_TOKEN_NV")]
    IndirectCommandsLayoutPushDataTokenNV = 1000135012,

    [NativeName("VK_STRUCTURE_TYPE_SUBSAMPLED_IMAGE_FORMAT_PROPERTIES_EXT")]
    SubsampledImageFormatPropertiesEXT = 1000135013,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_HEAP_TENSOR_PROPERTIES_ARM")]
    PhysicalDeviceDescriptorHeapTensorPropertiesARM = 1000135014,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD")]
    AttachmentSampleCountInfoAMD = 1000044008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_BFLOAT16_FEATURES_KHR")]
    PhysicalDeviceShaderBfloat16FeaturesKHR = 1000141000,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT")]
    SampleLocationsInfoEXT = 1000143000,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT")]
    RenderPassSampleLocationsBeginInfoEXT = 1000143001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT")]
    PipelineSampleLocationsStateCreateInfoEXT = 1000143002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT")]
    PhysicalDeviceSampleLocationsPropertiesEXT = 1000143003,

    [NativeName("VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT")]
    MultisamplePropertiesEXT = 1000143004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT")]
    PhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT")]
    PhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT")]
    PipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV")]
    PipelineCoverageToColorStateCreateInfoNV = 1000149000,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR")]
    WriteDescriptorSetAccelerationStructureKHR = 1000150007,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR")]
    AccelerationStructureBuildGeometryInfoKHR = 1000150000,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR")]
    AccelerationStructureDeviceAddressInfoKHR = 1000150002,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR")]
    AccelerationStructureGeometryAabbsDataKHR = 1000150003,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR")]
    AccelerationStructureGeometryInstancesDataKHR = 1000150004,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR")]
    AccelerationStructureGeometryTrianglesDataKHR = 1000150005,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR")]
    AccelerationStructureGeometryKHR = 1000150006,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR")]
    AccelerationStructureVersionInfoKHR = 1000150009,

    [NativeName("VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR")]
    CopyAccelerationStructureInfoKHR = 1000150010,

    [NativeName("VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR")]
    CopyAccelerationStructureToMemoryInfoKHR = 1000150011,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR")]
    CopyMemoryToAccelerationStructureInfoKHR = 1000150012,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR")]
    PhysicalDeviceAccelerationStructureFeaturesKHR = 1000150013,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR")]
    PhysicalDeviceAccelerationStructurePropertiesKHR = 1000150014,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR")]
    AccelerationStructureCreateInfoKHR = 1000150017,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR")]
    AccelerationStructureBuildSizesInfoKHR = 1000150020,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR")]
    PhysicalDeviceRayTracingPipelineFeaturesKHR = 1000347000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR")]
    PhysicalDeviceRayTracingPipelinePropertiesKHR = 1000347001,

    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR")]
    RayTracingPipelineCreateInfoKHR = 1000150015,

    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR")]
    RayTracingShaderGroupCreateInfoKHR = 1000150016,

    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR")]
    RayTracingPipelineInterfaceCreateInfoKHR = 1000150018,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR")]
    PhysicalDeviceRayQueryFeaturesKHR = 1000348013,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV")]
    PipelineCoverageModulationStateCreateInfoNV = 1000152000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV")]
    PhysicalDeviceShaderSmBuiltinsFeaturesNV = 1000154000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV")]
    PhysicalDeviceShaderSmBuiltinsPropertiesNV = 1000154001,

    [NativeName("VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT")]
    DrmFormatModifierPropertiesListEXT = 1000158000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT")]
    PhysicalDeviceImageDrmFormatModifierInfoEXT = 1000158002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT")]
    ImageDrmFormatModifierListCreateInfoEXT = 1000158003,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT")]
    ImageDrmFormatModifierExplicitCreateInfoEXT = 1000158004,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT")]
    ImageDrmFormatModifierPropertiesEXT = 1000158005,

    [NativeName("VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT")]
    DrmFormatModifierPropertiesList2EXT = 1000158006,

    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT")]
    ValidationCacheCreateInfoEXT = 1000160000,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT")]
    ShaderModuleValidationCacheCreateInfoEXT = 1000160001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_FEATURES_KHR")]
    PhysicalDevicePortabilitySubsetFeaturesKHR = 1000163000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_PROPERTIES_KHR")]
    PhysicalDevicePortabilitySubsetPropertiesKHR = 1000163001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV")]
    PipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV")]
    PhysicalDeviceShadingRateImageFeaturesNV = 1000164001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV")]
    PhysicalDeviceShadingRateImagePropertiesNV = 1000164002,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV")]
    PipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,

    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV")]
    RayTracingPipelineCreateInfoNV = 1000165000,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV")]
    AccelerationStructureCreateInfoNV = 1000165001,

    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_NV")]
    GeometryNV = 1000165003,

    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV")]
    GeometryTrianglesNV = 1000165004,

    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV")]
    GeometryAabbNV = 1000165005,

    [NativeName("VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV")]
    BindAccelerationStructureMemoryInfoNV = 1000165006,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV")]
    WriteDescriptorSetAccelerationStructureNV = 1000165007,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV")]
    AccelerationStructureMemoryRequirementsInfoNV = 1000165008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV")]
    PhysicalDeviceRayTracingPropertiesNV = 1000165009,

    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV")]
    RayTracingShaderGroupCreateInfoNV = 1000165011,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV")]
    AccelerationStructureInfoNV = 1000165012,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV")]
    PhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV")]
    PipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT")]
    PhysicalDeviceImageViewImageFormatInfoEXT = 1000170000,

    [NativeName("VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT")]
    FilterCubicImageViewImageFormatPropertiesEXT = 1000170001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_CONVERSION_FEATURES_QCOM")]
    PhysicalDeviceCooperativeMatrixConversionFeaturesQCOM = 1000172000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ELAPSED_TIMER_QUERY_FEATURES_QCOM")]
    PhysicalDeviceElapsedTimerQueryFeaturesQCOM = 1000173000,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT")]
    ImportMemoryHostPointerInfoEXT = 1000178000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT")]
    MemoryHostPointerPropertiesEXT = 1000178001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT")]
    PhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR")]
    PhysicalDeviceShaderClockFeaturesKHR = 1000181000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD")]
    PipelineCompilerControlCreateInfoAMD = 1000183000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD")]
    PhysicalDeviceShaderCorePropertiesAMD = 1000185000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR")]
    VideoDecodeH265CapabilitiesKHR = 1000187000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    VideoDecodeH265SessionParametersCreateInfoKHR = 1000187001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR")]
    VideoDecodeH265SessionParametersAddInfoKHR = 1000187002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR")]
    VideoDecodeH265ProfileInfoKHR = 1000187003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR")]
    VideoDecodeH265PictureInfoKHR = 1000187004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_KHR")]
    VideoDecodeH265DpbSlotInfoKHR = 1000187005,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD")]
    DeviceMemoryOverallocationCreateInfoAMD = 1000189000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT")]
    PhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP")]
    PresentFrameTokenGGP = 1000191000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV")]
    PhysicalDeviceMeshShaderFeaturesNV = 1000202000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV")]
    PhysicalDeviceMeshShaderPropertiesNV = 1000202001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV")]
    PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV")]
    PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV")]
    PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,

    [NativeName("VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV")]
    CheckpointDataNV = 1000206000,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV")]
    QueueFamilyCheckpointPropertiesNV = 1000206001,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV")]
    QueueFamilyCheckpointProperties2NV = 1000314008,

    [NativeName("VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV")]
    CheckpointData2NV = 1000314009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_TIMING_FEATURES_EXT")]
    PhysicalDevicePresentTimingFeaturesEXT = 1000208000,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_TIMING_PROPERTIES_EXT")]
    SwapchainTimingPropertiesEXT = 1000208001,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_TIME_DOMAIN_PROPERTIES_EXT")]
    SwapchainTimeDomainPropertiesEXT = 1000208002,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_TIMINGS_INFO_EXT")]
    PresentTimingsInfoEXT = 1000208003,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_TIMING_INFO_EXT")]
    PresentTimingInfoEXT = 1000208004,

    [NativeName("VK_STRUCTURE_TYPE_PAST_PRESENTATION_TIMING_INFO_EXT")]
    PastPresentationTimingInfoEXT = 1000208005,

    [NativeName("VK_STRUCTURE_TYPE_PAST_PRESENTATION_TIMING_PROPERTIES_EXT")]
    PastPresentationTimingPropertiesEXT = 1000208006,

    [NativeName("VK_STRUCTURE_TYPE_PAST_PRESENTATION_TIMING_EXT")]
    PastPresentationTimingEXT = 1000208007,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_TIMING_SURFACE_CAPABILITIES_EXT")]
    PresentTimingSurfaceCapabilitiesEXT = 1000208008,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_CALIBRATED_TIMESTAMP_INFO_EXT")]
    SwapchainCalibratedTimestampInfoEXT = 1000208009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL")]
    PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL = 1000209000,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL")]
    QueryPoolPerformanceQueryCreateInfoINTEL = 1000210000,

    [NativeName("VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL")]
    InitializePerformanceApiInfoINTEL = 1000210001,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL")]
    PerformanceMarkerInfoINTEL = 1000210002,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL")]
    PerformanceStreamMarkerInfoINTEL = 1000210003,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL")]
    PerformanceOverrideInfoINTEL = 1000210004,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL")]
    PerformanceConfigurationAcquireInfoINTEL = 1000210005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT")]
    PhysicalDevicePciBusInfoPropertiesEXT = 1000212000,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD")]
    DisplayNativeHdrSurfaceCapabilitiesAMD = 1000213000,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD")]
    SwapchainDisplayNativeHdrCreateInfoAMD = 1000213001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA")]
    ImagepipeSurfaceCreateInfoFUCHSIA = 1000214000,

    [NativeName("VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT")]
    MetalSurfaceCreateInfoEXT = 1000217000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT")]
    PhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT")]
    PhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT")]
    RenderPassFragmentDensityMapCreateInfoEXT = 1000218002,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT")]
    RenderingFragmentDensityMapAttachmentInfoEXT = 1000044007,

    [NativeName("VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR")]
    FragmentShadingRateAttachmentInfoKHR = 1000226000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR")]
    PipelineFragmentShadingRateStateCreateInfoKHR = 1000226001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR")]
    PhysicalDeviceFragmentShadingRatePropertiesKHR = 1000226002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR")]
    PhysicalDeviceFragmentShadingRateFeaturesKHR = 1000226003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR")]
    PhysicalDeviceFragmentShadingRateKHR = 1000226004,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR")]
    RenderingFragmentShadingRateAttachmentInfoKHR = 1000044006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD")]
    PhysicalDeviceShaderCoreProperties2AMD = 1000227000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD")]
    PhysicalDeviceCoherentMemoryFeaturesAMD = 1000229000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CONSTANT_DATA_FEATURES_KHR")]
    PhysicalDeviceShaderConstantDataFeaturesKHR = 1000231000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ABORT_FEATURES_KHR")]
    PhysicalDeviceShaderAbortFeaturesKHR = 1000233000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_SHADER_ABORT_MESSAGE_INFO_KHR")]
    DeviceFaultShaderAbortMessageInfoKHR = 1000233001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ABORT_PROPERTIES_KHR")]
    PhysicalDeviceShaderAbortPropertiesKHR = 1000233002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT")]
    PhysicalDeviceShaderImageAtomicInt64FeaturesEXT = 1000234000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_QUAD_CONTROL_FEATURES_KHR")]
    PhysicalDeviceShaderQuadControlFeaturesKHR = 1000235000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT")]
    PhysicalDeviceMemoryBudgetPropertiesEXT = 1000237000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT")]
    PhysicalDeviceMemoryPriorityFeaturesEXT = 1000238000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT")]
    MemoryPriorityAllocateInfoEXT = 1000238001,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR")]
    SurfaceProtectedCapabilitiesKHR = 1000239000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV"
    )]
    PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT")]
    PhysicalDeviceBufferDeviceAddressFeaturesEXT = 1000244000,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT")]
    BufferDeviceAddressCreateInfoEXT = 1000244002,

    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT")]
    ValidationFeaturesEXT = 1000247000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR")]
    PhysicalDevicePresentWaitFeaturesKHR = 1000248000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV")]
    PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,

    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV")]
    CooperativeMatrixPropertiesNV = 1000249001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV")]
    PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV")]
    PhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV")]
    PipelineCoverageReductionStateCreateInfoNV = 1000250001,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV")]
    FramebufferMixedSamplesCombinationNV = 1000250002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT")]
    PhysicalDeviceFragmentShaderInterlockFeaturesEXT = 1000251000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT")]
    PhysicalDeviceYcbcrImageArraysFeaturesEXT = 1000252000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT")]
    PhysicalDeviceProvokingVertexFeaturesEXT = 1000254000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT")]
    PipelineRasterizationProvokingVertexStateCreateInfoEXT = 1000254001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT")]
    PhysicalDeviceProvokingVertexPropertiesEXT = 1000254002,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT")]
    SurfaceFullScreenExclusiveInfoEXT = 1000255000,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT")]
    SurfaceCapabilitiesFullScreenExclusiveEXT = 1000255002,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT")]
    SurfaceFullScreenExclusiveWin32InfoEXT = 1000255001,

    [NativeName("VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT")]
    HeadlessSurfaceCreateInfoEXT = 1000256000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT")]
    PhysicalDeviceShaderAtomicFloatFeaturesEXT = 1000260000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT")]
    PhysicalDeviceExtendedDynamicStateFeaturesEXT = 1000267000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR")]
    PhysicalDevicePipelineExecutablePropertiesFeaturesKHR = 1000269000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR")]
    PipelineInfoKHR = 1000269001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR")]
    PipelineExecutablePropertiesKHR = 1000269002,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR")]
    PipelineExecutableInfoKHR = 1000269003,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR")]
    PipelineExecutableStatisticKHR = 1000269004,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR")]
    PipelineExecutableInternalRepresentationKHR = 1000269005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_FEATURES_EXT")]
    PhysicalDeviceMapMemoryPlacedFeaturesEXT = 1000272000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_PROPERTIES_EXT")]
    PhysicalDeviceMapMemoryPlacedPropertiesEXT = 1000272001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MAP_PLACED_INFO_EXT")]
    MemoryMapPlacedInfoEXT = 1000272002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT")]
    PhysicalDeviceShaderAtomicFloat2FeaturesEXT = 1000273000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV")]
    PhysicalDeviceDeviceGeneratedCommandsPropertiesNV = 1000277000,

    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV")]
    GraphicsShaderGroupCreateInfoNV = 1000277001,

    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV")]
    GraphicsPipelineShaderGroupsCreateInfoNV = 1000277002,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV")]
    IndirectCommandsLayoutTokenNV = 1000277003,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV")]
    IndirectCommandsLayoutCreateInfoNV = 1000277004,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV")]
    GeneratedCommandsInfoNV = 1000277005,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV")]
    GeneratedCommandsMemoryRequirementsInfoNV = 1000277006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV")]
    PhysicalDeviceDeviceGeneratedCommandsFeaturesNV = 1000277007,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV")]
    PhysicalDeviceInheritedViewportScissorFeaturesNV = 1000278000,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV")]
    CommandBufferInheritanceViewportScissorInfoNV = 1000278001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT")]
    PhysicalDeviceTexelBufferAlignmentFeaturesEXT = 1000281000,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM")]
    CommandBufferInheritanceRenderPassTransformInfoQCOM = 1000282000,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM")]
    RenderPassTransformBeginInfoQCOM = 1000282001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT")]
    PhysicalDeviceDepthBiasControlFeaturesEXT = 1000283000,

    [NativeName("VK_STRUCTURE_TYPE_DEPTH_BIAS_INFO_EXT")]
    DepthBiasInfoEXT = 1000283001,

    [NativeName("VK_STRUCTURE_TYPE_DEPTH_BIAS_REPRESENTATION_INFO_EXT")]
    DepthBiasRepresentationInfoEXT = 1000283002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT")]
    PhysicalDeviceDeviceMemoryReportFeaturesEXT = 1000284000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT")]
    DeviceDeviceMemoryReportCreateInfoEXT = 1000284001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT")]
    DeviceMemoryReportCallbackDataEXT = 1000284002,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT")]
    SamplerCustomBorderColorCreateInfoEXT = 1000287000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT")]
    PhysicalDeviceCustomBorderColorPropertiesEXT = 1000287001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT")]
    PhysicalDeviceCustomBorderColorFeaturesEXT = 1000287002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_3D_FEATURES_EXT")]
    PhysicalDeviceTextureCompressionAstc3DFeaturesEXT = 1000288000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR")]
    PipelineLibraryCreateInfoKHR = 1000290000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV")]
    PhysicalDevicePresentBarrierFeaturesNV = 1000292000,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV")]
    SurfaceCapabilitiesPresentBarrierNV = 1000292001,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV")]
    SwapchainPresentBarrierCreateInfoNV = 1000292002,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_ID_KHR")]
    PresentIdKHR = 1000294000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR")]
    PhysicalDevicePresentIdFeaturesKHR = 1000294001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR")]
    VideoEncodeInfoKHR = 1000299000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR")]
    VideoEncodeRateControlInfoKHR = 1000299001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR")]
    VideoEncodeRateControlLayerInfoKHR = 1000299002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR")]
    VideoEncodeCapabilitiesKHR = 1000299003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR")]
    VideoEncodeUsageInfoKHR = 1000299004,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR")]
    QueryPoolVideoEncodeFeedbackCreateInfoKHR = 1000299005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR")]
    PhysicalDeviceVideoEncodeQualityLevelInfoKHR = 1000299006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_PROPERTIES_KHR")]
    VideoEncodeQualityLevelPropertiesKHR = 1000299007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR")]
    VideoEncodeQualityLevelInfoKHR = 1000299008,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_GET_INFO_KHR")]
    VideoEncodeSessionParametersGetInfoKHR = 1000299009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    VideoEncodeSessionParametersFeedbackInfoKHR = 1000299010,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV")]
    PhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV")]
    DeviceDiagnosticsConfigCreateInfoNV = 1000300001,

    [NativeName("VK_STRUCTURE_TYPE_PERF_HINT_INFO_QCOM")]
    PerfHintInfoQCOM = 1000302000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_PERF_HINT_FEATURES_QCOM")]
    PhysicalDeviceQueuePerfHintFeaturesQCOM = 1000302001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_PERF_HINT_PROPERTIES_QCOM")]
    PhysicalDeviceQueuePerfHintPropertiesQCOM = 1000302002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_3_FEATURES_QCOM")]
    PhysicalDeviceImageProcessing3FeaturesQCOM = 1000303000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MULTIPLE_WAIT_QUEUES_FEATURES_QCOM")]
    PhysicalDeviceShaderMultipleWaitQueuesFeaturesQCOM = 1000304000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MULTIPLE_WAIT_QUEUES_PROPERTIES_QCOM")]
    PhysicalDeviceShaderMultipleWaitQueuesPropertiesQCOM = 1000304001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SPLIT_BARRIER_FEATURES_EXT")]
    PhysicalDeviceShaderSplitBarrierFeaturesEXT = 1000305000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SPLIT_BARRIER_PROPERTIES_EXT")]
    PhysicalDeviceShaderSplitBarrierPropertiesEXT = 1000305001,

    [NativeName("VK_STRUCTURE_TYPE_CUDA_MODULE_CREATE_INFO_NV")]
    CudaModuleCreateInfoNV = 1000307000,

    [NativeName("VK_STRUCTURE_TYPE_CUDA_FUNCTION_CREATE_INFO_NV")]
    CudaFunctionCreateInfoNV = 1000307001,

    [NativeName("VK_STRUCTURE_TYPE_CUDA_LAUNCH_INFO_NV")]
    CudaLaunchInfoNV = 1000307002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUDA_KERNEL_LAUNCH_FEATURES_NV")]
    PhysicalDeviceCudaKernelLaunchFeaturesNV = 1000307003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUDA_KERNEL_LAUNCH_PROPERTIES_NV")]
    PhysicalDeviceCudaKernelLaunchPropertiesNV = 1000307004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_FEATURES_QCOM")]
    PhysicalDeviceTileShadingFeaturesQCOM = 1000309000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_PROPERTIES_QCOM")]
    PhysicalDeviceTileShadingPropertiesQCOM = 1000309001,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_TILE_SHADING_CREATE_INFO_QCOM")]
    RenderPassTileShadingCreateInfoQCOM = 1000309002,

    [NativeName("VK_STRUCTURE_TYPE_PER_TILE_BEGIN_INFO_QCOM")]
    PerTileBeginInfoQCOM = 1000309003,

    [NativeName("VK_STRUCTURE_TYPE_PER_TILE_END_INFO_QCOM")]
    PerTileEndInfoQCOM = 1000309004,

    [NativeName("VK_STRUCTURE_TYPE_DISPATCH_TILE_INFO_QCOM")]
    DispatchTileInfoQCOM = 1000309005,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV")]
    QueryLowLatencySupportNV = 1000310000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT")]
    ExportMetalObjectCreateInfoEXT = 1000311000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT")]
    ExportMetalObjectsInfoEXT = 1000311001,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT")]
    ExportMetalDeviceInfoEXT = 1000311002,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT")]
    ExportMetalCommandQueueInfoEXT = 1000311003,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT")]
    ExportMetalBufferInfoEXT = 1000311004,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT")]
    ImportMetalBufferInfoEXT = 1000311005,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT")]
    ExportMetalTextureInfoEXT = 1000311006,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT")]
    ImportMetalTextureInfoEXT = 1000311007,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT")]
    ExportMetalIoSurfaceInfoEXT = 1000311008,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT")]
    ImportMetalIoSurfaceInfoEXT = 1000311009,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT")]
    ExportMetalSharedEventInfoEXT = 1000311010,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT")]
    ImportMetalSharedEventInfoEXT = 1000311011,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT")]
    PhysicalDeviceDescriptorBufferPropertiesEXT = 1000316000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_DENSITY_MAP_PROPERTIES_EXT")]
    PhysicalDeviceDescriptorBufferDensityMapPropertiesEXT = 1000316001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT")]
    PhysicalDeviceDescriptorBufferFeaturesEXT = 1000316002,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT")]
    DescriptorAddressInfoEXT = 1000316003,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT")]
    DescriptorGetInfoEXT = 1000316004,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
    BufferCaptureDescriptorDataInfoEXT = 1000316005,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
    ImageCaptureDescriptorDataInfoEXT = 1000316006,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
    ImageViewCaptureDescriptorDataInfoEXT = 1000316007,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
    SamplerCaptureDescriptorDataInfoEXT = 1000316008,

    [NativeName("VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT")]
    OpaqueCaptureDescriptorDataCreateInfoEXT = 1000316010,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT")]
    DescriptorBufferBindingInfoEXT = 1000316011,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT")]
    DescriptorBufferBindingPushDescriptorBufferHandleEXT = 1000316012,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
    AccelerationStructureCaptureDescriptorDataInfoEXT = 1000316009,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_COPY_KHR")]
    DeviceMemoryCopyKHR = 1000318000,

    [NativeName("VK_STRUCTURE_TYPE_COPY_DEVICE_MEMORY_INFO_KHR")]
    CopyDeviceMemoryInfoKHR = 1000318001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_IMAGE_COPY_KHR")]
    DeviceMemoryImageCopyKHR = 1000318002,

    [NativeName("VK_STRUCTURE_TYPE_COPY_DEVICE_MEMORY_IMAGE_INFO_KHR")]
    CopyDeviceMemoryImageInfoKHR = 1000318003,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_RANGE_BARRIERS_INFO_KHR")]
    MemoryRangeBarriersInfoKHR = 1000318004,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_RANGE_BARRIER_KHR")]
    MemoryRangeBarrierKHR = 1000318005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_ADDRESS_COMMANDS_FEATURES_KHR")]
    PhysicalDeviceDeviceAddressCommandsFeaturesKHR = 1000318006,

    [NativeName("VK_STRUCTURE_TYPE_BIND_INDEX_BUFFER_3_INFO_KHR")]
    BindIndexBuffer3InfoKHR = 1000318007,

    [NativeName("VK_STRUCTURE_TYPE_BIND_VERTEX_BUFFER_3_INFO_KHR")]
    BindVertexBuffer3InfoKHR = 1000318008,

    [NativeName("VK_STRUCTURE_TYPE_DRAW_INDIRECT_2_INFO_KHR")]
    DrawIndirect2InfoKHR = 1000318009,

    [NativeName("VK_STRUCTURE_TYPE_DRAW_INDIRECT_COUNT_2_INFO_KHR")]
    DrawIndirectCount2InfoKHR = 1000318010,

    [NativeName("VK_STRUCTURE_TYPE_DISPATCH_INDIRECT_2_INFO_KHR")]
    DispatchIndirect2InfoKHR = 1000318011,

    [NativeName("VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_2_EXT")]
    ConditionalRenderingBeginInfo2EXT = 1000318012,

    [NativeName("VK_STRUCTURE_TYPE_BIND_TRANSFORM_FEEDBACK_BUFFER_2_INFO_EXT")]
    BindTransformFeedbackBuffer2InfoEXT = 1000318013,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MARKER_INFO_AMD")]
    MemoryMarkerInfoAMD = 1000318014,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_2_KHR")]
    AccelerationStructureCreateInfo2KHR = 1000318015,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT")]
    PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT = 1000320000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT")]
    PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT = 1000320001,

    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT")]
    GraphicsPipelineLibraryCreateInfoEXT = 1000320002,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD"
    )]
    PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD = 1000321000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR")]
    PhysicalDeviceFragmentShaderBarycentricFeaturesKHR = 1000203000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR")]
    PhysicalDeviceFragmentShaderBarycentricPropertiesKHR = 1000322000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR"
    )]
    PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR = 1000323000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV")]
    PhysicalDeviceFragmentShadingRateEnumsPropertiesNV = 1000326000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV")]
    PhysicalDeviceFragmentShadingRateEnumsFeaturesNV = 1000326001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV")]
    PipelineFragmentShadingRateEnumStateCreateInfoNV = 1000326002,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV")]
    AccelerationStructureGeometryMotionTrianglesDataNV = 1000327000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV")]
    PhysicalDeviceRayTracingMotionBlurFeaturesNV = 1000327001,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV")]
    AccelerationStructureMotionInfoNV = 1000327002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT")]
    PhysicalDeviceMeshShaderFeaturesEXT = 1000328000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT")]
    PhysicalDeviceMeshShaderPropertiesEXT = 1000328001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT")]
    PhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT = 1000330000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT")]
    PhysicalDeviceFragmentDensityMap2FeaturesEXT = 1000332000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT")]
    PhysicalDeviceFragmentDensityMap2PropertiesEXT = 1000332001,

    [NativeName("VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM")]
    CopyCommandTransformInfoQCOM = 1000333000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR")]
    PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR = 1000336000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT")]
    PhysicalDeviceImageCompressionControlFeaturesEXT = 1000338000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT")]
    ImageCompressionControlEXT = 1000338001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT")]
    ImageCompressionPropertiesEXT = 1000338004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT")]
    PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT = 1000339000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT")]
    PhysicalDevice4444FormatsFeaturesEXT = 1000340000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_EXT")]
    PhysicalDeviceFaultFeaturesEXT = 1000341000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT")]
    DeviceFaultCountsEXT = 1000341001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT")]
    DeviceFaultInfoEXT = 1000341002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT")]
    PhysicalDeviceRgba10x6FormatsFeaturesEXT = 1000344000,

    [NativeName("VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT")]
    DirectfbSurfaceCreateInfoEXT = 1000346000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT")]
    PhysicalDeviceVertexInputDynamicStateFeaturesEXT = 1000352000,

    [NativeName("VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT")]
    VertexInputBindingDescription2EXT = 1000352001,

    [NativeName("VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT")]
    VertexInputAttributeDescription2EXT = 1000352002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT")]
    PhysicalDeviceDrmPropertiesEXT = 1000353000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT")]
    PhysicalDeviceAddressBindingReportFeaturesEXT = 1000354000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT")]
    DeviceAddressBindingCallbackDataEXT = 1000354001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT")]
    PhysicalDeviceDepthClipControlFeaturesEXT = 1000355000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT")]
    PipelineViewportDepthClipControlCreateInfoEXT = 1000355001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT")]
    PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT = 1000356000,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA")]
    ImportMemoryZirconHandleInfoFUCHSIA = 1000364000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA")]
    MemoryZirconHandlePropertiesFUCHSIA = 1000364001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA")]
    MemoryGetZirconHandleInfoFUCHSIA = 1000364002,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA")]
    ImportSemaphoreZirconHandleInfoFUCHSIA = 1000365000,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA")]
    SemaphoreGetZirconHandleInfoFUCHSIA = 1000365001,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA")]
    BufferCollectionCreateInfoFUCHSIA = 1000366000,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA")]
    ImportMemoryBufferCollectionFUCHSIA = 1000366001,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA")]
    BufferCollectionImageCreateInfoFUCHSIA = 1000366002,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA")]
    BufferCollectionPropertiesFUCHSIA = 1000366003,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA")]
    BufferConstraintsInfoFUCHSIA = 1000366004,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA")]
    BufferCollectionBufferCreateInfoFUCHSIA = 1000366005,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA")]
    ImageConstraintsInfoFUCHSIA = 1000366006,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA")]
    ImageFormatConstraintsInfoFUCHSIA = 1000366007,

    [NativeName("VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA")]
    SysmemColorSpaceFUCHSIA = 1000366008,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA")]
    BufferCollectionConstraintsInfoFUCHSIA = 1000366009,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI")]
    SubpassShadingPipelineCreateInfoHUAWEI = 1000369000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI")]
    PhysicalDeviceSubpassShadingFeaturesHUAWEI = 1000369001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI")]
    PhysicalDeviceSubpassShadingPropertiesHUAWEI = 1000369002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI")]
    PhysicalDeviceInvocationMaskFeaturesHUAWEI = 1000370000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV")]
    MemoryGetRemoteAddressInfoNV = 1000371000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV")]
    PhysicalDeviceExternalMemoryRdmaFeaturesNV = 1000371001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT")]
    PipelinePropertiesIdentifierEXT = 1000372000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT")]
    PhysicalDevicePipelinePropertiesFeaturesEXT = 1000372001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAME_BOUNDARY_FEATURES_EXT")]
    PhysicalDeviceFrameBoundaryFeaturesEXT = 1000375000,

    [NativeName("VK_STRUCTURE_TYPE_FRAME_BOUNDARY_EXT")]
    FrameBoundaryEXT = 1000375001,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT"
    )]
    PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT = 1000376000,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT")]
    SubpassResolvePerformanceQueryEXT = 1000376001,

    [NativeName("VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT")]
    MultisampledRenderToSingleSampledInfoEXT = 1000376002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT")]
    PhysicalDeviceExtendedDynamicState2FeaturesEXT = 1000377000,

    [NativeName("VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX")]
    ScreenSurfaceCreateInfoQNX = 1000378000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT")]
    PhysicalDeviceColorWriteEnableFeaturesEXT = 1000381000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT")]
    PipelineColorWriteCreateInfoEXT = 1000381001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT")]
    PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT = 1000382000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR")]
    PhysicalDeviceRayTracingMaintenance1FeaturesKHR = 1000386000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNTYPED_POINTERS_FEATURES_KHR")]
    PhysicalDeviceShaderUntypedPointersFeaturesKHR = 1000387000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_RGB_CONVERSION_FEATURES_VALVE")]
    PhysicalDeviceVideoEncodeRgbConversionFeaturesVALVE = 1000390000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RGB_CONVERSION_CAPABILITIES_VALVE")]
    VideoEncodeRgbConversionCapabilitiesVALVE = 1000390001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_PROFILE_RGB_CONVERSION_INFO_VALVE")]
    VideoEncodeProfileRgbConversionInfoVALVE = 1000390002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_RGB_CONVERSION_CREATE_INFO_VALVE")]
    VideoEncodeSessionRgbConversionCreateInfoVALVE = 1000390003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT")]
    PhysicalDeviceImageViewMinLodFeaturesEXT = 1000391000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT")]
    ImageViewMinLodCreateInfoEXT = 1000391001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT")]
    PhysicalDeviceMultiDrawFeaturesEXT = 1000392000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT")]
    PhysicalDeviceMultiDrawPropertiesEXT = 1000392001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT")]
    PhysicalDeviceImage2DViewOf3DFeaturesEXT = 1000393000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_FEATURES_EXT")]
    PhysicalDeviceShaderTileImageFeaturesEXT = 1000395000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT")]
    PhysicalDeviceShaderTileImagePropertiesEXT = 1000395001,

    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT")]
    MicromapBuildInfoEXT = 1000396000,

    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT")]
    MicromapVersionInfoEXT = 1000396001,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT")]
    CopyMicromapInfoEXT = 1000396002,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT")]
    CopyMicromapToMemoryInfoEXT = 1000396003,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT")]
    CopyMemoryToMicromapInfoEXT = 1000396004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT")]
    PhysicalDeviceOpacityMicromapFeaturesEXT = 1000396005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_EXT")]
    PhysicalDeviceOpacityMicromapPropertiesEXT = 1000396006,

    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT")]
    MicromapCreateInfoEXT = 1000396007,

    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT")]
    MicromapBuildSizesInfoEXT = 1000396008,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT")]
    AccelerationStructureTrianglesOpacityMicromapEXT = 1000396009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_FEATURES_NV")]
    PhysicalDeviceDisplacementMicromapFeaturesNV = 1000397000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_PROPERTIES_NV")]
    PhysicalDeviceDisplacementMicromapPropertiesNV = 1000397001,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_DISPLACEMENT_MICROMAP_NV")]
    AccelerationStructureTrianglesDisplacementMicromapNV = 1000397002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI")]
    PhysicalDeviceClusterCullingShaderFeaturesHUAWEI = 1000404000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI")]
    PhysicalDeviceClusterCullingShaderPropertiesHUAWEI = 1000404001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_VRS_FEATURES_HUAWEI")]
    PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI = 1000404002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT")]
    PhysicalDeviceBorderColorSwizzleFeaturesEXT = 1000411000,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT")]
    SamplerBorderColorComponentMappingCreateInfoEXT = 1000411001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT")]
    PhysicalDevicePageableDeviceLocalMemoryFeaturesEXT = 1000412000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM")]
    PhysicalDeviceShaderCorePropertiesARM = 1000415000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_SHADER_CORE_CONTROL_CREATE_INFO_ARM")]
    DeviceQueueShaderCoreControlCreateInfoARM = 1000417000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_FEATURES_ARM")]
    PhysicalDeviceSchedulingControlsFeaturesARM = 1000417001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_PROPERTIES_ARM")]
    PhysicalDeviceSchedulingControlsPropertiesARM = 1000417002,

    [NativeName("VK_STRUCTURE_TYPE_DISPATCH_PARAMETERS_ARM")]
    DispatchParametersARM = 1000417003,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_DISPATCH_PARAMETERS_PROPERTIES_ARM"
    )]
    PhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM = 1000417004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT")]
    PhysicalDeviceImageSlicedViewOf3DFeaturesEXT = 1000418000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT")]
    ImageViewSlicedCreateInfoEXT = 1000418001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE")]
    PhysicalDeviceDescriptorSetHostMappingFeaturesVALVE = 1000420000,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE")]
    DescriptorSetBindingReferenceVALVE = 1000420001,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE")]
    DescriptorSetLayoutHostMappingInfoVALVE = 1000420002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT")]
    PhysicalDeviceNonSeamlessCubeMapFeaturesEXT = 1000422000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_FEATURES_ARM")]
    PhysicalDeviceRenderPassStripedFeaturesARM = 1000424000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_PROPERTIES_ARM")]
    PhysicalDeviceRenderPassStripedPropertiesARM = 1000424001,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_BEGIN_INFO_ARM")]
    RenderPassStripeBeginInfoARM = 1000424002,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_INFO_ARM")]
    RenderPassStripeInfoARM = 1000424003,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_SUBMIT_INFO_ARM")]
    RenderPassStripeSubmitInfoARM = 1000424004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_NV")]
    PhysicalDeviceCopyMemoryIndirectFeaturesNV = 1000426000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV")]
    PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV = 1000428000,

    [NativeName("VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV")]
    ComputePipelineIndirectBufferInfoNV = 1000428001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INDIRECT_DEVICE_ADDRESS_INFO_NV")]
    PipelineIndirectDeviceAddressInfoNV = 1000428002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_LINEAR_SWEPT_SPHERES_FEATURES_NV")]
    PhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV = 1000429008,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_LINEAR_SWEPT_SPHERES_DATA_NV")]
    AccelerationStructureGeometryLinearSweptSpheresDataNV = 1000429009,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_SPHERES_DATA_NV")]
    AccelerationStructureGeometrySpheresDataNV = 1000429010,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV")]
    PhysicalDeviceLinearColorAttachmentFeaturesNV = 1000430000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MAXIMAL_RECONVERGENCE_FEATURES_KHR")]
    PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR = 1000434000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT"
    )]
    PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT = 1000437000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM")]
    PhysicalDeviceImageProcessingFeaturesQCOM = 1000440000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM")]
    PhysicalDeviceImageProcessingPropertiesQCOM = 1000440001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM")]
    ImageViewSampleWeightCreateInfoQCOM = 1000440002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_FEATURES_EXT")]
    PhysicalDeviceNestedCommandBufferFeaturesEXT = 1000451000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_PROPERTIES_EXT")]
    PhysicalDeviceNestedCommandBufferPropertiesEXT = 1000451001,

    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_USAGE_OHOS")]
    NativeBufferUsageOHOS = 1000452000,

    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_PROPERTIES_OHOS")]
    NativeBufferPropertiesOHOS = 1000452001,

    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_FORMAT_PROPERTIES_OHOS")]
    NativeBufferFormatPropertiesOHOS = 1000452002,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_NATIVE_BUFFER_INFO_OHOS")]
    ImportNativeBufferInfoOHOS = 1000452003,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_NATIVE_BUFFER_INFO_OHOS")]
    MemoryGetNativeBufferInfoOHOS = 1000452004,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_OHOS")]
    ExternalFormatOHOS = 1000452005,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT")]
    ExternalMemoryAcquireUnmodifiedEXT = 1000453000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT")]
    PhysicalDeviceExtendedDynamicState3FeaturesEXT = 1000455000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT")]
    PhysicalDeviceExtendedDynamicState3PropertiesEXT = 1000455001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT")]
    PhysicalDeviceSubpassMergeFeedbackFeaturesEXT = 1000458000,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT")]
    RenderPassCreationControlEXT = 1000458001,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT")]
    RenderPassCreationFeedbackCreateInfoEXT = 1000458002,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT")]
    RenderPassSubpassFeedbackCreateInfoEXT = 1000458003,

    [NativeName("VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG")]
    DirectDriverLoadingInfoLUNARG = 1000459000,

    [NativeName("VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG")]
    DirectDriverLoadingListLUNARG = 1000459001,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_CREATE_INFO_ARM")]
    TensorCreateInfoARM = 1000460000,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_VIEW_CREATE_INFO_ARM")]
    TensorViewCreateInfoARM = 1000460001,

    [NativeName("VK_STRUCTURE_TYPE_BIND_TENSOR_MEMORY_INFO_ARM")]
    BindTensorMemoryInfoARM = 1000460002,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_TENSOR_ARM")]
    WriteDescriptorSetTensorARM = 1000460003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_PROPERTIES_ARM")]
    PhysicalDeviceTensorPropertiesARM = 1000460004,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_FORMAT_PROPERTIES_ARM")]
    TensorFormatPropertiesARM = 1000460005,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_DESCRIPTION_ARM")]
    TensorDescriptionARM = 1000460006,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_MEMORY_REQUIREMENTS_INFO_ARM")]
    TensorMemoryRequirementsInfoARM = 1000460007,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_MEMORY_BARRIER_ARM")]
    TensorMemoryBarrierARM = 1000460008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_FEATURES_ARM")]
    PhysicalDeviceTensorFeaturesARM = 1000460009,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_TENSOR_MEMORY_REQUIREMENTS_ARM")]
    DeviceTensorMemoryRequirementsARM = 1000460010,

    [NativeName("VK_STRUCTURE_TYPE_COPY_TENSOR_INFO_ARM")]
    CopyTensorInfoARM = 1000460011,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_COPY_ARM")]
    TensorCopyARM = 1000460012,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_DEPENDENCY_INFO_ARM")]
    TensorDependencyInfoARM = 1000460013,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_TENSOR_ARM")]
    MemoryDedicatedAllocateInfoTensorARM = 1000460014,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_TENSOR_INFO_ARM")]
    PhysicalDeviceExternalTensorInfoARM = 1000460015,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_TENSOR_PROPERTIES_ARM")]
    ExternalTensorPropertiesARM = 1000460016,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_TENSOR_CREATE_INFO_ARM")]
    ExternalMemoryTensorCreateInfoARM = 1000460017,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_FEATURES_ARM")]
    PhysicalDeviceDescriptorBufferTensorFeaturesARM = 1000460018,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_PROPERTIES_ARM")]
    PhysicalDeviceDescriptorBufferTensorPropertiesARM = 1000460019,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_GET_TENSOR_INFO_ARM")]
    DescriptorGetTensorInfoARM = 1000460020,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_CAPTURE_DESCRIPTOR_DATA_INFO_ARM")]
    TensorCaptureDescriptorDataInfoARM = 1000460021,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_ARM")]
    TensorViewCaptureDescriptorDataInfoARM = 1000460022,

    [NativeName("VK_STRUCTURE_TYPE_FRAME_BOUNDARY_TENSORS_ARM")]
    FrameBoundaryTensorsARM = 1000460023,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_FEATURES_EXT")]
    PhysicalDeviceShaderModuleIdentifierFeaturesEXT = 1000462000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_PROPERTIES_EXT")]
    PhysicalDeviceShaderModuleIdentifierPropertiesEXT = 1000462001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_MODULE_IDENTIFIER_CREATE_INFO_EXT")]
    PipelineShaderStageModuleIdentifierCreateInfoEXT = 1000462002,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT")]
    ShaderModuleIdentifierEXT = 1000462003,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT"
    )]
    PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT = 1000342000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_FEATURES_NV")]
    PhysicalDeviceOpticalFlowFeaturesNV = 1000464000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV")]
    PhysicalDeviceOpticalFlowPropertiesNV = 1000464001,

    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV")]
    OpticalFlowImageFormatInfoNV = 1000464002,

    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_NV")]
    OpticalFlowImageFormatPropertiesNV = 1000464003,

    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_INFO_NV")]
    OpticalFlowSessionCreateInfoNV = 1000464004,

    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV")]
    OpticalFlowExecuteInfoNV = 1000464005,

    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV")]
    OpticalFlowSessionCreatePrivateDataInfoNV = 1000464010,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT")]
    PhysicalDeviceLegacyDitheringFeaturesEXT = 1000465000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_FEATURES_ANDROID")]
    PhysicalDeviceExternalFormatResolveFeaturesANDROID = 1000468000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_PROPERTIES_ANDROID")]
    PhysicalDeviceExternalFormatResolvePropertiesANDROID = 1000468001,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_RESOLVE_PROPERTIES_ANDROID")]
    AndroidHardwareBufferFormatResolvePropertiesANDROID = 1000468002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ANTI_LAG_FEATURES_AMD")]
    PhysicalDeviceAntiLagFeaturesAMD = 1000476000,

    [NativeName("VK_STRUCTURE_TYPE_ANTI_LAG_DATA_AMD")]
    AntiLagDataAMD = 1000476001,

    [NativeName("VK_STRUCTURE_TYPE_ANTI_LAG_PRESENTATION_INFO_AMD")]
    AntiLagPresentationInfoAMD = 1000476002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DENSE_GEOMETRY_FORMAT_FEATURES_AMDX")]
    PhysicalDeviceDenseGeometryFormatFeaturesAMDX = 1000478000,

    [NativeName(
        "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DENSE_GEOMETRY_FORMAT_TRIANGLES_DATA_AMDX"
    )]
    AccelerationStructureDenseGeometryFormatTrianglesDataAMDX = 1000478001,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_ID_2_KHR")]
    SurfaceCapabilitiesPresentId2KHR = 1000479000,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_ID_2_KHR")]
    PresentId2KHR = 1000479001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_2_FEATURES_KHR")]
    PhysicalDevicePresentId2FeaturesKHR = 1000479002,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_WAIT_2_KHR")]
    SurfaceCapabilitiesPresentWait2KHR = 1000480000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_2_FEATURES_KHR")]
    PhysicalDevicePresentWait2FeaturesKHR = 1000480001,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_WAIT_2_INFO_KHR")]
    PresentWait2InfoKHR = 1000480002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_POSITION_FETCH_FEATURES_KHR")]
    PhysicalDeviceRayTracingPositionFetchFeaturesKHR = 1000481000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_FEATURES_EXT")]
    PhysicalDeviceShaderObjectFeaturesEXT = 1000482000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_PROPERTIES_EXT")]
    PhysicalDeviceShaderObjectPropertiesEXT = 1000482001,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_CREATE_INFO_EXT")]
    ShaderCreateInfoEXT = 1000482002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_FEATURES_KHR")]
    PhysicalDevicePipelineBinaryFeaturesKHR = 1000483000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_CREATE_INFO_KHR")]
    PipelineBinaryCreateInfoKHR = 1000483001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_INFO_KHR")]
    PipelineBinaryInfoKHR = 1000483002,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_KEY_KHR")]
    PipelineBinaryKeyKHR = 1000483003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_PROPERTIES_KHR")]
    PhysicalDevicePipelineBinaryPropertiesKHR = 1000483004,

    [NativeName("VK_STRUCTURE_TYPE_RELEASE_CAPTURED_PIPELINE_DATA_INFO_KHR")]
    ReleaseCapturedPipelineDataInfoKHR = 1000483005,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_DATA_INFO_KHR")]
    PipelineBinaryDataInfoKHR = 1000483006,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_INFO_KHR")]
    PipelineCreateInfoKHR = 1000483007,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_PIPELINE_BINARY_INTERNAL_CACHE_CONTROL_KHR")]
    DevicePipelineBinaryInternalCacheControlKHR = 1000483008,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_HANDLES_INFO_KHR")]
    PipelineBinaryHandlesInfoKHR = 1000483009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM")]
    PhysicalDeviceTilePropertiesFeaturesQCOM = 1000484000,

    [NativeName("VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM")]
    TilePropertiesQCOM = 1000484001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC")]
    PhysicalDeviceAmigoProfilingFeaturesSEC = 1000485000,

    [NativeName("VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC")]
    AmigoProfilingSubmitInfoSEC = 1000485001,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_KHR")]
    SurfacePresentModeKHR = 1000274000,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_KHR")]
    SurfacePresentScalingCapabilitiesKHR = 1000274001,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_KHR")]
    SurfacePresentModeCompatibilityKHR = 1000274002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_KHR")]
    PhysicalDeviceSwapchainMaintenance1FeaturesKHR = 1000275000,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_KHR")]
    SwapchainPresentFenceInfoKHR = 1000275001,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_KHR")]
    SwapchainPresentModesCreateInfoKHR = 1000275002,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_KHR")]
    SwapchainPresentModeInfoKHR = 1000275003,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_KHR")]
    SwapchainPresentScalingCreateInfoKHR = 1000275004,

    [NativeName("VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_KHR")]
    ReleaseSwapchainImagesInfoKHR = 1000275005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM")]
    PhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM = 1000488000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV")]
    PhysicalDeviceRayTracingInvocationReorderFeaturesNV = 1000490000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV")]
    PhysicalDeviceRayTracingInvocationReorderPropertiesNV = 1000490001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_FEATURES_NV")]
    PhysicalDeviceCooperativeVectorFeaturesNV = 1000491000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_PROPERTIES_NV")]
    PhysicalDeviceCooperativeVectorPropertiesNV = 1000491001,

    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_VECTOR_PROPERTIES_NV")]
    CooperativeVectorPropertiesNV = 1000491002,

    [NativeName("VK_STRUCTURE_TYPE_CONVERT_COOPERATIVE_VECTOR_MATRIX_INFO_NV")]
    ConvertCooperativeVectorMatrixInfoNV = 1000491004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_FEATURES_NV")]
    PhysicalDeviceExtendedSparseAddressSpaceFeaturesNV = 1000492000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_PROPERTIES_NV")]
    PhysicalDeviceExtendedSparseAddressSpacePropertiesNV = 1000492001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT")]
    PhysicalDeviceMutableDescriptorTypeFeaturesEXT = 1000351000,

    [NativeName("VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT")]
    MutableDescriptorTypeCreateInfoEXT = 1000351002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_FEATURES_EXT")]
    PhysicalDeviceLegacyVertexAttributesFeaturesEXT = 1000495000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_PROPERTIES_EXT")]
    PhysicalDeviceLegacyVertexAttributesPropertiesEXT = 1000495001,

    [NativeName("VK_STRUCTURE_TYPE_LAYER_SETTINGS_CREATE_INFO_EXT")]
    LayerSettingsCreateInfoEXT = 1000496000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM")]
    PhysicalDeviceShaderCoreBuiltinsFeaturesARM = 1000497000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM")]
    PhysicalDeviceShaderCoreBuiltinsPropertiesARM = 1000497001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_LIBRARY_GROUP_HANDLES_FEATURES_EXT")]
    PhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT = 1000498000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_FEATURES_EXT"
    )]
    PhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT = 1000499000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INTERNALLY_SYNCHRONIZED_QUEUES_FEATURES_KHR")]
    PhysicalDeviceInternallySynchronizedQueuesFeaturesKHR = 1000504000,

    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SLEEP_MODE_INFO_NV")]
    LatencySleepModeInfoNV = 1000505000,

    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SLEEP_INFO_NV")]
    LatencySleepInfoNV = 1000505001,

    [NativeName("VK_STRUCTURE_TYPE_SET_LATENCY_MARKER_INFO_NV")]
    SetLatencyMarkerInfoNV = 1000505002,

    [NativeName("VK_STRUCTURE_TYPE_GET_LATENCY_MARKER_INFO_NV")]
    GetLatencyMarkerInfoNV = 1000505003,

    [NativeName("VK_STRUCTURE_TYPE_LATENCY_TIMINGS_FRAME_REPORT_NV")]
    LatencyTimingsFrameReportNV = 1000505004,

    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SUBMISSION_PRESENT_ID_NV")]
    LatencySubmissionPresentIdNV = 1000505005,

    [NativeName("VK_STRUCTURE_TYPE_OUT_OF_BAND_QUEUE_TYPE_INFO_NV")]
    OutOfBandQueueTypeInfoNV = 1000505006,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_LATENCY_CREATE_INFO_NV")]
    SwapchainLatencyCreateInfoNV = 1000505007,

    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SURFACE_CAPABILITIES_NV")]
    LatencySurfaceCapabilitiesNV = 1000505008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_KHR")]
    PhysicalDeviceCooperativeMatrixFeaturesKHR = 1000506000,

    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_KHR")]
    CooperativeMatrixPropertiesKHR = 1000506001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_KHR")]
    PhysicalDeviceCooperativeMatrixPropertiesKHR = 1000506002,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CREATE_INFO_ARM")]
    DataGraphPipelineCreateInfoARM = 1000507000,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_CREATE_INFO_ARM")]
    DataGraphPipelineSessionCreateInfoARM = 1000507001,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_RESOURCE_INFO_ARM")]
    DataGraphPipelineResourceInfoARM = 1000507002,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_ARM")]
    DataGraphPipelineConstantARM = 1000507003,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_MEMORY_REQUIREMENTS_INFO_ARM")]
    DataGraphPipelineSessionMemoryRequirementsInfoARM = 1000507004,

    [NativeName("VK_STRUCTURE_TYPE_BIND_DATA_GRAPH_PIPELINE_SESSION_MEMORY_INFO_ARM")]
    BindDataGraphPipelineSessionMemoryInfoARM = 1000507005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_FEATURES_ARM")]
    PhysicalDeviceDataGraphFeaturesARM = 1000507006,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SHADER_MODULE_CREATE_INFO_ARM")]
    DataGraphPipelineShaderModuleCreateInfoARM = 1000507007,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_PROPERTY_QUERY_RESULT_ARM")]
    DataGraphPipelinePropertyQueryResultARM = 1000507008,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_INFO_ARM")]
    DataGraphPipelineInfoARM = 1000507009,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_COMPILER_CONTROL_CREATE_INFO_ARM")]
    DataGraphPipelineCompilerControlCreateInfoARM = 1000507010,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENTS_INFO_ARM")]
    DataGraphPipelineSessionBindPointRequirementsInfoARM = 1000507011,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENT_ARM")]
    DataGraphPipelineSessionBindPointRequirementARM = 1000507012,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_IDENTIFIER_CREATE_INFO_ARM")]
    DataGraphPipelineIdentifierCreateInfoARM = 1000507013,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_DISPATCH_INFO_ARM")]
    DataGraphPipelineDispatchInfoARM = 1000507014,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PROCESSING_ENGINE_CREATE_INFO_ARM")]
    DataGraphProcessingEngineCreateInfoARM = 1000507016,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_PROPERTIES_ARM")]
    QueueFamilyDataGraphProcessingEnginePropertiesARM = 1000507017,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROPERTIES_ARM")]
    QueueFamilyDataGraphPropertiesARM = 1000507018,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_INFO_ARM"
    )]
    PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM = 1000507019,

    [NativeName(
        "VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_TENSOR_SEMI_STRUCTURED_SPARSITY_INFO_ARM"
    )]
    DataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM = 1000507015,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_TOSA_PROPERTIES_ARM")]
    QueueFamilyDataGraphTosaPropertiesARM = 1000508000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM")]
    PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM = 1000510000,

    [NativeName("VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM")]
    MultiviewPerViewRenderAreasRenderPassBeginInfoQCOM = 1000510001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_KHR")]
    PhysicalDeviceComputeShaderDerivativesFeaturesKHR = 1000201000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_PROPERTIES_KHR")]
    PhysicalDeviceComputeShaderDerivativesPropertiesKHR = 1000511000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_CAPABILITIES_KHR")]
    VideoDecodeAv1CapabilitiesKHR = 1000512000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PICTURE_INFO_KHR")]
    VideoDecodeAv1PictureInfoKHR = 1000512001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PROFILE_INFO_KHR")]
    VideoDecodeAv1ProfileInfoKHR = 1000512003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    VideoDecodeAv1SessionParametersCreateInfoKHR = 1000512004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_DPB_SLOT_INFO_KHR")]
    VideoDecodeAv1DpbSlotInfoKHR = 1000512005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_CAPABILITIES_KHR")]
    VideoEncodeAv1CapabilitiesKHR = 1000513000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    VideoEncodeAv1SessionParametersCreateInfoKHR = 1000513001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PICTURE_INFO_KHR")]
    VideoEncodeAv1PictureInfoKHR = 1000513002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_DPB_SLOT_INFO_KHR")]
    VideoEncodeAv1DpbSlotInfoKHR = 1000513003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_AV1_FEATURES_KHR")]
    PhysicalDeviceVideoEncodeAv1FeaturesKHR = 1000513004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PROFILE_INFO_KHR")]
    VideoEncodeAv1ProfileInfoKHR = 1000513005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_INFO_KHR")]
    VideoEncodeAv1RateControlInfoKHR = 1000513006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_LAYER_INFO_KHR")]
    VideoEncodeAv1RateControlLayerInfoKHR = 1000513007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUALITY_LEVEL_PROPERTIES_KHR")]
    VideoEncodeAv1QualityLevelPropertiesKHR = 1000513008,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_CREATE_INFO_KHR")]
    VideoEncodeAv1SessionCreateInfoKHR = 1000513009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_GOP_REMAINING_FRAME_INFO_KHR")]
    VideoEncodeAv1GopRemainingFrameInfoKHR = 1000513010,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_DECODE_VP9_FEATURES_KHR")]
    PhysicalDeviceVideoDecodeVp9FeaturesKHR = 1000514000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_CAPABILITIES_KHR")]
    VideoDecodeVp9CapabilitiesKHR = 1000514001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PICTURE_INFO_KHR")]
    VideoDecodeVp9PictureInfoKHR = 1000514002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PROFILE_INFO_KHR")]
    VideoDecodeVp9ProfileInfoKHR = 1000514003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_1_FEATURES_KHR")]
    PhysicalDeviceVideoMaintenance1FeaturesKHR = 1000515000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_INLINE_QUERY_INFO_KHR")]
    VideoInlineQueryInfoKHR = 1000515001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PER_STAGE_DESCRIPTOR_SET_FEATURES_NV")]
    PhysicalDevicePerStageDescriptorSetFeaturesNV = 1000516000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_FEATURES_QCOM")]
    PhysicalDeviceImageProcessing2FeaturesQCOM = 1000518000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_PROPERTIES_QCOM")]
    PhysicalDeviceImageProcessing2PropertiesQCOM = 1000518001,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM")]
    SamplerBlockMatchWindowCreateInfoQCOM = 1000518002,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CUBIC_WEIGHTS_CREATE_INFO_QCOM")]
    SamplerCubicWeightsCreateInfoQCOM = 1000519000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_WEIGHTS_FEATURES_QCOM")]
    PhysicalDeviceCubicWeightsFeaturesQCOM = 1000519001,

    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_CUBIC_WEIGHTS_INFO_QCOM")]
    BlitImageCubicWeightsInfoQCOM = 1000519002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_DEGAMMA_FEATURES_QCOM")]
    PhysicalDeviceYcbcrDegammaFeaturesQCOM = 1000520000,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM")]
    SamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM = 1000520001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_CLAMP_FEATURES_QCOM")]
    PhysicalDeviceCubicClampFeaturesQCOM = 1000521000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_FEATURES_EXT"
    )]
    PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT = 1000524000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFIED_IMAGE_LAYOUTS_FEATURES_KHR")]
    PhysicalDeviceUnifiedImageLayoutsFeaturesKHR = 1000527000,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_FEEDBACK_LOOP_INFO_EXT")]
    AttachmentFeedbackLoopInfoEXT = 1000527001,

    [NativeName("VK_STRUCTURE_TYPE_SCREEN_BUFFER_PROPERTIES_QNX")]
    ScreenBufferPropertiesQNX = 1000529000,

    [NativeName("VK_STRUCTURE_TYPE_SCREEN_BUFFER_FORMAT_PROPERTIES_QNX")]
    ScreenBufferFormatPropertiesQNX = 1000529001,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SCREEN_BUFFER_INFO_QNX")]
    ImportScreenBufferInfoQNX = 1000529002,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_QNX")]
    ExternalFormatQNX = 1000529003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCREEN_BUFFER_FEATURES_QNX")]
    PhysicalDeviceExternalMemoryScreenBufferFeaturesQNX = 1000529004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_DRIVER_PROPERTIES_MSFT")]
    PhysicalDeviceLayeredDriverPropertiesMSFT = 1000530000,

    [NativeName("VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_KHR")]
    CalibratedTimestampInfoKHR = 1000184000,

    [NativeName("VK_STRUCTURE_TYPE_SET_DESCRIPTOR_BUFFER_OFFSETS_INFO_EXT")]
    SetDescriptorBufferOffsetsInfoEXT = 1000545007,

    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_BUFFER_EMBEDDED_SAMPLERS_INFO_EXT")]
    BindDescriptorBufferEmbeddedSamplersInfoEXT = 1000545008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_POOL_OVERALLOCATION_FEATURES_NV")]
    PhysicalDeviceDescriptorPoolOverallocationFeaturesNV = 1000546000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_FEATURES_QCOM")]
    PhysicalDeviceTileMemoryHeapFeaturesQCOM = 1000547000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_PROPERTIES_QCOM")]
    PhysicalDeviceTileMemoryHeapPropertiesQCOM = 1000547001,

    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_REQUIREMENTS_QCOM")]
    TileMemoryRequirementsQCOM = 1000547002,

    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_BIND_INFO_QCOM")]
    TileMemoryBindInfoQCOM = 1000547003,

    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_SIZE_INFO_QCOM")]
    TileMemorySizeInfoQCOM = 1000547004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_KHR")]
    PhysicalDeviceCopyMemoryIndirectFeaturesKHR = 1000549000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_KHR")]
    PhysicalDeviceCopyMemoryIndirectPropertiesKHR = 1000426001,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_INDIRECT_INFO_KHR")]
    CopyMemoryIndirectInfoKHR = 1000549002,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INDIRECT_INFO_KHR")]
    CopyMemoryToImageIndirectInfoKHR = 1000549003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_EXT")]
    PhysicalDeviceMemoryDecompressionFeaturesEXT = 1000427000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_EXT")]
    PhysicalDeviceMemoryDecompressionPropertiesEXT = 1000427001,

    [NativeName("VK_STRUCTURE_TYPE_DECOMPRESS_MEMORY_INFO_EXT")]
    DecompressMemoryInfoEXT = 1000550002,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_SURFACE_STEREO_CREATE_INFO_NV")]
    DisplaySurfaceStereoCreateInfoNV = 1000551000,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_STEREO_PROPERTIES_NV")]
    DisplayModeStereoPropertiesNV = 1000551001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_CAPABILITIES_KHR")]
    VideoEncodeIntraRefreshCapabilitiesKHR = 1000552000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_INTRA_REFRESH_CREATE_INFO_KHR")]
    VideoEncodeSessionIntraRefreshCreateInfoKHR = 1000552001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_INFO_KHR")]
    VideoEncodeIntraRefreshInfoKHR = 1000552002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_REFERENCE_INTRA_REFRESH_INFO_KHR")]
    VideoReferenceIntraRefreshInfoKHR = 1000552003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_INTRA_REFRESH_FEATURES_KHR")]
    PhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR = 1000552004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    VideoEncodeQuantizationMapCapabilitiesKHR = 1000553000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_QUANTIZATION_MAP_PROPERTIES_KHR")]
    VideoFormatQuantizationMapPropertiesKHR = 1000553001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_INFO_KHR")]
    VideoEncodeQuantizationMapInfoKHR = 1000553002,

    [NativeName(
        "VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_SESSION_PARAMETERS_CREATE_INFO_KHR"
    )]
    VideoEncodeQuantizationMapSessionParametersCreateInfoKHR = 1000553005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUANTIZATION_MAP_FEATURES_KHR")]
    PhysicalDeviceVideoEncodeQuantizationMapFeaturesKHR = 1000553009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    VideoEncodeH264QuantizationMapCapabilitiesKHR = 1000553003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    VideoEncodeH265QuantizationMapCapabilitiesKHR = 1000553004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_H265_QUANTIZATION_MAP_PROPERTIES_KHR")]
    VideoFormatH265QuantizationMapPropertiesKHR = 1000553006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    VideoEncodeAv1QuantizationMapCapabilitiesKHR = 1000553007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_AV1_QUANTIZATION_MAP_PROPERTIES_KHR")]
    VideoFormatAv1QuantizationMapPropertiesKHR = 1000553008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAW_ACCESS_CHAINS_FEATURES_NV")]
    PhysicalDeviceRawAccessChainsFeaturesNV = 1000555000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DEVICE_CREATE_INFO_NV")]
    ExternalComputeQueueDeviceCreateInfoNV = 1000556000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_CREATE_INFO_NV")]
    ExternalComputeQueueCreateInfoNV = 1000556001,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DATA_PARAMS_NV")]
    ExternalComputeQueueDataParamsNV = 1000556002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_COMPUTE_QUEUE_PROPERTIES_NV")]
    PhysicalDeviceExternalComputeQueuePropertiesNV = 1000556003,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_RELAXED_EXTENDED_INSTRUCTION_FEATURES_KHR"
    )]
    PhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR = 1000558000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMMAND_BUFFER_INHERITANCE_FEATURES_NV")]
    PhysicalDeviceCommandBufferInheritanceFeaturesNV = 1000559000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_FEATURES_KHR")]
    PhysicalDeviceMaintenance7FeaturesKHR = 1000562000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_PROPERTIES_KHR")]
    PhysicalDeviceMaintenance7PropertiesKHR = 1000562001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_LIST_KHR")]
    PhysicalDeviceLayeredApiPropertiesListKHR = 1000562002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_KHR")]
    PhysicalDeviceLayeredApiPropertiesKHR = 1000562003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_VULKAN_PROPERTIES_KHR")]
    PhysicalDeviceLayeredApiVulkanPropertiesKHR = 1000562004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT16_VECTOR_FEATURES_NV")]
    PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV = 1000563000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_REPLICATED_COMPOSITES_FEATURES_EXT")]
    PhysicalDeviceShaderReplicatedCompositesFeaturesEXT = 1000564000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT8_FEATURES_EXT")]
    PhysicalDeviceShaderFloat8FeaturesEXT = 1000567000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_VALIDATION_FEATURES_NV")]
    PhysicalDeviceRayTracingValidationFeaturesNV = 1000568000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_FEATURES_NV")]
    PhysicalDeviceClusterAccelerationStructureFeaturesNV = 1000569000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_PROPERTIES_NV")]
    PhysicalDeviceClusterAccelerationStructurePropertiesNV = 1000569001,

    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_CLUSTERS_BOTTOM_LEVEL_INPUT_NV")]
    ClusterAccelerationStructureClustersBottomLevelInputNV = 1000569002,

    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_TRIANGLE_CLUSTER_INPUT_NV")]
    ClusterAccelerationStructureTriangleClusterInputNV = 1000569003,

    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_MOVE_OBJECTS_INPUT_NV")]
    ClusterAccelerationStructureMoveObjectsInputNV = 1000569004,

    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_INPUT_INFO_NV")]
    ClusterAccelerationStructureInputInfoNV = 1000569005,

    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_COMMANDS_INFO_NV")]
    ClusterAccelerationStructureCommandsInfoNV = 1000569006,

    [NativeName(
        "VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CLUSTER_ACCELERATION_STRUCTURE_CREATE_INFO_NV"
    )]
    RayTracingPipelineClusterAccelerationStructureCreateInfoNV = 1000569007,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_FEATURES_NV")]
    PhysicalDevicePartitionedAccelerationStructureFeaturesNV = 1000570000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_PROPERTIES_NV"
    )]
    PhysicalDevicePartitionedAccelerationStructurePropertiesNV = 1000570001,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_PARTITIONED_ACCELERATION_STRUCTURE_NV")]
    WriteDescriptorSetPartitionedAccelerationStructureNV = 1000570002,

    [NativeName("VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCES_INPUT_NV")]
    PartitionedAccelerationStructureInstancesInputNV = 1000570003,

    [NativeName("VK_STRUCTURE_TYPE_BUILD_PARTITIONED_ACCELERATION_STRUCTURE_INFO_NV")]
    BuildPartitionedAccelerationStructureInfoNV = 1000570004,

    [NativeName("VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_FLAGS_NV")]
    PartitionedAccelerationStructureFlagsNV = 1000570005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_EXT")]
    PhysicalDeviceDeviceGeneratedCommandsFeaturesEXT = 1000572000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_EXT")]
    PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT = 1000572001,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_EXT")]
    GeneratedCommandsMemoryRequirementsInfoEXT = 1000572002,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_CREATE_INFO_EXT")]
    IndirectExecutionSetCreateInfoEXT = 1000572003,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_EXT")]
    GeneratedCommandsInfoEXT = 1000572004,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_EXT")]
    IndirectCommandsLayoutCreateInfoEXT = 1000572006,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_EXT")]
    IndirectCommandsLayoutTokenEXT = 1000572007,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_PIPELINE_EXT")]
    WriteIndirectExecutionSetPipelineEXT = 1000572008,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_SHADER_EXT")]
    WriteIndirectExecutionSetShaderEXT = 1000572009,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_PIPELINE_INFO_EXT")]
    IndirectExecutionSetPipelineInfoEXT = 1000572010,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_INFO_EXT")]
    IndirectExecutionSetShaderInfoEXT = 1000572011,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_LAYOUT_INFO_EXT")]
    IndirectExecutionSetShaderLayoutInfoEXT = 1000572012,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_PIPELINE_INFO_EXT")]
    GeneratedCommandsPipelineInfoEXT = 1000572013,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_SHADER_INFO_EXT")]
    GeneratedCommandsShaderInfoEXT = 1000572014,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_KHR")]
    PhysicalDeviceFaultFeaturesKHR = 1000573000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_PROPERTIES_KHR")]
    PhysicalDeviceFaultPropertiesKHR = 1000573001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_KHR")]
    DeviceFaultInfoKHR = 1000573002,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_DEBUG_INFO_KHR")]
    DeviceFaultDebugInfoKHR = 1000573003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_8_FEATURES_KHR")]
    PhysicalDeviceMaintenance8FeaturesKHR = 1000574000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER_ACCESS_FLAGS_3_KHR")]
    MemoryBarrierAccessFlags3KHR = 1000574002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_FEATURES_MESA")]
    PhysicalDeviceImageAlignmentControlFeaturesMESA = 1000575000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_PROPERTIES_MESA")]
    PhysicalDeviceImageAlignmentControlPropertiesMESA = 1000575001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_ALIGNMENT_CONTROL_CREATE_INFO_MESA")]
    ImageAlignmentControlCreateInfoMESA = 1000575002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FMA_FEATURES_KHR")]
    PhysicalDeviceShaderFmaFeaturesKHR = 1000579000,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_CONSTANT_BANK_INFO_NV")]
    PushConstantBankInfoNV = 1000580000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_CONSTANT_BANK_FEATURES_NV")]
    PhysicalDevicePushConstantBankFeaturesNV = 1000580001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_CONSTANT_BANK_PROPERTIES_NV")]
    PhysicalDevicePushConstantBankPropertiesNV = 1000580002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_EXT")]
    PhysicalDeviceRayTracingInvocationReorderFeaturesEXT = 1000581000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_EXT")]
    PhysicalDeviceRayTracingInvocationReorderPropertiesEXT = 1000581001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_CONTROL_FEATURES_EXT")]
    PhysicalDeviceDepthClampControlFeaturesEXT = 1000582000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLAMP_CONTROL_CREATE_INFO_EXT")]
    PipelineViewportDepthClampControlCreateInfoEXT = 1000582001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_FEATURES_KHR")]
    PhysicalDeviceMaintenance9FeaturesKHR = 1000584000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_PROPERTIES_KHR")]
    PhysicalDeviceMaintenance9PropertiesKHR = 1000584001,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_OWNERSHIP_TRANSFER_PROPERTIES_KHR")]
    QueueFamilyOwnershipTransferPropertiesKHR = 1000584002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_2_FEATURES_KHR")]
    PhysicalDeviceVideoMaintenance2FeaturesKHR = 1000586000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    VideoDecodeH264InlineSessionParametersInfoKHR = 1000586001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    VideoDecodeH265InlineSessionParametersInfoKHR = 1000586002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    VideoDecodeAv1InlineSessionParametersInfoKHR = 1000586003,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CREATE_INFO_OHOS")]
    SurfaceCreateInfoOHOS = 1000685000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HDR_VIVID_FEATURES_HUAWEI")]
    PhysicalDeviceHdrVividFeaturesHUAWEI = 1000590000,

    [NativeName("VK_STRUCTURE_TYPE_HDR_VIVID_DYNAMIC_METADATA_HUAWEI")]
    HdrVividDynamicMetadataHUAWEI = 1000590001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_FEATURES_NV")]
    PhysicalDeviceCooperativeMatrix2FeaturesNV = 1000593000,

    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_FLEXIBLE_DIMENSIONS_PROPERTIES_NV")]
    CooperativeMatrixFlexibleDimensionsPropertiesNV = 1000593001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_PROPERTIES_NV")]
    PhysicalDeviceCooperativeMatrix2PropertiesNV = 1000593002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_OPACITY_MICROMAP_FEATURES_ARM")]
    PhysicalDevicePipelineOpacityMicromapFeaturesARM = 1000596000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_FEEDBACK_2_FEATURES_KHR")]
    PhysicalDeviceVideoEncodeFeedback2FeaturesKHR = 1000598000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_FEEDBACK_2_CAPABILITIES_KHR")]
    VideoEncodeFeedback2CapabilitiesKHR = 1000598001,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_CREATE_INFO_KHR")]
    QueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR = 1000598002,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_METAL_HANDLE_INFO_EXT")]
    ImportMemoryMetalHandleInfoEXT = 1000602000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_METAL_HANDLE_PROPERTIES_EXT")]
    MemoryMetalHandlePropertiesEXT = 1000602001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_METAL_HANDLE_INFO_EXT")]
    MemoryGetMetalHandleInfoEXT = 1000602002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_KHR")]
    PhysicalDeviceDepthClampZeroOneFeaturesKHR = 1000421000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_FEATURES_ARM")]
    PhysicalDevicePerformanceCountersByRegionFeaturesARM = 1000605000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_PROPERTIES_ARM")]
    PhysicalDevicePerformanceCountersByRegionPropertiesARM = 1000605001,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_ARM")]
    PerformanceCounterARM = 1000605002,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_ARM")]
    PerformanceCounterDescriptionARM = 1000605003,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_PERFORMANCE_COUNTERS_BY_REGION_BEGIN_INFO_ARM")]
    RenderPassPerformanceCountersByRegionBeginInfoARM = 1000605004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INSTRUMENTATION_FEATURES_ARM")]
    PhysicalDeviceShaderInstrumentationFeaturesARM = 1000607000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INSTRUMENTATION_PROPERTIES_ARM")]
    PhysicalDeviceShaderInstrumentationPropertiesARM = 1000607001,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_INSTRUMENTATION_CREATE_INFO_ARM")]
    ShaderInstrumentationCreateInfoARM = 1000607002,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_INSTRUMENTATION_METRIC_DESCRIPTION_ARM")]
    ShaderInstrumentationMetricDescriptionARM = 1000607003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_ROBUSTNESS_FEATURES_EXT")]
    PhysicalDeviceVertexAttributeRobustnessFeaturesEXT = 1000608000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FORMAT_PACK_FEATURES_ARM")]
    PhysicalDeviceFormatPackFeaturesARM = 1000609000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_FEATURES_VALVE")]
    PhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE = 1000611000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_PROPERTIES_VALVE")]
    PhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE = 1000611001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_DENSITY_MAP_LAYERED_CREATE_INFO_VALVE")]
    PipelineFragmentDensityMapLayeredCreateInfoVALVE = 1000611002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_KHR")]
    PhysicalDeviceRobustness2FeaturesKHR = 1000286000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_KHR")]
    PhysicalDeviceRobustness2PropertiesKHR = 1000286001,

    [NativeName("VK_STRUCTURE_TYPE_SET_PRESENT_CONFIG_NV")]
    SetPresentConfigNV = 1000613000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_METERING_FEATURES_NV")]
    PhysicalDevicePresentMeteringFeaturesNV = 1000613001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SWAPCHAIN_FEATURES_EXT")]
    PhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT = 1000616000,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_FLAGS_SURFACE_CAPABILITIES_EXT")]
    SwapchainFlagsSurfaceCapabilitiesEXT = 1000616001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_EXT")]
    PhysicalDeviceFragmentDensityMapOffsetFeaturesEXT = 1000425000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_EXT")]
    PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT = 1000425001,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_EXT")]
    RenderPassFragmentDensityMapOffsetEndInfoEXT = 1000425002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_DEVICE_MEMORY_FEATURES_EXT")]
    PhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT = 1000620000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_KHR")]
    PhysicalDevicePresentModeFifoLatestReadyFeaturesKHR = 1000361000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_KHR")]
    PhysicalDeviceOpacityMicromapFeaturesKHR = 1000623000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_KHR")]
    PhysicalDeviceOpacityMicromapPropertiesKHR = 1000623001,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MICROMAP_DATA_KHR")]
    AccelerationStructureGeometryMicromapDataKHR = 1000623002,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_KHR")]
    AccelerationStructureTrianglesOpacityMicromapKHR = 1000623003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_64_BIT_INDEXING_FEATURES_EXT")]
    PhysicalDeviceShader64BitIndexingFeaturesEXT = 1000627000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_RESOLVE_FEATURES_EXT")]
    PhysicalDeviceCustomResolveFeaturesEXT = 1000628000,

    [NativeName("VK_STRUCTURE_TYPE_BEGIN_CUSTOM_RESOLVE_INFO_EXT")]
    BeginCustomResolveInfoEXT = 1000628001,

    [NativeName("VK_STRUCTURE_TYPE_CUSTOM_RESOLVE_CREATE_INFO_EXT")]
    CustomResolveCreateInfoEXT = 1000628002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_MODEL_FEATURES_QCOM")]
    PhysicalDeviceDataGraphModelFeaturesQCOM = 1000629000,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_BUILTIN_MODEL_CREATE_INFO_QCOM")]
    DataGraphPipelineBuiltinModelCreateInfoQCOM = 1000629001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_FEATURES_KHR")]
    PhysicalDeviceMaintenance10FeaturesKHR = 1000630000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_PROPERTIES_KHR")]
    PhysicalDeviceMaintenance10PropertiesKHR = 1000630001,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_FLAGS_INFO_KHR")]
    RenderingAttachmentFlagsInfoKHR = 1000630002,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_END_INFO_KHR")]
    RenderingEndInfoKHR = 1000619003,

    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_MODE_INFO_KHR")]
    ResolveImageModeInfoKHR = 1000630004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_OPTICAL_FLOW_FEATURES_ARM")]
    PhysicalDeviceDataGraphOpticalFlowFeaturesARM = 1000631000,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_OPTICAL_FLOW_PROPERTIES_ARM")]
    QueueFamilyDataGraphOpticalFlowPropertiesARM = 1000631001,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_OPTICAL_FLOW_IMAGE_FORMAT_INFO_ARM")]
    DataGraphOpticalFlowImageFormatInfoARM = 1000631003,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_ARM")]
    DataGraphOpticalFlowImageFormatPropertiesARM = 1000631004,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_OPTICAL_FLOW_DISPATCH_INFO_ARM")]
    DataGraphPipelineOpticalFlowDispatchInfoARM = 1000631005,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_OPTICAL_FLOW_CREATE_INFO_ARM")]
    DataGraphPipelineOpticalFlowCreateInfoARM = 1000631002,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_RESOURCE_INFO_IMAGE_LAYOUT_ARM")]
    DataGraphPipelineResourceInfoImageLayoutARM = 1000631006,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SINGLE_NODE_CREATE_INFO_ARM")]
    DataGraphPipelineSingleNodeCreateInfoARM = 1000631007,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SINGLE_NODE_CONNECTION_ARM")]
    DataGraphPipelineSingleNodeConnectionARM = 1000631008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_LONG_VECTOR_FEATURES_EXT")]
    PhysicalDeviceShaderLongVectorFeaturesEXT = 1000635000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_LONG_VECTOR_PROPERTIES_EXT")]
    PhysicalDeviceShaderLongVectorPropertiesEXT = 1000635001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CACHE_INCREMENTAL_MODE_FEATURES_SEC")]
    PhysicalDevicePipelineCacheIncrementalModeFeaturesSEC = 1000637000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNIFORM_BUFFER_UNSIZED_ARRAY_FEATURES_EXT"
    )]
    PhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT = 1000642000,

    [NativeName("VK_STRUCTURE_TYPE_COMPUTE_OCCUPANCY_PRIORITY_PARAMETERS_NV")]
    ComputeOccupancyPriorityParametersNV = 1000645000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_OCCUPANCY_PRIORITY_FEATURES_NV")]
    PhysicalDeviceComputeOccupancyPriorityFeaturesNV = 1000645001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_11_FEATURES_KHR")]
    PhysicalDeviceMaintenance11FeaturesKHR = 1000657000,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_OPTIMAL_IMAGE_TRANSFER_GRANULARITY_PROPERTIES_KHR")]
    QueueFamilyOptimalImageTransferGranularityPropertiesKHR = 1000657001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_PARTITIONED_FEATURES_EXT")]
    PhysicalDeviceShaderSubgroupPartitionedFeaturesEXT = 1000662000,

    [NativeName("VK_STRUCTURE_TYPE_UBM_SURFACE_CREATE_INFO_SEC")]
    UbmSurfaceCreateInfoSEC = 1000664000,

    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_4_KHR")]
    FormatProperties4KHR = 1000668000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_CREATE_FLAGS_2_CREATE_INFO_KHR")]
    ImageCreateFlags2CreateInfoKHR = 1000668001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_USAGE_FLAGS_2_CREATE_INFO_KHR")]
    ImageUsageFlags2CreateInfoKHR = 1000668002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_2_CREATE_INFO_KHR")]
    ImageViewUsage2CreateInfoKHR = 1000668003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_FLAGS_FEATURES_KHR")]
    PhysicalDeviceExtendedFlagsFeaturesKHR = 1000668004,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_2_CREATE_INFO_KHR")]
    ImageStencilUsage2CreateInfoKHR = 1000668005,

    [NativeName("VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_2_KHR")]
    SharedPresentSurfaceCapabilities2KHR = 1000668006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MIXED_FLOAT_DOT_PRODUCT_FEATURES_VALVE")]
    PhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE = 1000673000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_THROTTLE_HINT_FEATURES_SEC")]
    PhysicalDeviceThrottleHintFeaturesSEC = 1000674000,

    [NativeName("VK_STRUCTURE_TYPE_THROTTLE_HINT_SUBMIT_INFO_SEC")]
    ThrottleHintSubmitInfoSEC = 1000674001,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_NEURAL_STATISTICS_CREATE_INFO_ARM")]
    DataGraphPipelineNeuralStatisticsCreateInfoARM = 1000676000,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_NEURAL_STATISTICS_CREATE_INFO_ARM")]
    DataGraphPipelineSessionNeuralStatisticsCreateInfoARM = 1000676001,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_NEURAL_ACCELERATOR_STATISTICS_FEATURES_ARM"
    )]
    PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM = 1000676002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_RESTART_INDEX_FEATURES_EXT")]
    PhysicalDevicePrimitiveRestartIndexFeaturesEXT = 1000678000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_DECODE_VECTOR_FEATURES_NV")]
    PhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV = 1000689000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES")]
    PhysicalDeviceVariablePointerFeatures = PhysicalDeviceVariablePointersFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETER_FEATURES")]
    PhysicalDeviceShaderDrawParameterFeatures = PhysicalDeviceShaderDrawParametersFeatures,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INFO_KHR")]
    RenderingInfoKHR = RenderingInfo,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO_KHR")]
    RenderingAttachmentInfoKHR = RenderingAttachmentInfo,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO_KHR")]
    PipelineRenderingCreateInfoKHR = PipelineRenderingCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES_KHR")]
    PhysicalDeviceDynamicRenderingFeaturesKHR = PhysicalDeviceDynamicRenderingFeatures,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO_KHR")]
    CommandBufferInheritanceRenderingInfoKHR = CommandBufferInheritanceRenderingInfo,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR")]
    RenderPassMultiviewCreateInfoKHR = RenderPassMultiviewCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR")]
    PhysicalDeviceMultiviewFeaturesKHR = PhysicalDeviceMultiviewFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR")]
    PhysicalDeviceMultiviewPropertiesKHR = PhysicalDeviceMultiviewProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR")]
    PhysicalDeviceFeatures2KHR = PhysicalDeviceFeatures2,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR")]
    PhysicalDeviceProperties2KHR = PhysicalDeviceProperties2,

    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR")]
    FormatProperties2KHR = FormatProperties2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR")]
    ImageFormatProperties2KHR = ImageFormatProperties2,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR")]
    PhysicalDeviceImageFormatInfo2KHR = PhysicalDeviceImageFormatInfo2,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR")]
    QueueFamilyProperties2KHR = QueueFamilyProperties2,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR")]
    PhysicalDeviceMemoryProperties2KHR = PhysicalDeviceMemoryProperties2,

    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR")]
    SparseImageFormatProperties2KHR = SparseImageFormatProperties2,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR")]
    PhysicalDeviceSparseImageFormatInfo2KHR = PhysicalDeviceSparseImageFormatInfo2,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR")]
    MemoryAllocateFlagsInfoKHR = MemoryAllocateFlagsInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR")]
    DeviceGroupRenderPassBeginInfoKHR = DeviceGroupRenderPassBeginInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR")]
    DeviceGroupCommandBufferBeginInfoKHR = DeviceGroupCommandBufferBeginInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR")]
    DeviceGroupSubmitInfoKHR = DeviceGroupSubmitInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR")]
    DeviceGroupBindSparseInfoKHR = DeviceGroupBindSparseInfo,

    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR")]
    BindBufferMemoryDeviceGroupInfoKHR = BindBufferMemoryDeviceGroupInfo,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR")]
    BindImageMemoryDeviceGroupInfoKHR = BindImageMemoryDeviceGroupInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT")]
    PhysicalDeviceTextureCompressionAstcHdrFeaturesEXT =
        PhysicalDeviceTextureCompressionAstcHdrFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT")]
    PipelineRobustnessCreateInfoEXT = PipelineRobustnessCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES_EXT")]
    PhysicalDevicePipelineRobustnessFeaturesEXT = PhysicalDevicePipelineRobustnessFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT")]
    PhysicalDevicePipelineRobustnessPropertiesEXT = PhysicalDevicePipelineRobustnessProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR")]
    PhysicalDeviceGroupPropertiesKHR = PhysicalDeviceGroupProperties,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR")]
    DeviceGroupDeviceCreateInfoKHR = DeviceGroupDeviceCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR")]
    PhysicalDeviceExternalImageFormatInfoKHR = PhysicalDeviceExternalImageFormatInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR")]
    ExternalImageFormatPropertiesKHR = ExternalImageFormatProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR")]
    PhysicalDeviceExternalBufferInfoKHR = PhysicalDeviceExternalBufferInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR")]
    ExternalBufferPropertiesKHR = ExternalBufferProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR")]
    PhysicalDeviceIdPropertiesKHR = PhysicalDeviceIdProperties,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR")]
    ExternalMemoryBufferCreateInfoKHR = ExternalMemoryBufferCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR")]
    ExternalMemoryImageCreateInfoKHR = ExternalMemoryImageCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR")]
    ExportMemoryAllocateInfoKHR = ExportMemoryAllocateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR")]
    PhysicalDeviceExternalSemaphoreInfoKHR = PhysicalDeviceExternalSemaphoreInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR")]
    ExternalSemaphorePropertiesKHR = ExternalSemaphoreProperties,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR")]
    ExportSemaphoreCreateInfoKHR = ExportSemaphoreCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR")]
    PhysicalDevicePushDescriptorPropertiesKHR = PhysicalDevicePushDescriptorProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR")]
    PhysicalDeviceShaderFloat16Int8FeaturesKHR = PhysicalDeviceShaderFloat16Int8Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR")]
    PhysicalDeviceFloat16Int8FeaturesKHR = PhysicalDeviceShaderFloat16Int8Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR")]
    PhysicalDevice16BitStorageFeaturesKHR = PhysicalDevice16BitStorageFeatures,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR")]
    DescriptorUpdateTemplateCreateInfoKHR = DescriptorUpdateTemplateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES_KHR")]
    PhysicalDeviceImagelessFramebufferFeaturesKHR = PhysicalDeviceImagelessFramebufferFeatures,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO_KHR")]
    FramebufferAttachmentsCreateInfoKHR = FramebufferAttachmentsCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO_KHR")]
    FramebufferAttachmentImageInfoKHR = FramebufferAttachmentImageInfo,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO_KHR")]
    RenderPassAttachmentBeginInfoKHR = RenderPassAttachmentBeginInfo,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR")]
    AttachmentDescription2KHR = AttachmentDescription2,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR")]
    AttachmentReference2KHR = AttachmentReference2,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR")]
    SubpassDescription2KHR = SubpassDescription2,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR")]
    SubpassDependency2KHR = SubpassDependency2,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR")]
    RenderPassCreateInfo2KHR = RenderPassCreateInfo2,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR")]
    SubpassBeginInfoKHR = SubpassBeginInfo,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR")]
    SubpassEndInfoKHR = SubpassEndInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR")]
    PhysicalDeviceExternalFenceInfoKHR = PhysicalDeviceExternalFenceInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR")]
    ExternalFencePropertiesKHR = ExternalFenceProperties,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR")]
    ExportFenceCreateInfoKHR = ExportFenceCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR")]
    PhysicalDevicePointClippingPropertiesKHR = PhysicalDevicePointClippingProperties,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR")]
    RenderPassInputAttachmentAspectCreateInfoKHR = RenderPassInputAttachmentAspectCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR")]
    ImageViewUsageCreateInfoKHR = ImageViewUsageCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR")]
    PipelineTessellationDomainOriginStateCreateInfoKHR =
        PipelineTessellationDomainOriginStateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR")]
    PhysicalDeviceVariablePointersFeaturesKHR = PhysicalDeviceVariablePointersFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR")]
    PhysicalDeviceVariablePointerFeaturesKHR = PhysicalDeviceVariablePointersFeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR")]
    MemoryDedicatedRequirementsKHR = MemoryDedicatedRequirements,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR")]
    MemoryDedicatedAllocateInfoKHR = MemoryDedicatedAllocateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT")]
    PhysicalDeviceSamplerFilterMinmaxPropertiesEXT = PhysicalDeviceSamplerFilterMinmaxProperties,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT")]
    SamplerReductionModeCreateInfoEXT = SamplerReductionModeCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT")]
    PhysicalDeviceInlineUniformBlockFeaturesEXT = PhysicalDeviceInlineUniformBlockFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT")]
    PhysicalDeviceInlineUniformBlockPropertiesEXT = PhysicalDeviceInlineUniformBlockProperties,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT")]
    WriteDescriptorSetInlineUniformBlockEXT = WriteDescriptorSetInlineUniformBlock,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT")]
    DescriptorPoolInlineUniformBlockCreateInfoEXT = DescriptorPoolInlineUniformBlockCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    BufferMemoryRequirementsInfo2KHR = BufferMemoryRequirementsInfo2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    ImageMemoryRequirementsInfo2KHR = ImageMemoryRequirementsInfo2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    ImageSparseMemoryRequirementsInfo2KHR = ImageSparseMemoryRequirementsInfo2,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR")]
    MemoryRequirements2KHR = MemoryRequirements2,

    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR")]
    SparseImageMemoryRequirements2KHR = SparseImageMemoryRequirements2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR")]
    ImageFormatListCreateInfoKHR = ImageFormatListCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_NV")]
    AttachmentSampleCountInfoNV = AttachmentSampleCountInfoAMD,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR")]
    SamplerYcbcrConversionCreateInfoKHR = SamplerYcbcrConversionCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR")]
    SamplerYcbcrConversionInfoKHR = SamplerYcbcrConversionInfo,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR")]
    BindImagePlaneMemoryInfoKHR = BindImagePlaneMemoryInfo,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR")]
    ImagePlaneMemoryRequirementsInfoKHR = ImagePlaneMemoryRequirementsInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR")]
    PhysicalDeviceSamplerYcbcrConversionFeaturesKHR = PhysicalDeviceSamplerYcbcrConversionFeatures,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR")]
    SamplerYcbcrConversionImageFormatPropertiesKHR = SamplerYcbcrConversionImageFormatProperties,

    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR")]
    BindBufferMemoryInfoKHR = BindBufferMemoryInfo,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR")]
    BindImageMemoryInfoKHR = BindImageMemoryInfo,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT")]
    DescriptorSetLayoutBindingFlagsCreateInfoEXT = DescriptorSetLayoutBindingFlagsCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT")]
    PhysicalDeviceDescriptorIndexingFeaturesEXT = PhysicalDeviceDescriptorIndexingFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT")]
    PhysicalDeviceDescriptorIndexingPropertiesEXT = PhysicalDeviceDescriptorIndexingProperties,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT")]
    DescriptorSetVariableDescriptorCountAllocateInfoEXT =
        DescriptorSetVariableDescriptorCountAllocateInfo,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT")]
    DescriptorSetVariableDescriptorCountLayoutSupportEXT =
        DescriptorSetVariableDescriptorCountLayoutSupport,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR")]
    PhysicalDeviceMaintenance3PropertiesKHR = PhysicalDeviceMaintenance3Properties,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR")]
    DescriptorSetLayoutSupportKHR = DescriptorSetLayoutSupport,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT")]
    DeviceQueueGlobalPriorityCreateInfoEXT = DeviceQueueGlobalPriorityCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR")]
    PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR =
        PhysicalDeviceShaderSubgroupExtendedTypesFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR")]
    PhysicalDevice8BitStorageFeaturesKHR = PhysicalDevice8BitStorageFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR")]
    PhysicalDeviceShaderAtomicInt64FeaturesKHR = PhysicalDeviceShaderAtomicInt64Features,

    [NativeName("VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT")]
    CalibratedTimestampInfoEXT = CalibratedTimestampInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR")]
    DeviceQueueGlobalPriorityCreateInfoKHR = DeviceQueueGlobalPriorityCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR")]
    PhysicalDeviceGlobalPriorityQueryFeaturesKHR = PhysicalDeviceGlobalPriorityQueryFeatures,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR")]
    QueueFamilyGlobalPriorityPropertiesKHR = QueueFamilyGlobalPriorityProperties,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT")]
    PipelineVertexInputDivisorStateCreateInfoEXT = PipelineVertexInputDivisorStateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT")]
    PhysicalDeviceVertexAttributeDivisorFeaturesEXT = PhysicalDeviceVertexAttributeDivisorFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT")]
    PipelineCreationFeedbackCreateInfoEXT = PipelineCreationFeedbackCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR")]
    PhysicalDeviceDriverPropertiesKHR = PhysicalDeviceDriverProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR")]
    PhysicalDeviceFloatControlsPropertiesKHR = PhysicalDeviceFloatControlsProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR")]
    PhysicalDeviceDepthStencilResolvePropertiesKHR = PhysicalDeviceDepthStencilResolveProperties,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR")]
    SubpassDescriptionDepthStencilResolveKHR = SubpassDescriptionDepthStencilResolve,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV")]
    PhysicalDeviceComputeShaderDerivativesFeaturesNV =
        PhysicalDeviceComputeShaderDerivativesFeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV")]
    PhysicalDeviceFragmentShaderBarycentricFeaturesNV =
        PhysicalDeviceFragmentShaderBarycentricFeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR")]
    PhysicalDeviceTimelineSemaphoreFeaturesKHR = PhysicalDeviceTimelineSemaphoreFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR")]
    PhysicalDeviceTimelineSemaphorePropertiesKHR = PhysicalDeviceTimelineSemaphoreProperties,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO_KHR")]
    SemaphoreTypeCreateInfoKHR = SemaphoreTypeCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR")]
    TimelineSemaphoreSubmitInfoKHR = TimelineSemaphoreSubmitInfo,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO_KHR")]
    SemaphoreWaitInfoKHR = SemaphoreWaitInfo,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO_KHR")]
    SemaphoreSignalInfoKHR = SemaphoreSignalInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR")]
    PhysicalDeviceVulkanMemoryModelFeaturesKHR = PhysicalDeviceVulkanMemoryModelFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR")]
    PhysicalDeviceShaderTerminateInvocationFeaturesKHR =
        PhysicalDeviceShaderTerminateInvocationFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT")]
    PhysicalDeviceScalarBlockLayoutFeaturesEXT = PhysicalDeviceScalarBlockLayoutFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT")]
    PhysicalDeviceSubgroupSizeControlPropertiesEXT = PhysicalDeviceSubgroupSizeControlProperties,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT")]
    PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT =
        PipelineShaderStageRequiredSubgroupSizeCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT")]
    PhysicalDeviceSubgroupSizeControlFeaturesEXT = PhysicalDeviceSubgroupSizeControlFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES_KHR")]
    PhysicalDeviceDynamicRenderingLocalReadFeaturesKHR =
        PhysicalDeviceDynamicRenderingLocalReadFeatures,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO_KHR")]
    RenderingAttachmentLocationInfoKHR = RenderingAttachmentLocationInfo,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO_KHR")]
    RenderingInputAttachmentIndexInfoKHR = RenderingInputAttachmentIndexInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES_KHR")]
    PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR =
        PhysicalDeviceSeparateDepthStencilLayoutsFeatures,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT_KHR")]
    AttachmentReferenceStencilLayoutKHR = AttachmentReferenceStencilLayout,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT_KHR")]
    AttachmentDescriptionStencilLayoutKHR = AttachmentDescriptionStencilLayout,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT")]
    PhysicalDeviceBufferAddressFeaturesEXT = PhysicalDeviceBufferDeviceAddressFeaturesEXT,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT")]
    BufferDeviceAddressInfoEXT = BufferDeviceAddressInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT")]
    PhysicalDeviceToolPropertiesEXT = PhysicalDeviceToolProperties,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT")]
    ImageStencilUsageCreateInfoEXT = ImageStencilUsageCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR")]
    PhysicalDeviceUniformBufferStandardLayoutFeaturesKHR =
        PhysicalDeviceUniformBufferStandardLayoutFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR")]
    PhysicalDeviceBufferDeviceAddressFeaturesKHR = PhysicalDeviceBufferDeviceAddressFeatures,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_KHR")]
    BufferDeviceAddressInfoKHR = BufferDeviceAddressInfo,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR")]
    BufferOpaqueCaptureAddressCreateInfoKHR = BufferOpaqueCaptureAddressCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR")]
    MemoryOpaqueCaptureAddressAllocateInfoKHR = MemoryOpaqueCaptureAddressAllocateInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR")]
    DeviceMemoryOpaqueCaptureAddressInfoKHR = DeviceMemoryOpaqueCaptureAddressInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT")]
    PhysicalDeviceLineRasterizationFeaturesEXT = PhysicalDeviceLineRasterizationFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT")]
    PipelineRasterizationLineStateCreateInfoEXT = PipelineRasterizationLineStateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT")]
    PhysicalDeviceLineRasterizationPropertiesEXT = PhysicalDeviceLineRasterizationProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT")]
    PhysicalDeviceHostQueryResetFeaturesEXT = PhysicalDeviceHostQueryResetFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT")]
    PhysicalDeviceIndexTypeUint8FeaturesEXT = PhysicalDeviceIndexTypeUint8Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES_EXT")]
    PhysicalDeviceHostImageCopyFeaturesEXT = PhysicalDeviceHostImageCopyFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES_EXT")]
    PhysicalDeviceHostImageCopyPropertiesEXT = PhysicalDeviceHostImageCopyProperties,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY_EXT")]
    MemoryToImageCopyEXT = MemoryToImageCopy,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY_EXT")]
    ImageToMemoryCopyEXT = ImageToMemoryCopy,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO_EXT")]
    CopyImageToMemoryInfoEXT = CopyImageToMemoryInfo,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO_EXT")]
    CopyMemoryToImageInfoEXT = CopyMemoryToImageInfo,

    [NativeName("VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO_EXT")]
    HostImageLayoutTransitionInfoEXT = HostImageLayoutTransitionInfo,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO_EXT")]
    CopyImageToImageInfoEXT = CopyImageToImageInfo,

    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE_EXT")]
    SubresourceHostMemcpySizeEXT = SubresourceHostMemcpySize,

    [NativeName("VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY_EXT")]
    HostImageCopyDevicePerformanceQueryEXT = HostImageCopyDevicePerformanceQuery,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR")]
    MemoryMapInfoKHR = MemoryMapInfo,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR")]
    MemoryUnmapInfoKHR = MemoryUnmapInfo,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT")]
    SurfacePresentModeEXT = SurfacePresentModeKHR,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT")]
    SurfacePresentScalingCapabilitiesEXT = SurfacePresentScalingCapabilitiesKHR,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT")]
    SurfacePresentModeCompatibilityEXT = SurfacePresentModeCompatibilityKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT")]
    PhysicalDeviceSwapchainMaintenance1FeaturesEXT = PhysicalDeviceSwapchainMaintenance1FeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT")]
    SwapchainPresentFenceInfoEXT = SwapchainPresentFenceInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT")]
    SwapchainPresentModesCreateInfoEXT = SwapchainPresentModesCreateInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT")]
    SwapchainPresentModeInfoEXT = SwapchainPresentModeInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT")]
    SwapchainPresentScalingCreateInfoEXT = SwapchainPresentScalingCreateInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT")]
    ReleaseSwapchainImagesInfoEXT = ReleaseSwapchainImagesInfoKHR,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT"
    )]
    PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT =
        PhysicalDeviceShaderDemoteToHelperInvocationFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES_KHR")]
    PhysicalDeviceShaderIntegerDotProductFeaturesKHR =
        PhysicalDeviceShaderIntegerDotProductFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES_KHR")]
    PhysicalDeviceShaderIntegerDotProductPropertiesKHR =
        PhysicalDeviceShaderIntegerDotProductProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT")]
    PhysicalDeviceTexelBufferAlignmentPropertiesEXT = PhysicalDeviceTexelBufferAlignmentProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT")]
    PhysicalDeviceRobustness2FeaturesEXT = PhysicalDeviceRobustness2FeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT")]
    PhysicalDeviceRobustness2PropertiesEXT = PhysicalDeviceRobustness2PropertiesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT")]
    PhysicalDevicePrivateDataFeaturesEXT = PhysicalDevicePrivateDataFeatures,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT")]
    DevicePrivateDataCreateInfoEXT = DevicePrivateDataCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT")]
    PrivateDataSlotCreateInfoEXT = PrivateDataSlotCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT")]
    PhysicalDevicePipelineCreationCacheControlFeaturesEXT =
        PhysicalDevicePipelineCreationCacheControlFeatures,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER_2_KHR")]
    MemoryBarrier2KHR = MemoryBarrier2,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2_KHR")]
    BufferMemoryBarrier2KHR = BufferMemoryBarrier2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2_KHR")]
    ImageMemoryBarrier2KHR = ImageMemoryBarrier2,

    [NativeName("VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR")]
    DependencyInfoKHR = DependencyInfo,

    [NativeName("VK_STRUCTURE_TYPE_SUBMIT_INFO_2_KHR")]
    SubmitInfo2KHR = SubmitInfo2,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR")]
    SemaphoreSubmitInfoKHR = SemaphoreSubmitInfo,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR")]
    CommandBufferSubmitInfoKHR = CommandBufferSubmitInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR")]
    PhysicalDeviceSynchronization2FeaturesKHR = PhysicalDeviceSynchronization2Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR")]
    PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR =
        PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT")]
    PhysicalDeviceImageRobustnessFeaturesEXT = PhysicalDeviceImageRobustnessFeatures,

    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR")]
    CopyBufferInfo2KHR = CopyBufferInfo2,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR")]
    CopyImageInfo2KHR = CopyImageInfo2,

    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR")]
    CopyBufferToImageInfo2KHR = CopyBufferToImageInfo2,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR")]
    CopyImageToBufferInfo2KHR = CopyImageToBufferInfo2,

    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR")]
    BlitImageInfo2KHR = BlitImageInfo2,

    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR")]
    ResolveImageInfo2KHR = ResolveImageInfo2,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR")]
    BufferCopy2KHR = BufferCopy2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR")]
    ImageCopy2KHR = ImageCopy2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR")]
    ImageBlit2KHR = ImageBlit2,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR")]
    BufferImageCopy2KHR = BufferImageCopy2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR")]
    ImageResolve2KHR = ImageResolve2,

    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_EXT")]
    SubresourceLayout2EXT = SubresourceLayout2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_EXT")]
    ImageSubresource2EXT = ImageSubresource2,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_ARM"
    )]
    PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM =
        PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE")]
    PhysicalDeviceMutableDescriptorTypeFeaturesVALVE =
        PhysicalDeviceMutableDescriptorTypeFeaturesEXT,

    [NativeName("VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE")]
    MutableDescriptorTypeCreateInfoVALVE = MutableDescriptorTypeCreateInfoEXT,

    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3_KHR")]
    FormatProperties3KHR = FormatProperties3,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_EXT")]
    PhysicalDevicePresentModeFifoLatestReadyFeaturesEXT =
        PhysicalDevicePresentModeFifoLatestReadyFeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INFO_EXT")]
    PipelineInfoEXT = PipelineInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT")]
    PhysicalDeviceGlobalPriorityQueryFeaturesEXT = PhysicalDeviceGlobalPriorityQueryFeatures,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT")]
    QueueFamilyGlobalPriorityPropertiesEXT = QueueFamilyGlobalPriorityProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES_KHR")]
    PhysicalDeviceMaintenance4FeaturesKHR = PhysicalDeviceMaintenance4Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES_KHR")]
    PhysicalDeviceMaintenance4PropertiesKHR = PhysicalDeviceMaintenance4Properties,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS_KHR")]
    DeviceBufferMemoryRequirementsKHR = DeviceBufferMemoryRequirements,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS_KHR")]
    DeviceImageMemoryRequirementsKHR = DeviceImageMemoryRequirements,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES_KHR")]
    PhysicalDeviceShaderSubgroupRotateFeaturesKHR = PhysicalDeviceShaderSubgroupRotateFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT")]
    PhysicalDeviceDepthClampZeroOneFeaturesEXT = PhysicalDeviceDepthClampZeroOneFeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM")]
    PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM =
        PhysicalDeviceFragmentDensityMapOffsetFeaturesEXT,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM")]
    PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM =
        PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM")]
    SubpassFragmentDensityMapOffsetEndInfoQCOM = RenderPassFragmentDensityMapOffsetEndInfoEXT,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_NV")]
    PhysicalDeviceCopyMemoryIndirectPropertiesNV = PhysicalDeviceCopyMemoryIndirectPropertiesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_NV")]
    PhysicalDeviceMemoryDecompressionFeaturesNV = PhysicalDeviceMemoryDecompressionFeaturesEXT,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV")]
    PhysicalDeviceMemoryDecompressionPropertiesNV = PhysicalDeviceMemoryDecompressionPropertiesEXT,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT")]
    PhysicalDevicePipelineProtectedAccessFeaturesEXT =
        PhysicalDevicePipelineProtectedAccessFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES_KHR")]
    PhysicalDeviceMaintenance5FeaturesKHR = PhysicalDeviceMaintenance5Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES_KHR")]
    PhysicalDeviceMaintenance5PropertiesKHR = PhysicalDeviceMaintenance5Properties,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_AREA_INFO_KHR")]
    RenderingAreaInfoKHR = RenderingAreaInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO_KHR")]
    DeviceImageSubresourceInfoKHR = DeviceImageSubresourceInfo,

    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_KHR")]
    SubresourceLayout2KHR = SubresourceLayout2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_KHR")]
    ImageSubresource2KHR = ImageSubresource2,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO_KHR")]
    PipelineCreateFlags2CreateInfoKHR = PipelineCreateFlags2CreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO_KHR")]
    BufferUsageFlags2CreateInfoKHR = BufferUsageFlags2CreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT")]
    ShaderRequiredSubgroupSizeCreateInfoEXT = PipelineShaderStageRequiredSubgroupSizeCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_KHR")]
    PhysicalDeviceVertexAttributeDivisorPropertiesKHR =
        PhysicalDeviceVertexAttributeDivisorProperties,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_KHR")]
    PipelineVertexInputDivisorStateCreateInfoKHR = PipelineVertexInputDivisorStateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_KHR")]
    PhysicalDeviceVertexAttributeDivisorFeaturesKHR = PhysicalDeviceVertexAttributeDivisorFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES_KHR")]
    PhysicalDeviceShaderFloatControls2FeaturesKHR = PhysicalDeviceShaderFloatControls2Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_KHR")]
    PhysicalDeviceIndexTypeUint8FeaturesKHR = PhysicalDeviceIndexTypeUint8Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_KHR")]
    PhysicalDeviceLineRasterizationFeaturesKHR = PhysicalDeviceLineRasterizationFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_KHR")]
    PipelineRasterizationLineStateCreateInfoKHR = PipelineRasterizationLineStateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_KHR")]
    PhysicalDeviceLineRasterizationPropertiesKHR = PhysicalDeviceLineRasterizationProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES_KHR")]
    PhysicalDeviceShaderExpectAssumeFeaturesKHR = PhysicalDeviceShaderExpectAssumeFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES_KHR")]
    PhysicalDeviceMaintenance6FeaturesKHR = PhysicalDeviceMaintenance6Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES_KHR")]
    PhysicalDeviceMaintenance6PropertiesKHR = PhysicalDeviceMaintenance6Properties,

    [NativeName("VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS_KHR")]
    BindMemoryStatusKHR = BindMemoryStatus,

    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO_KHR")]
    BindDescriptorSetsInfoKHR = BindDescriptorSetsInfo,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO_KHR")]
    PushConstantsInfoKHR = PushConstantsInfo,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO_KHR")]
    PushDescriptorSetInfoKHR = PushDescriptorSetInfo,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO_KHR")]
    PushDescriptorSetWithTemplateInfoKHR = PushDescriptorSetWithTemplateInfo,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_END_INFO_EXT")]
    RenderingEndInfoEXT = RenderingEndInfoKHR,
}
