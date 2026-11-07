// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPushConstantsInfo")]
public unsafe partial struct PushConstantsInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PushConstantsInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("layout")]
    public PipelineLayoutHandle Layout;

    [NativeName("stageFlags")]
    public ShaderStageFlags StageFlags;

    [NativeName("offset")]
    public uint Offset;

    [NativeName("size")]
    public uint Size;

    [NativeName("pValues")]
    public void* PValues;

    public PushConstantsInfo() { }
}
