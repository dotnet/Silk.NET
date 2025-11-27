// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("HUAWEI", 0)]
[NativeName("VkPhysicalDeviceInvocationMaskFeaturesHUAWEI")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceInvocationMaskFeaturesHuawei
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_invocation_mask"],
        ImpliesSets = [
            "VK_KHR_ray_tracing_pipeline+VK_KHR_synchronization2",
            "VK_KHR_ray_tracing_pipeline+VK_VERSION_1_3",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_invocation_mask"],
        ImpliesSets = [
            "VK_KHR_ray_tracing_pipeline+VK_KHR_synchronization2",
            "VK_KHR_ray_tracing_pipeline+VK_VERSION_1_3",
        ]
    )]
    public void* PNext;

    [NativeName("invocationMask")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_invocation_mask"],
        ImpliesSets = [
            "VK_KHR_ray_tracing_pipeline+VK_KHR_synchronization2",
            "VK_KHR_ray_tracing_pipeline+VK_VERSION_1_3",
        ]
    )]
    public uint InvocationMask;
}
