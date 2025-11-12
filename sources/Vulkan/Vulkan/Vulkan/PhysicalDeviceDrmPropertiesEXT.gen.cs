// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceDrmPropertiesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> HasPrimary;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> HasRender;

    [NativeTypeName("int64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    public long PrimaryMajor;

    [NativeTypeName("int64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    public long PrimaryMinor;

    [NativeTypeName("int64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    public long RenderMajor;

    [NativeTypeName("int64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_physical_device_drm"],
        ImpliesSets = [
            "VK_EXT_physical_device_drm+VK_KHR_get_physical_device_properties2",
            "VK_EXT_physical_device_drm+VK_VERSION_1_1",
        ]
    )]
    public long RenderMinor;
}
