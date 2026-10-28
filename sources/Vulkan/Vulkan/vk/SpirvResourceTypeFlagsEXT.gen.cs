// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSpirvResourceTypeFlagsEXT")]
[Flags]
public enum SpirvResourceTypeFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_ALL_EXT")]
    All = 0x7FFFFFFF,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_SAMPLER_BIT_EXT")]
    SamplerBit = 0x1,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_SAMPLED_IMAGE_BIT_EXT")]
    SampledImageBit = 0x2,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_READ_ONLY_IMAGE_BIT_EXT")]
    ReadOnlyImageBit = 0x4,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_READ_WRITE_IMAGE_BIT_EXT")]
    ReadWriteImageBit = 0x8,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_COMBINED_SAMPLED_IMAGE_BIT_EXT")]
    CombinedSampledImageBit = 0x10,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_UNIFORM_BUFFER_BIT_EXT")]
    UniformBufferBit = 0x20,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_READ_ONLY_STORAGE_BUFFER_BIT_EXT")]
    ReadOnlyStorageBufferBit = 0x40,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_READ_WRITE_STORAGE_BUFFER_BIT_EXT")]
    ReadWriteStorageBufferBit = 0x80,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_ACCELERATION_STRUCTURE_BIT_EXT")]
    AccelerationStructureBit = 0x100,

    [NativeName("VK_SPIRV_RESOURCE_TYPE_TENSOR_BIT_ARM")]
    TensorBitARM = 0x200,
}
