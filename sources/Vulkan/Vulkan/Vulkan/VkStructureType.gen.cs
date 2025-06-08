// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkStructureType
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_APPLICATION_INFO = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_SUBMIT_INFO = 4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO = 5,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE = 6,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_BIND_SPARSE_INFO = 7,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_FENCE_CREATE_INFO = 8,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO = 9,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_EVENT_CREATE_INFO = 10,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO = 11,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO = 12,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO = 13,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO = 14,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO = 15,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO = 16,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO = 17,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO = 18,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO = 19,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO = 20,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO = 21,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO = 22,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO = 23,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO = 24,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO = 25,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO = 26,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO = 27,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO = 28,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO = 29,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO = 30,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO = 31,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO = 32,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO = 33,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO = 34,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET = 35,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET = 36,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO = 37,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO = 38,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO = 39,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO = 40,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO = 41,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO = 42,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO = 43,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER = 44,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER = 45,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_MEMORY_BARRIER = 46,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO = 47,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO = 48,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES = 1000094000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO = 1000157000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO = 1000157001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES = 1000083000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS = 1000127000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO = 1000127001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO = 1000060000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO = 1000060003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO = 1000060004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO = 1000060005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO = 1000060006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO = 1000060013,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO = 1000060014,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES = 1000070000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO = 1000070001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2 = 1000146000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2 = 1000146001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2 = 1000146002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2 = 1000146003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2 = 1000146004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2 = 1000059000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2 = 1000059001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2 = 1000059002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2 = 1000059003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2 = 1000059004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2 = 1000059005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2 = 1000059006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2 = 1000059007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2 = 1000059008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES = 1000117000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO = 1000117001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO = 1000117002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO = 1000117003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO = 1000053000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES = 1000053001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES = 1000053002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES = 1000120000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO = 1000145000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES = 1000145001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES = 1000145002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2 = 1000145003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO = 1000156000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO = 1000156001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO = 1000156002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO = 1000156003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES = 1000156004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES = 1000156005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO = 1000085000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO = 1000071000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES = 1000071001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO = 1000071002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES = 1000071003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES = 1000071004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO = 1000072000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO = 1000072001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO = 1000072002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO = 1000112000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES = 1000112001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO = 1000113000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO = 1000077000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO = 1000076000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES = 1000076001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES = 1000168000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT = 1000168001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES = 1000063000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_FEATURES = 49,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES = 50,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES = 51,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES = 52,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO = 1000147000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2 = 1000109000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2 = 1000109001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2 = 1000109002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2 = 1000109003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2 = 1000109004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO = 1000109005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_SUBPASS_END_INFO = 1000109006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES = 1000177000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES = 1000196000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES = 1000180000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES = 1000082000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES = 1000197000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO = 1000161000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES = 1000161001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES = 1000161002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO = 1000161003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT = 1000161004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES = 1000199000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE = 1000199001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES = 1000221000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO = 1000246000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES = 1000130000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO = 1000130001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES = 1000211000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES = 1000108000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO = 1000108001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO = 1000108002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO = 1000108003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES = 1000253000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES = 1000175000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES = 1000241000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT = 1000241001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT = 1000241002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES = 1000261000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES = 1000207000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES = 1000207001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO = 1000207002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO = 1000207003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO = 1000207004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO = 1000207005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES = 1000257000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO = 1000244001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO = 1000257002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO = 1000257003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO = 1000257004,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_FEATURES = 53,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_PROPERTIES = 54,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO = 1000192000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES = 1000215000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES = 1000245000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES = 1000276000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES = 1000295000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO = 1000295001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO = 1000295002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES = 1000297000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_MEMORY_BARRIER_2 = 1000314000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2 = 1000314001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2 = 1000314002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_DEPENDENCY_INFO = 1000314003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_SUBMIT_INFO_2 = 1000314004,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO = 1000314005,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO = 1000314006,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES = 1000314007,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES = 1000325000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES = 1000335000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2 = 1000337000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2 = 1000337001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2 = 1000337002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2 = 1000337003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2 = 1000337004,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2 = 1000337005,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_BUFFER_COPY_2 = 1000337006,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_IMAGE_COPY_2 = 1000337007,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_IMAGE_BLIT_2 = 1000337008,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2 = 1000337009,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2 = 1000337010,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES = 1000225000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO = 1000225001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES = 1000225002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES = 1000138000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES = 1000138001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK = 1000138002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO = 1000138003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES = 1000066000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_RENDERING_INFO = 1000044000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO = 1000044001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO = 1000044002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES = 1000044003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO = 1000044004,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES = 1000280000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES = 1000280001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES = 1000281001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3 = 1000360000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES = 1000413000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES = 1000413001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS = 1000413002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS = 1000413003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_4_FEATURES = 55,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_4_PROPERTIES = 56,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO = 1000174000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES = 1000388000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES = 1000388001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES = 1000416000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES = 1000528000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES = 1000544000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES = 1000259000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO = 1000259001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES = 1000259002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES = 1000525000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO = 1000190001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES = 1000190002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES = 1000265000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_MEMORY_MAP_INFO = 1000271000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO = 1000271001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES = 1000470000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES = 1000470001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_RENDERING_AREA_INFO = 1000470003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO = 1000470004,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2 = 1000338002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2 = 1000338003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO = 1000470005,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO = 1000470006,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES = 1000080000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES = 1000232000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO = 1000232001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO = 1000232002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES = 1000545000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES = 1000545001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS = 1000545002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO = 1000545003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO = 1000545004,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO = 1000545005,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO = 1000545006,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES = 1000466000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO = 1000068000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES = 1000068001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES = 1000068002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES = 1000270000,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES = 1000270001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY = 1000270002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY = 1000270003,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO = 1000270004,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO = 1000270005,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO = 1000270006,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO = 1000270007,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE = 1000270008,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY = 1000270009,

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR = 1000001000,

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_PRESENT_INFO_KHR = 1000001001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR = 1000060007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR = 1000060008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR = 1000060009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR = 1000060010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR = 1000060011,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR = 1000060012,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR = 1000002000,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR = 1000002001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_display_swapchain"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_swapchain"]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR = 1000003000,

    [SupportedApiProfile("vulkan", ["VK_KHR_xlib_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR = 1000004000,

    [SupportedApiProfile("vulkan", ["VK_KHR_xcb_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR = 1000005000,

    [SupportedApiProfile("vulkan", ["VK_KHR_wayland_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR = 1000006000,

    [SupportedApiProfile("vulkan", ["VK_KHR_android_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR = 1000008000,

    [SupportedApiProfile("vulkan", ["VK_KHR_win32_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR = 1000009000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT = 1000011000,

    [SupportedApiProfile("vulkan", ["VK_AMD_rasterization_order"])]
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD = 1000018000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT = 1000022000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT = 1000022001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_marker"], ImpliesSets = ["VK_EXT_debug_report"])]
    VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT = 1000022002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR = 1000023000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR = 1000023001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR = 1000023002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR = 1000023003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR = 1000023004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR = 1000023005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000023006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR = 1000023007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR = 1000023008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR = 1000023009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR = 1000023010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR = 1000023011,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR = 1000023012,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR = 1000023013,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR = 1000023014,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR = 1000023015,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR = 1000023016,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR = 1000024000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR = 1000024001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR = 1000024002,

    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV = 1000026000,

    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV = 1000026001,

    [SupportedApiProfile("vulkan", ["VK_NV_dedicated_allocation"])]
    VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV = 1000026002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT = 1000028000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT = 1000028001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback"],
        ImpliesSets = [
            "VK_EXT_transform_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_transform_feedback+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT = 1000028002,

    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX = 1000029000,

    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX = 1000029001,

    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX = 1000029002,

    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    VK_STRUCTURE_TYPE_CU_MODULE_TEXTURING_MODE_CREATE_INFO_NVX = 1000029004,

    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX = 1000030000,

    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX = 1000030001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_KHR = 1000038000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000038001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR = 1000038002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_KHR = 1000038003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_KHR = 1000038004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_KHR = 1000038005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_GOP_REMAINING_FRAME_INFO_KHR = 1000038006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_KHR = 1000038007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_KHR = 1000038008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_KHR = 1000038009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_KHR = 1000038010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUALITY_LEVEL_PROPERTIES_KHR = 1000038011,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_GET_INFO_KHR = 1000038012,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_FEEDBACK_INFO_KHR = 1000038013,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_KHR = 1000039000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000039001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR = 1000039002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PICTURE_INFO_KHR = 1000039003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_KHR = 1000039004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_KHR = 1000039005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_GOP_REMAINING_FRAME_INFO_KHR = 1000039006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_KHR = 1000039007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_KHR = 1000039009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_KHR = 1000039010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_KHR = 1000039011,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUALITY_LEVEL_PROPERTIES_KHR = 1000039012,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_GET_INFO_KHR = 1000039013,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_FEEDBACK_INFO_KHR = 1000039014,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR = 1000040000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR = 1000040001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR = 1000040003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000040004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR = 1000040005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR = 1000040006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_texture_gather_bias_lod"],
        ImpliesSets = [
            "VK_AMD_texture_gather_bias_lod+VK_KHR_get_physical_device_properties2",
            "VK_AMD_texture_gather_bias_lod+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD = 1000041000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_GGP_stream_descriptor_surface"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP = 1000049000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_corner_sampled_image"],
        ImpliesSets = [
            "VK_NV_corner_sampled_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_corner_sampled_image+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV = 1000050000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV = 1000056000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV = 1000056001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV = 1000057000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV = 1000057001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV = 1000058000,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT = 1000061000,

    [SupportedApiProfile("vulkan", ["VK_NN_vi_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN = 1000062000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT = 1000067000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT = 1000067001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR = 1000073000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR = 1000073001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR = 1000073002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR = 1000073003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR = 1000074000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR = 1000074001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_fd"],
        ImpliesSets = [
            "VK_KHR_external_memory_fd+VK_KHR_external_memory",
            "VK_KHR_external_memory_fd+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR = 1000074002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_win32_keyed_mutex"],
        ImpliesSets = ["VK_KHR_external_memory_win32"]
    )]
    VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR = 1000075000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = 1000078000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = 1000078001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR = 1000078002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR = 1000078003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_fd"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_fd+VK_KHR_external_semaphore",
            "VK_KHR_external_semaphore_fd+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR = 1000079000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_fd"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_fd+VK_KHR_external_semaphore",
            "VK_KHR_external_semaphore_fd+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR = 1000079001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT = 1000081000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT = 1000081001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT = 1000081002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_incremental_present"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR = 1000084000,

    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV = 1000087000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT = 1000090000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT = 1000091000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT = 1000091001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT = 1000091002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT = 1000091003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_GOOGLE_display_timing"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE = 1000092000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NVX_multiview_per_view_attributes"],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX = 1000097000,

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
    VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX = 1000044009,

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV = 1000098000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT = 1000099000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_discard_rectangles"],
        ImpliesSets = [
            "VK_EXT_discard_rectangles+VK_KHR_get_physical_device_properties2",
            "VK_EXT_discard_rectangles+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT = 1000099001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT = 1000101000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT = 1000101001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT = 1000102000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT = 1000102001,

    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    VK_STRUCTURE_TYPE_HDR_METADATA_EXT = 1000105000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_IMG_relaxed_line_rasterization"],
        ImpliesSets = [
            "VK_IMG_relaxed_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_IMG_relaxed_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RELAXED_LINE_RASTERIZATION_FEATURES_IMG = 1000110000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR = 1000111000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR = 1000114000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR = 1000114001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_win32"],
        ImpliesSets = ["VK_KHR_external_fence"]
    )]
    VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR = 1000114002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_fd"],
        ImpliesSets = [
            "VK_KHR_external_fence_fd+VK_KHR_external_fence",
            "VK_KHR_external_fence_fd+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR = 1000115000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_fd"],
        ImpliesSets = [
            "VK_KHR_external_fence_fd+VK_KHR_external_fence",
            "VK_KHR_external_fence_fd+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR = 1000115001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR = 1000116000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR = 1000116001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR = 1000116002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR = 1000116003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR = 1000116004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR = 1000116005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR = 1000116006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR = 1000119000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR = 1000119001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR = 1000119002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR = 1000121000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR = 1000121001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR = 1000121002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR = 1000121003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR = 1000121004,

    [SupportedApiProfile("vulkan", ["VK_MVK_ios_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK = 1000122000,

    [SupportedApiProfile("vulkan", ["VK_MVK_macos_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK = 1000123000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT = 1000128000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT = 1000128001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT = 1000128002,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT = 1000128003,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT = 1000128004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID = 1000129000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID = 1000129001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID = 1000129002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = 1000129003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = 1000129004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_memory_android_hardware_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID = 1000129005,

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
    VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID = 1000129006,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_AMD_mixed_attachment_samples+VK_KHR_dynamic_rendering",
            "VK_AMD_mixed_attachment_samples+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD = 1000044008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_BFLOAT16_FEATURES_KHR = 1000141000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT = 1000143000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT = 1000143001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT = 1000143002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT = 1000143003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sample_locations"],
        ImpliesSets = [
            "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sample_locations+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT = 1000143004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT = 1000148000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT = 1000148001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_blend_operation_advanced"],
        ImpliesSets = [
            "VK_EXT_blend_operation_advanced+VK_KHR_get_physical_device_properties2",
            "VK_EXT_blend_operation_advanced+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT = 1000148002,

    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV = 1000149000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR = 1000150007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR = 1000150000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR = 1000150002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR = 1000150003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR = 1000150004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR = 1000150005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR = 1000150006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR = 1000150009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR = 1000150010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR = 1000150011,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR = 1000150012,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR = 1000150013,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR = 1000150014,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR = 1000150017,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR = 1000150020,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR = 1000347000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR = 1000347001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR = 1000150015,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR = 1000150016,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR = 1000150018,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_query"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_spirv_1_4",
            "VK_KHR_acceleration_structure+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR = 1000348013,

    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV = 1000152000,

    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV = 1000154000,

    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV = 1000154001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT = 1000158000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT = 1000158002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT = 1000158003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT = 1000158004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT = 1000158005,

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
    VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT = 1000158006,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT = 1000160000,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT = 1000160001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV = 1000164000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV = 1000164001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV = 1000164002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV = 1000164005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV = 1000165000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV = 1000165001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_GEOMETRY_NV = 1000165003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV = 1000165004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV = 1000165005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV = 1000165006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV = 1000165007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV = 1000165008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV = 1000165009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV = 1000165011,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV = 1000165012,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV = 1000166000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV = 1000166001,

    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT = 1000170000,

    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT = 1000170001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT = 1000178000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT = 1000178001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT = 1000178002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_clock"],
        ImpliesSets = [
            "VK_KHR_shader_clock+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_clock+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR = 1000181000,

    [SupportedApiProfile("vulkan", ["VK_AMD_pipeline_compiler_control"])]
    VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD = 1000183000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD = 1000185000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR = 1000187000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000187001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR = 1000187002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR = 1000187003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR = 1000187004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_KHR = 1000187005,

    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD = 1000189000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT = 1000190000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_GGP_frame_token"],
        ImpliesSets = ["VK_GGP_stream_descriptor_surface", "VK_KHR_swapchain"]
    )]
    VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP = 1000191000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV = 1000202000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV = 1000202001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shader_image_footprint"],
        ImpliesSets = [
            "VK_NV_shader_image_footprint+VK_KHR_get_physical_device_properties2",
            "VK_NV_shader_image_footprint+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV = 1000204000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV = 1000205000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_scissor_exclusive"],
        ImpliesSets = [
            "VK_NV_scissor_exclusive+VK_KHR_get_physical_device_properties2",
            "VK_NV_scissor_exclusive+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV = 1000205002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostic_checkpoints"],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV = 1000206000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostic_checkpoints"],
        ImpliesSets = [
            "VK_NV_device_diagnostic_checkpoints+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostic_checkpoints+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV = 1000206001,

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
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV = 1000314008,

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
    VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV = 1000314009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_INTEL_shader_integer_functions2"],
        ImpliesSets = [
            "VK_INTEL_shader_integer_functions2+VK_KHR_get_physical_device_properties2",
            "VK_INTEL_shader_integer_functions2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL = 1000209000,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL = 1000210000,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL = 1000210001,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL = 1000210002,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL = 1000210003,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL = 1000210004,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL = 1000210005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pci_bus_info"],
        ImpliesSets = [
            "VK_EXT_pci_bus_info+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pci_bus_info+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT = 1000212000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD = 1000213000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD = 1000213001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_imagepipe_surface"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA = 1000214000,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT = 1000217000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT = 1000218000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT = 1000218001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT = 1000218002,

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
    VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT = 1000044007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = 1000226000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR = 1000226001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR = 1000226002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR = 1000226003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR = 1000226004,

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
    VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = 1000044006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties2"],
        ImpliesSets = ["VK_AMD_shader_core_properties"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD = 1000227000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_device_coherent_memory"],
        ImpliesSets = [
            "VK_AMD_device_coherent_memory+VK_KHR_get_physical_device_properties2",
            "VK_AMD_device_coherent_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD = 1000229000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_image_atomic_int64"],
        ImpliesSets = [
            "VK_EXT_shader_image_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_image_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT = 1000234000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_quad_control"],
        ImpliesSets = [
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_1+VK_KHR_vulkan_memory_model",
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_QUAD_CONTROL_FEATURES_KHR = 1000235000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_budget"],
        ImpliesSets = [
            "VK_EXT_memory_budget+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_budget+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT = 1000237000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_priority"],
        ImpliesSets = [
            "VK_EXT_memory_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_priority+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT = 1000238000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_priority"],
        ImpliesSets = [
            "VK_EXT_memory_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_priority+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT = 1000238001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_protected_capabilities"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR = 1000239000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_dedicated_allocation_image_aliasing"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV = 1000240000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT = 1000244000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT = 1000244002,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT = 1000247000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait"],
        ImpliesSets = ["VK_KHR_present_id", "VK_KHR_swapchain"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR = 1000248000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV = 1000249000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV = 1000249001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV = 1000249002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV = 1000250000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV = 1000250001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_coverage_reduction_mode"],
        ImpliesSets = [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_get_physical_device_properties2",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV = 1000250002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_shader_interlock"],
        ImpliesSets = [
            "VK_EXT_fragment_shader_interlock+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_shader_interlock+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT = 1000251000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_image_arrays"],
        ImpliesSets = [
            "VK_EXT_ycbcr_image_arrays+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_image_arrays+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT = 1000252000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT = 1000254000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT = 1000254001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_provoking_vertex"],
        ImpliesSets = [
            "VK_EXT_provoking_vertex+VK_KHR_get_physical_device_properties2",
            "VK_EXT_provoking_vertex+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT = 1000254002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT = 1000255000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT = 1000255002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive", "VK_KHR_win32_surface"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT = 1000255001,

    [SupportedApiProfile("vulkan", ["VK_EXT_headless_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT = 1000256000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT = 1000260000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT = 1000267000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR = 1000269000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR = 1000269001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR = 1000269002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR = 1000269003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR = 1000269004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_executable_properties"],
        ImpliesSets = [
            "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR = 1000269005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_FEATURES_EXT = 1000272000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_PROPERTIES_EXT = 1000272001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_MAP_PLACED_INFO_EXT = 1000272002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT = 1000273000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT = 1000274000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT = 1000274001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT = 1000274002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT = 1000275000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT = 1000275001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT = 1000275002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT = 1000275003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT = 1000275004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT = 1000275005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV = 1000277000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV = 1000277001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV = 1000277002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV = 1000277003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV = 1000277004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV = 1000277005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV = 1000277006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV = 1000277007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_inherited_viewport_scissor"],
        ImpliesSets = [
            "VK_NV_inherited_viewport_scissor+VK_KHR_get_physical_device_properties2",
            "VK_NV_inherited_viewport_scissor+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV = 1000278000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_inherited_viewport_scissor"],
        ImpliesSets = [
            "VK_NV_inherited_viewport_scissor+VK_KHR_get_physical_device_properties2",
            "VK_NV_inherited_viewport_scissor+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV = 1000278001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texel_buffer_alignment"],
        ImpliesSets = [
            "VK_EXT_texel_buffer_alignment+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texel_buffer_alignment+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT = 1000281000,

    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM = 1000282000,

    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM = 1000282001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT = 1000283000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEPTH_BIAS_INFO_EXT = 1000283001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_bias_control"],
        ImpliesSets = [
            "VK_EXT_depth_bias_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_bias_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEPTH_BIAS_REPRESENTATION_INFO_EXT = 1000283002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT = 1000284000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT = 1000284001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT = 1000284002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT = 1000287000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT = 1000287001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT = 1000287002,

    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR = 1000290000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV = 1000292000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV = 1000292001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_present_barrier"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV = 1000292002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PRESENT_ID_KHR = 1000294000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR = 1000294001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR = 1000299000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR = 1000299001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR = 1000299002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR = 1000299003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR = 1000299004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR = 1000299005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR = 1000299006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_PROPERTIES_KHR = 1000299007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR = 1000299008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_GET_INFO_KHR = 1000299009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_FEEDBACK_INFO_KHR = 1000299010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV = 1000300000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV = 1000300001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_FEATURES_QCOM = 1000309000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_PROPERTIES_QCOM = 1000309001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_TILE_SHADING_CREATE_INFO_QCOM = 1000309002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VK_STRUCTURE_TYPE_PER_TILE_BEGIN_INFO_QCOM = 1000309003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VK_STRUCTURE_TYPE_PER_TILE_END_INFO_QCOM = 1000309004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VK_STRUCTURE_TYPE_DISPATCH_TILE_INFO_QCOM = 1000309005,

    [SupportedApiProfile("vulkan", ["VK_NV_low_latency"])]
    VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV = 1000310000,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT = 1000311000,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT = 1000311001,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT = 1000311002,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT = 1000311003,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT = 1000311004,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT = 1000311005,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT = 1000311006,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT = 1000311007,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT = 1000311008,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT = 1000311009,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT = 1000311010,

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT = 1000311011,

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
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT = 1000316000,

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
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_DENSITY_MAP_PROPERTIES_EXT = 1000316001,

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
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT = 1000316002,

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
    VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT = 1000316003,

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
    VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT = 1000316004,

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
    VK_STRUCTURE_TYPE_BUFFER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316005,

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
    VK_STRUCTURE_TYPE_IMAGE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316006,

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
    VK_STRUCTURE_TYPE_IMAGE_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316007,

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
    VK_STRUCTURE_TYPE_SAMPLER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316008,

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
    VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT = 1000316010,

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
    VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT = 1000316011,

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
    VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT = 1000316012,

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
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT = 1000320000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT = 1000320001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_graphics_pipeline_library"],
        ImpliesSets = [
            "VK_KHR_pipeline_library+VK_KHR_get_physical_device_properties2",
            "VK_KHR_pipeline_library+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT = 1000320002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_early_and_late_fragment_tests"],
        ImpliesSets = [
            "VK_AMD_shader_early_and_late_fragment_tests+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_early_and_late_fragment_tests+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD =
        1000321000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR = 1000203000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_KHR_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_KHR_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR = 1000322000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_uniform_control_flow"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR =
        1000323000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV = 1000326000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV = 1000326001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV = 1000326002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV = 1000327000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV = 1000327001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV = 1000327002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT = 1000328000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT = 1000328001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_2plane_444_formats"],
        ImpliesSets = [
            "VK_EXT_ycbcr_2plane_444_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_2plane_444_formats+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT = 1000330000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT = 1000332000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT = 1000332001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_rotated_copy_commands"],
        ImpliesSets = [
            "VK_QCOM_rotated_copy_commands+VK_KHR_copy_commands2",
            "VK_QCOM_rotated_copy_commands+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM = 1000333000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_workgroup_memory_explicit_layout"],
        ImpliesSets = [
            "VK_KHR_workgroup_memory_explicit_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_workgroup_memory_explicit_layout+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR = 1000336000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT = 1000338000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT = 1000338001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT = 1000338004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_layout"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT = 1000339000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_4444_formats"],
        ImpliesSets = [
            "VK_EXT_4444_formats+VK_KHR_get_physical_device_properties2",
            "VK_EXT_4444_formats+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT = 1000340000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_EXT = 1000341000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT = 1000341001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT = 1000341002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rgba10x6_formats"],
        ImpliesSets = [
            "VK_EXT_rgba10x6_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_rgba10x6_formats+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT = 1000344000,

    [SupportedApiProfile("vulkan", ["VK_EXT_directfb_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT = 1000346000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT = 1000352000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT = 1000352001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_input_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_vertex_input_dynamic_state+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_input_dynamic_state+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT = 1000352002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT = 1000353000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT = 1000354000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT = 1000354001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control"],
        ImpliesSets = [
            "VK_EXT_depth_clip_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT = 1000355000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_control"],
        ImpliesSets = [
            "VK_EXT_depth_clip_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT = 1000355001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitive_topology_list_restart"],
        ImpliesSets = [
            "VK_EXT_primitive_topology_list_restart+VK_KHR_get_physical_device_properties2",
            "VK_EXT_primitive_topology_list_restart+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT = 1000356000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_EXT = 1000361000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA = 1000364000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA = 1000364001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_external_memory",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA = 1000364002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore", "VK_KHR_external_semaphore_capabilities"]
    )]
    VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA = 1000365000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore", "VK_KHR_external_semaphore_capabilities"]
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA = 1000365001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA = 1000366000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA = 1000366001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA = 1000366002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA = 1000366003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA = 1000366004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA = 1000366005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA = 1000366006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA = 1000366007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA = 1000366008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA = 1000366009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI = 1000369000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI = 1000369001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI = 1000369002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_invocation_mask"],
        ImpliesSets = [
            "VK_KHR_ray_tracing_pipeline+VK_KHR_synchronization2",
            "VK_KHR_ray_tracing_pipeline+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI = 1000370000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_rdma"],
        ImpliesSets = [
            "VK_NV_external_memory_rdma+VK_KHR_external_memory",
            "VK_NV_external_memory_rdma+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV = 1000371000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_rdma"],
        ImpliesSets = [
            "VK_NV_external_memory_rdma+VK_KHR_external_memory",
            "VK_NV_external_memory_rdma+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV = 1000371001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT = 1000372000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT = 1000372001,

    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAME_BOUNDARY_FEATURES_EXT = 1000375000,

    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    VK_STRUCTURE_TYPE_FRAME_BOUNDARY_EXT = 1000375001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT =
        1000376000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT = 1000376001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_single_sampled"],
        ImpliesSets = ["VK_KHR_create_renderpass2+VK_KHR_depth_stencil_resolve", "VK_VERSION_1_2"]
    )]
    VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT = 1000376002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state2"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT = 1000377000,

    [SupportedApiProfile("vulkan", ["VK_QNX_screen_surface"], ImpliesSets = ["VK_KHR_surface"])]
    VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX = 1000378000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT = 1000381000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_color_write_enable"],
        ImpliesSets = [
            "VK_EXT_color_write_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_color_write_enable+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT = 1000381001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitives_generated_query"],
        ImpliesSets = ["VK_EXT_transform_feedback"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT = 1000382000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR = 1000386000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_view_min_lod"],
        ImpliesSets = [
            "VK_EXT_image_view_min_lod+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_view_min_lod+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT = 1000391000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_view_min_lod"],
        ImpliesSets = [
            "VK_EXT_image_view_min_lod+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_view_min_lod+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT = 1000391001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multi_draw"],
        ImpliesSets = [
            "VK_EXT_multi_draw+VK_KHR_get_physical_device_properties2",
            "VK_EXT_multi_draw+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT = 1000392000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multi_draw"],
        ImpliesSets = [
            "VK_EXT_multi_draw+VK_KHR_get_physical_device_properties2",
            "VK_EXT_multi_draw+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT = 1000392001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_2d_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT = 1000393000,

    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_FEATURES_EXT = 1000395000,

    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT = 1000395001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT = 1000396000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT = 1000396001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT = 1000396002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT = 1000396003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT = 1000396004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT = 1000396005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_EXT = 1000396006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT = 1000396007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT = 1000396008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT = 1000396009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI = 1000404000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI = 1000404001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_VRS_FEATURES_HUAWEI = 1000404002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT = 1000411000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT = 1000411001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pageable_device_local_memory"],
        ImpliesSets = ["VK_EXT_memory_priority"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT = 1000412000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_properties"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM = 1000415000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    VK_STRUCTURE_TYPE_DEVICE_QUEUE_SHADER_CORE_CONTROL_CREATE_INFO_ARM = 1000417000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_FEATURES_ARM = 1000417001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_PROPERTIES_ARM = 1000417002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_sliced_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT = 1000418000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_sliced_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT = 1000418001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE = 1000420000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE = 1000420001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_descriptor_set_host_mapping"],
        ImpliesSets = [
            "VK_VALVE_descriptor_set_host_mapping+VK_KHR_get_physical_device_properties2",
            "VK_VALVE_descriptor_set_host_mapping+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE = 1000420002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_non_seamless_cube_map"],
        ImpliesSets = [
            "VK_EXT_non_seamless_cube_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_non_seamless_cube_map+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT = 1000422000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_FEATURES_ARM = 1000424000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_PROPERTIES_ARM = 1000424001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_BEGIN_INFO_ARM = 1000424002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_INFO_ARM = 1000424003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_render_pass_striped"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_SUBMIT_INFO_ARM = 1000424004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_NV = 1000426000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_NV = 1000426001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_NV = 1000427000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV = 1000427001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV = 1000428000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV = 1000428001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_INDIRECT_DEVICE_ADDRESS_INFO_NV = 1000428002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_LINEAR_SWEPT_SPHERES_FEATURES_NV = 1000429008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_LINEAR_SWEPT_SPHERES_DATA_NV = 1000429009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_SPHERES_DATA_NV = 1000429010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_linear_color_attachment"],
        ImpliesSets = [
            "VK_NV_linear_color_attachment+VK_KHR_get_physical_device_properties2",
            "VK_NV_linear_color_attachment+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV = 1000430000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_maximal_reconvergence"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MAXIMAL_RECONVERGENCE_FEATURES_KHR = 1000434000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control_swapchain"],
        ImpliesSets = ["VK_EXT_image_compression_control"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT = 1000437000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM = 1000440000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM = 1000440001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM = 1000440002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_FEATURES_EXT = 1000451000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_PROPERTIES_EXT = 1000451001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_acquire_unmodified"],
        ImpliesSets = [
            "VK_EXT_external_memory_acquire_unmodified+VK_KHR_external_memory",
            "VK_EXT_external_memory_acquire_unmodified+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT = 1000453000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT = 1000455000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT = 1000455001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT = 1000458000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT = 1000458001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT = 1000458002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT = 1000458003,

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG = 1000459000,

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG = 1000459001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_FEATURES_EXT = 1000462000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_PROPERTIES_EXT = 1000462001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_MODULE_IDENTIFIER_CREATE_INFO_EXT = 1000462002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_module_identifier"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT = 1000462003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT =
        1000342000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_FEATURES_NV = 1000464000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV = 1000464001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV = 1000464002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_NV = 1000464003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_INFO_NV = 1000464004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV = 1000464005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV = 1000464010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_dithering"],
        ImpliesSets = [
            "VK_EXT_legacy_dithering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_legacy_dithering+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT = 1000465000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_FEATURES_ANDROID = 1000468000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_PROPERTIES_ANDROID = 1000468001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_RESOLVE_PROPERTIES_ANDROID = 1000468002,

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ANTI_LAG_FEATURES_AMD = 1000476000,

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    VK_STRUCTURE_TYPE_ANTI_LAG_DATA_AMD = 1000476001,

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    VK_STRUCTURE_TYPE_ANTI_LAG_PRESENTATION_INFO_AMD = 1000476002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_position_fetch"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_POSITION_FETCH_FEATURES_KHR = 1000481000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_FEATURES_EXT = 1000482000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_PROPERTIES_EXT = 1000482001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_SHADER_CREATE_INFO_EXT = 1000482002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_FEATURES_KHR = 1000483000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_BINARY_CREATE_INFO_KHR = 1000483001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_BINARY_INFO_KHR = 1000483002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_BINARY_KEY_KHR = 1000483003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_PROPERTIES_KHR = 1000483004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_RELEASE_CAPTURED_PIPELINE_DATA_INFO_KHR = 1000483005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_BINARY_DATA_INFO_KHR = 1000483006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_CREATE_INFO_KHR = 1000483007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_DEVICE_PIPELINE_BINARY_INTERNAL_CACHE_CONTROL_KHR = 1000483008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_BINARY_HANDLES_INFO_KHR = 1000483009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM = 1000484000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM = 1000484001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC = 1000485000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC = 1000485001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_viewports"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_viewports+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_viewports+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM = 1000488000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV = 1000490000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV = 1000490001,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_FEATURES_NV = 1000491000,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_PROPERTIES_NV = 1000491001,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_STRUCTURE_TYPE_COOPERATIVE_VECTOR_PROPERTIES_NV = 1000491002,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_STRUCTURE_TYPE_CONVERT_COOPERATIVE_VECTOR_MATRIX_INFO_NV = 1000491004,

    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_FEATURES_NV = 1000492000,

    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_PROPERTIES_NV = 1000492001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mutable_descriptor_type"],
        ImpliesSets = [
            "VK_EXT_mutable_descriptor_type+VK_KHR_maintenance3",
            "VK_EXT_mutable_descriptor_type+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT = 1000351000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mutable_descriptor_type"],
        ImpliesSets = [
            "VK_EXT_mutable_descriptor_type+VK_KHR_maintenance3",
            "VK_EXT_mutable_descriptor_type+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT = 1000351002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_vertex_attributes"],
        ImpliesSets = ["VK_EXT_vertex_input_dynamic_state"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_FEATURES_EXT = 1000495000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_vertex_attributes"],
        ImpliesSets = ["VK_EXT_vertex_input_dynamic_state"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_PROPERTIES_EXT = 1000495001,

    [SupportedApiProfile("vulkan", ["VK_EXT_layer_settings"])]
    VK_STRUCTURE_TYPE_LAYER_SETTINGS_CREATE_INFO_EXT = 1000496000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_builtins"],
        ImpliesSets = [
            "VK_ARM_shader_core_builtins+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_core_builtins+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM = 1000497000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_core_builtins"],
        ImpliesSets = [
            "VK_ARM_shader_core_builtins+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_core_builtins+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM = 1000497001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_library_group_handles"],
        ImpliesSets = ["VK_KHR_pipeline_library", "VK_KHR_ray_tracing_pipeline"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_LIBRARY_GROUP_HANDLES_FEATURES_EXT = 1000498000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_dynamic_rendering_unused_attachments"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_FEATURES_EXT =
        1000499000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_LATENCY_SLEEP_MODE_INFO_NV = 1000505000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_LATENCY_SLEEP_INFO_NV = 1000505001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_SET_LATENCY_MARKER_INFO_NV = 1000505002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_GET_LATENCY_MARKER_INFO_NV = 1000505003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_LATENCY_TIMINGS_FRAME_REPORT_NV = 1000505004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_LATENCY_SUBMISSION_PRESENT_ID_NV = 1000505005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_OUT_OF_BAND_QUEUE_TYPE_INFO_NV = 1000505006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_SWAPCHAIN_LATENCY_CREATE_INFO_NV = 1000505007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_LATENCY_SURFACE_CAPABILITIES_NV = 1000505008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_KHR = 1000506000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_KHR = 1000506001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_KHR = 1000506002,

    [SupportedApiProfile("vulkan", ["VK_QCOM_multiview_per_view_render_areas"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM = 1000510000,

    [SupportedApiProfile("vulkan", ["VK_QCOM_multiview_per_view_render_areas"])]
    VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM = 1000510001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_KHR_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_KHR_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_KHR = 1000201000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_KHR_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_KHR_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_PROPERTIES_KHR = 1000511000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_CAPABILITIES_KHR = 1000512000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PICTURE_INFO_KHR = 1000512001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PROFILE_INFO_KHR = 1000512003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000512004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_DPB_SLOT_INFO_KHR = 1000512005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_CAPABILITIES_KHR = 1000513000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000513001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PICTURE_INFO_KHR = 1000513002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_DPB_SLOT_INFO_KHR = 1000513003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_AV1_FEATURES_KHR = 1000513004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PROFILE_INFO_KHR = 1000513005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_INFO_KHR = 1000513006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_LAYER_INFO_KHR = 1000513007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUALITY_LEVEL_PROPERTIES_KHR = 1000513008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_CREATE_INFO_KHR = 1000513009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_GOP_REMAINING_FRAME_INFO_KHR = 1000513010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance1"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_1_FEATURES_KHR = 1000515000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance1"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    VK_STRUCTURE_TYPE_VIDEO_INLINE_QUERY_INFO_KHR = 1000515001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_per_stage_descriptor_set"],
        ImpliesSets = [
            "VK_NV_per_stage_descriptor_set+VK_KHR_maintenance6",
            "VK_NV_per_stage_descriptor_set+VK_VERSION_1_4",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PER_STAGE_DESCRIPTOR_SET_FEATURES_NV = 1000516000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_FEATURES_QCOM = 1000518000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_PROPERTIES_QCOM = 1000518001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM = 1000518002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VK_STRUCTURE_TYPE_SAMPLER_CUBIC_WEIGHTS_CREATE_INFO_QCOM = 1000519000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_WEIGHTS_FEATURES_QCOM = 1000519001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VK_STRUCTURE_TYPE_BLIT_IMAGE_CUBIC_WEIGHTS_INFO_QCOM = 1000519002,

    [SupportedApiProfile("vulkan", ["VK_QCOM_ycbcr_degamma"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_DEGAMMA_FEATURES_QCOM = 1000520000,

    [SupportedApiProfile("vulkan", ["VK_QCOM_ycbcr_degamma"])]
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM = 1000520001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_clamp"],
        ImpliesSets = [
            "VK_EXT_filter_cubic+VK_EXT_sampler_filter_minmax",
            "VK_EXT_filter_cubic+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_CLAMP_FEATURES_QCOM = 1000521000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_dynamic_state"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_FEATURES_EXT =
        1000524000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SCREEN_BUFFER_PROPERTIES_QNX = 1000529000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SCREEN_BUFFER_FORMAT_PROPERTIES_QNX = 1000529001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMPORT_SCREEN_BUFFER_INFO_QNX = 1000529002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_QNX = 1000529003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QNX_external_memory_screen_buffer"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCREEN_BUFFER_FEATURES_QNX = 1000529004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_MSFT_layered_driver"],
        ImpliesSets = [
            "VK_MSFT_layered_driver+VK_KHR_get_physical_device_properties2",
            "VK_MSFT_layered_driver+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_DRIVER_PROPERTIES_MSFT = 1000530000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_calibrated_timestamps"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_KHR_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_KHR = 1000184000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer", "VK_KHR_maintenance6"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_SET_DESCRIPTOR_BUFFER_OFFSETS_INFO_EXT = 1000545007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer", "VK_KHR_maintenance6"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_BUFFER_EMBEDDED_SAMPLERS_INFO_EXT = 1000545008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_descriptor_pool_overallocation"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_POOL_OVERALLOCATION_FEATURES_NV = 1000546000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_FEATURES_QCOM = 1000547000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_PROPERTIES_QCOM = 1000547001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_TILE_MEMORY_REQUIREMENTS_QCOM = 1000547002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_TILE_MEMORY_BIND_INFO_QCOM = 1000547003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_memory_heap", "VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_TILE_MEMORY_SIZE_INFO_QCOM = 1000547004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_SURFACE_STEREO_CREATE_INFO_NV = 1000551000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    VK_STRUCTURE_TYPE_DISPLAY_MODE_STEREO_PROPERTIES_NV = 1000551001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_FORMAT_QUANTIZATION_MAP_PROPERTIES_KHR = 1000553001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_INFO_KHR = 1000553002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000553005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUANTIZATION_MAP_FEATURES_KHR = 1000553009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_VIDEO_FORMAT_H265_QUANTIZATION_MAP_PROPERTIES_KHR = 1000553006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_VIDEO_FORMAT_AV1_QUANTIZATION_MAP_PROPERTIES_KHR = 1000553008,

    [SupportedApiProfile("vulkan", ["VK_NV_raw_access_chains"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAW_ACCESS_CHAINS_FEATURES_NV = 1000555000,

    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DEVICE_CREATE_INFO_NV = 1000556000,

    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_CREATE_INFO_NV = 1000556001,

    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DATA_PARAMS_NV = 1000556002,

    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_COMPUTE_QUEUE_PROPERTIES_NV = 1000556003,

    [SupportedApiProfile("vulkan", ["VK_KHR_shader_relaxed_extended_instruction"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_RELAXED_EXTENDED_INSTRUCTION_FEATURES_KHR = 1000558000,

    [SupportedApiProfile("vulkan", ["VK_NV_command_buffer_inheritance"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMMAND_BUFFER_INHERITANCE_FEATURES_NV = 1000559000,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_FEATURES_KHR = 1000562000,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_PROPERTIES_KHR = 1000562001,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_LIST_KHR = 1000562002,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_KHR = 1000562003,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_VULKAN_PROPERTIES_KHR = 1000562004,

    [SupportedApiProfile("vulkan", ["VK_NV_shader_atomic_float16_vector"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT16_VECTOR_FEATURES_NV = 1000563000,

    [SupportedApiProfile("vulkan", ["VK_EXT_shader_replicated_composites"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_REPLICATED_COMPOSITES_FEATURES_EXT = 1000564000,

    [SupportedApiProfile("vulkan", ["VK_NV_ray_tracing_validation"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_VALIDATION_FEATURES_NV = 1000568000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_FEATURES_NV = 1000569000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_PROPERTIES_NV = 1000569001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_CLUSTERS_BOTTOM_LEVEL_INPUT_NV = 1000569002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_TRIANGLE_CLUSTER_INPUT_NV = 1000569003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_MOVE_OBJECTS_INPUT_NV = 1000569004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_INPUT_INFO_NV = 1000569005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_COMMANDS_INFO_NV = 1000569006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CLUSTER_ACCELERATION_STRUCTURE_CREATE_INFO_NV =
        1000569007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_FEATURES_NV = 1000570000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_PROPERTIES_NV = 1000570001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_PARTITIONED_ACCELERATION_STRUCTURE_NV = 1000570002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCES_INPUT_NV = 1000570003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_BUILD_PARTITIONED_ACCELERATION_STRUCTURE_INFO_NV = 1000570004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_FLAGS_NV = 1000570005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_EXT = 1000572000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_EXT = 1000572001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_EXT = 1000572002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_CREATE_INFO_EXT = 1000572003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_EXT = 1000572004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_EXT = 1000572006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_EXT = 1000572007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_PIPELINE_EXT = 1000572008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_SHADER_EXT = 1000572009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_PIPELINE_INFO_EXT = 1000572010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_INFO_EXT = 1000572011,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_LAYOUT_INFO_EXT = 1000572012,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_GENERATED_COMMANDS_PIPELINE_INFO_EXT = 1000572013,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_GENERATED_COMMANDS_SHADER_INFO_EXT = 1000572014,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_8_FEATURES_KHR = 1000574000,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_MEMORY_BARRIER_ACCESS_FLAGS_3_KHR = 1000574002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_FEATURES_MESA = 1000575000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_PROPERTIES_MESA = 1000575001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_ALIGNMENT_CONTROL_CREATE_INFO_MESA = 1000575002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_CONTROL_FEATURES_EXT = 1000582000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLAMP_CONTROL_CREATE_INFO_EXT = 1000582001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_2_FEATURES_KHR = 1000586000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_INLINE_SESSION_PARAMETERS_INFO_KHR = 1000586001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_INLINE_SESSION_PARAMETERS_INFO_KHR = 1000586002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_INLINE_SESSION_PARAMETERS_INFO_KHR = 1000586003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HDR_VIVID_FEATURES_HUAWEI = 1000590000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_HDR_VIVID_DYNAMIC_METADATA_HUAWEI = 1000590001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_FEATURES_NV = 1000593000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_FLEXIBLE_DIMENSIONS_PROPERTIES_NV = 1000593001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_PROPERTIES_NV = 1000593002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_pipeline_opacity_micromap"],
        ImpliesSets = ["VK_EXT_opacity_micromap"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_OPACITY_MICROMAP_FEATURES_ARM = 1000596000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_METAL_HANDLE_INFO_EXT = 1000602000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_METAL_HANDLE_PROPERTIES_EXT = 1000602001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_metal"],
        ImpliesSets = [
            "VK_EXT_external_memory_metal+VK_KHR_external_memory",
            "VK_EXT_external_memory_metal+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_GET_METAL_HANDLE_INFO_EXT = 1000602002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_clamp_zero_one"],
        ImpliesSets = [
            "VK_KHR_depth_clamp_zero_one+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_clamp_zero_one+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_KHR = 1000421000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_robustness"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_robustness+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_ROBUSTNESS_FEATURES_EXT = 1000608000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_KHR = 1000286000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_KHR = 1000286001,

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
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_EXT = 1000425000,

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
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_EXT = 1000425001,

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
    VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_EXT = 1000425002,

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
    VK_STRUCTURE_TYPE_RENDERING_END_INFO_EXT = 1000619003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_zero_initialize_device_memory"],
        ImpliesSets = [
            "VK_EXT_zero_initialize_device_memory+VK_KHR_get_physical_device_properties2",
            "VK_EXT_zero_initialize_device_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_DEVICE_MEMORY_FEATURES_EXT = 1000620000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETER_FEATURES =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDERING_INFO_KHR = VK_STRUCTURE_TYPE_RENDERING_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO_KHR = VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO_KHR =
        VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR =
        VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_physical_device_properties2"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR =
        VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR =
        VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR =
        VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_bind_memory2", "VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR =
        VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_bind_memory2", "VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR =
        VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_robustness"],
        ImpliesSets = [
            "VK_EXT_pipeline_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_robustness+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES,

    [SupportedApiProfile("vulkan", ["VK_KHR_device_group_creation"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES,

    [SupportedApiProfile("vulkan", ["VK_KHR_device_group_creation"])]
    VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR =
        VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore_capabilities"]
    )]
    VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_push_descriptor"],
        ImpliesSets = [
            "VK_KHR_push_descriptor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_push_descriptor+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float16_int8"],
        ImpliesSets = [
            "VK_KHR_shader_float16_int8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float16_int8+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float16_int8"],
        ImpliesSets = [
            "VK_KHR_shader_float16_int8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float16_int8+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_16bit_storage"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES,

    [SupportedApiProfile("vulkan", ["VK_KHR_descriptor_update_template"])]
    VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT = VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO_KHR =
        VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO_KHR =
        VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR = VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR = VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR = VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR = VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_create_renderpass2"],
        ImpliesSets = ["VK_KHR_multiview+VK_KHR_maintenance2", "VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR = VK_STRUCTURE_TYPE_SUBPASS_END_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence"],
        ImpliesSets = ["VK_KHR_external_fence_capabilities"]
    )]
    VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_variable_pointers"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_variable_pointers"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dedicated_allocation"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_memory_requirements2",
            "VK_KHR_dedicated_allocation+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR =
        VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dedicated_allocation"],
        ImpliesSets = [
            "VK_KHR_dedicated_allocation+VK_KHR_get_memory_requirements2",
            "VK_KHR_dedicated_allocation+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR =
        VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT =
        VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_inline_uniform_block"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance1",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR =
        VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR =
        VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR =
        VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR = VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_get_memory_requirements2"])]
    VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR =
        VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2,

    [SupportedApiProfile("vulkan", ["VK_KHR_image_format_list"])]
    VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NV_framebuffer_mixed_samples+VK_KHR_dynamic_rendering",
            "VK_NV_framebuffer_mixed_samples+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_NV =
        VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR =
        VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR =
        VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR =
        VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES,

    [SupportedApiProfile("vulkan", ["VK_KHR_bind_memory2"])]
    VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO,

    [SupportedApiProfile("vulkan", ["VK_KHR_bind_memory2"])]
    VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT =
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT =
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance3"],
        ImpliesSets = [
            "VK_KHR_maintenance3+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance3+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance3"],
        ImpliesSets = [
            "VK_KHR_maintenance3+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance3+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR =
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT,

    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_extended_types"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_8bit_storage"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_atomic_int64"],
        ImpliesSets = [
            "VK_KHR_shader_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_calibrated_timestamps"],
        ImpliesSets = [
            "VK_EXT_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_EXT_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT =
        VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_EXT_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_EXT_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES,

    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float_controls"],
        ImpliesSets = [
            "VK_KHR_shader_float_controls+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_float_controls+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR =
        VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_compute_shader_derivatives"],
        ImpliesSets = [
            "VK_NV_compute_shader_derivatives+VK_KHR_get_physical_device_properties2",
            "VK_NV_compute_shader_derivatives+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shader_barycentric"],
        ImpliesSets = [
            "VK_NV_fragment_shader_barycentric+VK_KHR_get_physical_device_properties2",
            "VK_NV_fragment_shader_barycentric+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR =
        VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_timeline_semaphore"],
        ImpliesSets = [
            "VK_KHR_timeline_semaphore+VK_KHR_get_physical_device_properties2",
            "VK_KHR_timeline_semaphore+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO_INTEL =
        VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vulkan_memory_model"],
        ImpliesSets = [
            "VK_KHR_vulkan_memory_model+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vulkan_memory_model+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_terminate_invocation"],
        ImpliesSets = [
            "VK_KHR_shader_terminate_invocation+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_terminate_invocation+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_scalar_block_layout"],
        ImpliesSets = [
            "VK_EXT_scalar_block_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_scalar_block_layout+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subgroup_size_control"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO_KHR =
        VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering_local_read"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO_KHR =
        VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT_KHR =
        VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_separate_depth_stencil_layouts"],
        ImpliesSets = [
            "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_create_renderpass2+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT_KHR =
        VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT = VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES,

    [SupportedApiProfile("vulkan", ["VK_EXT_separate_stencil_usage"])]
    VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_uniform_buffer_standard_layout"],
        ImpliesSets = [
            "VK_KHR_uniform_buffer_standard_layout+VK_KHR_get_physical_device_properties2",
            "VK_KHR_uniform_buffer_standard_layout+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_KHR = VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR =
        VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR =
        VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_query_reset"],
        ImpliesSets = [
            "VK_EXT_host_query_reset+VK_KHR_get_physical_device_properties2",
            "VK_EXT_host_query_reset+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_index_type_uint8"],
        ImpliesSets = [
            "VK_EXT_index_type_uint8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_index_type_uint8+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY_EXT = VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY_EXT = VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO_EXT = VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO_EXT = VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO_EXT =
        VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO_EXT = VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE_EXT =
        VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY_EXT =
        VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY,

    [SupportedApiProfile("vulkan", ["VK_KHR_map_memory2"])]
    VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_MAP_INFO,

    [SupportedApiProfile("vulkan", ["VK_KHR_map_memory2"])]
    VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_demote_to_helper_invocation"],
        ImpliesSets = [
            "VK_EXT_shader_demote_to_helper_invocation+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_demote_to_helper_invocation+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_integer_dot_product"],
        ImpliesSets = [
            "VK_KHR_shader_integer_dot_product+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_integer_dot_product+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_integer_dot_product"],
        ImpliesSets = [
            "VK_KHR_shader_integer_dot_product+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_integer_dot_product+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texel_buffer_alignment"],
        ImpliesSets = [
            "VK_EXT_texel_buffer_alignment+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texel_buffer_alignment+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_robustness2"],
        ImpliesSets = [
            "VK_EXT_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_robustness2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_robustness2"],
        ImpliesSets = [
            "VK_EXT_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_EXT_robustness2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_creation_cache_control"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_MEMORY_BARRIER_2_KHR = VK_STRUCTURE_TYPE_MEMORY_BARRIER_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2_KHR = VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2_KHR = VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR = VK_STRUCTURE_TYPE_DEPENDENCY_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SUBMIT_INFO_2_KHR = VK_STRUCTURE_TYPE_SUBMIT_INFO_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_zero_initialize_workgroup_memory"],
        ImpliesSets = [
            "VK_KHR_zero_initialize_workgroup_memory+VK_KHR_get_physical_device_properties2",
            "VK_KHR_zero_initialize_workgroup_memory+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_robustness"],
        ImpliesSets = [
            "VK_EXT_image_robustness+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_robustness+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR = VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR =
        VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR =
        VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR = VK_STRUCTURE_TYPE_BUFFER_COPY_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR = VK_STRUCTURE_TYPE_IMAGE_COPY_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR = VK_STRUCTURE_TYPE_IMAGE_BLIT_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR = VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_commands2"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR = VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_EXT = VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_EXT = VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_ARM =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_mutable_descriptor_type"],
        ImpliesSets = ["VK_KHR_maintenance3"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_mutable_descriptor_type"],
        ImpliesSets = ["VK_KHR_maintenance3"]
    )]
    VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE =
        VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_format_feature_flags2"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3_KHR = VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_properties"],
        ImpliesSets = [
            "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_properties+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_global_priority_query"],
        ImpliesSets = [
            "VK_EXT_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_global_priority+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_global_priority_query"],
        ImpliesSets = [
            "VK_EXT_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_EXT_global_priority+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT =
        VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS_KHR =
        VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance4"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS_KHR =
        VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS,

    [SupportedApiProfile("vulkan", ["VK_KHR_shader_subgroup_rotate"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_zero_one"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_zero_one+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_zero_one+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_fragment_density_map_offset"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM =
        VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_protected_access"],
        ImpliesSets = [
            "VK_EXT_pipeline_protected_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_protected_access+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_RENDERING_AREA_INFO_KHR = VK_STRUCTURE_TYPE_RENDERING_AREA_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO_KHR =
        VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_KHR = VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_KHR = VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VK_STRUCTURE_TYPE_SHADER_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT =
        VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_vertex_attribute_divisor"],
        ImpliesSets = [
            "VK_KHR_vertex_attribute_divisor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_vertex_attribute_divisor+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_float_controls2"],
        ImpliesSets = ["VK_KHR_shader_float_controls", "VK_VERSION_1_1"]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_index_type_uint8"],
        ImpliesSets = [
            "VK_KHR_index_type_uint8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_index_type_uint8+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_KHR =
        VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_expect_assume"],
        ImpliesSets = [
            "VK_KHR_shader_expect_assume+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_expect_assume+VK_VERSION_1_1",
        ]
    )]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES_KHR =
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS_KHR = VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO_KHR = VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance6"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO_KHR = VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance6", "VK_KHR_push_descriptor"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO_KHR = VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance6", "VK_KHR_push_descriptor"],
        ImpliesSets = ["VK_VERSION_1_1"],
        RequireAll = true
    )]
    VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO_KHR =
        VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_STRUCTURE_TYPE_MAX_ENUM = 0x7FFFFFFF,
}
