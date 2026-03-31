// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccessFlags2")]
[Transformed]
[Flags]
public enum VkAccessFlags2 : ulong
{
    [NativeName("VK_ACCESS_2_NONE")]
    VkAccess2None = unchecked((ulong)0UL),

    [NativeName("VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT")]
    VkAccess2IndirectCommandReadBit = unchecked((ulong)0x00000001UL),

    [NativeName("VK_ACCESS_2_INDEX_READ_BIT")]
    VkAccess2IndexReadBit = unchecked((ulong)0x00000002UL),

    [NativeName("VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT")]
    VkAccess2VertexAttributeReadBit = unchecked((ulong)0x00000004UL),

    [NativeName("VK_ACCESS_2_UNIFORM_READ_BIT")]
    VkAccess2UniformReadBit = unchecked((ulong)0x00000008UL),

    [NativeName("VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT")]
    VkAccess2InputAttachmentReadBit = unchecked((ulong)0x00000010UL),

    [NativeName("VK_ACCESS_2_SHADER_READ_BIT")]
    VkAccess2ShaderReadBit = unchecked((ulong)0x00000020UL),

    [NativeName("VK_ACCESS_2_SHADER_WRITE_BIT")]
    VkAccess2ShaderWriteBit = unchecked((ulong)0x00000040UL),

    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT")]
    VkAccess2ColorAttachmentReadBit = unchecked((ulong)0x00000080UL),

    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT")]
    VkAccess2ColorAttachmentWriteBit = unchecked((ulong)0x00000100UL),

    [NativeName("VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
    VkAccess2DepthStencilAttachmentReadBit = unchecked((ulong)0x00000200UL),

    [NativeName("VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
    VkAccess2DepthStencilAttachmentWriteBit = unchecked((ulong)0x00000400UL),

    [NativeName("VK_ACCESS_2_TRANSFER_READ_BIT")]
    VkAccess2TransferReadBit = unchecked((ulong)0x00000800UL),

    [NativeName("VK_ACCESS_2_TRANSFER_WRITE_BIT")]
    VkAccess2TransferWriteBit = unchecked((ulong)0x00001000UL),

    [NativeName("VK_ACCESS_2_HOST_READ_BIT")]
    VkAccess2HostReadBit = unchecked((ulong)0x00002000UL),

    [NativeName("VK_ACCESS_2_HOST_WRITE_BIT")]
    VkAccess2HostWriteBit = unchecked((ulong)0x00004000UL),

    [NativeName("VK_ACCESS_2_MEMORY_READ_BIT")]
    VkAccess2MemoryReadBit = unchecked((ulong)0x00008000UL),

    [NativeName("VK_ACCESS_2_MEMORY_WRITE_BIT")]
    VkAccess2MemoryWriteBit = unchecked((ulong)0x00010000UL),

    [NativeName("VK_ACCESS_2_SHADER_SAMPLED_READ_BIT")]
    VkAccess2ShaderSampledReadBit = unchecked((ulong)0x100000000UL),

    [NativeName("VK_ACCESS_2_SHADER_STORAGE_READ_BIT")]
    VkAccess2ShaderStorageReadBit = unchecked((ulong)0x200000000UL),

    [NativeName("VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT")]
    VkAccess2ShaderStorageWriteBit = unchecked((ulong)0x400000000UL),

    [NativeName("VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2VideoDecodeReadBitKHR = unchecked((ulong)0x800000000UL),

    [NativeName("VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2VideoDecodeWriteBitKHR = unchecked((ulong)0x1000000000UL),

    [NativeName("VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2VideoEncodeReadBitKHR = unchecked((ulong)0x2000000000UL),

    [NativeName("VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2VideoEncodeWriteBitKHR = unchecked((ulong)0x4000000000UL),

    [NativeName("VK_ACCESS_2_SHADER_TILE_ATTACHMENT_READ_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    VkAccess2ShaderTileAttachmentReadBitQCOM = unchecked((ulong)0x8000000000000UL),

    [NativeName("VK_ACCESS_2_SHADER_TILE_ATTACHMENT_WRITE_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    VkAccess2ShaderTileAttachmentWriteBitQCOM = unchecked((ulong)0x10000000000000UL),

    [NativeName("VK_ACCESS_2_NONE_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2NoneKHR = unchecked((ulong)0UL),

    [NativeName("VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2IndirectCommandReadBitKHR = unchecked((ulong)0x00000001UL),

    [NativeName("VK_ACCESS_2_INDEX_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2IndexReadBitKHR = unchecked((ulong)0x00000002UL),

    [NativeName("VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2VertexAttributeReadBitKHR = unchecked((ulong)0x00000004UL),

    [NativeName("VK_ACCESS_2_UNIFORM_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2UniformReadBitKHR = unchecked((ulong)0x00000008UL),

    [NativeName("VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2InputAttachmentReadBitKHR = unchecked((ulong)0x00000010UL),

    [NativeName("VK_ACCESS_2_SHADER_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2ShaderReadBitKHR = unchecked((ulong)0x00000020UL),

    [NativeName("VK_ACCESS_2_SHADER_WRITE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2ShaderWriteBitKHR = unchecked((ulong)0x00000040UL),

    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2ColorAttachmentReadBitKHR = unchecked((ulong)0x00000080UL),

    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2ColorAttachmentWriteBitKHR = unchecked((ulong)0x00000100UL),

    [NativeName("VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2DepthStencilAttachmentReadBitKHR = unchecked((ulong)0x00000200UL),

    [NativeName("VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2DepthStencilAttachmentWriteBitKHR = unchecked((ulong)0x00000400UL),

    [NativeName("VK_ACCESS_2_TRANSFER_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2TransferReadBitKHR = unchecked((ulong)0x00000800UL),

    [NativeName("VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2TransferWriteBitKHR = unchecked((ulong)0x00001000UL),

    [NativeName("VK_ACCESS_2_HOST_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2HostReadBitKHR = unchecked((ulong)0x00002000UL),

    [NativeName("VK_ACCESS_2_HOST_WRITE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2HostWriteBitKHR = unchecked((ulong)0x00004000UL),

    [NativeName("VK_ACCESS_2_MEMORY_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2MemoryReadBitKHR = unchecked((ulong)0x00008000UL),

    [NativeName("VK_ACCESS_2_MEMORY_WRITE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2MemoryWriteBitKHR = unchecked((ulong)0x00010000UL),

    [NativeName("VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2ShaderSampledReadBitKHR = unchecked((ulong)0x100000000UL),

    [NativeName("VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2ShaderStorageReadBitKHR = unchecked((ulong)0x200000000UL),

    [NativeName("VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2ShaderStorageWriteBitKHR = unchecked((ulong)0x400000000UL),

    [NativeName("VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2TransformFeedbackWriteBitEXT = unchecked((ulong)0x02000000UL),

    [NativeName("VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2TransformFeedbackCounterReadBitEXT = unchecked((ulong)0x04000000UL),

    [NativeName("VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2TransformFeedbackCounterWriteBitEXT = unchecked((ulong)0x08000000UL),

    [NativeName("VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2ConditionalRenderingReadBitEXT = unchecked((ulong)0x00100000UL),

    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkAccess2CommandPreprocessReadBitNV = unchecked((ulong)0x00020000UL),

    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkAccess2CommandPreprocessWriteBitNV = unchecked((ulong)0x00040000UL),

    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2CommandPreprocessReadBitEXT = unchecked((ulong)0x00020000UL),

    [NativeName("VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2CommandPreprocessWriteBitEXT = unchecked((ulong)0x00040000UL),

    [NativeName("VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2FragmentShadingRateAttachmentReadBitKHR = unchecked((ulong)0x00800000UL),

    [NativeName("VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkAccess2ShadingRateImageReadBitNV = unchecked((ulong)0x00800000UL),

    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2AccelerationStructureReadBitKHR = unchecked((ulong)0x00200000UL),

    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2AccelerationStructureWriteBitKHR = unchecked((ulong)0x00400000UL),

    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkAccess2AccelerationStructureReadBitNV = unchecked((ulong)0x00200000UL),

    [NativeName("VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkAccess2AccelerationStructureWriteBitNV = unchecked((ulong)0x00400000UL),

    [NativeName("VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2FragmentDensityMapReadBitEXT = unchecked((ulong)0x01000000UL),

    [NativeName("VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2ColorAttachmentReadNoncoherentBitEXT = unchecked((ulong)0x00080000UL),

    [NativeName("VK_ACCESS_2_DESCRIPTOR_BUFFER_READ_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2DescriptorBufferReadBitEXT = unchecked((ulong)0x20000000000UL),

    [NativeName("VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    VkAccess2InvocationMaskReadBitHUAWEI = unchecked((ulong)0x8000000000UL),

    [NativeName("VK_ACCESS_2_SHADER_BINDING_TABLE_READ_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkAccess2ShaderBindingTableReadBitKHR = unchecked((ulong)0x10000000000UL),

    [NativeName("VK_ACCESS_2_MICROMAP_READ_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2MicromapReadBitEXT = unchecked((ulong)0x100000000000UL),

    [NativeName("VK_ACCESS_2_MICROMAP_WRITE_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2MicromapWriteBitEXT = unchecked((ulong)0x200000000000UL),

    [NativeName("VK_ACCESS_2_OPTICAL_FLOW_READ_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkAccess2OpticalFlowReadBitNV = unchecked((ulong)0x40000000000UL),

    [NativeName("VK_ACCESS_2_OPTICAL_FLOW_WRITE_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkAccess2OpticalFlowWriteBitNV = unchecked((ulong)0x80000000000UL),

    [NativeName("VK_ACCESS_2_DATA_GRAPH_READ_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    VkAccess2DataGraphReadBitARM = unchecked((ulong)0x800000000000UL),

    [NativeName("VK_ACCESS_2_DATA_GRAPH_WRITE_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    VkAccess2DataGraphWriteBitARM = unchecked((ulong)0x1000000000000UL),

    [NativeName("VK_ACCESS_2_MEMORY_DECOMPRESSION_READ_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2MemoryDecompressionReadBitEXT = unchecked((ulong)0x80000000000000UL),

    [NativeName("VK_ACCESS_2_MEMORY_DECOMPRESSION_WRITE_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkAccess2MemoryDecompressionWriteBitEXT = unchecked((ulong)0x100000000000000UL),
}
