// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAccessFlags2KHR")]
    public enum AccessFlags2KHR : long
    {
        [NativeName("Name", "VK_ACCESS_2_NONE_KHR")]
        Access2NoneKhr = 0,
        [NativeName("Name", "VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR")]
        Access2IndirectCommandReadBitKhr = 1,
        [NativeName("Name", "VK_ACCESS_2_INDEX_READ_BIT_KHR")]
        Access2IndexReadBitKhr = 2,
        [NativeName("Name", "VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR")]
        Access2VertexAttributeReadBitKhr = 4,
        [NativeName("Name", "VK_ACCESS_2_UNIFORM_READ_BIT_KHR")]
        Access2UniformReadBitKhr = 8,
        [NativeName("Name", "VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR")]
        Access2InputAttachmentReadBitKhr = 16,
        [NativeName("Name", "VK_ACCESS_2_SHADER_READ_BIT_KHR")]
        Access2ShaderReadBitKhr = 32,
        [NativeName("Name", "VK_ACCESS_2_SHADER_WRITE_BIT_KHR")]
        Access2ShaderWriteBitKhr = 64,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR")]
        Access2ColorAttachmentReadBitKhr = 128,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR")]
        Access2ColorAttachmentWriteBitKhr = 256,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR")]
        Access2DepthStencilAttachmentReadBitKhr = 512,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR")]
        Access2DepthStencilAttachmentWriteBitKhr = 1024,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_READ_BIT_KHR")]
        Access2TransferReadBitKhr = 2048,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR")]
        Access2TransferWriteBitKhr = 4096,
        [NativeName("Name", "VK_ACCESS_2_HOST_READ_BIT_KHR")]
        Access2HostReadBitKhr = 8192,
        [NativeName("Name", "VK_ACCESS_2_HOST_WRITE_BIT_KHR")]
        Access2HostWriteBitKhr = 16384,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_READ_BIT_KHR")]
        Access2MemoryReadBitKhr = 32768,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_WRITE_BIT_KHR")]
        Access2MemoryWriteBitKhr = 65536,
        [NativeName("Name", "VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR")]
        Access2ShaderSampledReadBitKhr = 4294967296,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR")]
        Access2ShaderStorageReadBitKhr = 8589934592,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR")]
        Access2ShaderStorageWriteBitKhr = 17179869184,
        [NativeName("Name", "VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR")]
        Access2VideoDecodeReadBitKhr = 34359738368,
        [NativeName("Name", "VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR")]
        Access2VideoDecodeWriteBitKhr = 68719476736,
        [NativeName("Name", "VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR")]
        Access2VideoEncodeReadBitKhr = 137438953472,
        [NativeName("Name", "VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR")]
        Access2VideoEncodeWriteBitKhr = 274877906944,
        [NativeName("Name", "VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT")]
        Access2TransformFeedbackWriteBitExt = 33554432,
        [NativeName("Name", "VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT")]
        Access2TransformFeedbackCounterReadBitExt = 67108864,
        [NativeName("Name", "VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT")]
        Access2TransformFeedbackCounterWriteBitExt = 134217728,
        [NativeName("Name", "VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT")]
        Access2ConditionalRenderingReadBitExt = 1048576,
        [NativeName("Name", "VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV")]
        Access2CommandPreprocessReadBitNV = 131072,
        [NativeName("Name", "VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV")]
        Access2CommandPreprocessWriteBitNV = 262144,
        [NativeName("Name", "VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR")]
        Access2FragmentShadingRateAttachmentReadBitKhr = 8388608,
        [NativeName("Name", "VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV")]
        Access2ShadingRateImageReadBitNV = 8388608,
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR")]
        Access2AccelerationStructureReadBitKhr = 2097152,
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR")]
        Access2AccelerationStructureWriteBitKhr = 4194304,
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV")]
        Access2AccelerationStructureReadBitNV = 2097152,
        [NativeName("Name", "VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV")]
        Access2AccelerationStructureWriteBitNV = 4194304,
        [NativeName("Name", "VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT")]
        Access2FragmentDensityMapReadBitExt = 16777216,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT")]
        Access2ColorAttachmentReadNoncoherentBitExt = 524288,
        [NativeName("Name", "VK_ACCESS_2_RESERVED_41_BIT_AMD")]
        Access2Reserved41BitAmd = 2199023255552,
        [NativeName("Name", "VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI")]
        Access2InvocationMaskReadBitHuawei = 549755813888,
        [NativeName("Name", "VK_ACCESS_2_RESERVED_387_BIT_KHR")]
        Access2Reserved387BitKhr = 1099511627776,
    }
}
