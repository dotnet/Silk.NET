// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineDiscardRectangleStateCreateInfoEXT")]
public unsafe partial struct PipelineDiscardRectangleStateCreateInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineDiscardRectangleStateCreateInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("discardRectangleMode")]
    public DiscardRectangleModeEXT DiscardRectangleMode;

    [NativeName("discardRectangleCount")]
    public uint DiscardRectangleCount;

    [NativeName("pDiscardRectangles")]
    public Rect2D* PDiscardRectangles;

    public PipelineDiscardRectangleStateCreateInfoEXT() { }
}
