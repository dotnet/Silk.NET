// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkBufferUsageFlags")]
    public enum BufferUsageFlags : int
    {
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFER_SRC_BIT")]
        BufferUsageTransferSrcBit = 1,
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFER_DST_BIT")]
        BufferUsageTransferDstBit = 2,
        [NativeName("Name", "VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT")]
        BufferUsageUniformTexelBufferBit = 4,
        [NativeName("Name", "VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT")]
        BufferUsageStorageTexelBufferBit = 8,
        [NativeName("Name", "VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT")]
        BufferUsageUniformBufferBit = 16,
        [NativeName("Name", "VK_BUFFER_USAGE_STORAGE_BUFFER_BIT")]
        BufferUsageStorageBufferBit = 32,
        [NativeName("Name", "VK_BUFFER_USAGE_INDEX_BUFFER_BIT")]
        BufferUsageIndexBufferBit = 64,
        [NativeName("Name", "VK_BUFFER_USAGE_VERTEX_BUFFER_BIT")]
        BufferUsageVertexBufferBit = 128,
        [NativeName("Name", "VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT")]
        BufferUsageIndirectBufferBit = 256,
        [NativeName("Name", "VK_BUFFER_USAGE_RESERVED_15_BIT_KHR")]
        BufferUsageReserved15BitKhr = 32768,
        [NativeName("Name", "VK_BUFFER_USAGE_RESERVED_16_BIT_KHR")]
        BufferUsageReserved16BitKhr = 65536,
        [NativeName("Name", "VK_BUFFER_USAGE_RESERVED_13_BIT_KHR")]
        BufferUsageReserved13BitKhr = 8192,
        [NativeName("Name", "VK_BUFFER_USAGE_RESERVED_14_BIT_KHR")]
        BufferUsageReserved14BitKhr = 16384,
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT")]
        BufferUsageTransformFeedbackBufferBitExt = 2048,
        [NativeName("Name", "VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT")]
        BufferUsageTransformFeedbackCounterBufferBitExt = 4096,
        [NativeName("Name", "VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT")]
        BufferUsageConditionalRenderingBitExt = 512,
        [NativeName("Name", "VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR")]
        BufferUsageAccelerationStructureBuildInputReadOnlyBitKhr = 524288,
        [NativeName("Name", "VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR")]
        BufferUsageAccelerationStructureStorageBitKhr = 1048576,
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR")]
        BufferUsageShaderBindingTableBitKhr = 1024,
        [NativeName("Name", "VK_BUFFER_USAGE_RAY_TRACING_BIT_NV")]
        BufferUsageRayTracingBitNV = 1024,
        [NativeName("Name", "VK_BUFFER_USAGE_RESERVED_18_BIT_QCOM")]
        BufferUsageReserved18BitQCom = 262144,
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_EXT")]
        BufferUsageShaderDeviceAddressBitExt = 131072,
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_KHR")]
        BufferUsageShaderDeviceAddressBitKhr = 131072,
        [NativeName("Name", "VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT")]
        BufferUsageShaderDeviceAddressBit = 131072,
    }
}
