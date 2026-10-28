// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelineCreateInfoARM")]
public unsafe partial struct DataGraphPipelineCreateInfoARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DataGraphPipelineCreateInfoARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public PipelineCreateFlags2 Flags;

    [NativeName("layout")]
    public PipelineLayoutHandle Layout;

    [NativeName("resourceInfoCount")]
    public uint ResourceInfoCount;

    [NativeName("pResourceInfos")]
    public DataGraphPipelineResourceInfoARM* PResourceInfos;

    public DataGraphPipelineCreateInfoARM() { }
}
