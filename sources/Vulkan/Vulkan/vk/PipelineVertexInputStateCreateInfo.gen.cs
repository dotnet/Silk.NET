// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineVertexInputStateCreateInfo")]
public unsafe partial struct PipelineVertexInputStateCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineVertexInputStateCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("vertexBindingDescriptionCount")]
    public uint VertexBindingDescriptionCount;

    [NativeName("pVertexBindingDescriptions")]
    public VertexInputBindingDescription* PVertexBindingDescriptions;

    [NativeName("vertexAttributeDescriptionCount")]
    public uint VertexAttributeDescriptionCount;

    [NativeName("pVertexAttributeDescriptions")]
    public VertexInputAttributeDescription* PVertexAttributeDescriptions;

    public PipelineVertexInputStateCreateInfo() { }
}
