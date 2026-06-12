// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGpaPerfBlockPropertiesAMD")]
[SupportedApiProfile("vulkan")]
public partial struct GpaPerfBlockPropertiesAMD
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

    [NativeName("flags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public uint Flags;

    [NativeName("instanceCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public uint InstanceCount;

    [NativeName("maxEventID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public uint MaxEventID;

    [NativeName("maxGlobalOnlyCounters")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public uint MaxGlobalOnlyCounters;

    [NativeName("maxGlobalSharedCounters")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public uint MaxGlobalSharedCounters;

    [NativeName("maxStreamingCounters")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public uint MaxStreamingCounters;
}
