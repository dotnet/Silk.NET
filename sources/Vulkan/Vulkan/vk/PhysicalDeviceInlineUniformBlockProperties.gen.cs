// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceInlineUniformBlockProperties")]
public unsafe partial struct PhysicalDeviceInlineUniformBlockProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceInlineUniformBlockProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxInlineUniformBlockSize")]
    public uint MaxInlineUniformBlockSize;

    [NativeName("maxPerStageDescriptorInlineUniformBlocks")]
    public uint MaxPerStageDescriptorInlineUniformBlocks;

    [NativeName("maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks")]
    public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;

    [NativeName("maxDescriptorSetInlineUniformBlocks")]
    public uint MaxDescriptorSetInlineUniformBlocks;

    [NativeName("maxDescriptorSetUpdateAfterBindInlineUniformBlocks")]
    public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;

    public PhysicalDeviceInlineUniformBlockProperties() { }
}
