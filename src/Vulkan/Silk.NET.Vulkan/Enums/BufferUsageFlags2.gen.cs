// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkBufferUsageFlags2")]
    public enum BufferUsageFlags2 : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TransferSrcBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT")]
        BufferUsage2TransferSrcBit = 1,
        [Obsolete("Deprecated in favour of \"TransferDstBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_DST_BIT")]
        BufferUsage2TransferDstBit = 2,
        [Obsolete("Deprecated in favour of \"UniformTexelBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT")]
        BufferUsage2UniformTexelBufferBit = 4,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT")]
        BufferUsage2StorageTexelBufferBit = 8,
        [Obsolete("Deprecated in favour of \"UniformBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT")]
        BufferUsage2UniformBufferBit = 16,
        [Obsolete("Deprecated in favour of \"StorageBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT")]
        BufferUsage2StorageBufferBit = 32,
        [Obsolete("Deprecated in favour of \"IndexBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT")]
        BufferUsage2IndexBufferBit = 64,
        [Obsolete("Deprecated in favour of \"VertexBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT")]
        BufferUsage2VertexBufferBit = 128,
        [Obsolete("Deprecated in favour of \"IndirectBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT")]
        BufferUsage2IndirectBufferBit = 256,
        [Obsolete("Deprecated in favour of \"ExecutionGraphScratchBitAmdx\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_EXECUTION_GRAPH_SCRATCH_BIT_AMDX")]
        BufferUsage2ExecutionGraphScratchBitAmdx = 33554432,
        [Obsolete("Deprecated in favour of \"ConditionalRenderingBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_CONDITIONAL_RENDERING_BIT_EXT")]
        BufferUsage2ConditionalRenderingBitExt = 512,
        [Obsolete("Deprecated in favour of \"ShaderBindingTableBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR")]
        BufferUsage2ShaderBindingTableBitKhr = 1024,
        [Obsolete("Deprecated in favour of \"RayTracingBitNV\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_RAY_TRACING_BIT_NV")]
        BufferUsage2RayTracingBitNV = 1024,
        [Obsolete("Deprecated in favour of \"TransformFeedbackBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT")]
        BufferUsage2TransformFeedbackBufferBitExt = 2048,
        [Obsolete("Deprecated in favour of \"TransformFeedbackCounterBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT")]
        BufferUsage2TransformFeedbackCounterBufferBitExt = 4096,
        [Obsolete("Deprecated in favour of \"VideoDecodeSrcBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR")]
        BufferUsage2VideoDecodeSrcBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"VideoDecodeDstBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_VIDEO_DECODE_DST_BIT_KHR")]
        BufferUsage2VideoDecodeDstBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"VideoEncodeDstBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR")]
        BufferUsage2VideoEncodeDstBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"VideoEncodeSrcBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR")]
        BufferUsage2VideoEncodeSrcBitKhr = 65536,
        [Obsolete("Deprecated in favour of \"ShaderDeviceAddressBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT_KHR")]
        BufferUsage2ShaderDeviceAddressBitKhr = 131072,
        [Obsolete("Deprecated in favour of \"AccelerationStructureBuildInputReadOnlyBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR")]
        BufferUsage2AccelerationStructureBuildInputReadOnlyBitKhr = 524288,
        [Obsolete("Deprecated in favour of \"AccelerationStructureStorageBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR")]
        BufferUsage2AccelerationStructureStorageBitKhr = 1048576,
        [Obsolete("Deprecated in favour of \"SamplerDescriptorBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT")]
        BufferUsage2SamplerDescriptorBufferBitExt = 2097152,
        [Obsolete("Deprecated in favour of \"ResourceDescriptorBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT")]
        BufferUsage2ResourceDescriptorBufferBitExt = 4194304,
        [Obsolete("Deprecated in favour of \"PushDescriptorsDescriptorBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT")]
        BufferUsage2PushDescriptorsDescriptorBufferBitExt = 67108864,
        [Obsolete("Deprecated in favour of \"MicromapBuildInputReadOnlyBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT")]
        BufferUsage2MicromapBuildInputReadOnlyBitExt = 8388608,
        [Obsolete("Deprecated in favour of \"MicromapStorageBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_MICROMAP_STORAGE_BIT_EXT")]
        BufferUsage2MicromapStorageBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"CompressedDataDgf1BitAmdx\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_COMPRESSED_DATA_DGF1_BIT_AMDX")]
        BufferUsage2CompressedDataDgf1BitAmdx = 8589934592,
        [Obsolete("Deprecated in favour of \"DataGraphForeignDescriptorBitArm\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_DATA_GRAPH_FOREIGN_DESCRIPTOR_BIT_ARM")]
        BufferUsage2DataGraphForeignDescriptorBitArm = 536870912,
        [Obsolete("Deprecated in favour of \"TileMemoryBitQCom\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_TILE_MEMORY_BIT_QCOM")]
        BufferUsage2TileMemoryBitQCom = 134217728,
        [Obsolete("Deprecated in favour of \"PreprocessBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_PREPROCESS_BUFFER_BIT_EXT")]
        BufferUsage2PreprocessBufferBitExt = 2147483648,
        [Obsolete("Deprecated in favour of \"ShaderDeviceAddressBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT")]
        BufferUsage2ShaderDeviceAddressBit = 131072,
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT")]
        TransferSrcBit = 1,
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_DST_BIT")]
        TransferDstBit = 2,
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT")]
        UniformTexelBufferBit = 4,
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT")]
        StorageTexelBufferBit = 8,
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT")]
        UniformBufferBit = 16,
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT")]
        StorageBufferBit = 32,
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT")]
        IndexBufferBit = 64,
        [NativeName("Name", "VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT")]
        VertexBufferBit = 128,
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT")]
        IndirectBufferBit = 256,
        [NativeName("Name", "VK_BUFFER_USAGE_2_EXECUTION_GRAPH_SCRATCH_BIT_AMDX")]
        ExecutionGraphScratchBitAmdx = 33554432,
        [NativeName("Name", "VK_BUFFER_USAGE_2_CONDITIONAL_RENDERING_BIT_EXT")]
        ConditionalRenderingBitExt = 512,
        [NativeName("Name", "VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR")]
        ShaderBindingTableBitKhr = 1024,
        [NativeName("Name", "VK_BUFFER_USAGE_2_RAY_TRACING_BIT_NV")]
        RayTracingBitNV = 1024,
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT")]
        TransformFeedbackBufferBitExt = 2048,
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT")]
        TransformFeedbackCounterBufferBitExt = 4096,
        [NativeName("Name", "VK_BUFFER_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR")]
        VideoDecodeSrcBitKhr = 8192,
        [NativeName("Name", "VK_BUFFER_USAGE_2_VIDEO_DECODE_DST_BIT_KHR")]
        VideoDecodeDstBitKhr = 16384,
        [NativeName("Name", "VK_BUFFER_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR")]
        VideoEncodeDstBitKhr = 32768,
        [NativeName("Name", "VK_BUFFER_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR")]
        VideoEncodeSrcBitKhr = 65536,
        [NativeName("Name", "VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT_KHR")]
        ShaderDeviceAddressBitKhr = 131072,
        [NativeName("Name", "VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR")]
        AccelerationStructureBuildInputReadOnlyBitKhr = 524288,
        [NativeName("Name", "VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR")]
        AccelerationStructureStorageBitKhr = 1048576,
        [NativeName("Name", "VK_BUFFER_USAGE_2_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT")]
        SamplerDescriptorBufferBitExt = 2097152,
        [NativeName("Name", "VK_BUFFER_USAGE_2_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT")]
        ResourceDescriptorBufferBitExt = 4194304,
        [NativeName("Name", "VK_BUFFER_USAGE_2_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT")]
        PushDescriptorsDescriptorBufferBitExt = 67108864,
        [NativeName("Name", "VK_BUFFER_USAGE_2_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT")]
        MicromapBuildInputReadOnlyBitExt = 8388608,
        [NativeName("Name", "VK_BUFFER_USAGE_2_MICROMAP_STORAGE_BIT_EXT")]
        MicromapStorageBitExt = 16777216,
        [NativeName("Name", "VK_BUFFER_USAGE_2_COMPRESSED_DATA_DGF1_BIT_AMDX")]
        CompressedDataDgf1BitAmdx = 8589934592,
        [NativeName("Name", "VK_BUFFER_USAGE_2_DATA_GRAPH_FOREIGN_DESCRIPTOR_BIT_ARM")]
        DataGraphForeignDescriptorBitArm = 536870912,
        [NativeName("Name", "VK_BUFFER_USAGE_2_TILE_MEMORY_BIT_QCOM")]
        TileMemoryBitQCom = 134217728,
        [NativeName("Name", "VK_BUFFER_USAGE_2_PREPROCESS_BUFFER_BIT_EXT")]
        PreprocessBufferBitExt = 2147483648,
        [NativeName("Name", "VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT")]
        ShaderDeviceAddressBit = 131072,
    }
}
