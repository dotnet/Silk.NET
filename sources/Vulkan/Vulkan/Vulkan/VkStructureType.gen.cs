// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkStructureType")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkStructureType : uint
{
    [NativeName("VK_STRUCTURE_TYPE_APPLICATION_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeApplicationInfo = 0,

    [NativeName("VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeInstanceCreateInfo = 1,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeDeviceQueueCreateInfo = 2,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeDeviceCreateInfo = 3,

    [NativeName("VK_STRUCTURE_TYPE_SUBMIT_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeSubmitInfo = 4,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeMemoryAllocateInfo = 5,

    [NativeName("VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeMappedMemoryRange = 6,

    [NativeName("VK_STRUCTURE_TYPE_BIND_SPARSE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeBindSparseInfo = 7,

    [NativeName("VK_STRUCTURE_TYPE_FENCE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeFenceCreateInfo = 8,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeSemaphoreCreateInfo = 9,

    [NativeName("VK_STRUCTURE_TYPE_EVENT_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeEventCreateInfo = 10,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeQueryPoolCreateInfo = 11,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeBufferCreateInfo = 12,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeBufferViewCreateInfo = 13,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeImageCreateInfo = 14,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeImageViewCreateInfo = 15,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeShaderModuleCreateInfo = 16,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineCacheCreateInfo = 17,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineShaderStageCreateInfo = 18,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineVertexInputStateCreateInfo = 19,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineInputAssemblyStateCreateInfo = 20,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineTessellationStateCreateInfo = 21,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineViewportStateCreateInfo = 22,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineRasterizationStateCreateInfo = 23,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineMultisampleStateCreateInfo = 24,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineDepthStencilStateCreateInfo = 25,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineColorBlendStateCreateInfo = 26,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineDynamicStateCreateInfo = 27,

    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeGraphicsPipelineCreateInfo = 28,

    [NativeName("VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeComputePipelineCreateInfo = 29,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypePipelineLayoutCreateInfo = 30,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeSamplerCreateInfo = 31,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeDescriptorSetLayoutCreateInfo = 32,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeDescriptorPoolCreateInfo = 33,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeDescriptorSetAllocateInfo = 34,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeWriteDescriptorSet = 35,

    [NativeName("VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeCopyDescriptorSet = 36,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeFramebufferCreateInfo = 37,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeRenderPassCreateInfo = 38,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeCommandPoolCreateInfo = 39,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeCommandBufferAllocateInfo = 40,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeCommandBufferInheritanceInfo = 41,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeCommandBufferBeginInfo = 42,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeRenderPassBeginInfo = 43,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeBufferMemoryBarrier = 44,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeImageMemoryBarrier = 45,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeMemoryBarrier = 46,

    [NativeName("VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeLoaderInstanceCreateInfo = 47,

    [NativeName("VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeLoaderDeviceCreateInfo = 48,

    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeBindBufferMemoryInfo = 1000157000,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeBindImageMemoryInfo = 1000157001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeMemoryDedicatedRequirements = 1000127000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeMemoryDedicatedAllocateInfo = 1000127001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeMemoryAllocateFlagsInfo = 1000060000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeDeviceGroupCommandBufferBeginInfo = 1000060004,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeDeviceGroupSubmitInfo = 1000060005,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeDeviceGroupBindSparseInfo = 1000060006,

    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeBindBufferMemoryDeviceGroupInfo = 1000060013,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeBindImageMemoryDeviceGroupInfo = 1000060014,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceGroupProperties = 1000070000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeDeviceGroupDeviceCreateInfo = 1000070001,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeBufferMemoryRequirementsInfo2 = 1000146000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeImageMemoryRequirementsInfo2 = 1000146001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeImageSparseMemoryRequirementsInfo2 = 1000146002,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeMemoryRequirements2 = 1000146003,

    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeSparseImageMemoryRequirements2 = 1000146004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceFeatures2 = 1000059000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceProperties2 = 1000059001,

    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeFormatProperties2 = 1000059002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeImageFormatProperties2 = 1000059003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceImageFormatInfo2 = 1000059004,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeQueueFamilyProperties2 = 1000059005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceMemoryProperties2 = 1000059006,

    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeSparseImageFormatProperties2 = 1000059007,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceSparseImageFormatInfo2 = 1000059008,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeImageViewUsageCreateInfo = 1000117002,

    [NativeName("VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeProtectedSubmitInfo = 1000145000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceProtectedMemoryFeatures = 1000145001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceProtectedMemoryProperties = 1000145002,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeDeviceQueueInfo2 = 1000145003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceExternalImageFormatInfo = 1000071000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeExternalImageFormatProperties = 1000071001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceExternalBufferInfo = 1000071002,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeExternalBufferProperties = 1000071003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceIdProperties = 1000071004,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeExternalMemoryBufferCreateInfo = 1000072000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeExternalMemoryImageCreateInfo = 1000072001,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeExportMemoryAllocateInfo = 1000072002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceExternalFenceInfo = 1000112000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeExternalFenceProperties = 1000112001,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeExportFenceCreateInfo = 1000113000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeExportSemaphoreCreateInfo = 1000077000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceExternalSemaphoreInfo = 1000076000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeExternalSemaphoreProperties = 1000076001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceSubgroupProperties = 1000094000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDevice16BitStorageFeatures = 1000083000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceVariablePointersFeatures = 1000120000,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeDescriptorUpdateTemplateCreateInfo = 1000085000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceMaintenance3Properties = 1000168000,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeDescriptorSetLayoutSupport = 1000168001,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeSamplerYcbcrConversionCreateInfo = 1000156000,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeSamplerYcbcrConversionInfo = 1000156001,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeBindImagePlaneMemoryInfo = 1000156002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeImagePlaneMemoryRequirementsInfo = 1000156003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeSamplerYcbcrConversionImageFormatProperties = 1000156005,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeDeviceGroupRenderPassBeginInfo = 1000060003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDevicePointClippingProperties = 1000117000,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeRenderPassInputAttachmentAspectCreateInfo = 1000117001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePipelineTessellationDomainOriginStateCreateInfo = 1000117003,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypeRenderPassMultiviewCreateInfo = 1000053000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceMultiviewFeatures = 1000053001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceMultiviewProperties = 1000053002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceShaderDrawParametersFeatures = 1000063000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceVulkan1x1Features = 49,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceVulkan1x1Properties = 50,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceVulkan1x2Features = 51,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceVulkan1x2Properties = 52,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeImageFormatListCreateInfo = 1000147000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceDriverProperties = 1000196000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceVulkanMemoryModelFeatures = 1000211000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceHostQueryResetFeatures = 1000261000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceTimelineSemaphoreFeatures = 1000207000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceTimelineSemaphoreProperties = 1000207001,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeSemaphoreTypeCreateInfo = 1000207002,

    [NativeName("VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeTimelineSemaphoreSubmitInfo = 1000207003,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeSemaphoreWaitInfo = 1000207004,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeSemaphoreSignalInfo = 1000207005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceBufferDeviceAddressFeatures = 1000257000,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeBufferDeviceAddressInfo = 1000244001,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeBufferOpaqueCaptureAddressCreateInfo = 1000257002,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeMemoryOpaqueCaptureAddressAllocateInfo = 1000257003,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeDeviceMemoryOpaqueCaptureAddressInfo = 1000257004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDevice8BitStorageFeatures = 1000177000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceShaderAtomicInt64Features = 1000180000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceShaderFloat16Int8Features = 1000082000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceFloatControlsProperties = 1000197000,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeDescriptorSetLayoutBindingFlagsCreateInfo = 1000161000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceDescriptorIndexingFeatures = 1000161001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceDescriptorIndexingProperties = 1000161002,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeDescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeDescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceScalarBlockLayoutFeatures = 1000221000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeSamplerReductionModeCreateInfo = 1000130001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeAttachmentDescription2 = 1000109000,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeAttachmentReference2 = 1000109001,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeSubpassDescription2 = 1000109002,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeSubpassDependency2 = 1000109003,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeRenderPassCreateInfo2 = 1000109004,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeSubpassBeginInfo = 1000109005,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_END_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeSubpassEndInfo = 1000109006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceDepthStencilResolveProperties = 1000199000,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeSubpassDescriptionDepthStencilResolve = 1000199001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeImageStencilUsageCreateInfo = 1000246000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceImagelessFramebufferFeatures = 1000108000,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeFramebufferAttachmentsCreateInfo = 1000108001,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeFramebufferAttachmentImageInfo = 1000108002,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeRenderPassAttachmentBeginInfo = 1000108003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeAttachmentReferenceStencilLayout = 1000241001,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    VkStructureTypeAttachmentDescriptionStencilLayout = 1000241002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceVulkan1x3Features = 53,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceVulkan1x3Properties = 54,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceToolProperties = 1000245000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDevicePrivateDataFeatures = 1000295000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeDevicePrivateDataCreateInfo = 1000295001,

    [NativeName("VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePrivateDataSlotCreateInfo = 1000295002,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeMemoryBarrier2 = 1000314000,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeBufferMemoryBarrier2 = 1000314001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeImageMemoryBarrier2 = 1000314002,

    [NativeName("VK_STRUCTURE_TYPE_DEPENDENCY_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeDependencyInfo = 1000314003,

    [NativeName("VK_STRUCTURE_TYPE_SUBMIT_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeSubmitInfo2 = 1000314004,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeSemaphoreSubmitInfo = 1000314005,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeCommandBufferSubmitInfo = 1000314006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceSynchronization2Features = 1000314007,

    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeCopyBufferInfo2 = 1000337000,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeCopyImageInfo2 = 1000337001,

    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeCopyBufferToImageInfo2 = 1000337002,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeCopyImageToBufferInfo2 = 1000337003,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COPY_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeBufferCopy2 = 1000337006,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COPY_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeImageCopy2 = 1000337007,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeBufferImageCopy2 = 1000337009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceTextureCompressionAstcHdrFeatures = 1000066000,

    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeFormatProperties3 = 1000360000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceMaintenance4Features = 1000413000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceMaintenance4Properties = 1000413001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeDeviceBufferMemoryRequirements = 1000413002,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeDeviceImageMemoryRequirements = 1000413003,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePipelineCreationFeedbackCreateInfo = 1000192000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceShaderTerminateInvocationFeatures = 1000215000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceShaderDemoteToHelperInvocationFeatures = 1000276000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDevicePipelineCreationCacheControlFeatures = 1000297000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceZeroInitializeWorkgroupMemoryFeatures = 1000325000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceImageRobustnessFeatures = 1000335000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceSubgroupSizeControlProperties = 1000225000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePipelineShaderStageRequiredSubgroupSizeCreateInfo = 1000225001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceSubgroupSizeControlFeatures = 1000225002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceInlineUniformBlockFeatures = 1000138000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceInlineUniformBlockProperties = 1000138001,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeWriteDescriptorSetInlineUniformBlock = 1000138002,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypeDescriptorPoolInlineUniformBlockCreateInfo = 1000138003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceShaderIntegerDotProductFeatures = 1000280000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceShaderIntegerDotProductProperties = 1000280001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceTexelBufferAlignmentProperties = 1000281001,

    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkStructureTypeBlitImageInfo2 = 1000337004,

    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkStructureTypeResolveImageInfo2 = 1000337005,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_BLIT_2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkStructureTypeImageBlit2 = 1000337008,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkStructureTypeImageResolve2 = 1000337010,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkStructureTypeRenderingInfo = 1000044000,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkStructureTypeRenderingAttachmentInfo = 1000044001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkStructureTypePipelineRenderingCreateInfo = 1000044002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkStructureTypePhysicalDeviceDynamicRenderingFeatures = 1000044003,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkStructureTypeCommandBufferInheritanceRenderingInfo = 1000044004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_4_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceVulkan1x4Features = 55,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_4_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceVulkan1x4Properties = 56,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeDeviceQueueGlobalPriorityCreateInfo = 1000174000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceGlobalPriorityQueryFeatures = 1000388000,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeQueueFamilyGlobalPriorityProperties = 1000388001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceIndexTypeUint8Features = 1000265000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MAP_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeMemoryMapInfo = 1000271000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeMemoryUnmapInfo = 1000271001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceMaintenance5Features = 1000470000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceMaintenance5Properties = 1000470001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeDeviceImageSubresourceInfo = 1000470004,

    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeSubresourceLayout2 = 1000338002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeImageSubresource2 = 1000338003,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeBufferUsageFlags2CreateInfo = 1000470006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceMaintenance6Features = 1000545000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceMaintenance6Properties = 1000545001,

    [NativeName("VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeBindMemoryStatus = 1000545002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceHostImageCopyFeatures = 1000270000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceHostImageCopyProperties = 1000270001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeMemoryToImageCopy = 1000270002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeImageToMemoryCopy = 1000270003,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeCopyImageToMemoryInfo = 1000270004,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeCopyMemoryToImageInfo = 1000270005,

    [NativeName("VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeHostImageLayoutTransitionInfo = 1000270006,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeCopyImageToImageInfo = 1000270007,

    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeSubresourceHostMemcpySize = 1000270008,

    [NativeName("VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkStructureTypeHostImageCopyDevicePerformanceQuery = 1000270009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceShaderSubgroupRotateFeatures = 1000416000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceShaderFloatControls2Features = 1000528000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceShaderExpectAssumeFeatures = 1000544000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePipelineCreateFlags2CreateInfo = 1000470005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDevicePushDescriptorProperties = 1000080000,

    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypeBindDescriptorSetsInfo = 1000545003,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePushConstantsInfo = 1000545004,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePushDescriptorSetInfo = 1000545005,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePushDescriptorSetWithTemplateInfo = 1000545006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDevicePipelineProtectedAccessFeatures = 1000466000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePipelineRobustnessCreateInfo = 1000068000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDevicePipelineRobustnessFeatures = 1000068001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDevicePipelineRobustnessProperties = 1000068002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceLineRasterizationFeatures = 1000259000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePipelineRasterizationLineStateCreateInfo = 1000259001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceLineRasterizationProperties = 1000259002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceVertexAttributeDivisorProperties = 1000525000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePipelineVertexInputDivisorStateCreateInfo = 1000190001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceVertexAttributeDivisorFeatures = 1000190002,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_AREA_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypeRenderingAreaInfo = 1000470003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypePhysicalDeviceDynamicRenderingLocalReadFeatures = 1000232000,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypeRenderingAttachmentLocationInfo = 1000232001,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkStructureTypeRenderingInputAttachmentIndexInfo = 1000232002,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeSwapchainCreateInfoKHR = 1000001000,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypePresentInfoKHR = 1000001001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VkStructureTypeDeviceGroupPresentCapabilitiesKHR = 1000060007,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VkStructureTypeImageSwapchainCreateInfoKHR = 1000060008,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VkStructureTypeBindImageMemorySwapchainInfoKHR = 1000060009,

    [NativeName("VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VkStructureTypeAcquireNextImageInfoKHR = 1000060010,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VkStructureTypeDeviceGroupPresentInfoKHR = 1000060011,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VkStructureTypeDeviceGroupSwapchainCreateInfoKHR = 1000060012,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeDisplayModeCreateInfoKHR = 1000002000,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeDisplaySurfaceCreateInfoKHR = 1000002001,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_display_swapchain"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_swapchain"]
    )]
    VkStructureTypeDisplayPresentInfoKHR = 1000003000,

    [NativeName("VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xlib_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeXlibSurfaceCreateInfoKHR = 1000004000,

    [NativeName("VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xcb_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeXcbSurfaceCreateInfoKHR = 1000005000,

    [NativeName("VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_wayland_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeWaylandSurfaceCreateInfoKHR = 1000006000,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_android_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeAndroidSurfaceCreateInfoKHR = 1000008000,

    [NativeName("VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_win32_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeWin32SurfaceCreateInfoKHR = 1000009000,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkStructureTypeDebugReportCallbackCreateInfoEXT = 1000011000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_rasterization_order"])]
    VkStructureTypePipelineRasterizationStateRasterizationOrderAMD = 1000018000,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    VkStructureTypeDebugMarkerObjectNameInfoEXT = 1000022000,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    VkStructureTypeDebugMarkerObjectTagInfoEXT = 1000022001,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    VkStructureTypeDebugMarkerMarkerInfoEXT = 1000022002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoProfileInfoKHR = 1000023000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoCapabilitiesKHR = 1000023001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoPictureResourceInfoKHR = 1000023002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoSessionMemoryRequirementsKHR = 1000023003,

    [NativeName("VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeBindVideoSessionMemoryInfoKHR = 1000023004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoSessionCreateInfoKHR = 1000023005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoSessionParametersCreateInfoKHR = 1000023006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoSessionParametersUpdateInfoKHR = 1000023007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoBeginCodingInfoKHR = 1000023008,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoEndCodingInfoKHR = 1000023009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoCodingControlInfoKHR = 1000023010,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoReferenceSlotInfoKHR = 1000023011,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeQueueFamilyVideoPropertiesKHR = 1000023012,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoProfileListInfoKHR = 1000023013,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypePhysicalDeviceVideoFormatInfoKHR = 1000023014,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeVideoFormatPropertiesKHR = 1000023015,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VkStructureTypeQueueFamilyQueryResultStatusPropertiesKHR = 1000023016,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoDecodeInfoKHR = 1000024000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoDecodeCapabilitiesKHR = 1000024001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoDecodeUsageInfoKHR = 1000024002,

    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    VkStructureTypeDedicatedAllocationImageCreateInfoNV = 1000026000,

    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    VkStructureTypeDedicatedAllocationBufferCreateInfoNV = 1000026001,

    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    VkStructureTypeDedicatedAllocationMemoryAllocateInfoNV = 1000026002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceTransformFeedbackFeaturesEXT = 1000028000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceTransformFeedbackPropertiesEXT = 1000028001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineRasterizationStateStreamCreateInfoEXT = 1000028002,

    [NativeName("VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX")]
    [NameAffix("Suffix", "KhronosVendor", "NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    VkStructureTypeCuModuleCreateInfoNVX = 1000029000,

    [NativeName("VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX")]
    [NameAffix("Suffix", "KhronosVendor", "NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    VkStructureTypeCuFunctionCreateInfoNVX = 1000029001,

    [NativeName("VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX")]
    [NameAffix("Suffix", "KhronosVendor", "NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    VkStructureTypeCuLaunchInfoNVX = 1000029002,

    [NativeName("VK_STRUCTURE_TYPE_CU_MODULE_TEXTURING_MODE_CREATE_INFO_NVX")]
    [NameAffix("Suffix", "KhronosVendor", "NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    VkStructureTypeCuModuleTexturingModeCreateInfoNVX = 1000029004,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX")]
    [NameAffix("Suffix", "KhronosVendor", "NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    VkStructureTypeImageViewHandleInfoNVX = 1000030000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX")]
    [NameAffix("Suffix", "KhronosVendor", "NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    VkStructureTypeImageViewAddressPropertiesNVX = 1000030001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264CapabilitiesKHR = 1000038000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264SessionParametersCreateInfoKHR = 1000038001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264SessionParametersAddInfoKHR = 1000038002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264PictureInfoKHR = 1000038003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264DpbSlotInfoKHR = 1000038004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264NaluSliceInfoKHR = 1000038005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_GOP_REMAINING_FRAME_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264GopRemainingFrameInfoKHR = 1000038006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264ProfileInfoKHR = 1000038007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264RateControlInfoKHR = 1000038008,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264RateControlLayerInfoKHR = 1000038009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264SessionCreateInfoKHR = 1000038010,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUALITY_LEVEL_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264QualityLevelPropertiesKHR = 1000038011,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_GET_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264SessionParametersGetInfoKHR = 1000038012,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH264SessionParametersFeedbackInfoKHR = 1000038013,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265CapabilitiesKHR = 1000039000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265SessionParametersCreateInfoKHR = 1000039001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265SessionParametersAddInfoKHR = 1000039002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PICTURE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265PictureInfoKHR = 1000039003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265DpbSlotInfoKHR = 1000039004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265NaluSliceSegmentInfoKHR = 1000039005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_GOP_REMAINING_FRAME_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265GopRemainingFrameInfoKHR = 1000039006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265ProfileInfoKHR = 1000039007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265RateControlInfoKHR = 1000039009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265RateControlLayerInfoKHR = 1000039010,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265SessionCreateInfoKHR = 1000039011,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUALITY_LEVEL_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265QualityLevelPropertiesKHR = 1000039012,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_GET_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265SessionParametersGetInfoKHR = 1000039013,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeH265SessionParametersFeedbackInfoKHR = 1000039014,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH264CapabilitiesKHR = 1000040000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH264PictureInfoKHR = 1000040001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH264ProfileInfoKHR = 1000040003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH264SessionParametersCreateInfoKHR = 1000040004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH264SessionParametersAddInfoKHR = 1000040005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH264DpbSlotInfoKHR = 1000040006,

    [NativeName("VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_texture_gather_bias_lod"],
        ImpliesSets = [
            "VK_AMD_texture_gather_bias_lod+VK_KHR_get_physical_device_properties2",
            "VK_AMD_texture_gather_bias_lod+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeTextureLodGatherFormatPropertiesAMD = 1000041000,

    [NativeName("VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP")]
    [NameAffix("Suffix", "KhronosVendor", "GGP")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GGP_stream_descriptor_surface"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkStructureTypeStreamDescriptorSurfaceCreateInfoGGP = 1000049000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_corner_sampled_image"],
        ImpliesSets = [
            "VK_NV_corner_sampled_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_corner_sampled_image+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    VkStructureTypeExternalMemoryImageCreateInfoNV = 1000056000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    VkStructureTypeExportMemoryAllocateInfoNV = 1000056001,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    VkStructureTypeImportMemoryWin32HandleInfoNV = 1000057000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    VkStructureTypeExportMemoryWin32HandleInfoNV = 1000057001,

    [NativeName("VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    VkStructureTypeWin32KeyedMutexAcquireReleaseInfoNV = 1000058000,

    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    VkStructureTypeValidationFlagsEXT = 1000061000,

    [NativeName("VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN")]
    [NameAffix("Suffix", "KhronosVendor", "NN")]
    [SupportedApiProfile("vulkan", ["VK_NN_vi_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeViSurfaceCreateInfoNN = 1000062000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageViewAstcDecodeModeEXT = 1000067000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceAstcDecodeFeaturesEXT = 1000067001,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportMemoryWin32HandleInfoKHR = 1000073000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExportMemoryWin32HandleInfoKHR = 1000073001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryWin32HandlePropertiesKHR = 1000073002,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryGetWin32HandleInfoKHR = 1000073003,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportMemoryFdInfoKHR = 1000074000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryFdPropertiesKHR = 1000074001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryGetFdInfoKHR = 1000074002,

    [NativeName("VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_win32_keyed_mutex"],
        ImpliesSets = ["VK_KHR_external_memory_win32"]
    )]
    VkStructureTypeWin32KeyedMutexAcquireReleaseInfoKHR = 1000075000,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    VkStructureTypeImportSemaphoreWin32HandleInfoKHR = 1000078000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    VkStructureTypeExportSemaphoreWin32HandleInfoKHR = 1000078001,

    [NativeName("VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    VkStructureTypeD3D12FenceSubmitInfoKHR = 1000078002,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    VkStructureTypeSemaphoreGetWin32HandleInfoKHR = 1000078003,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_fd"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_fd+VK_KHR_external_semaphore",
            "VK_KHR_external_semaphore_fd+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportSemaphoreFdInfoKHR = 1000079000,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_fd"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_fd+VK_KHR_external_semaphore",
            "VK_KHR_external_semaphore_fd+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSemaphoreGetFdInfoKHR = 1000079001,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCommandBufferInheritanceConditionalRenderingInfoEXT = 1000081000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceConditionalRenderingFeaturesEXT = 1000081001,

    [NativeName("VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeConditionalRenderingBeginInfoEXT = 1000081002,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_incremental_present"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    VkStructureTypePresentRegionsKHR = 1000084000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    VkStructureTypePipelineViewportWScalingStateCreateInfoNV = 1000087000,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VkStructureTypeSurfaceCapabilities2EXT = 1000090000,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    VkStructureTypeDisplayPowerInfoEXT = 1000091000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    VkStructureTypeDeviceEventInfoEXT = 1000091001,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    VkStructureTypeDisplayEventInfoEXT = 1000091002,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    VkStructureTypeSwapchainCounterCreateInfoEXT = 1000091003,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE")]
    [NameAffix("Suffix", "KhronosVendor", "GOOGLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GOOGLE_display_timing"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    VkStructureTypePresentTimesInfoGOOGLE = 1000092000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX")]
    [NameAffix("Suffix", "KhronosVendor", "NVX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NVX_multiview_per_view_attributes"],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMultiviewPerViewAttributesPropertiesNVX = 1000097000,

    [NativeName("VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX")]
    [NameAffix("Suffix", "KhronosVendor", "NVX")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_dynamic_rendering",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMultiviewPerViewAttributesInfoNVX = 1000044009,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VkStructureTypePipelineViewportSwizzleStateCreateInfoNV = 1000098000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDiscardRectanglePropertiesEXT = 1000099000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineDiscardRectangleStateCreateInfoEXT = 1000099001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceConservativeRasterizationPropertiesEXT = 1000101000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineRasterizationConservativeStateCreateInfoEXT = 1000101001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDepthClipEnableFeaturesEXT = 1000102000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineRasterizationDepthClipStateCreateInfoEXT = 1000102001,

    [NativeName("VK_STRUCTURE_TYPE_HDR_METADATA_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    VkStructureTypeHdrMetadataEXT = 1000105000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RELAXED_LINE_RASTERIZATION_FEATURES_IMG")]
    [NameAffix("Suffix", "KhronosVendor", "IMG")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_IMG_relaxed_line_rasterization"],
        ImpliesSets = [
            "VK_IMG_relaxed_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_IMG_relaxed_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRelaxedLineRasterizationFeaturesIMG = 1000110000,

    [NativeName("VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSharedPresentSurfaceCapabilitiesKHR = 1000111000,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    VkStructureTypeImportFenceWin32HandleInfoKHR = 1000114000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    VkStructureTypeExportFenceWin32HandleInfoKHR = 1000114001,

    [NativeName("VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    VkStructureTypeFenceGetWin32HandleInfoKHR = 1000114002,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_fd"],
        ImpliesSets = [
            "VK_KHR_external_fence_fd+VK_KHR_external_fence",
            "VK_KHR_external_fence_fd+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportFenceFdInfoKHR = 1000115000,

    [NativeName("VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_fd"],
        ImpliesSets = [
            "VK_KHR_external_fence_fd+VK_KHR_external_fence",
            "VK_KHR_external_fence_fd+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeFenceGetFdInfoKHR = 1000115001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePerformanceQueryFeaturesKHR = 1000116000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePerformanceQueryPropertiesKHR = 1000116001,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeQueryPoolPerformanceCreateInfoKHR = 1000116002,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePerformanceQuerySubmitInfoKHR = 1000116003,

    [NativeName("VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAcquireProfilingLockInfoKHR = 1000116004,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePerformanceCounterKHR = 1000116005,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePerformanceCounterDescriptionKHR = 1000116006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkStructureTypePhysicalDeviceSurfaceInfo2KHR = 1000119000,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkStructureTypeSurfaceCapabilities2KHR = 1000119001,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkStructureTypeSurfaceFormat2KHR = 1000119002,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VkStructureTypeDisplayProperties2KHR = 1000121000,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VkStructureTypeDisplayPlaneProperties2KHR = 1000121001,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VkStructureTypeDisplayModeProperties2KHR = 1000121002,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VkStructureTypeDisplayPlaneInfo2KHR = 1000121003,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VkStructureTypeDisplayPlaneCapabilities2KHR = 1000121004,

    [NativeName("VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK")]
    [NameAffix("Suffix", "KhronosVendor", "MVK")]
    [SupportedApiProfile("vulkan", ["VK_MVK_ios_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeIosSurfaceCreateInfoMVK = 1000122000,

    [NativeName("VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK")]
    [NameAffix("Suffix", "KhronosVendor", "MVK")]
    [SupportedApiProfile("vulkan", ["VK_MVK_macos_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeMacosSurfaceCreateInfoMVK = 1000123000,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkStructureTypeDebugUtilsObjectNameInfoEXT = 1000128000,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkStructureTypeDebugUtilsObjectTagInfoEXT = 1000128001,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkStructureTypeDebugUtilsLabelEXT = 1000128002,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkStructureTypeDebugUtilsMessengerCallbackDataEXT = 1000128003,

    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkStructureTypeDebugUtilsMessengerCreateInfoEXT = 1000128004,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID")]
    [NameAffix("Suffix", "KhronosVendor", "ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAndroidHardwareBufferUsageANDROID = 1000129000,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID")]
    [NameAffix("Suffix", "KhronosVendor", "ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAndroidHardwareBufferPropertiesANDROID = 1000129001,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID")]
    [NameAffix("Suffix", "KhronosVendor", "ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAndroidHardwareBufferFormatPropertiesANDROID = 1000129002,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID")]
    [NameAffix("Suffix", "KhronosVendor", "ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportAndroidHardwareBufferInfoANDROID = 1000129003,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID")]
    [NameAffix("Suffix", "KhronosVendor", "ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryGetAndroidHardwareBufferInfoANDROID = 1000129004,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID")]
    [NameAffix("Suffix", "KhronosVendor", "ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExternalFormatANDROID = 1000129005,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID")]
    [NameAffix("Suffix", "KhronosVendor", "ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAndroidHardwareBufferFormatProperties2ANDROID = 1000129006,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_AMD_mixed_attachment_samples+VK_KHR_dynamic_rendering",
            "VK_AMD_mixed_attachment_samples+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeAttachmentSampleCountInfoAMD = 1000044008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_BFLOAT16_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderBfloat16FeaturesKHR = 1000141000,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSampleLocationsInfoEXT = 1000143000,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRenderPassSampleLocationsBeginInfoEXT = 1000143001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineSampleLocationsStateCreateInfoEXT = 1000143002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceSampleLocationsPropertiesEXT = 1000143003,

    [NativeName("VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMultisamplePropertiesEXT = 1000143004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    VkStructureTypePipelineCoverageToColorStateCreateInfoNV = 1000149000,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeWriteDescriptorSetAccelerationStructureKHR = 1000150007,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAccelerationStructureBuildGeometryInfoKHR = 1000150000,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAccelerationStructureDeviceAddressInfoKHR = 1000150002,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAccelerationStructureGeometryAabbsDataKHR = 1000150003,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAccelerationStructureGeometryInstancesDataKHR = 1000150004,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAccelerationStructureGeometryTrianglesDataKHR = 1000150005,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAccelerationStructureGeometryKHR = 1000150006,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAccelerationStructureVersionInfoKHR = 1000150009,

    [NativeName("VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeCopyAccelerationStructureInfoKHR = 1000150010,

    [NativeName("VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeCopyAccelerationStructureToMemoryInfoKHR = 1000150011,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeCopyMemoryToAccelerationStructureInfoKHR = 1000150012,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceAccelerationStructureFeaturesKHR = 1000150013,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceAccelerationStructurePropertiesKHR = 1000150014,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAccelerationStructureCreateInfoKHR = 1000150017,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAccelerationStructureBuildSizesInfoKHR = 1000150020,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceRayTracingPipelineFeaturesKHR = 1000347000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceRayTracingPipelinePropertiesKHR = 1000347001,

    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeRayTracingPipelineCreateInfoKHR = 1000150015,

    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeRayTracingShaderGroupCreateInfoKHR = 1000150016,

    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeRayTracingPipelineInterfaceCreateInfoKHR = 1000150018,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_query"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceRayQueryFeaturesKHR = 1000348013,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    VkStructureTypePipelineCoverageModulationStateCreateInfoNV = 1000152000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceShaderSmBuiltinsFeaturesNV = 1000154000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceShaderSmBuiltinsPropertiesNV = 1000154001,

    [NativeName("VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeDrmFormatModifierPropertiesListEXT = 1000158000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceImageDrmFormatModifierInfoEXT = 1000158002,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeImageDrmFormatModifierListCreateInfoEXT = 1000158003,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeImageDrmFormatModifierExplicitCreateInfoEXT = 1000158004,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeImageDrmFormatModifierPropertiesEXT = 1000158005,

    [NativeName("VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_image_drm_format_modifier+VK_KHR_format_feature_flags2",
            "VK_EXT_image_drm_format_modifier+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeDrmFormatModifierPropertiesList2EXT = 1000158006,

    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    VkStructureTypeValidationCacheCreateInfoEXT = 1000160000,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    VkStructureTypeShaderModuleValidationCacheCreateInfoEXT = 1000160001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShadingRateImageFeaturesNV = 1000164001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShadingRateImagePropertiesNV = 1000164002,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,

    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRayTracingPipelineCreateInfoNV = 1000165000,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAccelerationStructureCreateInfoNV = 1000165001,

    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeGeometryNV = 1000165003,

    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeGeometryTrianglesNV = 1000165004,

    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeGeometryAabbNV = 1000165005,

    [NativeName("VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBindAccelerationStructureMemoryInfoNV = 1000165006,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeWriteDescriptorSetAccelerationStructureNV = 1000165007,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAccelerationStructureMemoryRequirementsInfoNV = 1000165008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRayTracingPropertiesNV = 1000165009,

    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRayTracingShaderGroupCreateInfoNV = 1000165011,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAccelerationStructureInfoNV = 1000165012,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    VkStructureTypePhysicalDeviceImageViewImageFormatInfoEXT = 1000170000,

    [NativeName("VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    VkStructureTypeFilterCubicImageViewImageFormatPropertiesEXT = 1000170001,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportMemoryHostPointerInfoEXT = 1000178000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryHostPointerPropertiesEXT = 1000178001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_clock"],
        ImpliesSets = [
            "VK_KHR_shader_clock+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_clock+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderClockFeaturesKHR = 1000181000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_pipeline_compiler_control"])]
    VkStructureTypePipelineCompilerControlCreateInfoAMD = 1000183000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderCorePropertiesAMD = 1000185000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH265CapabilitiesKHR = 1000187000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH265SessionParametersCreateInfoKHR = 1000187001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH265SessionParametersAddInfoKHR = 1000187002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH265ProfileInfoKHR = 1000187003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH265PictureInfoKHR = 1000187004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeH265DpbSlotInfoKHR = 1000187005,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    VkStructureTypeDeviceMemoryOverallocationCreateInfoAMD = 1000189000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP")]
    [NameAffix("Suffix", "KhronosVendor", "GGP")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GGP_frame_token"],
        ImpliesSets = ["VK_GGP_stream_descriptor_surface", "VK_KHR_swapchain"]
    )]
    VkStructureTypePresentFrameTokenGGP = 1000191000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMeshShaderFeaturesNV = 1000202000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMeshShaderPropertiesNV = 1000202001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shader_image_footprint"],
        ImpliesSets = [
            "VK_NV_shader_image_footprint+VK_KHR_get_physical_device_properties2",
            "VK_NV_shader_image_footprint+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,

    [NativeName("VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostic_checkpoints"],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCheckpointDataNV = 1000206000,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostic_checkpoints"],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeQueueFamilyCheckpointPropertiesNV = 1000206001,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_synchronization2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeQueueFamilyCheckpointProperties2NV = 1000314008,

    [NativeName("VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_synchronization2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCheckpointData2NV = 1000314009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL")]
    [NameAffix("Suffix", "KhronosVendor", "INTEL")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_INTEL_shader_integer_functions2"],
        ImpliesSets = [
            "VK_INTEL_shader_integer_functions2+VK_KHR_get_physical_device_properties2",
            "VK_INTEL_shader_integer_functions2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderIntegerFunctions2FeaturesINTEL = 1000209000,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL")]
    [NameAffix("Suffix", "KhronosVendor", "INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkStructureTypeQueryPoolPerformanceQueryCreateInfoINTEL = 1000210000,

    [NativeName("VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL")]
    [NameAffix("Suffix", "KhronosVendor", "INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkStructureTypeInitializePerformanceApiInfoINTEL = 1000210001,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL")]
    [NameAffix("Suffix", "KhronosVendor", "INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkStructureTypePerformanceMarkerInfoINTEL = 1000210002,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL")]
    [NameAffix("Suffix", "KhronosVendor", "INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkStructureTypePerformanceStreamMarkerInfoINTEL = 1000210003,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL")]
    [NameAffix("Suffix", "KhronosVendor", "INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkStructureTypePerformanceOverrideInfoINTEL = 1000210004,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL")]
    [NameAffix("Suffix", "KhronosVendor", "INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkStructureTypePerformanceConfigurationAcquireInfoINTEL = 1000210005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pci_bus_info"],
        ImpliesSets = [
            "VK_EXT_pci_bus_info+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pci_bus_info+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePciBusInfoPropertiesEXT = 1000212000,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDisplayNativeHdrSurfaceCapabilitiesAMD = 1000213000,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSwapchainDisplayNativeHdrCreateInfoAMD = 1000213001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_imagepipe_surface"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkStructureTypeImagepipeSurfaceCreateInfoFUCHSIA = 1000214000,

    [NativeName("VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeMetalSurfaceCreateInfoEXT = 1000217000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRenderPassFragmentDensityMapCreateInfoEXT = 1000218002,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_fragment_density_map+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRenderingFragmentDensityMapAttachmentInfoEXT = 1000044007,

    [NativeName("VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeFragmentShadingRateAttachmentInfoKHR = 1000226000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePipelineFragmentShadingRateStateCreateInfoKHR = 1000226001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentShadingRatePropertiesKHR = 1000226002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentShadingRateFeaturesKHR = 1000226003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentShadingRateKHR = 1000226004,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_fragment_shading_rate+VK_KHR_dynamic_rendering",
            "VK_KHR_fragment_shading_rate+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeRenderingFragmentShadingRateAttachmentInfoKHR = 1000044006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties2"],
        ImpliesSets = ["VK_AMD_shader_core_properties"]
    )]
    VkStructureTypePhysicalDeviceShaderCoreProperties2AMD = 1000227000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_device_coherent_memory"],
        ImpliesSets = [
            "VK_AMD_device_coherent_memory+VK_KHR_get_physical_device_properties2",
            "VK_AMD_device_coherent_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCoherentMemoryFeaturesAMD = 1000229000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_image_atomic_int64"],
        ImpliesSets = [
            "VK_EXT_shader_image_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_image_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderImageAtomicInt64FeaturesEXT = 1000234000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_QUAD_CONTROL_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_quad_control"],
        ImpliesSets = [
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_1+VK_KHR_vulkan_memory_model",
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderQuadControlFeaturesKHR = 1000235000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_budget"],
        ImpliesSets = [
            "VK_EXT_memory_budget+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_budget+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMemoryBudgetPropertiesEXT = 1000237000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_priority"],
        ImpliesSets = [
            "VK_EXT_memory_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_priority+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMemoryPriorityFeaturesEXT = 1000238000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_priority"],
        ImpliesSets = [
            "VK_EXT_memory_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_priority+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryPriorityAllocateInfoEXT = 1000238001,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_protected_capabilities"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_VERSION_1_1"]
    )]
    VkStructureTypeSurfaceProtectedCapabilitiesKHR = 1000239000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV"
    )]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_dedicated_allocation_image_aliasing"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceBufferDeviceAddressFeaturesEXT = 1000244000,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferDeviceAddressCreateInfoEXT = 1000244002,

    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkStructureTypeValidationFeaturesEXT = 1000247000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait"],
        ImpliesSets = ["VK_KHR_present_id", "VK_KHR_swapchain"]
    )]
    VkStructureTypePhysicalDevicePresentWaitFeaturesKHR = 1000248000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,

    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCooperativeMatrixPropertiesNV = 1000249001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineCoverageReductionStateCreateInfoNV = 1000250001,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeFramebufferMixedSamplesCombinationNV = 1000250002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_shader_interlock"],
        ImpliesSets = [
            "VK_EXT_fragment_shader_interlock+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_shader_interlock+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentShaderInterlockFeaturesEXT = 1000251000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_image_arrays"],
        ImpliesSets = [
            "VK_EXT_ycbcr_image_arrays+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_image_arrays+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceYcbcrImageArraysFeaturesEXT = 1000252000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceProvokingVertexFeaturesEXT = 1000254000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineRasterizationProvokingVertexStateCreateInfoEXT = 1000254001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceProvokingVertexPropertiesEXT = 1000254002,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSurfaceFullScreenExclusiveInfoEXT = 1000255000,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSurfaceCapabilitiesFullScreenExclusiveEXT = 1000255002,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive", "VK_KHR_win32_surface"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkStructureTypeSurfaceFullScreenExclusiveWin32InfoEXT = 1000255001,

    [NativeName("VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_headless_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeHeadlessSurfaceCreateInfoEXT = 1000256000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderAtomicFloatFeaturesEXT = 1000260000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExtendedDynamicStateFeaturesEXT = 1000267000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePipelineExecutablePropertiesFeaturesKHR = 1000269000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineInfoKHR = 1000269001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineExecutablePropertiesKHR = 1000269002,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineExecutableInfoKHR = 1000269003,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineExecutableStatisticKHR = 1000269004,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineExecutableInternalRepresentationKHR = 1000269005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePhysicalDeviceMapMemoryPlacedFeaturesEXT = 1000272000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePhysicalDeviceMapMemoryPlacedPropertiesEXT = 1000272001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MAP_PLACED_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypeMemoryMapPlacedInfoEXT = 1000272002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    VkStructureTypePhysicalDeviceShaderAtomicFloat2FeaturesEXT = 1000273000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkStructureTypePhysicalDeviceDeviceGeneratedCommandsPropertiesNV = 1000277000,

    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkStructureTypeGraphicsShaderGroupCreateInfoNV = 1000277001,

    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkStructureTypeGraphicsPipelineShaderGroupsCreateInfoNV = 1000277002,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkStructureTypeIndirectCommandsLayoutTokenNV = 1000277003,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkStructureTypeIndirectCommandsLayoutCreateInfoNV = 1000277004,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkStructureTypeGeneratedCommandsInfoNV = 1000277005,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkStructureTypeGeneratedCommandsMemoryRequirementsInfoNV = 1000277006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VkStructureTypePhysicalDeviceDeviceGeneratedCommandsFeaturesNV = 1000277007,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_inherited_viewport_scissor"],
        ImpliesSets = [
            "VK_NV_inherited_viewport_scissor+VK_KHR_get_physical_device_properties2",
            "VK_NV_inherited_viewport_scissor+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceInheritedViewportScissorFeaturesNV = 1000278000,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_inherited_viewport_scissor"],
        ImpliesSets = [
            "VK_NV_inherited_viewport_scissor+VK_KHR_get_physical_device_properties2",
            "VK_NV_inherited_viewport_scissor+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCommandBufferInheritanceViewportScissorInfoNV = 1000278001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texel_buffer_alignment"],
        ImpliesSets = [
            "VK_EXT_texel_buffer_alignment+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texel_buffer_alignment+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceTexelBufferAlignmentFeaturesEXT = 1000281000,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    VkStructureTypeCommandBufferInheritanceRenderPassTransformInfoQCOM = 1000282000,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    VkStructureTypeRenderPassTransformBeginInfoQCOM = 1000282001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDepthBiasControlFeaturesEXT = 1000283000,

    [NativeName("VK_STRUCTURE_TYPE_DEPTH_BIAS_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDepthBiasInfoEXT = 1000283001,

    [NativeName("VK_STRUCTURE_TYPE_DEPTH_BIAS_REPRESENTATION_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDepthBiasRepresentationInfoEXT = 1000283002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDeviceMemoryReportFeaturesEXT = 1000284000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDeviceDeviceMemoryReportCreateInfoEXT = 1000284001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDeviceMemoryReportCallbackDataEXT = 1000284002,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSamplerCustomBorderColorCreateInfoEXT = 1000287000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCustomBorderColorPropertiesEXT = 1000287001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCustomBorderColorFeaturesEXT = 1000287002,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    VkStructureTypePipelineLibraryCreateInfoKHR = 1000290000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePresentBarrierFeaturesNV = 1000292000,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSurfaceCapabilitiesPresentBarrierNV = 1000292001,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSwapchainPresentBarrierCreateInfoNV = 1000292002,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_ID_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePresentIdKHR = 1000294000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePresentIdFeaturesKHR = 1000294001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeInfoKHR = 1000299000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeRateControlInfoKHR = 1000299001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeRateControlLayerInfoKHR = 1000299002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeCapabilitiesKHR = 1000299003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeUsageInfoKHR = 1000299004,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeQueryPoolVideoEncodeFeedbackCreateInfoKHR = 1000299005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceVideoEncodeQualityLevelInfoKHR = 1000299006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeQualityLevelPropertiesKHR = 1000299007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeQualityLevelInfoKHR = 1000299008,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_GET_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeSessionParametersGetInfoKHR = 1000299009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeSessionParametersFeedbackInfoKHR = 1000299010,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDeviceDiagnosticsConfigCreateInfoNV = 1000300001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VkStructureTypePhysicalDeviceTileShadingFeaturesQCOM = 1000309000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_PROPERTIES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VkStructureTypePhysicalDeviceTileShadingPropertiesQCOM = 1000309001,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_TILE_SHADING_CREATE_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VkStructureTypeRenderPassTileShadingCreateInfoQCOM = 1000309002,

    [NativeName("VK_STRUCTURE_TYPE_PER_TILE_BEGIN_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VkStructureTypePerTileBeginInfoQCOM = 1000309003,

    [NativeName("VK_STRUCTURE_TYPE_PER_TILE_END_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VkStructureTypePerTileEndInfoQCOM = 1000309004,

    [NativeName("VK_STRUCTURE_TYPE_DISPATCH_TILE_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VkStructureTypeDispatchTileInfoQCOM = 1000309005,

    [NativeName("VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_low_latency"])]
    VkStructureTypeQueryLowLatencySupportNV = 1000310000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeExportMetalObjectCreateInfoEXT = 1000311000,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeExportMetalObjectsInfoEXT = 1000311001,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeExportMetalDeviceInfoEXT = 1000311002,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeExportMetalCommandQueueInfoEXT = 1000311003,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeExportMetalBufferInfoEXT = 1000311004,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeImportMetalBufferInfoEXT = 1000311005,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeExportMetalTextureInfoEXT = 1000311006,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeImportMetalTextureInfoEXT = 1000311007,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeExportMetalIoSurfaceInfoEXT = 1000311008,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeImportMetalIoSurfaceInfoEXT = 1000311009,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeExportMetalSharedEventInfoEXT = 1000311010,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VkStructureTypeImportMetalSharedEventInfoEXT = 1000311011,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceDescriptorBufferPropertiesEXT = 1000316000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_DENSITY_MAP_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceDescriptorBufferDensityMapPropertiesEXT = 1000316001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceDescriptorBufferFeaturesEXT = 1000316002,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeDescriptorAddressInfoEXT = 1000316003,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeDescriptorGetInfoEXT = 1000316004,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeBufferCaptureDescriptorDataInfoEXT = 1000316005,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeImageCaptureDescriptorDataInfoEXT = 1000316006,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeImageViewCaptureDescriptorDataInfoEXT = 1000316007,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeSamplerCaptureDescriptorDataInfoEXT = 1000316008,

    [NativeName("VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeOpaqueCaptureDescriptorDataCreateInfoEXT = 1000316010,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeDescriptorBufferBindingInfoEXT = 1000316011,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeDescriptorBufferBindingPushDescriptorBufferHandleEXT = 1000316012,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_descriptor_buffer+VK_KHR_acceleration_structure",
            "VK_EXT_descriptor_buffer+VK_NV_ray_tracing",
        ],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeAccelerationStructureCaptureDescriptorDataInfoEXT = 1000316009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceGraphicsPipelineLibraryFeaturesEXT = 1000320000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceGraphicsPipelineLibraryPropertiesEXT = 1000320001,

    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeGraphicsPipelineLibraryCreateInfoEXT = 1000320002,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD"
    )]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_early_and_late_fragment_tests"],
        ImpliesSets = [
            "VK_AMD_shader_early_and_late_fragment_tests+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_early_and_late_fragment_tests+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD = 1000321000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentShaderBarycentricFeaturesKHR = 1000203000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentShaderBarycentricPropertiesKHR = 1000322000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR"
    )]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_uniform_control_flow"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VkStructureTypePhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR = 1000323000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkStructureTypePhysicalDeviceFragmentShadingRateEnumsPropertiesNV = 1000326000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkStructureTypePhysicalDeviceFragmentShadingRateEnumsFeaturesNV = 1000326001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkStructureTypePipelineFragmentShadingRateEnumStateCreateInfoNV = 1000326002,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkStructureTypeAccelerationStructureGeometryMotionTrianglesDataNV = 1000327000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkStructureTypePhysicalDeviceRayTracingMotionBlurFeaturesNV = 1000327001,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkStructureTypeAccelerationStructureMotionInfoNV = 1000327002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
    )]
    VkStructureTypePhysicalDeviceMeshShaderFeaturesEXT = 1000328000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
    )]
    VkStructureTypePhysicalDeviceMeshShaderPropertiesEXT = 1000328001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_2plane_444_formats"],
        ImpliesSets = [
            "VK_EXT_ycbcr_2plane_444_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_2plane_444_formats+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT = 1000330000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    VkStructureTypePhysicalDeviceFragmentDensityMap2FeaturesEXT = 1000332000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    VkStructureTypePhysicalDeviceFragmentDensityMap2PropertiesEXT = 1000332001,

    [NativeName("VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_rotated_copy_commands"],
        ImpliesSets = [
            "VK_QCOM_rotated_copy_commands+VK_KHR_copy_commands2",
            "VK_QCOM_rotated_copy_commands+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeCopyCommandTransformInfoQCOM = 1000333000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_workgroup_memory_explicit_layout"],
        ImpliesSets = [
            "VK_KHR_workgroup_memory_explicit_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_workgroup_memory_explicit_layout+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR = 1000336000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceImageCompressionControlFeaturesEXT = 1000338000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageCompressionControlEXT = 1000338001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageCompressionPropertiesEXT = 1000338004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_layout"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT = 1000339000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_4444_formats"],
        ImpliesSets = [
            "VK_EXT_4444_formats+VK_KHR_get_physical_device_properties2",
            "VK_EXT_4444_formats+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevice4444FormatsFeaturesEXT = 1000340000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFaultFeaturesEXT = 1000341000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDeviceFaultCountsEXT = 1000341001,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDeviceFaultInfoEXT = 1000341002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rgba10x6_formats"],
        ImpliesSets = [
            "VK_EXT_rgba10x6_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_rgba10x6_formats+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRgba10x6FormatsFeaturesEXT = 1000344000,

    [NativeName("VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_directfb_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeDirectfbSurfaceCreateInfoEXT = 1000346000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceVertexInputDynamicStateFeaturesEXT = 1000352000,

    [NativeName("VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeVertexInputBindingDescription2EXT = 1000352001,

    [NativeName("VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeVertexInputAttributeDescription2EXT = 1000352002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDrmPropertiesEXT = 1000353000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceAddressBindingReportFeaturesEXT = 1000354000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDeviceAddressBindingCallbackDataEXT = 1000354001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control"],
        ImpliesSets = [
            "VK_EXT_depth_clip_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDepthClipControlFeaturesEXT = 1000355000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control"],
        ImpliesSets = [
            "VK_EXT_depth_clip_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineViewportDepthClipControlCreateInfoEXT = 1000355001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitive_topology_list_restart"],
        ImpliesSets = [
            "VK_EXT_primitive_topology_list_restart+VK_KHR_get_physical_device_properties2",
            "VK_EXT_primitive_topology_list_restart+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePrimitiveTopologyListRestartFeaturesEXT = 1000356000,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportMemoryZirconHandleInfoFUCHSIA = 1000364000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryZirconHandlePropertiesFUCHSIA = 1000364001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryGetZirconHandleInfoFUCHSIA = 1000364002,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore", "VK_KHR_external_semaphore_capabilities"]
    )]
    VkStructureTypeImportSemaphoreZirconHandleInfoFUCHSIA = 1000365000,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore", "VK_KHR_external_semaphore_capabilities"]
    )]
    VkStructureTypeSemaphoreGetZirconHandleInfoFUCHSIA = 1000365001,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferCollectionCreateInfoFUCHSIA = 1000366000,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportMemoryBufferCollectionFUCHSIA = 1000366001,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferCollectionImageCreateInfoFUCHSIA = 1000366002,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferCollectionPropertiesFUCHSIA = 1000366003,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferConstraintsInfoFUCHSIA = 1000366004,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferCollectionBufferCreateInfoFUCHSIA = 1000366005,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageConstraintsInfoFUCHSIA = 1000366006,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageFormatConstraintsInfoFUCHSIA = 1000366007,

    [NativeName("VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSysmemColorSpaceFUCHSIA = 1000366008,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA")]
    [NameAffix("Suffix", "KhronosVendor", "FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferCollectionConstraintsInfoFUCHSIA = 1000366009,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeSubpassShadingPipelineCreateInfoHUAWEI = 1000369000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceSubpassShadingFeaturesHUAWEI = 1000369001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceSubpassShadingPropertiesHUAWEI = 1000369002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_invocation_mask"],
        ImpliesSets = [
            "VK_KHR_ray_tracing_pipeline+VK_KHR_synchronization2",
            "VK_KHR_ray_tracing_pipeline+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceInvocationMaskFeaturesHUAWEI = 1000370000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_rdma"],
        ImpliesSets = [
            "VK_NV_external_memory_rdma+VK_KHR_external_memory",
            "VK_NV_external_memory_rdma+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryGetRemoteAddressInfoNV = 1000371000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_rdma"],
        ImpliesSets = [
            "VK_NV_external_memory_rdma+VK_KHR_external_memory",
            "VK_NV_external_memory_rdma+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExternalMemoryRdmaFeaturesNV = 1000371001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelinePropertiesIdentifierEXT = 1000372000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePipelinePropertiesFeaturesEXT = 1000372001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAME_BOUNDARY_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFrameBoundaryFeaturesEXT = 1000375000,

    [NativeName("VK_STRUCTURE_TYPE_FRAME_BOUNDARY_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeFrameBoundaryEXT = 1000375001,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT"
    )]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    VkStructureTypePhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT = 1000376000,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    VkStructureTypeSubpassResolvePerformanceQueryEXT = 1000376001,

    [NativeName("VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    VkStructureTypeMultisampledRenderToSingleSampledInfoEXT = 1000376002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExtendedDynamicState2FeaturesEXT = 1000377000,

    [NativeName("VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX")]
    [NameAffix("Suffix", "KhronosVendor", "QNX")]
    [SupportedApiProfile("vulkan", ["VK_QNX_screen_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeScreenSurfaceCreateInfoQNX = 1000378000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceColorWriteEnableFeaturesEXT = 1000381000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineColorWriteCreateInfoEXT = 1000381001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitives_generated_query"],
        ImpliesSets = ["VK_EXT_transform_feedback"]
    )]
    VkStructureTypePhysicalDevicePrimitivesGeneratedQueryFeaturesEXT = 1000382000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypePhysicalDeviceRayTracingMaintenance1FeaturesKHR = 1000386000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNTYPED_POINTERS_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_untyped_pointers"],
        ImpliesSets = ["VK_KHR_get_physical_device_properties2"]
    )]
    VkStructureTypePhysicalDeviceShaderUntypedPointersFeaturesKHR = 1000387000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_RGB_CONVERSION_FEATURES_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceVideoEncodeRgbConversionFeaturesVALVE = 1000390000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RGB_CONVERSION_CAPABILITIES_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeVideoEncodeRgbConversionCapabilitiesVALVE = 1000390001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_PROFILE_RGB_CONVERSION_INFO_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeVideoEncodeProfileRgbConversionInfoVALVE = 1000390002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_RGB_CONVERSION_CREATE_INFO_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeVideoEncodeSessionRgbConversionCreateInfoVALVE = 1000390003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_view_min_lod"],
        ImpliesSets = [
            "VK_EXT_image_view_min_lod+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_view_min_lod+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceImageViewMinLodFeaturesEXT = 1000391000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_view_min_lod"],
        ImpliesSets = [
            "VK_EXT_image_view_min_lod+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_view_min_lod+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageViewMinLodCreateInfoEXT = 1000391001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multi_draw"],
        ImpliesSets = [
            "VK_EXT_multi_draw+VK_KHR_get_physical_device_properties2",
            "VK_EXT_multi_draw+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMultiDrawFeaturesEXT = 1000392000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multi_draw"],
        ImpliesSets = [
            "VK_EXT_multi_draw+VK_KHR_get_physical_device_properties2",
            "VK_EXT_multi_draw+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMultiDrawPropertiesEXT = 1000392001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_2d_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceImage2DViewOf3DFeaturesEXT = 1000393000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypePhysicalDeviceShaderTileImageFeaturesEXT = 1000395000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypePhysicalDeviceShaderTileImagePropertiesEXT = 1000395001,

    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeMicromapBuildInfoEXT = 1000396000,

    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeMicromapVersionInfoEXT = 1000396001,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeCopyMicromapInfoEXT = 1000396002,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeCopyMicromapToMemoryInfoEXT = 1000396003,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeCopyMemoryToMicromapInfoEXT = 1000396004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceOpacityMicromapFeaturesEXT = 1000396005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceOpacityMicromapPropertiesEXT = 1000396006,

    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeMicromapCreateInfoEXT = 1000396007,

    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeMicromapBuildSizesInfoEXT = 1000396008,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeAccelerationStructureTrianglesOpacityMicromapEXT = 1000396009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceClusterCullingShaderFeaturesHUAWEI = 1000404000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceClusterCullingShaderPropertiesHUAWEI = 1000404001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_VRS_FEATURES_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI = 1000404002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    VkStructureTypePhysicalDeviceBorderColorSwizzleFeaturesEXT = 1000411000,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    VkStructureTypeSamplerBorderColorComponentMappingCreateInfoEXT = 1000411001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pageable_device_local_memory"],
        ImpliesSets = ["VK_EXT_memory_priority"]
    )]
    VkStructureTypePhysicalDevicePageableDeviceLocalMemoryFeaturesEXT = 1000412000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_properties"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VkStructureTypePhysicalDeviceShaderCorePropertiesARM = 1000415000,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_SHADER_CORE_CONTROL_CREATE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    VkStructureTypeDeviceQueueShaderCoreControlCreateInfoARM = 1000417000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_FEATURES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    VkStructureTypePhysicalDeviceSchedulingControlsFeaturesARM = 1000417001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    VkStructureTypePhysicalDeviceSchedulingControlsPropertiesARM = 1000417002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_sliced_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceImageSlicedViewOf3DFeaturesEXT = 1000418000,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_sliced_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageViewSlicedCreateInfoEXT = 1000418001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDescriptorSetHostMappingFeaturesVALVE = 1000420000,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDescriptorSetBindingReferenceVALVE = 1000420001,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDescriptorSetLayoutHostMappingInfoVALVE = 1000420002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_non_seamless_cube_map"],
        ImpliesSets = [
            "VK_EXT_non_seamless_cube_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_non_seamless_cube_map+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceNonSeamlessCubeMapFeaturesEXT = 1000422000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_FEATURES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceRenderPassStripedFeaturesARM = 1000424000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceRenderPassStripedPropertiesARM = 1000424001,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_BEGIN_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeRenderPassStripeBeginInfoARM = 1000424002,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeRenderPassStripeInfoARM = 1000424003,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_SUBMIT_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeRenderPassStripeSubmitInfoARM = 1000424004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceCopyMemoryIndirectFeaturesNV = 1000426000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    VkStructureTypePhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV = 1000428000,

    [NativeName("VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    VkStructureTypeComputePipelineIndirectBufferInfoNV = 1000428001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INDIRECT_DEVICE_ADDRESS_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    VkStructureTypePipelineIndirectDeviceAddressInfoNV = 1000428002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_LINEAR_SWEPT_SPHERES_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkStructureTypePhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV = 1000429008,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_LINEAR_SWEPT_SPHERES_DATA_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkStructureTypeAccelerationStructureGeometryLinearSweptSpheresDataNV = 1000429009,

    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_SPHERES_DATA_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkStructureTypeAccelerationStructureGeometrySpheresDataNV = 1000429010,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_linear_color_attachment"],
        ImpliesSets = [
            "VK_NV_linear_color_attachment+VK_KHR_get_physical_device_properties2",
            "VK_NV_linear_color_attachment+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceLinearColorAttachmentFeaturesNV = 1000430000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MAXIMAL_RECONVERGENCE_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_maximal_reconvergence"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VkStructureTypePhysicalDeviceShaderMaximalReconvergenceFeaturesKHR = 1000434000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT"
    )]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control_swapchain"],
        ImpliesSets = ["VK_EXT_image_compression_control"]
    )]
    VkStructureTypePhysicalDeviceImageCompressionControlSwapchainFeaturesEXT = 1000437000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceImageProcessingFeaturesQCOM = 1000440000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceImageProcessingPropertiesQCOM = 1000440001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeImageViewSampleWeightCreateInfoQCOM = 1000440002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceNestedCommandBufferFeaturesEXT = 1000451000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceNestedCommandBufferPropertiesEXT = 1000451001,

    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_USAGE_OHOS")]
    [NameAffix("Suffix", "KhronosVendor", "OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeNativeBufferUsageOHOS = 1000452000,

    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_PROPERTIES_OHOS")]
    [NameAffix("Suffix", "KhronosVendor", "OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeNativeBufferPropertiesOHOS = 1000452001,

    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_FORMAT_PROPERTIES_OHOS")]
    [NameAffix("Suffix", "KhronosVendor", "OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeNativeBufferFormatPropertiesOHOS = 1000452002,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_NATIVE_BUFFER_INFO_OHOS")]
    [NameAffix("Suffix", "KhronosVendor", "OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportNativeBufferInfoOHOS = 1000452003,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_NATIVE_BUFFER_INFO_OHOS")]
    [NameAffix("Suffix", "KhronosVendor", "OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryGetNativeBufferInfoOHOS = 1000452004,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_OHOS")]
    [NameAffix("Suffix", "KhronosVendor", "OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExternalFormatOHOS = 1000452005,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_acquire_unmodified"],
        ImpliesSets = [
            "VK_EXT_external_memory_acquire_unmodified+VK_KHR_external_memory",
            "VK_EXT_external_memory_acquire_unmodified+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExternalMemoryAcquireUnmodifiedEXT = 1000453000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExtendedDynamicState3FeaturesEXT = 1000455000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExtendedDynamicState3PropertiesEXT = 1000455001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceSubpassMergeFeedbackFeaturesEXT = 1000458000,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRenderPassCreationControlEXT = 1000458001,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRenderPassCreationFeedbackCreateInfoEXT = 1000458002,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRenderPassSubpassFeedbackCreateInfoEXT = 1000458003,

    [NativeName("VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG")]
    [NameAffix("Suffix", "KhronosVendor", "LUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    VkStructureTypeDirectDriverLoadingInfoLUNARG = 1000459000,

    [NativeName("VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG")]
    [NameAffix("Suffix", "KhronosVendor", "LUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    VkStructureTypeDirectDriverLoadingListLUNARG = 1000459001,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_CREATE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeTensorCreateInfoARM = 1000460000,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_VIEW_CREATE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeTensorViewCreateInfoARM = 1000460001,

    [NativeName("VK_STRUCTURE_TYPE_BIND_TENSOR_MEMORY_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeBindTensorMemoryInfoARM = 1000460002,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_TENSOR_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeWriteDescriptorSetTensorARM = 1000460003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypePhysicalDeviceTensorPropertiesARM = 1000460004,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_FORMAT_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeTensorFormatPropertiesARM = 1000460005,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_DESCRIPTION_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeTensorDescriptionARM = 1000460006,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_MEMORY_REQUIREMENTS_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeTensorMemoryRequirementsInfoARM = 1000460007,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_MEMORY_BARRIER_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeTensorMemoryBarrierARM = 1000460008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_FEATURES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypePhysicalDeviceTensorFeaturesARM = 1000460009,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_TENSOR_MEMORY_REQUIREMENTS_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeDeviceTensorMemoryRequirementsARM = 1000460010,

    [NativeName("VK_STRUCTURE_TYPE_COPY_TENSOR_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeCopyTensorInfoARM = 1000460011,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_COPY_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeTensorCopyARM = 1000460012,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_DEPENDENCY_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeTensorDependencyInfoARM = 1000460013,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_TENSOR_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeMemoryDedicatedAllocateInfoTensorARM = 1000460014,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_TENSOR_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypePhysicalDeviceExternalTensorInfoARM = 1000460015,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_TENSOR_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeExternalTensorPropertiesARM = 1000460016,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_TENSOR_CREATE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkStructureTypeExternalMemoryTensorCreateInfoARM = 1000460017,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_FEATURES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    VkStructureTypePhysicalDeviceDescriptorBufferTensorFeaturesARM = 1000460018,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    VkStructureTypePhysicalDeviceDescriptorBufferTensorPropertiesARM = 1000460019,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_GET_TENSOR_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    VkStructureTypeDescriptorGetTensorInfoARM = 1000460020,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_CAPTURE_DESCRIPTOR_DATA_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    VkStructureTypeTensorCaptureDescriptorDataInfoARM = 1000460021,

    [NativeName("VK_STRUCTURE_TYPE_TENSOR_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    VkStructureTypeTensorViewCaptureDescriptorDataInfoARM = 1000460022,

    [NativeName("VK_STRUCTURE_TYPE_FRAME_BOUNDARY_TENSORS_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    VkStructureTypeFrameBoundaryTensorsARM = 1000460023,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderModuleIdentifierFeaturesEXT = 1000462000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderModuleIdentifierPropertiesEXT = 1000462001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_MODULE_IDENTIFIER_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePipelineShaderStageModuleIdentifierCreateInfoEXT = 1000462002,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeShaderModuleIdentifierEXT = 1000462003,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT"
    )]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT = 1000342000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceOpticalFlowFeaturesNV = 1000464000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceOpticalFlowPropertiesNV = 1000464001,

    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeOpticalFlowImageFormatInfoNV = 1000464002,

    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeOpticalFlowImageFormatPropertiesNV = 1000464003,

    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeOpticalFlowSessionCreateInfoNV = 1000464004,

    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeOpticalFlowExecuteInfoNV = 1000464005,

    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeOpticalFlowSessionCreatePrivateDataInfoNV = 1000464010,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_dithering"],
        ImpliesSets = [
            "VK_EXT_legacy_dithering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_legacy_dithering+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceLegacyDitheringFeaturesEXT = 1000465000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_FEATURES_ANDROID")]
    [NameAffix("Suffix", "KhronosVendor", "ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    VkStructureTypePhysicalDeviceExternalFormatResolveFeaturesANDROID = 1000468000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_PROPERTIES_ANDROID")]
    [NameAffix("Suffix", "KhronosVendor", "ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    VkStructureTypePhysicalDeviceExternalFormatResolvePropertiesANDROID = 1000468001,

    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_RESOLVE_PROPERTIES_ANDROID")]
    [NameAffix("Suffix", "KhronosVendor", "ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    VkStructureTypeAndroidHardwareBufferFormatResolvePropertiesANDROID = 1000468002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ANTI_LAG_FEATURES_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceAntiLagFeaturesAMD = 1000476000,

    [NativeName("VK_STRUCTURE_TYPE_ANTI_LAG_DATA_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAntiLagDataAMD = 1000476001,

    [NativeName("VK_STRUCTURE_TYPE_ANTI_LAG_PRESENTATION_INFO_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAntiLagPresentationInfoAMD = 1000476002,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_ID_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    VkStructureTypeSurfaceCapabilitiesPresentId2KHR = 1000479000,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_ID_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    VkStructureTypePresentId2KHR = 1000479001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_2_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    VkStructureTypePhysicalDevicePresentId2FeaturesKHR = 1000479002,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_WAIT_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait2"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_surface",
            "VK_KHR_swapchain",
        ]
    )]
    VkStructureTypeSurfaceCapabilitiesPresentWait2KHR = 1000480000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_2_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait2"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_surface",
            "VK_KHR_swapchain",
        ]
    )]
    VkStructureTypePhysicalDevicePresentWait2FeaturesKHR = 1000480001,

    [NativeName("VK_STRUCTURE_TYPE_PRESENT_WAIT_2_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait2"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_surface",
            "VK_KHR_swapchain",
        ]
    )]
    VkStructureTypePresentWait2InfoKHR = 1000480002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_POSITION_FETCH_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_position_fetch"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypePhysicalDeviceRayTracingPositionFetchFeaturesKHR = 1000481000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderObjectFeaturesEXT = 1000482000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderObjectPropertiesEXT = 1000482001,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeShaderCreateInfoEXT = 1000482002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePhysicalDevicePipelineBinaryFeaturesKHR = 1000483000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePipelineBinaryCreateInfoKHR = 1000483001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePipelineBinaryInfoKHR = 1000483002,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_KEY_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePipelineBinaryKeyKHR = 1000483003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePhysicalDevicePipelineBinaryPropertiesKHR = 1000483004,

    [NativeName("VK_STRUCTURE_TYPE_RELEASE_CAPTURED_PIPELINE_DATA_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypeReleaseCapturedPipelineDataInfoKHR = 1000483005,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_DATA_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePipelineBinaryDataInfoKHR = 1000483006,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePipelineCreateInfoKHR = 1000483007,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_PIPELINE_BINARY_INTERNAL_CACHE_CONTROL_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypeDevicePipelineBinaryInternalCacheControlKHR = 1000483008,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_HANDLES_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePipelineBinaryHandlesInfoKHR = 1000483009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceTilePropertiesFeaturesQCOM = 1000484000,

    [NativeName("VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeTilePropertiesQCOM = 1000484001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC")]
    [NameAffix("Suffix", "KhronosVendor", "SEC")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceAmigoProfilingFeaturesSEC = 1000485000,

    [NativeName("VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC")]
    [NameAffix("Suffix", "KhronosVendor", "SEC")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAmigoProfilingSubmitInfoSEC = 1000485001,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkStructureTypeSurfacePresentModeKHR = 1000274000,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkStructureTypeSurfacePresentScalingCapabilitiesKHR = 1000274001,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkStructureTypeSurfacePresentModeCompatibilityKHR = 1000274002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    VkStructureTypePhysicalDeviceSwapchainMaintenance1FeaturesKHR = 1000275000,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    VkStructureTypeSwapchainPresentFenceInfoKHR = 1000275001,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    VkStructureTypeSwapchainPresentModesCreateInfoKHR = 1000275002,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    VkStructureTypeSwapchainPresentModeInfoKHR = 1000275003,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    VkStructureTypeSwapchainPresentScalingCreateInfoKHR = 1000275004,

    [NativeName("VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    VkStructureTypeReleaseSwapchainImagesInfoKHR = 1000275005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_viewports"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_viewports+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_viewports+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM = 1000488000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkStructureTypePhysicalDeviceRayTracingInvocationReorderFeaturesNV = 1000490000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkStructureTypePhysicalDeviceRayTracingInvocationReorderPropertiesNV = 1000490001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCooperativeVectorFeaturesNV = 1000491000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCooperativeVectorPropertiesNV = 1000491001,

    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_VECTOR_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCooperativeVectorPropertiesNV = 1000491002,

    [NativeName("VK_STRUCTURE_TYPE_CONVERT_COOPERATIVE_VECTOR_MATRIX_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeConvertCooperativeVectorMatrixInfoNV = 1000491004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_extended_sparse_address_space"],
        ImpliesSets = [
            "VK_NV_extended_sparse_address_space+VK_KHR_get_physical_device_properties2",
            "VK_NV_extended_sparse_address_space+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExtendedSparseAddressSpaceFeaturesNV = 1000492000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_extended_sparse_address_space"],
        ImpliesSets = [
            "VK_NV_extended_sparse_address_space+VK_KHR_get_physical_device_properties2",
            "VK_NV_extended_sparse_address_space+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExtendedSparseAddressSpacePropertiesNV = 1000492001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mutable_descriptor_type"],
        ImpliesSets = [
            "VK_EXT_mutable_descriptor_type+VK_KHR_maintenance3",
            "VK_EXT_mutable_descriptor_type+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMutableDescriptorTypeFeaturesEXT = 1000351000,

    [NativeName("VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mutable_descriptor_type"],
        ImpliesSets = [
            "VK_EXT_mutable_descriptor_type+VK_KHR_maintenance3",
            "VK_EXT_mutable_descriptor_type+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMutableDescriptorTypeCreateInfoEXT = 1000351002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_vertex_attributes"],
        ImpliesSets = ["VK_EXT_vertex_input_dynamic_state"]
    )]
    VkStructureTypePhysicalDeviceLegacyVertexAttributesFeaturesEXT = 1000495000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_vertex_attributes"],
        ImpliesSets = ["VK_EXT_vertex_input_dynamic_state"]
    )]
    VkStructureTypePhysicalDeviceLegacyVertexAttributesPropertiesEXT = 1000495001,

    [NativeName("VK_STRUCTURE_TYPE_LAYER_SETTINGS_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VkStructureTypeLayerSettingsCreateInfoEXT = 1000496000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_builtins"],
        ImpliesSets = [
            "VK_ARM_shader_core_builtins+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_core_builtins+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderCoreBuiltinsFeaturesARM = 1000497000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_builtins"],
        ImpliesSets = [
            "VK_ARM_shader_core_builtins+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_core_builtins+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderCoreBuiltinsPropertiesARM = 1000497001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_LIBRARY_GROUP_HANDLES_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_library_group_handles"],
        ImpliesSets = ["VK_KHR_pipeline_library", "VK_KHR_ray_tracing_pipeline"]
    )]
    VkStructureTypePhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT = 1000498000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_FEATURES_EXT"
    )]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_dynamic_rendering_unused_attachments"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT = 1000499000,

    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SLEEP_MODE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    VkStructureTypeLatencySleepModeInfoNV = 1000505000,

    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SLEEP_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    VkStructureTypeLatencySleepInfoNV = 1000505001,

    [NativeName("VK_STRUCTURE_TYPE_SET_LATENCY_MARKER_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    VkStructureTypeSetLatencyMarkerInfoNV = 1000505002,

    [NativeName("VK_STRUCTURE_TYPE_GET_LATENCY_MARKER_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    VkStructureTypeGetLatencyMarkerInfoNV = 1000505003,

    [NativeName("VK_STRUCTURE_TYPE_LATENCY_TIMINGS_FRAME_REPORT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    VkStructureTypeLatencyTimingsFrameReportNV = 1000505004,

    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SUBMISSION_PRESENT_ID_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    VkStructureTypeLatencySubmissionPresentIdNV = 1000505005,

    [NativeName("VK_STRUCTURE_TYPE_OUT_OF_BAND_QUEUE_TYPE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    VkStructureTypeOutOfBandQueueTypeInfoNV = 1000505006,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_LATENCY_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    VkStructureTypeSwapchainLatencyCreateInfoNV = 1000505007,

    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SURFACE_CAPABILITIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_present_id",
            "VK_KHR_timeline_semaphore+VK_KHR_present_id2",
            "VK_VERSION_1_2+VK_KHR_present_id",
            "VK_VERSION_1_2+VK_KHR_present_id2",
        ]
    )]
    VkStructureTypeLatencySurfaceCapabilitiesNV = 1000505008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCooperativeMatrixFeaturesKHR = 1000506000,

    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCooperativeMatrixPropertiesKHR = 1000506001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCooperativeMatrixPropertiesKHR = 1000506002,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CREATE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineCreateInfoARM = 1000507000,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_CREATE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineSessionCreateInfoARM = 1000507001,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_RESOURCE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineResourceInfoARM = 1000507002,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineConstantARM = 1000507003,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_MEMORY_REQUIREMENTS_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineSessionMemoryRequirementsInfoARM = 1000507004,

    [NativeName("VK_STRUCTURE_TYPE_BIND_DATA_GRAPH_PIPELINE_SESSION_MEMORY_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeBindDataGraphPipelineSessionMemoryInfoARM = 1000507005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_FEATURES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypePhysicalDeviceDataGraphFeaturesARM = 1000507006,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SHADER_MODULE_CREATE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineShaderModuleCreateInfoARM = 1000507007,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_PROPERTY_QUERY_RESULT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelinePropertyQueryResultARM = 1000507008,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineInfoARM = 1000507009,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_COMPILER_CONTROL_CREATE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineCompilerControlCreateInfoARM = 1000507010,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENTS_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineSessionBindPointRequirementsInfoARM = 1000507011,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineSessionBindPointRequirementARM = 1000507012,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_IDENTIFIER_CREATE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineIdentifierCreateInfoARM = 1000507013,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_DISPATCH_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphPipelineDispatchInfoARM = 1000507014,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PROCESSING_ENGINE_CREATE_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDataGraphProcessingEngineCreateInfoARM = 1000507016,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeQueueFamilyDataGraphProcessingEnginePropertiesARM = 1000507017,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypeQueueFamilyDataGraphPropertiesARM = 1000507018,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_INFO_ARM"
    )]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkStructureTypePhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM = 1000507019,

    [NativeName(
        "VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_TENSOR_SEMI_STRUCTURED_SPARSITY_INFO_ARM"
    )]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph", "VK_ARM_tensors"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"],
        RequireAll = true
    )]
    VkStructureTypeDataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM = 1000507015,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_render_areas"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_render_areas+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_render_areas+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM = 1000510000,

    [NativeName("VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_render_areas"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_render_areas+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_render_areas+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM = 1000510001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_KHR_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_KHR_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceComputeShaderDerivativesFeaturesKHR = 1000201000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_KHR_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_KHR_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceComputeShaderDerivativesPropertiesKHR = 1000511000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeAv1CapabilitiesKHR = 1000512000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PICTURE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeAv1PictureInfoKHR = 1000512001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PROFILE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeAv1ProfileInfoKHR = 1000512003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeAv1SessionParametersCreateInfoKHR = 1000512004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_DPB_SLOT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeAv1DpbSlotInfoKHR = 1000512005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeAv1CapabilitiesKHR = 1000513000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeAv1SessionParametersCreateInfoKHR = 1000513001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PICTURE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeAv1PictureInfoKHR = 1000513002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_DPB_SLOT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeAv1DpbSlotInfoKHR = 1000513003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_AV1_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypePhysicalDeviceVideoEncodeAv1FeaturesKHR = 1000513004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PROFILE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeAv1ProfileInfoKHR = 1000513005,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeAv1RateControlInfoKHR = 1000513006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_LAYER_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeAv1RateControlLayerInfoKHR = 1000513007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUALITY_LEVEL_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeAv1QualityLevelPropertiesKHR = 1000513008,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeAv1SessionCreateInfoKHR = 1000513009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_GOP_REMAINING_FRAME_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeAv1GopRemainingFrameInfoKHR = 1000513010,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_DECODE_VP9_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypePhysicalDeviceVideoDecodeVp9FeaturesKHR = 1000514000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeVp9CapabilitiesKHR = 1000514001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PICTURE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeVp9PictureInfoKHR = 1000514002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PROFILE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VkStructureTypeVideoDecodeVp9ProfileInfoKHR = 1000514003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_1_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance1"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    VkStructureTypePhysicalDeviceVideoMaintenance1FeaturesKHR = 1000515000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_INLINE_QUERY_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance1"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    VkStructureTypeVideoInlineQueryInfoKHR = 1000515001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PER_STAGE_DESCRIPTOR_SET_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_per_stage_descriptor_set"],
        ImpliesSets = [
            "VK_NV_per_stage_descriptor_set+VK_KHR_maintenance6",
            "VK_NV_per_stage_descriptor_set+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePhysicalDevicePerStageDescriptorSetFeaturesNV = 1000516000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    VkStructureTypePhysicalDeviceImageProcessing2FeaturesQCOM = 1000518000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_PROPERTIES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    VkStructureTypePhysicalDeviceImageProcessing2PropertiesQCOM = 1000518001,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    VkStructureTypeSamplerBlockMatchWindowCreateInfoQCOM = 1000518002,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CUBIC_WEIGHTS_CREATE_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VkStructureTypeSamplerCubicWeightsCreateInfoQCOM = 1000519000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_WEIGHTS_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VkStructureTypePhysicalDeviceCubicWeightsFeaturesQCOM = 1000519001,

    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_CUBIC_WEIGHTS_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VkStructureTypeBlitImageCubicWeightsInfoQCOM = 1000519002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_DEGAMMA_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_ycbcr_degamma"],
        ImpliesSets = [
            "VK_QCOM_ycbcr_degamma+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_ycbcr_degamma+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceYcbcrDegammaFeaturesQCOM = 1000520000,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_ycbcr_degamma"],
        ImpliesSets = [
            "VK_QCOM_ycbcr_degamma+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_ycbcr_degamma+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM = 1000520001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_CLAMP_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_clamp"],
        ImpliesSets = [
            "VK_EXT_filter_cubic+VK_EXT_sampler_filter_minmax",
            "VK_EXT_filter_cubic+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceCubicClampFeaturesQCOM = 1000521000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_FEATURES_EXT"
    )]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT = 1000524000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFIED_IMAGE_LAYOUTS_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_unified_image_layouts"],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceUnifiedImageLayoutsFeaturesKHR = 1000527000,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_FEEDBACK_LOOP_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_unified_image_layouts+VK_EXT_attachment_feedback_loop_layout+VK_KHR_dynamic_rendering",
            "VK_KHR_unified_image_layouts+VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeAttachmentFeedbackLoopInfoEXT = 1000527001,

    [NativeName("VK_STRUCTURE_TYPE_SCREEN_BUFFER_PROPERTIES_QNX")]
    [NameAffix("Suffix", "KhronosVendor", "QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeScreenBufferPropertiesQNX = 1000529000,

    [NativeName("VK_STRUCTURE_TYPE_SCREEN_BUFFER_FORMAT_PROPERTIES_QNX")]
    [NameAffix("Suffix", "KhronosVendor", "QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeScreenBufferFormatPropertiesQNX = 1000529001,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SCREEN_BUFFER_INFO_QNX")]
    [NameAffix("Suffix", "KhronosVendor", "QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportScreenBufferInfoQNX = 1000529002,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_QNX")]
    [NameAffix("Suffix", "KhronosVendor", "QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExternalFormatQNX = 1000529003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCREEN_BUFFER_FEATURES_QNX")]
    [NameAffix("Suffix", "KhronosVendor", "QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExternalMemoryScreenBufferFeaturesQNX = 1000529004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_DRIVER_PROPERTIES_MSFT")]
    [NameAffix("Suffix", "KhronosVendor", "MSFT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MSFT_layered_driver"],
        ImpliesSets = [
            "VK_MSFT_layered_driver+VK_KHR_get_physical_device_properties2",
            "VK_MSFT_layered_driver+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceLayeredDriverPropertiesMSFT = 1000530000,

    [NativeName("VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_calibrated_timestamps"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_KHR_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCalibratedTimestampInfoKHR = 1000184000,

    [NativeName("VK_STRUCTURE_TYPE_SET_DESCRIPTOR_BUFFER_OFFSETS_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer", "VK_KHR_maintenance6"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    VkStructureTypeSetDescriptorBufferOffsetsInfoEXT = 1000545007,

    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_BUFFER_EMBEDDED_SAMPLERS_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer", "VK_KHR_maintenance6"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    VkStructureTypeBindDescriptorBufferEmbeddedSamplersInfoEXT = 1000545008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_POOL_OVERALLOCATION_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_descriptor_pool_overallocation"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VkStructureTypePhysicalDeviceDescriptorPoolOverallocationFeaturesNV = 1000546000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceTileMemoryHeapFeaturesQCOM = 1000547000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_PROPERTIES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceTileMemoryHeapPropertiesQCOM = 1000547001,

    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_REQUIREMENTS_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeTileMemoryRequirementsQCOM = 1000547002,

    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_BIND_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeTileMemoryBindInfoQCOM = 1000547003,

    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_SIZE_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap", "VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkStructureTypeTileMemorySizeInfoQCOM = 1000547004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceCopyMemoryIndirectFeaturesKHR = 1000549000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceCopyMemoryIndirectPropertiesKHR = 1000426001,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_INDIRECT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeCopyMemoryIndirectInfoKHR = 1000549002,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INDIRECT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeCopyMemoryToImageIndirectInfoKHR = 1000549003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    VkStructureTypePhysicalDeviceMemoryDecompressionFeaturesEXT = 1000427000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    VkStructureTypePhysicalDeviceMemoryDecompressionPropertiesEXT = 1000427001,

    [NativeName("VK_STRUCTURE_TYPE_DECOMPRESS_MEMORY_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    VkStructureTypeDecompressMemoryInfoEXT = 1000550002,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_SURFACE_STEREO_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    VkStructureTypeDisplaySurfaceStereoCreateInfoNV = 1000551000,

    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_STEREO_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    VkStructureTypeDisplayModeStereoPropertiesNV = 1000551001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeIntraRefreshCapabilitiesKHR = 1000552000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_INTRA_REFRESH_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeSessionIntraRefreshCreateInfoKHR = 1000552001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoEncodeIntraRefreshInfoKHR = 1000552002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_REFERENCE_INTRA_REFRESH_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypeVideoReferenceIntraRefreshInfoKHR = 1000552003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_INTRA_REFRESH_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VkStructureTypePhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR = 1000552004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeQuantizationMapCapabilitiesKHR = 1000553000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_QUANTIZATION_MAP_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoFormatQuantizationMapPropertiesKHR = 1000553001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeQuantizationMapInfoKHR = 1000553002,

    [NativeName(
        "VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_SESSION_PARAMETERS_CREATE_INFO_KHR"
    )]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeVideoEncodeQuantizationMapSessionParametersCreateInfoKHR = 1000553005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUANTIZATION_MAP_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceVideoEncodeQuantizationMapFeaturesKHR = 1000553009,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VkStructureTypeVideoEncodeH264QuantizationMapCapabilitiesKHR = 1000553003,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VkStructureTypeVideoEncodeH265QuantizationMapCapabilitiesKHR = 1000553004,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_H265_QUANTIZATION_MAP_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VkStructureTypeVideoFormatH265QuantizationMapPropertiesKHR = 1000553006,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VkStructureTypeVideoEncodeAv1QuantizationMapCapabilitiesKHR = 1000553007,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_AV1_QUANTIZATION_MAP_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VkStructureTypeVideoFormatAv1QuantizationMapPropertiesKHR = 1000553008,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAW_ACCESS_CHAINS_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_raw_access_chains"],
        ImpliesSets = [
            "VK_NV_raw_access_chains+VK_KHR_get_physical_device_properties2",
            "VK_NV_raw_access_chains+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRawAccessChainsFeaturesNV = 1000555000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DEVICE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    VkStructureTypeExternalComputeQueueDeviceCreateInfoNV = 1000556000,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_CREATE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    VkStructureTypeExternalComputeQueueCreateInfoNV = 1000556001,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DATA_PARAMS_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    VkStructureTypeExternalComputeQueueDataParamsNV = 1000556002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_COMPUTE_QUEUE_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    VkStructureTypePhysicalDeviceExternalComputeQueuePropertiesNV = 1000556003,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_RELAXED_EXTENDED_INSTRUCTION_FEATURES_KHR"
    )]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_relaxed_extended_instruction"],
        ImpliesSets = [
            "VK_KHR_shader_relaxed_extended_instruction+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_relaxed_extended_instruction+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR = 1000558000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMMAND_BUFFER_INHERITANCE_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_command_buffer_inheritance"],
        ImpliesSets = [
            "VK_NV_command_buffer_inheritance+VK_KHR_get_physical_device_properties2",
            "VK_NV_command_buffer_inheritance+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceCommandBufferInheritanceFeaturesNV = 1000559000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceMaintenance7FeaturesKHR = 1000562000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceMaintenance7PropertiesKHR = 1000562001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_LIST_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceLayeredApiPropertiesListKHR = 1000562002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceLayeredApiPropertiesKHR = 1000562003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_VULKAN_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceLayeredApiVulkanPropertiesKHR = 1000562004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT16_VECTOR_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shader_atomic_float16_vector"],
        ImpliesSets = [
            "VK_NV_shader_atomic_float16_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_shader_atomic_float16_vector+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderAtomicFloat16VectorFeaturesNV = 1000563000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_REPLICATED_COMPOSITES_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_replicated_composites"],
        ImpliesSets = [
            "VK_EXT_shader_replicated_composites+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_replicated_composites+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderReplicatedCompositesFeaturesEXT = 1000564000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT8_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_float8"],
        ImpliesSets = [
            "VK_EXT_shader_float8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_float8+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderFloat8FeaturesEXT = 1000567000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_VALIDATION_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_validation"],
        ImpliesSets = [
            "VK_NV_ray_tracing_validation+VK_KHR_get_physical_device_properties2",
            "VK_NV_ray_tracing_validation+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRayTracingValidationFeaturesNV = 1000568000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypePhysicalDeviceClusterAccelerationStructureFeaturesNV = 1000569000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypePhysicalDeviceClusterAccelerationStructurePropertiesNV = 1000569001,

    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_CLUSTERS_BOTTOM_LEVEL_INPUT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypeClusterAccelerationStructureClustersBottomLevelInputNV = 1000569002,

    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_TRIANGLE_CLUSTER_INPUT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypeClusterAccelerationStructureTriangleClusterInputNV = 1000569003,

    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_MOVE_OBJECTS_INPUT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypeClusterAccelerationStructureMoveObjectsInputNV = 1000569004,

    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_INPUT_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypeClusterAccelerationStructureInputInfoNV = 1000569005,

    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_COMMANDS_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypeClusterAccelerationStructureCommandsInfoNV = 1000569006,

    [NativeName(
        "VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CLUSTER_ACCELERATION_STRUCTURE_CREATE_INFO_NV"
    )]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypeRayTracingPipelineClusterAccelerationStructureCreateInfoNV = 1000569007,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypePhysicalDevicePartitionedAccelerationStructureFeaturesNV = 1000570000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_PROPERTIES_NV"
    )]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypePhysicalDevicePartitionedAccelerationStructurePropertiesNV = 1000570001,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_PARTITIONED_ACCELERATION_STRUCTURE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypeWriteDescriptorSetPartitionedAccelerationStructureNV = 1000570002,

    [NativeName("VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCES_INPUT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypePartitionedAccelerationStructureInstancesInputNV = 1000570003,

    [NativeName("VK_STRUCTURE_TYPE_BUILD_PARTITIONED_ACCELERATION_STRUCTURE_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypeBuildPartitionedAccelerationStructureInfoNV = 1000570004,

    [NativeName("VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_FLAGS_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkStructureTypePartitionedAccelerationStructureFlagsNV = 1000570005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceDeviceGeneratedCommandsFeaturesEXT = 1000572000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceDeviceGeneratedCommandsPropertiesEXT = 1000572001,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeGeneratedCommandsMemoryRequirementsInfoEXT = 1000572002,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeIndirectExecutionSetCreateInfoEXT = 1000572003,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeGeneratedCommandsInfoEXT = 1000572004,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeIndirectCommandsLayoutCreateInfoEXT = 1000572006,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeIndirectCommandsLayoutTokenEXT = 1000572007,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_PIPELINE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeWriteIndirectExecutionSetPipelineEXT = 1000572008,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_SHADER_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeWriteIndirectExecutionSetShaderEXT = 1000572009,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_PIPELINE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeIndirectExecutionSetPipelineInfoEXT = 1000572010,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeIndirectExecutionSetShaderInfoEXT = 1000572011,

    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_LAYOUT_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeIndirectExecutionSetShaderLayoutInfoEXT = 1000572012,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_PIPELINE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeGeneratedCommandsPipelineInfoEXT = 1000572013,

    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_SHADER_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeGeneratedCommandsShaderInfoEXT = 1000572014,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_8_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceMaintenance8FeaturesKHR = 1000574000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER_ACCESS_FLAGS_3_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypeMemoryBarrierAccessFlags3KHR = 1000574002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_FEATURES_MESA")]
    [NameAffix("Suffix", "KhronosVendor", "MESA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceImageAlignmentControlFeaturesMESA = 1000575000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_PROPERTIES_MESA")]
    [NameAffix("Suffix", "KhronosVendor", "MESA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceImageAlignmentControlPropertiesMESA = 1000575001,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_ALIGNMENT_CONTROL_CREATE_INFO_MESA")]
    [NameAffix("Suffix", "KhronosVendor", "MESA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageAlignmentControlCreateInfoMESA = 1000575002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FMA_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_fma"],
        ImpliesSets = [
            "VK_KHR_shader_fma+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_fma+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderFmaFeaturesKHR = 1000579000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_CONTROL_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDepthClampControlFeaturesEXT = 1000582000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLAMP_CONTROL_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineViewportDepthClampControlCreateInfoEXT = 1000582001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMaintenance9FeaturesKHR = 1000584000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMaintenance9PropertiesKHR = 1000584001,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_OWNERSHIP_TRANSFER_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeQueueFamilyOwnershipTransferPropertiesKHR = 1000584002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_2_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    VkStructureTypePhysicalDeviceVideoMaintenance2FeaturesKHR = 1000586000,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VkStructureTypeVideoDecodeH264InlineSessionParametersInfoKHR = 1000586001,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VkStructureTypeVideoDecodeH265InlineSessionParametersInfoKHR = 1000586002,

    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VkStructureTypeVideoDecodeAv1InlineSessionParametersInfoKHR = 1000586003,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CREATE_INFO_OHOS")]
    [NameAffix("Suffix", "KhronosVendor", "OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VkStructureTypeSurfaceCreateInfoOHOS = 1000685000,

    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_OHOS")]
    [NameAffix("Suffix", "KhronosVendor", "OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_native_buffer"])]
    VkStructureTypeNativeBufferOHOS = 1000453001,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_IMAGE_CREATE_INFO_OHOS")]
    [NameAffix("Suffix", "KhronosVendor", "OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_native_buffer"])]
    VkStructureTypeSwapchainImageCreateInfoOHOS = 1000453002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENTATION_PROPERTIES_OHOS")]
    [NameAffix("Suffix", "KhronosVendor", "OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_native_buffer"])]
    VkStructureTypePhysicalDevicePresentationPropertiesOHOS = 1000453003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HDR_VIVID_FEATURES_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceHdrVividFeaturesHUAWEI = 1000590000,

    [NativeName("VK_STRUCTURE_TYPE_HDR_VIVID_DYNAMIC_METADATA_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeHdrVividDynamicMetadataHUAWEI = 1000590001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    VkStructureTypePhysicalDeviceCooperativeMatrix2FeaturesNV = 1000593000,

    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_FLEXIBLE_DIMENSIONS_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    VkStructureTypeCooperativeMatrixFlexibleDimensionsPropertiesNV = 1000593001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    VkStructureTypePhysicalDeviceCooperativeMatrix2PropertiesNV = 1000593002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_OPACITY_MICROMAP_FEATURES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_pipeline_opacity_micromap"],
        ImpliesSets = ["VK_EXT_opacity_micromap"]
    )]
    VkStructureTypePhysicalDevicePipelineOpacityMicromapFeaturesARM = 1000596000,

    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_METAL_HANDLE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImportMemoryMetalHandleInfoEXT = 1000602000,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_METAL_HANDLE_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryMetalHandlePropertiesEXT = 1000602001,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_METAL_HANDLE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryGetMetalHandleInfoEXT = 1000602002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_clamp_zero_one"],
        ImpliesSets = [
            "VK_KHR_depth_clamp_zero_one+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_clamp_zero_one+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDepthClampZeroOneFeaturesKHR = 1000421000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_FEATURES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePerformanceCountersByRegionFeaturesARM = 1000605000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_PROPERTIES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePerformanceCountersByRegionPropertiesARM = 1000605001,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePerformanceCounterARM = 1000605002,

    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePerformanceCounterDescriptionARM = 1000605003,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_PERFORMANCE_COUNTERS_BY_REGION_BEGIN_INFO_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRenderPassPerformanceCountersByRegionBeginInfoARM = 1000605004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_ROBUSTNESS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_robustness"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_robustness+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceVertexAttributeRobustnessFeaturesEXT = 1000608000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FORMAT_PACK_FEATURES_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFormatPackFeaturesARM = 1000609000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_FEATURES_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE = 1000611000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_PROPERTIES_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE = 1000611001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_DENSITY_MAP_LAYERED_CREATE_INFO_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    VkStructureTypePipelineFragmentDensityMapLayeredCreateInfoVALVE = 1000611002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRobustness2FeaturesKHR = 1000286000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRobustness2PropertiesKHR = 1000286001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_KHR_create_renderpass2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_KHR_create_renderpass2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_VERSION_1_2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_VERSION_1_2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_KHR_create_renderpass2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_KHR_create_renderpass2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_VERSION_1_2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_VERSION_1_2+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentDensityMapOffsetFeaturesEXT = 1000425000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_KHR_create_renderpass2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_KHR_create_renderpass2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_VERSION_1_2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_VERSION_1_2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_KHR_create_renderpass2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_KHR_create_renderpass2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_VERSION_1_2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_VERSION_1_2+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentDensityMapOffsetPropertiesEXT = 1000425001,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_KHR_create_renderpass2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_KHR_create_renderpass2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_VERSION_1_2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_VERSION_1_2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_KHR_create_renderpass2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_KHR_create_renderpass2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_VERSION_1_2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_VERSION_1_2+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeRenderPassFragmentDensityMapOffsetEndInfoEXT = 1000425002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_DEVICE_MEMORY_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_zero_initialize_device_memory"],
        ImpliesSets = [
            "VK_EXT_zero_initialize_device_memory+VK_KHR_get_physical_device_properties2",
            "VK_EXT_zero_initialize_device_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT = 1000620000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    VkStructureTypePhysicalDevicePresentModeFifoLatestReadyFeaturesKHR = 1000361000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_64_BIT_INDEXING_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_64bit_indexing"],
        ImpliesSets = [
            "VK_EXT_shader_64bit_indexing+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_64bit_indexing+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShader64BitIndexingFeaturesEXT = 1000627000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_MODEL_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    VkStructureTypePhysicalDeviceDataGraphModelFeaturesQCOM = 1000629000,

    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_BUILTIN_MODEL_CREATE_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    VkStructureTypeDataGraphPipelineBuiltinModelCreateInfoQCOM = 1000629001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMaintenance10FeaturesKHR = 1000630000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMaintenance10PropertiesKHR = 1000630001,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_FLAGS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRenderingAttachmentFlagsInfoKHR = 1000630002,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_END_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRenderingEndInfoKHR = 1000619003,

    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_MODE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeResolveImageModeInfoKHR = 1000630004,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CACHE_INCREMENTAL_MODE_FEATURES_SEC")]
    [NameAffix("Suffix", "KhronosVendor", "SEC")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_pipeline_cache_incremental_mode"],
        ImpliesSets = [
            "VK_SEC_pipeline_cache_incremental_mode+VK_KHR_get_physical_device_properties2",
            "VK_SEC_pipeline_cache_incremental_mode+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePipelineCacheIncrementalModeFeaturesSEC = 1000637000,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNIFORM_BUFFER_UNSIZED_ARRAY_FEATURES_EXT"
    )]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_uniform_buffer_unsized_array"],
        ImpliesSets = [
            "VK_EXT_shader_uniform_buffer_unsized_array+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_uniform_buffer_unsized_array+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT = 1000642000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceVariablePointerFeatures =
        VkStructureTypePhysicalDeviceVariablePointersFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETER_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkStructureTypePhysicalDeviceShaderDrawParameterFeatures =
        VkStructureTypePhysicalDeviceShaderDrawParametersFeatures,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeRenderingInfoKHR = VkStructureTypeRenderingInfo,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeRenderingAttachmentInfoKHR = VkStructureTypeRenderingAttachmentInfo,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePipelineRenderingCreateInfoKHR = VkStructureTypePipelineRenderingCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceDynamicRenderingFeaturesKHR =
        VkStructureTypePhysicalDeviceDynamicRenderingFeatures,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeCommandBufferInheritanceRenderingInfoKHR =
        VkStructureTypeCommandBufferInheritanceRenderingInfo,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeRenderPassMultiviewCreateInfoKHR = VkStructureTypeRenderPassMultiviewCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMultiviewFeaturesKHR =
        VkStructureTypePhysicalDeviceMultiviewFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMultiviewPropertiesKHR =
        VkStructureTypePhysicalDeviceMultiviewProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VkStructureTypePhysicalDeviceFeatures2KHR = VkStructureTypePhysicalDeviceFeatures2,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VkStructureTypePhysicalDeviceProperties2KHR = VkStructureTypePhysicalDeviceProperties2,

    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VkStructureTypeFormatProperties2KHR = VkStructureTypeFormatProperties2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VkStructureTypeImageFormatProperties2KHR = VkStructureTypeImageFormatProperties2,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VkStructureTypePhysicalDeviceImageFormatInfo2KHR =
        VkStructureTypePhysicalDeviceImageFormatInfo2,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VkStructureTypeQueueFamilyProperties2KHR = VkStructureTypeQueueFamilyProperties2,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VkStructureTypePhysicalDeviceMemoryProperties2KHR =
        VkStructureTypePhysicalDeviceMemoryProperties2,

    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VkStructureTypeSparseImageFormatProperties2KHR = VkStructureTypeSparseImageFormatProperties2,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VkStructureTypePhysicalDeviceSparseImageFormatInfo2KHR =
        VkStructureTypePhysicalDeviceSparseImageFormatInfo2,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VkStructureTypeMemoryAllocateFlagsInfoKHR = VkStructureTypeMemoryAllocateFlagsInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VkStructureTypeDeviceGroupRenderPassBeginInfoKHR =
        VkStructureTypeDeviceGroupRenderPassBeginInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VkStructureTypeDeviceGroupCommandBufferBeginInfoKHR =
        VkStructureTypeDeviceGroupCommandBufferBeginInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VkStructureTypeDeviceGroupSubmitInfoKHR = VkStructureTypeDeviceGroupSubmitInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VkStructureTypeDeviceGroupBindSparseInfoKHR = VkStructureTypeDeviceGroupBindSparseInfo,

    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_bind_memory2", "VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"],
        RequireAll = true
    )]
    VkStructureTypeBindBufferMemoryDeviceGroupInfoKHR =
        VkStructureTypeBindBufferMemoryDeviceGroupInfo,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_bind_memory2", "VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"],
        RequireAll = true
    )]
    VkStructureTypeBindImageMemoryDeviceGroupInfoKHR =
        VkStructureTypeBindImageMemoryDeviceGroupInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceTextureCompressionAstcHdrFeaturesEXT =
        VkStructureTypePhysicalDeviceTextureCompressionAstcHdrFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineRobustnessCreateInfoEXT = VkStructureTypePipelineRobustnessCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePipelineRobustnessFeaturesEXT =
        VkStructureTypePhysicalDevicePipelineRobustnessFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePipelineRobustnessPropertiesEXT =
        VkStructureTypePhysicalDevicePipelineRobustnessProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_device_group_creation"])]
    VkStructureTypePhysicalDeviceGroupPropertiesKHR = VkStructureTypePhysicalDeviceGroupProperties,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_device_group_creation"])]
    VkStructureTypeDeviceGroupDeviceCreateInfoKHR = VkStructureTypeDeviceGroupDeviceCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExternalImageFormatInfoKHR =
        VkStructureTypePhysicalDeviceExternalImageFormatInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExternalImageFormatPropertiesKHR = VkStructureTypeExternalImageFormatProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExternalBufferInfoKHR =
        VkStructureTypePhysicalDeviceExternalBufferInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExternalBufferPropertiesKHR = VkStructureTypeExternalBufferProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceIdPropertiesKHR = VkStructureTypePhysicalDeviceIdProperties,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExternalMemoryBufferCreateInfoKHR =
        VkStructureTypeExternalMemoryBufferCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExternalMemoryImageCreateInfoKHR = VkStructureTypeExternalMemoryImageCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExportMemoryAllocateInfoKHR = VkStructureTypeExportMemoryAllocateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExternalSemaphoreInfoKHR =
        VkStructureTypePhysicalDeviceExternalSemaphoreInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExternalSemaphorePropertiesKHR = VkStructureTypeExternalSemaphoreProperties,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore_capabilities"]
    )]
    VkStructureTypeExportSemaphoreCreateInfoKHR = VkStructureTypeExportSemaphoreCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_push_descriptor"],
        ImpliesSets = [
            "VK_KHR_push_descriptor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_push_descriptor+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePushDescriptorPropertiesKHR =
        VkStructureTypePhysicalDevicePushDescriptorProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float16_int8"],
        ImpliesSets = [
            "VK_KHR_shader_float16_int8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float16_int8+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderFloat16Int8FeaturesKHR =
        VkStructureTypePhysicalDeviceShaderFloat16Int8Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float16_int8"],
        ImpliesSets = [
            "VK_KHR_shader_float16_int8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float16_int8+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFloat16Int8FeaturesKHR =
        VkStructureTypePhysicalDeviceShaderFloat16Int8Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_16bit_storage"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevice16BitStorageFeaturesKHR =
        VkStructureTypePhysicalDevice16BitStorageFeatures,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_descriptor_update_template"])]
    VkStructureTypeDescriptorUpdateTemplateCreateInfoKHR =
        VkStructureTypeDescriptorUpdateTemplateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceImagelessFramebufferFeaturesKHR =
        VkStructureTypePhysicalDeviceImagelessFramebufferFeatures,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeFramebufferAttachmentsCreateInfoKHR =
        VkStructureTypeFramebufferAttachmentsCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeFramebufferAttachmentImageInfoKHR =
        VkStructureTypeFramebufferAttachmentImageInfo,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeRenderPassAttachmentBeginInfoKHR = VkStructureTypeRenderPassAttachmentBeginInfo,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VkStructureTypeAttachmentDescription2KHR = VkStructureTypeAttachmentDescription2,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VkStructureTypeAttachmentReference2KHR = VkStructureTypeAttachmentReference2,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VkStructureTypeSubpassDescription2KHR = VkStructureTypeSubpassDescription2,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VkStructureTypeSubpassDependency2KHR = VkStructureTypeSubpassDependency2,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VkStructureTypeRenderPassCreateInfo2KHR = VkStructureTypeRenderPassCreateInfo2,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VkStructureTypeSubpassBeginInfoKHR = VkStructureTypeSubpassBeginInfo,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VkStructureTypeSubpassEndInfoKHR = VkStructureTypeSubpassEndInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceExternalFenceInfoKHR =
        VkStructureTypePhysicalDeviceExternalFenceInfo,

    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeExternalFencePropertiesKHR = VkStructureTypeExternalFenceProperties,

    [NativeName("VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence"],
        ImpliesSets = ["VK_KHR_external_fence_capabilities"]
    )]
    VkStructureTypeExportFenceCreateInfoKHR = VkStructureTypeExportFenceCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VkStructureTypePhysicalDevicePointClippingPropertiesKHR =
        VkStructureTypePhysicalDevicePointClippingProperties,

    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VkStructureTypeRenderPassInputAttachmentAspectCreateInfoKHR =
        VkStructureTypeRenderPassInputAttachmentAspectCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VkStructureTypeImageViewUsageCreateInfoKHR = VkStructureTypeImageViewUsageCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VkStructureTypePipelineTessellationDomainOriginStateCreateInfoKHR =
        VkStructureTypePipelineTessellationDomainOriginStateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_variable_pointers"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceVariablePointersFeaturesKHR =
        VkStructureTypePhysicalDeviceVariablePointersFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_variable_pointers"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceVariablePointerFeaturesKHR =
        VkStructureTypePhysicalDeviceVariablePointersFeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dedicated_allocation"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_memory_requirements2",
            "VK_KHR_dedicated_allocation+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryDedicatedRequirementsKHR = VkStructureTypeMemoryDedicatedRequirements,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dedicated_allocation"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_memory_requirements2",
            "VK_KHR_dedicated_allocation+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryDedicatedAllocateInfoKHR = VkStructureTypeMemoryDedicatedAllocateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceSamplerFilterMinmaxPropertiesEXT =
        VkStructureTypePhysicalDeviceSamplerFilterMinmaxProperties,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSamplerReductionModeCreateInfoEXT =
        VkStructureTypeSamplerReductionModeCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceInlineUniformBlockFeaturesEXT =
        VkStructureTypePhysicalDeviceInlineUniformBlockFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceInlineUniformBlockPropertiesEXT =
        VkStructureTypePhysicalDeviceInlineUniformBlockProperties,

    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeWriteDescriptorSetInlineUniformBlockEXT =
        VkStructureTypeWriteDescriptorSetInlineUniformBlock,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDescriptorPoolInlineUniformBlockCreateInfoEXT =
        VkStructureTypeDescriptorPoolInlineUniformBlockCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    VkStructureTypeBufferMemoryRequirementsInfo2KHR = VkStructureTypeBufferMemoryRequirementsInfo2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    VkStructureTypeImageMemoryRequirementsInfo2KHR = VkStructureTypeImageMemoryRequirementsInfo2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    VkStructureTypeImageSparseMemoryRequirementsInfo2KHR =
        VkStructureTypeImageSparseMemoryRequirementsInfo2,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    VkStructureTypeMemoryRequirements2KHR = VkStructureTypeMemoryRequirements2,

    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    VkStructureTypeSparseImageMemoryRequirements2KHR =
        VkStructureTypeSparseImageMemoryRequirements2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_image_format_list"])]
    VkStructureTypeImageFormatListCreateInfoKHR = VkStructureTypeImageFormatListCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_dynamic_rendering",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeAttachmentSampleCountInfoNV = VkStructureTypeAttachmentSampleCountInfoAMD,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSamplerYcbcrConversionCreateInfoKHR =
        VkStructureTypeSamplerYcbcrConversionCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSamplerYcbcrConversionInfoKHR = VkStructureTypeSamplerYcbcrConversionInfo,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBindImagePlaneMemoryInfoKHR = VkStructureTypeBindImagePlaneMemoryInfo,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImagePlaneMemoryRequirementsInfoKHR =
        VkStructureTypeImagePlaneMemoryRequirementsInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceSamplerYcbcrConversionFeaturesKHR =
        VkStructureTypePhysicalDeviceSamplerYcbcrConversionFeatures,

    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSamplerYcbcrConversionImageFormatPropertiesKHR =
        VkStructureTypeSamplerYcbcrConversionImageFormatProperties,

    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_bind_memory2"])]
    VkStructureTypeBindBufferMemoryInfoKHR = VkStructureTypeBindBufferMemoryInfo,

    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_bind_memory2"])]
    VkStructureTypeBindImageMemoryInfoKHR = VkStructureTypeBindImageMemoryInfo,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDescriptorSetLayoutBindingFlagsCreateInfoEXT =
        VkStructureTypeDescriptorSetLayoutBindingFlagsCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDescriptorIndexingFeaturesEXT =
        VkStructureTypePhysicalDeviceDescriptorIndexingFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDescriptorIndexingPropertiesEXT =
        VkStructureTypePhysicalDeviceDescriptorIndexingProperties,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDescriptorSetVariableDescriptorCountAllocateInfoEXT =
        VkStructureTypeDescriptorSetVariableDescriptorCountAllocateInfo,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDescriptorSetVariableDescriptorCountLayoutSupportEXT =
        VkStructureTypeDescriptorSetVariableDescriptorCountLayoutSupport,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance3"],
        ImpliesSets = [
            "VK_KHR_maintenance3+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance3+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceMaintenance3PropertiesKHR =
        VkStructureTypePhysicalDeviceMaintenance3Properties,

    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance3"],
        ImpliesSets = [
            "VK_KHR_maintenance3+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance3+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDescriptorSetLayoutSupportKHR = VkStructureTypeDescriptorSetLayoutSupport,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    VkStructureTypeDeviceQueueGlobalPriorityCreateInfoEXT =
        VkStructureTypeDeviceQueueGlobalPriorityCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_extended_types"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VkStructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR =
        VkStructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_8bit_storage"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevice8BitStorageFeaturesKHR =
        VkStructureTypePhysicalDevice8BitStorageFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_atomic_int64"],
        ImpliesSets = [
            "VK_KHR_shader_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderAtomicInt64FeaturesKHR =
        VkStructureTypePhysicalDeviceShaderAtomicInt64Features,

    [NativeName("VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_calibrated_timestamps"],
        ImpliesSets = [
            "VK_EXT_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_EXT_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCalibratedTimestampInfoEXT = VkStructureTypeCalibratedTimestampInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDeviceQueueGlobalPriorityCreateInfoKHR =
        VkStructureTypeDeviceQueueGlobalPriorityCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceGlobalPriorityQueryFeaturesKHR =
        VkStructureTypePhysicalDeviceGlobalPriorityQueryFeatures,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeQueueFamilyGlobalPriorityPropertiesKHR =
        VkStructureTypeQueueFamilyGlobalPriorityProperties,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineVertexInputDivisorStateCreateInfoEXT =
        VkStructureTypePipelineVertexInputDivisorStateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceVertexAttributeDivisorFeaturesEXT =
        VkStructureTypePhysicalDeviceVertexAttributeDivisorFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    VkStructureTypePipelineCreationFeedbackCreateInfoEXT =
        VkStructureTypePipelineCreationFeedbackCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDriverPropertiesKHR =
        VkStructureTypePhysicalDeviceDriverProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float_controls"],
        ImpliesSets = [
            "VK_KHR_shader_float_controls+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float_controls+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFloatControlsPropertiesKHR =
        VkStructureTypePhysicalDeviceFloatControlsProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceDepthStencilResolvePropertiesKHR =
        VkStructureTypePhysicalDeviceDepthStencilResolveProperties,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeSubpassDescriptionDepthStencilResolveKHR =
        VkStructureTypeSubpassDescriptionDepthStencilResolve,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_NV_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_NV_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceComputeShaderDerivativesFeaturesNV =
        VkStructureTypePhysicalDeviceComputeShaderDerivativesFeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_NV_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_NV_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentShaderBarycentricFeaturesNV =
        VkStructureTypePhysicalDeviceFragmentShaderBarycentricFeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceTimelineSemaphoreFeaturesKHR =
        VkStructureTypePhysicalDeviceTimelineSemaphoreFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceTimelineSemaphorePropertiesKHR =
        VkStructureTypePhysicalDeviceTimelineSemaphoreProperties,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSemaphoreTypeCreateInfoKHR = VkStructureTypeSemaphoreTypeCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeTimelineSemaphoreSubmitInfoKHR = VkStructureTypeTimelineSemaphoreSubmitInfo,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSemaphoreWaitInfoKHR = VkStructureTypeSemaphoreWaitInfo,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSemaphoreSignalInfoKHR = VkStructureTypeSemaphoreSignalInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vulkan_memory_model"],
        ImpliesSets = [
            "VK_KHR_vulkan_memory_model+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vulkan_memory_model+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceVulkanMemoryModelFeaturesKHR =
        VkStructureTypePhysicalDeviceVulkanMemoryModelFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_terminate_invocation"],
        ImpliesSets = [
            "VK_KHR_shader_terminate_invocation+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_terminate_invocation+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderTerminateInvocationFeaturesKHR =
        VkStructureTypePhysicalDeviceShaderTerminateInvocationFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_scalar_block_layout"],
        ImpliesSets = [
            "VK_EXT_scalar_block_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_scalar_block_layout+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceScalarBlockLayoutFeaturesEXT =
        VkStructureTypePhysicalDeviceScalarBlockLayoutFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VkStructureTypePhysicalDeviceSubgroupSizeControlPropertiesEXT =
        VkStructureTypePhysicalDeviceSubgroupSizeControlProperties,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VkStructureTypePipelineShaderStageRequiredSubgroupSizeCreateInfoEXT =
        VkStructureTypePipelineShaderStageRequiredSubgroupSizeCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VkStructureTypePhysicalDeviceSubgroupSizeControlFeaturesEXT =
        VkStructureTypePhysicalDeviceSubgroupSizeControlFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceDynamicRenderingLocalReadFeaturesKHR =
        VkStructureTypePhysicalDeviceDynamicRenderingLocalReadFeatures,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeRenderingAttachmentLocationInfoKHR =
        VkStructureTypeRenderingAttachmentLocationInfo,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeRenderingInputAttachmentIndexInfoKHR =
        VkStructureTypeRenderingInputAttachmentIndexInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR =
        VkStructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeatures,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAttachmentReferenceStencilLayoutKHR =
        VkStructureTypeAttachmentReferenceStencilLayout,

    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypeAttachmentDescriptionStencilLayoutKHR =
        VkStructureTypeAttachmentDescriptionStencilLayout,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceBufferAddressFeaturesEXT =
        VkStructureTypePhysicalDeviceBufferDeviceAddressFeaturesEXT,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferDeviceAddressInfoEXT = VkStructureTypeBufferDeviceAddressInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VkStructureTypePhysicalDeviceToolPropertiesEXT = VkStructureTypePhysicalDeviceToolProperties,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_separate_stencil_usage"])]
    VkStructureTypeImageStencilUsageCreateInfoEXT = VkStructureTypeImageStencilUsageCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_uniform_buffer_standard_layout"],
        ImpliesSets = [
            "VK_KHR_uniform_buffer_standard_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_uniform_buffer_standard_layout+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceUniformBufferStandardLayoutFeaturesKHR =
        VkStructureTypePhysicalDeviceUniformBufferStandardLayoutFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceBufferDeviceAddressFeaturesKHR =
        VkStructureTypePhysicalDeviceBufferDeviceAddressFeatures,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferDeviceAddressInfoKHR = VkStructureTypeBufferDeviceAddressInfo,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferOpaqueCaptureAddressCreateInfoKHR =
        VkStructureTypeBufferOpaqueCaptureAddressCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryOpaqueCaptureAddressAllocateInfoKHR =
        VkStructureTypeMemoryOpaqueCaptureAddressAllocateInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDeviceMemoryOpaqueCaptureAddressInfoKHR =
        VkStructureTypeDeviceMemoryOpaqueCaptureAddressInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceLineRasterizationFeaturesEXT =
        VkStructureTypePhysicalDeviceLineRasterizationFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineRasterizationLineStateCreateInfoEXT =
        VkStructureTypePipelineRasterizationLineStateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceLineRasterizationPropertiesEXT =
        VkStructureTypePhysicalDeviceLineRasterizationProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_query_reset"],
        ImpliesSets = [
            "VK_EXT_host_query_reset+VK_KHR_get_physical_device_properties2",
            "VK_EXT_host_query_reset+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceHostQueryResetFeaturesEXT =
        VkStructureTypePhysicalDeviceHostQueryResetFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_index_type_uint8"],
        ImpliesSets = [
            "VK_EXT_index_type_uint8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_index_type_uint8+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceIndexTypeUint8FeaturesEXT =
        VkStructureTypePhysicalDeviceIndexTypeUint8Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceHostImageCopyFeaturesEXT =
        VkStructureTypePhysicalDeviceHostImageCopyFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypePhysicalDeviceHostImageCopyPropertiesEXT =
        VkStructureTypePhysicalDeviceHostImageCopyProperties,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeMemoryToImageCopyEXT = VkStructureTypeMemoryToImageCopy,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeImageToMemoryCopyEXT = VkStructureTypeImageToMemoryCopy,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeCopyImageToMemoryInfoEXT = VkStructureTypeCopyImageToMemoryInfo,

    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeCopyMemoryToImageInfoEXT = VkStructureTypeCopyMemoryToImageInfo,

    [NativeName("VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeHostImageLayoutTransitionInfoEXT = VkStructureTypeHostImageLayoutTransitionInfo,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeCopyImageToImageInfoEXT = VkStructureTypeCopyImageToImageInfo,

    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeSubresourceHostMemcpySizeEXT = VkStructureTypeSubresourceHostMemcpySize,

    [NativeName("VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeHostImageCopyDevicePerformanceQueryEXT =
        VkStructureTypeHostImageCopyDevicePerformanceQuery,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_map_memory2"])]
    VkStructureTypeMemoryMapInfoKHR = VkStructureTypeMemoryMapInfo,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_map_memory2"])]
    VkStructureTypeMemoryUnmapInfoKHR = VkStructureTypeMemoryUnmapInfo,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    VkStructureTypeSurfacePresentModeEXT = VkStructureTypeSurfacePresentModeKHR,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    VkStructureTypeSurfacePresentScalingCapabilitiesEXT =
        VkStructureTypeSurfacePresentScalingCapabilitiesKHR,

    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    VkStructureTypeSurfacePresentModeCompatibilityEXT =
        VkStructureTypeSurfacePresentModeCompatibilityKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceSwapchainMaintenance1FeaturesEXT =
        VkStructureTypePhysicalDeviceSwapchainMaintenance1FeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSwapchainPresentFenceInfoEXT = VkStructureTypeSwapchainPresentFenceInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSwapchainPresentModesCreateInfoEXT =
        VkStructureTypeSwapchainPresentModesCreateInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSwapchainPresentModeInfoEXT = VkStructureTypeSwapchainPresentModeInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSwapchainPresentScalingCreateInfoEXT =
        VkStructureTypeSwapchainPresentScalingCreateInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeReleaseSwapchainImagesInfoEXT = VkStructureTypeReleaseSwapchainImagesInfoKHR,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT"
    )]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_demote_to_helper_invocation"],
        ImpliesSets = [
            "VK_EXT_shader_demote_to_helper_invocation+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_demote_to_helper_invocation+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT =
        VkStructureTypePhysicalDeviceShaderDemoteToHelperInvocationFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_integer_dot_product"],
        ImpliesSets = [
            "VK_KHR_shader_integer_dot_product+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_integer_dot_product+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderIntegerDotProductFeaturesKHR =
        VkStructureTypePhysicalDeviceShaderIntegerDotProductFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_integer_dot_product"],
        ImpliesSets = [
            "VK_KHR_shader_integer_dot_product+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_integer_dot_product+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderIntegerDotProductPropertiesKHR =
        VkStructureTypePhysicalDeviceShaderIntegerDotProductProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texel_buffer_alignment"],
        ImpliesSets = [
            "VK_EXT_texel_buffer_alignment+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texel_buffer_alignment+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceTexelBufferAlignmentPropertiesEXT =
        VkStructureTypePhysicalDeviceTexelBufferAlignmentProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_robustness2"],
        ImpliesSets = [
            "VK_EXT_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_robustness2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRobustness2FeaturesEXT =
        VkStructureTypePhysicalDeviceRobustness2FeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_robustness2"],
        ImpliesSets = [
            "VK_EXT_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_robustness2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRobustness2PropertiesEXT =
        VkStructureTypePhysicalDeviceRobustness2PropertiesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePrivateDataFeaturesEXT =
        VkStructureTypePhysicalDevicePrivateDataFeatures,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDevicePrivateDataCreateInfoEXT = VkStructureTypeDevicePrivateDataCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePrivateDataSlotCreateInfoEXT = VkStructureTypePrivateDataSlotCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_creation_cache_control"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePipelineCreationCacheControlFeaturesEXT =
        VkStructureTypePhysicalDevicePipelineCreationCacheControlFeatures,

    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeMemoryBarrier2KHR = VkStructureTypeMemoryBarrier2,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferMemoryBarrier2KHR = VkStructureTypeBufferMemoryBarrier2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageMemoryBarrier2KHR = VkStructureTypeImageMemoryBarrier2,

    [NativeName("VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeDependencyInfoKHR = VkStructureTypeDependencyInfo,

    [NativeName("VK_STRUCTURE_TYPE_SUBMIT_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSubmitInfo2KHR = VkStructureTypeSubmitInfo2,

    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSemaphoreSubmitInfoKHR = VkStructureTypeSemaphoreSubmitInfo,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCommandBufferSubmitInfoKHR = VkStructureTypeCommandBufferSubmitInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceSynchronization2FeaturesKHR =
        VkStructureTypePhysicalDeviceSynchronization2Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_zero_initialize_workgroup_memory"],
        ImpliesSets = [
            "VK_KHR_zero_initialize_workgroup_memory+VK_KHR_get_physical_device_properties2",
            "VK_KHR_zero_initialize_workgroup_memory+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR =
        VkStructureTypePhysicalDeviceZeroInitializeWorkgroupMemoryFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_robustness"],
        ImpliesSets = [
            "VK_EXT_image_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_robustness+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceImageRobustnessFeaturesEXT =
        VkStructureTypePhysicalDeviceImageRobustnessFeatures,

    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCopyBufferInfo2KHR = VkStructureTypeCopyBufferInfo2,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCopyImageInfo2KHR = VkStructureTypeCopyImageInfo2,

    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCopyBufferToImageInfo2KHR = VkStructureTypeCopyBufferToImageInfo2,

    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeCopyImageToBufferInfo2KHR = VkStructureTypeCopyImageToBufferInfo2,

    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBlitImageInfo2KHR = VkStructureTypeBlitImageInfo2,

    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeResolveImageInfo2KHR = VkStructureTypeResolveImageInfo2,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferCopy2KHR = VkStructureTypeBufferCopy2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageCopy2KHR = VkStructureTypeImageCopy2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageBlit2KHR = VkStructureTypeImageBlit2,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeBufferImageCopy2KHR = VkStructureTypeBufferImageCopy2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageResolve2KHR = VkStructureTypeImageResolve2,

    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSubresourceLayout2EXT = VkStructureTypeSubresourceLayout2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeImageSubresource2EXT = VkStructureTypeImageSubresource2,

    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_ARM"
    )]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM =
        VkStructureTypePhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_mutable_descriptor_type"],
        ImpliesSets = ["VK_KHR_maintenance3"]
    )]
    VkStructureTypePhysicalDeviceMutableDescriptorTypeFeaturesVALVE =
        VkStructureTypePhysicalDeviceMutableDescriptorTypeFeaturesEXT,

    [NativeName("VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_mutable_descriptor_type"],
        ImpliesSets = ["VK_KHR_maintenance3"]
    )]
    VkStructureTypeMutableDescriptorTypeCreateInfoVALVE =
        VkStructureTypeMutableDescriptorTypeCreateInfoEXT,

    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_format_feature_flags2"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeFormatProperties3KHR = VkStructureTypeFormatProperties3,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    VkStructureTypePhysicalDevicePresentModeFifoLatestReadyFeaturesEXT =
        VkStructureTypePhysicalDevicePresentModeFifoLatestReadyFeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineInfoEXT = VkStructureTypePipelineInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_global_priority_query"],
        ImpliesSets = [
            "VK_EXT_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_global_priority+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceGlobalPriorityQueryFeaturesEXT =
        VkStructureTypePhysicalDeviceGlobalPriorityQueryFeatures,

    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_global_priority_query"],
        ImpliesSets = [
            "VK_EXT_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_global_priority+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeQueueFamilyGlobalPriorityPropertiesEXT =
        VkStructureTypeQueueFamilyGlobalPriorityProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceMaintenance4FeaturesKHR =
        VkStructureTypePhysicalDeviceMaintenance4Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceMaintenance4PropertiesKHR =
        VkStructureTypePhysicalDeviceMaintenance4Properties,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypeDeviceBufferMemoryRequirementsKHR =
        VkStructureTypeDeviceBufferMemoryRequirements,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypeDeviceImageMemoryRequirementsKHR = VkStructureTypeDeviceImageMemoryRequirements,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_rotate"],
        ImpliesSets = [
            "VK_KHR_shader_subgroup_rotate+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_subgroup_rotate+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderSubgroupRotateFeaturesKHR =
        VkStructureTypePhysicalDeviceShaderSubgroupRotateFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_zero_one"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_zero_one+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_zero_one+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceDepthClampZeroOneFeaturesEXT =
        VkStructureTypePhysicalDeviceDepthClampZeroOneFeaturesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM =
        VkStructureTypePhysicalDeviceFragmentDensityMapOffsetFeaturesEXT,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM =
        VkStructureTypePhysicalDeviceFragmentDensityMapOffsetPropertiesEXT,

    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypeSubpassFragmentDensityMapOffsetEndInfoQCOM =
        VkStructureTypeRenderPassFragmentDensityMapOffsetEndInfoEXT,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceCopyMemoryIndirectPropertiesNV =
        VkStructureTypePhysicalDeviceCopyMemoryIndirectPropertiesKHR,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceMemoryDecompressionFeaturesNV =
        VkStructureTypePhysicalDeviceMemoryDecompressionFeaturesEXT,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkStructureTypePhysicalDeviceMemoryDecompressionPropertiesNV =
        VkStructureTypePhysicalDeviceMemoryDecompressionPropertiesEXT,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_protected_access"],
        ImpliesSets = [
            "VK_EXT_pipeline_protected_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_protected_access+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDevicePipelineProtectedAccessFeaturesEXT =
        VkStructureTypePhysicalDevicePipelineProtectedAccessFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VkStructureTypePhysicalDeviceMaintenance5FeaturesKHR =
        VkStructureTypePhysicalDeviceMaintenance5Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VkStructureTypePhysicalDeviceMaintenance5PropertiesKHR =
        VkStructureTypePhysicalDeviceMaintenance5Properties,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_AREA_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VkStructureTypeRenderingAreaInfoKHR = VkStructureTypeRenderingAreaInfo,

    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VkStructureTypeDeviceImageSubresourceInfoKHR = VkStructureTypeDeviceImageSubresourceInfo,

    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VkStructureTypeSubresourceLayout2KHR = VkStructureTypeSubresourceLayout2,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VkStructureTypeImageSubresource2KHR = VkStructureTypeImageSubresource2,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VkStructureTypePipelineCreateFlags2CreateInfoKHR =
        VkStructureTypePipelineCreateFlags2CreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VkStructureTypeBufferUsageFlags2CreateInfoKHR = VkStructureTypeBufferUsageFlags2CreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_SHADER_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeShaderRequiredSubgroupSizeCreateInfoEXT =
        VkStructureTypePipelineShaderStageRequiredSubgroupSizeCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceVertexAttributeDivisorPropertiesKHR =
        VkStructureTypePhysicalDeviceVertexAttributeDivisorProperties,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineVertexInputDivisorStateCreateInfoKHR =
        VkStructureTypePipelineVertexInputDivisorStateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceVertexAttributeDivisorFeaturesKHR =
        VkStructureTypePhysicalDeviceVertexAttributeDivisorFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float_controls2"],
        ImpliesSets = ["VK_KHR_shader_float_controls", "VK_VERSION_1_1"]
    )]
    VkStructureTypePhysicalDeviceShaderFloatControls2FeaturesKHR =
        VkStructureTypePhysicalDeviceShaderFloatControls2Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_index_type_uint8"],
        ImpliesSets = [
            "VK_KHR_index_type_uint8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_index_type_uint8+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceIndexTypeUint8FeaturesKHR =
        VkStructureTypePhysicalDeviceIndexTypeUint8Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceLineRasterizationFeaturesKHR =
        VkStructureTypePhysicalDeviceLineRasterizationFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePipelineRasterizationLineStateCreateInfoKHR =
        VkStructureTypePipelineRasterizationLineStateCreateInfo,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceLineRasterizationPropertiesKHR =
        VkStructureTypePhysicalDeviceLineRasterizationProperties,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_expect_assume"],
        ImpliesSets = [
            "VK_KHR_shader_expect_assume+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_expect_assume+VK_VERSION_1_1",
        ]
    )]
    VkStructureTypePhysicalDeviceShaderExpectAssumeFeaturesKHR =
        VkStructureTypePhysicalDeviceShaderExpectAssumeFeatures,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceMaintenance6FeaturesKHR =
        VkStructureTypePhysicalDeviceMaintenance6Features,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePhysicalDeviceMaintenance6PropertiesKHR =
        VkStructureTypePhysicalDeviceMaintenance6Properties,

    [NativeName("VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypeBindMemoryStatusKHR = VkStructureTypeBindMemoryStatus,

    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypeBindDescriptorSetsInfoKHR = VkStructureTypeBindDescriptorSetsInfo,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkStructureTypePushConstantsInfoKHR = VkStructureTypePushConstantsInfo,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance6", "VK_KHR_push_descriptor"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    VkStructureTypePushDescriptorSetInfoKHR = VkStructureTypePushDescriptorSetInfo,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance6", "VK_KHR_push_descriptor"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    VkStructureTypePushDescriptorSetWithTemplateInfoKHR =
        VkStructureTypePushDescriptorSetWithTemplateInfo,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_END_INFO_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_KHR_create_renderpass2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_KHR_create_renderpass2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_VERSION_1_2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2+VK_VERSION_1_2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_KHR_create_renderpass2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_KHR_create_renderpass2+VK_VERSION_1_3",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_VERSION_1_2+VK_KHR_dynamic_rendering",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1+VK_VERSION_1_2+VK_VERSION_1_3",
        ]
    )]
    VkStructureTypeRenderingEndInfoEXT = VkStructureTypeRenderingEndInfoKHR,

    [NativeName("VK_STRUCTURE_TYPE_MAX_ENUM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkStructureTypeMaxEnum = 0x7FFFFFFF,
}
