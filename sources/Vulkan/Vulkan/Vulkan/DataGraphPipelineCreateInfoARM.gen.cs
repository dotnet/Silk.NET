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
public unsafe partial struct DataGraphPipelineCreateInfoARM
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkPipelineCreateFlags2KHR")]
    [SupportedApiProfile("vulkan")]
    public ulong Flags;

    [NativeTypeName("VkPipelineLayout")]
    [SupportedApiProfile("vulkan")]
    public PipelineLayoutHandle Layout;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ResourceInfoCount;

    [NativeTypeName("const VkDataGraphPipelineResourceInfoARM *")]
    [SupportedApiProfile("vulkan")]
    public DataGraphPipelineResourceInfoARM* PResourceInfos;
}
