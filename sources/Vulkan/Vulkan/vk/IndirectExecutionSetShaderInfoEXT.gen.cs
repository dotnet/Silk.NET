// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectExecutionSetShaderInfoEXT")]
public unsafe partial struct IndirectExecutionSetShaderInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.IndirectExecutionSetShaderInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderCount")]
    public uint ShaderCount;

    [NativeName("pInitialShaders")]
    public ShaderHandleEXT* PInitialShaders;

    [NativeName("pSetLayoutInfos")]
    public IndirectExecutionSetShaderLayoutInfoEXT* PSetLayoutInfos;

    [NativeName("maxShaderCount")]
    public uint MaxShaderCount;

    [NativeName("pushConstantRangeCount")]
    public uint PushConstantRangeCount;

    [NativeName("pPushConstantRanges")]
    public PushConstantRange* PPushConstantRanges;

    public IndirectExecutionSetShaderInfoEXT() { }
}
