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
public unsafe partial struct PipelineViewportWScalingStateCreateInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public MaybeBool<uint> ViewportWScalingEnable;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public uint ViewportCount;

    [NativeTypeName("const VkViewportWScalingNV *")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public ViewportWScalingNV* PViewportWScalings;
}
