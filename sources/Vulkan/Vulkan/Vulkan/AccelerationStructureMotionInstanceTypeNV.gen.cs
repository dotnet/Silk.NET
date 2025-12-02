// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureMotionInstanceTypeNV")]
[SupportedApiProfile("vulkan")]
public enum AccelerationStructureMotionInstanceTypeNV : uint
{
    [NativeName("VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    Static = 0,

    [NativeName("VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    MatrixMotion = 1,

    [NativeName("VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    SrtMotion = 2,
}
