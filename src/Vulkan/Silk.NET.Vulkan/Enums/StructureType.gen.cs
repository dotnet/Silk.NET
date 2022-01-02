// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkStructureType")]
    public enum StructureType : int
    {
        [NativeName("Name", "VK_STRUCTURE_TYPE_APPLICATION_INFO")]
        ApplicationInfo = 0,
        [NativeName("Name", "VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO")]
        InstanceCreateInfo = 1,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO")]
        DeviceQueueCreateInfo = 2,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO")]
        DeviceCreateInfo = 3,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBMIT_INFO")]
        SubmitInfo = 4,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO")]
        MemoryAllocateInfo = 5,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE")]
        MappedMemoryRange = 6,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_SPARSE_INFO")]
        BindSparseInfo = 7,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FENCE_CREATE_INFO")]
        FenceCreateInfo = 8,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO")]
        SemaphoreCreateInfo = 9,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EVENT_CREATE_INFO")]
        EventCreateInfo = 10,
        [NativeName("Name", "VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO")]
        QueryPoolCreateInfo = 11,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO")]
        BufferCreateInfo = 12,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO")]
        BufferViewCreateInfo = 13,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO")]
        ImageCreateInfo = 14,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO")]
        ImageViewCreateInfo = 15,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO")]
        ShaderModuleCreateInfo = 16,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO")]
        PipelineCacheCreateInfo = 17,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO")]
        PipelineShaderStageCreateInfo = 18,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO")]
        PipelineVertexInputStateCreateInfo = 19,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO")]
        PipelineInputAssemblyStateCreateInfo = 20,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO")]
        PipelineTessellationStateCreateInfo = 21,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO")]
        PipelineViewportStateCreateInfo = 22,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO")]
        PipelineRasterizationStateCreateInfo = 23,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO")]
        PipelineMultisampleStateCreateInfo = 24,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO")]
        PipelineDepthStencilStateCreateInfo = 25,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO")]
        PipelineColorBlendStateCreateInfo = 26,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO")]
        PipelineDynamicStateCreateInfo = 27,
        [NativeName("Name", "VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO")]
        GraphicsPipelineCreateInfo = 28,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO")]
        ComputePipelineCreateInfo = 29,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO")]
        PipelineLayoutCreateInfo = 30,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO")]
        SamplerCreateInfo = 31,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO")]
        DescriptorSetLayoutCreateInfo = 32,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO")]
        DescriptorPoolCreateInfo = 33,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO")]
        DescriptorSetAllocateInfo = 34,
        [NativeName("Name", "VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET")]
        WriteDescriptorSet = 35,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET")]
        CopyDescriptorSet = 36,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO")]
        FramebufferCreateInfo = 37,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO")]
        RenderPassCreateInfo = 38,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO")]
        CommandPoolCreateInfo = 39,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO")]
        CommandBufferAllocateInfo = 40,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO")]
        CommandBufferInheritanceInfo = 41,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO")]
        CommandBufferBeginInfo = 42,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO")]
        RenderPassBeginInfo = 43,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER")]
        BufferMemoryBarrier = 44,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER")]
        ImageMemoryBarrier = 45,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_BARRIER")]
        MemoryBarrier = 46,
        [NativeName("Name", "VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO")]
        LoaderInstanceCreateInfo = 47,
        [NativeName("Name", "VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO")]
        LoaderDeviceCreateInfo = 48,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR")]
        SwapchainCreateInfoKhr = 1000001000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PRESENT_INFO_KHR")]
        PresentInfoKhr = 1000001001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR")]
        DeviceGroupPresentCapabilitiesKhr = 1000060007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR")]
        ImageSwapchainCreateInfoKhr = 1000060008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR")]
        BindImageMemorySwapchainInfoKhr = 1000060009,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR")]
        AcquireNextImageInfoKhr = 1000060010,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR")]
        DeviceGroupPresentInfoKhr = 1000060011,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR")]
        DeviceGroupSwapchainCreateInfoKhr = 1000060012,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR")]
        DisplayModeCreateInfoKhr = 1000002000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR")]
        DisplaySurfaceCreateInfoKhr = 1000002001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR")]
        DisplayPresentInfoKhr = 1000003000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR")]
        XlibSurfaceCreateInfoKhr = 1000004000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR")]
        XcbSurfaceCreateInfoKhr = 1000005000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR")]
        WaylandSurfaceCreateInfoKhr = 1000006000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR")]
        AndroidSurfaceCreateInfoKhr = 1000008000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR")]
        Win32SurfaceCreateInfoKhr = 1000009000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_NATIVE_BUFFER_ANDROID")]
        NativeBufferAndroid = 1000010000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SWAPCHAIN_IMAGE_CREATE_INFO_ANDROID")]
        SwapchainImageCreateInfoAndroid = 1000010001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENTATION_PROPERTIES_ANDROID")]
        PhysicalDevicePresentationPropertiesAndroid = 1000010002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT")]
        DebugReportCallbackCreateInfoExt = 1000011000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT")]
        DebugReportCreateInfoExt = 1000011000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD")]
        PipelineRasterizationStateRasterizationOrderAmd = 1000018000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT")]
        DebugMarkerObjectNameInfoExt = 1000022000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT")]
        DebugMarkerObjectTagInfoExt = 1000022001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT")]
        DebugMarkerMarkerInfoExt = 1000022002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_PROFILE_KHR")]
        VideoProfileKhr = 1000023000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR")]
        VideoCapabilitiesKhr = 1000023001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_KHR")]
        VideoPictureResourceKhr = 1000023002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_GET_MEMORY_PROPERTIES_KHR")]
        VideoGetMemoryPropertiesKhr = 1000023003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_BIND_MEMORY_KHR")]
        VideoBindMemoryKhr = 1000023004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR")]
        VideoSessionCreateInfoKhr = 1000023005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR")]
        VideoSessionParametersCreateInfoKhr = 1000023006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR")]
        VideoSessionParametersUpdateInfoKhr = 1000023007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR")]
        VideoBeginCodingInfoKhr = 1000023008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR")]
        VideoEndCodingInfoKhr = 1000023009,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR")]
        VideoCodingControlInfoKhr = 1000023010,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_KHR")]
        VideoReferenceSlotKhr = 1000023011,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_QUEUE_FAMILY_PROPERTIES_2_KHR")]
        VideoQueueFamilyProperties2Khr = 1000023012,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_PROFILES_KHR")]
        VideoProfilesKhr = 1000023013,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR")]
        PhysicalDeviceVideoFormatInfoKhr = 1000023014,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR")]
        VideoFormatPropertiesKhr = 1000023015,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR")]
        VideoDecodeInfoKhr = 1000024000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV")]
        DedicatedAllocationImageCreateInfoNV = 1000026000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV")]
        DedicatedAllocationBufferCreateInfoNV = 1000026001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV")]
        DedicatedAllocationMemoryAllocateInfoNV = 1000026002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT")]
        PhysicalDeviceTransformFeedbackFeaturesExt = 1000028000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT")]
        PhysicalDeviceTransformFeedbackPropertiesExt = 1000028001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT")]
        PipelineRasterizationStateStreamCreateInfoExt = 1000028002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX")]
        CUModuleCreateInfoNvx = 1000029000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX")]
        CUFunctionCreateInfoNvx = 1000029001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX")]
        CULaunchInfoNvx = 1000029002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX")]
        ImageViewHandleInfoNvx = 1000030000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX")]
        ImageViewAddressPropertiesNvx = 1000030001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_EXT")]
        VideoEncodeH264CapabilitiesExt = 1000038000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_EXT")]
        VideoEncodeH264SessionCreateInfoExt = 1000038001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_EXT")]
        VideoEncodeH264SessionParametersCreateInfoExt = 1000038002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_EXT")]
        VideoEncodeH264SessionParametersAddInfoExt = 1000038003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_VCL_FRAME_INFO_EXT")]
        VideoEncodeH264VclFrameInfoExt = 1000038004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_EXT")]
        VideoEncodeH264DpbSlotInfoExt = 1000038005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_EXT")]
        VideoEncodeH264NaluSliceExt = 1000038006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_EMIT_PICTURE_PARAMETERS_EXT")]
        VideoEncodeH264EmitPictureParametersExt = 1000038007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_EXT")]
        VideoEncodeH264ProfileExt = 1000038008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_EXT")]
        VideoEncodeH264RateControlInfoExt = 1000038009,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_EXT")]
        VideoEncodeH264RateControlLayerInfoExt = 1000038010,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_EXT")]
        VideoEncodeH265CapabilitiesExt = 1000039000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_EXT")]
        VideoEncodeH265SessionCreateInfoExt = 1000039001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_EXT")]
        VideoEncodeH265SessionParametersCreateInfoExt = 1000039002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_EXT")]
        VideoEncodeH265SessionParametersAddInfoExt = 1000039003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_VCL_FRAME_INFO_EXT")]
        VideoEncodeH265VclFrameInfoExt = 1000039004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_EXT")]
        VideoEncodeH265DpbSlotInfoExt = 1000039005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_EXT")]
        VideoEncodeH265NaluSliceExt = 1000039006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_EMIT_PICTURE_PARAMETERS_EXT")]
        VideoEncodeH265EmitPictureParametersExt = 1000039007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_EXT")]
        VideoEncodeH265ProfileExt = 1000039008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_REFERENCE_LISTS_EXT")]
        VideoEncodeH265ReferenceListsExt = 1000039009,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_EXT")]
        VideoEncodeH265RateControlInfoExt = 1000039010,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_EXT")]
        VideoEncodeH265RateControlLayerInfoExt = 1000039011,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_EXT")]
        VideoDecodeH264CapabilitiesExt = 1000040000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_CREATE_INFO_EXT")]
        VideoDecodeH264SessionCreateInfoExt = 1000040001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_EXT")]
        VideoDecodeH264PictureInfoExt = 1000040002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_MVC_EXT")]
        VideoDecodeH264MvcExt = 1000040003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_EXT")]
        VideoDecodeH264ProfileExt = 1000040004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_EXT")]
        VideoDecodeH264SessionParametersCreateInfoExt = 1000040005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_EXT")]
        VideoDecodeH264SessionParametersAddInfoExt = 1000040006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_EXT")]
        VideoDecodeH264DpbSlotInfoExt = 1000040007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD")]
        TextureLodGatherFormatPropertiesAmd = 1000041000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDERING_INFO_KHR")]
        RenderingInfoKhr = 1000044000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO_KHR")]
        RenderingAttachmentInfoKhr = 1000044001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO_KHR")]
        PipelineRenderingCreateInfoKhr = 1000044002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES_KHR")]
        PhysicalDeviceDynamicRenderingFeaturesKhr = 1000044003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO_KHR")]
        CommandBufferInheritanceRenderingInfoKhr = 1000044004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR")]
        RenderingFragmentShadingRateAttachmentInfoKhr = 1000044006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT")]
        RenderingFragmentDensityMapAttachmentInfoExt = 1000044007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD")]
        AttachmentSampleCountInfoAmd = 1000044008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_NV")]
        AttachmentSampleCountInfoNV = 1000044008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX")]
        MultiviewPerViewAttributesInfoNvx = 1000044009,
        [NativeName("Name", "VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP")]
        StreamDescriptorSurfaceCreateInfoGgp = 1000049000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV")]
        PhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR")]
        RenderPassMultiviewCreateInfoKhr = 1000053000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR")]
        PhysicalDeviceMultiviewFeaturesKhr = 1000053001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR")]
        PhysicalDeviceMultiviewPropertiesKhr = 1000053002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV")]
        ExternalMemoryImageCreateInfoNV = 1000056000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV")]
        ExportMemoryAllocateInfoNV = 1000056001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV")]
        ImportMemoryWin32HandleInfoNV = 1000057000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV")]
        ExportMemoryWin32HandleInfoNV = 1000057001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV")]
        Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR")]
        PhysicalDeviceFeatures2Khr = 1000059000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR")]
        PhysicalDeviceProperties2Khr = 1000059001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR")]
        FormatProperties2Khr = 1000059002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR")]
        ImageFormatProperties2Khr = 1000059003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR")]
        PhysicalDeviceImageFormatInfo2Khr = 1000059004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR")]
        QueueFamilyProperties2Khr = 1000059005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR")]
        PhysicalDeviceMemoryProperties2Khr = 1000059006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR")]
        SparseImageFormatProperties2Khr = 1000059007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR")]
        PhysicalDeviceSparseImageFormatInfo2Khr = 1000059008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR")]
        MemoryAllocateFlagsInfoKhr = 1000060000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR")]
        DeviceGroupRenderPassBeginInfoKhr = 1000060003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR")]
        DeviceGroupCommandBufferBeginInfoKhr = 1000060004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR")]
        DeviceGroupSubmitInfoKhr = 1000060005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR")]
        DeviceGroupBindSparseInfoKhr = 1000060006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR")]
        BindBufferMemoryDeviceGroupInfoKhr = 1000060013,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR")]
        BindImageMemoryDeviceGroupInfoKhr = 1000060014,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT")]
        ValidationFlagsExt = 1000061000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN")]
        VISurfaceCreateInfoNN = 1000062000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT")]
        PhysicalDeviceTextureCompressionAstcHdrFeaturesExt = 1000066000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT")]
        ImageViewAstcDecodeModeExt = 1000067000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT")]
        PhysicalDeviceAstcDecodeFeaturesExt = 1000067001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR")]
        PhysicalDeviceGroupPropertiesKhr = 1000070000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR")]
        DeviceGroupDeviceCreateInfoKhr = 1000070001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR")]
        PhysicalDeviceExternalImageFormatInfoKhr = 1000071000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR")]
        ExternalImageFormatPropertiesKhr = 1000071001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR")]
        PhysicalDeviceExternalBufferInfoKhr = 1000071002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR")]
        ExternalBufferPropertiesKhr = 1000071003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR")]
        PhysicalDeviceIDPropertiesKhr = 1000071004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR")]
        ExternalMemoryBufferCreateInfoKhr = 1000072000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR")]
        ExternalMemoryImageCreateInfoKhr = 1000072001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR")]
        ExportMemoryAllocateInfoKhr = 1000072002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR")]
        ImportMemoryWin32HandleInfoKhr = 1000073000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR")]
        ExportMemoryWin32HandleInfoKhr = 1000073001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR")]
        MemoryWin32HandlePropertiesKhr = 1000073002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR")]
        MemoryGetWin32HandleInfoKhr = 1000073003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR")]
        ImportMemoryFDInfoKhr = 1000074000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR")]
        MemoryFDPropertiesKhr = 1000074001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR")]
        MemoryGetFDInfoKhr = 1000074002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR")]
        Win32KeyedMutexAcquireReleaseInfoKhr = 1000075000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR")]
        PhysicalDeviceExternalSemaphoreInfoKhr = 1000076000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR")]
        ExternalSemaphorePropertiesKhr = 1000076001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR")]
        ExportSemaphoreCreateInfoKhr = 1000077000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR")]
        ImportSemaphoreWin32HandleInfoKhr = 1000078000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR")]
        ExportSemaphoreWin32HandleInfoKhr = 1000078001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR")]
        D3D12FenceSubmitInfoKhr = 1000078002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR")]
        SemaphoreGetWin32HandleInfoKhr = 1000078003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR")]
        ImportSemaphoreFDInfoKhr = 1000079000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR")]
        SemaphoreGetFDInfoKhr = 1000079001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR")]
        PhysicalDevicePushDescriptorPropertiesKhr = 1000080000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT")]
        CommandBufferInheritanceConditionalRenderingInfoExt = 1000081000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT")]
        PhysicalDeviceConditionalRenderingFeaturesExt = 1000081001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT")]
        ConditionalRenderingBeginInfoExt = 1000081002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR")]
        PhysicalDeviceShaderFloat16Int8FeaturesKhr = 1000082000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR")]
        PhysicalDeviceFloat16Int8FeaturesKhr = 1000082000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR")]
        PhysicalDevice16BitStorageFeaturesKhr = 1000083000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR")]
        PresentRegionsKhr = 1000084000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR")]
        DescriptorUpdateTemplateCreateInfoKhr = 1000085000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV")]
        PipelineViewportWScalingStateCreateInfoNV = 1000087000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT")]
        SurfaceCapabilities2Ext = 1000090000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT")]
        DisplayPowerInfoExt = 1000091000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT")]
        DeviceEventInfoExt = 1000091001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT")]
        DisplayEventInfoExt = 1000091002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT")]
        SwapchainCounterCreateInfoExt = 1000091003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE")]
        PresentTimesInfoGoogle = 1000092000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX")]
        PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx = 1000097000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV")]
        PipelineViewportSwizzleStateCreateInfoNV = 1000098000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT")]
        PhysicalDeviceDiscardRectanglePropertiesExt = 1000099000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT")]
        PipelineDiscardRectangleStateCreateInfoExt = 1000099001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT")]
        PhysicalDeviceConservativeRasterizationPropertiesExt = 1000101000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT")]
        PipelineRasterizationConservativeStateCreateInfoExt = 1000101001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT")]
        PhysicalDeviceDepthClipEnableFeaturesExt = 1000102000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT")]
        PipelineRasterizationDepthClipStateCreateInfoExt = 1000102001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_HDR_METADATA_EXT")]
        HdrMetadataExt = 1000105000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES_KHR")]
        PhysicalDeviceImagelessFramebufferFeaturesKhr = 1000108000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO_KHR")]
        FramebufferAttachmentsCreateInfoKhr = 1000108001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO_KHR")]
        FramebufferAttachmentImageInfoKhr = 1000108002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO_KHR")]
        RenderPassAttachmentBeginInfoKhr = 1000108003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR")]
        AttachmentDescription2Khr = 1000109000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR")]
        AttachmentReference2Khr = 1000109001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR")]
        SubpassDescription2Khr = 1000109002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR")]
        SubpassDependency2Khr = 1000109003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR")]
        RenderPassCreateInfo2Khr = 1000109004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR")]
        SubpassBeginInfoKhr = 1000109005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR")]
        SubpassEndInfoKhr = 1000109006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR")]
        SharedPresentSurfaceCapabilitiesKhr = 1000111000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR")]
        PhysicalDeviceExternalFenceInfoKhr = 1000112000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR")]
        ExternalFencePropertiesKhr = 1000112001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR")]
        ExportFenceCreateInfoKhr = 1000113000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR")]
        ImportFenceWin32HandleInfoKhr = 1000114000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR")]
        ExportFenceWin32HandleInfoKhr = 1000114001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR")]
        FenceGetWin32HandleInfoKhr = 1000114002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR")]
        ImportFenceFDInfoKhr = 1000115000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR")]
        FenceGetFDInfoKhr = 1000115001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR")]
        PhysicalDevicePerformanceQueryFeaturesKhr = 1000116000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR")]
        PhysicalDevicePerformanceQueryPropertiesKhr = 1000116001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR")]
        QueryPoolPerformanceCreateInfoKhr = 1000116002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR")]
        PerformanceQuerySubmitInfoKhr = 1000116003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR")]
        AcquireProfilingLockInfoKhr = 1000116004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR")]
        PerformanceCounterKhr = 1000116005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR")]
        PerformanceCounterDescriptionKhr = 1000116006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR")]
        PhysicalDevicePointClippingPropertiesKhr = 1000117000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR")]
        RenderPassInputAttachmentAspectCreateInfoKhr = 1000117001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR")]
        ImageViewUsageCreateInfoKhr = 1000117002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR")]
        PipelineTessellationDomainOriginStateCreateInfoKhr = 1000117003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR")]
        PhysicalDeviceSurfaceInfo2Khr = 1000119000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR")]
        SurfaceCapabilities2Khr = 1000119001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR")]
        SurfaceFormat2Khr = 1000119002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR")]
        PhysicalDeviceVariablePointersFeaturesKhr = 1000120000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR")]
        PhysicalDeviceVariablePointerFeaturesKhr = 1000120000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR")]
        DisplayProperties2Khr = 1000121000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR")]
        DisplayPlaneProperties2Khr = 1000121001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR")]
        DisplayModeProperties2Khr = 1000121002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR")]
        DisplayPlaneInfo2Khr = 1000121003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR")]
        DisplayPlaneCapabilities2Khr = 1000121004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK")]
        IosSurfaceCreateInfoMvk = 1000122000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK")]
        MacosSurfaceCreateInfoMvk = 1000123000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR")]
        MemoryDedicatedRequirementsKhr = 1000127000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR")]
        MemoryDedicatedAllocateInfoKhr = 1000127001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
        DebugUtilsObjectNameInfoExt = 1000128000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT")]
        DebugUtilsObjectTagInfoExt = 1000128001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT")]
        DebugUtilsLabelExt = 1000128002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
        DebugUtilsMessengerCallbackDataExt = 1000128003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
        DebugUtilsMessengerCreateInfoExt = 1000128004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID")]
        AndroidHardwareBufferUsageAndroid = 1000129000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID")]
        AndroidHardwareBufferPropertiesAndroid = 1000129001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID")]
        AndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID")]
        ImportAndroidHardwareBufferInfoAndroid = 1000129003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID")]
        MemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID")]
        ExternalFormatAndroid = 1000129005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID")]
        AndroidHardwareBufferFormatProperties2Android = 1000129006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT")]
        PhysicalDeviceSamplerFilterMinmaxPropertiesExt = 1000130000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT")]
        SamplerReductionModeCreateInfoExt = 1000130001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT")]
        PhysicalDeviceInlineUniformBlockFeaturesExt = 1000138000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT")]
        PhysicalDeviceInlineUniformBlockPropertiesExt = 1000138001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT")]
        WriteDescriptorSetInlineUniformBlockExt = 1000138002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT")]
        DescriptorPoolInlineUniformBlockCreateInfoExt = 1000138003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT")]
        SampleLocationsInfoExt = 1000143000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT")]
        RenderPassSampleLocationsBeginInfoExt = 1000143001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT")]
        PipelineSampleLocationsStateCreateInfoExt = 1000143002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT")]
        PhysicalDeviceSampleLocationsPropertiesExt = 1000143003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT")]
        MultisamplePropertiesExt = 1000143004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR")]
        BufferMemoryRequirementsInfo2Khr = 1000146000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR")]
        ImageMemoryRequirementsInfo2Khr = 1000146001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR")]
        ImageSparseMemoryRequirementsInfo2Khr = 1000146002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR")]
        MemoryRequirements2Khr = 1000146003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR")]
        SparseImageMemoryRequirements2Khr = 1000146004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR")]
        ImageFormatListCreateInfoKhr = 1000147000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT")]
        PhysicalDeviceBlendOperationAdvancedFeaturesExt = 1000148000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT")]
        PhysicalDeviceBlendOperationAdvancedPropertiesExt = 1000148001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT")]
        PipelineColorBlendAdvancedStateCreateInfoExt = 1000148002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV")]
        PipelineCoverageToColorStateCreateInfoNV = 1000149000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR")]
        WriteDescriptorSetAccelerationStructureKhr = 1000150007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR")]
        AccelerationStructureBuildGeometryInfoKhr = 1000150000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR")]
        AccelerationStructureDeviceAddressInfoKhr = 1000150002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR")]
        AccelerationStructureGeometryAabbsDataKhr = 1000150003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR")]
        AccelerationStructureGeometryInstancesDataKhr = 1000150004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR")]
        AccelerationStructureGeometryTrianglesDataKhr = 1000150005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR")]
        AccelerationStructureGeometryKhr = 1000150006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR")]
        AccelerationStructureVersionInfoKhr = 1000150009,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR")]
        CopyAccelerationStructureInfoKhr = 1000150010,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR")]
        CopyAccelerationStructureToMemoryInfoKhr = 1000150011,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR")]
        CopyMemoryToAccelerationStructureInfoKhr = 1000150012,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR")]
        PhysicalDeviceAccelerationStructureFeaturesKhr = 1000150013,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR")]
        PhysicalDeviceAccelerationStructurePropertiesKhr = 1000150014,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR")]
        AccelerationStructureCreateInfoKhr = 1000150017,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR")]
        AccelerationStructureBuildSizesInfoKhr = 1000150020,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR")]
        PhysicalDeviceRayTracingPipelineFeaturesKhr = 1000347000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR")]
        PhysicalDeviceRayTracingPipelinePropertiesKhr = 1000347001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR")]
        RayTracingPipelineCreateInfoKhr = 1000150015,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR")]
        RayTracingShaderGroupCreateInfoKhr = 1000150016,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR")]
        RayTracingPipelineInterfaceCreateInfoKhr = 1000150018,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR")]
        PhysicalDeviceRayQueryFeaturesKhr = 1000348013,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV")]
        PipelineCoverageModulationStateCreateInfoNV = 1000152000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV")]
        PhysicalDeviceShaderSMBuiltinsFeaturesNV = 1000154000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV")]
        PhysicalDeviceShaderSMBuiltinsPropertiesNV = 1000154001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR")]
        SamplerYcbcrConversionCreateInfoKhr = 1000156000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR")]
        SamplerYcbcrConversionInfoKhr = 1000156001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR")]
        BindImagePlaneMemoryInfoKhr = 1000156002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR")]
        ImagePlaneMemoryRequirementsInfoKhr = 1000156003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR")]
        PhysicalDeviceSamplerYcbcrConversionFeaturesKhr = 1000156004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR")]
        SamplerYcbcrConversionImageFormatPropertiesKhr = 1000156005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR")]
        BindBufferMemoryInfoKhr = 1000157000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR")]
        BindImageMemoryInfoKhr = 1000157001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT")]
        DrmFormatModifierPropertiesListExt = 1000158000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT")]
        PhysicalDeviceImageDrmFormatModifierInfoExt = 1000158002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT")]
        ImageDrmFormatModifierListCreateInfoExt = 1000158003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT")]
        ImageDrmFormatModifierExplicitCreateInfoExt = 1000158004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT")]
        ImageDrmFormatModifierPropertiesExt = 1000158005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT")]
        DrmFormatModifierPropertiesList2Ext = 1000158006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT")]
        ValidationCacheCreateInfoExt = 1000160000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT")]
        ShaderModuleValidationCacheCreateInfoExt = 1000160001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT")]
        DescriptorSetLayoutBindingFlagsCreateInfoExt = 1000161000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT")]
        PhysicalDeviceDescriptorIndexingFeaturesExt = 1000161001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT")]
        PhysicalDeviceDescriptorIndexingPropertiesExt = 1000161002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT")]
        DescriptorSetVariableDescriptorCountAllocateInfoExt = 1000161003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT")]
        DescriptorSetVariableDescriptorCountLayoutSupportExt = 1000161004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_FEATURES_KHR")]
        PhysicalDevicePortabilitySubsetFeaturesKhr = 1000163000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_PROPERTIES_KHR")]
        PhysicalDevicePortabilitySubsetPropertiesKhr = 1000163001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV")]
        PipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV")]
        PhysicalDeviceShadingRateImageFeaturesNV = 1000164001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV")]
        PhysicalDeviceShadingRateImagePropertiesNV = 1000164002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV")]
        PipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV")]
        RayTracingPipelineCreateInfoNV = 1000165000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV")]
        AccelerationStructureCreateInfoNV = 1000165001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_GEOMETRY_NV")]
        GeometryNV = 1000165003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV")]
        GeometryTrianglesNV = 1000165004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV")]
        GeometryAabbNV = 1000165005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV")]
        BindAccelerationStructureMemoryInfoNV = 1000165006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV")]
        WriteDescriptorSetAccelerationStructureNV = 1000165007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV")]
        AccelerationStructureMemoryRequirementsInfoNV = 1000165008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV")]
        PhysicalDeviceRayTracingPropertiesNV = 1000165009,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV")]
        RayTracingShaderGroupCreateInfoNV = 1000165011,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV")]
        AccelerationStructureInfoNV = 1000165012,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV")]
        PhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV")]
        PipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR")]
        PhysicalDeviceMaintenance3PropertiesKhr = 1000168000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR")]
        DescriptorSetLayoutSupportKhr = 1000168001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT")]
        PhysicalDeviceImageViewImageFormatInfoExt = 1000170000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT")]
        FilterCubicImageViewImageFormatPropertiesExt = 1000170001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT")]
        DeviceQueueGlobalPriorityCreateInfoExt = 1000174000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR")]
        PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKhr = 1000175000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR")]
        PhysicalDevice8BitStorageFeaturesKhr = 1000177000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT")]
        ImportMemoryHostPointerInfoExt = 1000178000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT")]
        MemoryHostPointerPropertiesExt = 1000178001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT")]
        PhysicalDeviceExternalMemoryHostPropertiesExt = 1000178002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR")]
        PhysicalDeviceShaderAtomicInt64FeaturesKhr = 1000180000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR")]
        PhysicalDeviceShaderClockFeaturesKhr = 1000181000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD")]
        PipelineCompilerControlCreateInfoAmd = 1000183000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT")]
        CalibratedTimestampInfoExt = 1000184000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD")]
        PhysicalDeviceShaderCorePropertiesAmd = 1000185000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_EXT")]
        VideoDecodeH265CapabilitiesExt = 1000187000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_CREATE_INFO_EXT")]
        VideoDecodeH265SessionCreateInfoExt = 1000187001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_EXT")]
        VideoDecodeH265SessionParametersCreateInfoExt = 1000187002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_EXT")]
        VideoDecodeH265SessionParametersAddInfoExt = 1000187003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_EXT")]
        VideoDecodeH265ProfileExt = 1000187004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_EXT")]
        VideoDecodeH265PictureInfoExt = 1000187005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_EXT")]
        VideoDecodeH265DpbSlotInfoExt = 1000187006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD")]
        DeviceMemoryOverallocationCreateInfoAmd = 1000189000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT")]
        PhysicalDeviceVertexAttributeDivisorPropertiesExt = 1000190000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT")]
        PipelineVertexInputDivisorStateCreateInfoExt = 1000190001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT")]
        PhysicalDeviceVertexAttributeDivisorFeaturesExt = 1000190002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP")]
        PresentFrameTokenGgp = 1000191000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT")]
        PipelineCreationFeedbackCreateInfoExt = 1000192000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR")]
        PhysicalDeviceDriverPropertiesKhr = 1000196000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR")]
        PhysicalDeviceFloatControlsPropertiesKhr = 1000197000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR")]
        PhysicalDeviceDepthStencilResolvePropertiesKhr = 1000199000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR")]
        SubpassDescriptionDepthStencilResolveKhr = 1000199001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV")]
        PhysicalDeviceComputeShaderDerivativesFeaturesNV = 1000201000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV")]
        PhysicalDeviceMeshShaderFeaturesNV = 1000202000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV")]
        PhysicalDeviceMeshShaderPropertiesNV = 1000202001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV")]
        PhysicalDeviceFragmentShaderBarycentricFeaturesNV = 1000203000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV")]
        PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV")]
        PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV")]
        PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV")]
        CheckpointDataNV = 1000206000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV")]
        QueueFamilyCheckpointPropertiesNV = 1000206001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR")]
        PhysicalDeviceTimelineSemaphoreFeaturesKhr = 1000207000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR")]
        PhysicalDeviceTimelineSemaphorePropertiesKhr = 1000207001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO_KHR")]
        SemaphoreTypeCreateInfoKhr = 1000207002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR")]
        TimelineSemaphoreSubmitInfoKhr = 1000207003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO_KHR")]
        SemaphoreWaitInfoKhr = 1000207004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO_KHR")]
        SemaphoreSignalInfoKhr = 1000207005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL")]
        PhysicalDeviceShaderIntegerFunctions2FeaturesIntel = 1000209000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL")]
        QueryPoolPerformanceQueryCreateInfoIntel = 1000210000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO_INTEL")]
        QueryPoolCreateInfoIntel = 1000210000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL")]
        InitializePerformanceApiInfoIntel = 1000210001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL")]
        PerformanceMarkerInfoIntel = 1000210002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL")]
        PerformanceStreamMarkerInfoIntel = 1000210003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL")]
        PerformanceOverrideInfoIntel = 1000210004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL")]
        PerformanceConfigurationAcquireInfoIntel = 1000210005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR")]
        PhysicalDeviceVulkanMemoryModelFeaturesKhr = 1000211000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT")]
        PhysicalDevicePciBusInfoPropertiesExt = 1000212000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD")]
        DisplayNativeHdrSurfaceCapabilitiesAmd = 1000213000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD")]
        SwapchainDisplayNativeHdrCreateInfoAmd = 1000213001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA")]
        ImagepipeSurfaceCreateInfoFuchsia = 1000214000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR")]
        PhysicalDeviceShaderTerminateInvocationFeaturesKhr = 1000215000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT")]
        MetalSurfaceCreateInfoExt = 1000217000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT")]
        PhysicalDeviceFragmentDensityMapFeaturesExt = 1000218000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT")]
        PhysicalDeviceFragmentDensityMapPropertiesExt = 1000218001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT")]
        RenderPassFragmentDensityMapCreateInfoExt = 1000218002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT")]
        PhysicalDeviceScalarBlockLayoutFeaturesExt = 1000221000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT")]
        PhysicalDeviceSubgroupSizeControlPropertiesExt = 1000225000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT")]
        PipelineShaderStageRequiredSubgroupSizeCreateInfoExt = 1000225001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT")]
        PhysicalDeviceSubgroupSizeControlFeaturesExt = 1000225002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR")]
        FragmentShadingRateAttachmentInfoKhr = 1000226000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR")]
        PipelineFragmentShadingRateStateCreateInfoKhr = 1000226001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR")]
        PhysicalDeviceFragmentShadingRatePropertiesKhr = 1000226002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR")]
        PhysicalDeviceFragmentShadingRateFeaturesKhr = 1000226003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR")]
        PhysicalDeviceFragmentShadingRateKhr = 1000226004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD")]
        PhysicalDeviceShaderCoreProperties2Amd = 1000227000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD")]
        PhysicalDeviceCoherentMemoryFeaturesAmd = 1000229000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT")]
        PhysicalDeviceShaderImageAtomicInt64FeaturesExt = 1000234000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT")]
        PhysicalDeviceMemoryBudgetPropertiesExt = 1000237000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT")]
        PhysicalDeviceMemoryPriorityFeaturesExt = 1000238000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT")]
        MemoryPriorityAllocateInfoExt = 1000238001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR")]
        SurfaceProtectedCapabilitiesKhr = 1000239000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV")]
        PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES_KHR")]
        PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKhr = 1000241000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT_KHR")]
        AttachmentReferenceStencilLayoutKhr = 1000241001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT_KHR")]
        AttachmentDescriptionStencilLayoutKhr = 1000241002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT")]
        PhysicalDeviceBufferDeviceAddressFeaturesExt = 1000244000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT")]
        PhysicalDeviceBufferAddressFeaturesExt = 1000244000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT")]
        BufferDeviceAddressInfoExt = 1000244001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT")]
        BufferDeviceAddressCreateInfoExt = 1000244002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT")]
        PhysicalDeviceToolPropertiesExt = 1000245000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT")]
        ImageStencilUsageCreateInfoExt = 1000246000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT")]
        ValidationFeaturesExt = 1000247000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR")]
        PhysicalDevicePresentWaitFeaturesKhr = 1000248000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV")]
        PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV")]
        CooperativeMatrixPropertiesNV = 1000249001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV")]
        PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV")]
        PhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV")]
        PipelineCoverageReductionStateCreateInfoNV = 1000250001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV")]
        FramebufferMixedSamplesCombinationNV = 1000250002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT")]
        PhysicalDeviceFragmentShaderInterlockFeaturesExt = 1000251000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT")]
        PhysicalDeviceYcbcrImageArraysFeaturesExt = 1000252000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR")]
        PhysicalDeviceUniformBufferStandardLayoutFeaturesKhr = 1000253000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT")]
        PhysicalDeviceProvokingVertexFeaturesExt = 1000254000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT")]
        PipelineRasterizationProvokingVertexStateCreateInfoExt = 1000254001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT")]
        PhysicalDeviceProvokingVertexPropertiesExt = 1000254002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT")]
        SurfaceFullScreenExclusiveInfoExt = 1000255000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT")]
        SurfaceCapabilitiesFullScreenExclusiveExt = 1000255002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT")]
        SurfaceFullScreenExclusiveWin32InfoExt = 1000255001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT")]
        HeadlessSurfaceCreateInfoExt = 1000256000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR")]
        PhysicalDeviceBufferDeviceAddressFeaturesKhr = 1000257000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_KHR")]
        BufferDeviceAddressInfoKhr = 1000244001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR")]
        BufferOpaqueCaptureAddressCreateInfoKhr = 1000257002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR")]
        MemoryOpaqueCaptureAddressAllocateInfoKhr = 1000257003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR")]
        DeviceMemoryOpaqueCaptureAddressInfoKhr = 1000257004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT")]
        PhysicalDeviceLineRasterizationFeaturesExt = 1000259000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT")]
        PipelineRasterizationLineStateCreateInfoExt = 1000259001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT")]
        PhysicalDeviceLineRasterizationPropertiesExt = 1000259002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT")]
        PhysicalDeviceShaderAtomicFloatFeaturesExt = 1000260000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT")]
        PhysicalDeviceHostQueryResetFeaturesExt = 1000261000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT")]
        PhysicalDeviceIndexTypeUint8FeaturesExt = 1000265000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT")]
        PhysicalDeviceExtendedDynamicStateFeaturesExt = 1000267000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR")]
        PhysicalDevicePipelineExecutablePropertiesFeaturesKhr = 1000269000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR")]
        PipelineInfoKhr = 1000269001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR")]
        PipelineExecutablePropertiesKhr = 1000269002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR")]
        PipelineExecutableInfoKhr = 1000269003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR")]
        PipelineExecutableStatisticKhr = 1000269004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR")]
        PipelineExecutableInternalRepresentationKhr = 1000269005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT")]
        PhysicalDeviceShaderAtomicFloat2FeaturesExt = 1000273000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT")]
        PhysicalDeviceShaderDemoteToHelperInvocationFeaturesExt = 1000276000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV")]
        PhysicalDeviceDeviceGeneratedCommandsPropertiesNV = 1000277000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV")]
        GraphicsShaderGroupCreateInfoNV = 1000277001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV")]
        GraphicsPipelineShaderGroupsCreateInfoNV = 1000277002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV")]
        IndirectCommandsLayoutTokenNV = 1000277003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV")]
        IndirectCommandsLayoutCreateInfoNV = 1000277004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV")]
        GeneratedCommandsInfoNV = 1000277005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV")]
        GeneratedCommandsMemoryRequirementsInfoNV = 1000277006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV")]
        PhysicalDeviceDeviceGeneratedCommandsFeaturesNV = 1000277007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV")]
        PhysicalDeviceInheritedViewportScissorFeaturesNV = 1000278000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV")]
        CommandBufferInheritanceViewportScissorInfoNV = 1000278001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES_KHR")]
        PhysicalDeviceShaderIntegerDotProductFeaturesKhr = 1000280000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES_KHR")]
        PhysicalDeviceShaderIntegerDotProductPropertiesKhr = 1000280001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT")]
        PhysicalDeviceTexelBufferAlignmentFeaturesExt = 1000281000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT")]
        PhysicalDeviceTexelBufferAlignmentPropertiesExt = 1000281001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM")]
        CommandBufferInheritanceRenderPassTransformInfoQCom = 1000282000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM")]
        RenderPassTransformBeginInfoQCom = 1000282001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT")]
        PhysicalDeviceDeviceMemoryReportFeaturesExt = 1000284000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT")]
        DeviceDeviceMemoryReportCreateInfoExt = 1000284001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT")]
        DeviceMemoryReportCallbackDataExt = 1000284002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT")]
        PhysicalDeviceRobustness2FeaturesExt = 1000286000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT")]
        PhysicalDeviceRobustness2PropertiesExt = 1000286001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT")]
        SamplerCustomBorderColorCreateInfoExt = 1000287000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT")]
        PhysicalDeviceCustomBorderColorPropertiesExt = 1000287001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT")]
        PhysicalDeviceCustomBorderColorFeaturesExt = 1000287002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR")]
        PipelineLibraryCreateInfoKhr = 1000290000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PRESENT_ID_KHR")]
        PresentIDKhr = 1000294000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR")]
        PhysicalDevicePresentIDFeaturesKhr = 1000294001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT")]
        PhysicalDevicePrivateDataFeaturesExt = 1000295000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT")]
        DevicePrivateDataCreateInfoExt = 1000295001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT")]
        PrivateDataSlotCreateInfoExt = 1000295002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT")]
        PhysicalDevicePipelineCreationCacheControlFeaturesExt = 1000297000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR")]
        VideoEncodeInfoKhr = 1000299000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR")]
        VideoEncodeRateControlInfoKhr = 1000299001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR")]
        VideoEncodeRateControlLayerInfoKhr = 1000299002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV")]
        PhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV")]
        DeviceDiagnosticsConfigCreateInfoNV = 1000300001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RESERVED_QCOM")]
        ReservedQCom = 1000309000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_BARRIER_2_KHR")]
        MemoryBarrier2Khr = 1000314000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2_KHR")]
        BufferMemoryBarrier2Khr = 1000314001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2_KHR")]
        ImageMemoryBarrier2Khr = 1000314002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR")]
        DependencyInfoKhr = 1000314003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBMIT_INFO_2_KHR")]
        SubmitInfo2Khr = 1000314004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR")]
        SemaphoreSubmitInfoKhr = 1000314005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR")]
        CommandBufferSubmitInfoKhr = 1000314006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR")]
        PhysicalDeviceSynchronization2FeaturesKhr = 1000314007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV")]
        QueueFamilyCheckpointProperties2NV = 1000314008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV")]
        CheckpointData2NV = 1000314009,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR")]
        PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKhr = 1000323000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR")]
        PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKhr = 1000325000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV")]
        PhysicalDeviceFragmentShadingRateEnumsPropertiesNV = 1000326000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV")]
        PhysicalDeviceFragmentShadingRateEnumsFeaturesNV = 1000326001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV")]
        PipelineFragmentShadingRateEnumStateCreateInfoNV = 1000326002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV")]
        AccelerationStructureGeometryMotionTrianglesDataNV = 1000327000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV")]
        PhysicalDeviceRayTracingMotionBlurFeaturesNV = 1000327001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV")]
        AccelerationStructureMotionInfoNV = 1000327002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT")]
        PhysicalDeviceYcbcr2Plane444FormatsFeaturesExt = 1000330000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT")]
        PhysicalDeviceFragmentDensityMap2FeaturesExt = 1000332000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT")]
        PhysicalDeviceFragmentDensityMap2PropertiesExt = 1000332001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM")]
        CopyCommandTransformInfoQCom = 1000333000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT")]
        PhysicalDeviceImageRobustnessFeaturesExt = 1000335000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR")]
        PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr = 1000336000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR")]
        CopyBufferInfo2Khr = 1000337000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR")]
        CopyImageInfo2Khr = 1000337001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR")]
        CopyBufferToImageInfo2Khr = 1000337002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR")]
        CopyImageToBufferInfo2Khr = 1000337003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR")]
        BlitImageInfo2Khr = 1000337004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR")]
        ResolveImageInfo2Khr = 1000337005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR")]
        BufferCopy2Khr = 1000337006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR")]
        ImageCopy2Khr = 1000337007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR")]
        ImageBlit2Khr = 1000337008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR")]
        BufferImageCopy2Khr = 1000337009,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR")]
        ImageResolve2Khr = 1000337010,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT")]
        PhysicalDevice4444FormatsFeaturesExt = 1000340000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_ARM")]
        PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesArm = 1000342000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT")]
        PhysicalDeviceRgba10X6FormatsFeaturesExt = 1000344000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT")]
        DirectfbSurfaceCreateInfoExt = 1000346000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE")]
        PhysicalDeviceMutableDescriptorTypeFeaturesValve = 1000351000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE")]
        MutableDescriptorTypeCreateInfoValve = 1000351002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT")]
        PhysicalDeviceVertexInputDynamicStateFeaturesExt = 1000352000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT")]
        VertexInputBindingDescription2Ext = 1000352001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT")]
        VertexInputAttributeDescription2Ext = 1000352002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT")]
        PhysicalDeviceDrmPropertiesExt = 1000353000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT")]
        PhysicalDeviceDepthClipControlFeaturesExt = 1000355000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT")]
        PipelineViewportDepthClipControlCreateInfoExt = 1000355001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT")]
        PhysicalDevicePrimitiveTopologyListRestartFeaturesExt = 1000356000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3_KHR")]
        FormatProperties3Khr = 1000360000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA")]
        ImportMemoryZirconHandleInfoFuchsia = 1000364000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA")]
        MemoryZirconHandlePropertiesFuchsia = 1000364001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA")]
        MemoryGetZirconHandleInfoFuchsia = 1000364002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA")]
        ImportSemaphoreZirconHandleInfoFuchsia = 1000365000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA")]
        SemaphoreGetZirconHandleInfoFuchsia = 1000365001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA")]
        BufferCollectionCreateInfoFuchsia = 1000366000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA")]
        ImportMemoryBufferCollectionFuchsia = 1000366001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA")]
        BufferCollectionImageCreateInfoFuchsia = 1000366002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA")]
        BufferCollectionPropertiesFuchsia = 1000366003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA")]
        BufferConstraintsInfoFuchsia = 1000366004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA")]
        BufferCollectionBufferCreateInfoFuchsia = 1000366005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA")]
        ImageConstraintsInfoFuchsia = 1000366006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA")]
        ImageFormatConstraintsInfoFuchsia = 1000366007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA")]
        SysmemColorSpaceFuchsia = 1000366008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA")]
        BufferCollectionConstraintsInfoFuchsia = 1000366009,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI")]
        SubpassShadingPipelineCreateInfoHuawei = 1000369000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI")]
        PhysicalDeviceSubpassShadingFeaturesHuawei = 1000369001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI")]
        PhysicalDeviceSubpassShadingPropertiesHuawei = 1000369002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI")]
        PhysicalDeviceInvocationMaskFeaturesHuawei = 1000370000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV")]
        MemoryGetRemoteAddressInfoNV = 1000371000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV")]
        PhysicalDeviceExternalMemoryRdmaFeaturesNV = 1000371001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT")]
        PhysicalDeviceExtendedDynamicState2FeaturesExt = 1000377000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX")]
        ScreenSurfaceCreateInfoQnx = 1000378000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT")]
        PhysicalDeviceColorWriteEnableFeaturesExt = 1000381000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT")]
        PipelineColorWriteCreateInfoExt = 1000381001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT")]
        PhysicalDeviceGlobalPriorityQueryFeaturesExt = 1000388000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT")]
        QueueFamilyGlobalPriorityPropertiesExt = 1000388001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT")]
        PhysicalDeviceImageViewMinLodFeaturesExt = 1000391000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT")]
        ImageViewMinLodCreateInfoExt = 1000391001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT")]
        PhysicalDeviceMultiDrawFeaturesExt = 1000392000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT")]
        PhysicalDeviceMultiDrawPropertiesExt = 1000392001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT")]
        PhysicalDeviceBorderColorSwizzleFeaturesExt = 1000411000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT")]
        SamplerBorderColorComponentMappingCreateInfoExt = 1000411001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT")]
        PhysicalDevicePageableDeviceLocalMemoryFeaturesExt = 1000412000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES_KHR")]
        PhysicalDeviceMaintenance4FeaturesKhr = 1000413000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES_KHR")]
        PhysicalDeviceMaintenance4PropertiesKhr = 1000413001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS_KHR")]
        DeviceBufferMemoryRequirementsKhr = 1000413002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS_KHR")]
        DeviceImageMemoryRequirementsKhr = 1000413003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES")]
        PhysicalDeviceSubgroupProperties = 1000094000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO")]
        BindBufferMemoryInfo = 1000157000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO")]
        BindImageMemoryInfo = 1000157001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES")]
        PhysicalDevice16BitStorageFeatures = 1000083000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS")]
        MemoryDedicatedRequirements = 1000127000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO")]
        MemoryDedicatedAllocateInfo = 1000127001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO")]
        MemoryAllocateFlagsInfo = 1000060000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO")]
        DeviceGroupRenderPassBeginInfo = 1000060003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO")]
        DeviceGroupCommandBufferBeginInfo = 1000060004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO")]
        DeviceGroupSubmitInfo = 1000060005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO")]
        DeviceGroupBindSparseInfo = 1000060006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO")]
        BindBufferMemoryDeviceGroupInfo = 1000060013,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO")]
        BindImageMemoryDeviceGroupInfo = 1000060014,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES")]
        PhysicalDeviceGroupProperties = 1000070000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO")]
        DeviceGroupDeviceCreateInfo = 1000070001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2")]
        BufferMemoryRequirementsInfo2 = 1000146000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2")]
        ImageMemoryRequirementsInfo2 = 1000146001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2")]
        ImageSparseMemoryRequirementsInfo2 = 1000146002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2")]
        MemoryRequirements2 = 1000146003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2")]
        SparseImageMemoryRequirements2 = 1000146004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2")]
        PhysicalDeviceFeatures2 = 1000059000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2")]
        PhysicalDeviceProperties2 = 1000059001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2")]
        FormatProperties2 = 1000059002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2")]
        ImageFormatProperties2 = 1000059003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2")]
        PhysicalDeviceImageFormatInfo2 = 1000059004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2")]
        QueueFamilyProperties2 = 1000059005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2")]
        PhysicalDeviceMemoryProperties2 = 1000059006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2")]
        SparseImageFormatProperties2 = 1000059007,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2")]
        PhysicalDeviceSparseImageFormatInfo2 = 1000059008,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES")]
        PhysicalDevicePointClippingProperties = 1000117000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO")]
        RenderPassInputAttachmentAspectCreateInfo = 1000117001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO")]
        ImageViewUsageCreateInfo = 1000117002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO")]
        PipelineTessellationDomainOriginStateCreateInfo = 1000117003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO")]
        RenderPassMultiviewCreateInfo = 1000053000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES")]
        PhysicalDeviceMultiviewFeatures = 1000053001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES")]
        PhysicalDeviceMultiviewProperties = 1000053002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES")]
        PhysicalDeviceVariablePointersFeatures = 1000120000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES")]
        PhysicalDeviceVariablePointerFeatures = 1000120000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO")]
        ProtectedSubmitInfo = 1000145000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES")]
        PhysicalDeviceProtectedMemoryFeatures = 1000145001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES")]
        PhysicalDeviceProtectedMemoryProperties = 1000145002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2")]
        DeviceQueueInfo2 = 1000145003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO")]
        SamplerYcbcrConversionCreateInfo = 1000156000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO")]
        SamplerYcbcrConversionInfo = 1000156001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO")]
        BindImagePlaneMemoryInfo = 1000156002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO")]
        ImagePlaneMemoryRequirementsInfo = 1000156003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES")]
        PhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES")]
        SamplerYcbcrConversionImageFormatProperties = 1000156005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO")]
        DescriptorUpdateTemplateCreateInfo = 1000085000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO")]
        PhysicalDeviceExternalImageFormatInfo = 1000071000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES")]
        ExternalImageFormatProperties = 1000071001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO")]
        PhysicalDeviceExternalBufferInfo = 1000071002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES")]
        ExternalBufferProperties = 1000071003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES")]
        PhysicalDeviceIDProperties = 1000071004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO")]
        ExternalMemoryBufferCreateInfo = 1000072000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO")]
        ExternalMemoryImageCreateInfo = 1000072001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO")]
        ExportMemoryAllocateInfo = 1000072002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO")]
        PhysicalDeviceExternalFenceInfo = 1000112000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES")]
        ExternalFenceProperties = 1000112001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO")]
        ExportFenceCreateInfo = 1000113000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO")]
        ExportSemaphoreCreateInfo = 1000077000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO")]
        PhysicalDeviceExternalSemaphoreInfo = 1000076000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES")]
        ExternalSemaphoreProperties = 1000076001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES")]
        PhysicalDeviceMaintenance3Properties = 1000168000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT")]
        DescriptorSetLayoutSupport = 1000168001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES")]
        PhysicalDeviceShaderDrawParametersFeatures = 1000063000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETER_FEATURES")]
        PhysicalDeviceShaderDrawParameterFeatures = 1000063000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_FEATURES")]
        PhysicalDeviceVulkan11Features = 49,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES")]
        PhysicalDeviceVulkan11Properties = 50,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES")]
        PhysicalDeviceVulkan12Features = 51,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES")]
        PhysicalDeviceVulkan12Properties = 52,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO")]
        ImageFormatListCreateInfo = 1000147000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2")]
        AttachmentDescription2 = 1000109000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2")]
        AttachmentReference2 = 1000109001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2")]
        SubpassDescription2 = 1000109002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2")]
        SubpassDependency2 = 1000109003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2")]
        RenderPassCreateInfo2 = 1000109004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO")]
        SubpassBeginInfo = 1000109005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_END_INFO")]
        SubpassEndInfo = 1000109006,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES")]
        PhysicalDevice8BitStorageFeatures = 1000177000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES")]
        PhysicalDeviceDriverProperties = 1000196000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES")]
        PhysicalDeviceShaderAtomicInt64Features = 1000180000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES")]
        PhysicalDeviceShaderFloat16Int8Features = 1000082000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES")]
        PhysicalDeviceFloatControlsProperties = 1000197000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO")]
        DescriptorSetLayoutBindingFlagsCreateInfo = 1000161000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES")]
        PhysicalDeviceDescriptorIndexingFeatures = 1000161001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES")]
        PhysicalDeviceDescriptorIndexingProperties = 1000161002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO")]
        DescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT")]
        DescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES")]
        PhysicalDeviceDepthStencilResolveProperties = 1000199000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE")]
        SubpassDescriptionDepthStencilResolve = 1000199001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES")]
        PhysicalDeviceScalarBlockLayoutFeatures = 1000221000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO")]
        ImageStencilUsageCreateInfo = 1000246000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES")]
        PhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO")]
        SamplerReductionModeCreateInfo = 1000130001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES")]
        PhysicalDeviceVulkanMemoryModelFeatures = 1000211000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES")]
        PhysicalDeviceImagelessFramebufferFeatures = 1000108000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO")]
        FramebufferAttachmentsCreateInfo = 1000108001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO")]
        FramebufferAttachmentImageInfo = 1000108002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO")]
        RenderPassAttachmentBeginInfo = 1000108003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES")]
        PhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES")]
        PhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES")]
        PhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT")]
        AttachmentReferenceStencilLayout = 1000241001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT")]
        AttachmentDescriptionStencilLayout = 1000241002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES")]
        PhysicalDeviceHostQueryResetFeatures = 1000261000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES")]
        PhysicalDeviceTimelineSemaphoreFeatures = 1000207000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES")]
        PhysicalDeviceTimelineSemaphoreProperties = 1000207001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO")]
        SemaphoreTypeCreateInfo = 1000207002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO")]
        TimelineSemaphoreSubmitInfo = 1000207003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO")]
        SemaphoreWaitInfo = 1000207004,
        [NativeName("Name", "VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO")]
        SemaphoreSignalInfo = 1000207005,
        [NativeName("Name", "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES")]
        PhysicalDeviceBufferDeviceAddressFeatures = 1000257000,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO")]
        BufferDeviceAddressInfo = 1000244001,
        [NativeName("Name", "VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO")]
        BufferOpaqueCaptureAddressCreateInfo = 1000257002,
        [NativeName("Name", "VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO")]
        MemoryOpaqueCaptureAddressAllocateInfo = 1000257003,
        [NativeName("Name", "VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO")]
        DeviceMemoryOpaqueCaptureAddressInfo = 1000257004,
    }
}
