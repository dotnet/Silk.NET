// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkBufferUsageFlags")]
    public enum BufferUsageFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TransferSrcBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFER_SRC_BIT")]
        BufferUsageTransferSrcBit = 1,
        [Obsolete("Deprecated in favour of \"TransferDstBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFER_DST_BIT")]
        BufferUsageTransferDstBit = 2,
        [Obsolete("Deprecated in favour of \"UniformTexelBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT")]
        BufferUsageUniformTexelBufferBit = 4,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT")]
        BufferUsageStorageTexelBufferBit = 8,
        [Obsolete("Deprecated in favour of \"UniformBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT")]
        BufferUsageUniformBufferBit = 16,
        [Obsolete("Deprecated in favour of \"StorageBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_STORAGE_BUFFER_BIT")]
        BufferUsageStorageBufferBit = 32,
        [Obsolete("Deprecated in favour of \"IndexBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_INDEX_BUFFER_BIT")]
        BufferUsageIndexBufferBit = 64,
        [Obsolete("Deprecated in favour of \"VertexBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_VERTEX_BUFFER_BIT")]
        BufferUsageVertexBufferBit = 128,
        [Obsolete("Deprecated in favour of \"IndirectBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT")]
        BufferUsageIndirectBufferBit = 256,
        [Obsolete("Deprecated in favour of \"VideoDecodeSrcBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_VIDEO_DECODE_SRC_BIT_KHR")]
        BufferUsageVideoDecodeSrcBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"VideoDecodeDstBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_VIDEO_DECODE_DST_BIT_KHR")]
        BufferUsageVideoDecodeDstBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"TransformFeedbackBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT")]
        BufferUsageTransformFeedbackBufferBitExt = 2048,
        [Obsolete("Deprecated in favour of \"TransformFeedbackCounterBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT")]
        BufferUsageTransformFeedbackCounterBufferBitExt = 4096,
        [Obsolete("Deprecated in favour of \"ConditionalRenderingBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT")]
        BufferUsageConditionalRenderingBitExt = 512,
        [Obsolete("Deprecated in favour of \"ExecutionGraphScratchBitAmdx\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_EXECUTION_GRAPH_SCRATCH_BIT_AMDX")]
        BufferUsageExecutionGraphScratchBitAmdx = 33554432,
        [Obsolete("Deprecated in favour of \"AccelerationStructureBuildInputReadOnlyBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR")]
        BufferUsageAccelerationStructureBuildInputReadOnlyBitKhr = 524288,
        [Obsolete("Deprecated in favour of \"AccelerationStructureStorageBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR")]
        BufferUsageAccelerationStructureStorageBitKhr = 1048576,
        [Obsolete("Deprecated in favour of \"ShaderBindingTableBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR")]
        BufferUsageShaderBindingTableBitKhr = 1024,
        [Obsolete("Deprecated in favour of \"RayTracingBitNV\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_RAY_TRACING_BIT_NV")]
        BufferUsageRayTracingBitNV = 1024,
        [Obsolete("Deprecated in favour of \"ShaderDeviceAddressBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_EXT")]
        BufferUsageShaderDeviceAddressBitExt = 131072,
        [Obsolete("Deprecated in favour of \"ShaderDeviceAddressBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_KHR")]
        BufferUsageShaderDeviceAddressBitKhr = 131072,
        [Obsolete("Deprecated in favour of \"VideoEncodeDstBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_VIDEO_ENCODE_DST_BIT_KHR")]
        BufferUsageVideoEncodeDstBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"VideoEncodeSrcBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_VIDEO_ENCODE_SRC_BIT_KHR")]
        BufferUsageVideoEncodeSrcBitKhr = 65536,
        [Obsolete("Deprecated in favour of \"SamplerDescriptorBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT")]
        BufferUsageSamplerDescriptorBufferBitExt = 2097152,
        [Obsolete("Deprecated in favour of \"ResourceDescriptorBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT")]
        BufferUsageResourceDescriptorBufferBitExt = 4194304,
        [Obsolete("Deprecated in favour of \"PushDescriptorsDescriptorBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT")]
        BufferUsagePushDescriptorsDescriptorBufferBitExt = 67108864,
        [Obsolete("Deprecated in favour of \"MicromapBuildInputReadOnlyBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT")]
        BufferUsageMicromapBuildInputReadOnlyBitExt = 8388608,
        [Obsolete("Deprecated in favour of \"MicromapStorageBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_MICROMAP_STORAGE_BIT_EXT")]
        BufferUsageMicromapStorageBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"ShaderDeviceAddressBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT")]
        BufferUsageShaderDeviceAddressBit = 131072,
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFER_SRC_BIT")]
        TransferSrcBit = 1,
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFER_DST_BIT")]
        TransferDstBit = 2,
        [NativeName("Name", "VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT")]
        UniformTexelBufferBit = 4,
        [NativeName("Name", "VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT")]
        StorageTexelBufferBit = 8,
        [NativeName("Name", "VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT")]
        UniformBufferBit = 16,
        [NativeName("Name", "VK_BUFFER_USAGE_STORAGE_BUFFER_BIT")]
        StorageBufferBit = 32,
        [NativeName("Name", "VK_BUFFER_USAGE_INDEX_BUFFER_BIT")]
        IndexBufferBit = 64,
        [NativeName("Name", "VK_BUFFER_USAGE_VERTEX_BUFFER_BIT")]
        VertexBufferBit = 128,
        [NativeName("Name", "VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT")]
        IndirectBufferBit = 256,
        [NativeName("Name", "VK_BUFFER_USAGE_VIDEO_DECODE_SRC_BIT_KHR")]
        VideoDecodeSrcBitKhr = 8192,
        [NativeName("Name", "VK_BUFFER_USAGE_VIDEO_DECODE_DST_BIT_KHR")]
        VideoDecodeDstBitKhr = 16384,
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT")]
        TransformFeedbackBufferBitExt = 2048,
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT")]
        TransformFeedbackCounterBufferBitExt = 4096,
        [NativeName("Name", "VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT")]
        ConditionalRenderingBitExt = 512,
        [NativeName("Name", "VK_BUFFER_USAGE_EXECUTION_GRAPH_SCRATCH_BIT_AMDX")]
        ExecutionGraphScratchBitAmdx = 33554432,
        [NativeName("Name", "VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR")]
        AccelerationStructureBuildInputReadOnlyBitKhr = 524288,
        [NativeName("Name", "VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR")]
        AccelerationStructureStorageBitKhr = 1048576,
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR")]
        ShaderBindingTableBitKhr = 1024,
        [NativeName("Name", "VK_BUFFER_USAGE_RAY_TRACING_BIT_NV")]
        RayTracingBitNV = 1024,
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_EXT")]
        ShaderDeviceAddressBitExt = 131072,
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_KHR")]
        ShaderDeviceAddressBitKhr = 131072,
        [NativeName("Name", "VK_BUFFER_USAGE_VIDEO_ENCODE_DST_BIT_KHR")]
        VideoEncodeDstBitKhr = 32768,
        [NativeName("Name", "VK_BUFFER_USAGE_VIDEO_ENCODE_SRC_BIT_KHR")]
        VideoEncodeSrcBitKhr = 65536,
        [NativeName("Name", "VK_BUFFER_USAGE_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT")]
        SamplerDescriptorBufferBitExt = 2097152,
        [NativeName("Name", "VK_BUFFER_USAGE_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT")]
        ResourceDescriptorBufferBitExt = 4194304,
        [NativeName("Name", "VK_BUFFER_USAGE_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT")]
        PushDescriptorsDescriptorBufferBitExt = 67108864,
        [NativeName("Name", "VK_BUFFER_USAGE_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT")]
        MicromapBuildInputReadOnlyBitExt = 8388608,
        [NativeName("Name", "VK_BUFFER_USAGE_MICROMAP_STORAGE_BIT_EXT")]
        MicromapStorageBitExt = 16777216,
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT")]
        ShaderDeviceAddressBit = 131072,
    }
}
