// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDescriptorType")]
    public enum DescriptorType : int
    {
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_SAMPLER")]
        Sampler = 0,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER")]
        CombinedImageSampler = 1,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE")]
        SampledImage = 2,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_STORAGE_IMAGE")]
        StorageImage = 3,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER")]
        UniformTexelBuffer = 4,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER")]
        StorageTexelBuffer = 5,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER")]
        UniformBuffer = 6,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_STORAGE_BUFFER")]
        StorageBuffer = 7,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC")]
        UniformBufferDynamic = 8,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC")]
        StorageBufferDynamic = 9,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT")]
        InputAttachment = 10,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT")]
        InlineUniformBlockExt = 1000138000,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR")]
        AccelerationStructureKhr = 1000150000,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV")]
        AccelerationStructureNV = 1000165000,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_MUTABLE_VALVE")]
        MutableValve = 1000351000,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_SAMPLE_WEIGHT_IMAGE_QCOM")]
        SampleWeightImageQCom = 1000440000,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_BLOCK_MATCH_IMAGE_QCOM")]
        BlockMatchImageQCom = 1000440001,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_MUTABLE_EXT")]
        MutableExt = 1000351000,
        [NativeName("Name", "VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK")]
        InlineUniformBlock = 1000138000,
    }
}
