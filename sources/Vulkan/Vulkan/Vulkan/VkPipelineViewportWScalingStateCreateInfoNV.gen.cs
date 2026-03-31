// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineViewportWScalingStateCreateInfoNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPipelineViewportWScalingStateCreateInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public void* PNext;

    [NativeName("viewportWScalingEnable")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public uint ViewportWScalingEnable;

    [NativeName("viewportCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public uint ViewportCount;

    [NativeName("pViewportWScalings")]
    [NativeTypeName("const VkViewportWScalingNV *")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public VkViewportWScalingNV* PViewportWScalings;
}
