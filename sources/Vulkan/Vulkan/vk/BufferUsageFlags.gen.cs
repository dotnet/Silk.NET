// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBufferUsageFlags")]
[Flags]
public enum BufferUsageFlags : uint
{
    None = 0x0,

    [NativeName("VK_BUFFER_USAGE_TRANSFER_SRC_BIT")]
    TransferSrcBit = 0x1,

    [NativeName("VK_BUFFER_USAGE_TRANSFER_DST_BIT")]
    TransferDstBit = 0x2,

    [NativeName("VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT")]
    UniformTexelBufferBit = 0x4,

    [NativeName("VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT")]
    StorageTexelBufferBit = 0x8,

    [NativeName("VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT")]
    UniformBufferBit = 0x10,

    [NativeName("VK_BUFFER_USAGE_STORAGE_BUFFER_BIT")]
    StorageBufferBit = 0x20,

    [NativeName("VK_BUFFER_USAGE_INDEX_BUFFER_BIT")]
    IndexBufferBit = 0x40,

    [NativeName("VK_BUFFER_USAGE_VERTEX_BUFFER_BIT")]
    VertexBufferBit = 0x80,

    [NativeName("VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT")]
    IndirectBufferBit = 0x100,

    [NativeName("VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT")]
    ShaderDeviceAddressBit = 0x20000,

    [NativeName("VK_BUFFER_USAGE_VIDEO_DECODE_SRC_BIT_KHR")]
    VideoDecodeSrcBitKHR = 0x2000,

    [NativeName("VK_BUFFER_USAGE_VIDEO_DECODE_DST_BIT_KHR")]
    VideoDecodeDstBitKHR = 0x4000,

    [NativeName("VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT")]
    TransformFeedbackBufferBitEXT = 0x800,

    [NativeName("VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT")]
    TransformFeedbackCounterBufferBitEXT = 0x1000,

    [NativeName("VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT")]
    ConditionalRenderingBitEXT = 0x200,

    [NativeName("VK_BUFFER_USAGE_EXECUTION_GRAPH_SCRATCH_BIT_AMDX")]
    ExecutionGraphScratchBitAMDX = 0x2000000,

    [NativeName("VK_BUFFER_USAGE_DESCRIPTOR_HEAP_BIT_EXT")]
    DescriptorHeapBitEXT = 0x10000000,

    [NativeName("VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR")]
    AccelerationStructureBuildInputReadOnlyBitKHR = 0x80000,

    [NativeName("VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR")]
    AccelerationStructureStorageBitKHR = 0x100000,

    [NativeName("VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR")]
    ShaderBindingTableBitKHR = 0x400,

    [NativeName("VK_BUFFER_USAGE_VIDEO_ENCODE_DST_BIT_KHR")]
    VideoEncodeDstBitKHR = 0x8000,

    [NativeName("VK_BUFFER_USAGE_VIDEO_ENCODE_SRC_BIT_KHR")]
    VideoEncodeSrcBitKHR = 0x10000,

    [NativeName("VK_BUFFER_USAGE_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT")]
    SamplerDescriptorBufferBitEXT = 0x200000,

    [NativeName("VK_BUFFER_USAGE_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT")]
    ResourceDescriptorBufferBitEXT = 0x400000,

    [NativeName("VK_BUFFER_USAGE_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT")]
    PushDescriptorsDescriptorBufferBitEXT = 0x4000000,

    [NativeName("VK_BUFFER_USAGE_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT")]
    MicromapBuildInputReadOnlyBitEXT = 0x800000,

    [NativeName("VK_BUFFER_USAGE_MICROMAP_STORAGE_BIT_EXT")]
    MicromapStorageBitEXT = 0x1000000,

    [NativeName("VK_BUFFER_USAGE_TILE_MEMORY_BIT_QCOM")]
    TileMemoryBitQCOM = 0x8000000,

    [NativeName("VK_BUFFER_USAGE_RAY_TRACING_BIT_NV")]
    RayTracingBitNV = ShaderBindingTableBitKHR,

    [NativeName("VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_EXT")]
    ShaderDeviceAddressBitEXT = ShaderDeviceAddressBit,

    [NativeName("VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_KHR")]
    ShaderDeviceAddressBitKHR = ShaderDeviceAddressBit,
}
