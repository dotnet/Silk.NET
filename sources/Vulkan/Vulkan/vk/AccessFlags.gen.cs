// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccessFlags")]
[Flags]
public enum AccessFlags : uint
{
    [NativeName("VK_ACCESS_INDIRECT_COMMAND_READ_BIT")]
    IndirectCommandReadBit = 0x1,

    [NativeName("VK_ACCESS_INDEX_READ_BIT")]
    IndexReadBit = 0x2,

    [NativeName("VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT")]
    VertexAttributeReadBit = 0x4,

    [NativeName("VK_ACCESS_UNIFORM_READ_BIT")]
    UniformReadBit = 0x8,

    [NativeName("VK_ACCESS_INPUT_ATTACHMENT_READ_BIT")]
    InputAttachmentReadBit = 0x10,

    [NativeName("VK_ACCESS_SHADER_READ_BIT")]
    ShaderReadBit = 0x20,

    [NativeName("VK_ACCESS_SHADER_WRITE_BIT")]
    ShaderWriteBit = 0x40,

    [NativeName("VK_ACCESS_COLOR_ATTACHMENT_READ_BIT")]
    ColorAttachmentReadBit = 0x80,

    [NativeName("VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT")]
    ColorAttachmentWriteBit = 0x100,

    [NativeName("VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
    DepthStencilAttachmentReadBit = 0x200,

    [NativeName("VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
    DepthStencilAttachmentWriteBit = 0x400,

    [NativeName("VK_ACCESS_TRANSFER_READ_BIT")]
    TransferReadBit = 0x800,

    [NativeName("VK_ACCESS_TRANSFER_WRITE_BIT")]
    TransferWriteBit = 0x1000,

    [NativeName("VK_ACCESS_HOST_READ_BIT")]
    HostReadBit = 0x2000,

    [NativeName("VK_ACCESS_HOST_WRITE_BIT")]
    HostWriteBit = 0x4000,

    [NativeName("VK_ACCESS_MEMORY_READ_BIT")]
    MemoryReadBit = 0x8000,

    [NativeName("VK_ACCESS_MEMORY_WRITE_BIT")]
    MemoryWriteBit = 0x10000,

    [NativeName("VK_ACCESS_NONE")]
    None = 0x0,

    [NativeName("VK_ACCESS_TRANSFORM_FEEDBACK_WRITE_BIT_EXT")]
    TransformFeedbackWriteBitEXT = 0x2000000,

    [NativeName("VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT")]
    TransformFeedbackCounterReadBitEXT = 0x4000000,

    [NativeName("VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT")]
    TransformFeedbackCounterWriteBitEXT = 0x8000000,

    [NativeName("VK_ACCESS_CONDITIONAL_RENDERING_READ_BIT_EXT")]
    ConditionalRenderingReadBitEXT = 0x100000,

    [NativeName("VK_ACCESS_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT")]
    ColorAttachmentReadNoncoherentBitEXT = 0x80000,

    [NativeName("VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_KHR")]
    AccelerationStructureReadBitKHR = 0x200000,

    [NativeName("VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_KHR")]
    AccelerationStructureWriteBitKHR = 0x400000,

    [NativeName("VK_ACCESS_FRAGMENT_DENSITY_MAP_READ_BIT_EXT")]
    FragmentDensityMapReadBitEXT = 0x1000000,

    [NativeName("VK_ACCESS_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR")]
    FragmentShadingRateAttachmentReadBitKHR = 0x800000,

    [NativeName("VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_EXT")]
    CommandPreprocessReadBitEXT = 0x20000,

    [NativeName("VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_EXT")]
    CommandPreprocessWriteBitEXT = 0x40000,

    [NativeName("VK_ACCESS_SHADING_RATE_IMAGE_READ_BIT_NV")]
    ShadingRateImageReadBitNV = FragmentShadingRateAttachmentReadBitKHR,

    [NativeName("VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_NV")]
    AccelerationStructureReadBitNV = AccelerationStructureReadBitKHR,

    [NativeName("VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_NV")]
    AccelerationStructureWriteBitNV = AccelerationStructureWriteBitKHR,

    [NativeName("VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_NV")]
    CommandPreprocessReadBitNV = CommandPreprocessReadBitEXT,

    [NativeName("VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_NV")]
    CommandPreprocessWriteBitNV = CommandPreprocessWriteBitEXT,

    [NativeName("VK_ACCESS_NONE_KHR")]
    NoneKHR = None,
}
