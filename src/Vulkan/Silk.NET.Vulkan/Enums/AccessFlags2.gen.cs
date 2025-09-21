// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAccessFlags2")]
    public enum AccessFlags2 : long
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "VK_ACCESS_2_NONE")]
        Access2None = 0,
        [Obsolete("Deprecated in favour of \"IndirectCommandReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT")]
        Access2IndirectCommandReadBit = 1,
        [Obsolete("Deprecated in favour of \"IndexReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_INDEX_READ_BIT")]
        Access2IndexReadBit = 2,
        [Obsolete("Deprecated in favour of \"VertexAttributeReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT")]
        Access2VertexAttributeReadBit = 4,
        [Obsolete("Deprecated in favour of \"UniformReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_UNIFORM_READ_BIT")]
        Access2UniformReadBit = 8,
        [Obsolete("Deprecated in favour of \"InputAttachmentReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT")]
        Access2InputAttachmentReadBit = 16,
        [Obsolete("Deprecated in favour of \"ShaderReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_READ_BIT")]
        Access2ShaderReadBit = 32,
        [Obsolete("Deprecated in favour of \"ShaderWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_WRITE_BIT")]
        Access2ShaderWriteBit = 64,
        [Obsolete("Deprecated in favour of \"ColorAttachmentReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT")]
        Access2ColorAttachmentReadBit = 128,
        [Obsolete("Deprecated in favour of \"ColorAttachmentWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT")]
        Access2ColorAttachmentWriteBit = 256,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
        Access2DepthStencilAttachmentReadBit = 512,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
        Access2DepthStencilAttachmentWriteBit = 1024,
        [Obsolete("Deprecated in favour of \"TransferReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_READ_BIT")]
        Access2TransferReadBit = 2048,
        [Obsolete("Deprecated in favour of \"TransferWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_WRITE_BIT")]
        Access2TransferWriteBit = 4096,
        [Obsolete("Deprecated in favour of \"HostReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_HOST_READ_BIT")]
        Access2HostReadBit = 8192,
        [Obsolete("Deprecated in favour of \"HostWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_HOST_WRITE_BIT")]
        Access2HostWriteBit = 16384,
        [Obsolete("Deprecated in favour of \"MemoryReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_MEMORY_READ_BIT")]
        Access2MemoryReadBit = 32768,
        [Obsolete("Deprecated in favour of \"MemoryWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_MEMORY_WRITE_BIT")]
        Access2MemoryWriteBit = 65536,
        [Obsolete("Deprecated in favour of \"ShaderSampledReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_SAMPLED_READ_BIT")]
        Access2ShaderSampledReadBit = 4294967296,
        [Obsolete("Deprecated in favour of \"ShaderStorageReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_READ_BIT")]
        Access2ShaderStorageReadBit = 8589934592,
        [Obsolete("Deprecated in favour of \"ShaderStorageWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT")]
        Access2ShaderStorageWriteBit = 17179869184,
        [Obsolete("Deprecated in favour of \"VideoDecodeReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR")]
        Access2VideoDecodeReadBitKhr = 34359738368,
        [Obsolete("Deprecated in favour of \"VideoDecodeWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR")]
        Access2VideoDecodeWriteBitKhr = 68719476736,
        [Obsolete("Deprecated in favour of \"VideoEncodeReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR")]
        Access2VideoEncodeReadBitKhr = 137438953472,
        [Obsolete("Deprecated in favour of \"VideoEncodeWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR")]
        Access2VideoEncodeWriteBitKhr = 274877906944,
        [Obsolete("Deprecated in favour of \"ShaderTileAttachmentReadBitQCom\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_TILE_ATTACHMENT_READ_BIT_QCOM")]
        Access2ShaderTileAttachmentReadBitQCom = 2251799813685248,
        [Obsolete("Deprecated in favour of \"ShaderTileAttachmentWriteBitQCom\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_TILE_ATTACHMENT_WRITE_BIT_QCOM")]
        Access2ShaderTileAttachmentWriteBitQCom = 4503599627370496,
        [Obsolete("Deprecated in favour of \"TransformFeedbackWriteBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT")]
        Access2TransformFeedbackWriteBitExt = 33554432,
        [Obsolete("Deprecated in favour of \"TransformFeedbackCounterReadBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT")]
        Access2TransformFeedbackCounterReadBitExt = 67108864,
        [Obsolete("Deprecated in favour of \"TransformFeedbackCounterWriteBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT")]
        Access2TransformFeedbackCounterWriteBitExt = 134217728,
        [Obsolete("Deprecated in favour of \"ConditionalRenderingReadBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT")]
        Access2ConditionalRenderingReadBitExt = 1048576,
        [Obsolete("Deprecated in favour of \"CommandPreprocessReadBitNV\"")]
        [NativeName("Name", "VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV")]
        Access2CommandPreprocessReadBitNV = 131072,
        [Obsolete("Deprecated in favour of \"CommandPreprocessWriteBitNV\"")]
        [NativeName("Name", "VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV")]
        Access2CommandPreprocessWriteBitNV = 262144,
        [Obsolete("Deprecated in favour of \"CommandPreprocessReadBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_EXT")]
        Access2CommandPreprocessReadBitExt = 131072,
        [Obsolete("Deprecated in favour of \"CommandPreprocessWriteBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_EXT")]
        Access2CommandPreprocessWriteBitExt = 262144,
        [Obsolete("Deprecated in favour of \"FragmentShadingRateAttachmentReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR")]
        Access2FragmentShadingRateAttachmentReadBitKhr = 8388608,
        [Obsolete("Deprecated in favour of \"ShadingRateImageReadBitNV\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV")]
        Access2ShadingRateImageReadBitNV = 8388608,
        [Obsolete("Deprecated in favour of \"AccelerationStructureReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR")]
        Access2AccelerationStructureReadBitKhr = 2097152,
        [Obsolete("Deprecated in favour of \"AccelerationStructureWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR")]
        Access2AccelerationStructureWriteBitKhr = 4194304,
        [Obsolete("Deprecated in favour of \"AccelerationStructureReadBitNV\"")]
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV")]
        Access2AccelerationStructureReadBitNV = 2097152,
        [Obsolete("Deprecated in favour of \"AccelerationStructureWriteBitNV\"")]
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV")]
        Access2AccelerationStructureWriteBitNV = 4194304,
        [Obsolete("Deprecated in favour of \"FragmentDensityMapReadBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT")]
        Access2FragmentDensityMapReadBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"ColorAttachmentReadNoncoherentBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT")]
        Access2ColorAttachmentReadNoncoherentBitExt = 524288,
        [Obsolete("Deprecated in favour of \"DescriptorBufferReadBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_DESCRIPTOR_BUFFER_READ_BIT_EXT")]
        Access2DescriptorBufferReadBitExt = 2199023255552,
        [Obsolete("Deprecated in favour of \"InvocationMaskReadBitHuawei\"")]
        [NativeName("Name", "VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI")]
        Access2InvocationMaskReadBitHuawei = 549755813888,
        [Obsolete("Deprecated in favour of \"ShaderBindingTableReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_BINDING_TABLE_READ_BIT_KHR")]
        Access2ShaderBindingTableReadBitKhr = 1099511627776,
        [Obsolete("Deprecated in favour of \"MicromapReadBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_MICROMAP_READ_BIT_EXT")]
        Access2MicromapReadBitExt = 17592186044416,
        [Obsolete("Deprecated in favour of \"MicromapWriteBitExt\"")]
        [NativeName("Name", "VK_ACCESS_2_MICROMAP_WRITE_BIT_EXT")]
        Access2MicromapWriteBitExt = 35184372088832,
        [Obsolete("Deprecated in favour of \"OpticalFlowReadBitNV\"")]
        [NativeName("Name", "VK_ACCESS_2_OPTICAL_FLOW_READ_BIT_NV")]
        Access2OpticalFlowReadBitNV = 4398046511104,
        [Obsolete("Deprecated in favour of \"OpticalFlowWriteBitNV\"")]
        [NativeName("Name", "VK_ACCESS_2_OPTICAL_FLOW_WRITE_BIT_NV")]
        Access2OpticalFlowWriteBitNV = 8796093022208,
        [Obsolete("Deprecated in favour of \"DataGraphReadBitArm\"")]
        [NativeName("Name", "VK_ACCESS_2_DATA_GRAPH_READ_BIT_ARM")]
        Access2DataGraphReadBitArm = 140737488355328,
        [Obsolete("Deprecated in favour of \"DataGraphWriteBitArm\"")]
        [NativeName("Name", "VK_ACCESS_2_DATA_GRAPH_WRITE_BIT_ARM")]
        Access2DataGraphWriteBitArm = 281474976710656,
        [NativeName("Name", "VK_ACCESS_2_NONE")]
        None = 0,
        [NativeName("Name", "VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT")]
        IndirectCommandReadBit = 1,
        [NativeName("Name", "VK_ACCESS_2_INDEX_READ_BIT")]
        IndexReadBit = 2,
        [NativeName("Name", "VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT")]
        VertexAttributeReadBit = 4,
        [NativeName("Name", "VK_ACCESS_2_UNIFORM_READ_BIT")]
        UniformReadBit = 8,
        [NativeName("Name", "VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT")]
        InputAttachmentReadBit = 16,
        [NativeName("Name", "VK_ACCESS_2_SHADER_READ_BIT")]
        ShaderReadBit = 32,
        [NativeName("Name", "VK_ACCESS_2_SHADER_WRITE_BIT")]
        ShaderWriteBit = 64,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT")]
        ColorAttachmentReadBit = 128,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT")]
        ColorAttachmentWriteBit = 256,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
        DepthStencilAttachmentReadBit = 512,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
        DepthStencilAttachmentWriteBit = 1024,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_READ_BIT")]
        TransferReadBit = 2048,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_WRITE_BIT")]
        TransferWriteBit = 4096,
        [NativeName("Name", "VK_ACCESS_2_HOST_READ_BIT")]
        HostReadBit = 8192,
        [NativeName("Name", "VK_ACCESS_2_HOST_WRITE_BIT")]
        HostWriteBit = 16384,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_READ_BIT")]
        MemoryReadBit = 32768,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_WRITE_BIT")]
        MemoryWriteBit = 65536,
        [NativeName("Name", "VK_ACCESS_2_SHADER_SAMPLED_READ_BIT")]
        ShaderSampledReadBit = 4294967296,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_READ_BIT")]
        ShaderStorageReadBit = 8589934592,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT")]
        ShaderStorageWriteBit = 17179869184,
        [NativeName("Name", "VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR")]
        VideoDecodeReadBitKhr = 34359738368,
        [NativeName("Name", "VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR")]
        VideoDecodeWriteBitKhr = 68719476736,
        [NativeName("Name", "VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR")]
        VideoEncodeReadBitKhr = 137438953472,
        [NativeName("Name", "VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR")]
        VideoEncodeWriteBitKhr = 274877906944,
        [NativeName("Name", "VK_ACCESS_2_SHADER_TILE_ATTACHMENT_READ_BIT_QCOM")]
        ShaderTileAttachmentReadBitQCom = 2251799813685248,
        [NativeName("Name", "VK_ACCESS_2_SHADER_TILE_ATTACHMENT_WRITE_BIT_QCOM")]
        ShaderTileAttachmentWriteBitQCom = 4503599627370496,
        [NativeName("Name", "VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT")]
        TransformFeedbackWriteBitExt = 33554432,
        [NativeName("Name", "VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT")]
        TransformFeedbackCounterReadBitExt = 67108864,
        [NativeName("Name", "VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT")]
        TransformFeedbackCounterWriteBitExt = 134217728,
        [NativeName("Name", "VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT")]
        ConditionalRenderingReadBitExt = 1048576,
        [NativeName("Name", "VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV")]
        CommandPreprocessReadBitNV = 131072,
        [NativeName("Name", "VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV")]
        CommandPreprocessWriteBitNV = 262144,
        [NativeName("Name", "VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_EXT")]
        CommandPreprocessReadBitExt = 131072,
        [NativeName("Name", "VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_EXT")]
        CommandPreprocessWriteBitExt = 262144,
        [NativeName("Name", "VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR")]
        FragmentShadingRateAttachmentReadBitKhr = 8388608,
        [NativeName("Name", "VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV")]
        ShadingRateImageReadBitNV = 8388608,
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR")]
        AccelerationStructureReadBitKhr = 2097152,
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR")]
        AccelerationStructureWriteBitKhr = 4194304,
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV")]
        AccelerationStructureReadBitNV = 2097152,
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV")]
        AccelerationStructureWriteBitNV = 4194304,
        [NativeName("Name", "VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT")]
        FragmentDensityMapReadBitExt = 16777216,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT")]
        ColorAttachmentReadNoncoherentBitExt = 524288,
        [NativeName("Name", "VK_ACCESS_2_DESCRIPTOR_BUFFER_READ_BIT_EXT")]
        DescriptorBufferReadBitExt = 2199023255552,
        [NativeName("Name", "VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI")]
        InvocationMaskReadBitHuawei = 549755813888,
        [NativeName("Name", "VK_ACCESS_2_SHADER_BINDING_TABLE_READ_BIT_KHR")]
        ShaderBindingTableReadBitKhr = 1099511627776,
        [NativeName("Name", "VK_ACCESS_2_MICROMAP_READ_BIT_EXT")]
        MicromapReadBitExt = 17592186044416,
        [NativeName("Name", "VK_ACCESS_2_MICROMAP_WRITE_BIT_EXT")]
        MicromapWriteBitExt = 35184372088832,
        [NativeName("Name", "VK_ACCESS_2_OPTICAL_FLOW_READ_BIT_NV")]
        OpticalFlowReadBitNV = 4398046511104,
        [NativeName("Name", "VK_ACCESS_2_OPTICAL_FLOW_WRITE_BIT_NV")]
        OpticalFlowWriteBitNV = 8796093022208,
        [NativeName("Name", "VK_ACCESS_2_DATA_GRAPH_READ_BIT_ARM")]
        DataGraphReadBitArm = 140737488355328,
        [NativeName("Name", "VK_ACCESS_2_DATA_GRAPH_WRITE_BIT_ARM")]
        DataGraphWriteBitArm = 281474976710656,
    }
}
