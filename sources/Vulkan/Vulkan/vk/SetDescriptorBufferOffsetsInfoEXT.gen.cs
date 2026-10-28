// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSetDescriptorBufferOffsetsInfoEXT")]
public unsafe partial struct SetDescriptorBufferOffsetsInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SetDescriptorBufferOffsetsInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("stageFlags")]
    public ShaderStageFlags StageFlags;

    [NativeName("layout")]
    public PipelineLayoutHandle Layout;

    [NativeName("firstSet")]
    public uint FirstSet;

    [NativeName("setCount")]
    public uint SetCount;

    [NativeName("pBufferIndices")]
    public uint* PBufferIndices;

    [NativeName("pOffsets")]
    public ulong* POffsets;

    public SetDescriptorBufferOffsetsInfoEXT() { }
}
