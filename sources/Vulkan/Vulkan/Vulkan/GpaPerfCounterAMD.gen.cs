// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGpaPerfCounterAMD")]
[SupportedApiProfile("vulkan")]
public partial struct GpaPerfCounterAMD
{
    [NativeName("blockType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public GpaPerfBlockAMD BlockType;

    [NativeName("blockInstance")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public uint BlockInstance;

    [NativeName("eventID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public uint EventID;
}
