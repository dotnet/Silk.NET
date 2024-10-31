// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkBufferUsageFlags2KHR")]
    public enum BufferUsageFlags2KHR : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TransferSrcBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT_KHR")]
        BufferUsage2TransferSrcBitKhr = 1,
        [Obsolete("Deprecated in favour of \"TransferDstBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_DST_BIT_KHR")]
        BufferUsage2TransferDstBitKhr = 2,
        [Obsolete("Deprecated in favour of \"UniformTexelBufferBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR")]
        BufferUsage2UniformTexelBufferBitKhr = 4,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT_KHR")]
        BufferUsage2StorageTexelBufferBitKhr = 8,
        [Obsolete("Deprecated in favour of \"UniformBufferBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT_KHR")]
        BufferUsage2UniformBufferBitKhr = 16,
        [Obsolete("Deprecated in favour of \"StorageBufferBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT_KHR")]
        BufferUsage2StorageBufferBitKhr = 32,
        [Obsolete("Deprecated in favour of \"IndexBufferBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT_KHR")]
        BufferUsage2IndexBufferBitKhr = 64,
        [Obsolete("Deprecated in favour of \"VertexBufferBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT_KHR")]
        BufferUsage2VertexBufferBitKhr = 128,
        [Obsolete("Deprecated in favour of \"IndirectBufferBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT_KHR")]
        BufferUsage2IndirectBufferBitKhr = 256,
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
        [Obsolete("Deprecated in favour of \"PreprocessBufferBitExt\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_PREPROCESS_BUFFER_BIT_EXT")]
        BufferUsage2PreprocessBufferBitExt = 2147483648,
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT_KHR")]
        TransferSrcBitKhr = 1,
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_DST_BIT_KHR")]
        TransferDstBitKhr = 2,
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR")]
        UniformTexelBufferBitKhr = 4,
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT_KHR")]
        StorageTexelBufferBitKhr = 8,
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT_KHR")]
        UniformBufferBitKhr = 16,
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT_KHR")]
        StorageBufferBitKhr = 32,
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT_KHR")]
        IndexBufferBitKhr = 64,
        [NativeName("Name", "VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT_KHR")]
        VertexBufferBitKhr = 128,
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT_KHR")]
        IndirectBufferBitKhr = 256,
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
        [NativeName("Name", "VK_BUFFER_USAGE_2_PREPROCESS_BUFFER_BIT_EXT")]
        PreprocessBufferBitExt = 2147483648,
    }
}
