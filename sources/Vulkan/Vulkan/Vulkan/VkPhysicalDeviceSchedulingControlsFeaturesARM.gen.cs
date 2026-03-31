// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceSchedulingControlsFeaturesARM")]
[NameAffix("Suffix", "KhronosVendor", "ARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceSchedulingControlsFeaturesARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    public void* PNext;

    [NativeName("schedulingControls")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    public uint SchedulingControls;
}
