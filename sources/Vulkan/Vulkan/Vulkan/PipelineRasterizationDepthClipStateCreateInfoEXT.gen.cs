// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineRasterizationDepthClipStateCreateInfoEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("VkPipelineRasterizationDepthClipStateCreateFlagsEXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    public uint Flags;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_depth_clip_enable"],
        ImpliesSets = [
            "VK_EXT_depth_clip_enable+VK_KHR_get_physical_device_properties2",
            "VK_EXT_depth_clip_enable+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> DepthClipEnable;
}
