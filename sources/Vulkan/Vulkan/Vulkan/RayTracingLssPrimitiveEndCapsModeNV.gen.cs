// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkRayTracingLssPrimitiveEndCapsModeNV")]
[SupportedApiProfile("vulkan")]
public enum RayTracingLssPrimitiveEndCapsModeNV : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_RAY_TRACING_LSS_PRIMITIVE_END_CAPS_MODE_NONE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    Nonenv = 0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_RAY_TRACING_LSS_PRIMITIVE_END_CAPS_MODE_CHAINED_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_linear_swept_spheres"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    Chainednv = 1,
}
