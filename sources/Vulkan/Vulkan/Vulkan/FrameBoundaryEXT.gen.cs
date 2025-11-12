// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct FrameBoundaryEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("VkFrameBoundaryFlagsEXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public FrameBoundaryFlagsEXT Flags;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public ulong FrameID;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public uint ImageCount;

    [NativeTypeName("const VkImage *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public ImageHandle* PImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public uint BufferCount;

    [NativeTypeName("const VkBuffer *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public BufferHandle* PBuffers;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public ulong TagName;

    [NativeTypeName("size_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_frame_boundary"],
        ImpliesSets = [
            "VK_EXT_frame_boundary+VK_KHR_get_physical_device_properties2",
            "VK_EXT_frame_boundary+VK_VERSION_1_1",
        ]
    )]
    public nuint TagSize;

    [NativeTypeName("const void *")]
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
