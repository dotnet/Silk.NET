// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectCommandsLayoutCreateInfoNV")]
public unsafe partial struct IndirectCommandsLayoutCreateInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.IndirectCommandsLayoutCreateInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public IndirectCommandsLayoutUsageFlagsNV Flags;

    [NativeName("pipelineBindPoint")]
    public PipelineBindPoint PipelineBindPoint;

    [NativeName("tokenCount")]
    public uint TokenCount;

    [NativeName("pTokens")]
    public IndirectCommandsLayoutTokenNV* PTokens;

    [NativeName("streamCount")]
    public uint StreamCount;

    [NativeName("pStreamStrides")]
    public uint* PStreamStrides;

    public IndirectCommandsLayoutCreateInfoNV() { }
}
