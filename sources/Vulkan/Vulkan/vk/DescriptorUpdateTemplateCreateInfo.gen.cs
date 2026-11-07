// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorUpdateTemplateCreateInfo")]
public unsafe partial struct DescriptorUpdateTemplateCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DescriptorUpdateTemplateCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("descriptorUpdateEntryCount")]
    public uint DescriptorUpdateEntryCount;

    [NativeName("pDescriptorUpdateEntries")]
    public DescriptorUpdateTemplateEntry* PDescriptorUpdateEntries;

    [NativeName("templateType")]
    public DescriptorUpdateTemplateType TemplateType;

    [NativeName("descriptorSetLayout")]
    public DescriptorSetLayoutHandle DescriptorSetLayout;

    [NativeName("pipelineBindPoint")]
    public PipelineBindPoint PipelineBindPoint;

    [NativeName("pipelineLayout")]
    public PipelineLayoutHandle PipelineLayout;

    [NativeName("set")]
    public uint Set;

    public DescriptorUpdateTemplateCreateInfo() { }
}
