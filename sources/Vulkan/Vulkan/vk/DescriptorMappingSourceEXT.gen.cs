// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorMappingSourceEXT")]
public enum DescriptorMappingSourceEXT : uint
{
    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_CONSTANT_OFFSET_EXT")]
    HeapWithConstantOffset = 0,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_PUSH_INDEX_EXT")]
    HeapWithPushIndex = 1,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_INDIRECT_INDEX_EXT")]
    HeapWithIndirectIndex = 2,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_INDIRECT_INDEX_ARRAY_EXT")]
    HeapWithIndirectIndexArray = 3,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_RESOURCE_HEAP_DATA_EXT")]
    ResourceHeapData = 4,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_PUSH_DATA_EXT")]
    PushData = 5,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_PUSH_ADDRESS_EXT")]
    PushAddress = 6,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_INDIRECT_ADDRESS_EXT")]
    IndirectAddress = 7,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_SHADER_RECORD_INDEX_EXT")]
    HeapWithShaderRecordIndex = 8,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_SHADER_RECORD_DATA_EXT")]
    ShaderRecordData = 9,

    [NativeName("VK_DESCRIPTOR_MAPPING_SOURCE_SHADER_RECORD_ADDRESS_EXT")]
    ShaderRecordAddress = 10,
}
