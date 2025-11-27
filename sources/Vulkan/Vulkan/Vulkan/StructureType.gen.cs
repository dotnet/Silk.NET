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

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    SwapchainCreateInfoKHR = 1000001000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    PresentInfoKHR = 1000001001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    DeviceGroupPresentCapabilitiesKHR = 1000060007,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    ImageSwapchainCreateInfoKHR = 1000060008,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    BindImageMemorySwapchainInfoKHR = 1000060009,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    AcquireNextImageInfoKHR = 1000060010,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    DeviceGroupPresentInfoKHR = 1000060011,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    DeviceGroupSwapchainCreateInfoKHR = 1000060012,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    DisplayModeCreateInfoKHR = 1000002000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    DisplaySurfaceCreateInfoKHR = 1000002001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_display_swapchain"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_swapchain"]
    )]
    DisplayPresentInfoKHR = 1000003000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xlib_surface"], ImpliesSets = ["VK_KHR_surface"])]
    XlibSurfaceCreateInfoKHR = 1000004000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xcb_surface"], ImpliesSets = ["VK_KHR_surface"])]
    XcbSurfaceCreateInfoKHR = 1000005000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_wayland_surface"], ImpliesSets = ["VK_KHR_surface"])]
    WaylandSurfaceCreateInfoKHR = 1000006000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_android_surface"], ImpliesSets = ["VK_KHR_surface"])]
    AndroidSurfaceCreateInfoKHR = 1000008000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_win32_surface"], ImpliesSets = ["VK_KHR_surface"])]
    Win32SurfaceCreateInfoKHR = 1000009000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DebugReportCallbackCreateInfoEXT = 1000011000,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_rasterization_order"])]
    PipelineRasterizationStateRasterizationOrderAMD = 1000018000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    DebugMarkerObjectNameInfoEXT = 1000022000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    DebugMarkerObjectTagInfoEXT = 1000022001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    DebugMarkerMarkerInfoEXT = 1000022002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoProfileInfoKHR = 1000023000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoCapabilitiesKHR = 1000023001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoPictureResourceInfoKHR = 1000023002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoSessionMemoryRequirementsKHR = 1000023003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    BindVideoSessionMemoryInfoKHR = 1000023004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoSessionCreateInfoKHR = 1000023005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoSessionParametersCreateInfoKHR = 1000023006,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoSessionParametersUpdateInfoKHR = 1000023007,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoBeginCodingInfoKHR = 1000023008,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoEndCodingInfoKHR = 1000023009,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoCodingControlInfoKHR = 1000023010,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoReferenceSlotInfoKHR = 1000023011,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    QueueFamilyVideoPropertiesKHR = 1000023012,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoProfileListInfoKHR = 1000023013,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    PhysicalDeviceVideoFormatInfoKHR = 1000023014,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoFormatPropertiesKHR = 1000023015,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    QueueFamilyQueryResultStatusPropertiesKHR = 1000023016,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoDecodeInfoKHR = 1000024000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoDecodeCapabilitiesKHR = 1000024001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoDecodeUsageInfoKHR = 1000024002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    DedicatedAllocationImageCreateInfoNV = 1000026000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    DedicatedAllocationBufferCreateInfoNV = 1000026001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    DedicatedAllocationMemoryAllocateInfoNV = 1000026002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTransformFeedbackFeaturesEXT = 1000028000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTransformFeedbackPropertiesEXT = 1000028001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationStateStreamCreateInfoEXT = 1000028002,

    [NameSuffix("NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    CuModuleCreateInfoNVX = 1000029000,

    [NameSuffix("NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    CuFunctionCreateInfoNVX = 1000029001,

    [NameSuffix("NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    CuLaunchInfoNVX = 1000029002,

    [NameSuffix("NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CU_MODULE_TEXTURING_MODE_CREATE_INFO_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    CuModuleTexturingModeCreateInfoNVX = 1000029004,

    [NameSuffix("NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    ImageViewHandleInfoNVX = 1000030000,

    [NameSuffix("NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    ImageViewAddressPropertiesNVX = 1000030001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264CapabilitiesKHR = 1000038000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264SessionParametersCreateInfoKHR = 1000038001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264SessionParametersAddInfoKHR = 1000038002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264PictureInfoKHR = 1000038003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264DpbSlotInfoKHR = 1000038004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264NaluSliceInfoKHR = 1000038005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_GOP_REMAINING_FRAME_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264GopRemainingFrameInfoKHR = 1000038006,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264ProfileInfoKHR = 1000038007,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264RateControlInfoKHR = 1000038008,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264RateControlLayerInfoKHR = 1000038009,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264SessionCreateInfoKHR = 1000038010,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUALITY_LEVEL_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264QualityLevelPropertiesKHR = 1000038011,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_GET_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264SessionParametersGetInfoKHR = 1000038012,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH264SessionParametersFeedbackInfoKHR = 1000038013,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265CapabilitiesKHR = 1000039000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265SessionParametersCreateInfoKHR = 1000039001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265SessionParametersAddInfoKHR = 1000039002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265PictureInfoKHR = 1000039003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265DpbSlotInfoKHR = 1000039004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265NaluSliceSegmentInfoKHR = 1000039005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_GOP_REMAINING_FRAME_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265GopRemainingFrameInfoKHR = 1000039006,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265ProfileInfoKHR = 1000039007,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265RateControlInfoKHR = 1000039009,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265RateControlLayerInfoKHR = 1000039010,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265SessionCreateInfoKHR = 1000039011,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUALITY_LEVEL_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265QualityLevelPropertiesKHR = 1000039012,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_GET_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265SessionParametersGetInfoKHR = 1000039013,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeH265SessionParametersFeedbackInfoKHR = 1000039014,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264CapabilitiesKHR = 1000040000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264PictureInfoKHR = 1000040001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264ProfileInfoKHR = 1000040003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264SessionParametersCreateInfoKHR = 1000040004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264SessionParametersAddInfoKHR = 1000040005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH264DpbSlotInfoKHR = 1000040006,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_texture_gather_bias_lod"],
        ImpliesSets = [
            "VK_AMD_texture_gather_bias_lod+VK_KHR_get_physical_device_properties2",
            "VK_AMD_texture_gather_bias_lod+VK_VERSION_1_1",
        ]
    )]
    TextureLodGatherFormatPropertiesAMD = 1000041000,

    [NameSuffix("GGP", 0)]
    [NativeName("VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GGP_stream_descriptor_surface"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    StreamDescriptorSurfaceCreateInfoGGP = 1000049000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_corner_sampled_image"],
        ImpliesSets = [
            "VK_NV_corner_sampled_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_corner_sampled_image+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    ExternalMemoryImageCreateInfoNV = 1000056000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    ExportMemoryAllocateInfoNV = 1000056001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    ImportMemoryWin32HandleInfoNV = 1000057000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    ExportMemoryWin32HandleInfoNV = 1000057001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    ValidationFlagsEXT = 1000061000,

    [NameSuffix("NN", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN")]
    [SupportedApiProfile("vulkan", ["VK_NN_vi_surface"], ImpliesSets = ["VK_KHR_surface"])]
    ViSurfaceCreateInfoNN = 1000062000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    ImageViewAstcDecodeModeEXT = 1000067000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAstcDecodeFeaturesEXT = 1000067001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    ImportMemoryWin32HandleInfoKHR = 1000073000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    ExportMemoryWin32HandleInfoKHR = 1000073001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    MemoryWin32HandlePropertiesKHR = 1000073002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    MemoryGetWin32HandleInfoKHR = 1000073003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    ImportMemoryFdInfoKHR = 1000074000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    MemoryFdPropertiesKHR = 1000074001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    MemoryGetFdInfoKHR = 1000074002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_win32_keyed_mutex"],
        ImpliesSets = ["VK_KHR_external_memory_win32"]
    )]
    Win32KeyedMutexAcquireReleaseInfoKHR = 1000075000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    ImportSemaphoreWin32HandleInfoKHR = 1000078000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    ExportSemaphoreWin32HandleInfoKHR = 1000078001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    D3D12FenceSubmitInfoKHR = 1000078002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    SemaphoreGetWin32HandleInfoKHR = 1000078003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_fd"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_fd+VK_KHR_external_semaphore",
            "VK_KHR_external_semaphore_fd+VK_VERSION_1_1",
        ]
    )]
    ImportSemaphoreFdInfoKHR = 1000079000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_fd"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_fd+VK_KHR_external_semaphore",
            "VK_KHR_external_semaphore_fd+VK_VERSION_1_1",
        ]
    )]
    SemaphoreGetFdInfoKHR = 1000079001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    CommandBufferInheritanceConditionalRenderingInfoEXT = 1000081000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceConditionalRenderingFeaturesEXT = 1000081001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    ConditionalRenderingBeginInfoEXT = 1000081002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_incremental_present"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    PresentRegionsKHR = 1000084000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    PipelineViewportWScalingStateCreateInfoNV = 1000087000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    SurfaceCapabilities2EXT = 1000090000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    DisplayPowerInfoEXT = 1000091000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    DeviceEventInfoEXT = 1000091001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    DisplayEventInfoEXT = 1000091002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    SwapchainCounterCreateInfoEXT = 1000091003,

    [NameSuffix("GOOGLE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GOOGLE_display_timing"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    PresentTimesInfoGoogle = 1000092000,

    [NameSuffix("NVX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NVX_multiview_per_view_attributes"],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX = 1000097000,

    [NameSuffix("NVX", 0)]
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
    MultiviewPerViewAttributesInfoNVX = 1000044009,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    PipelineViewportSwizzleStateCreateInfoNV = 1000098000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDiscardRectanglePropertiesEXT = 1000099000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    PipelineDiscardRectangleStateCreateInfoEXT = 1000099001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceConservativeRasterizationPropertiesEXT = 1000101000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationConservativeStateCreateInfoEXT = 1000101001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthClipEnableFeaturesEXT = 1000102000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationDepthClipStateCreateInfoEXT = 1000102001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_HDR_METADATA_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    HdrMetadataEXT = 1000105000,

    [NameSuffix("IMG", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RELAXED_LINE_RASTERIZATION_FEATURES_IMG")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_IMG_relaxed_line_rasterization"],
        ImpliesSets = [
            "VK_IMG_relaxed_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_IMG_relaxed_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRelaxedLineRasterizationFeaturesIMG = 1000110000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    SharedPresentSurfaceCapabilitiesKHR = 1000111000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    ImportFenceWin32HandleInfoKHR = 1000114000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    ExportFenceWin32HandleInfoKHR = 1000114001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    FenceGetWin32HandleInfoKHR = 1000114002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_fd"],
        ImpliesSets = [
            "VK_KHR_external_fence_fd+VK_KHR_external_fence",
            "VK_KHR_external_fence_fd+VK_VERSION_1_1",
        ]
    )]
    ImportFenceFdInfoKHR = 1000115000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_fd"],
        ImpliesSets = [
            "VK_KHR_external_fence_fd+VK_KHR_external_fence",
            "VK_KHR_external_fence_fd+VK_VERSION_1_1",
        ]
    )]
    FenceGetFdInfoKHR = 1000115001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePerformanceQueryFeaturesKHR = 1000116000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePerformanceQueryPropertiesKHR = 1000116001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    QueryPoolPerformanceCreateInfoKHR = 1000116002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    PerformanceQuerySubmitInfoKHR = 1000116003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    AcquireProfilingLockInfoKHR = 1000116004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    PerformanceCounterKHR = 1000116005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    PerformanceCounterDescriptionKHR = 1000116006,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    PhysicalDeviceSurfaceInfo2KHR = 1000119000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    SurfaceCapabilities2KHR = 1000119001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    SurfaceFormat2KHR = 1000119002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    DisplayProperties2KHR = 1000121000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    DisplayPlaneProperties2KHR = 1000121001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    DisplayModeProperties2KHR = 1000121002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    DisplayPlaneInfo2KHR = 1000121003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    DisplayPlaneCapabilities2KHR = 1000121004,

    [NameSuffix("MVK", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK")]
    [SupportedApiProfile("vulkan", ["VK_MVK_ios_surface"], ImpliesSets = ["VK_KHR_surface"])]
    IosSurfaceCreateInfoMVK = 1000122000,

    [NameSuffix("MVK", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK")]
    [SupportedApiProfile("vulkan", ["VK_MVK_macos_surface"], ImpliesSets = ["VK_KHR_surface"])]
    MacosSurfaceCreateInfoMVK = 1000123000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsObjectNameInfoEXT = 1000128000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsObjectTagInfoEXT = 1000128001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsLabelEXT = 1000128002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsMessengerCallbackDataEXT = 1000128003,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsMessengerCreateInfoEXT = 1000128004,

    [NameSuffix("ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    AndroidHardwareBufferUsageAndroid = 1000129000,

    [NameSuffix("ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    AndroidHardwareBufferPropertiesAndroid = 1000129001,

    [NameSuffix("ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    AndroidHardwareBufferFormatPropertiesAndroid = 1000129002,

    [NameSuffix("ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ImportAndroidHardwareBufferInfoAndroid = 1000129003,

    [NameSuffix("ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    MemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,

    [NameSuffix("ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ExternalFormatAndroid = 1000129005,

    [NameSuffix("ANDROID", 0)]
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

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_AMD_mixed_attachment_samples+VK_KHR_dynamic_rendering",
            "VK_AMD_mixed_attachment_samples+VK_VERSION_1_3",
        ]
    )]
    AttachmentSampleCountInfoAMD = 1000044008,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_BFLOAT16_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderBfloat16FeaturesKHR = 1000141000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    SampleLocationsInfoEXT = 1000143000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    RenderPassSampleLocationsBeginInfoEXT = 1000143001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    PipelineSampleLocationsStateCreateInfoEXT = 1000143002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSampleLocationsPropertiesEXT = 1000143003,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    MultisamplePropertiesEXT = 1000143004,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    PipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    PipelineCoverageToColorStateCreateInfoNV = 1000149000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    WriteDescriptorSetAccelerationStructureKHR = 1000150007,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureBuildGeometryInfoKHR = 1000150000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureDeviceAddressInfoKHR = 1000150002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureGeometryAabbsDataKHR = 1000150003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureGeometryInstancesDataKHR = 1000150004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureGeometryTrianglesDataKHR = 1000150005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureGeometryKHR = 1000150006,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureVersionInfoKHR = 1000150009,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    CopyAccelerationStructureInfoKHR = 1000150010,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    CopyAccelerationStructureToMemoryInfoKHR = 1000150011,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    CopyMemoryToAccelerationStructureInfoKHR = 1000150012,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceAccelerationStructureFeaturesKHR = 1000150013,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceAccelerationStructurePropertiesKHR = 1000150014,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureCreateInfoKHR = 1000150017,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureBuildSizesInfoKHR = 1000150020,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceRayTracingPipelineFeaturesKHR = 1000347000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceRayTracingPipelinePropertiesKHR = 1000347001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingPipelineCreateInfoKHR = 1000150015,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingShaderGroupCreateInfoKHR = 1000150016,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    RayTracingPipelineInterfaceCreateInfoKHR = 1000150018,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_query"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceRayQueryFeaturesKHR = 1000348013,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    PipelineCoverageModulationStateCreateInfoNV = 1000152000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceShaderSmBuiltinsFeaturesNV = 1000154000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceShaderSmBuiltinsPropertiesNV = 1000154001,

    [NameSuffix("EXT", 0)]
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
    DrmFormatModifierPropertiesListEXT = 1000158000,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceImageDrmFormatModifierInfoEXT = 1000158002,

    [NameSuffix("EXT", 0)]
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
    ImageDrmFormatModifierListCreateInfoEXT = 1000158003,

    [NameSuffix("EXT", 0)]
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
    ImageDrmFormatModifierExplicitCreateInfoEXT = 1000158004,

    [NameSuffix("EXT", 0)]
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
    ImageDrmFormatModifierPropertiesEXT = 1000158005,

    [NameSuffix("EXT", 0)]
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
    DrmFormatModifierPropertiesList2EXT = 1000158006,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    ValidationCacheCreateInfoEXT = 1000160000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    ShaderModuleValidationCacheCreateInfoEXT = 1000160001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    PipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShadingRateImageFeaturesNV = 1000164001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShadingRateImagePropertiesNV = 1000164002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    PipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    RayTracingPipelineCreateInfoNV = 1000165000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    AccelerationStructureCreateInfoNV = 1000165001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    GeometryNV = 1000165003,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    GeometryTrianglesNV = 1000165004,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    GeometryAabbNV = 1000165005,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    BindAccelerationStructureMemoryInfoNV = 1000165006,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    WriteDescriptorSetAccelerationStructureNV = 1000165007,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    AccelerationStructureMemoryRequirementsInfoNV = 1000165008,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRayTracingPropertiesNV = 1000165009,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    RayTracingShaderGroupCreateInfoNV = 1000165011,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    AccelerationStructureInfoNV = 1000165012,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    PipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    PhysicalDeviceImageViewImageFormatInfoEXT = 1000170000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    FilterCubicImageViewImageFormatPropertiesEXT = 1000170001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    ImportMemoryHostPointerInfoEXT = 1000178000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    MemoryHostPointerPropertiesEXT = 1000178001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_clock"],
        ImpliesSets = [
            "VK_KHR_shader_clock+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_clock+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderClockFeaturesKHR = 1000181000,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_pipeline_compiler_control"])]
    PipelineCompilerControlCreateInfoAMD = 1000183000,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderCorePropertiesAMD = 1000185000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265CapabilitiesKHR = 1000187000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265SessionParametersCreateInfoKHR = 1000187001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265SessionParametersAddInfoKHR = 1000187002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265ProfileInfoKHR = 1000187003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265PictureInfoKHR = 1000187004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeH265DpbSlotInfoKHR = 1000187005,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    DeviceMemoryOverallocationCreateInfoAMD = 1000189000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,

    [NameSuffix("GGP", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GGP_frame_token"],
        ImpliesSets = ["VK_GGP_stream_descriptor_surface", "VK_KHR_swapchain"]
    )]
    PresentFrameTokenGGP = 1000191000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMeshShaderFeaturesNV = 1000202000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMeshShaderPropertiesNV = 1000202001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shader_image_footprint"],
        ImpliesSets = [
            "VK_NV_shader_image_footprint+VK_KHR_get_physical_device_properties2",
            "VK_NV_shader_image_footprint+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostic_checkpoints"],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    CheckpointDataNV = 1000206000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostic_checkpoints"],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    QueueFamilyCheckpointPropertiesNV = 1000206001,

    [NameSuffix("NV", 0)]
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
    QueueFamilyCheckpointProperties2NV = 1000314008,

    [NameSuffix("NV", 0)]
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
    CheckpointData2NV = 1000314009,

    [NameSuffix("INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_INTEL_shader_integer_functions2"],
        ImpliesSets = [
            "VK_INTEL_shader_integer_functions2+VK_KHR_get_physical_device_properties2",
            "VK_INTEL_shader_integer_functions2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderIntegerFunctions2FeaturesIntel = 1000209000,

    [NameSuffix("INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    QueryPoolPerformanceQueryCreateInfoIntel = 1000210000,

    [NameSuffix("INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    InitializePerformanceApiInfoIntel = 1000210001,

    [NameSuffix("INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    PerformanceMarkerInfoIntel = 1000210002,

    [NameSuffix("INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    PerformanceStreamMarkerInfoIntel = 1000210003,

    [NameSuffix("INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    PerformanceOverrideInfoIntel = 1000210004,

    [NameSuffix("INTEL", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    PerformanceConfigurationAcquireInfoIntel = 1000210005,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pci_bus_info"],
        ImpliesSets = [
            "VK_EXT_pci_bus_info+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pci_bus_info+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePciBusInfoPropertiesEXT = 1000212000,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    DisplayNativeHdrSurfaceCapabilitiesAMD = 1000213000,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    SwapchainDisplayNativeHdrCreateInfoAMD = 1000213001,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_imagepipe_surface"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    ImagepipeSurfaceCreateInfoFuchsia = 1000214000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_surface"], ImpliesSets = ["VK_KHR_surface"])]
    MetalSurfaceCreateInfoEXT = 1000217000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    RenderPassFragmentDensityMapCreateInfoEXT = 1000218002,

    [NameSuffix("EXT", 0)]
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
    RenderingFragmentDensityMapAttachmentInfoEXT = 1000044007,

    [NameSuffix("KHR", 0)]
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
    FragmentShadingRateAttachmentInfoKHR = 1000226000,

    [NameSuffix("KHR", 0)]
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
    PipelineFragmentShadingRateStateCreateInfoKHR = 1000226001,

    [NameSuffix("KHR", 0)]
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
    PhysicalDeviceFragmentShadingRatePropertiesKHR = 1000226002,

    [NameSuffix("KHR", 0)]
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
    PhysicalDeviceFragmentShadingRateFeaturesKHR = 1000226003,

    [NameSuffix("KHR", 0)]
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
    PhysicalDeviceFragmentShadingRateKHR = 1000226004,

    [NameSuffix("KHR", 0)]
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
    RenderingFragmentShadingRateAttachmentInfoKHR = 1000044006,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties2"],
        ImpliesSets = ["VK_AMD_shader_core_properties"]
    )]
    PhysicalDeviceShaderCoreProperties2AMD = 1000227000,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_device_coherent_memory"],
        ImpliesSets = [
            "VK_AMD_device_coherent_memory+VK_KHR_get_physical_device_properties2",
            "VK_AMD_device_coherent_memory+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCoherentMemoryFeaturesAMD = 1000229000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_image_atomic_int64"],
        ImpliesSets = [
            "VK_EXT_shader_image_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_image_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderImageAtomicInt64FeaturesEXT = 1000234000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_QUAD_CONTROL_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_quad_control"],
        ImpliesSets = [
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_1+VK_KHR_vulkan_memory_model",
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceShaderQuadControlFeaturesKHR = 1000235000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_budget"],
        ImpliesSets = [
            "VK_EXT_memory_budget+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_budget+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMemoryBudgetPropertiesEXT = 1000237000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_priority"],
        ImpliesSets = [
            "VK_EXT_memory_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_priority+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMemoryPriorityFeaturesEXT = 1000238000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_priority"],
        ImpliesSets = [
            "VK_EXT_memory_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_priority+VK_VERSION_1_1",
        ]
    )]
    MemoryPriorityAllocateInfoEXT = 1000238001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_protected_capabilities"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_VERSION_1_1"]
    )]
    SurfaceProtectedCapabilitiesKHR = 1000239000,

    [NameSuffix("NV", 0)]
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
    PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceBufferDeviceAddressFeaturesEXT = 1000244000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    BufferDeviceAddressCreateInfoEXT = 1000244002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ValidationFeaturesEXT = 1000247000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait"],
        ImpliesSets = ["VK_KHR_present_id", "VK_KHR_swapchain"]
    )]
    PhysicalDevicePresentWaitFeaturesKHR = 1000248000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    CooperativeMatrixPropertiesNV = 1000249001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    PipelineCoverageReductionStateCreateInfoNV = 1000250001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    FramebufferMixedSamplesCombinationNV = 1000250002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_shader_interlock"],
        ImpliesSets = [
            "VK_EXT_fragment_shader_interlock+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_shader_interlock+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentShaderInterlockFeaturesEXT = 1000251000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_image_arrays"],
        ImpliesSets = [
            "VK_EXT_ycbcr_image_arrays+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_image_arrays+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceYcbcrImageArraysFeaturesEXT = 1000252000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceProvokingVertexFeaturesEXT = 1000254000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationProvokingVertexStateCreateInfoEXT = 1000254001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceProvokingVertexPropertiesEXT = 1000254002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    SurfaceFullScreenExclusiveInfoEXT = 1000255000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    SurfaceCapabilitiesFullScreenExclusiveEXT = 1000255002,

    [NameSuffix("EXT", 0)]
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
    SurfaceFullScreenExclusiveWin32InfoEXT = 1000255001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_headless_surface"], ImpliesSets = ["VK_KHR_surface"])]
    HeadlessSurfaceCreateInfoEXT = 1000256000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderAtomicFloatFeaturesEXT = 1000260000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedDynamicStateFeaturesEXT = 1000267000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineExecutablePropertiesFeaturesKHR = 1000269000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineInfoKHR = 1000269001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineExecutablePropertiesKHR = 1000269002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineExecutableInfoKHR = 1000269003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineExecutableStatisticKHR = 1000269004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineExecutableInternalRepresentationKHR = 1000269005,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    PhysicalDeviceMapMemoryPlacedFeaturesEXT = 1000272000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    PhysicalDeviceMapMemoryPlacedPropertiesEXT = 1000272001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MAP_PLACED_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    MemoryMapPlacedInfoEXT = 1000272002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    PhysicalDeviceShaderAtomicFloat2FeaturesEXT = 1000273000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    PhysicalDeviceDeviceGeneratedCommandsPropertiesNV = 1000277000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    GraphicsShaderGroupCreateInfoNV = 1000277001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    GraphicsPipelineShaderGroupsCreateInfoNV = 1000277002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    IndirectCommandsLayoutTokenNV = 1000277003,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    IndirectCommandsLayoutCreateInfoNV = 1000277004,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    GeneratedCommandsInfoNV = 1000277005,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    GeneratedCommandsMemoryRequirementsInfoNV = 1000277006,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    PhysicalDeviceDeviceGeneratedCommandsFeaturesNV = 1000277007,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_inherited_viewport_scissor"],
        ImpliesSets = [
            "VK_NV_inherited_viewport_scissor+VK_KHR_get_physical_device_properties2",
            "VK_NV_inherited_viewport_scissor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceInheritedViewportScissorFeaturesNV = 1000278000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_inherited_viewport_scissor"],
        ImpliesSets = [
            "VK_NV_inherited_viewport_scissor+VK_KHR_get_physical_device_properties2",
            "VK_NV_inherited_viewport_scissor+VK_VERSION_1_1",
        ]
    )]
    CommandBufferInheritanceViewportScissorInfoNV = 1000278001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texel_buffer_alignment"],
        ImpliesSets = [
            "VK_EXT_texel_buffer_alignment+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texel_buffer_alignment+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTexelBufferAlignmentFeaturesEXT = 1000281000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    CommandBufferInheritanceRenderPassTransformInfoQCOM = 1000282000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    RenderPassTransformBeginInfoQCOM = 1000282001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthBiasControlFeaturesEXT = 1000283000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEPTH_BIAS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    DepthBiasInfoEXT = 1000283001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEPTH_BIAS_REPRESENTATION_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    DepthBiasRepresentationInfoEXT = 1000283002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDeviceMemoryReportFeaturesEXT = 1000284000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    DeviceDeviceMemoryReportCreateInfoEXT = 1000284001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    DeviceMemoryReportCallbackDataEXT = 1000284002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    SamplerCustomBorderColorCreateInfoEXT = 1000287000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCustomBorderColorPropertiesEXT = 1000287001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCustomBorderColorFeaturesEXT = 1000287002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    PipelineLibraryCreateInfoKHR = 1000290000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePresentBarrierFeaturesNV = 1000292000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    SurfaceCapabilitiesPresentBarrierNV = 1000292001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    SwapchainPresentBarrierCreateInfoNV = 1000292002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_ID_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    PresentIdKHR = 1000294000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePresentIdFeaturesKHR = 1000294001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeInfoKHR = 1000299000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeRateControlInfoKHR = 1000299001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeRateControlLayerInfoKHR = 1000299002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeCapabilitiesKHR = 1000299003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeUsageInfoKHR = 1000299004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    QueryPoolVideoEncodeFeedbackCreateInfoKHR = 1000299005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceVideoEncodeQualityLevelInfoKHR = 1000299006,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeQualityLevelPropertiesKHR = 1000299007,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeQualityLevelInfoKHR = 1000299008,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_GET_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeSessionParametersGetInfoKHR = 1000299009,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_FEEDBACK_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeSessionParametersFeedbackInfoKHR = 1000299010,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    DeviceDiagnosticsConfigCreateInfoNV = 1000300001,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    PhysicalDeviceTileShadingFeaturesQCOM = 1000309000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    PhysicalDeviceTileShadingPropertiesQCOM = 1000309001,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_TILE_SHADING_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    RenderPassTileShadingCreateInfoQCOM = 1000309002,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PER_TILE_BEGIN_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    PerTileBeginInfoQCOM = 1000309003,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PER_TILE_END_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    PerTileEndInfoQCOM = 1000309004,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPATCH_TILE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    DispatchTileInfoQCOM = 1000309005,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_low_latency"])]
    QueryLowLatencySupportNV = 1000310000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalObjectCreateInfoEXT = 1000311000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalObjectsInfoEXT = 1000311001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalDeviceInfoEXT = 1000311002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalCommandQueueInfoEXT = 1000311003,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalBufferInfoEXT = 1000311004,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ImportMetalBufferInfoEXT = 1000311005,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalTextureInfoEXT = 1000311006,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ImportMetalTextureInfoEXT = 1000311007,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalIoSurfaceInfoEXT = 1000311008,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ImportMetalIoSurfaceInfoEXT = 1000311009,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ExportMetalSharedEventInfoEXT = 1000311010,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    ImportMetalSharedEventInfoEXT = 1000311011,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceDescriptorBufferPropertiesEXT = 1000316000,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceDescriptorBufferDensityMapPropertiesEXT = 1000316001,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceDescriptorBufferFeaturesEXT = 1000316002,

    [NameSuffix("EXT", 0)]
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
    DescriptorAddressInfoEXT = 1000316003,

    [NameSuffix("EXT", 0)]
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
    DescriptorGetInfoEXT = 1000316004,

    [NameSuffix("EXT", 0)]
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
    BufferCaptureDescriptorDataInfoEXT = 1000316005,

    [NameSuffix("EXT", 0)]
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
    ImageCaptureDescriptorDataInfoEXT = 1000316006,

    [NameSuffix("EXT", 0)]
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
    ImageViewCaptureDescriptorDataInfoEXT = 1000316007,

    [NameSuffix("EXT", 0)]
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
    SamplerCaptureDescriptorDataInfoEXT = 1000316008,

    [NameSuffix("EXT", 0)]
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
    OpaqueCaptureDescriptorDataCreateInfoEXT = 1000316010,

    [NameSuffix("EXT", 0)]
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
    DescriptorBufferBindingInfoEXT = 1000316011,

    [NameSuffix("EXT", 0)]
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
    DescriptorBufferBindingPushDescriptorBufferHandleEXT = 1000316012,

    [NameSuffix("EXT", 0)]
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
    AccelerationStructureCaptureDescriptorDataInfoEXT = 1000316009,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT = 1000320000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT = 1000320001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    GraphicsPipelineLibraryCreateInfoEXT = 1000320002,

    [NameSuffix("AMD", 0)]
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
    PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD = 1000321000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentShaderBarycentricFeaturesKHR = 1000203000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentShaderBarycentricPropertiesKHR = 1000322000,

    [NameSuffix("KHR", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_uniform_control_flow"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR = 1000323000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    PhysicalDeviceFragmentShadingRateEnumsPropertiesNV = 1000326000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    PhysicalDeviceFragmentShadingRateEnumsFeaturesNV = 1000326001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    PipelineFragmentShadingRateEnumStateCreateInfoNV = 1000326002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    AccelerationStructureGeometryMotionTrianglesDataNV = 1000327000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    PhysicalDeviceRayTracingMotionBlurFeaturesNV = 1000327001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    AccelerationStructureMotionInfoNV = 1000327002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
    )]
    PhysicalDeviceMeshShaderFeaturesEXT = 1000328000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
    )]
    PhysicalDeviceMeshShaderPropertiesEXT = 1000328001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_2plane_444_formats"],
        ImpliesSets = [
            "VK_EXT_ycbcr_2plane_444_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_2plane_444_formats+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT = 1000330000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    PhysicalDeviceFragmentDensityMap2FeaturesEXT = 1000332000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    PhysicalDeviceFragmentDensityMap2PropertiesEXT = 1000332001,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_rotated_copy_commands"],
        ImpliesSets = [
            "VK_QCOM_rotated_copy_commands+VK_KHR_copy_commands2",
            "VK_QCOM_rotated_copy_commands+VK_VERSION_1_3",
        ]
    )]
    CopyCommandTransformInfoQCOM = 1000333000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_workgroup_memory_explicit_layout"],
        ImpliesSets = [
            "VK_KHR_workgroup_memory_explicit_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_workgroup_memory_explicit_layout+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR = 1000336000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageCompressionControlFeaturesEXT = 1000338000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    ImageCompressionControlEXT = 1000338001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    ImageCompressionPropertiesEXT = 1000338004,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_layout"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT = 1000339000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_4444_formats"],
        ImpliesSets = [
            "VK_EXT_4444_formats+VK_KHR_get_physical_device_properties2",
            "VK_EXT_4444_formats+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevice4444FormatsFeaturesEXT = 1000340000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFaultFeaturesEXT = 1000341000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    DeviceFaultCountsEXT = 1000341001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    DeviceFaultInfoEXT = 1000341002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rgba10x6_formats"],
        ImpliesSets = [
            "VK_EXT_rgba10x6_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_rgba10x6_formats+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRgba10X6FormatsFeaturesEXT = 1000344000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_directfb_surface"], ImpliesSets = ["VK_KHR_surface"])]
    DirectfbSurfaceCreateInfoEXT = 1000346000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexInputDynamicStateFeaturesEXT = 1000352000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VertexInputBindingDescription2EXT = 1000352001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VertexInputAttributeDescription2EXT = 1000352002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDrmPropertiesEXT = 1000353000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAddressBindingReportFeaturesEXT = 1000354000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    DeviceAddressBindingCallbackDataEXT = 1000354001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control"],
        ImpliesSets = [
            "VK_EXT_depth_clip_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthClipControlFeaturesEXT = 1000355000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control"],
        ImpliesSets = [
            "VK_EXT_depth_clip_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_control+VK_VERSION_1_1",
        ]
    )]
    PipelineViewportDepthClipControlCreateInfoEXT = 1000355001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitive_topology_list_restart"],
        ImpliesSets = [
            "VK_EXT_primitive_topology_list_restart+VK_KHR_get_physical_device_properties2",
            "VK_EXT_primitive_topology_list_restart+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT = 1000356000,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    ImportMemoryZirconHandleInfoFuchsia = 1000364000,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    MemoryZirconHandlePropertiesFuchsia = 1000364001,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    MemoryGetZirconHandleInfoFuchsia = 1000364002,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore", "VK_KHR_external_semaphore_capabilities"]
    )]
    ImportSemaphoreZirconHandleInfoFuchsia = 1000365000,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore", "VK_KHR_external_semaphore_capabilities"]
    )]
    SemaphoreGetZirconHandleInfoFuchsia = 1000365001,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionCreateInfoFuchsia = 1000366000,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    ImportMemoryBufferCollectionFuchsia = 1000366001,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionImageCreateInfoFuchsia = 1000366002,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionPropertiesFuchsia = 1000366003,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferConstraintsInfoFuchsia = 1000366004,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionBufferCreateInfoFuchsia = 1000366005,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    ImageConstraintsInfoFuchsia = 1000366006,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    ImageFormatConstraintsInfoFuchsia = 1000366007,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    SysmemColorSpaceFuchsia = 1000366008,

    [NameSuffix("FUCHSIA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionConstraintsInfoFuchsia = 1000366009,

    [NameSuffix("HUAWEI", 0)]
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
    SubpassShadingPipelineCreateInfoHuawei = 1000369000,

    [NameSuffix("HUAWEI", 0)]
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
    PhysicalDeviceSubpassShadingFeaturesHuawei = 1000369001,

    [NameSuffix("HUAWEI", 0)]
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
    PhysicalDeviceSubpassShadingPropertiesHuawei = 1000369002,

    [NameSuffix("HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_invocation_mask"],
        ImpliesSets = [
            "VK_KHR_ray_tracing_pipeline+VK_KHR_synchronization2",
            "VK_KHR_ray_tracing_pipeline+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceInvocationMaskFeaturesHuawei = 1000370000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_rdma"],
        ImpliesSets = [
            "VK_NV_external_memory_rdma+VK_KHR_external_memory",
            "VK_NV_external_memory_rdma+VK_VERSION_1_1",
        ]
    )]
    MemoryGetRemoteAddressInfoNV = 1000371000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_rdma"],
        ImpliesSets = [
            "VK_NV_external_memory_rdma+VK_KHR_external_memory",
            "VK_NV_external_memory_rdma+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalMemoryRdmaFeaturesNV = 1000371001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    PipelinePropertiesIdentifierEXT = 1000372000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelinePropertiesFeaturesEXT = 1000372001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAME_BOUNDARY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFrameBoundaryFeaturesEXT = 1000375000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FRAME_BOUNDARY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    FrameBoundaryEXT = 1000375001,

    [NameSuffix("EXT", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT = 1000376000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    SubpassResolvePerformanceQueryEXT = 1000376001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    MultisampledRenderToSingleSampledInfoEXT = 1000376002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedDynamicState2FeaturesEXT = 1000377000,

    [NameSuffix("QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX")]
    [SupportedApiProfile("vulkan", ["VK_QNX_screen_surface"], ImpliesSets = ["VK_KHR_surface"])]
    ScreenSurfaceCreateInfoQNX = 1000378000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceColorWriteEnableFeaturesEXT = 1000381000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    PipelineColorWriteCreateInfoEXT = 1000381001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitives_generated_query"],
        ImpliesSets = ["VK_EXT_transform_feedback"]
    )]
    PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT = 1000382000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDeviceRayTracingMaintenance1FeaturesKHR = 1000386000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNTYPED_POINTERS_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_untyped_pointers"],
        ImpliesSets = ["VK_KHR_get_physical_device_properties2"]
    )]
    PhysicalDeviceShaderUntypedPointersFeaturesKHR = 1000387000,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_RGB_CONVERSION_FEATURES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVideoEncodeRgbConversionFeaturesValve = 1000390000,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_RGB_CONVERSION_CAPABILITIES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VideoEncodeRgbConversionCapabilitiesValve = 1000390001,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_PROFILE_RGB_CONVERSION_INFO_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VideoEncodeProfileRgbConversionInfoValve = 1000390002,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_RGB_CONVERSION_CREATE_INFO_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VideoEncodeSessionRgbConversionCreateInfoValve = 1000390003,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_view_min_lod"],
        ImpliesSets = [
            "VK_EXT_image_view_min_lod+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_view_min_lod+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageViewMinLodFeaturesEXT = 1000391000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_view_min_lod"],
        ImpliesSets = [
            "VK_EXT_image_view_min_lod+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_view_min_lod+VK_VERSION_1_1",
        ]
    )]
    ImageViewMinLodCreateInfoEXT = 1000391001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multi_draw"],
        ImpliesSets = [
            "VK_EXT_multi_draw+VK_KHR_get_physical_device_properties2",
            "VK_EXT_multi_draw+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiDrawFeaturesEXT = 1000392000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multi_draw"],
        ImpliesSets = [
            "VK_EXT_multi_draw+VK_KHR_get_physical_device_properties2",
            "VK_EXT_multi_draw+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiDrawPropertiesEXT = 1000392001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_2d_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImage2DViewOf3DFeaturesEXT = 1000393000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_FEATURES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    PhysicalDeviceShaderTileImageFeaturesEXT = 1000395000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    PhysicalDeviceShaderTileImagePropertiesEXT = 1000395001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    MicromapBuildInfoEXT = 1000396000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    MicromapVersionInfoEXT = 1000396001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    CopyMicromapInfoEXT = 1000396002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    CopyMicromapToMemoryInfoEXT = 1000396003,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    CopyMemoryToMicromapInfoEXT = 1000396004,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceOpacityMicromapFeaturesEXT = 1000396005,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceOpacityMicromapPropertiesEXT = 1000396006,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    MicromapCreateInfoEXT = 1000396007,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    MicromapBuildSizesInfoEXT = 1000396008,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    AccelerationStructureTrianglesOpacityMicromapEXT = 1000396009,

    [NameSuffix("HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceClusterCullingShaderFeaturesHuawei = 1000404000,

    [NameSuffix("HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceClusterCullingShaderPropertiesHuawei = 1000404001,

    [NameSuffix("HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_VRS_FEATURES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceClusterCullingShaderVrsFeaturesHuawei = 1000404002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    PhysicalDeviceBorderColorSwizzleFeaturesEXT = 1000411000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    SamplerBorderColorComponentMappingCreateInfoEXT = 1000411001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pageable_device_local_memory"],
        ImpliesSets = ["VK_EXT_memory_priority"]
    )]
    PhysicalDevicePageableDeviceLocalMemoryFeaturesEXT = 1000412000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_properties"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceShaderCorePropertiesARM = 1000415000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_SHADER_CORE_CONTROL_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    DeviceQueueShaderCoreControlCreateInfoARM = 1000417000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    PhysicalDeviceSchedulingControlsFeaturesARM = 1000417001,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    PhysicalDeviceSchedulingControlsPropertiesARM = 1000417002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_sliced_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageSlicedViewOf3DFeaturesEXT = 1000418000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_sliced_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    ImageViewSlicedCreateInfoEXT = 1000418001,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDescriptorSetHostMappingFeaturesValve = 1000420000,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    DescriptorSetBindingReferenceValve = 1000420001,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    DescriptorSetLayoutHostMappingInfoValve = 1000420002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_non_seamless_cube_map"],
        ImpliesSets = [
            "VK_EXT_non_seamless_cube_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_non_seamless_cube_map+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceNonSeamlessCubeMapFeaturesEXT = 1000422000,

    [NameSuffix("ARM", 0)]
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
    PhysicalDeviceRenderPassStripedFeaturesARM = 1000424000,

    [NameSuffix("ARM", 0)]
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
    PhysicalDeviceRenderPassStripedPropertiesARM = 1000424001,

    [NameSuffix("ARM", 0)]
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
    RenderPassStripeBeginInfoARM = 1000424002,

    [NameSuffix("ARM", 0)]
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
    RenderPassStripeInfoARM = 1000424003,

    [NameSuffix("ARM", 0)]
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
    RenderPassStripeSubmitInfoARM = 1000424004,

    [NameSuffix("NV", 0)]
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
    PhysicalDeviceCopyMemoryIndirectFeaturesNV = 1000426000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV = 1000428000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    ComputePipelineIndirectBufferInfoNV = 1000428001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INDIRECT_DEVICE_ADDRESS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    PipelineIndirectDeviceAddressInfoNV = 1000428002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_LINEAR_SWEPT_SPHERES_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    PhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV = 1000429008,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_LINEAR_SWEPT_SPHERES_DATA_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    AccelerationStructureGeometryLinearSweptSpheresDataNV = 1000429009,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_SPHERES_DATA_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    AccelerationStructureGeometrySpheresDataNV = 1000429010,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_linear_color_attachment"],
        ImpliesSets = [
            "VK_NV_linear_color_attachment+VK_KHR_get_physical_device_properties2",
            "VK_NV_linear_color_attachment+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLinearColorAttachmentFeaturesNV = 1000430000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MAXIMAL_RECONVERGENCE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_maximal_reconvergence"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR = 1000434000,

    [NameSuffix("EXT", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control_swapchain"],
        ImpliesSets = ["VK_EXT_image_compression_control"]
    )]
    PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT = 1000437000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceImageProcessingFeaturesQCOM = 1000440000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceImageProcessingPropertiesQCOM = 1000440001,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    ImageViewSampleWeightCreateInfoQCOM = 1000440002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceNestedCommandBufferFeaturesEXT = 1000451000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceNestedCommandBufferPropertiesEXT = 1000451001,

    [NameSuffix("OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_USAGE_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    NativeBufferUsageOHOS = 1000452000,

    [NameSuffix("OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_PROPERTIES_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    NativeBufferPropertiesOHOS = 1000452001,

    [NameSuffix("OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_FORMAT_PROPERTIES_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    NativeBufferFormatPropertiesOHOS = 1000452002,

    [NameSuffix("OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_NATIVE_BUFFER_INFO_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ImportNativeBufferInfoOHOS = 1000452003,

    [NameSuffix("OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_NATIVE_BUFFER_INFO_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    MemoryGetNativeBufferInfoOHOS = 1000452004,

    [NameSuffix("OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_OHOS")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ExternalFormatOHOS = 1000452005,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_acquire_unmodified"],
        ImpliesSets = [
            "VK_EXT_external_memory_acquire_unmodified+VK_KHR_external_memory",
            "VK_EXT_external_memory_acquire_unmodified+VK_VERSION_1_1",
        ]
    )]
    ExternalMemoryAcquireUnmodifiedEXT = 1000453000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedDynamicState3FeaturesEXT = 1000455000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedDynamicState3PropertiesEXT = 1000455001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSubpassMergeFeedbackFeaturesEXT = 1000458000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    RenderPassCreationControlEXT = 1000458001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    RenderPassCreationFeedbackCreateInfoEXT = 1000458002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    RenderPassSubpassFeedbackCreateInfoEXT = 1000458003,

    [NameSuffix("LUNARG", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    DirectDriverLoadingInfoLunarg = 1000459000,

    [NameSuffix("LUNARG", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    DirectDriverLoadingListLunarg = 1000459001,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_CREATE_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorCreateInfoARM = 1000460000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_VIEW_CREATE_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorViewCreateInfoARM = 1000460001,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_TENSOR_MEMORY_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    BindTensorMemoryInfoARM = 1000460002,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_TENSOR_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    WriteDescriptorSetTensorARM = 1000460003,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_PROPERTIES_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    PhysicalDeviceTensorPropertiesARM = 1000460004,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_FORMAT_PROPERTIES_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorFormatPropertiesARM = 1000460005,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_DESCRIPTION_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorDescriptionARM = 1000460006,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_MEMORY_REQUIREMENTS_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorMemoryRequirementsInfoARM = 1000460007,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_MEMORY_BARRIER_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorMemoryBarrierARM = 1000460008,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_FEATURES_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    PhysicalDeviceTensorFeaturesARM = 1000460009,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_TENSOR_MEMORY_REQUIREMENTS_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    DeviceTensorMemoryRequirementsARM = 1000460010,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_TENSOR_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    CopyTensorInfoARM = 1000460011,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_COPY_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorCopyARM = 1000460012,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_DEPENDENCY_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorDependencyInfoARM = 1000460013,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_TENSOR_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    MemoryDedicatedAllocateInfoTensorARM = 1000460014,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_TENSOR_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    PhysicalDeviceExternalTensorInfoARM = 1000460015,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_TENSOR_PROPERTIES_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    ExternalTensorPropertiesARM = 1000460016,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_TENSOR_CREATE_INFO_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    ExternalMemoryTensorCreateInfoARM = 1000460017,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    PhysicalDeviceDescriptorBufferTensorFeaturesARM = 1000460018,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    PhysicalDeviceDescriptorBufferTensorPropertiesARM = 1000460019,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_GET_TENSOR_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    DescriptorGetTensorInfoARM = 1000460020,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_CAPTURE_DESCRIPTOR_DATA_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    TensorCaptureDescriptorDataInfoARM = 1000460021,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TENSOR_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    TensorViewCaptureDescriptorDataInfoARM = 1000460022,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FRAME_BOUNDARY_TENSORS_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    FrameBoundaryTensorsARM = 1000460023,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceShaderModuleIdentifierFeaturesEXT = 1000462000,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceShaderModuleIdentifierPropertiesEXT = 1000462001,

    [NameSuffix("EXT", 0)]
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
    PipelineShaderStageModuleIdentifierCreateInfoEXT = 1000462002,

    [NameSuffix("EXT", 0)]
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
    ShaderModuleIdentifierEXT = 1000462003,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT = 1000342000,

    [NameSuffix("NV", 0)]
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
    PhysicalDeviceOpticalFlowFeaturesNV = 1000464000,

    [NameSuffix("NV", 0)]
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
    PhysicalDeviceOpticalFlowPropertiesNV = 1000464001,

    [NameSuffix("NV", 0)]
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
    OpticalFlowImageFormatInfoNV = 1000464002,

    [NameSuffix("NV", 0)]
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
    OpticalFlowImageFormatPropertiesNV = 1000464003,

    [NameSuffix("NV", 0)]
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
    OpticalFlowSessionCreateInfoNV = 1000464004,

    [NameSuffix("NV", 0)]
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
    OpticalFlowExecuteInfoNV = 1000464005,

    [NameSuffix("NV", 0)]
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
    OpticalFlowSessionCreatePrivateDataInfoNV = 1000464010,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_dithering"],
        ImpliesSets = [
            "VK_EXT_legacy_dithering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_legacy_dithering+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLegacyDitheringFeaturesEXT = 1000465000,

    [NameSuffix("ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_FEATURES_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    PhysicalDeviceExternalFormatResolveFeaturesAndroid = 1000468000,

    [NameSuffix("ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    PhysicalDeviceExternalFormatResolvePropertiesAndroid = 1000468001,

    [NameSuffix("ANDROID", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_RESOLVE_PROPERTIES_ANDROID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    AndroidHardwareBufferFormatResolvePropertiesAndroid = 1000468002,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ANTI_LAG_FEATURES_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAntiLagFeaturesAMD = 1000476000,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANTI_LAG_DATA_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    AntiLagDataAMD = 1000476001,

    [NameSuffix("AMD", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ANTI_LAG_PRESENTATION_INFO_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    AntiLagPresentationInfoAMD = 1000476002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_ID_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    SurfaceCapabilitiesPresentId2KHR = 1000479000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRESENT_ID_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    PresentId2KHR = 1000479001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_2_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    PhysicalDevicePresentId2FeaturesKHR = 1000479002,

    [NameSuffix("KHR", 0)]
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
    SurfaceCapabilitiesPresentWait2KHR = 1000480000,

    [NameSuffix("KHR", 0)]
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
    PhysicalDevicePresentWait2FeaturesKHR = 1000480001,

    [NameSuffix("KHR", 0)]
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
    PresentWait2InfoKHR = 1000480002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_POSITION_FETCH_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_position_fetch"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDeviceRayTracingPositionFetchFeaturesKHR = 1000481000,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceShaderObjectFeaturesEXT = 1000482000,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceShaderObjectPropertiesEXT = 1000482001,

    [NameSuffix("EXT", 0)]
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
    ShaderCreateInfoEXT = 1000482002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PhysicalDevicePipelineBinaryFeaturesKHR = 1000483000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryCreateInfoKHR = 1000483001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryInfoKHR = 1000483002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_KEY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryKeyKHR = 1000483003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PhysicalDevicePipelineBinaryPropertiesKHR = 1000483004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RELEASE_CAPTURED_PIPELINE_DATA_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    ReleaseCapturedPipelineDataInfoKHR = 1000483005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_DATA_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryDataInfoKHR = 1000483006,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineCreateInfoKHR = 1000483007,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_PIPELINE_BINARY_INTERNAL_CACHE_CONTROL_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    DevicePipelineBinaryInternalCacheControlKHR = 1000483008,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_BINARY_HANDLES_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryHandlesInfoKHR = 1000483009,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTilePropertiesFeaturesQCOM = 1000484000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    TilePropertiesQCOM = 1000484001,

    [NameSuffix("SEC", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceAmigoProfilingFeaturesSEC = 1000485000,

    [NameSuffix("SEC", 0)]
    [NativeName("VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    AmigoProfilingSubmitInfoSEC = 1000485001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    SurfacePresentModeKHR = 1000274000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    SurfacePresentScalingCapabilitiesKHR = 1000274001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    SurfacePresentModeCompatibilityKHR = 1000274002,

    [NameSuffix("KHR", 0)]
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
    PhysicalDeviceSwapchainMaintenance1FeaturesKHR = 1000275000,

    [NameSuffix("KHR", 0)]
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
    SwapchainPresentFenceInfoKHR = 1000275001,

    [NameSuffix("KHR", 0)]
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
    SwapchainPresentModesCreateInfoKHR = 1000275002,

    [NameSuffix("KHR", 0)]
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
    SwapchainPresentModeInfoKHR = 1000275003,

    [NameSuffix("KHR", 0)]
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
    SwapchainPresentScalingCreateInfoKHR = 1000275004,

    [NameSuffix("KHR", 0)]
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
    ReleaseSwapchainImagesInfoKHR = 1000275005,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_viewports"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_viewports+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_viewports+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM = 1000488000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    PhysicalDeviceRayTracingInvocationReorderFeaturesNV = 1000490000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    PhysicalDeviceRayTracingInvocationReorderPropertiesNV = 1000490001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeVectorFeaturesNV = 1000491000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeVectorPropertiesNV = 1000491001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_VECTOR_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    CooperativeVectorPropertiesNV = 1000491002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CONVERT_COOPERATIVE_VECTOR_MATRIX_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    ConvertCooperativeVectorMatrixInfoNV = 1000491004,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_extended_sparse_address_space"],
        ImpliesSets = [
            "VK_NV_extended_sparse_address_space+VK_KHR_get_physical_device_properties2",
            "VK_NV_extended_sparse_address_space+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedSparseAddressSpaceFeaturesNV = 1000492000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_extended_sparse_address_space"],
        ImpliesSets = [
            "VK_NV_extended_sparse_address_space+VK_KHR_get_physical_device_properties2",
            "VK_NV_extended_sparse_address_space+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExtendedSparseAddressSpacePropertiesNV = 1000492001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mutable_descriptor_type"],
        ImpliesSets = [
            "VK_EXT_mutable_descriptor_type+VK_KHR_maintenance3",
            "VK_EXT_mutable_descriptor_type+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMutableDescriptorTypeFeaturesEXT = 1000351000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mutable_descriptor_type"],
        ImpliesSets = [
            "VK_EXT_mutable_descriptor_type+VK_KHR_maintenance3",
            "VK_EXT_mutable_descriptor_type+VK_VERSION_1_1",
        ]
    )]
    MutableDescriptorTypeCreateInfoEXT = 1000351002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_vertex_attributes"],
        ImpliesSets = ["VK_EXT_vertex_input_dynamic_state"]
    )]
    PhysicalDeviceLegacyVertexAttributesFeaturesEXT = 1000495000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_vertex_attributes"],
        ImpliesSets = ["VK_EXT_vertex_input_dynamic_state"]
    )]
    PhysicalDeviceLegacyVertexAttributesPropertiesEXT = 1000495001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_LAYER_SETTINGS_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    LayerSettingsCreateInfoEXT = 1000496000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_builtins"],
        ImpliesSets = [
            "VK_ARM_shader_core_builtins+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_core_builtins+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderCoreBuiltinsFeaturesARM = 1000497000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_builtins"],
        ImpliesSets = [
            "VK_ARM_shader_core_builtins+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_core_builtins+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderCoreBuiltinsPropertiesARM = 1000497001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_LIBRARY_GROUP_HANDLES_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_library_group_handles"],
        ImpliesSets = ["VK_KHR_pipeline_library", "VK_KHR_ray_tracing_pipeline"]
    )]
    PhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT = 1000498000,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT = 1000499000,

    [NameSuffix("NV", 0)]
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
    LatencySleepModeInfoNV = 1000505000,

    [NameSuffix("NV", 0)]
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
    LatencySleepInfoNV = 1000505001,

    [NameSuffix("NV", 0)]
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
    SetLatencyMarkerInfoNV = 1000505002,

    [NameSuffix("NV", 0)]
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
    GetLatencyMarkerInfoNV = 1000505003,

    [NameSuffix("NV", 0)]
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
    LatencyTimingsFrameReportNV = 1000505004,

    [NameSuffix("NV", 0)]
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
    LatencySubmissionPresentIdNV = 1000505005,

    [NameSuffix("NV", 0)]
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
    OutOfBandQueueTypeInfoNV = 1000505006,

    [NameSuffix("NV", 0)]
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
    SwapchainLatencyCreateInfoNV = 1000505007,

    [NameSuffix("NV", 0)]
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
    LatencySurfaceCapabilitiesNV = 1000505008,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeMatrixFeaturesKHR = 1000506000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    CooperativeMatrixPropertiesKHR = 1000506001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCooperativeMatrixPropertiesKHR = 1000506002,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineCreateInfoARM = 1000507000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineSessionCreateInfoARM = 1000507001,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_RESOURCE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineResourceInfoARM = 1000507002,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineConstantARM = 1000507003,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_MEMORY_REQUIREMENTS_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineSessionMemoryRequirementsInfoARM = 1000507004,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_DATA_GRAPH_PIPELINE_SESSION_MEMORY_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    BindDataGraphPipelineSessionMemoryInfoARM = 1000507005,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    PhysicalDeviceDataGraphFeaturesARM = 1000507006,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SHADER_MODULE_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineShaderModuleCreateInfoARM = 1000507007,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_PROPERTY_QUERY_RESULT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelinePropertyQueryResultARM = 1000507008,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineInfoARM = 1000507009,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_COMPILER_CONTROL_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineCompilerControlCreateInfoARM = 1000507010,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENTS_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineSessionBindPointRequirementsInfoARM = 1000507011,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineSessionBindPointRequirementARM = 1000507012,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_IDENTIFIER_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineIdentifierCreateInfoARM = 1000507013,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_DISPATCH_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineDispatchInfoARM = 1000507014,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PROCESSING_ENGINE_CREATE_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphProcessingEngineCreateInfoARM = 1000507016,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    QueueFamilyDataGraphProcessingEnginePropertiesARM = 1000507017,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    QueueFamilyDataGraphPropertiesARM = 1000507018,

    [NameSuffix("ARM", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_INFO_ARM"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM = 1000507019,

    [NameSuffix("ARM", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_TENSOR_SEMI_STRUCTURED_SPARSITY_INFO_ARM"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph", "VK_ARM_tensors"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"],
        RequireAll = true
    )]
    DataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM = 1000507015,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_render_areas"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_render_areas+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_render_areas+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM = 1000510000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_render_areas"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_render_areas+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_render_areas+VK_VERSION_1_1",
        ]
    )]
    MultiviewPerViewRenderAreasRenderPassBeginInfoQCOM = 1000510001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_KHR_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_KHR_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceComputeShaderDerivativesFeaturesKHR = 1000201000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_KHR_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_KHR_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceComputeShaderDerivativesPropertiesKHR = 1000511000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeAv1CapabilitiesKHR = 1000512000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeAv1PictureInfoKHR = 1000512001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeAv1ProfileInfoKHR = 1000512003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeAv1SessionParametersCreateInfoKHR = 1000512004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeAv1DpbSlotInfoKHR = 1000512005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1CapabilitiesKHR = 1000513000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1SessionParametersCreateInfoKHR = 1000513001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1PictureInfoKHR = 1000513002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_DPB_SLOT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1DpbSlotInfoKHR = 1000513003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_AV1_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PhysicalDeviceVideoEncodeAv1FeaturesKHR = 1000513004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1ProfileInfoKHR = 1000513005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1RateControlInfoKHR = 1000513006,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_LAYER_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1RateControlLayerInfoKHR = 1000513007,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUALITY_LEVEL_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1QualityLevelPropertiesKHR = 1000513008,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1SessionCreateInfoKHR = 1000513009,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_GOP_REMAINING_FRAME_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeAv1GopRemainingFrameInfoKHR = 1000513010,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_DECODE_VP9_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    PhysicalDeviceVideoDecodeVp9FeaturesKHR = 1000514000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeVp9CapabilitiesKHR = 1000514001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PICTURE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeVp9PictureInfoKHR = 1000514002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PROFILE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VideoDecodeVp9ProfileInfoKHR = 1000514003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_1_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance1"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    PhysicalDeviceVideoMaintenance1FeaturesKHR = 1000515000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_INLINE_QUERY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance1"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    VideoInlineQueryInfoKHR = 1000515001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PER_STAGE_DESCRIPTOR_SET_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_per_stage_descriptor_set"],
        ImpliesSets = [
            "VK_NV_per_stage_descriptor_set+VK_KHR_maintenance6",
            "VK_NV_per_stage_descriptor_set+VK_VERSION_1_4",
        ]
    )]
    PhysicalDevicePerStageDescriptorSetFeaturesNV = 1000516000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    PhysicalDeviceImageProcessing2FeaturesQCOM = 1000518000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    PhysicalDeviceImageProcessing2PropertiesQCOM = 1000518001,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    SamplerBlockMatchWindowCreateInfoQCOM = 1000518002,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_CUBIC_WEIGHTS_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    SamplerCubicWeightsCreateInfoQCOM = 1000519000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_WEIGHTS_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    PhysicalDeviceCubicWeightsFeaturesQCOM = 1000519001,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_CUBIC_WEIGHTS_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    BlitImageCubicWeightsInfoQCOM = 1000519002,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_DEGAMMA_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_ycbcr_degamma"],
        ImpliesSets = [
            "VK_QCOM_ycbcr_degamma+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_ycbcr_degamma+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceYcbcrDegammaFeaturesQCOM = 1000520000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_ycbcr_degamma"],
        ImpliesSets = [
            "VK_QCOM_ycbcr_degamma+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_ycbcr_degamma+VK_VERSION_1_1",
        ]
    )]
    SamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM = 1000520001,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_CLAMP_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_clamp"],
        ImpliesSets = [
            "VK_EXT_filter_cubic+VK_EXT_sampler_filter_minmax",
            "VK_EXT_filter_cubic+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceCubicClampFeaturesQCOM = 1000521000,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT = 1000524000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFIED_IMAGE_LAYOUTS_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_unified_image_layouts"],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceUnifiedImageLayoutsFeaturesKHR = 1000527000,

    [NameSuffix("EXT", 0)]
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
    AttachmentFeedbackLoopInfoEXT = 1000527001,

    [NameSuffix("QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SCREEN_BUFFER_PROPERTIES_QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ScreenBufferPropertiesQNX = 1000529000,

    [NameSuffix("QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SCREEN_BUFFER_FORMAT_PROPERTIES_QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ScreenBufferFormatPropertiesQNX = 1000529001,

    [NameSuffix("QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_SCREEN_BUFFER_INFO_QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ImportScreenBufferInfoQNX = 1000529002,

    [NameSuffix("QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    ExternalFormatQNX = 1000529003,

    [NameSuffix("QNX", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCREEN_BUFFER_FEATURES_QNX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalMemoryScreenBufferFeaturesQNX = 1000529004,

    [NameSuffix("MSFT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_DRIVER_PROPERTIES_MSFT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MSFT_layered_driver"],
        ImpliesSets = [
            "VK_MSFT_layered_driver+VK_KHR_get_physical_device_properties2",
            "VK_MSFT_layered_driver+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLayeredDriverPropertiesMSFT = 1000530000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_calibrated_timestamps"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_KHR_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    CalibratedTimestampInfoKHR = 1000184000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SET_DESCRIPTOR_BUFFER_OFFSETS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer", "VK_KHR_maintenance6"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    SetDescriptorBufferOffsetsInfoEXT = 1000545007,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_BUFFER_EMBEDDED_SAMPLERS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer", "VK_KHR_maintenance6"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    BindDescriptorBufferEmbeddedSamplersInfoEXT = 1000545008,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_POOL_OVERALLOCATION_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_descriptor_pool_overallocation"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceDescriptorPoolOverallocationFeaturesNV = 1000546000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTileMemoryHeapFeaturesQCOM = 1000547000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTileMemoryHeapPropertiesQCOM = 1000547001,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_REQUIREMENTS_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    TileMemoryRequirementsQCOM = 1000547002,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TILE_MEMORY_BIND_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    TileMemoryBindInfoQCOM = 1000547003,

    [NameSuffix("QCOM", 0)]
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
    TileMemorySizeInfoQCOM = 1000547004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceCopyMemoryIndirectFeaturesKHR = 1000549000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceCopyMemoryIndirectPropertiesKHR = 1000426001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_INDIRECT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    CopyMemoryIndirectInfoKHR = 1000549002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INDIRECT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    CopyMemoryToImageIndirectInfoKHR = 1000549003,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    PhysicalDeviceMemoryDecompressionFeaturesEXT = 1000427000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    PhysicalDeviceMemoryDecompressionPropertiesEXT = 1000427001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DECOMPRESS_MEMORY_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    DecompressMemoryInfoEXT = 1000550002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_SURFACE_STEREO_CREATE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    DisplaySurfaceStereoCreateInfoNV = 1000551000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DISPLAY_MODE_STEREO_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    DisplayModeStereoPropertiesNV = 1000551001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeIntraRefreshCapabilitiesKHR = 1000552000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_INTRA_REFRESH_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeSessionIntraRefreshCreateInfoKHR = 1000552001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoEncodeIntraRefreshInfoKHR = 1000552002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_REFERENCE_INTRA_REFRESH_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VideoReferenceIntraRefreshInfoKHR = 1000552003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_INTRA_REFRESH_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR = 1000552004,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_CAPABILITIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeQuantizationMapCapabilitiesKHR = 1000553000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_FORMAT_QUANTIZATION_MAP_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VideoFormatQuantizationMapPropertiesKHR = 1000553001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VideoEncodeQuantizationMapInfoKHR = 1000553002,

    [NameSuffix("KHR", 0)]
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
    VideoEncodeQuantizationMapSessionParametersCreateInfoKHR = 1000553005,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUANTIZATION_MAP_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceVideoEncodeQuantizationMapFeaturesKHR = 1000553009,

    [NameSuffix("KHR", 0)]
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
    VideoEncodeH264QuantizationMapCapabilitiesKHR = 1000553003,

    [NameSuffix("KHR", 0)]
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
    VideoEncodeH265QuantizationMapCapabilitiesKHR = 1000553004,

    [NameSuffix("KHR", 0)]
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
    VideoFormatH265QuantizationMapPropertiesKHR = 1000553006,

    [NameSuffix("KHR", 0)]
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
    VideoEncodeAv1QuantizationMapCapabilitiesKHR = 1000553007,

    [NameSuffix("KHR", 0)]
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
    VideoFormatAv1QuantizationMapPropertiesKHR = 1000553008,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAW_ACCESS_CHAINS_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_raw_access_chains"],
        ImpliesSets = [
            "VK_NV_raw_access_chains+VK_KHR_get_physical_device_properties2",
            "VK_NV_raw_access_chains+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRawAccessChainsFeaturesNV = 1000555000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DEVICE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    ExternalComputeQueueDeviceCreateInfoNV = 1000556000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_CREATE_INFO_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    ExternalComputeQueueCreateInfoNV = 1000556001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DATA_PARAMS_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    ExternalComputeQueueDataParamsNV = 1000556002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_COMPUTE_QUEUE_PROPERTIES_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    PhysicalDeviceExternalComputeQueuePropertiesNV = 1000556003,

    [NameSuffix("KHR", 0)]
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
    PhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR = 1000558000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMMAND_BUFFER_INHERITANCE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_command_buffer_inheritance"],
        ImpliesSets = [
            "VK_NV_command_buffer_inheritance+VK_KHR_get_physical_device_properties2",
            "VK_NV_command_buffer_inheritance+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceCommandBufferInheritanceFeaturesNV = 1000559000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_FEATURES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance7FeaturesKHR = 1000562000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance7PropertiesKHR = 1000562001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_LIST_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceLayeredApiPropertiesListKHR = 1000562002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceLayeredApiPropertiesKHR = 1000562003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_VULKAN_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceLayeredApiVulkanPropertiesKHR = 1000562004,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT16_VECTOR_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shader_atomic_float16_vector"],
        ImpliesSets = [
            "VK_NV_shader_atomic_float16_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_shader_atomic_float16_vector+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV = 1000563000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_REPLICATED_COMPOSITES_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_replicated_composites"],
        ImpliesSets = [
            "VK_EXT_shader_replicated_composites+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_replicated_composites+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderReplicatedCompositesFeaturesEXT = 1000564000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT8_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_float8"],
        ImpliesSets = [
            "VK_EXT_shader_float8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_float8+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderFloat8FeaturesEXT = 1000567000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_VALIDATION_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_validation"],
        ImpliesSets = [
            "VK_NV_ray_tracing_validation+VK_KHR_get_physical_device_properties2",
            "VK_NV_ray_tracing_validation+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRayTracingValidationFeaturesNV = 1000568000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDeviceClusterAccelerationStructureFeaturesNV = 1000569000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDeviceClusterAccelerationStructurePropertiesNV = 1000569001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_CLUSTERS_BOTTOM_LEVEL_INPUT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ClusterAccelerationStructureClustersBottomLevelInputNV = 1000569002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_TRIANGLE_CLUSTER_INPUT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ClusterAccelerationStructureTriangleClusterInputNV = 1000569003,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_MOVE_OBJECTS_INPUT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ClusterAccelerationStructureMoveObjectsInputNV = 1000569004,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_INPUT_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ClusterAccelerationStructureInputInfoNV = 1000569005,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_COMMANDS_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ClusterAccelerationStructureCommandsInfoNV = 1000569006,

    [NameSuffix("NV", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CLUSTER_ACCELERATION_STRUCTURE_CREATE_INFO_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    RayTracingPipelineClusterAccelerationStructureCreateInfoNV = 1000569007,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDevicePartitionedAccelerationStructureFeaturesNV = 1000570000,

    [NameSuffix("NV", 0)]
    [NativeName(
        "VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_PROPERTIES_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PhysicalDevicePartitionedAccelerationStructurePropertiesNV = 1000570001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_PARTITIONED_ACCELERATION_STRUCTURE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    WriteDescriptorSetPartitionedAccelerationStructureNV = 1000570002,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCES_INPUT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PartitionedAccelerationStructureInstancesInputNV = 1000570003,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUILD_PARTITIONED_ACCELERATION_STRUCTURE_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    BuildPartitionedAccelerationStructureInfoNV = 1000570004,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_FLAGS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    PartitionedAccelerationStructureFlagsNV = 1000570005,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceDeviceGeneratedCommandsFeaturesEXT = 1000572000,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT = 1000572001,

    [NameSuffix("EXT", 0)]
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
    GeneratedCommandsMemoryRequirementsInfoEXT = 1000572002,

    [NameSuffix("EXT", 0)]
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
    IndirectExecutionSetCreateInfoEXT = 1000572003,

    [NameSuffix("EXT", 0)]
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
    GeneratedCommandsInfoEXT = 1000572004,

    [NameSuffix("EXT", 0)]
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
    IndirectCommandsLayoutCreateInfoEXT = 1000572006,

    [NameSuffix("EXT", 0)]
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
    IndirectCommandsLayoutTokenEXT = 1000572007,

    [NameSuffix("EXT", 0)]
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
    WriteIndirectExecutionSetPipelineEXT = 1000572008,

    [NameSuffix("EXT", 0)]
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
    WriteIndirectExecutionSetShaderEXT = 1000572009,

    [NameSuffix("EXT", 0)]
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
    IndirectExecutionSetPipelineInfoEXT = 1000572010,

    [NameSuffix("EXT", 0)]
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
    IndirectExecutionSetShaderInfoEXT = 1000572011,

    [NameSuffix("EXT", 0)]
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
    IndirectExecutionSetShaderLayoutInfoEXT = 1000572012,

    [NameSuffix("EXT", 0)]
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
    GeneratedCommandsPipelineInfoEXT = 1000572013,

    [NameSuffix("EXT", 0)]
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
    GeneratedCommandsShaderInfoEXT = 1000572014,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_8_FEATURES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance8FeaturesKHR = 1000574000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER_ACCESS_FLAGS_3_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    MemoryBarrierAccessFlags3KHR = 1000574002,

    [NameSuffix("MESA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_FEATURES_MESA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageAlignmentControlFeaturesMESA = 1000575000,

    [NameSuffix("MESA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_PROPERTIES_MESA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageAlignmentControlPropertiesMESA = 1000575001,

    [NameSuffix("MESA", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_ALIGNMENT_CONTROL_CREATE_INFO_MESA")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    ImageAlignmentControlCreateInfoMESA = 1000575002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FMA_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_fma"],
        ImpliesSets = [
            "VK_KHR_shader_fma+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_fma+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderFmaFeaturesKHR = 1000579000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthClampControlFeaturesEXT = 1000582000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLAMP_CONTROL_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    PipelineViewportDepthClampControlCreateInfoEXT = 1000582001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMaintenance9FeaturesKHR = 1000584000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMaintenance9PropertiesKHR = 1000584001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_OWNERSHIP_TRANSFER_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    QueueFamilyOwnershipTransferPropertiesKHR = 1000584002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_2_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    PhysicalDeviceVideoMaintenance2FeaturesKHR = 1000586000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VideoDecodeH264InlineSessionParametersInfoKHR = 1000586001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VideoDecodeH265InlineSessionParametersInfoKHR = 1000586002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_INLINE_SESSION_PARAMETERS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VideoDecodeAv1InlineSessionParametersInfoKHR = 1000586003,

    [NameSuffix("OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_CREATE_INFO_OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_surface"], ImpliesSets = ["VK_KHR_surface"])]
    SurfaceCreateInfoOHOS = 1000685000,

    [NameSuffix("OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_NATIVE_BUFFER_OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_native_buffer"])]
    NativeBufferOHOS = 1000453001,

    [NameSuffix("OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_IMAGE_CREATE_INFO_OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_native_buffer"])]
    SwapchainImageCreateInfoOHOS = 1000453002,

    [NameSuffix("OHOS", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENTATION_PROPERTIES_OHOS")]
    [SupportedApiProfile("vulkan", ["VK_OHOS_native_buffer"])]
    PhysicalDevicePresentationPropertiesOHOS = 1000453003,

    [NameSuffix("HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HDR_VIVID_FEATURES_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceHdrVividFeaturesHuawei = 1000590000,

    [NameSuffix("HUAWEI", 0)]
    [NativeName("VK_STRUCTURE_TYPE_HDR_VIVID_DYNAMIC_METADATA_HUAWEI")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    HdrVividDynamicMetadataHuawei = 1000590001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    PhysicalDeviceCooperativeMatrix2FeaturesNV = 1000593000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_FLEXIBLE_DIMENSIONS_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    CooperativeMatrixFlexibleDimensionsPropertiesNV = 1000593001,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_PROPERTIES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    PhysicalDeviceCooperativeMatrix2PropertiesNV = 1000593002,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_OPACITY_MICROMAP_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_pipeline_opacity_micromap"],
        ImpliesSets = ["VK_EXT_opacity_micromap"]
    )]
    PhysicalDevicePipelineOpacityMicromapFeaturesARM = 1000596000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMPORT_MEMORY_METAL_HANDLE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    ImportMemoryMetalHandleInfoEXT = 1000602000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_METAL_HANDLE_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    MemoryMetalHandlePropertiesEXT = 1000602001,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_GET_METAL_HANDLE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    MemoryGetMetalHandleInfoEXT = 1000602002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_clamp_zero_one"],
        ImpliesSets = [
            "VK_KHR_depth_clamp_zero_one+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_clamp_zero_one+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthClampZeroOneFeaturesKHR = 1000421000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePerformanceCountersByRegionFeaturesARM = 1000605000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_PROPERTIES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePerformanceCountersByRegionPropertiesARM = 1000605001,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    PerformanceCounterARM = 1000605002,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    PerformanceCounterDescriptionARM = 1000605003,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_PERFORMANCE_COUNTERS_BY_REGION_BEGIN_INFO_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    RenderPassPerformanceCountersByRegionBeginInfoARM = 1000605004,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_ROBUSTNESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_robustness"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_robustness+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexAttributeRobustnessFeaturesEXT = 1000608000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FORMAT_PACK_FEATURES_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFormatPackFeaturesARM = 1000609000,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_FEATURES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    PhysicalDeviceFragmentDensityMapLayeredFeaturesValve = 1000611000,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_PROPERTIES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    PhysicalDeviceFragmentDensityMapLayeredPropertiesValve = 1000611001,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_DENSITY_MAP_LAYERED_CREATE_INFO_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    PipelineFragmentDensityMapLayeredCreateInfoValve = 1000611002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRobustness2FeaturesKHR = 1000286000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRobustness2PropertiesKHR = 1000286001,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceFragmentDensityMapOffsetFeaturesEXT = 1000425000,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT = 1000425001,

    [NameSuffix("EXT", 0)]
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
    RenderPassFragmentDensityMapOffsetEndInfoEXT = 1000425002,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_DEVICE_MEMORY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_zero_initialize_device_memory"],
        ImpliesSets = [
            "VK_EXT_zero_initialize_device_memory+VK_KHR_get_physical_device_properties2",
            "VK_EXT_zero_initialize_device_memory+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT = 1000620000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    PhysicalDevicePresentModeFifoLatestReadyFeaturesKHR = 1000361000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_64_BIT_INDEXING_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_64bit_indexing"],
        ImpliesSets = [
            "VK_EXT_shader_64bit_indexing+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_64bit_indexing+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShader64BitIndexingFeaturesEXT = 1000627000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_MODEL_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    PhysicalDeviceDataGraphModelFeaturesQCOM = 1000629000,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_BUILTIN_MODEL_CREATE_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    DataGraphPipelineBuiltinModelCreateInfoQCOM = 1000629001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMaintenance10FeaturesKHR = 1000630000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMaintenance10PropertiesKHR = 1000630001,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_FLAGS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    RenderingAttachmentFlagsInfoKHR = 1000630002,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_END_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    RenderingEndInfoKHR = 1000619003,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_MODE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    ResolveImageModeInfoKHR = 1000630004,

    [NameSuffix("SEC", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CACHE_INCREMENTAL_MODE_FEATURES_SEC")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_pipeline_cache_incremental_mode"],
        ImpliesSets = [
            "VK_SEC_pipeline_cache_incremental_mode+VK_KHR_get_physical_device_properties2",
            "VK_SEC_pipeline_cache_incremental_mode+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineCacheIncrementalModeFeaturesSEC = 1000637000,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT = 1000642000,

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

    [NameSuffix("KHR", 0)]
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
    RenderingInfoKHR = RenderingInfo,

    [NameSuffix("KHR", 0)]
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
    RenderingAttachmentInfoKHR = RenderingAttachmentInfo,

    [NameSuffix("KHR", 0)]
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
    PipelineRenderingCreateInfoKHR = PipelineRenderingCreateInfo,

    [NameSuffix("KHR", 0)]
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
    PhysicalDeviceDynamicRenderingFeaturesKHR = PhysicalDeviceDynamicRenderingFeatures,

    [NameSuffix("KHR", 0)]
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
    CommandBufferInheritanceRenderingInfoKHR = CommandBufferInheritanceRenderingInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    RenderPassMultiviewCreateInfoKHR = RenderPassMultiviewCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiviewFeaturesKHR = PhysicalDeviceMultiviewFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMultiviewPropertiesKHR = PhysicalDeviceMultiviewProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    PhysicalDeviceFeatures2KHR = PhysicalDeviceFeatures2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    PhysicalDeviceProperties2KHR = PhysicalDeviceProperties2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    FormatProperties2KHR = FormatProperties2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    ImageFormatProperties2KHR = ImageFormatProperties2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    PhysicalDeviceImageFormatInfo2KHR = PhysicalDeviceImageFormatInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    QueueFamilyProperties2KHR = QueueFamilyProperties2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    PhysicalDeviceMemoryProperties2KHR = PhysicalDeviceMemoryProperties2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    SparseImageFormatProperties2KHR = SparseImageFormatProperties2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    PhysicalDeviceSparseImageFormatInfo2KHR = PhysicalDeviceSparseImageFormatInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    MemoryAllocateFlagsInfoKHR = MemoryAllocateFlagsInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    DeviceGroupRenderPassBeginInfoKHR = DeviceGroupRenderPassBeginInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    DeviceGroupCommandBufferBeginInfoKHR = DeviceGroupCommandBufferBeginInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    DeviceGroupSubmitInfoKHR = DeviceGroupSubmitInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    DeviceGroupBindSparseInfoKHR = DeviceGroupBindSparseInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_bind_memory2", "VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"],
        RequireAll = true
    )]
    BindBufferMemoryDeviceGroupInfoKHR = BindBufferMemoryDeviceGroupInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_bind_memory2", "VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"],
        RequireAll = true
    )]
    BindImageMemoryDeviceGroupInfoKHR = BindImageMemoryDeviceGroupInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTextureCompressionAstcHdrFeaturesEXT =
        PhysicalDeviceTextureCompressionAstcHdrFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    PipelineRobustnessCreateInfoEXT = PipelineRobustnessCreateInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineRobustnessFeaturesEXT = PhysicalDevicePipelineRobustnessFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineRobustnessPropertiesEXT = PhysicalDevicePipelineRobustnessProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_device_group_creation"])]
    PhysicalDeviceGroupPropertiesKHR = PhysicalDeviceGroupProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_device_group_creation"])]
    DeviceGroupDeviceCreateInfoKHR = DeviceGroupDeviceCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalImageFormatInfoKHR = PhysicalDeviceExternalImageFormatInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    ExternalImageFormatPropertiesKHR = ExternalImageFormatProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalBufferInfoKHR = PhysicalDeviceExternalBufferInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    ExternalBufferPropertiesKHR = ExternalBufferProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceIdPropertiesKHR = PhysicalDeviceIdProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    ExternalMemoryBufferCreateInfoKHR = ExternalMemoryBufferCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    ExternalMemoryImageCreateInfoKHR = ExternalMemoryImageCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    ExportMemoryAllocateInfoKHR = ExportMemoryAllocateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalSemaphoreInfoKHR = PhysicalDeviceExternalSemaphoreInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    ExternalSemaphorePropertiesKHR = ExternalSemaphoreProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore_capabilities"]
    )]
    ExportSemaphoreCreateInfoKHR = ExportSemaphoreCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_push_descriptor"],
        ImpliesSets = [
            "VK_KHR_push_descriptor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_push_descriptor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePushDescriptorPropertiesKHR = PhysicalDevicePushDescriptorProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float16_int8"],
        ImpliesSets = [
            "VK_KHR_shader_float16_int8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float16_int8+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderFloat16Int8FeaturesKHR = PhysicalDeviceShaderFloat16Int8Features,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float16_int8"],
        ImpliesSets = [
            "VK_KHR_shader_float16_int8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float16_int8+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFloat16Int8FeaturesKHR = PhysicalDeviceShaderFloat16Int8Features,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_16bit_storage"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDevice16BitStorageFeaturesKHR = PhysicalDevice16BitStorageFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_descriptor_update_template"])]
    DescriptorUpdateTemplateCreateInfoKHR = DescriptorUpdateTemplateCreateInfo,

    [NameSuffix("KHR", 0)]
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
    PhysicalDeviceImagelessFramebufferFeaturesKHR = PhysicalDeviceImagelessFramebufferFeatures,

    [NameSuffix("KHR", 0)]
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
    FramebufferAttachmentsCreateInfoKHR = FramebufferAttachmentsCreateInfo,

    [NameSuffix("KHR", 0)]
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
    FramebufferAttachmentImageInfoKHR = FramebufferAttachmentImageInfo,

    [NameSuffix("KHR", 0)]
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
    RenderPassAttachmentBeginInfoKHR = RenderPassAttachmentBeginInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    AttachmentDescription2KHR = AttachmentDescription2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    AttachmentReference2KHR = AttachmentReference2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    SubpassDescription2KHR = SubpassDescription2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    SubpassDependency2KHR = SubpassDependency2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    RenderPassCreateInfo2KHR = RenderPassCreateInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    SubpassBeginInfoKHR = SubpassBeginInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    SubpassEndInfoKHR = SubpassEndInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceExternalFenceInfoKHR = PhysicalDeviceExternalFenceInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    ExternalFencePropertiesKHR = ExternalFenceProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence"],
        ImpliesSets = ["VK_KHR_external_fence_capabilities"]
    )]
    ExportFenceCreateInfoKHR = ExportFenceCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    PhysicalDevicePointClippingPropertiesKHR = PhysicalDevicePointClippingProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    RenderPassInputAttachmentAspectCreateInfoKHR = RenderPassInputAttachmentAspectCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    ImageViewUsageCreateInfoKHR = ImageViewUsageCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    PipelineTessellationDomainOriginStateCreateInfoKHR =
        PipelineTessellationDomainOriginStateCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_variable_pointers"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVariablePointersFeaturesKHR = PhysicalDeviceVariablePointersFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_variable_pointers"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVariablePointerFeaturesKHR = PhysicalDeviceVariablePointersFeaturesKHR,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dedicated_allocation"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_memory_requirements2",
            "VK_KHR_dedicated_allocation+VK_VERSION_1_1",
        ]
    )]
    MemoryDedicatedRequirementsKHR = MemoryDedicatedRequirements,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dedicated_allocation"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_memory_requirements2",
            "VK_KHR_dedicated_allocation+VK_VERSION_1_1",
        ]
    )]
    MemoryDedicatedAllocateInfoKHR = MemoryDedicatedAllocateInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSamplerFilterMinmaxPropertiesEXT = PhysicalDeviceSamplerFilterMinmaxProperties,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    SamplerReductionModeCreateInfoEXT = SamplerReductionModeCreateInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceInlineUniformBlockFeaturesEXT = PhysicalDeviceInlineUniformBlockFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceInlineUniformBlockPropertiesEXT = PhysicalDeviceInlineUniformBlockProperties,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    WriteDescriptorSetInlineUniformBlockEXT = WriteDescriptorSetInlineUniformBlock,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    DescriptorPoolInlineUniformBlockCreateInfoEXT = DescriptorPoolInlineUniformBlockCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    BufferMemoryRequirementsInfo2KHR = BufferMemoryRequirementsInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    ImageMemoryRequirementsInfo2KHR = ImageMemoryRequirementsInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    ImageSparseMemoryRequirementsInfo2KHR = ImageSparseMemoryRequirementsInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    MemoryRequirements2KHR = MemoryRequirements2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    SparseImageMemoryRequirements2KHR = SparseImageMemoryRequirements2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_image_format_list"])]
    ImageFormatListCreateInfoKHR = ImageFormatListCreateInfo,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_NV")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_dynamic_rendering",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_3",
        ]
    )]
    AttachmentSampleCountInfoNV = AttachmentSampleCountInfoAMD,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    SamplerYcbcrConversionCreateInfoKHR = SamplerYcbcrConversionCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    SamplerYcbcrConversionInfoKHR = SamplerYcbcrConversionInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    BindImagePlaneMemoryInfoKHR = BindImagePlaneMemoryInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    ImagePlaneMemoryRequirementsInfoKHR = ImagePlaneMemoryRequirementsInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSamplerYcbcrConversionFeaturesKHR = PhysicalDeviceSamplerYcbcrConversionFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    SamplerYcbcrConversionImageFormatPropertiesKHR = SamplerYcbcrConversionImageFormatProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_bind_memory2"])]
    BindBufferMemoryInfoKHR = BindBufferMemoryInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_bind_memory2"])]
    BindImageMemoryInfoKHR = BindImageMemoryInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    DescriptorSetLayoutBindingFlagsCreateInfoEXT = DescriptorSetLayoutBindingFlagsCreateInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDescriptorIndexingFeaturesEXT = PhysicalDeviceDescriptorIndexingFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDescriptorIndexingPropertiesEXT = PhysicalDeviceDescriptorIndexingProperties,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    DescriptorSetVariableDescriptorCountAllocateInfoEXT =
        DescriptorSetVariableDescriptorCountAllocateInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    DescriptorSetVariableDescriptorCountLayoutSupportEXT =
        DescriptorSetVariableDescriptorCountLayoutSupport,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance3"],
        ImpliesSets = [
            "VK_KHR_maintenance3+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance3+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceMaintenance3PropertiesKHR = PhysicalDeviceMaintenance3Properties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance3"],
        ImpliesSets = [
            "VK_KHR_maintenance3+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance3+VK_VERSION_1_1",
        ]
    )]
    DescriptorSetLayoutSupportKHR = DescriptorSetLayoutSupport,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    DeviceQueueGlobalPriorityCreateInfoEXT = DeviceQueueGlobalPriorityCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_extended_types"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR =
        PhysicalDeviceShaderSubgroupExtendedTypesFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_8bit_storage"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDevice8BitStorageFeaturesKHR = PhysicalDevice8BitStorageFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_atomic_int64"],
        ImpliesSets = [
            "VK_KHR_shader_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderAtomicInt64FeaturesKHR = PhysicalDeviceShaderAtomicInt64Features,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_calibrated_timestamps"],
        ImpliesSets = [
            "VK_EXT_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_EXT_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    CalibratedTimestampInfoEXT = CalibratedTimestampInfoKHR,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    DeviceQueueGlobalPriorityCreateInfoKHR = DeviceQueueGlobalPriorityCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceGlobalPriorityQueryFeaturesKHR = PhysicalDeviceGlobalPriorityQueryFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    QueueFamilyGlobalPriorityPropertiesKHR = QueueFamilyGlobalPriorityProperties,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PipelineVertexInputDivisorStateCreateInfoEXT = PipelineVertexInputDivisorStateCreateInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexAttributeDivisorFeaturesEXT = PhysicalDeviceVertexAttributeDivisorFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    PipelineCreationFeedbackCreateInfoEXT = PipelineCreationFeedbackCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDriverPropertiesKHR = PhysicalDeviceDriverProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float_controls"],
        ImpliesSets = [
            "VK_KHR_shader_float_controls+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float_controls+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFloatControlsPropertiesKHR = PhysicalDeviceFloatControlsProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    PhysicalDeviceDepthStencilResolvePropertiesKHR = PhysicalDeviceDepthStencilResolveProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    SubpassDescriptionDepthStencilResolveKHR = SubpassDescriptionDepthStencilResolve,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_NV_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_NV_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceComputeShaderDerivativesFeaturesNV =
        PhysicalDeviceComputeShaderDerivativesFeaturesKHR,

    [NameSuffix("NV", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_NV_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_NV_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentShaderBarycentricFeaturesNV =
        PhysicalDeviceFragmentShaderBarycentricFeaturesKHR,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTimelineSemaphoreFeaturesKHR = PhysicalDeviceTimelineSemaphoreFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTimelineSemaphorePropertiesKHR = PhysicalDeviceTimelineSemaphoreProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    SemaphoreTypeCreateInfoKHR = SemaphoreTypeCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    TimelineSemaphoreSubmitInfoKHR = TimelineSemaphoreSubmitInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    SemaphoreWaitInfoKHR = SemaphoreWaitInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    SemaphoreSignalInfoKHR = SemaphoreSignalInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vulkan_memory_model"],
        ImpliesSets = [
            "VK_KHR_vulkan_memory_model+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vulkan_memory_model+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVulkanMemoryModelFeaturesKHR = PhysicalDeviceVulkanMemoryModelFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_terminate_invocation"],
        ImpliesSets = [
            "VK_KHR_shader_terminate_invocation+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_terminate_invocation+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderTerminateInvocationFeaturesKHR =
        PhysicalDeviceShaderTerminateInvocationFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_scalar_block_layout"],
        ImpliesSets = [
            "VK_EXT_scalar_block_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_scalar_block_layout+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceScalarBlockLayoutFeaturesEXT = PhysicalDeviceScalarBlockLayoutFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceSubgroupSizeControlPropertiesEXT = PhysicalDeviceSubgroupSizeControlProperties,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT =
        PipelineShaderStageRequiredSubgroupSizeCreateInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    PhysicalDeviceSubgroupSizeControlFeaturesEXT = PhysicalDeviceSubgroupSizeControlFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    PhysicalDeviceDynamicRenderingLocalReadFeaturesKHR =
        PhysicalDeviceDynamicRenderingLocalReadFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    RenderingAttachmentLocationInfoKHR = RenderingAttachmentLocationInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    RenderingInputAttachmentIndexInfoKHR = RenderingInputAttachmentIndexInfo,

    [NameSuffix("KHR", 0)]
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
    PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR =
        PhysicalDeviceSeparateDepthStencilLayoutsFeatures,

    [NameSuffix("KHR", 0)]
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
    AttachmentReferenceStencilLayoutKHR = AttachmentReferenceStencilLayout,

    [NameSuffix("KHR", 0)]
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
    AttachmentDescriptionStencilLayoutKHR = AttachmentDescriptionStencilLayout,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceBufferAddressFeaturesEXT = PhysicalDeviceBufferDeviceAddressFeaturesEXT,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    BufferDeviceAddressInfoEXT = BufferDeviceAddressInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    PhysicalDeviceToolPropertiesEXT = PhysicalDeviceToolProperties,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_separate_stencil_usage"])]
    ImageStencilUsageCreateInfoEXT = ImageStencilUsageCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_uniform_buffer_standard_layout"],
        ImpliesSets = [
            "VK_KHR_uniform_buffer_standard_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_uniform_buffer_standard_layout+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceUniformBufferStandardLayoutFeaturesKHR =
        PhysicalDeviceUniformBufferStandardLayoutFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceBufferDeviceAddressFeaturesKHR = PhysicalDeviceBufferDeviceAddressFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    BufferDeviceAddressInfoKHR = BufferDeviceAddressInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    BufferOpaqueCaptureAddressCreateInfoKHR = BufferOpaqueCaptureAddressCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    MemoryOpaqueCaptureAddressAllocateInfoKHR = MemoryOpaqueCaptureAddressAllocateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    DeviceMemoryOpaqueCaptureAddressInfoKHR = DeviceMemoryOpaqueCaptureAddressInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLineRasterizationFeaturesEXT = PhysicalDeviceLineRasterizationFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationLineStateCreateInfoEXT = PipelineRasterizationLineStateCreateInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLineRasterizationPropertiesEXT = PhysicalDeviceLineRasterizationProperties,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_query_reset"],
        ImpliesSets = [
            "VK_EXT_host_query_reset+VK_KHR_get_physical_device_properties2",
            "VK_EXT_host_query_reset+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceHostQueryResetFeaturesEXT = PhysicalDeviceHostQueryResetFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_index_type_uint8"],
        ImpliesSets = [
            "VK_EXT_index_type_uint8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_index_type_uint8+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceIndexTypeUint8FeaturesEXT = PhysicalDeviceIndexTypeUint8Features,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceHostImageCopyFeaturesEXT = PhysicalDeviceHostImageCopyFeatures,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceHostImageCopyPropertiesEXT = PhysicalDeviceHostImageCopyProperties,

    [NameSuffix("EXT", 0)]
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
    MemoryToImageCopyEXT = MemoryToImageCopy,

    [NameSuffix("EXT", 0)]
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
    ImageToMemoryCopyEXT = ImageToMemoryCopy,

    [NameSuffix("EXT", 0)]
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
    CopyImageToMemoryInfoEXT = CopyImageToMemoryInfo,

    [NameSuffix("EXT", 0)]
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
    CopyMemoryToImageInfoEXT = CopyMemoryToImageInfo,

    [NameSuffix("EXT", 0)]
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
    HostImageLayoutTransitionInfoEXT = HostImageLayoutTransitionInfo,

    [NameSuffix("EXT", 0)]
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
    CopyImageToImageInfoEXT = CopyImageToImageInfo,

    [NameSuffix("EXT", 0)]
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
    SubresourceHostMemcpySizeEXT = SubresourceHostMemcpySize,

    [NameSuffix("EXT", 0)]
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
    HostImageCopyDevicePerformanceQueryEXT = HostImageCopyDevicePerformanceQuery,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_map_memory2"])]
    MemoryMapInfoKHR = MemoryMapInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_map_memory2"])]
    MemoryUnmapInfoKHR = MemoryUnmapInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    SurfacePresentModeEXT = SurfacePresentModeKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    SurfacePresentScalingCapabilitiesEXT = SurfacePresentScalingCapabilitiesKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    SurfacePresentModeCompatibilityEXT = SurfacePresentModeCompatibilityKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSwapchainMaintenance1FeaturesEXT = PhysicalDeviceSwapchainMaintenance1FeaturesKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    SwapchainPresentFenceInfoEXT = SwapchainPresentFenceInfoKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    SwapchainPresentModesCreateInfoEXT = SwapchainPresentModesCreateInfoKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    SwapchainPresentModeInfoEXT = SwapchainPresentModeInfoKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    SwapchainPresentScalingCreateInfoEXT = SwapchainPresentScalingCreateInfoKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    ReleaseSwapchainImagesInfoEXT = ReleaseSwapchainImagesInfoKHR,

    [NameSuffix("EXT", 0)]
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
    PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT =
        PhysicalDeviceShaderDemoteToHelperInvocationFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_integer_dot_product"],
        ImpliesSets = [
            "VK_KHR_shader_integer_dot_product+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_integer_dot_product+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderIntegerDotProductFeaturesKHR =
        PhysicalDeviceShaderIntegerDotProductFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_integer_dot_product"],
        ImpliesSets = [
            "VK_KHR_shader_integer_dot_product+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_integer_dot_product+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderIntegerDotProductPropertiesKHR =
        PhysicalDeviceShaderIntegerDotProductProperties,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texel_buffer_alignment"],
        ImpliesSets = [
            "VK_EXT_texel_buffer_alignment+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texel_buffer_alignment+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceTexelBufferAlignmentPropertiesEXT = PhysicalDeviceTexelBufferAlignmentProperties,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_robustness2"],
        ImpliesSets = [
            "VK_EXT_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_robustness2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRobustness2FeaturesEXT = PhysicalDeviceRobustness2FeaturesKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_robustness2"],
        ImpliesSets = [
            "VK_EXT_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_robustness2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceRobustness2PropertiesEXT = PhysicalDeviceRobustness2PropertiesKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePrivateDataFeaturesEXT = PhysicalDevicePrivateDataFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    DevicePrivateDataCreateInfoEXT = DevicePrivateDataCreateInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    PrivateDataSlotCreateInfoEXT = PrivateDataSlotCreateInfo,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_creation_cache_control"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineCreationCacheControlFeaturesEXT =
        PhysicalDevicePipelineCreationCacheControlFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MEMORY_BARRIER_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    MemoryBarrier2KHR = MemoryBarrier2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    BufferMemoryBarrier2KHR = BufferMemoryBarrier2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    ImageMemoryBarrier2KHR = ImageMemoryBarrier2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    DependencyInfoKHR = DependencyInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBMIT_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    SubmitInfo2KHR = SubmitInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    SemaphoreSubmitInfoKHR = SemaphoreSubmitInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    CommandBufferSubmitInfoKHR = CommandBufferSubmitInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceSynchronization2FeaturesKHR = PhysicalDeviceSynchronization2Features,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_zero_initialize_workgroup_memory"],
        ImpliesSets = [
            "VK_KHR_zero_initialize_workgroup_memory+VK_KHR_get_physical_device_properties2",
            "VK_KHR_zero_initialize_workgroup_memory+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR =
        PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_robustness"],
        ImpliesSets = [
            "VK_EXT_image_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_robustness+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceImageRobustnessFeaturesEXT = PhysicalDeviceImageRobustnessFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    CopyBufferInfo2KHR = CopyBufferInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    CopyImageInfo2KHR = CopyImageInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    CopyBufferToImageInfo2KHR = CopyBufferToImageInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    CopyImageToBufferInfo2KHR = CopyImageToBufferInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    BlitImageInfo2KHR = BlitImageInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    ResolveImageInfo2KHR = ResolveImageInfo2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    BufferCopy2KHR = BufferCopy2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    ImageCopy2KHR = ImageCopy2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    ImageBlit2KHR = ImageBlit2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    BufferImageCopy2KHR = BufferImageCopy2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    ImageResolve2KHR = ImageResolve2,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    SubresourceLayout2EXT = SubresourceLayout2,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    ImageSubresource2EXT = ImageSubresource2,

    [NameSuffix("ARM", 0)]
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
    PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM =
        PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_mutable_descriptor_type"],
        ImpliesSets = ["VK_KHR_maintenance3"]
    )]
    PhysicalDeviceMutableDescriptorTypeFeaturesValve =
        PhysicalDeviceMutableDescriptorTypeFeaturesEXT,

    [NameSuffix("VALVE", 0)]
    [NativeName("VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_mutable_descriptor_type"],
        ImpliesSets = ["VK_KHR_maintenance3"]
    )]
    MutableDescriptorTypeCreateInfoValve = MutableDescriptorTypeCreateInfoEXT,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_format_feature_flags2"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_VERSION_1_1",
        ]
    )]
    FormatProperties3KHR = FormatProperties3,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    PhysicalDevicePresentModeFifoLatestReadyFeaturesEXT =
        PhysicalDevicePresentModeFifoLatestReadyFeaturesKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_INFO_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    PipelineInfoEXT = PipelineInfoKHR,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_global_priority_query"],
        ImpliesSets = [
            "VK_EXT_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_global_priority+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceGlobalPriorityQueryFeaturesEXT = PhysicalDeviceGlobalPriorityQueryFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_global_priority_query"],
        ImpliesSets = [
            "VK_EXT_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_global_priority+VK_VERSION_1_1",
        ]
    )]
    QueueFamilyGlobalPriorityPropertiesEXT = QueueFamilyGlobalPriorityProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance4FeaturesKHR = PhysicalDeviceMaintenance4Features,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance4PropertiesKHR = PhysicalDeviceMaintenance4Properties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    DeviceBufferMemoryRequirementsKHR = DeviceBufferMemoryRequirements,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    DeviceImageMemoryRequirementsKHR = DeviceImageMemoryRequirements,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_rotate"],
        ImpliesSets = [
            "VK_KHR_shader_subgroup_rotate+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_subgroup_rotate+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderSubgroupRotateFeaturesKHR = PhysicalDeviceShaderSubgroupRotateFeatures,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_zero_one"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_zero_one+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_zero_one+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceDepthClampZeroOneFeaturesEXT = PhysicalDeviceDepthClampZeroOneFeaturesKHR,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM =
        PhysicalDeviceFragmentDensityMapOffsetFeaturesEXT,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM =
        PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    SubpassFragmentDensityMapOffsetEndInfoQCOM = RenderPassFragmentDensityMapOffsetEndInfoEXT,

    [NameSuffix("NV", 0)]
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
    PhysicalDeviceCopyMemoryIndirectPropertiesNV = PhysicalDeviceCopyMemoryIndirectPropertiesKHR,

    [NameSuffix("NV", 0)]
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
    PhysicalDeviceMemoryDecompressionFeaturesNV = PhysicalDeviceMemoryDecompressionFeaturesEXT,

    [NameSuffix("NV", 0)]
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
    PhysicalDeviceMemoryDecompressionPropertiesNV = PhysicalDeviceMemoryDecompressionPropertiesEXT,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_protected_access"],
        ImpliesSets = [
            "VK_EXT_pipeline_protected_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_protected_access+VK_VERSION_1_1",
        ]
    )]
    PhysicalDevicePipelineProtectedAccessFeaturesEXT =
        PhysicalDevicePipelineProtectedAccessFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    PhysicalDeviceMaintenance5FeaturesKHR = PhysicalDeviceMaintenance5Features,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    PhysicalDeviceMaintenance5PropertiesKHR = PhysicalDeviceMaintenance5Properties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_RENDERING_AREA_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    RenderingAreaInfoKHR = RenderingAreaInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    DeviceImageSubresourceInfoKHR = DeviceImageSubresourceInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    SubresourceLayout2KHR = SubresourceLayout2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    ImageSubresource2KHR = ImageSubresource2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    PipelineCreateFlags2CreateInfoKHR = PipelineCreateFlags2CreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    BufferUsageFlags2CreateInfoKHR = BufferUsageFlags2CreateInfo,

    [NameSuffix("EXT", 0)]
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
    ShaderRequiredSubgroupSizeCreateInfoEXT = PipelineShaderStageRequiredSubgroupSizeCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexAttributeDivisorPropertiesKHR =
        PhysicalDeviceVertexAttributeDivisorProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PipelineVertexInputDivisorStateCreateInfoKHR = PipelineVertexInputDivisorStateCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceVertexAttributeDivisorFeaturesKHR = PhysicalDeviceVertexAttributeDivisorFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float_controls2"],
        ImpliesSets = ["VK_KHR_shader_float_controls", "VK_VERSION_1_1"]
    )]
    PhysicalDeviceShaderFloatControls2FeaturesKHR = PhysicalDeviceShaderFloatControls2Features,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_index_type_uint8"],
        ImpliesSets = [
            "VK_KHR_index_type_uint8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_index_type_uint8+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceIndexTypeUint8FeaturesKHR = PhysicalDeviceIndexTypeUint8Features,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLineRasterizationFeaturesKHR = PhysicalDeviceLineRasterizationFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PipelineRasterizationLineStateCreateInfoKHR = PipelineRasterizationLineStateCreateInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceLineRasterizationPropertiesKHR = PhysicalDeviceLineRasterizationProperties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_expect_assume"],
        ImpliesSets = [
            "VK_KHR_shader_expect_assume+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_expect_assume+VK_VERSION_1_1",
        ]
    )]
    PhysicalDeviceShaderExpectAssumeFeaturesKHR = PhysicalDeviceShaderExpectAssumeFeatures,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance6FeaturesKHR = PhysicalDeviceMaintenance6Features,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    PhysicalDeviceMaintenance6PropertiesKHR = PhysicalDeviceMaintenance6Properties,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    BindMemoryStatusKHR = BindMemoryStatus,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    BindDescriptorSetsInfoKHR = BindDescriptorSetsInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    PushConstantsInfoKHR = PushConstantsInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance6", "VK_KHR_push_descriptor"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    PushDescriptorSetInfoKHR = PushDescriptorSetInfo,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance6", "VK_KHR_push_descriptor"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    PushDescriptorSetWithTemplateInfoKHR = PushDescriptorSetWithTemplateInfo,

    [NameSuffix("EXT", 0)]
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
    RenderingEndInfoEXT = RenderingEndInfoKHR,
}
