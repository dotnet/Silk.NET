// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkStructureType")]
[SupportedApiProfile("vulkan")]
public enum StructureType : uint
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
    ApplicationInfo = 0,

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
    InstanceCreateInfo = 1,

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
    DeviceQueueCreateInfo = 2,

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
    DeviceCreateInfo = 3,

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
    SubmitInfo = 4,

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
    MemoryAllocateInfo = 5,

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
    MappedMemoryRange = 6,

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
    BindSparseInfo = 7,

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
    FenceCreateInfo = 8,

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
    SemaphoreCreateInfo = 9,

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
    EventCreateInfo = 10,

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
    QueryPoolCreateInfo = 11,

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
    BufferCreateInfo = 12,

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
    BufferViewCreateInfo = 13,

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
    ImageCreateInfo = 14,

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
    ImageViewCreateInfo = 15,

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
    ShaderModuleCreateInfo = 16,

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
    PipelineCacheCreateInfo = 17,

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
    PipelineShaderStageCreateInfo = 18,

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
    PipelineVertexInputStateCreateInfo = 19,

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
    PipelineInputAssemblyStateCreateInfo = 20,

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
    PipelineTessellationStateCreateInfo = 21,

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
    PipelineViewportStateCreateInfo = 22,

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
    PipelineRasterizationStateCreateInfo = 23,

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
    PipelineMultisampleStateCreateInfo = 24,

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
    PipelineDepthStencilStateCreateInfo = 25,

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
    PipelineColorBlendStateCreateInfo = 26,

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
    PipelineDynamicStateCreateInfo = 27,

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
    GraphicsPipelineCreateInfo = 28,

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
    ComputePipelineCreateInfo = 29,

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
    PipelineLayoutCreateInfo = 30,

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
    SamplerCreateInfo = 31,

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
    DescriptorSetLayoutCreateInfo = 32,

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
    DescriptorPoolCreateInfo = 33,

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
    DescriptorSetAllocateInfo = 34,

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
    WriteDescriptorSet = 35,

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
    CopyDescriptorSet = 36,

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
    FramebufferCreateInfo = 37,

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
    RenderPassCreateInfo = 38,

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
    CommandPoolCreateInfo = 39,

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
    CommandBufferAllocateInfo = 40,

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
    CommandBufferInheritanceInfo = 41,

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
    CommandBufferBeginInfo = 42,

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
    RenderPassBeginInfo = 43,

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
    BufferMemoryBarrier = 44,

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
    ImageMemoryBarrier = 45,

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
    MemoryBarrier = 46,

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
    LoaderInstanceCreateInfo = 47,

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
    LoaderDeviceCreateInfo = 48,

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
    BindBufferMemoryInfo = 1000157000,

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
    BindImageMemoryInfo = 1000157001,

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
    MemoryDedicatedRequirements = 1000127000,

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
    MemoryDedicatedAllocateInfo = 1000127001,

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
    MemoryAllocateFlagsInfo = 1000060000,

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
    DeviceGroupCommandBufferBeginInfo = 1000060004,

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
    DeviceGroupSubmitInfo = 1000060005,

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
    DeviceGroupBindSparseInfo = 1000060006,

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
    BindBufferMemoryDeviceGroupInfo = 1000060013,

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
    BindImageMemoryDeviceGroupInfo = 1000060014,

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
    PhysicalDeviceGroupProperties = 1000070000,

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
    DeviceGroupDeviceCreateInfo = 1000070001,

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
    BufferMemoryRequirementsInfo2 = 1000146000,

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
    ImageMemoryRequirementsInfo2 = 1000146001,

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
    ImageSparseMemoryRequirementsInfo2 = 1000146002,

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
    MemoryRequirements2 = 1000146003,

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
    SparseImageMemoryRequirements2 = 1000146004,

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
    PhysicalDeviceFeatures2 = 1000059000,

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
    PhysicalDeviceProperties2 = 1000059001,

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
    FormatProperties2 = 1000059002,

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
    ImageFormatProperties2 = 1000059003,

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
    PhysicalDeviceImageFormatInfo2 = 1000059004,

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
    QueueFamilyProperties2 = 1000059005,

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
    PhysicalDeviceMemoryProperties2 = 1000059006,

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
    SparseImageFormatProperties2 = 1000059007,

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
    PhysicalDeviceSparseImageFormatInfo2 = 1000059008,

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
    ImageViewUsageCreateInfo = 1000117002,

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
    ProtectedSubmitInfo = 1000145000,

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
    PhysicalDeviceProtectedMemoryFeatures = 1000145001,

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
    PhysicalDeviceProtectedMemoryProperties = 1000145002,

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
    DeviceQueueInfo2 = 1000145003,

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
    PhysicalDeviceExternalImageFormatInfo = 1000071000,

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
    ExternalImageFormatProperties = 1000071001,

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
    PhysicalDeviceExternalBufferInfo = 1000071002,

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
    ExternalBufferProperties = 1000071003,

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
    PhysicalDeviceIdProperties = 1000071004,

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
    ExternalMemoryBufferCreateInfo = 1000072000,

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
    ExternalMemoryImageCreateInfo = 1000072001,

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
    ExportMemoryAllocateInfo = 1000072002,

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
    PhysicalDeviceExternalFenceInfo = 1000112000,

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
    ExternalFenceProperties = 1000112001,

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
    ExportFenceCreateInfo = 1000113000,

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
    ExportSemaphoreCreateInfo = 1000077000,

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
    PhysicalDeviceExternalSemaphoreInfo = 1000076000,

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
    ExternalSemaphoreProperties = 1000076001,

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
    PhysicalDeviceSubgroupProperties = 1000094000,

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
    PhysicalDevice16BitStorageFeatures = 1000083000,

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
    PhysicalDeviceVariablePointersFeatures = 1000120000,

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
    DescriptorUpdateTemplateCreateInfo = 1000085000,

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
    PhysicalDeviceMaintenance3Properties = 1000168000,

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
    DescriptorSetLayoutSupport = 1000168001,

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
    SamplerYcbcrConversionCreateInfo = 1000156000,

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
    SamplerYcbcrConversionInfo = 1000156001,

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
    BindImagePlaneMemoryInfo = 1000156002,

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
    ImagePlaneMemoryRequirementsInfo = 1000156003,

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
    PhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,

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
    SamplerYcbcrConversionImageFormatProperties = 1000156005,

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
    DeviceGroupRenderPassBeginInfo = 1000060003,

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
    PhysicalDevicePointClippingProperties = 1000117000,

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
    RenderPassInputAttachmentAspectCreateInfo = 1000117001,

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
    PipelineTessellationDomainOriginStateCreateInfo = 1000117003,

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
    RenderPassMultiviewCreateInfo = 1000053000,

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
    PhysicalDeviceMultiviewFeatures = 1000053001,

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
    PhysicalDeviceMultiviewProperties = 1000053002,

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
    PhysicalDeviceShaderDrawParametersFeatures = 1000063000,

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
    PhysicalDeviceVulkan1X1Features = 49,

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
    PhysicalDeviceVulkan1X1Properties = 50,

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
    PhysicalDeviceVulkan1X2Features = 51,

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
    PhysicalDeviceVulkan1X2Properties = 52,

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
    ImageFormatListCreateInfo = 1000147000,

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
    PhysicalDeviceDriverProperties = 1000196000,

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
    PhysicalDeviceVulkanMemoryModelFeatures = 1000211000,

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
    PhysicalDeviceHostQueryResetFeatures = 1000261000,

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
    PhysicalDeviceTimelineSemaphoreFeatures = 1000207000,

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
    PhysicalDeviceTimelineSemaphoreProperties = 1000207001,

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
    SemaphoreTypeCreateInfo = 1000207002,

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
    TimelineSemaphoreSubmitInfo = 1000207003,

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
    SemaphoreWaitInfo = 1000207004,

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
    SemaphoreSignalInfo = 1000207005,

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
    PhysicalDeviceBufferDeviceAddressFeatures = 1000257000,

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
    BufferDeviceAddressInfo = 1000244001,

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
    BufferOpaqueCaptureAddressCreateInfo = 1000257002,

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
    MemoryOpaqueCaptureAddressAllocateInfo = 1000257003,

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
    DeviceMemoryOpaqueCaptureAddressInfo = 1000257004,

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
    PhysicalDevice8BitStorageFeatures = 1000177000,

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
    PhysicalDeviceShaderAtomicInt64Features = 1000180000,

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
    PhysicalDeviceShaderFloat16Int8Features = 1000082000,

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
    PhysicalDeviceFloatControlsProperties = 1000197000,

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
    DescriptorSetLayoutBindingFlagsCreateInfo = 1000161000,

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
    PhysicalDeviceDescriptorIndexingFeatures = 1000161001,

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
    PhysicalDeviceDescriptorIndexingProperties = 1000161002,

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
    DescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,

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
    DescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,

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
    PhysicalDeviceScalarBlockLayoutFeatures = 1000221000,

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
    PhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,

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
    SamplerReductionModeCreateInfo = 1000130001,

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
    PhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,

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
    PhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,

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
    AttachmentDescription2 = 1000109000,

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
    AttachmentReference2 = 1000109001,

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
    SubpassDescription2 = 1000109002,

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
    SubpassDependency2 = 1000109003,

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
    RenderPassCreateInfo2 = 1000109004,

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
    SubpassBeginInfo = 1000109005,

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
    SubpassEndInfo = 1000109006,

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
    PhysicalDeviceDepthStencilResolveProperties = 1000199000,

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
    SubpassDescriptionDepthStencilResolve = 1000199001,

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
    ImageStencilUsageCreateInfo = 1000246000,

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
    PhysicalDeviceImagelessFramebufferFeatures = 1000108000,

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
    FramebufferAttachmentsCreateInfo = 1000108001,

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
    FramebufferAttachmentImageInfo = 1000108002,

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
    RenderPassAttachmentBeginInfo = 1000108003,

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
    PhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,

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
    AttachmentReferenceStencilLayout = 1000241001,

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
    AttachmentDescriptionStencilLayout = 1000241002,

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
    PhysicalDeviceVulkan1X3Features = 53,

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
    PhysicalDeviceVulkan1X3Properties = 54,

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
    PhysicalDeviceToolProperties = 1000245000,

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
    PhysicalDevicePrivateDataFeatures = 1000295000,

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
    DevicePrivateDataCreateInfo = 1000295001,

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
    PrivateDataSlotCreateInfo = 1000295002,

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
    MemoryBarrier2 = 1000314000,

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
    BufferMemoryBarrier2 = 1000314001,

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
    ImageMemoryBarrier2 = 1000314002,

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
    DependencyInfo = 1000314003,

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
    SubmitInfo2 = 1000314004,

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
    SemaphoreSubmitInfo = 1000314005,

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
    CommandBufferSubmitInfo = 1000314006,

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
    PhysicalDeviceSynchronization2Features = 1000314007,

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
    CopyBufferInfo2 = 1000337000,

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
    CopyImageInfo2 = 1000337001,

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
    CopyBufferToImageInfo2 = 1000337002,

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
    CopyImageToBufferInfo2 = 1000337003,

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
    BufferCopy2 = 1000337006,

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
    ImageCopy2 = 1000337007,

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
    BufferImageCopy2 = 1000337009,

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
    PhysicalDeviceTextureCompressionAstcHdrFeatures = 1000066000,

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
    FormatProperties3 = 1000360000,

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
    PhysicalDeviceMaintenance4Features = 1000413000,

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
    PhysicalDeviceMaintenance4Properties = 1000413001,

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
    DeviceBufferMemoryRequirements = 1000413002,

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
    DeviceImageMemoryRequirements = 1000413003,

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
    PipelineCreationFeedbackCreateInfo = 1000192000,

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
    PhysicalDeviceShaderTerminateInvocationFeatures = 1000215000,

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
    PhysicalDeviceShaderDemoteToHelperInvocationFeatures = 1000276000,

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
    PhysicalDevicePipelineCreationCacheControlFeatures = 1000297000,

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
    PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures = 1000325000,

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
    PhysicalDeviceImageRobustnessFeatures = 1000335000,

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
    PhysicalDeviceSubgroupSizeControlProperties = 1000225000,

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
    PipelineShaderStageRequiredSubgroupSizeCreateInfo = 1000225001,

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
    PhysicalDeviceSubgroupSizeControlFeatures = 1000225002,

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
    PhysicalDeviceInlineUniformBlockFeatures = 1000138000,

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
    PhysicalDeviceInlineUniformBlockProperties = 1000138001,

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
    WriteDescriptorSetInlineUniformBlock = 1000138002,

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
    DescriptorPoolInlineUniformBlockCreateInfo = 1000138003,

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
    PhysicalDeviceShaderIntegerDotProductFeatures = 1000280000,

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
    PhysicalDeviceShaderIntegerDotProductProperties = 1000280001,

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
    PhysicalDeviceTexelBufferAlignmentProperties = 1000281001,

    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    BlitImageInfo2 = 1000337004,

    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    ResolveImageInfo2 = 1000337005,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_BLIT_2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    ImageBlit2 = 1000337008,

    [NativeName("VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    ImageResolve2 = 1000337010,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    RenderingInfo = 1000044000,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    RenderingAttachmentInfo = 1000044001,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    PipelineRenderingCreateInfo = 1000044002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    PhysicalDeviceDynamicRenderingFeatures = 1000044003,

    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    CommandBufferInheritanceRenderingInfo = 1000044004,

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
    PhysicalDeviceVulkan1X4Features = 55,

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
    PhysicalDeviceVulkan1X4Properties = 56,

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
    DeviceQueueGlobalPriorityCreateInfo = 1000174000,

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
    PhysicalDeviceGlobalPriorityQueryFeatures = 1000388000,

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
    QueueFamilyGlobalPriorityProperties = 1000388001,

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
    PhysicalDeviceIndexTypeUint8Features = 1000265000,

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
    MemoryMapInfo = 1000271000,

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
    MemoryUnmapInfo = 1000271001,

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
    PhysicalDeviceMaintenance5Features = 1000470000,

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
    PhysicalDeviceMaintenance5Properties = 1000470001,

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
    DeviceImageSubresourceInfo = 1000470004,

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
    SubresourceLayout2 = 1000338002,

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
    ImageSubresource2 = 1000338003,

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
    BufferUsageFlags2CreateInfo = 1000470006,

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
    PhysicalDeviceMaintenance6Features = 1000545000,

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
    PhysicalDeviceMaintenance6Properties = 1000545001,

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
    BindMemoryStatus = 1000545002,

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
    PhysicalDeviceHostImageCopyFeatures = 1000270000,

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
    PhysicalDeviceHostImageCopyProperties = 1000270001,

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
    MemoryToImageCopy = 1000270002,

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
    ImageToMemoryCopy = 1000270003,

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
    CopyImageToMemoryInfo = 1000270004,

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
    CopyMemoryToImageInfo = 1000270005,

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
    HostImageLayoutTransitionInfo = 1000270006,

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
    CopyImageToImageInfo = 1000270007,

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
    SubresourceHostMemcpySize = 1000270008,

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
    HostImageCopyDevicePerformanceQuery = 1000270009,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDeviceShaderSubgroupRotateFeatures = 1000416000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDeviceShaderFloatControls2Features = 1000528000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDeviceShaderExpectAssumeFeatures = 1000544000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PipelineCreateFlags2CreateInfo = 1000470005,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDevicePushDescriptorProperties = 1000080000,

    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    BindDescriptorSetsInfo = 1000545003,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PushConstantsInfo = 1000545004,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PushDescriptorSetInfo = 1000545005,

    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PushDescriptorSetWithTemplateInfo = 1000545006,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDevicePipelineProtectedAccessFeatures = 1000466000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PipelineRobustnessCreateInfo = 1000068000,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDevicePipelineRobustnessFeatures = 1000068001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_COMPUTE_VERSION_1_4", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDevicePipelineRobustnessProperties = 1000068002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDeviceLineRasterizationFeatures = 1000259000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PipelineRasterizationLineStateCreateInfo = 1000259001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDeviceLineRasterizationProperties = 1000259002,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDeviceVertexAttributeDivisorProperties = 1000525000,

    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PipelineVertexInputDivisorStateCreateInfo = 1000190001,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDeviceVertexAttributeDivisorFeatures = 1000190002,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_AREA_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    RenderingAreaInfo = 1000470003,

    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    PhysicalDeviceDynamicRenderingLocalReadFeatures = 1000232000,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    RenderingAttachmentLocationInfo = 1000232001,

    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    RenderingInputAttachmentIndexInfo = 1000232002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    SwapchainCreateInfokhr = 1000001000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    PresentInfokhr = 1000001001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    DeviceGroupPresentCapabilitieskhr = 1000060007,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    ImageSwapchainCreateInfokhr = 1000060008,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    BindImageMemorySwapchainInfokhr = 1000060009,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    AcquireNextImageInfokhr = 1000060010,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    DeviceGroupPresentInfokhr = 1000060011,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    DeviceGroupSwapchainCreateInfokhr = 1000060012,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    DisplayModeCreateInfokhr = 1000002000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    DisplaySurfaceCreateInfokhr = 1000002001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_display_swapchain"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_swapchain"]
    )]
    DisplayPresentInfokhr = 1000003000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xlib_surface"], ImpliesSets = ["VK_KHR_surface"])]
    XlibSurfaceCreateInfokhr = 1000004000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xcb_surface"], ImpliesSets = ["VK_KHR_surface"])]
    XcbSurfaceCreateInfokhr = 1000005000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_wayland_surface"], ImpliesSets = ["VK_KHR_surface"])]
    WaylandSurfaceCreateInfokhr = 1000006000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_android_surface"], ImpliesSets = ["VK_KHR_surface"])]
    AndroidSurfaceCreateInfokhr = 1000008000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_win32_surface"], ImpliesSets = ["VK_KHR_surface"])]
    Win32SurfaceCreateInfokhr = 1000009000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DebugReportCallbackCreateInfoext = 1000011000,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_rasterization_order"])]
    PipelineRasterizationStateRasterizationOrderamd = 1000018000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    DebugMarkerObjectNameInfoext = 1000022000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    DebugMarkerObjectTagInfoext = 1000022001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    DebugMarkerMarkerInfoext = 1000022002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoProfileInfokhr = 1000023000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoCapabilitieskhr = 1000023001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoPictureResourceInfokhr = 1000023002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoSessionMemoryRequirementskhr = 1000023003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    BindVideoSessionMemoryInfokhr = 1000023004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoSessionCreateInfokhr = 1000023005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoSessionParametersCreateInfokhr = 1000023006,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoSessionParametersUpdateInfokhr = 1000023007,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoBeginCodingInfokhr = 1000023008,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoEndCodingInfokhr = 1000023009,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoCodingControlInfokhr = 1000023010,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoReferenceSlotInfokhr = 1000023011,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    QueueFamilyVideoPropertieskhr = 1000023012,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoProfileListInfokhr = 1000023013,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    PhysicalDeviceVideoFormatInfokhr = 1000023014,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoFormatPropertieskhr = 1000023015,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    QueueFamilyQueryResultStatusPropertieskhr = 1000023016,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoDecodeInfokhr = 1000024000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoDecodeCapabilitieskhr = 1000024001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoDecodeUsageInfokhr = 1000024002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    DedicatedAllocationImageCreateInfonv = 1000026000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    DedicatedAllocationBufferCreateInfonv = 1000026001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    DedicatedAllocationMemoryAllocateInfonv = 1000026002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTransformFeedbackFeaturesext = 1000028000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTransformFeedbackPropertiesext = 1000028001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationStateStreamCreateInfoext = 1000028002,

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    CuModuleCreateInfonvx = 1000029000,

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    CuFunctionCreateInfonvx = 1000029001,

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    CuLaunchInfonvx = 1000029002,

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CU_MODULE_TEXTURING_MODE_CREATE_INFO_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    CuModuleTexturingModeCreateInfonvx = 1000029004,

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    ImageViewHandleInfonvx = 1000030000,

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    ImageViewAddressPropertiesnvx = 1000030001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264Capabilitieskhr = 1000038000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264SessionParametersCreateInfokhr = 1000038001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264SessionParametersAddInfokhr = 1000038002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264PictureInfokhr = 1000038003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264DpbSlotInfokhr = 1000038004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264NaluSliceInfokhr = 1000038005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_GOP_REMAINING_FRAME_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264GopRemainingFrameInfokhr = 1000038006,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264ProfileInfokhr = 1000038007,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264RateControlInfokhr = 1000038008,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264RateControlLayerInfokhr = 1000038009,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264SessionCreateInfokhr = 1000038010,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUALITY_LEVEL_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264QualityLevelPropertieskhr = 1000038011,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_GET_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264SessionParametersGetInfokhr = 1000038012,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264SessionParametersFeedbackInfokhr = 1000038013,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265Capabilitieskhr = 1000039000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265SessionParametersCreateInfokhr = 1000039001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265SessionParametersAddInfokhr = 1000039002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265PictureInfokhr = 1000039003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265DpbSlotInfokhr = 1000039004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265NaluSliceSegmentInfokhr = 1000039005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_GOP_REMAINING_FRAME_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265GopRemainingFrameInfokhr = 1000039006,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265ProfileInfokhr = 1000039007,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265RateControlInfokhr = 1000039009,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265RateControlLayerInfokhr = 1000039010,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265SessionCreateInfokhr = 1000039011,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUALITY_LEVEL_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265QualityLevelPropertieskhr = 1000039012,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_GET_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265SessionParametersGetInfokhr = 1000039013,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265SessionParametersFeedbackInfokhr = 1000039014,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264Capabilitieskhr = 1000040000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264PictureInfokhr = 1000040001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264ProfileInfokhr = 1000040003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264SessionParametersCreateInfokhr = 1000040004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264SessionParametersAddInfokhr = 1000040005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264DpbSlotInfokhr = 1000040006,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_texture_gather_bias_lod"],
        ImpliesSets = [
            "VK_AMD_texture_gather_bias_lod+VK_KHR_get_physical_device_properties2",
            "VK_AMD_texture_gather_bias_lod+VK_VERSION_1_1",
        ]
    )]
    TextureLodGatherFormatPropertiesamd = 1000041000,

    [NameAffix("Suffix", "GGP", 0)]
    [NativeName("VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GGP_stream_descriptor_surface"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    StreamDescriptorSurfaceCreateInfoggp = 1000049000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_corner_sampled_image"],
        ImpliesSets = [
            "VK_NV_corner_sampled_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_corner_sampled_image+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCornerSampledImageFeaturesnv = 1000050000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    ExternalMemoryImageCreateInfonv = 1000056000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    ExportMemoryAllocateInfonv = 1000056001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    ImportMemoryWin32HandleInfonv = 1000057000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    ExportMemoryWin32HandleInfonv = 1000057001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    Win32KeyedMutexAcquireReleaseInfonv = 1000058000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    ValidationFlagsext = 1000061000,

    [NameAffix("Suffix", "NN", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN")]
    [SupportedApiProfile("vulkan", ["VK_NN_vi_surface"], ImpliesSets = ["VK_KHR_surface"])]
    ViSurfaceCreateInfonn = 1000062000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    ImageViewAstcDecodeModeext = 1000067000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAstcDecodeFeaturesext = 1000067001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    ImportMemoryWin32HandleInfokhr = 1000073000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    ExportMemoryWin32HandleInfokhr = 1000073001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    MemoryWin32HandlePropertieskhr = 1000073002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    MemoryGetWin32HandleInfokhr = 1000073003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    ImportMemoryFdInfokhr = 1000074000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    MemoryFdPropertieskhr = 1000074001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    MemoryGetFdInfokhr = 1000074002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_win32_keyed_mutex"],
        ImpliesSets = ["VK_KHR_external_memory_win32"]
    )]
    Win32KeyedMutexAcquireReleaseInfokhr = 1000075000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    ImportSemaphoreWin32HandleInfokhr = 1000078000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    ExportSemaphoreWin32HandleInfokhr = 1000078001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    D3D12FenceSubmitInfokhr = 1000078002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    SemaphoreGetWin32HandleInfokhr = 1000078003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_fd"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_fd+VK_KHR_external_semaphore",
            "VK_KHR_external_semaphore_fd+VK_VERSION_1_1",
        ]
    )]
    ImportSemaphoreFdInfokhr = 1000079000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_fd"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_fd+VK_KHR_external_semaphore",
            "VK_KHR_external_semaphore_fd+VK_VERSION_1_1",
        ]
    )]
    SemaphoreGetFdInfokhr = 1000079001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    CommandBufferInheritanceConditionalRenderingInfoext = 1000081000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceConditionalRenderingFeaturesext = 1000081001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    ConditionalRenderingBeginInfoext = 1000081002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_incremental_present"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    PresentRegionskhr = 1000084000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    PipelineViewportWScalingStateCreateInfonv = 1000087000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    SurfaceCapabilities2Ext = 1000090000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    DisplayPowerInfoext = 1000091000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    DeviceEventInfoext = 1000091001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    DisplayEventInfoext = 1000091002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    SwapchainCounterCreateInfoext = 1000091003,

    [NameAffix("Suffix", "GOOGLE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GOOGLE_display_timing"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    PresentTimesInfogoogle = 1000092000,

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NVX_multiview_per_view_attributes"],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiviewPerViewAttributesPropertiesnvx = 1000097000,

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX")]
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
    MultiviewPerViewAttributesInfonvx = 1000044009,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    PipelineViewportSwizzleStateCreateInfonv = 1000098000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDiscardRectanglePropertiesext = 1000099000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    PipelineDiscardRectangleStateCreateInfoext = 1000099001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceConservativeRasterizationPropertiesext = 1000101000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationConservativeStateCreateInfoext = 1000101001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthClipEnableFeaturesext = 1000102000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationDepthClipStateCreateInfoext = 1000102001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_HDR_METADATA_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    HdrMetadataext = 1000105000,

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RELAXED_LINE_RASTERIZATION_FEATURES_IMG")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_IMG_relaxed_line_rasterization"],
        ImpliesSets = [
            "VK_IMG_relaxed_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_IMG_relaxed_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRelaxedLineRasterizationFeaturesimg = 1000110000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    SharedPresentSurfaceCapabilitieskhr = 1000111000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    ImportFenceWin32HandleInfokhr = 1000114000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    ExportFenceWin32HandleInfokhr = 1000114001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    FenceGetWin32HandleInfokhr = 1000114002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_fd"],
        ImpliesSets = [
            "VK_KHR_external_fence_fd+VK_KHR_external_fence",
            "VK_KHR_external_fence_fd+VK_VERSION_1_1",
        ]
    )]
    ImportFenceFdInfokhr = 1000115000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_fd"],
        ImpliesSets = [
            "VK_KHR_external_fence_fd+VK_KHR_external_fence",
            "VK_KHR_external_fence_fd+VK_VERSION_1_1",
        ]
    )]
    FenceGetFdInfokhr = 1000115001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePerformanceQueryFeatureskhr = 1000116000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePerformanceQueryPropertieskhr = 1000116001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    QueryPoolPerformanceCreateInfokhr = 1000116002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    PerformanceQuerySubmitInfokhr = 1000116003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    AcquireProfilingLockInfokhr = 1000116004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    PerformanceCounterkhr = 1000116005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    PerformanceCounterDescriptionkhr = 1000116006,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    PhysicalDeviceSurfaceInfo2Khr = 1000119000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    SurfaceCapabilities2Khr = 1000119001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    SurfaceFormat2Khr = 1000119002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    DisplayProperties2Khr = 1000121000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    DisplayPlaneProperties2Khr = 1000121001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    DisplayModeProperties2Khr = 1000121002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    DisplayPlaneInfo2Khr = 1000121003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    DisplayPlaneCapabilities2Khr = 1000121004,

    [NameAffix("Suffix", "MVK", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK")]
    [SupportedApiProfile("vulkan", ["VK_MVK_ios_surface"], ImpliesSets = ["VK_KHR_surface"])]
    IosSurfaceCreateInfomvk = 1000122000,

    [NameAffix("Suffix", "MVK", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK")]
    [SupportedApiProfile("vulkan", ["VK_MVK_macos_surface"], ImpliesSets = ["VK_KHR_surface"])]
    MacosSurfaceCreateInfomvk = 1000123000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsObjectNameInfoext = 1000128000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsObjectTagInfoext = 1000128001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsLabelext = 1000128002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsMessengerCallbackDataext = 1000128003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsMessengerCreateInfoext = 1000128004,

    [NameAffix("Suffix", "ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    AndroidHardwareBufferUsageandroid = 1000129000,

    [NameAffix("Suffix", "ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    AndroidHardwareBufferPropertiesandroid = 1000129001,

    [NameAffix("Suffix", "ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    AndroidHardwareBufferFormatPropertiesandroid = 1000129002,

    [NameAffix("Suffix", "ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ImportAndroidHardwareBufferInfoandroid = 1000129003,

    [NameAffix("Suffix", "ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    MemoryGetAndroidHardwareBufferInfoandroid = 1000129004,

    [NameAffix("Suffix", "ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ExternalFormatandroid = 1000129005,

    [NameAffix("Suffix", "ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID")]
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
    AndroidHardwareBufferFormatProperties2Android = 1000129006,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_AMD_mixed_attachment_samples+VK_KHR_dynamic_rendering",
            "VK_AMD_mixed_attachment_samples+VK_VERSION_1_3",
        ]
    )]
    AttachmentSampleCountInfoamd = 1000044008,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_BFLOAT16_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderBfloat16Featureskhr = 1000141000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    SampleLocationsInfoext = 1000143000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    RenderPassSampleLocationsBeginInfoext = 1000143001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    PipelineSampleLocationsStateCreateInfoext = 1000143002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSampleLocationsPropertiesext = 1000143003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    MultisamplePropertiesext = 1000143004,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceBlendOperationAdvancedFeaturesext = 1000148000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceBlendOperationAdvancedPropertiesext = 1000148001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    PipelineColorBlendAdvancedStateCreateInfoext = 1000148002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    PipelineCoverageToColorStateCreateInfonv = 1000149000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    WriteDescriptorSetAccelerationStructurekhr = 1000150007,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureBuildGeometryInfokhr = 1000150000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureDeviceAddressInfokhr = 1000150002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureGeometryAabbsDatakhr = 1000150003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureGeometryInstancesDatakhr = 1000150004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureGeometryTrianglesDatakhr = 1000150005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureGeometrykhr = 1000150006,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureVersionInfokhr = 1000150009,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    CopyAccelerationStructureInfokhr = 1000150010,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    CopyAccelerationStructureToMemoryInfokhr = 1000150011,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    CopyMemoryToAccelerationStructureInfokhr = 1000150012,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceAccelerationStructureFeatureskhr = 1000150013,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceAccelerationStructurePropertieskhr = 1000150014,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureCreateInfokhr = 1000150017,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureBuildSizesInfokhr = 1000150020,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceRayTracingPipelineFeatureskhr = 1000347000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceRayTracingPipelinePropertieskhr = 1000347001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingPipelineCreateInfokhr = 1000150015,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingShaderGroupCreateInfokhr = 1000150016,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingPipelineInterfaceCreateInfokhr = 1000150018,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_query"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceRayQueryFeatureskhr = 1000348013,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    PipelineCoverageModulationStateCreateInfonv = 1000152000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceShaderSmBuiltinsFeaturesnv = 1000154000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceShaderSmBuiltinsPropertiesnv = 1000154001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    DrmFormatModifierPropertiesListext = 1000158000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceImageDrmFormatModifierInfoext = 1000158002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    ImageDrmFormatModifierListCreateInfoext = 1000158003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    ImageDrmFormatModifierExplicitCreateInfoext = 1000158004,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    ImageDrmFormatModifierPropertiesext = 1000158005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT")]
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
    DrmFormatModifierPropertiesList2Ext = 1000158006,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    ValidationCacheCreateInfoext = 1000160000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    ShaderModuleValidationCacheCreateInfoext = 1000160001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    PipelineViewportShadingRateImageStateCreateInfonv = 1000164000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShadingRateImageFeaturesnv = 1000164001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShadingRateImagePropertiesnv = 1000164002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    PipelineViewportCoarseSampleOrderStateCreateInfonv = 1000164005,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    RayTracingPipelineCreateInfonv = 1000165000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    AccelerationStructureCreateInfonv = 1000165001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    Geometrynv = 1000165003,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    GeometryTrianglesnv = 1000165004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    GeometryAabbnv = 1000165005,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    BindAccelerationStructureMemoryInfonv = 1000165006,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    WriteDescriptorSetAccelerationStructurenv = 1000165007,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    AccelerationStructureMemoryRequirementsInfonv = 1000165008,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRayTracingPropertiesnv = 1000165009,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    RayTracingShaderGroupCreateInfonv = 1000165011,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    AccelerationStructureInfonv = 1000165012,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRepresentativeFragmentTestFeaturesnv = 1000166000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    PipelineRepresentativeFragmentTestStateCreateInfonv = 1000166001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    PhysicalDeviceImageViewImageFormatInfoext = 1000170000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    FilterCubicImageViewImageFormatPropertiesext = 1000170001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    ImportMemoryHostPointerInfoext = 1000178000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    MemoryHostPointerPropertiesext = 1000178001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalMemoryHostPropertiesext = 1000178002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_clock"],
        ImpliesSets = [
            "VK_KHR_shader_clock+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_clock+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderClockFeatureskhr = 1000181000,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_pipeline_compiler_control"])]
    PipelineCompilerControlCreateInfoamd = 1000183000,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderCorePropertiesamd = 1000185000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265Capabilitieskhr = 1000187000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265SessionParametersCreateInfokhr = 1000187001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265SessionParametersAddInfokhr = 1000187002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265ProfileInfokhr = 1000187003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265PictureInfokhr = 1000187004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265DpbSlotInfokhr = 1000187005,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    DeviceMemoryOverallocationCreateInfoamd = 1000189000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexAttributeDivisorPropertiesext = 1000190000,

    [NameAffix("Suffix", "GGP", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GGP_frame_token"],
        ImpliesSets = ["VK_GGP_stream_descriptor_surface", "VK_KHR_swapchain"]
    )]
    PresentFrameTokenggp = 1000191000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMeshShaderFeaturesnv = 1000202000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMeshShaderPropertiesnv = 1000202001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shader_image_footprint"],
        ImpliesSets = [
            "VK_NV_shader_image_footprint+VK_KHR_get_physical_device_properties2",
            "VK_NV_shader_image_footprint+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderImageFootprintFeaturesnv = 1000204000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    PipelineViewportExclusiveScissorStateCreateInfonv = 1000205000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExclusiveScissorFeaturesnv = 1000205002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostic_checkpoints"],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    CheckpointDatanv = 1000206000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostic_checkpoints"],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    QueueFamilyCheckpointPropertiesnv = 1000206001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV")]
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
    QueueFamilyCheckpointProperties2Nv = 1000314008,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV")]
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
    CheckpointData2Nv = 1000314009,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_INTEL_shader_integer_functions2"],
        ImpliesSets = [
            "VK_INTEL_shader_integer_functions2+VK_KHR_get_physical_device_properties2",
            "VK_INTEL_shader_integer_functions2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderIntegerFunctions2Featuresintel = 1000209000,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    QueryPoolPerformanceQueryCreateInfointel = 1000210000,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    InitializePerformanceApiInfointel = 1000210001,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    PerformanceMarkerInfointel = 1000210002,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    PerformanceStreamMarkerInfointel = 1000210003,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    PerformanceOverrideInfointel = 1000210004,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    PerformanceConfigurationAcquireInfointel = 1000210005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pci_bus_info"],
        ImpliesSets = [
            "VK_EXT_pci_bus_info+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pci_bus_info+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePciBusInfoPropertiesext = 1000212000,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    DisplayNativeHdrSurfaceCapabilitiesamd = 1000213000,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    SwapchainDisplayNativeHdrCreateInfoamd = 1000213001,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_imagepipe_surface"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    ImagepipeSurfaceCreateInfofuchsia = 1000214000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_surface"], ImpliesSets = ["VK_KHR_surface"])]
    MetalSurfaceCreateInfoext = 1000217000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentDensityMapFeaturesext = 1000218000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentDensityMapPropertiesext = 1000218001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    RenderPassFragmentDensityMapCreateInfoext = 1000218002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT")]
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
    RenderingFragmentDensityMapAttachmentInfoext = 1000044007,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    FragmentShadingRateAttachmentInfokhr = 1000226000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PipelineFragmentShadingRateStateCreateInfokhr = 1000226001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceFragmentShadingRatePropertieskhr = 1000226002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceFragmentShadingRateFeatureskhr = 1000226003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceFragmentShadingRatekhr = 1000226004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR")]
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
    RenderingFragmentShadingRateAttachmentInfokhr = 1000044006,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties2"],
        ImpliesSets = ["VK_AMD_shader_core_properties"]
    )]
    PhysicalDeviceShaderCoreProperties2Amd = 1000227000,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_device_coherent_memory"],
        ImpliesSets = [
            "VK_AMD_device_coherent_memory+VK_KHR_get_physical_device_properties2",
            "VK_AMD_device_coherent_memory+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCoherentMemoryFeaturesamd = 1000229000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_image_atomic_int64"],
        ImpliesSets = [
            "VK_EXT_shader_image_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_image_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderImageAtomicInt64Featuresext = 1000234000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_QUAD_CONTROL_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_quad_control"],
        ImpliesSets = [
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_1+VK_KHR_vulkan_memory_model",
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceShaderQuadControlFeatureskhr = 1000235000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_budget"],
        ImpliesSets = [
            "VK_EXT_memory_budget+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_budget+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMemoryBudgetPropertiesext = 1000237000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_priority"],
        ImpliesSets = [
            "VK_EXT_memory_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_priority+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMemoryPriorityFeaturesext = 1000238000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_priority"],
        ImpliesSets = [
            "VK_EXT_memory_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_priority+VK_VERSION_1_1",
        ]
    )]
    MemoryPriorityAllocateInfoext = 1000238001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_protected_capabilities"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_VERSION_1_1"]
    )]
    SurfaceProtectedCapabilitieskhr = 1000239000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_dedicated_allocation_image_aliasing"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDedicatedAllocationImageAliasingFeaturesnv = 1000240000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceBufferDeviceAddressFeaturesext = 1000244000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    BufferDeviceAddressCreateInfoext = 1000244002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ValidationFeaturesext = 1000247000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait"],
        ImpliesSets = ["VK_KHR_present_id", "VK_KHR_swapchain"]
    )]
    PhysicalDevicePresentWaitFeatureskhr = 1000248000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeMatrixFeaturesnv = 1000249000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    CooperativeMatrixPropertiesnv = 1000249001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeMatrixPropertiesnv = 1000249002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCoverageReductionModeFeaturesnv = 1000250000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    PipelineCoverageReductionStateCreateInfonv = 1000250001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    FramebufferMixedSamplesCombinationnv = 1000250002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_shader_interlock"],
        ImpliesSets = [
            "VK_EXT_fragment_shader_interlock+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_shader_interlock+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentShaderInterlockFeaturesext = 1000251000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_image_arrays"],
        ImpliesSets = [
            "VK_EXT_ycbcr_image_arrays+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_image_arrays+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceYcbcrImageArraysFeaturesext = 1000252000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceProvokingVertexFeaturesext = 1000254000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationProvokingVertexStateCreateInfoext = 1000254001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceProvokingVertexPropertiesext = 1000254002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    SurfaceFullScreenExclusiveInfoext = 1000255000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    SurfaceCapabilitiesFullScreenExclusiveext = 1000255002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive", "VK_KHR_win32_surface"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    SurfaceFullScreenExclusiveWin32Infoext = 1000255001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_headless_surface"], ImpliesSets = ["VK_KHR_surface"])]
    HeadlessSurfaceCreateInfoext = 1000256000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderAtomicFloatFeaturesext = 1000260000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedDynamicStateFeaturesext = 1000267000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineExecutablePropertiesFeatureskhr = 1000269000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineInfokhr = 1000269001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineExecutablePropertieskhr = 1000269002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineExecutableInfokhr = 1000269003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineExecutableStatistickhr = 1000269004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineExecutableInternalRepresentationkhr = 1000269005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    PhysicalDeviceMapMemoryPlacedFeaturesext = 1000272000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    PhysicalDeviceMapMemoryPlacedPropertiesext = 1000272001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MAP_PLACED_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    MemoryMapPlacedInfoext = 1000272002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    PhysicalDeviceShaderAtomicFloat2Featuresext = 1000273000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    PhysicalDeviceDeviceGeneratedCommandsPropertiesnv = 1000277000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    GraphicsShaderGroupCreateInfonv = 1000277001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    GraphicsPipelineShaderGroupsCreateInfonv = 1000277002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    IndirectCommandsLayoutTokennv = 1000277003,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    IndirectCommandsLayoutCreateInfonv = 1000277004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    GeneratedCommandsInfonv = 1000277005,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    GeneratedCommandsMemoryRequirementsInfonv = 1000277006,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    PhysicalDeviceDeviceGeneratedCommandsFeaturesnv = 1000277007,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_inherited_viewport_scissor"],
        ImpliesSets = [
            "VK_NV_inherited_viewport_scissor+VK_KHR_get_physical_device_properties2",
            "VK_NV_inherited_viewport_scissor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceInheritedViewportScissorFeaturesnv = 1000278000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_inherited_viewport_scissor"],
        ImpliesSets = [
            "VK_NV_inherited_viewport_scissor+VK_KHR_get_physical_device_properties2",
            "VK_NV_inherited_viewport_scissor+VK_VERSION_1_1",
        ]
    )]
    CommandBufferInheritanceViewportScissorInfonv = 1000278001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texel_buffer_alignment"],
        ImpliesSets = [
            "VK_EXT_texel_buffer_alignment+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texel_buffer_alignment+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTexelBufferAlignmentFeaturesext = 1000281000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    CommandBufferInheritanceRenderPassTransformInfoqcom = 1000282000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    RenderPassTransformBeginInfoqcom = 1000282001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthBiasControlFeaturesext = 1000283000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEPTH_BIAS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    DepthBiasInfoext = 1000283001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEPTH_BIAS_REPRESENTATION_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    DepthBiasRepresentationInfoext = 1000283002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDeviceMemoryReportFeaturesext = 1000284000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    DeviceDeviceMemoryReportCreateInfoext = 1000284001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    DeviceMemoryReportCallbackDataext = 1000284002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    SamplerCustomBorderColorCreateInfoext = 1000287000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCustomBorderColorPropertiesext = 1000287001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCustomBorderColorFeaturesext = 1000287002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    PipelineLibraryCreateInfokhr = 1000290000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePresentBarrierFeaturesnv = 1000292000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    SurfaceCapabilitiesPresentBarriernv = 1000292001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    SwapchainPresentBarrierCreateInfonv = 1000292002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_ID_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    PresentIdkhr = 1000294000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePresentIdFeatureskhr = 1000294001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeInfokhr = 1000299000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeRateControlInfokhr = 1000299001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeRateControlLayerInfokhr = 1000299002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeCapabilitieskhr = 1000299003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeUsageInfokhr = 1000299004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    QueryPoolVideoEncodeFeedbackCreateInfokhr = 1000299005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceVideoEncodeQualityLevelInfokhr = 1000299006,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeQualityLevelPropertieskhr = 1000299007,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeQualityLevelInfokhr = 1000299008,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_GET_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeSessionParametersGetInfokhr = 1000299009,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeSessionParametersFeedbackInfokhr = 1000299010,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDiagnosticsConfigFeaturesnv = 1000300000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    DeviceDiagnosticsConfigCreateInfonv = 1000300001,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    PhysicalDeviceTileShadingFeaturesqcom = 1000309000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    PhysicalDeviceTileShadingPropertiesqcom = 1000309001,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_TILE_SHADING_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    RenderPassTileShadingCreateInfoqcom = 1000309002,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PER_TILE_BEGIN_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    PerTileBeginInfoqcom = 1000309003,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PER_TILE_END_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    PerTileEndInfoqcom = 1000309004,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPATCH_TILE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    DispatchTileInfoqcom = 1000309005,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_low_latency"])]
    QueryLowLatencySupportnv = 1000310000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalObjectCreateInfoext = 1000311000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalObjectsInfoext = 1000311001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalDeviceInfoext = 1000311002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalCommandQueueInfoext = 1000311003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalBufferInfoext = 1000311004,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ImportMetalBufferInfoext = 1000311005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalTextureInfoext = 1000311006,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ImportMetalTextureInfoext = 1000311007,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalIoSurfaceInfoext = 1000311008,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ImportMetalIoSurfaceInfoext = 1000311009,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalSharedEventInfoext = 1000311010,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ImportMetalSharedEventInfoext = 1000311011,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT")]
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
    PhysicalDeviceDescriptorBufferPropertiesext = 1000316000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_DENSITY_MAP_PROPERTIES_EXT")]
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
    PhysicalDeviceDescriptorBufferDensityMapPropertiesext = 1000316001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT")]
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
    PhysicalDeviceDescriptorBufferFeaturesext = 1000316002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT")]
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
    DescriptorAddressInfoext = 1000316003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT")]
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
    DescriptorGetInfoext = 1000316004,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
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
    BufferCaptureDescriptorDataInfoext = 1000316005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
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
    ImageCaptureDescriptorDataInfoext = 1000316006,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
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
    ImageViewCaptureDescriptorDataInfoext = 1000316007,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
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
    SamplerCaptureDescriptorDataInfoext = 1000316008,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT")]
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
    OpaqueCaptureDescriptorDataCreateInfoext = 1000316010,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT")]
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
    DescriptorBufferBindingInfoext = 1000316011,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT")]
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
    DescriptorBufferBindingPushDescriptorBufferHandleext = 1000316012,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT")]
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
    AccelerationStructureCaptureDescriptorDataInfoext = 1000316009,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceGraphicsPipelineLibraryFeaturesext = 1000320000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceGraphicsPipelineLibraryPropertiesext = 1000320001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    GraphicsPipelineLibraryCreateInfoext = 1000320002,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_early_and_late_fragment_tests"],
        ImpliesSets = [
            "VK_AMD_shader_early_and_late_fragment_tests+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_early_and_late_fragment_tests+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesamd = 1000321000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentShaderBarycentricFeatureskhr = 1000203000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentShaderBarycentricPropertieskhr = 1000322000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_uniform_control_flow"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceShaderSubgroupUniformControlFlowFeatureskhr = 1000323000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    PhysicalDeviceFragmentShadingRateEnumsPropertiesnv = 1000326000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    PhysicalDeviceFragmentShadingRateEnumsFeaturesnv = 1000326001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    PipelineFragmentShadingRateEnumStateCreateInfonv = 1000326002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    AccelerationStructureGeometryMotionTrianglesDatanv = 1000327000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    PhysicalDeviceRayTracingMotionBlurFeaturesnv = 1000327001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    AccelerationStructureMotionInfonv = 1000327002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
    )]
    PhysicalDeviceMeshShaderFeaturesext = 1000328000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
    )]
    PhysicalDeviceMeshShaderPropertiesext = 1000328001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_2plane_444_formats"],
        ImpliesSets = [
            "VK_EXT_ycbcr_2plane_444_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_2plane_444_formats+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceYcbcr2Plane444FormatsFeaturesext = 1000330000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    PhysicalDeviceFragmentDensityMap2Featuresext = 1000332000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    PhysicalDeviceFragmentDensityMap2Propertiesext = 1000332001,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_rotated_copy_commands"],
        ImpliesSets = [
            "VK_QCOM_rotated_copy_commands+VK_KHR_copy_commands2",
            "VK_QCOM_rotated_copy_commands+VK_VERSION_1_3",
        ]
    )]
    CopyCommandTransformInfoqcom = 1000333000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_workgroup_memory_explicit_layout"],
        ImpliesSets = [
            "VK_KHR_workgroup_memory_explicit_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_workgroup_memory_explicit_layout+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceWorkgroupMemoryExplicitLayoutFeatureskhr = 1000336000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageCompressionControlFeaturesext = 1000338000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    ImageCompressionControlext = 1000338001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    ImageCompressionPropertiesext = 1000338004,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_layout"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesext = 1000339000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_4444_formats"],
        ImpliesSets = [
            "VK_EXT_4444_formats+VK_KHR_get_physical_device_properties2",
            "VK_EXT_4444_formats+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevice4444FormatsFeaturesext = 1000340000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFaultFeaturesext = 1000341000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    DeviceFaultCountsext = 1000341001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    DeviceFaultInfoext = 1000341002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rgba10x6_formats"],
        ImpliesSets = [
            "VK_EXT_rgba10x6_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_rgba10x6_formats+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRgba10X6FormatsFeaturesext = 1000344000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_directfb_surface"], ImpliesSets = ["VK_KHR_surface"])]
    DirectfbSurfaceCreateInfoext = 1000346000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexInputDynamicStateFeaturesext = 1000352000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VertexInputBindingDescription2Ext = 1000352001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VertexInputAttributeDescription2Ext = 1000352002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDrmPropertiesext = 1000353000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAddressBindingReportFeaturesext = 1000354000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    DeviceAddressBindingCallbackDataext = 1000354001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control"],
        ImpliesSets = [
            "VK_EXT_depth_clip_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthClipControlFeaturesext = 1000355000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control"],
        ImpliesSets = [
            "VK_EXT_depth_clip_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_control+VK_VERSION_1_1",
        ]
    )]
    PipelineViewportDepthClipControlCreateInfoext = 1000355001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitive_topology_list_restart"],
        ImpliesSets = [
            "VK_EXT_primitive_topology_list_restart+VK_KHR_get_physical_device_properties2",
            "VK_EXT_primitive_topology_list_restart+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePrimitiveTopologyListRestartFeaturesext = 1000356000,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    ImportMemoryZirconHandleInfofuchsia = 1000364000,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    MemoryZirconHandlePropertiesfuchsia = 1000364001,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    MemoryGetZirconHandleInfofuchsia = 1000364002,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore", "VK_KHR_external_semaphore_capabilities"]
    )]
    ImportSemaphoreZirconHandleInfofuchsia = 1000365000,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore", "VK_KHR_external_semaphore_capabilities"]
    )]
    SemaphoreGetZirconHandleInfofuchsia = 1000365001,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionCreateInfofuchsia = 1000366000,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    ImportMemoryBufferCollectionfuchsia = 1000366001,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionImageCreateInfofuchsia = 1000366002,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionPropertiesfuchsia = 1000366003,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferConstraintsInfofuchsia = 1000366004,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionBufferCreateInfofuchsia = 1000366005,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    ImageConstraintsInfofuchsia = 1000366006,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    ImageFormatConstraintsInfofuchsia = 1000366007,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    SysmemColorSpacefuchsia = 1000366008,

    [NameAffix("Suffix", "FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionConstraintsInfofuchsia = 1000366009,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    SubpassShadingPipelineCreateInfohuawei = 1000369000,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceSubpassShadingFeatureshuawei = 1000369001,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceSubpassShadingPropertieshuawei = 1000369002,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_invocation_mask"],
        ImpliesSets = [
            "VK_KHR_ray_tracing_pipeline+VK_KHR_synchronization2",
            "VK_KHR_ray_tracing_pipeline+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceInvocationMaskFeatureshuawei = 1000370000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_rdma"],
        ImpliesSets = [
            "VK_NV_external_memory_rdma+VK_KHR_external_memory",
            "VK_NV_external_memory_rdma+VK_VERSION_1_1",
        ]
    )]
    MemoryGetRemoteAddressInfonv = 1000371000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_rdma"],
        ImpliesSets = [
            "VK_NV_external_memory_rdma+VK_KHR_external_memory",
            "VK_NV_external_memory_rdma+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalMemoryRdmaFeaturesnv = 1000371001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    PipelinePropertiesIdentifierext = 1000372000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelinePropertiesFeaturesext = 1000372001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAME_BOUNDARY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFrameBoundaryFeaturesext = 1000375000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FRAME_BOUNDARY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    FrameBoundaryext = 1000375001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    PhysicalDeviceMultisampledRenderToSingleSampledFeaturesext = 1000376000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    SubpassResolvePerformanceQueryext = 1000376001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    MultisampledRenderToSingleSampledInfoext = 1000376002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedDynamicState2Featuresext = 1000377000,

    [NameAffix("Suffix", "QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX")]
    [SupportedApiProfile("vulkan", ["VK_QNX_screen_surface"], ImpliesSets = ["VK_KHR_surface"])]
    ScreenSurfaceCreateInfoqnx = 1000378000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceColorWriteEnableFeaturesext = 1000381000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    PipelineColorWriteCreateInfoext = 1000381001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitives_generated_query"],
        ImpliesSets = ["VK_EXT_transform_feedback"]
    )]
    PhysicalDevicePrimitivesGeneratedQueryFeaturesext = 1000382000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDeviceRayTracingMaintenance1Featureskhr = 1000386000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNTYPED_POINTERS_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_untyped_pointers"],
        ImpliesSets = ["VK_KHR_get_physical_device_properties2"]
    )]
    PhysicalDeviceShaderUntypedPointersFeatureskhr = 1000387000,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_RGB_CONVERSION_FEATURES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVideoEncodeRgbConversionFeaturesvalve = 1000390000,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RGB_CONVERSION_CAPABILITIES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VideoEncodeRgbConversionCapabilitiesvalve = 1000390001,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_PROFILE_RGB_CONVERSION_INFO_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VideoEncodeProfileRgbConversionInfovalve = 1000390002,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_RGB_CONVERSION_CREATE_INFO_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VideoEncodeSessionRgbConversionCreateInfovalve = 1000390003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_view_min_lod"],
        ImpliesSets = [
            "VK_EXT_image_view_min_lod+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_view_min_lod+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageViewMinLodFeaturesext = 1000391000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_view_min_lod"],
        ImpliesSets = [
            "VK_EXT_image_view_min_lod+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_view_min_lod+VK_VERSION_1_1",
        ]
    )]
    ImageViewMinLodCreateInfoext = 1000391001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multi_draw"],
        ImpliesSets = [
            "VK_EXT_multi_draw+VK_KHR_get_physical_device_properties2",
            "VK_EXT_multi_draw+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiDrawFeaturesext = 1000392000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multi_draw"],
        ImpliesSets = [
            "VK_EXT_multi_draw+VK_KHR_get_physical_device_properties2",
            "VK_EXT_multi_draw+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiDrawPropertiesext = 1000392001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_2d_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImage2DViewOf3DFeaturesext = 1000393000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_FEATURES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    PhysicalDeviceShaderTileImageFeaturesext = 1000395000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    PhysicalDeviceShaderTileImagePropertiesext = 1000395001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    MicromapBuildInfoext = 1000396000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    MicromapVersionInfoext = 1000396001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    CopyMicromapInfoext = 1000396002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    CopyMicromapToMemoryInfoext = 1000396003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    CopyMemoryToMicromapInfoext = 1000396004,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceOpacityMicromapFeaturesext = 1000396005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceOpacityMicromapPropertiesext = 1000396006,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    MicromapCreateInfoext = 1000396007,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    MicromapBuildSizesInfoext = 1000396008,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    AccelerationStructureTrianglesOpacityMicromapext = 1000396009,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceClusterCullingShaderFeatureshuawei = 1000404000,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceClusterCullingShaderPropertieshuawei = 1000404001,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_VRS_FEATURES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceClusterCullingShaderVrsFeatureshuawei = 1000404002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    PhysicalDeviceBorderColorSwizzleFeaturesext = 1000411000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    SamplerBorderColorComponentMappingCreateInfoext = 1000411001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pageable_device_local_memory"],
        ImpliesSets = ["VK_EXT_memory_priority"]
    )]
    PhysicalDevicePageableDeviceLocalMemoryFeaturesext = 1000412000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_properties"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceShaderCorePropertiesarm = 1000415000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_SHADER_CORE_CONTROL_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    DeviceQueueShaderCoreControlCreateInfoarm = 1000417000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    PhysicalDeviceSchedulingControlsFeaturesarm = 1000417001,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    PhysicalDeviceSchedulingControlsPropertiesarm = 1000417002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_sliced_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageSlicedViewOf3DFeaturesext = 1000418000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_sliced_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    ImageViewSlicedCreateInfoext = 1000418001,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDescriptorSetHostMappingFeaturesvalve = 1000420000,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    DescriptorSetBindingReferencevalve = 1000420001,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    DescriptorSetLayoutHostMappingInfovalve = 1000420002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_non_seamless_cube_map"],
        ImpliesSets = [
            "VK_EXT_non_seamless_cube_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_non_seamless_cube_map+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceNonSeamlessCubeMapFeaturesext = 1000422000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceRenderPassStripedFeaturesarm = 1000424000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceRenderPassStripedPropertiesarm = 1000424001,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_BEGIN_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    RenderPassStripeBeginInfoarm = 1000424002,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    RenderPassStripeInfoarm = 1000424003,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_SUBMIT_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    RenderPassStripeSubmitInfoarm = 1000424004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceCopyMemoryIndirectFeaturesnv = 1000426000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesnv = 1000428000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    ComputePipelineIndirectBufferInfonv = 1000428001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INDIRECT_DEVICE_ADDRESS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    PipelineIndirectDeviceAddressInfonv = 1000428002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_LINEAR_SWEPT_SPHERES_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    PhysicalDeviceRayTracingLinearSweptSpheresFeaturesnv = 1000429008,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_LINEAR_SWEPT_SPHERES_DATA_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    AccelerationStructureGeometryLinearSweptSpheresDatanv = 1000429009,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_SPHERES_DATA_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    AccelerationStructureGeometrySpheresDatanv = 1000429010,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_linear_color_attachment"],
        ImpliesSets = [
            "VK_NV_linear_color_attachment+VK_KHR_get_physical_device_properties2",
            "VK_NV_linear_color_attachment+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLinearColorAttachmentFeaturesnv = 1000430000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MAXIMAL_RECONVERGENCE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_maximal_reconvergence"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceShaderMaximalReconvergenceFeatureskhr = 1000434000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control_swapchain"],
        ImpliesSets = ["VK_EXT_image_compression_control"]
    )]
    PhysicalDeviceImageCompressionControlSwapchainFeaturesext = 1000437000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceImageProcessingFeaturesqcom = 1000440000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceImageProcessingPropertiesqcom = 1000440001,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    ImageViewSampleWeightCreateInfoqcom = 1000440002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceNestedCommandBufferFeaturesext = 1000451000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceNestedCommandBufferPropertiesext = 1000451001,

    [NameAffix("Suffix", "OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_USAGE_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    NativeBufferUsageohos = 1000452000,

    [NameAffix("Suffix", "OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_PROPERTIES_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    NativeBufferPropertiesohos = 1000452001,

    [NameAffix("Suffix", "OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_FORMAT_PROPERTIES_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    NativeBufferFormatPropertiesohos = 1000452002,

    [NameAffix("Suffix", "OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_NATIVE_BUFFER_INFO_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ImportNativeBufferInfoohos = 1000452003,

    [NameAffix("Suffix", "OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_NATIVE_BUFFER_INFO_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    MemoryGetNativeBufferInfoohos = 1000452004,

    [NameAffix("Suffix", "OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ExternalFormatohos = 1000452005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_acquire_unmodified"],
        ImpliesSets = [
            "VK_EXT_external_memory_acquire_unmodified+VK_KHR_external_memory",
            "VK_EXT_external_memory_acquire_unmodified+VK_VERSION_1_1",
        ]
    )]
    ExternalMemoryAcquireUnmodifiedext = 1000453000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedDynamicState3Featuresext = 1000455000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedDynamicState3Propertiesext = 1000455001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSubpassMergeFeedbackFeaturesext = 1000458000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    RenderPassCreationControlext = 1000458001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    RenderPassCreationFeedbackCreateInfoext = 1000458002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    RenderPassSubpassFeedbackCreateInfoext = 1000458003,

    [NameAffix("Suffix", "LUNARG", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    DirectDriverLoadingInfolunarg = 1000459000,

    [NameAffix("Suffix", "LUNARG", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    DirectDriverLoadingListlunarg = 1000459001,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_CREATE_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorCreateInfoarm = 1000460000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_VIEW_CREATE_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorViewCreateInfoarm = 1000460001,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_TENSOR_MEMORY_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    BindTensorMemoryInfoarm = 1000460002,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_TENSOR_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    WriteDescriptorSetTensorarm = 1000460003,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_PROPERTIES_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    PhysicalDeviceTensorPropertiesarm = 1000460004,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_FORMAT_PROPERTIES_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorFormatPropertiesarm = 1000460005,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_DESCRIPTION_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorDescriptionarm = 1000460006,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_MEMORY_REQUIREMENTS_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorMemoryRequirementsInfoarm = 1000460007,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_MEMORY_BARRIER_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorMemoryBarrierarm = 1000460008,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_FEATURES_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    PhysicalDeviceTensorFeaturesarm = 1000460009,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_TENSOR_MEMORY_REQUIREMENTS_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    DeviceTensorMemoryRequirementsarm = 1000460010,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_TENSOR_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    CopyTensorInfoarm = 1000460011,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_COPY_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorCopyarm = 1000460012,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_DEPENDENCY_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorDependencyInfoarm = 1000460013,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_TENSOR_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    MemoryDedicatedAllocateInfoTensorarm = 1000460014,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_TENSOR_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    PhysicalDeviceExternalTensorInfoarm = 1000460015,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_TENSOR_PROPERTIES_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    ExternalTensorPropertiesarm = 1000460016,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_TENSOR_CREATE_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    ExternalMemoryTensorCreateInfoarm = 1000460017,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    PhysicalDeviceDescriptorBufferTensorFeaturesarm = 1000460018,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    PhysicalDeviceDescriptorBufferTensorPropertiesarm = 1000460019,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_GET_TENSOR_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    DescriptorGetTensorInfoarm = 1000460020,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_CAPTURE_DESCRIPTOR_DATA_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    TensorCaptureDescriptorDataInfoarm = 1000460021,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    TensorViewCaptureDescriptorDataInfoarm = 1000460022,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FRAME_BOUNDARY_TENSORS_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    FrameBoundaryTensorsarm = 1000460023,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceShaderModuleIdentifierFeaturesext = 1000462000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceShaderModuleIdentifierPropertiesext = 1000462001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_MODULE_IDENTIFIER_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PipelineShaderStageModuleIdentifierCreateInfoext = 1000462002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    ShaderModuleIdentifierext = 1000462003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesext = 1000342000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceOpticalFlowFeaturesnv = 1000464000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceOpticalFlowPropertiesnv = 1000464001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    OpticalFlowImageFormatInfonv = 1000464002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    OpticalFlowImageFormatPropertiesnv = 1000464003,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    OpticalFlowSessionCreateInfonv = 1000464004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    OpticalFlowExecuteInfonv = 1000464005,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    OpticalFlowSessionCreatePrivateDataInfonv = 1000464010,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_dithering"],
        ImpliesSets = [
            "VK_EXT_legacy_dithering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_legacy_dithering+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLegacyDitheringFeaturesext = 1000465000,

    [NameAffix("Suffix", "ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_FEATURES_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    PhysicalDeviceExternalFormatResolveFeaturesandroid = 1000468000,

    [NameAffix("Suffix", "ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    PhysicalDeviceExternalFormatResolvePropertiesandroid = 1000468001,

    [NameAffix("Suffix", "ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_RESOLVE_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    AndroidHardwareBufferFormatResolvePropertiesandroid = 1000468002,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ANTI_LAG_FEATURES_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAntiLagFeaturesamd = 1000476000,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANTI_LAG_DATA_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    AntiLagDataamd = 1000476001,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANTI_LAG_PRESENTATION_INFO_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    AntiLagPresentationInfoamd = 1000476002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_ID_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    SurfaceCapabilitiesPresentId2Khr = 1000479000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_ID_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    PresentId2Khr = 1000479001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_2_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    PhysicalDevicePresentId2Featureskhr = 1000479002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_WAIT_2_KHR")]
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
    SurfaceCapabilitiesPresentWait2Khr = 1000480000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_2_FEATURES_KHR")]
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
    PhysicalDevicePresentWait2Featureskhr = 1000480001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_WAIT_2_INFO_KHR")]
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
    PresentWait2Infokhr = 1000480002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_POSITION_FETCH_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_position_fetch"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDeviceRayTracingPositionFetchFeatureskhr = 1000481000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceShaderObjectFeaturesext = 1000482000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceShaderObjectPropertiesext = 1000482001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SHADER_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    ShaderCreateInfoext = 1000482002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PhysicalDevicePipelineBinaryFeatureskhr = 1000483000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryCreateInfokhr = 1000483001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryInfokhr = 1000483002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_KEY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryKeykhr = 1000483003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PhysicalDevicePipelineBinaryPropertieskhr = 1000483004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RELEASE_CAPTURED_PIPELINE_DATA_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    ReleaseCapturedPipelineDataInfokhr = 1000483005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_DATA_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryDataInfokhr = 1000483006,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineCreateInfokhr = 1000483007,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_PIPELINE_BINARY_INTERNAL_CACHE_CONTROL_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    DevicePipelineBinaryInternalCacheControlkhr = 1000483008,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_HANDLES_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryHandlesInfokhr = 1000483009,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTilePropertiesFeaturesqcom = 1000484000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    TilePropertiesqcom = 1000484001,

    [NameAffix("Suffix", "SEC", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAmigoProfilingFeaturessec = 1000485000,

    [NameAffix("Suffix", "SEC", 0)]
    [NativeName("VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    AmigoProfilingSubmitInfosec = 1000485001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    SurfacePresentModekhr = 1000274000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    SurfacePresentScalingCapabilitieskhr = 1000274001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    SurfacePresentModeCompatibilitykhr = 1000274002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    PhysicalDeviceSwapchainMaintenance1Featureskhr = 1000275000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    SwapchainPresentFenceInfokhr = 1000275001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    SwapchainPresentModesCreateInfokhr = 1000275002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    SwapchainPresentModeInfokhr = 1000275003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    SwapchainPresentScalingCreateInfokhr = 1000275004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    ReleaseSwapchainImagesInfokhr = 1000275005,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_viewports"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_viewports+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_viewports+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiviewPerViewViewportsFeaturesqcom = 1000488000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    PhysicalDeviceRayTracingInvocationReorderFeaturesnv = 1000490000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    PhysicalDeviceRayTracingInvocationReorderPropertiesnv = 1000490001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeVectorFeaturesnv = 1000491000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeVectorPropertiesnv = 1000491001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_VECTOR_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    CooperativeVectorPropertiesnv = 1000491002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CONVERT_COOPERATIVE_VECTOR_MATRIX_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    ConvertCooperativeVectorMatrixInfonv = 1000491004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_extended_sparse_address_space"],
        ImpliesSets = [
            "VK_NV_extended_sparse_address_space+VK_KHR_get_physical_device_properties2",
            "VK_NV_extended_sparse_address_space+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedSparseAddressSpaceFeaturesnv = 1000492000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_extended_sparse_address_space"],
        ImpliesSets = [
            "VK_NV_extended_sparse_address_space+VK_KHR_get_physical_device_properties2",
            "VK_NV_extended_sparse_address_space+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedSparseAddressSpacePropertiesnv = 1000492001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mutable_descriptor_type"],
        ImpliesSets = [
            "VK_EXT_mutable_descriptor_type+VK_KHR_maintenance3",
            "VK_EXT_mutable_descriptor_type+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMutableDescriptorTypeFeaturesext = 1000351000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mutable_descriptor_type"],
        ImpliesSets = [
            "VK_EXT_mutable_descriptor_type+VK_KHR_maintenance3",
            "VK_EXT_mutable_descriptor_type+VK_VERSION_1_1",
        ]
    )]
    MutableDescriptorTypeCreateInfoext = 1000351002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_vertex_attributes"],
        ImpliesSets = ["VK_EXT_vertex_input_dynamic_state"]
    )]
    PhysicalDeviceLegacyVertexAttributesFeaturesext = 1000495000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_vertex_attributes"],
        ImpliesSets = ["VK_EXT_vertex_input_dynamic_state"]
    )]
    PhysicalDeviceLegacyVertexAttributesPropertiesext = 1000495001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_LAYER_SETTINGS_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    LayerSettingsCreateInfoext = 1000496000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_builtins"],
        ImpliesSets = [
            "VK_ARM_shader_core_builtins+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_core_builtins+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderCoreBuiltinsFeaturesarm = 1000497000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_builtins"],
        ImpliesSets = [
            "VK_ARM_shader_core_builtins+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_core_builtins+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderCoreBuiltinsPropertiesarm = 1000497001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_LIBRARY_GROUP_HANDLES_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_library_group_handles"],
        ImpliesSets = ["VK_KHR_pipeline_library", "VK_KHR_ray_tracing_pipeline"]
    )]
    PhysicalDevicePipelineLibraryGroupHandlesFeaturesext = 1000498000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_FEATURES_EXT"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_dynamic_rendering_unused_attachments"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesext = 1000499000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SLEEP_MODE_INFO_NV")]
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
    LatencySleepModeInfonv = 1000505000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SLEEP_INFO_NV")]
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
    LatencySleepInfonv = 1000505001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SET_LATENCY_MARKER_INFO_NV")]
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
    SetLatencyMarkerInfonv = 1000505002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GET_LATENCY_MARKER_INFO_NV")]
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
    GetLatencyMarkerInfonv = 1000505003,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_LATENCY_TIMINGS_FRAME_REPORT_NV")]
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
    LatencyTimingsFrameReportnv = 1000505004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SUBMISSION_PRESENT_ID_NV")]
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
    LatencySubmissionPresentIdnv = 1000505005,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_OUT_OF_BAND_QUEUE_TYPE_INFO_NV")]
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
    OutOfBandQueueTypeInfonv = 1000505006,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_LATENCY_CREATE_INFO_NV")]
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
    SwapchainLatencyCreateInfonv = 1000505007,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_LATENCY_SURFACE_CAPABILITIES_NV")]
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
    LatencySurfaceCapabilitiesnv = 1000505008,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeMatrixFeatureskhr = 1000506000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    CooperativeMatrixPropertieskhr = 1000506001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeMatrixPropertieskhr = 1000506002,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineCreateInfoarm = 1000507000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineSessionCreateInfoarm = 1000507001,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_RESOURCE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineResourceInfoarm = 1000507002,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineConstantarm = 1000507003,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_MEMORY_REQUIREMENTS_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineSessionMemoryRequirementsInfoarm = 1000507004,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_DATA_GRAPH_PIPELINE_SESSION_MEMORY_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    BindDataGraphPipelineSessionMemoryInfoarm = 1000507005,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    PhysicalDeviceDataGraphFeaturesarm = 1000507006,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SHADER_MODULE_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineShaderModuleCreateInfoarm = 1000507007,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_PROPERTY_QUERY_RESULT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelinePropertyQueryResultarm = 1000507008,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineInfoarm = 1000507009,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_COMPILER_CONTROL_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineCompilerControlCreateInfoarm = 1000507010,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENTS_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineSessionBindPointRequirementsInfoarm = 1000507011,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineSessionBindPointRequirementarm = 1000507012,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_IDENTIFIER_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineIdentifierCreateInfoarm = 1000507013,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_DISPATCH_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineDispatchInfoarm = 1000507014,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PROCESSING_ENGINE_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphProcessingEngineCreateInfoarm = 1000507016,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    QueueFamilyDataGraphProcessingEnginePropertiesarm = 1000507017,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    QueueFamilyDataGraphPropertiesarm = 1000507018,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_INFO_ARM"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoarm = 1000507019,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_TENSOR_SEMI_STRUCTURED_SPARSITY_INFO_ARM"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph", "VK_ARM_tensors"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"],
        RequireAll = true
    )]
    DataGraphPipelineConstantTensorSemiStructuredSparsityInfoarm = 1000507015,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_render_areas"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_render_areas+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_render_areas+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiviewPerViewRenderAreasFeaturesqcom = 1000510000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_render_areas"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_render_areas+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_render_areas+VK_VERSION_1_1",
        ]
    )]
    MultiviewPerViewRenderAreasRenderPassBeginInfoqcom = 1000510001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_KHR_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_KHR_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceComputeShaderDerivativesFeatureskhr = 1000201000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_KHR_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_KHR_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceComputeShaderDerivativesPropertieskhr = 1000511000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeAv1Capabilitieskhr = 1000512000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeAv1PictureInfokhr = 1000512001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeAv1ProfileInfokhr = 1000512003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeAv1SessionParametersCreateInfokhr = 1000512004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeAv1DpbSlotInfokhr = 1000512005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1Capabilitieskhr = 1000513000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1SessionParametersCreateInfokhr = 1000513001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1PictureInfokhr = 1000513002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1DpbSlotInfokhr = 1000513003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_AV1_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PhysicalDeviceVideoEncodeAv1Featureskhr = 1000513004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1ProfileInfokhr = 1000513005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1RateControlInfokhr = 1000513006,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_LAYER_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1RateControlLayerInfokhr = 1000513007,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUALITY_LEVEL_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1QualityLevelPropertieskhr = 1000513008,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1SessionCreateInfokhr = 1000513009,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_GOP_REMAINING_FRAME_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1GopRemainingFrameInfokhr = 1000513010,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_DECODE_VP9_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    PhysicalDeviceVideoDecodeVp9Featureskhr = 1000514000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeVp9Capabilitieskhr = 1000514001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeVp9PictureInfokhr = 1000514002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeVp9ProfileInfokhr = 1000514003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_1_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance1"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    PhysicalDeviceVideoMaintenance1Featureskhr = 1000515000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_INLINE_QUERY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance1"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    VideoInlineQueryInfokhr = 1000515001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PER_STAGE_DESCRIPTOR_SET_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_per_stage_descriptor_set"],
        ImpliesSets = [
            "VK_NV_per_stage_descriptor_set+VK_KHR_maintenance6",
            "VK_NV_per_stage_descriptor_set+VK_VERSION_1_4",
        ]
    )]
    PhysicalDevicePerStageDescriptorSetFeaturesnv = 1000516000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    PhysicalDeviceImageProcessing2Featuresqcom = 1000518000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    PhysicalDeviceImageProcessing2Propertiesqcom = 1000518001,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    SamplerBlockMatchWindowCreateInfoqcom = 1000518002,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CUBIC_WEIGHTS_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    SamplerCubicWeightsCreateInfoqcom = 1000519000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_WEIGHTS_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    PhysicalDeviceCubicWeightsFeaturesqcom = 1000519001,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_CUBIC_WEIGHTS_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    BlitImageCubicWeightsInfoqcom = 1000519002,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_DEGAMMA_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_ycbcr_degamma"],
        ImpliesSets = [
            "VK_QCOM_ycbcr_degamma+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_ycbcr_degamma+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceYcbcrDegammaFeaturesqcom = 1000520000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_ycbcr_degamma"],
        ImpliesSets = [
            "VK_QCOM_ycbcr_degamma+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_ycbcr_degamma+VK_VERSION_1_1",
        ]
    )]
    SamplerYcbcrConversionYcbcrDegammaCreateInfoqcom = 1000520001,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_CLAMP_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_clamp"],
        ImpliesSets = [
            "VK_EXT_filter_cubic+VK_EXT_sampler_filter_minmax",
            "VK_EXT_filter_cubic+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceCubicClampFeaturesqcom = 1000521000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_FEATURES_EXT"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesext = 1000524000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFIED_IMAGE_LAYOUTS_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_unified_image_layouts"],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceUnifiedImageLayoutsFeatureskhr = 1000527000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_FEEDBACK_LOOP_INFO_EXT")]
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
    AttachmentFeedbackLoopInfoext = 1000527001,

    [NameAffix("Suffix", "QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SCREEN_BUFFER_PROPERTIES_QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ScreenBufferPropertiesqnx = 1000529000,

    [NameAffix("Suffix", "QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SCREEN_BUFFER_FORMAT_PROPERTIES_QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ScreenBufferFormatPropertiesqnx = 1000529001,

    [NameAffix("Suffix", "QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SCREEN_BUFFER_INFO_QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ImportScreenBufferInfoqnx = 1000529002,

    [NameAffix("Suffix", "QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ExternalFormatqnx = 1000529003,

    [NameAffix("Suffix", "QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCREEN_BUFFER_FEATURES_QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalMemoryScreenBufferFeaturesqnx = 1000529004,

    [NameAffix("Suffix", "MSFT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_DRIVER_PROPERTIES_MSFT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MSFT_layered_driver"],
        ImpliesSets = [
            "VK_MSFT_layered_driver+VK_KHR_get_physical_device_properties2",
            "VK_MSFT_layered_driver+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLayeredDriverPropertiesmsft = 1000530000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_calibrated_timestamps"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_KHR_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    CalibratedTimestampInfokhr = 1000184000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SET_DESCRIPTOR_BUFFER_OFFSETS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer", "VK_KHR_maintenance6"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    SetDescriptorBufferOffsetsInfoext = 1000545007,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_BUFFER_EMBEDDED_SAMPLERS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer", "VK_KHR_maintenance6"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    BindDescriptorBufferEmbeddedSamplersInfoext = 1000545008,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_POOL_OVERALLOCATION_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_descriptor_pool_overallocation"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceDescriptorPoolOverallocationFeaturesnv = 1000546000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTileMemoryHeapFeaturesqcom = 1000547000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTileMemoryHeapPropertiesqcom = 1000547001,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_REQUIREMENTS_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    TileMemoryRequirementsqcom = 1000547002,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_BIND_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    TileMemoryBindInfoqcom = 1000547003,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_SIZE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap", "VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    TileMemorySizeInfoqcom = 1000547004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceCopyMemoryIndirectFeatureskhr = 1000549000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceCopyMemoryIndirectPropertieskhr = 1000426001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_INDIRECT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    CopyMemoryIndirectInfokhr = 1000549002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INDIRECT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    CopyMemoryToImageIndirectInfokhr = 1000549003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    PhysicalDeviceMemoryDecompressionFeaturesext = 1000427000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    PhysicalDeviceMemoryDecompressionPropertiesext = 1000427001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DECOMPRESS_MEMORY_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    DecompressMemoryInfoext = 1000550002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_SURFACE_STEREO_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    DisplaySurfaceStereoCreateInfonv = 1000551000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_STEREO_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    DisplayModeStereoPropertiesnv = 1000551001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeIntraRefreshCapabilitieskhr = 1000552000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_INTRA_REFRESH_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeSessionIntraRefreshCreateInfokhr = 1000552001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeIntraRefreshInfokhr = 1000552002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_REFERENCE_INTRA_REFRESH_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoReferenceIntraRefreshInfokhr = 1000552003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_INTRA_REFRESH_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PhysicalDeviceVideoEncodeIntraRefreshFeatureskhr = 1000552004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeQuantizationMapCapabilitieskhr = 1000553000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_QUANTIZATION_MAP_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VideoFormatQuantizationMapPropertieskhr = 1000553001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeQuantizationMapInfokhr = 1000553002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_SESSION_PARAMETERS_CREATE_INFO_KHR"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeQuantizationMapSessionParametersCreateInfokhr = 1000553005,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUANTIZATION_MAP_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceVideoEncodeQuantizationMapFeatureskhr = 1000553009,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VideoEncodeH264QuantizationMapCapabilitieskhr = 1000553003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VideoEncodeH265QuantizationMapCapabilitieskhr = 1000553004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_H265_QUANTIZATION_MAP_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VideoFormatH265QuantizationMapPropertieskhr = 1000553006,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VideoEncodeAv1QuantizationMapCapabilitieskhr = 1000553007,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_AV1_QUANTIZATION_MAP_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VideoFormatAv1QuantizationMapPropertieskhr = 1000553008,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAW_ACCESS_CHAINS_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_raw_access_chains"],
        ImpliesSets = [
            "VK_NV_raw_access_chains+VK_KHR_get_physical_device_properties2",
            "VK_NV_raw_access_chains+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRawAccessChainsFeaturesnv = 1000555000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DEVICE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    ExternalComputeQueueDeviceCreateInfonv = 1000556000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    ExternalComputeQueueCreateInfonv = 1000556001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DATA_PARAMS_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    ExternalComputeQueueDataParamsnv = 1000556002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_COMPUTE_QUEUE_PROPERTIES_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    PhysicalDeviceExternalComputeQueuePropertiesnv = 1000556003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_RELAXED_EXTENDED_INSTRUCTION_FEATURES_KHR"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_relaxed_extended_instruction"],
        ImpliesSets = [
            "VK_KHR_shader_relaxed_extended_instruction+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_relaxed_extended_instruction+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderRelaxedExtendedInstructionFeatureskhr = 1000558000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMMAND_BUFFER_INHERITANCE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_command_buffer_inheritance"],
        ImpliesSets = [
            "VK_NV_command_buffer_inheritance+VK_KHR_get_physical_device_properties2",
            "VK_NV_command_buffer_inheritance+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCommandBufferInheritanceFeaturesnv = 1000559000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_FEATURES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance7Featureskhr = 1000562000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance7Propertieskhr = 1000562001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_LIST_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceLayeredApiPropertiesListkhr = 1000562002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceLayeredApiPropertieskhr = 1000562003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_VULKAN_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceLayeredApiVulkanPropertieskhr = 1000562004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT16_VECTOR_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shader_atomic_float16_vector"],
        ImpliesSets = [
            "VK_NV_shader_atomic_float16_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_shader_atomic_float16_vector+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderAtomicFloat16VectorFeaturesnv = 1000563000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_REPLICATED_COMPOSITES_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_replicated_composites"],
        ImpliesSets = [
            "VK_EXT_shader_replicated_composites+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_replicated_composites+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderReplicatedCompositesFeaturesext = 1000564000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT8_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_float8"],
        ImpliesSets = [
            "VK_EXT_shader_float8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_float8+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderFloat8Featuresext = 1000567000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_VALIDATION_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_validation"],
        ImpliesSets = [
            "VK_NV_ray_tracing_validation+VK_KHR_get_physical_device_properties2",
            "VK_NV_ray_tracing_validation+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRayTracingValidationFeaturesnv = 1000568000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDeviceClusterAccelerationStructureFeaturesnv = 1000569000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDeviceClusterAccelerationStructurePropertiesnv = 1000569001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_CLUSTERS_BOTTOM_LEVEL_INPUT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ClusterAccelerationStructureClustersBottomLevelInputnv = 1000569002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_TRIANGLE_CLUSTER_INPUT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ClusterAccelerationStructureTriangleClusterInputnv = 1000569003,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_MOVE_OBJECTS_INPUT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ClusterAccelerationStructureMoveObjectsInputnv = 1000569004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_INPUT_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ClusterAccelerationStructureInputInfonv = 1000569005,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_COMMANDS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ClusterAccelerationStructureCommandsInfonv = 1000569006,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CLUSTER_ACCELERATION_STRUCTURE_CREATE_INFO_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    RayTracingPipelineClusterAccelerationStructureCreateInfonv = 1000569007,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDevicePartitionedAccelerationStructureFeaturesnv = 1000570000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_PROPERTIES_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDevicePartitionedAccelerationStructurePropertiesnv = 1000570001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_PARTITIONED_ACCELERATION_STRUCTURE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    WriteDescriptorSetPartitionedAccelerationStructurenv = 1000570002,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCES_INPUT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PartitionedAccelerationStructureInstancesInputnv = 1000570003,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUILD_PARTITIONED_ACCELERATION_STRUCTURE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    BuildPartitionedAccelerationStructureInfonv = 1000570004,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_FLAGS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PartitionedAccelerationStructureFlagsnv = 1000570005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceDeviceGeneratedCommandsFeaturesext = 1000572000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceDeviceGeneratedCommandsPropertiesext = 1000572001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    GeneratedCommandsMemoryRequirementsInfoext = 1000572002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    IndirectExecutionSetCreateInfoext = 1000572003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    GeneratedCommandsInfoext = 1000572004,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    IndirectCommandsLayoutCreateInfoext = 1000572006,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    IndirectCommandsLayoutTokenext = 1000572007,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_PIPELINE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    WriteIndirectExecutionSetPipelineext = 1000572008,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_SHADER_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    WriteIndirectExecutionSetShaderext = 1000572009,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_PIPELINE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    IndirectExecutionSetPipelineInfoext = 1000572010,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    IndirectExecutionSetShaderInfoext = 1000572011,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_LAYOUT_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    IndirectExecutionSetShaderLayoutInfoext = 1000572012,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_PIPELINE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    GeneratedCommandsPipelineInfoext = 1000572013,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_SHADER_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    GeneratedCommandsShaderInfoext = 1000572014,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_8_FEATURES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance8Featureskhr = 1000574000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER_ACCESS_FLAGS_3_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    MemoryBarrierAccessFlags3Khr = 1000574002,

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_FEATURES_MESA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageAlignmentControlFeaturesmesa = 1000575000,

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_PROPERTIES_MESA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageAlignmentControlPropertiesmesa = 1000575001,

    [NameAffix("Suffix", "MESA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_ALIGNMENT_CONTROL_CREATE_INFO_MESA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    ImageAlignmentControlCreateInfomesa = 1000575002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FMA_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_fma"],
        ImpliesSets = [
            "VK_KHR_shader_fma+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_fma+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderFmaFeatureskhr = 1000579000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthClampControlFeaturesext = 1000582000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLAMP_CONTROL_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    PipelineViewportDepthClampControlCreateInfoext = 1000582001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMaintenance9Featureskhr = 1000584000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMaintenance9Propertieskhr = 1000584001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_OWNERSHIP_TRANSFER_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    QueueFamilyOwnershipTransferPropertieskhr = 1000584002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_2_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    PhysicalDeviceVideoMaintenance2Featureskhr = 1000586000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VideoDecodeH264InlineSessionParametersInfokhr = 1000586001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VideoDecodeH265InlineSessionParametersInfokhr = 1000586002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VideoDecodeAv1InlineSessionParametersInfokhr = 1000586003,

    [NameAffix("Suffix", "OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CREATE_INFO_OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_surface"], ImpliesSets = ["VK_KHR_surface"])]
    SurfaceCreateInfoohos = 1000685000,

    [NameAffix("Suffix", "OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_native_buffer"])]
    NativeBufferohos = 1000453001,

    [NameAffix("Suffix", "OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_IMAGE_CREATE_INFO_OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_native_buffer"])]
    SwapchainImageCreateInfoohos = 1000453002,

    [NameAffix("Suffix", "OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENTATION_PROPERTIES_OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_native_buffer"])]
    PhysicalDevicePresentationPropertiesohos = 1000453003,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HDR_VIVID_FEATURES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceHdrVividFeatureshuawei = 1000590000,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_HDR_VIVID_DYNAMIC_METADATA_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    HdrVividDynamicMetadatahuawei = 1000590001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    PhysicalDeviceCooperativeMatrix2Featuresnv = 1000593000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_FLEXIBLE_DIMENSIONS_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    CooperativeMatrixFlexibleDimensionsPropertiesnv = 1000593001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    PhysicalDeviceCooperativeMatrix2Propertiesnv = 1000593002,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_OPACITY_MICROMAP_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_pipeline_opacity_micromap"],
        ImpliesSets = ["VK_EXT_opacity_micromap"]
    )]
    PhysicalDevicePipelineOpacityMicromapFeaturesarm = 1000596000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_METAL_HANDLE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    ImportMemoryMetalHandleInfoext = 1000602000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_METAL_HANDLE_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    MemoryMetalHandlePropertiesext = 1000602001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_METAL_HANDLE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    MemoryGetMetalHandleInfoext = 1000602002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_clamp_zero_one"],
        ImpliesSets = [
            "VK_KHR_depth_clamp_zero_one+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_clamp_zero_one+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthClampZeroOneFeatureskhr = 1000421000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePerformanceCountersByRegionFeaturesarm = 1000605000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePerformanceCountersByRegionPropertiesarm = 1000605001,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    PerformanceCounterarm = 1000605002,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    PerformanceCounterDescriptionarm = 1000605003,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_PERFORMANCE_COUNTERS_BY_REGION_BEGIN_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    RenderPassPerformanceCountersByRegionBeginInfoarm = 1000605004,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_ROBUSTNESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_robustness"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_robustness+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexAttributeRobustnessFeaturesext = 1000608000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FORMAT_PACK_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFormatPackFeaturesarm = 1000609000,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_FEATURES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    PhysicalDeviceFragmentDensityMapLayeredFeaturesvalve = 1000611000,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_PROPERTIES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    PhysicalDeviceFragmentDensityMapLayeredPropertiesvalve = 1000611001,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_DENSITY_MAP_LAYERED_CREATE_INFO_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    PipelineFragmentDensityMapLayeredCreateInfovalve = 1000611002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRobustness2Featureskhr = 1000286000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRobustness2Propertieskhr = 1000286001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_EXT")]
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
    PhysicalDeviceFragmentDensityMapOffsetFeaturesext = 1000425000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_EXT")]
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
    PhysicalDeviceFragmentDensityMapOffsetPropertiesext = 1000425001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_EXT")]
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
    RenderPassFragmentDensityMapOffsetEndInfoext = 1000425002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_DEVICE_MEMORY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_zero_initialize_device_memory"],
        ImpliesSets = [
            "VK_EXT_zero_initialize_device_memory+VK_KHR_get_physical_device_properties2",
            "VK_EXT_zero_initialize_device_memory+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceZeroInitializeDeviceMemoryFeaturesext = 1000620000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    PhysicalDevicePresentModeFifoLatestReadyFeatureskhr = 1000361000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_64_BIT_INDEXING_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_64bit_indexing"],
        ImpliesSets = [
            "VK_EXT_shader_64bit_indexing+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_64bit_indexing+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShader64BitIndexingFeaturesext = 1000627000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_MODEL_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    PhysicalDeviceDataGraphModelFeaturesqcom = 1000629000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_BUILTIN_MODEL_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    DataGraphPipelineBuiltinModelCreateInfoqcom = 1000629001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMaintenance10Featureskhr = 1000630000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMaintenance10Propertieskhr = 1000630001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_FLAGS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    RenderingAttachmentFlagsInfokhr = 1000630002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_END_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    RenderingEndInfokhr = 1000619003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_MODE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    ResolveImageModeInfokhr = 1000630004,

    [NameAffix("Suffix", "SEC", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CACHE_INCREMENTAL_MODE_FEATURES_SEC")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_pipeline_cache_incremental_mode"],
        ImpliesSets = [
            "VK_SEC_pipeline_cache_incremental_mode+VK_KHR_get_physical_device_properties2",
            "VK_SEC_pipeline_cache_incremental_mode+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineCacheIncrementalModeFeaturessec = 1000637000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNIFORM_BUFFER_UNSIZED_ARRAY_FEATURES_EXT"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_uniform_buffer_unsized_array"],
        ImpliesSets = [
            "VK_EXT_shader_uniform_buffer_unsized_array+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_uniform_buffer_unsized_array+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesext = 1000642000,

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
    PhysicalDeviceVariablePointerFeatures = PhysicalDeviceVariablePointersFeatures,

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
    PhysicalDeviceShaderDrawParameterFeatures = PhysicalDeviceShaderDrawParametersFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    RenderingInfokhr = RenderingInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    RenderingAttachmentInfokhr = RenderingAttachmentInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PipelineRenderingCreateInfokhr = PipelineRenderingCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceDynamicRenderingFeatureskhr = PhysicalDeviceDynamicRenderingFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    CommandBufferInheritanceRenderingInfokhr = CommandBufferInheritanceRenderingInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    RenderPassMultiviewCreateInfokhr = RenderPassMultiviewCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiviewFeatureskhr = PhysicalDeviceMultiviewFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiviewPropertieskhr = PhysicalDeviceMultiviewProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    PhysicalDeviceFeatures2Khr = PhysicalDeviceFeatures2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    PhysicalDeviceProperties2Khr = PhysicalDeviceProperties2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    FormatProperties2Khr = FormatProperties2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    ImageFormatProperties2Khr = ImageFormatProperties2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    PhysicalDeviceImageFormatInfo2Khr = PhysicalDeviceImageFormatInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    QueueFamilyProperties2Khr = QueueFamilyProperties2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    PhysicalDeviceMemoryProperties2Khr = PhysicalDeviceMemoryProperties2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    SparseImageFormatProperties2Khr = SparseImageFormatProperties2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    PhysicalDeviceSparseImageFormatInfo2Khr = PhysicalDeviceSparseImageFormatInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    MemoryAllocateFlagsInfokhr = MemoryAllocateFlagsInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    DeviceGroupRenderPassBeginInfokhr = DeviceGroupRenderPassBeginInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    DeviceGroupCommandBufferBeginInfokhr = DeviceGroupCommandBufferBeginInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    DeviceGroupSubmitInfokhr = DeviceGroupSubmitInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    DeviceGroupBindSparseInfokhr = DeviceGroupBindSparseInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_bind_memory2", "VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"],
        RequireAll = true
    )]
    BindBufferMemoryDeviceGroupInfokhr = BindBufferMemoryDeviceGroupInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_bind_memory2", "VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"],
        RequireAll = true
    )]
    BindImageMemoryDeviceGroupInfokhr = BindImageMemoryDeviceGroupInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTextureCompressionAstcHdrFeaturesext =
        PhysicalDeviceTextureCompressionAstcHdrFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    PipelineRobustnessCreateInfoext = PipelineRobustnessCreateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineRobustnessFeaturesext = PhysicalDevicePipelineRobustnessFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineRobustnessPropertiesext = PhysicalDevicePipelineRobustnessProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_device_group_creation"])]
    PhysicalDeviceGroupPropertieskhr = PhysicalDeviceGroupProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_device_group_creation"])]
    DeviceGroupDeviceCreateInfokhr = DeviceGroupDeviceCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalImageFormatInfokhr = PhysicalDeviceExternalImageFormatInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    ExternalImageFormatPropertieskhr = ExternalImageFormatProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalBufferInfokhr = PhysicalDeviceExternalBufferInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    ExternalBufferPropertieskhr = ExternalBufferProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceIdPropertieskhr = PhysicalDeviceIdProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    ExternalMemoryBufferCreateInfokhr = ExternalMemoryBufferCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    ExternalMemoryImageCreateInfokhr = ExternalMemoryImageCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    ExportMemoryAllocateInfokhr = ExportMemoryAllocateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalSemaphoreInfokhr = PhysicalDeviceExternalSemaphoreInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    ExternalSemaphorePropertieskhr = ExternalSemaphoreProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore_capabilities"]
    )]
    ExportSemaphoreCreateInfokhr = ExportSemaphoreCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_push_descriptor"],
        ImpliesSets = [
            "VK_KHR_push_descriptor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_push_descriptor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePushDescriptorPropertieskhr = PhysicalDevicePushDescriptorProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float16_int8"],
        ImpliesSets = [
            "VK_KHR_shader_float16_int8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float16_int8+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderFloat16Int8Featureskhr = PhysicalDeviceShaderFloat16Int8Features,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float16_int8"],
        ImpliesSets = [
            "VK_KHR_shader_float16_int8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float16_int8+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFloat16Int8Featureskhr = PhysicalDeviceShaderFloat16Int8Features,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_16bit_storage"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDevice16BitStorageFeatureskhr = PhysicalDevice16BitStorageFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_descriptor_update_template"])]
    DescriptorUpdateTemplateCreateInfokhr = DescriptorUpdateTemplateCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceImagelessFramebufferFeatureskhr = PhysicalDeviceImagelessFramebufferFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    FramebufferAttachmentsCreateInfokhr = FramebufferAttachmentsCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    FramebufferAttachmentImageInfokhr = FramebufferAttachmentImageInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    RenderPassAttachmentBeginInfokhr = RenderPassAttachmentBeginInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    AttachmentDescription2Khr = AttachmentDescription2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    AttachmentReference2Khr = AttachmentReference2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    SubpassDescription2Khr = SubpassDescription2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    SubpassDependency2Khr = SubpassDependency2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    RenderPassCreateInfo2Khr = RenderPassCreateInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    SubpassBeginInfokhr = SubpassBeginInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    SubpassEndInfokhr = SubpassEndInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalFenceInfokhr = PhysicalDeviceExternalFenceInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    ExternalFencePropertieskhr = ExternalFenceProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence"],
        ImpliesSets = ["VK_KHR_external_fence_capabilities"]
    )]
    ExportFenceCreateInfokhr = ExportFenceCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    PhysicalDevicePointClippingPropertieskhr = PhysicalDevicePointClippingProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    RenderPassInputAttachmentAspectCreateInfokhr = RenderPassInputAttachmentAspectCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    ImageViewUsageCreateInfokhr = ImageViewUsageCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    PipelineTessellationDomainOriginStateCreateInfokhr =
        PipelineTessellationDomainOriginStateCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_variable_pointers"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVariablePointersFeatureskhr = PhysicalDeviceVariablePointersFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_variable_pointers"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVariablePointerFeatureskhr = PhysicalDeviceVariablePointersFeatureskhr,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dedicated_allocation"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_memory_requirements2",
            "VK_KHR_dedicated_allocation+VK_VERSION_1_1",
        ]
    )]
    MemoryDedicatedRequirementskhr = MemoryDedicatedRequirements,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dedicated_allocation"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_memory_requirements2",
            "VK_KHR_dedicated_allocation+VK_VERSION_1_1",
        ]
    )]
    MemoryDedicatedAllocateInfokhr = MemoryDedicatedAllocateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSamplerFilterMinmaxPropertiesext = PhysicalDeviceSamplerFilterMinmaxProperties,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    SamplerReductionModeCreateInfoext = SamplerReductionModeCreateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceInlineUniformBlockFeaturesext = PhysicalDeviceInlineUniformBlockFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceInlineUniformBlockPropertiesext = PhysicalDeviceInlineUniformBlockProperties,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    WriteDescriptorSetInlineUniformBlockext = WriteDescriptorSetInlineUniformBlock,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    DescriptorPoolInlineUniformBlockCreateInfoext = DescriptorPoolInlineUniformBlockCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    BufferMemoryRequirementsInfo2Khr = BufferMemoryRequirementsInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    ImageMemoryRequirementsInfo2Khr = ImageMemoryRequirementsInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    ImageSparseMemoryRequirementsInfo2Khr = ImageSparseMemoryRequirementsInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    MemoryRequirements2Khr = MemoryRequirements2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    SparseImageMemoryRequirements2Khr = SparseImageMemoryRequirements2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_image_format_list"])]
    ImageFormatListCreateInfokhr = ImageFormatListCreateInfo,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_dynamic_rendering",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_3",
        ]
    )]
    AttachmentSampleCountInfonv = AttachmentSampleCountInfoamd,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    SamplerYcbcrConversionCreateInfokhr = SamplerYcbcrConversionCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    SamplerYcbcrConversionInfokhr = SamplerYcbcrConversionInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    BindImagePlaneMemoryInfokhr = BindImagePlaneMemoryInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    ImagePlaneMemoryRequirementsInfokhr = ImagePlaneMemoryRequirementsInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSamplerYcbcrConversionFeatureskhr = PhysicalDeviceSamplerYcbcrConversionFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    SamplerYcbcrConversionImageFormatPropertieskhr = SamplerYcbcrConversionImageFormatProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_bind_memory2"])]
    BindBufferMemoryInfokhr = BindBufferMemoryInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_bind_memory2"])]
    BindImageMemoryInfokhr = BindImageMemoryInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    DescriptorSetLayoutBindingFlagsCreateInfoext = DescriptorSetLayoutBindingFlagsCreateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDescriptorIndexingFeaturesext = PhysicalDeviceDescriptorIndexingFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDescriptorIndexingPropertiesext = PhysicalDeviceDescriptorIndexingProperties,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    DescriptorSetVariableDescriptorCountAllocateInfoext =
        DescriptorSetVariableDescriptorCountAllocateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    DescriptorSetVariableDescriptorCountLayoutSupportext =
        DescriptorSetVariableDescriptorCountLayoutSupport,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance3"],
        ImpliesSets = [
            "VK_KHR_maintenance3+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance3+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMaintenance3Propertieskhr = PhysicalDeviceMaintenance3Properties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance3"],
        ImpliesSets = [
            "VK_KHR_maintenance3+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance3+VK_VERSION_1_1",
        ]
    )]
    DescriptorSetLayoutSupportkhr = DescriptorSetLayoutSupport,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    DeviceQueueGlobalPriorityCreateInfoext = DeviceQueueGlobalPriorityCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_extended_types"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceShaderSubgroupExtendedTypesFeatureskhr =
        PhysicalDeviceShaderSubgroupExtendedTypesFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_8bit_storage"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDevice8BitStorageFeatureskhr = PhysicalDevice8BitStorageFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_atomic_int64"],
        ImpliesSets = [
            "VK_KHR_shader_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderAtomicInt64Featureskhr = PhysicalDeviceShaderAtomicInt64Features,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_calibrated_timestamps"],
        ImpliesSets = [
            "VK_EXT_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_EXT_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    CalibratedTimestampInfoext = CalibratedTimestampInfokhr,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    DeviceQueueGlobalPriorityCreateInfokhr = DeviceQueueGlobalPriorityCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceGlobalPriorityQueryFeatureskhr = PhysicalDeviceGlobalPriorityQueryFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    QueueFamilyGlobalPriorityPropertieskhr = QueueFamilyGlobalPriorityProperties,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PipelineVertexInputDivisorStateCreateInfoext = PipelineVertexInputDivisorStateCreateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexAttributeDivisorFeaturesext = PhysicalDeviceVertexAttributeDivisorFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    PipelineCreationFeedbackCreateInfoext = PipelineCreationFeedbackCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDriverPropertieskhr = PhysicalDeviceDriverProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float_controls"],
        ImpliesSets = [
            "VK_KHR_shader_float_controls+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float_controls+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFloatControlsPropertieskhr = PhysicalDeviceFloatControlsProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceDepthStencilResolvePropertieskhr = PhysicalDeviceDepthStencilResolveProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    SubpassDescriptionDepthStencilResolvekhr = SubpassDescriptionDepthStencilResolve,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_NV_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_NV_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceComputeShaderDerivativesFeaturesnv =
        PhysicalDeviceComputeShaderDerivativesFeatureskhr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_NV_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_NV_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentShaderBarycentricFeaturesnv =
        PhysicalDeviceFragmentShaderBarycentricFeatureskhr,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTimelineSemaphoreFeatureskhr = PhysicalDeviceTimelineSemaphoreFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTimelineSemaphorePropertieskhr = PhysicalDeviceTimelineSemaphoreProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    SemaphoreTypeCreateInfokhr = SemaphoreTypeCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    TimelineSemaphoreSubmitInfokhr = TimelineSemaphoreSubmitInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    SemaphoreWaitInfokhr = SemaphoreWaitInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    SemaphoreSignalInfokhr = SemaphoreSignalInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vulkan_memory_model"],
        ImpliesSets = [
            "VK_KHR_vulkan_memory_model+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vulkan_memory_model+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVulkanMemoryModelFeatureskhr = PhysicalDeviceVulkanMemoryModelFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_terminate_invocation"],
        ImpliesSets = [
            "VK_KHR_shader_terminate_invocation+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_terminate_invocation+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderTerminateInvocationFeatureskhr =
        PhysicalDeviceShaderTerminateInvocationFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_scalar_block_layout"],
        ImpliesSets = [
            "VK_EXT_scalar_block_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_scalar_block_layout+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceScalarBlockLayoutFeaturesext = PhysicalDeviceScalarBlockLayoutFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceSubgroupSizeControlPropertiesext = PhysicalDeviceSubgroupSizeControlProperties,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PipelineShaderStageRequiredSubgroupSizeCreateInfoext =
        PipelineShaderStageRequiredSubgroupSizeCreateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceSubgroupSizeControlFeaturesext = PhysicalDeviceSubgroupSizeControlFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceDynamicRenderingLocalReadFeatureskhr =
        PhysicalDeviceDynamicRenderingLocalReadFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    RenderingAttachmentLocationInfokhr = RenderingAttachmentLocationInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    RenderingInputAttachmentIndexInfokhr = RenderingInputAttachmentIndexInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceSeparateDepthStencilLayoutsFeatureskhr =
        PhysicalDeviceSeparateDepthStencilLayoutsFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    AttachmentReferenceStencilLayoutkhr = AttachmentReferenceStencilLayout,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    AttachmentDescriptionStencilLayoutkhr = AttachmentDescriptionStencilLayout,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceBufferAddressFeaturesext = PhysicalDeviceBufferDeviceAddressFeaturesext,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    BufferDeviceAddressInfoext = BufferDeviceAddressInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    PhysicalDeviceToolPropertiesext = PhysicalDeviceToolProperties,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_separate_stencil_usage"])]
    ImageStencilUsageCreateInfoext = ImageStencilUsageCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_uniform_buffer_standard_layout"],
        ImpliesSets = [
            "VK_KHR_uniform_buffer_standard_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_uniform_buffer_standard_layout+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceUniformBufferStandardLayoutFeatureskhr =
        PhysicalDeviceUniformBufferStandardLayoutFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceBufferDeviceAddressFeatureskhr = PhysicalDeviceBufferDeviceAddressFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    BufferDeviceAddressInfokhr = BufferDeviceAddressInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    BufferOpaqueCaptureAddressCreateInfokhr = BufferOpaqueCaptureAddressCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    MemoryOpaqueCaptureAddressAllocateInfokhr = MemoryOpaqueCaptureAddressAllocateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    DeviceMemoryOpaqueCaptureAddressInfokhr = DeviceMemoryOpaqueCaptureAddressInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLineRasterizationFeaturesext = PhysicalDeviceLineRasterizationFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationLineStateCreateInfoext = PipelineRasterizationLineStateCreateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLineRasterizationPropertiesext = PhysicalDeviceLineRasterizationProperties,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_query_reset"],
        ImpliesSets = [
            "VK_EXT_host_query_reset+VK_KHR_get_physical_device_properties2",
            "VK_EXT_host_query_reset+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceHostQueryResetFeaturesext = PhysicalDeviceHostQueryResetFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_index_type_uint8"],
        ImpliesSets = [
            "VK_EXT_index_type_uint8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_index_type_uint8+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceIndexTypeUint8Featuresext = PhysicalDeviceIndexTypeUint8Features,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceHostImageCopyFeaturesext = PhysicalDeviceHostImageCopyFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceHostImageCopyPropertiesext = PhysicalDeviceHostImageCopyProperties,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    MemoryToImageCopyext = MemoryToImageCopy,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    ImageToMemoryCopyext = ImageToMemoryCopy,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    CopyImageToMemoryInfoext = CopyImageToMemoryInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    CopyMemoryToImageInfoext = CopyMemoryToImageInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    HostImageLayoutTransitionInfoext = HostImageLayoutTransitionInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    CopyImageToImageInfoext = CopyImageToImageInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    SubresourceHostMemcpySizeext = SubresourceHostMemcpySize,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    HostImageCopyDevicePerformanceQueryext = HostImageCopyDevicePerformanceQuery,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_map_memory2"])]
    MemoryMapInfokhr = MemoryMapInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_map_memory2"])]
    MemoryUnmapInfokhr = MemoryUnmapInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    SurfacePresentModeext = SurfacePresentModekhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    SurfacePresentScalingCapabilitiesext = SurfacePresentScalingCapabilitieskhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    SurfacePresentModeCompatibilityext = SurfacePresentModeCompatibilitykhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSwapchainMaintenance1Featuresext = PhysicalDeviceSwapchainMaintenance1Featureskhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    SwapchainPresentFenceInfoext = SwapchainPresentFenceInfokhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    SwapchainPresentModesCreateInfoext = SwapchainPresentModesCreateInfokhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    SwapchainPresentModeInfoext = SwapchainPresentModeInfokhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    SwapchainPresentScalingCreateInfoext = SwapchainPresentScalingCreateInfokhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    ReleaseSwapchainImagesInfoext = ReleaseSwapchainImagesInfokhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_demote_to_helper_invocation"],
        ImpliesSets = [
            "VK_EXT_shader_demote_to_helper_invocation+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_demote_to_helper_invocation+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderDemoteToHelperInvocationFeaturesext =
        PhysicalDeviceShaderDemoteToHelperInvocationFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_integer_dot_product"],
        ImpliesSets = [
            "VK_KHR_shader_integer_dot_product+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_integer_dot_product+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderIntegerDotProductFeatureskhr =
        PhysicalDeviceShaderIntegerDotProductFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_integer_dot_product"],
        ImpliesSets = [
            "VK_KHR_shader_integer_dot_product+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_integer_dot_product+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderIntegerDotProductPropertieskhr =
        PhysicalDeviceShaderIntegerDotProductProperties,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texel_buffer_alignment"],
        ImpliesSets = [
            "VK_EXT_texel_buffer_alignment+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texel_buffer_alignment+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTexelBufferAlignmentPropertiesext = PhysicalDeviceTexelBufferAlignmentProperties,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_robustness2"],
        ImpliesSets = [
            "VK_EXT_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_robustness2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRobustness2Featuresext = PhysicalDeviceRobustness2Featureskhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_robustness2"],
        ImpliesSets = [
            "VK_EXT_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_robustness2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRobustness2Propertiesext = PhysicalDeviceRobustness2Propertieskhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePrivateDataFeaturesext = PhysicalDevicePrivateDataFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    DevicePrivateDataCreateInfoext = DevicePrivateDataCreateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    PrivateDataSlotCreateInfoext = PrivateDataSlotCreateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_creation_cache_control"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineCreationCacheControlFeaturesext =
        PhysicalDevicePipelineCreationCacheControlFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    MemoryBarrier2Khr = MemoryBarrier2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    BufferMemoryBarrier2Khr = BufferMemoryBarrier2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    ImageMemoryBarrier2Khr = ImageMemoryBarrier2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    DependencyInfokhr = DependencyInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBMIT_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    SubmitInfo2Khr = SubmitInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    SemaphoreSubmitInfokhr = SemaphoreSubmitInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    CommandBufferSubmitInfokhr = CommandBufferSubmitInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSynchronization2Featureskhr = PhysicalDeviceSynchronization2Features,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_zero_initialize_workgroup_memory"],
        ImpliesSets = [
            "VK_KHR_zero_initialize_workgroup_memory+VK_KHR_get_physical_device_properties2",
            "VK_KHR_zero_initialize_workgroup_memory+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceZeroInitializeWorkgroupMemoryFeatureskhr =
        PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_robustness"],
        ImpliesSets = [
            "VK_EXT_image_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_robustness+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageRobustnessFeaturesext = PhysicalDeviceImageRobustnessFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    CopyBufferInfo2Khr = CopyBufferInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    CopyImageInfo2Khr = CopyImageInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    CopyBufferToImageInfo2Khr = CopyBufferToImageInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    CopyImageToBufferInfo2Khr = CopyImageToBufferInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    BlitImageInfo2Khr = BlitImageInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    ResolveImageInfo2Khr = ResolveImageInfo2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    BufferCopy2Khr = BufferCopy2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    ImageCopy2Khr = ImageCopy2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    ImageBlit2Khr = ImageBlit2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    BufferImageCopy2Khr = BufferImageCopy2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    ImageResolve2Khr = ImageResolve2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    SubresourceLayout2Ext = SubresourceLayout2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    ImageSubresource2Ext = ImageSubresource2,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_ARM"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesarm =
        PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesext,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_mutable_descriptor_type"],
        ImpliesSets = ["VK_KHR_maintenance3"]
    )]
    PhysicalDeviceMutableDescriptorTypeFeaturesvalve =
        PhysicalDeviceMutableDescriptorTypeFeaturesext,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_mutable_descriptor_type"],
        ImpliesSets = ["VK_KHR_maintenance3"]
    )]
    MutableDescriptorTypeCreateInfovalve = MutableDescriptorTypeCreateInfoext,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_format_feature_flags2"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_VERSION_1_1",
        ]
    )]
    FormatProperties3Khr = FormatProperties3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    PhysicalDevicePresentModeFifoLatestReadyFeaturesext =
        PhysicalDevicePresentModeFifoLatestReadyFeatureskhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineInfoext = PipelineInfokhr,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_global_priority_query"],
        ImpliesSets = [
            "VK_EXT_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_global_priority+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceGlobalPriorityQueryFeaturesext = PhysicalDeviceGlobalPriorityQueryFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_global_priority_query"],
        ImpliesSets = [
            "VK_EXT_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_global_priority+VK_VERSION_1_1",
        ]
    )]
    QueueFamilyGlobalPriorityPropertiesext = QueueFamilyGlobalPriorityProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance4Featureskhr = PhysicalDeviceMaintenance4Features,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance4Propertieskhr = PhysicalDeviceMaintenance4Properties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    DeviceBufferMemoryRequirementskhr = DeviceBufferMemoryRequirements,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    DeviceImageMemoryRequirementskhr = DeviceImageMemoryRequirements,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_rotate"],
        ImpliesSets = [
            "VK_KHR_shader_subgroup_rotate+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_subgroup_rotate+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderSubgroupRotateFeatureskhr = PhysicalDeviceShaderSubgroupRotateFeatures,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_zero_one"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_zero_one+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_zero_one+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthClampZeroOneFeaturesext = PhysicalDeviceDepthClampZeroOneFeatureskhr,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentDensityMapOffsetFeaturesqcom =
        PhysicalDeviceFragmentDensityMapOffsetFeaturesext,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentDensityMapOffsetPropertiesqcom =
        PhysicalDeviceFragmentDensityMapOffsetPropertiesext,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    SubpassFragmentDensityMapOffsetEndInfoqcom = RenderPassFragmentDensityMapOffsetEndInfoext,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceCopyMemoryIndirectPropertiesnv = PhysicalDeviceCopyMemoryIndirectPropertieskhr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceMemoryDecompressionFeaturesnv = PhysicalDeviceMemoryDecompressionFeaturesext,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceMemoryDecompressionPropertiesnv = PhysicalDeviceMemoryDecompressionPropertiesext,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_protected_access"],
        ImpliesSets = [
            "VK_EXT_pipeline_protected_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_protected_access+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineProtectedAccessFeaturesext =
        PhysicalDevicePipelineProtectedAccessFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    PhysicalDeviceMaintenance5Featureskhr = PhysicalDeviceMaintenance5Features,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    PhysicalDeviceMaintenance5Propertieskhr = PhysicalDeviceMaintenance5Properties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_AREA_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    RenderingAreaInfokhr = RenderingAreaInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    DeviceImageSubresourceInfokhr = DeviceImageSubresourceInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    SubresourceLayout2Khr = SubresourceLayout2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    ImageSubresource2Khr = ImageSubresource2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    PipelineCreateFlags2CreateInfokhr = PipelineCreateFlags2CreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    BufferUsageFlags2CreateInfokhr = BufferUsageFlags2CreateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SHADER_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    ShaderRequiredSubgroupSizeCreateInfoext = PipelineShaderStageRequiredSubgroupSizeCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexAttributeDivisorPropertieskhr =
        PhysicalDeviceVertexAttributeDivisorProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PipelineVertexInputDivisorStateCreateInfokhr = PipelineVertexInputDivisorStateCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexAttributeDivisorFeatureskhr = PhysicalDeviceVertexAttributeDivisorFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float_controls2"],
        ImpliesSets = ["VK_KHR_shader_float_controls", "VK_VERSION_1_1"]
    )]
    PhysicalDeviceShaderFloatControls2Featureskhr = PhysicalDeviceShaderFloatControls2Features,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_index_type_uint8"],
        ImpliesSets = [
            "VK_KHR_index_type_uint8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_index_type_uint8+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceIndexTypeUint8Featureskhr = PhysicalDeviceIndexTypeUint8Features,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLineRasterizationFeatureskhr = PhysicalDeviceLineRasterizationFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationLineStateCreateInfokhr = PipelineRasterizationLineStateCreateInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLineRasterizationPropertieskhr = PhysicalDeviceLineRasterizationProperties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_expect_assume"],
        ImpliesSets = [
            "VK_KHR_shader_expect_assume+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_expect_assume+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderExpectAssumeFeatureskhr = PhysicalDeviceShaderExpectAssumeFeatures,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance6Featureskhr = PhysicalDeviceMaintenance6Features,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance6Propertieskhr = PhysicalDeviceMaintenance6Properties,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    BindMemoryStatuskhr = BindMemoryStatus,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    BindDescriptorSetsInfokhr = BindDescriptorSetsInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    PushConstantsInfokhr = PushConstantsInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance6", "VK_KHR_push_descriptor"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    PushDescriptorSetInfokhr = PushDescriptorSetInfo,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance6", "VK_KHR_push_descriptor"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    PushDescriptorSetWithTemplateInfokhr = PushDescriptorSetWithTemplateInfo,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_END_INFO_EXT")]
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
    RenderingEndInfoext = RenderingEndInfokhr,
}
