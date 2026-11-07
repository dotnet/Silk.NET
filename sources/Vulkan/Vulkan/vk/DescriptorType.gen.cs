// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorType")]
public enum DescriptorType : uint
{
    [NativeName("VK_DESCRIPTOR_TYPE_SAMPLER")]
    Sampler = 0,

    [NativeName("VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER")]
    CombinedImageSampler = 1,

    [NativeName("VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE")]
    SampledImage = 2,

    [NativeName("VK_DESCRIPTOR_TYPE_STORAGE_IMAGE")]
    StorageImage = 3,

    [NativeName("VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER")]
    UniformTexelBuffer = 4,

    [NativeName("VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER")]
    StorageTexelBuffer = 5,

    [NativeName("VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER")]
    UniformBuffer = 6,

    [NativeName("VK_DESCRIPTOR_TYPE_STORAGE_BUFFER")]
    StorageBuffer = 7,

    [NativeName("VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC")]
    UniformBufferDynamic = 8,

    [NativeName("VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC")]
    StorageBufferDynamic = 9,

    [NativeName("VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT")]
    InputAttachment = 10,

    [NativeName("VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK")]
    InlineUniformBlock = 1000138000,

    [NativeName("VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR")]
    AccelerationStructureKHR = 1000150000,

    [NativeName("VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV")]
    AccelerationStructureNV = 1000165000,

    [NativeName("VK_DESCRIPTOR_TYPE_SAMPLE_WEIGHT_IMAGE_QCOM")]
    SampleWeightImageQCOM = 1000440000,

    [NativeName("VK_DESCRIPTOR_TYPE_BLOCK_MATCH_IMAGE_QCOM")]
    BlockMatchImageQCOM = 1000440001,

    [NativeName("VK_DESCRIPTOR_TYPE_TENSOR_ARM")]
    TensorARM = 1000460000,

    [NativeName("VK_DESCRIPTOR_TYPE_MUTABLE_EXT")]
    MutableEXT = 1000351000,

    [NativeName("VK_DESCRIPTOR_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_NV")]
    PartitionedAccelerationStructureNV = 1000570000,

    [NativeName("VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT")]
    InlineUniformBlockEXT = InlineUniformBlock,

    [NativeName("VK_DESCRIPTOR_TYPE_MUTABLE_VALVE")]
    MutableVALVE = MutableEXT,
}
