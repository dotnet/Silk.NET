// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGraphicsPipelineShaderGroupsCreateInfoNV")]
public unsafe partial struct GraphicsPipelineShaderGroupsCreateInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.GraphicsPipelineShaderGroupsCreateInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("groupCount")]
    public uint GroupCount;

    [NativeName("pGroups")]
    public GraphicsShaderGroupCreateInfoNV* PGroups;

    [NativeName("pipelineCount")]
    public uint PipelineCount;

    [NativeName("pPipelines")]
    public PipelineHandle* PPipelines;

    public GraphicsPipelineShaderGroupsCreateInfoNV() { }
}
