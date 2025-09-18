// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DataGraphPipelineShaderModuleCreateInfoARM
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkShaderModule")]
    [SupportedApiProfile("vulkan")]
    public ShaderModuleHandle Module;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan")]
    public sbyte* PName;

    [NativeTypeName("const VkSpecializationInfo *")]
    [SupportedApiProfile("vulkan")]
    public SpecializationInfo* PSpecializationInfo;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ConstantCount;

    [NativeTypeName("const VkDataGraphPipelineConstantARM *")]
    [SupportedApiProfile("vulkan")]
    public DataGraphPipelineConstantARM* PConstants;
}
