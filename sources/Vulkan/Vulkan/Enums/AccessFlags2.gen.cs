// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccessFlags2")]
[Flags]
public enum AccessFlags2 : ulong
{
    [NativeName("VK_ACCESS_2_NONE")]
    None = 0x0,

    [NativeName("VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT")]
    IndirectCommandReadBit = 0x1,

    [NativeName("VK_ACCESS_2_INDEX_READ_BIT")]
    IndexReadBit = 0x2,

    [NativeName("VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT")]
    VertexAttributeReadBit = 0x4,

    [NativeName("VK_ACCESS_2_UNIFORM_READ_BIT")]
    UniformReadBit = 0x8,

    [NativeName("VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT")]
    InputAttachmentReadBit = 0x10,

    [NativeName("VK_ACCESS_2_SHADER_READ_BIT")]
    ShaderReadBit = 0x20,

    [NativeName("VK_ACCESS_2_SHADER_WRITE_BIT")]
    ShaderWriteBit = 0x40,

    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT")]
    ColorAttachmentReadBit = 0x80,

    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT")]
    ColorAttachmentWriteBit = 0x100,

    [NativeName("VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
    DepthStencilAttachmentReadBit = 0x200,

    [NativeName("VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
    DepthStencilAttachmentWriteBit = 0x400,

    [NativeName("VK_ACCESS_2_TRANSFER_READ_BIT")]
    TransferReadBit = 0x800,

    [NativeName("VK_ACCESS_2_TRANSFER_WRITE_BIT")]
    TransferWriteBit = 0x1000,

    [NativeName("VK_ACCESS_2_HOST_READ_BIT")]
    HostReadBit = 0x2000,

    [NativeName("VK_ACCESS_2_HOST_WRITE_BIT")]
    HostWriteBit = 0x4000,

    [NativeName("VK_ACCESS_2_MEMORY_READ_BIT")]
    MemoryReadBit = 0x8000,

    [NativeName("VK_ACCESS_2_MEMORY_WRITE_BIT")]
    MemoryWriteBit = 0x10000,

    [NativeName("VK_ACCESS_2_SHADER_SAMPLED_READ_BIT")]
    ShaderSampledReadBit = 0x100000000,

    [NativeName("VK_ACCESS_2_SHADER_STORAGE_READ_BIT")]
    ShaderStorageReadBit = 0x200000000,

    [NativeName("VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT")]
    ShaderStorageWriteBit = 0x400000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR")]
    VideoDecodeReadBitkhr = 0x800000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR")]
    VideoDecodeWriteBitkhr = 0x1000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR")]
    VideoEncodeReadBitkhr = 0x2000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR")]
    VideoEncodeWriteBitkhr = 0x4000000000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_ACCESS_2_SHADER_TILE_ATTACHMENT_READ_BIT_QCOM")]
    ShaderTileAttachmentReadBitqcom = 0x8000000000000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_ACCESS_2_SHADER_TILE_ATTACHMENT_WRITE_BIT_QCOM")]
    ShaderTileAttachmentWriteBitqcom = 0x10000000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_NONE_KHR")]
    Nonekhr = 0x0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR")]
    IndirectCommandReadBitkhr = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_INDEX_READ_BIT_KHR")]
    IndexReadBitkhr = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR")]
    VertexAttributeReadBitkhr = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_UNIFORM_READ_BIT_KHR")]
    UniformReadBitkhr = 0x8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR")]
    InputAttachmentReadBitkhr = 0x10,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_READ_BIT_KHR")]
    ShaderReadBitkhr = 0x20,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_WRITE_BIT_KHR")]
    ShaderWriteBitkhr = 0x40,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR")]
    ColorAttachmentReadBitkhr = 0x80,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR")]
    ColorAttachmentWriteBitkhr = 0x100,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR")]
    DepthStencilAttachmentReadBitkhr = 0x200,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR")]
    DepthStencilAttachmentWriteBitkhr = 0x400,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_TRANSFER_READ_BIT_KHR")]
    TransferReadBitkhr = 0x800,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR")]
    TransferWriteBitkhr = 0x1000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_HOST_READ_BIT_KHR")]
    HostReadBitkhr = 0x2000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_HOST_WRITE_BIT_KHR")]
    HostWriteBitkhr = 0x4000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_MEMORY_READ_BIT_KHR")]
    MemoryReadBitkhr = 0x8000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_MEMORY_WRITE_BIT_KHR")]
    MemoryWriteBitkhr = 0x10000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR")]
    ShaderSampledReadBitkhr = 0x100000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR")]
    ShaderStorageReadBitkhr = 0x200000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR")]
    ShaderStorageWriteBitkhr = 0x400000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT")]
    TransformFeedbackWriteBitext = 0x2000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT")]
    TransformFeedbackCounterReadBitext = 0x4000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT")]
    TransformFeedbackCounterWriteBitext = 0x8000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT")]
    ConditionalRenderingReadBitext = 0x100000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV")]
    CommandPreprocessReadBitnv = 0x20000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV")]
    CommandPreprocessWriteBitnv = 0x40000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_EXT")]
    CommandPreprocessReadBitext = 0x20000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_EXT")]
    CommandPreprocessWriteBitext = 0x40000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR")]
    FragmentShadingRateAttachmentReadBitkhr = 0x800000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV")]
    ShadingRateImageReadBitnv = 0x800000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR")]
    AccelerationStructureReadBitkhr = 0x200000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR")]
    AccelerationStructureWriteBitkhr = 0x400000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV")]
    AccelerationStructureReadBitnv = 0x200000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV")]
    AccelerationStructureWriteBitnv = 0x400000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT")]
    FragmentDensityMapReadBitext = 0x1000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT")]
    ColorAttachmentReadNoncoherentBitext = 0x80000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_DESCRIPTOR_BUFFER_READ_BIT_EXT")]
    DescriptorBufferReadBitext = 0x20000000000,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI")]
    InvocationMaskReadBithuawei = 0x8000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_BINDING_TABLE_READ_BIT_KHR")]
    ShaderBindingTableReadBitkhr = 0x10000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_MICROMAP_READ_BIT_EXT")]
    MicromapReadBitext = 0x100000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_MICROMAP_WRITE_BIT_EXT")]
    MicromapWriteBitext = 0x200000000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_OPTICAL_FLOW_READ_BIT_NV")]
    OpticalFlowReadBitnv = 0x40000000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_OPTICAL_FLOW_WRITE_BIT_NV")]
    OpticalFlowWriteBitnv = 0x80000000000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_ACCESS_2_DATA_GRAPH_READ_BIT_ARM")]
    DataGraphReadBitarm = 0x800000000000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_ACCESS_2_DATA_GRAPH_WRITE_BIT_ARM")]
    DataGraphWriteBitarm = 0x1000000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_MEMORY_DECOMPRESSION_READ_BIT_EXT")]
    MemoryDecompressionReadBitext = 0x80000000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_MEMORY_DECOMPRESSION_WRITE_BIT_EXT")]
    MemoryDecompressionWriteBitext = 0x100000000000000,
}
