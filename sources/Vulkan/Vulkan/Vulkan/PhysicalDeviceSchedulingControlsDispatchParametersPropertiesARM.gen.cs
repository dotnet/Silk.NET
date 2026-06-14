// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    public StructureType SType =
        StructureType.PhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    public void* PNext;

    [NativeName("schedulingControlsMaxWarpsCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    public uint SchedulingControlsMaxWarpsCount;

    [NativeName("schedulingControlsMaxQueuedBatchesCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    public uint SchedulingControlsMaxQueuedBatchesCount;

    [NativeName("schedulingControlsMaxWorkGroupBatchSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    public uint SchedulingControlsMaxWorkGroupBatchSize;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_scheduling_controls"],
        ImpliesSets = ["VK_ARM_shader_core_builtins"]
    )]
    public PhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM() { }
}
