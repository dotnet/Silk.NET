// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRayTracingValidationFeaturesNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceRayTracingValidationFeaturesNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_validation"],
        ImpliesSets = [
            "VK_NV_ray_tracing_validation+VK_KHR_get_physical_device_properties2",
            "VK_NV_ray_tracing_validation+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_validation"],
        ImpliesSets = [
            "VK_NV_ray_tracing_validation+VK_KHR_get_physical_device_properties2",
            "VK_NV_ray_tracing_validation+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("rayTracingValidation")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_validation"],
        ImpliesSets = [
            "VK_NV_ray_tracing_validation+VK_KHR_get_physical_device_properties2",
            "VK_NV_ray_tracing_validation+VK_VERSION_1_1",
        ]
    )]
    public uint RayTracingValidation;
}
