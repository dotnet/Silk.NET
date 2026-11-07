// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineExecutableStatisticKHR")]
public unsafe partial struct PipelineExecutableStatisticKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineExecutableStatisticKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("name")]
    public PipelineExecutableStatisticKHRName Name;

    [NativeName("description")]
    public PipelineExecutableStatisticKHRDescription Description;

    [NativeName("format")]
    public PipelineExecutableStatisticFormatKHR Format;

    [NativeName("value")]
    public PipelineExecutableStatisticValueKHR Value;

    public PipelineExecutableStatisticKHR() { }
}
