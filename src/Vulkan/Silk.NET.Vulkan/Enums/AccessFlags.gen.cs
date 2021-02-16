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
    [NativeName("Name", "VkAccessFlags")]
    public enum AccessFlags : int
    {
        [NativeName("Name", "VK_ACCESS_INDIRECT_COMMAND_READ_BIT")]
        AccessIndirectCommandReadBit = 1,
        [NativeName("Name", "VK_ACCESS_INDEX_READ_BIT")]
        AccessIndexReadBit = 2,
        [NativeName("Name", "VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT")]
        AccessVertexAttributeReadBit = 4,
        [NativeName("Name", "VK_ACCESS_UNIFORM_READ_BIT")]
        AccessUniformReadBit = 8,
        [NativeName("Name", "VK_ACCESS_INPUT_ATTACHMENT_READ_BIT")]
        AccessInputAttachmentReadBit = 16,
        [NativeName("Name", "VK_ACCESS_SHADER_READ_BIT")]
        AccessShaderReadBit = 32,
        [NativeName("Name", "VK_ACCESS_SHADER_WRITE_BIT")]
        AccessShaderWriteBit = 64,
        [NativeName("Name", "VK_ACCESS_COLOR_ATTACHMENT_READ_BIT")]
        AccessColorAttachmentReadBit = 128,
        [NativeName("Name", "VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT")]
        AccessColorAttachmentWriteBit = 256,
        [NativeName("Name", "VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
        AccessDepthStencilAttachmentReadBit = 512,
        [NativeName("Name", "VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
        AccessDepthStencilAttachmentWriteBit = 1024,
        [NativeName("Name", "VK_ACCESS_TRANSFER_READ_BIT")]
        AccessTransferReadBit = 2048,
        [NativeName("Name", "VK_ACCESS_TRANSFER_WRITE_BIT")]
        AccessTransferWriteBit = 4096,
        [NativeName("Name", "VK_ACCESS_HOST_READ_BIT")]
        AccessHostReadBit = 8192,
        [NativeName("Name", "VK_ACCESS_HOST_WRITE_BIT")]
        AccessHostWriteBit = 16384,
        [NativeName("Name", "VK_ACCESS_MEMORY_READ_BIT")]
        AccessMemoryReadBit = 32768,
        [NativeName("Name", "VK_ACCESS_MEMORY_WRITE_BIT")]
        AccessMemoryWriteBit = 65536,
        [NativeName("Name", "VK_ACCESS_RESERVED_30_BIT_KHR")]
        AccessReserved30BitKhr = 1073741824,
        [NativeName("Name", "VK_ACCESS_RESERVED_28_BIT_KHR")]
        AccessReserved28BitKhr = 268435456,
        [NativeName("Name", "VK_ACCESS_RESERVED_29_BIT_KHR")]
        AccessReserved29BitKhr = 536870912,
        [NativeName("Name", "VK_ACCESS_TRANSFORM_FEEDBACK_WRITE_BIT_EXT")]
        AccessTransformFeedbackWriteBitExt = 33554432,
        [NativeName("Name", "VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT")]
        AccessTransformFeedbackCounterReadBitExt = 67108864,
        [NativeName("Name", "VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT")]
        AccessTransformFeedbackCounterWriteBitExt = 134217728,
        [NativeName("Name", "VK_ACCESS_CONDITIONAL_RENDERING_READ_BIT_EXT")]
        AccessConditionalRenderingReadBitExt = 1048576,
        [NativeName("Name", "VK_ACCESS_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT")]
        AccessColorAttachmentReadNoncoherentBitExt = 524288,
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_KHR")]
        AccessAccelerationStructureReadBitKhr = 2097152,
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_KHR")]
        AccessAccelerationStructureWriteBitKhr = 4194304,
        [NativeName("Name", "VK_ACCESS_SHADING_RATE_IMAGE_READ_BIT_NV")]
        AccessShadingRateImageReadBitNV = 8388608,
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_NV")]
        AccessAccelerationStructureReadBitNV = 2097152,
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_NV")]
        AccessAccelerationStructureWriteBitNV = 4194304,
        [NativeName("Name", "VK_ACCESS_FRAGMENT_DENSITY_MAP_READ_BIT_EXT")]
        AccessFragmentDensityMapReadBitExt = 16777216,
        [NativeName("Name", "VK_ACCESS_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR")]
        AccessFragmentShadingRateAttachmentReadBitKhr = 8388608,
        [NativeName("Name", "VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_NV")]
        AccessCommandPreprocessReadBitNV = 131072,
        [NativeName("Name", "VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_NV")]
        AccessCommandPreprocessWriteBitNV = 262144,
    }
}
