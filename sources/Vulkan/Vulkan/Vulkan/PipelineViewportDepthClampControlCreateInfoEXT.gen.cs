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
public unsafe partial struct PipelineViewportDepthClampControlCreateInfoEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    public DepthClampModeEXT DepthClampMode;

    [NativeTypeName("const VkDepthClampRangeEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clamp_control"],
        ImpliesSets = [
            "VK_EXT_depth_clamp_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clamp_control+VK_VERSION_1_1",
        ]
    )]
    public DepthClampRangeEXT* PDepthClampRange;
}
