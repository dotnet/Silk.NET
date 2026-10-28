// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkWriteDescriptorSet")]
public unsafe partial struct WriteDescriptorSet
{
    [NativeName("sType")]
    public StructureType SType = StructureType.WriteDescriptorSet;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("dstSet")]
    public DescriptorSetHandle DstSet;

    [NativeName("dstBinding")]
    public uint DstBinding;

    [NativeName("dstArrayElement")]
    public uint DstArrayElement;

    [NativeName("descriptorCount")]
    public uint DescriptorCount;

    [NativeName("descriptorType")]
    public DescriptorType DescriptorType;

    [NativeName("pImageInfo")]
    public DescriptorImageInfo* PImageInfo;

    [NativeName("pBufferInfo")]
    public DescriptorBufferInfo* PBufferInfo;

    [NativeName("pTexelBufferView")]
    public BufferViewHandle* PTexelBufferView;

    public WriteDescriptorSet() { }
}
