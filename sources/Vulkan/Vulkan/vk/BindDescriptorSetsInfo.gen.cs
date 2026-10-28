// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBindDescriptorSetsInfo")]
public unsafe partial struct BindDescriptorSetsInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BindDescriptorSetsInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("stageFlags")]
    public ShaderStageFlags StageFlags;

    [NativeName("layout")]
    public PipelineLayoutHandle Layout;

    [NativeName("firstSet")]
    public uint FirstSet;

    [NativeName("descriptorSetCount")]
    public uint DescriptorSetCount;

    [NativeName("pDescriptorSets")]
    public DescriptorSetHandle* PDescriptorSets;

    [NativeName("dynamicOffsetCount")]
    public uint DynamicOffsetCount;

    [NativeName("pDynamicOffsets")]
    public uint* PDynamicOffsets;

    public BindDescriptorSetsInfo() { }
}
