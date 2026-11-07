// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubpassShadingPipelineCreateInfoHUAWEI")]
public unsafe partial struct SubpassShadingPipelineCreateInfoHUAWEI
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SubpassShadingPipelineCreateInfoHUAWEI;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("renderPass")]
    public RenderPassHandle RenderPass;

    [NativeName("subpass")]
    public uint Subpass;

    public SubpassShadingPipelineCreateInfoHUAWEI() { }
}
