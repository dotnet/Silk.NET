// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkFrameBoundaryEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct FrameBoundaryEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("flags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public FrameBoundaryFlagsEXT Flags;

    [NativeName("frameID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public ulong FrameID;

    [NativeName("imageCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public uint ImageCount;

    [NativeName("pImages")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public ImageHandle* PImages;

    [NativeName("bufferCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public uint BufferCount;

    [NativeName("pBuffers")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public BufferHandle* PBuffers;

    [NativeName("tagName")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public ulong TagName;

    [NativeName("tagSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public nuint TagSize;

    [NativeName("pTag")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public void* PTag;
}
