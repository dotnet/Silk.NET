// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceExternalFormatResolvePropertiesANDROID")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceExternalFormatResolvePropertiesANDROID
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    public StructureType SType = StructureType.PhysicalDeviceExternalFormatResolvePropertiesANDROID;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    public void* PNext;

    [NativeName("nullColorAttachmentWithExternalFormatResolve")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    public MaybeBool<uint> NullColorAttachmentWithExternalFormatResolve;

    [NativeName("externalFormatResolveChromaOffsetX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    public ChromaLocation ExternalFormatResolveChromaOffsetX;

    [NativeName("externalFormatResolveChromaOffsetY")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    public ChromaLocation ExternalFormatResolveChromaOffsetY;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    public PhysicalDeviceExternalFormatResolvePropertiesANDROID() { }
}
