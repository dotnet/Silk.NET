// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAndroidHardwareBufferFormatResolvePropertiesANDROID")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct AndroidHardwareBufferFormatResolvePropertiesANDROID
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    public StructureType SType = StructureType.AndroidHardwareBufferFormatResolvePropertiesANDROID;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    public void* PNext;

    [NativeName("colorAttachmentFormat")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    public Format ColorAttachmentFormat;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ANDROID_external_format_resolve"],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    public AndroidHardwareBufferFormatResolvePropertiesANDROID() { }
}
