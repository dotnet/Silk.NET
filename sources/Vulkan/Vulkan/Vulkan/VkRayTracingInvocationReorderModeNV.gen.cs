// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkRayTracingInvocationReorderModeNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkRayTracingInvocationReorderModeNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkRayTracingInvocationReorderModeNone = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkRayTracingInvocationReorderModeReorder = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_RAY_TRACING_INVOCATION_REORDER_MODE_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_invocation_reorder"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    VkRayTracingInvocationReorderModeMaxEnum = 0x7FFFFFFF,
}
