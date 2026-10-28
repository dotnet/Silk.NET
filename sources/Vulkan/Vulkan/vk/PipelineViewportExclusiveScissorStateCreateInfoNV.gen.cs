// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineViewportExclusiveScissorStateCreateInfoNV")]
public unsafe partial struct PipelineViewportExclusiveScissorStateCreateInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineViewportExclusiveScissorStateCreateInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("exclusiveScissorCount")]
    public uint ExclusiveScissorCount;

    [NativeName("pExclusiveScissors")]
    public Rect2D* PExclusiveScissors;

    public PipelineViewportExclusiveScissorStateCreateInfoNV() { }
}
