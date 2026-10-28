// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkComputePipelineCreateInfo")]
public unsafe partial struct ComputePipelineCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ComputePipelineCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public PipelineCreateFlags Flags;

    [NativeName("stage")]
    public PipelineShaderStageCreateInfo Stage;

    [NativeName("layout")]
    public PipelineLayoutHandle Layout;

    [NativeName("basePipelineHandle")]
    public PipelineHandle BasePipelineHandle;

    [NativeName("basePipelineIndex")]
    public int BasePipelineIndex;

    public ComputePipelineCreateInfo() { }
}
