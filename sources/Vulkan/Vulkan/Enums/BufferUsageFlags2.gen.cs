// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBufferUsageFlags2")]
[Flags]
public enum BufferUsageFlags2 : ulong
{
    None = 0x0,

    [NativeName("VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT")]
    TransferSrcBit = 0x1,

    [NativeName("VK_BUFFER_USAGE_2_TRANSFER_DST_BIT")]
    TransferDstBit = 0x2,

    [NativeName("VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT")]
    UniformTexelBufferBit = 0x4,

    [NativeName("VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT")]
    StorageTexelBufferBit = 0x8,

    [NativeName("VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT")]
    UniformBufferBit = 0x10,

    [NativeName("VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT")]
    StorageBufferBit = 0x20,

    [NativeName("VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT")]
    IndexBufferBit = 0x40,

    [NativeName("VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT")]
    VertexBufferBit = 0x80,

    [NativeName("VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT")]
    IndirectBufferBit = 0x100,

    [NativeName("VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT")]
    ShaderDeviceAddressBit = 0x20000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT_KHR")]
    TransferSrcBitkhr = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_TRANSFER_DST_BIT_KHR")]
    TransferDstBitkhr = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR")]
    UniformTexelBufferBitkhr = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT_KHR")]
    StorageTexelBufferBitkhr = 0x8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT_KHR")]
    UniformBufferBitkhr = 0x10,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT_KHR")]
    StorageBufferBitkhr = 0x20,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT_KHR")]
    IndexBufferBitkhr = 0x40,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT_KHR")]
    VertexBufferBitkhr = 0x80,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT_KHR")]
    IndirectBufferBitkhr = 0x100,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_BUFFER_USAGE_2_CONDITIONAL_RENDERING_BIT_EXT")]
    ConditionalRenderingBitext = 0x200,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR")]
    ShaderBindingTableBitkhr = 0x400,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_BUFFER_USAGE_2_RAY_TRACING_BIT_NV")]
    RayTracingBitnv = 0x400,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT")]
    TransformFeedbackBufferBitext = 0x800,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT")]
    TransformFeedbackCounterBufferBitext = 0x1000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR")]
    VideoDecodeSrcBitkhr = 0x2000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_VIDEO_DECODE_DST_BIT_KHR")]
    VideoDecodeDstBitkhr = 0x4000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR")]
    VideoEncodeDstBitkhr = 0x8000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR")]
    VideoEncodeSrcBitkhr = 0x10000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT_KHR")]
    ShaderDeviceAddressBitkhr = 0x20000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR")]
    AccelerationStructureBuildInputReadOnlyBitkhr = 0x80000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR")]
    AccelerationStructureStorageBitkhr = 0x100000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_BUFFER_USAGE_2_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT")]
    SamplerDescriptorBufferBitext = 0x200000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_BUFFER_USAGE_2_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT")]
    ResourceDescriptorBufferBitext = 0x400000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_BUFFER_USAGE_2_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT")]
    PushDescriptorsDescriptorBufferBitext = 0x4000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_BUFFER_USAGE_2_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT")]
    MicromapBuildInputReadOnlyBitext = 0x800000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_BUFFER_USAGE_2_MICROMAP_STORAGE_BIT_EXT")]
    MicromapStorageBitext = 0x1000000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_BUFFER_USAGE_2_DATA_GRAPH_FOREIGN_DESCRIPTOR_BIT_ARM")]
    DataGraphForeignDescriptorBitarm = 0x20000000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_BUFFER_USAGE_2_TILE_MEMORY_BIT_QCOM")]
    TileMemoryBitqcom = 0x8000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_BUFFER_USAGE_2_MEMORY_DECOMPRESSION_BIT_EXT")]
    MemoryDecompressionBitext = 0x100000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_BUFFER_USAGE_2_PREPROCESS_BUFFER_BIT_EXT")]
    PreprocessBufferBitext = 0x80000000,
}
