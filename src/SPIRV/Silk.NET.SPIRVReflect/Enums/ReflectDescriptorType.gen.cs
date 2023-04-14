// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvReflectDescriptorType")]
    public enum ReflectDescriptorType : int
    {
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_SAMPLER")]
        Sampler = 0x0,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER")]
        CombinedImageSampler = 0x1,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_SAMPLED_IMAGE")]
        SampledImage = 0x2,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_STORAGE_IMAGE")]
        StorageImage = 0x3,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER")]
        UniformTexelBuffer = 0x4,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER")]
        StorageTexelBuffer = 0x5,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_UNIFORM_BUFFER")]
        UniformBuffer = 0x6,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_STORAGE_BUFFER")]
        StorageBuffer = 0x7,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC")]
        UniformBufferDynamic = 0x8,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC")]
        StorageBufferDynamic = 0x9,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_INPUT_ATTACHMENT")]
        InputAttachment = 0xA,
        [NativeName("Name", "SPV_REFLECT_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR")]
        AccelerationStructureKhr = 0x3B9D13F0,
    }
}
