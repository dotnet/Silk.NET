// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorSetAndBindingMappingEXT")]
public unsafe partial struct DescriptorSetAndBindingMappingEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DescriptorSetAndBindingMappingEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("descriptorSet")]
    public uint DescriptorSet;

    [NativeName("firstBinding")]
    public uint FirstBinding;

    [NativeName("bindingCount")]
    public uint BindingCount;

    [NativeName("resourceMask")]
    public SpirvResourceTypeFlagsEXT ResourceMask;

    [NativeName("source")]
    public DescriptorMappingSourceEXT Source;

    [NativeName("sourceData")]
    public DescriptorMappingSourceDataEXT SourceData;

    public DescriptorSetAndBindingMappingEXT() { }
}
