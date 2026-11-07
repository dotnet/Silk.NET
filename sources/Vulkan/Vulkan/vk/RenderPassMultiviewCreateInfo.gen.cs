// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderPassMultiviewCreateInfo")]
public unsafe partial struct RenderPassMultiviewCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RenderPassMultiviewCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("subpassCount")]
    public uint SubpassCount;

    [NativeName("pViewMasks")]
    public uint* PViewMasks;

    [NativeName("dependencyCount")]
    public uint DependencyCount;

    [NativeName("pViewOffsets")]
    public int* PViewOffsets;

    [NativeName("correlationMaskCount")]
    public uint CorrelationMaskCount;

    [NativeName("pCorrelationMasks")]
    public uint* PCorrelationMasks;

    public RenderPassMultiviewCreateInfo() { }
}
