// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("NV", 0)]
[NativeName("VkPipelineViewportWScalingStateCreateInfoNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineViewportWScalingStateCreateInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public void* PNext;

    [NativeName("viewportWScalingEnable")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public uint ViewportWScalingEnable;

    [NativeName("viewportCount")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public uint ViewportCount;

    [NativeName("pViewportWScalings")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public ViewportWScalingNV* PViewportWScalings;
}
