// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureGeometryMicromapDataKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct AccelerationStructureGeometryMicromapDataKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public StructureType SType = StructureType.AccelerationStructureGeometryMicromapDataKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public void* PNext;

    [NativeName("usageCountsCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public uint UsageCountsCount;

    [NativeName("pUsageCounts")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public MicromapUsageKHR* PUsageCounts;

    [NativeName("ppUsageCounts")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public MicromapUsageKHR** PpUsageCounts;

    [NativeName("data")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public ulong Data;

    [NativeName("triangleArray")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public ulong TriangleArray;

    [NativeName("triangleArrayStride")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public ulong TriangleArrayStride;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public AccelerationStructureGeometryMicromapDataKHR() { }
}
