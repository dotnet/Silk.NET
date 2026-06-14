// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRayTracingInvocationReorderPropertiesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceRayTracingInvocationReorderPropertiesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public StructureType SType =
        StructureType.PhysicalDeviceRayTracingInvocationReorderPropertiesEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public void* PNext;

    [NativeName("rayTracingInvocationReorderReorderingHint")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public RayTracingInvocationReorderModeEXT RayTracingInvocationReorderReorderingHint;

    [NativeName("maxShaderBindingTableRecordIndex")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public uint MaxShaderBindingTableRecordIndex;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public PhysicalDeviceRayTracingInvocationReorderPropertiesEXT() { }
}
