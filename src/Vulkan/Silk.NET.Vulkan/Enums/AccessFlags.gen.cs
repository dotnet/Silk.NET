// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAccessFlags")]
    public enum AccessFlags : int
    {
        [Obsolete("Deprecated in favour of \"IndirectCommandReadBit\"")]
        [NativeName("Name", "VK_ACCESS_INDIRECT_COMMAND_READ_BIT")]
        AccessIndirectCommandReadBit = 1,
        [Obsolete("Deprecated in favour of \"IndexReadBit\"")]
        [NativeName("Name", "VK_ACCESS_INDEX_READ_BIT")]
        AccessIndexReadBit = 2,
        [Obsolete("Deprecated in favour of \"VertexAttributeReadBit\"")]
        [NativeName("Name", "VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT")]
        AccessVertexAttributeReadBit = 4,
        [Obsolete("Deprecated in favour of \"UniformReadBit\"")]
        [NativeName("Name", "VK_ACCESS_UNIFORM_READ_BIT")]
        AccessUniformReadBit = 8,
        [Obsolete("Deprecated in favour of \"InputAttachmentReadBit\"")]
        [NativeName("Name", "VK_ACCESS_INPUT_ATTACHMENT_READ_BIT")]
        AccessInputAttachmentReadBit = 16,
        [Obsolete("Deprecated in favour of \"ShaderReadBit\"")]
        [NativeName("Name", "VK_ACCESS_SHADER_READ_BIT")]
        AccessShaderReadBit = 32,
        [Obsolete("Deprecated in favour of \"ShaderWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_SHADER_WRITE_BIT")]
        AccessShaderWriteBit = 64,
        [Obsolete("Deprecated in favour of \"ColorAttachmentReadBit\"")]
        [NativeName("Name", "VK_ACCESS_COLOR_ATTACHMENT_READ_BIT")]
        AccessColorAttachmentReadBit = 128,
        [Obsolete("Deprecated in favour of \"ColorAttachmentWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT")]
        AccessColorAttachmentWriteBit = 256,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentReadBit\"")]
        [NativeName("Name", "VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
        AccessDepthStencilAttachmentReadBit = 512,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
        AccessDepthStencilAttachmentWriteBit = 1024,
        [Obsolete("Deprecated in favour of \"TransferReadBit\"")]
        [NativeName("Name", "VK_ACCESS_TRANSFER_READ_BIT")]
        AccessTransferReadBit = 2048,
        [Obsolete("Deprecated in favour of \"TransferWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_TRANSFER_WRITE_BIT")]
        AccessTransferWriteBit = 4096,
        [Obsolete("Deprecated in favour of \"HostReadBit\"")]
        [NativeName("Name", "VK_ACCESS_HOST_READ_BIT")]
        AccessHostReadBit = 8192,
        [Obsolete("Deprecated in favour of \"HostWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_HOST_WRITE_BIT")]
        AccessHostWriteBit = 16384,
        [Obsolete("Deprecated in favour of \"MemoryReadBit\"")]
        [NativeName("Name", "VK_ACCESS_MEMORY_READ_BIT")]
        AccessMemoryReadBit = 32768,
        [Obsolete("Deprecated in favour of \"MemoryWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_MEMORY_WRITE_BIT")]
        AccessMemoryWriteBit = 65536,
        [Obsolete("Deprecated in favour of \"TransformFeedbackWriteBitExt\"")]
        [NativeName("Name", "VK_ACCESS_TRANSFORM_FEEDBACK_WRITE_BIT_EXT")]
        AccessTransformFeedbackWriteBitExt = 33554432,
        [Obsolete("Deprecated in favour of \"TransformFeedbackCounterReadBitExt\"")]
        [NativeName("Name", "VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT")]
        AccessTransformFeedbackCounterReadBitExt = 67108864,
        [Obsolete("Deprecated in favour of \"TransformFeedbackCounterWriteBitExt\"")]
        [NativeName("Name", "VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT")]
        AccessTransformFeedbackCounterWriteBitExt = 134217728,
        [Obsolete("Deprecated in favour of \"ConditionalRenderingReadBitExt\"")]
        [NativeName("Name", "VK_ACCESS_CONDITIONAL_RENDERING_READ_BIT_EXT")]
        AccessConditionalRenderingReadBitExt = 1048576,
        [Obsolete("Deprecated in favour of \"ColorAttachmentReadNoncoherentBitExt\"")]
        [NativeName("Name", "VK_ACCESS_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT")]
        AccessColorAttachmentReadNoncoherentBitExt = 524288,
        [Obsolete("Deprecated in favour of \"AccelerationStructureReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_KHR")]
        AccessAccelerationStructureReadBitKhr = 2097152,
        [Obsolete("Deprecated in favour of \"AccelerationStructureWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_KHR")]
        AccessAccelerationStructureWriteBitKhr = 4194304,
        [Obsolete("Deprecated in favour of \"ShadingRateImageReadBitNV\"")]
        [NativeName("Name", "VK_ACCESS_SHADING_RATE_IMAGE_READ_BIT_NV")]
        AccessShadingRateImageReadBitNV = 8388608,
        [Obsolete("Deprecated in favour of \"AccelerationStructureReadBitNV\"")]
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_NV")]
        AccessAccelerationStructureReadBitNV = 2097152,
        [Obsolete("Deprecated in favour of \"AccelerationStructureWriteBitNV\"")]
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_NV")]
        AccessAccelerationStructureWriteBitNV = 4194304,
        [Obsolete("Deprecated in favour of \"FragmentDensityMapReadBitExt\"")]
        [NativeName("Name", "VK_ACCESS_FRAGMENT_DENSITY_MAP_READ_BIT_EXT")]
        AccessFragmentDensityMapReadBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"FragmentShadingRateAttachmentReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR")]
        AccessFragmentShadingRateAttachmentReadBitKhr = 8388608,
        [Obsolete("Deprecated in favour of \"CommandPreprocessReadBitNV\"")]
        [NativeName("Name", "VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_NV")]
        AccessCommandPreprocessReadBitNV = 131072,
        [Obsolete("Deprecated in favour of \"CommandPreprocessWriteBitNV\"")]
        [NativeName("Name", "VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_NV")]
        AccessCommandPreprocessWriteBitNV = 262144,
        [Obsolete("Deprecated in favour of \"NoneKhr\"")]
        [NativeName("Name", "VK_ACCESS_NONE_KHR")]
        AccessNoneKhr = 0,
        [Obsolete("Deprecated in favour of \"CommandPreprocessReadBitExt\"")]
        [NativeName("Name", "VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_EXT")]
        AccessCommandPreprocessReadBitExt = 131072,
        [Obsolete("Deprecated in favour of \"CommandPreprocessWriteBitExt\"")]
        [NativeName("Name", "VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_EXT")]
        AccessCommandPreprocessWriteBitExt = 262144,
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "VK_ACCESS_NONE")]
        AccessNone = 0,
        [NativeName("Name", "VK_ACCESS_INDIRECT_COMMAND_READ_BIT")]
        IndirectCommandReadBit = 1,
        [NativeName("Name", "VK_ACCESS_INDEX_READ_BIT")]
        IndexReadBit = 2,
        [NativeName("Name", "VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT")]
        VertexAttributeReadBit = 4,
        [NativeName("Name", "VK_ACCESS_UNIFORM_READ_BIT")]
        UniformReadBit = 8,
        [NativeName("Name", "VK_ACCESS_INPUT_ATTACHMENT_READ_BIT")]
        InputAttachmentReadBit = 16,
        [NativeName("Name", "VK_ACCESS_SHADER_READ_BIT")]
        ShaderReadBit = 32,
        [NativeName("Name", "VK_ACCESS_SHADER_WRITE_BIT")]
        ShaderWriteBit = 64,
        [NativeName("Name", "VK_ACCESS_COLOR_ATTACHMENT_READ_BIT")]
        ColorAttachmentReadBit = 128,
        [NativeName("Name", "VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT")]
        ColorAttachmentWriteBit = 256,
        [NativeName("Name", "VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
        DepthStencilAttachmentReadBit = 512,
        [NativeName("Name", "VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
        DepthStencilAttachmentWriteBit = 1024,
        [NativeName("Name", "VK_ACCESS_TRANSFER_READ_BIT")]
        TransferReadBit = 2048,
        [NativeName("Name", "VK_ACCESS_TRANSFER_WRITE_BIT")]
        TransferWriteBit = 4096,
        [NativeName("Name", "VK_ACCESS_HOST_READ_BIT")]
        HostReadBit = 8192,
        [NativeName("Name", "VK_ACCESS_HOST_WRITE_BIT")]
        HostWriteBit = 16384,
        [NativeName("Name", "VK_ACCESS_MEMORY_READ_BIT")]
        MemoryReadBit = 32768,
        [NativeName("Name", "VK_ACCESS_MEMORY_WRITE_BIT")]
        MemoryWriteBit = 65536,
        [NativeName("Name", "VK_ACCESS_TRANSFORM_FEEDBACK_WRITE_BIT_EXT")]
        TransformFeedbackWriteBitExt = 33554432,
        [NativeName("Name", "VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT")]
        TransformFeedbackCounterReadBitExt = 67108864,
        [NativeName("Name", "VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT")]
        TransformFeedbackCounterWriteBitExt = 134217728,
        [NativeName("Name", "VK_ACCESS_CONDITIONAL_RENDERING_READ_BIT_EXT")]
        ConditionalRenderingReadBitExt = 1048576,
        [NativeName("Name", "VK_ACCESS_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT")]
        ColorAttachmentReadNoncoherentBitExt = 524288,
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_KHR")]
        AccelerationStructureReadBitKhr = 2097152,
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_KHR")]
        AccelerationStructureWriteBitKhr = 4194304,
        [NativeName("Name", "VK_ACCESS_SHADING_RATE_IMAGE_READ_BIT_NV")]
        ShadingRateImageReadBitNV = 8388608,
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_NV")]
        AccelerationStructureReadBitNV = 2097152,
        [NativeName("Name", "VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_NV")]
        AccelerationStructureWriteBitNV = 4194304,
        [NativeName("Name", "VK_ACCESS_FRAGMENT_DENSITY_MAP_READ_BIT_EXT")]
        FragmentDensityMapReadBitExt = 16777216,
        [NativeName("Name", "VK_ACCESS_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR")]
        FragmentShadingRateAttachmentReadBitKhr = 8388608,
        [NativeName("Name", "VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_NV")]
        CommandPreprocessReadBitNV = 131072,
        [NativeName("Name", "VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_NV")]
        CommandPreprocessWriteBitNV = 262144,
        [NativeName("Name", "VK_ACCESS_NONE_KHR")]
        NoneKhr = 0,
        [NativeName("Name", "VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_EXT")]
        CommandPreprocessReadBitExt = 131072,
        [NativeName("Name", "VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_EXT")]
        CommandPreprocessWriteBitExt = 262144,
        [NativeName("Name", "VK_ACCESS_NONE")]
        None = 0,
    }
}
