// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGpaDeviceGetClockInfoAMD")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct GpaDeviceGetClockInfoAMD
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.GpaDeviceGetClockInfoAMD;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("memoryClockRatioToPeak")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public float MemoryClockRatioToPeak;

    [NativeName("engineClockRatioToPeak")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public float EngineClockRatioToPeak;

    [NativeName("memoryClockFrequency")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public uint MemoryClockFrequency;

    [NativeName("engineClockFrequency")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public uint EngineClockFrequency;

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    public GpaDeviceGetClockInfoAMD() { }
}
