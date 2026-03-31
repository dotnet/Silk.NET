// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBufferUsageFlags2")]
[Transformed]
[Flags]
public enum VkBufferUsageFlags2 : ulong
{
    [NativeName("VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT")]
    VkBufferUsage2TransferSrcBit = unchecked((ulong)0x00000001UL),

    [NativeName("VK_BUFFER_USAGE_2_TRANSFER_DST_BIT")]
    VkBufferUsage2TransferDstBit = unchecked((ulong)0x00000002UL),

    [NativeName("VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT")]
    VkBufferUsage2UniformTexelBufferBit = unchecked((ulong)0x00000004UL),

    [NativeName("VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT")]
    VkBufferUsage2StorageTexelBufferBit = unchecked((ulong)0x00000008UL),

    [NativeName("VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT")]
    VkBufferUsage2UniformBufferBit = unchecked((ulong)0x00000010UL),

    [NativeName("VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT")]
    VkBufferUsage2StorageBufferBit = unchecked((ulong)0x00000020UL),

    [NativeName("VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT")]
    VkBufferUsage2IndexBufferBit = unchecked((ulong)0x00000040UL),

    [NativeName("VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT")]
    VkBufferUsage2VertexBufferBit = unchecked((ulong)0x00000080UL),

    [NativeName("VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT")]
    VkBufferUsage2IndirectBufferBit = unchecked((ulong)0x00000100UL),

    [NativeName("VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT")]
    VkBufferUsage2ShaderDeviceAddressBit = unchecked((ulong)0x00020000UL),

    [NativeName("VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2TransferSrcBitKHR = unchecked((ulong)0x00000001UL),

    [NativeName("VK_BUFFER_USAGE_2_TRANSFER_DST_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2TransferDstBitKHR = unchecked((ulong)0x00000002UL),

    [NativeName("VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2UniformTexelBufferBitKHR = unchecked((ulong)0x00000004UL),

    [NativeName("VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2StorageTexelBufferBitKHR = unchecked((ulong)0x00000008UL),

    [NativeName("VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2UniformBufferBitKHR = unchecked((ulong)0x00000010UL),

    [NativeName("VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2StorageBufferBitKHR = unchecked((ulong)0x00000020UL),

    [NativeName("VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2IndexBufferBitKHR = unchecked((ulong)0x00000040UL),

    [NativeName("VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2VertexBufferBitKHR = unchecked((ulong)0x00000080UL),

    [NativeName("VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2IndirectBufferBitKHR = unchecked((ulong)0x00000100UL),

    [NativeName("VK_BUFFER_USAGE_2_CONDITIONAL_RENDERING_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkBufferUsage2ConditionalRenderingBitEXT = unchecked((ulong)0x00000200UL),

    [NativeName("VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2ShaderBindingTableBitKHR = unchecked((ulong)0x00000400UL),

    [NativeName("VK_BUFFER_USAGE_2_RAY_TRACING_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkBufferUsage2RayTracingBitNV = unchecked((ulong)0x00000400UL),

    [NativeName("VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkBufferUsage2TransformFeedbackBufferBitEXT = unchecked((ulong)0x00000800UL),

    [NativeName("VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkBufferUsage2TransformFeedbackCounterBufferBitEXT = unchecked((ulong)0x00001000UL),

    [NativeName("VK_BUFFER_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2VideoDecodeSrcBitKHR = unchecked((ulong)0x00002000UL),

    [NativeName("VK_BUFFER_USAGE_2_VIDEO_DECODE_DST_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2VideoDecodeDstBitKHR = unchecked((ulong)0x00004000UL),

    [NativeName("VK_BUFFER_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2VideoEncodeDstBitKHR = unchecked((ulong)0x00008000UL),

    [NativeName("VK_BUFFER_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2VideoEncodeSrcBitKHR = unchecked((ulong)0x00010000UL),

    [NativeName("VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2ShaderDeviceAddressBitKHR = unchecked((ulong)0x00020000UL),

    [NativeName("VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2AccelerationStructureBuildInputReadOnlyBitKHR = unchecked((ulong)0x00080000UL),

    [NativeName("VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkBufferUsage2AccelerationStructureStorageBitKHR = unchecked((ulong)0x00100000UL),

    [NativeName("VK_BUFFER_USAGE_2_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkBufferUsage2SamplerDescriptorBufferBitEXT = unchecked((ulong)0x00200000UL),

    [NativeName("VK_BUFFER_USAGE_2_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkBufferUsage2ResourceDescriptorBufferBitEXT = unchecked((ulong)0x00400000UL),

    [NativeName("VK_BUFFER_USAGE_2_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkBufferUsage2PushDescriptorsDescriptorBufferBitEXT = unchecked((ulong)0x04000000UL),

    [NativeName("VK_BUFFER_USAGE_2_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkBufferUsage2MicromapBuildInputReadOnlyBitEXT = unchecked((ulong)0x00800000UL),

    [NativeName("VK_BUFFER_USAGE_2_MICROMAP_STORAGE_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkBufferUsage2MicromapStorageBitEXT = unchecked((ulong)0x01000000UL),

    [NativeName("VK_BUFFER_USAGE_2_DATA_GRAPH_FOREIGN_DESCRIPTOR_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    VkBufferUsage2DataGraphForeignDescriptorBitARM = unchecked((ulong)0x20000000UL),

    [NativeName("VK_BUFFER_USAGE_2_TILE_MEMORY_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    VkBufferUsage2TileMemoryBitQCOM = unchecked((ulong)0x08000000UL),

    [NativeName("VK_BUFFER_USAGE_2_MEMORY_DECOMPRESSION_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkBufferUsage2MemoryDecompressionBitEXT = unchecked((ulong)0x100000000UL),

    [NativeName("VK_BUFFER_USAGE_2_PREPROCESS_BUFFER_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkBufferUsage2PreprocessBufferBitEXT = unchecked((ulong)0x80000000UL),
}
