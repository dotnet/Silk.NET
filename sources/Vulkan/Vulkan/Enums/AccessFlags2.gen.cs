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
    VideoDecodeReadBitKHR = 0x800000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR")]
    VideoDecodeWriteBitKHR = 0x1000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR")]
    VideoEncodeReadBitKHR = 0x2000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR")]
    VideoEncodeWriteBitKHR = 0x4000000000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_ACCESS_2_SHADER_TILE_ATTACHMENT_READ_BIT_QCOM")]
    ShaderTileAttachmentReadBitQCOM = 0x8000000000000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_ACCESS_2_SHADER_TILE_ATTACHMENT_WRITE_BIT_QCOM")]
    ShaderTileAttachmentWriteBitQCOM = 0x10000000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_NONE_KHR")]
    NoneKHR = 0x0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR")]
    IndirectCommandReadBitKHR = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_INDEX_READ_BIT_KHR")]
    IndexReadBitKHR = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR")]
    VertexAttributeReadBitKHR = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_UNIFORM_READ_BIT_KHR")]
    UniformReadBitKHR = 0x8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR")]
    InputAttachmentReadBitKHR = 0x10,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_READ_BIT_KHR")]
    ShaderReadBitKHR = 0x20,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_WRITE_BIT_KHR")]
    ShaderWriteBitKHR = 0x40,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR")]
    ColorAttachmentReadBitKHR = 0x80,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR")]
    ColorAttachmentWriteBitKHR = 0x100,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR")]
    DepthStencilAttachmentReadBitKHR = 0x200,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR")]
    DepthStencilAttachmentWriteBitKHR = 0x400,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_TRANSFER_READ_BIT_KHR")]
    TransferReadBitKHR = 0x800,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR")]
    TransferWriteBitKHR = 0x1000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_HOST_READ_BIT_KHR")]
    HostReadBitKHR = 0x2000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_HOST_WRITE_BIT_KHR")]
    HostWriteBitKHR = 0x4000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_MEMORY_READ_BIT_KHR")]
    MemoryReadBitKHR = 0x8000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_MEMORY_WRITE_BIT_KHR")]
    MemoryWriteBitKHR = 0x10000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR")]
    ShaderSampledReadBitKHR = 0x100000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR")]
    ShaderStorageReadBitKHR = 0x200000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR")]
    ShaderStorageWriteBitKHR = 0x400000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT")]
    TransformFeedbackWriteBitEXT = 0x2000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT")]
    TransformFeedbackCounterReadBitEXT = 0x4000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT")]
    TransformFeedbackCounterWriteBitEXT = 0x8000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT")]
    ConditionalRenderingReadBitEXT = 0x100000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV")]
    CommandPreprocessReadBitNV = 0x20000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV")]
    CommandPreprocessWriteBitNV = 0x40000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_EXT")]
    CommandPreprocessReadBitEXT = 0x20000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_EXT")]
    CommandPreprocessWriteBitEXT = 0x40000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR")]
    FragmentShadingRateAttachmentReadBitKHR = 0x800000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV")]
    ShadingRateImageReadBitNV = 0x800000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR")]
    AccelerationStructureReadBitKHR = 0x200000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR")]
    AccelerationStructureWriteBitKHR = 0x400000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV")]
    AccelerationStructureReadBitNV = 0x200000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV")]
    AccelerationStructureWriteBitNV = 0x400000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT")]
    FragmentDensityMapReadBitEXT = 0x1000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT")]
    ColorAttachmentReadNoncoherentBitEXT = 0x80000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_DESCRIPTOR_BUFFER_READ_BIT_EXT")]
    DescriptorBufferReadBitEXT = 0x20000000000,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI")]
    InvocationMaskReadBitHuawei = 0x8000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ACCESS_2_SHADER_BINDING_TABLE_READ_BIT_KHR")]
    ShaderBindingTableReadBitKHR = 0x10000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_MICROMAP_READ_BIT_EXT")]
    MicromapReadBitEXT = 0x100000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_MICROMAP_WRITE_BIT_EXT")]
    MicromapWriteBitEXT = 0x200000000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_OPTICAL_FLOW_READ_BIT_NV")]
    OpticalFlowReadBitNV = 0x40000000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ACCESS_2_OPTICAL_FLOW_WRITE_BIT_NV")]
    OpticalFlowWriteBitNV = 0x80000000000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_ACCESS_2_DATA_GRAPH_READ_BIT_ARM")]
    DataGraphReadBitARM = 0x800000000000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_ACCESS_2_DATA_GRAPH_WRITE_BIT_ARM")]
    DataGraphWriteBitARM = 0x1000000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_MEMORY_DECOMPRESSION_READ_BIT_EXT")]
    MemoryDecompressionReadBitEXT = 0x80000000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ACCESS_2_MEMORY_DECOMPRESSION_WRITE_BIT_EXT")]
    MemoryDecompressionWriteBitEXT = 0x100000000000000,
}
