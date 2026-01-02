// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum DebugReportObjectTypeEXT : uint
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    UnknownEXT = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    InstanceEXT = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PhysicalDeviceEXT = 2,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DeviceEXT = 3,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    QueueEXT = 4,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    SemaphoreEXT = 5,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    CommandBufferEXT = 6,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    FenceEXT = 7,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DeviceMemoryEXT = 8,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    BufferEXT = 9,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ImageEXT = 10,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    EventEXT = 11,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    QueryPoolEXT = 12,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    BufferViewEXT = 13,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ImageViewEXT = 14,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ShaderModuleEXT = 15,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PipelineCacheEXT = 16,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PipelineLayoutEXT = 17,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    RenderPassEXT = 18,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PipelineEXT = 19,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DescriptorSetLayoutEXT = 20,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    SamplerEXT = 21,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DescriptorPoolEXT = 22,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DescriptorSetEXT = 23,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    FramebufferEXT = 24,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    CommandPoolEXT = 25,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    SurfaceKhrEXT = 26,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    SwapchainKhrEXT = 27,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DebugReportCallbackExtEXT = 28,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DisplayKhrEXT = 29,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DisplayModeKhrEXT = 30,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ValidationCacheExtEXT = 33,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    SamplerYcbcrConversionEXT = 1000156000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    DescriptorUpdateTemplateEXT = 1000085000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    CuModuleNvxEXT = 1000029000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    CuFunctionNvxEXT = 1000029001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ],
        RequireAll = true
    )]
    AccelerationStructureKhrEXT = 1000150000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    AccelerationStructureNvEXT = 1000165000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_cuda_kernel_launch"],
        ImpliesSets = [
            "VK_NV_cuda_kernel_launch+VK_KHR_get_physical_device_properties2",
            "VK_NV_cuda_kernel_launch+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CudaModuleNvEXT = 1000307000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_cuda_kernel_launch"],
        ImpliesSets = [
            "VK_NV_cuda_kernel_launch+VK_KHR_get_physical_device_properties2",
            "VK_NV_cuda_kernel_launch+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CudaFunctionNvEXT = 1000307001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    BufferCollectionFuchsiaEXT = 1000366000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_descriptor_update_template"],
        RequireAll = true
    )]
    DescriptorUpdateTemplateKhrEXT = DescriptorUpdateTemplateEXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    SamplerYcbcrConversionKhrEXT = SamplerYcbcrConversionEXT,
}
