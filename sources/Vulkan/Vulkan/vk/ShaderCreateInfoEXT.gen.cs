// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderCreateInfoEXT")]
public unsafe partial struct ShaderCreateInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ShaderCreateInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public ShaderCreateFlagsEXT Flags;

    [NativeName("stage")]
    public ShaderStageFlags Stage;

    [NativeName("nextStage")]
    public ShaderStageFlags NextStage;

    [NativeName("codeType")]
    public ShaderCodeTypeEXT CodeType;

    [NativeName("codeSize")]
    public nuint CodeSize;

    [NativeName("pCode")]
    public void* PCode;

    [NativeName("pName")]
    public sbyte* PName;

    [NativeName("setLayoutCount")]
    public uint SetLayoutCount;

    [NativeName("pSetLayouts")]
    public DescriptorSetLayoutHandle* PSetLayouts;

    [NativeName("pushConstantRangeCount")]
    public uint PushConstantRangeCount;

    [NativeName("pPushConstantRanges")]
    public PushConstantRange* PPushConstantRanges;

    [NativeName("pSpecializationInfo")]
    public SpecializationInfo* PSpecializationInfo;

    public ShaderCreateInfoEXT() { }
}
