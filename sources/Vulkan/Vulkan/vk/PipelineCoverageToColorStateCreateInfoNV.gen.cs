// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineCoverageToColorStateCreateInfoNV")]
public unsafe partial struct PipelineCoverageToColorStateCreateInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineCoverageToColorStateCreateInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("coverageToColorEnable")]
    public MaybeBool<uint> CoverageToColorEnable;

    [NativeName("coverageToColorLocation")]
    public uint CoverageToColorLocation;

    public PipelineCoverageToColorStateCreateInfoNV() { }
}
