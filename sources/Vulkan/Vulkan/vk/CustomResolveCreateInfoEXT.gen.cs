// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCustomResolveCreateInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct CustomResolveCreateInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve+VK_KHR_dynamic_rendering", "VK_EXT_custom_resolve+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.CustomResolveCreateInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve+VK_KHR_dynamic_rendering", "VK_EXT_custom_resolve+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("customResolve")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> CustomResolve;

    [NativeName("colorAttachmentCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve+VK_KHR_dynamic_rendering", "VK_EXT_custom_resolve+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public uint ColorAttachmentCount;

    [NativeName("pColorAttachmentFormats")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve+VK_KHR_dynamic_rendering", "VK_EXT_custom_resolve+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public Format* PColorAttachmentFormats;

    [NativeName("depthAttachmentFormat")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve+VK_KHR_dynamic_rendering", "VK_EXT_custom_resolve+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public Format DepthAttachmentFormat;

    [NativeName("stencilAttachmentFormat")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve+VK_KHR_dynamic_rendering", "VK_EXT_custom_resolve+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public Format StencilAttachmentFormat;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_resolve+VK_KHR_dynamic_rendering", "VK_EXT_custom_resolve+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_EXT_custom_resolve+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_resolve+VK_VERSION_1_1",
        ]
    )]
    public CustomResolveCreateInfoEXT() { }
}
