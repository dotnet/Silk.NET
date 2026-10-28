// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineShaderStageCreateInfo")]
public unsafe partial struct PipelineShaderStageCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineShaderStageCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public PipelineShaderStageCreateFlags Flags;

    [NativeName("stage")]
    public ShaderStageFlags Stage;

    [NativeName("module")]
    public ShaderModuleHandle Module;

    [NativeName("pName")]
    public sbyte* PName;

    [NativeName("pSpecializationInfo")]
    public SpecializationInfo* PSpecializationInfo;

    public PipelineShaderStageCreateInfo() { }
}
