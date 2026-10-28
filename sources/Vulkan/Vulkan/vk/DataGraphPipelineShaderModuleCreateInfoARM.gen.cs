// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelineShaderModuleCreateInfoARM")]
public unsafe partial struct DataGraphPipelineShaderModuleCreateInfoARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DataGraphPipelineShaderModuleCreateInfoARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("module")]
    public ShaderModuleHandle Module;

    [NativeName("pName")]
    public sbyte* PName;

    [NativeName("pSpecializationInfo")]
    public SpecializationInfo* PSpecializationInfo;

    [NativeName("constantCount")]
    public uint ConstantCount;

    [NativeName("pConstants")]
    public DataGraphPipelineConstantARM* PConstants;

    public DataGraphPipelineShaderModuleCreateInfoARM() { }
}
