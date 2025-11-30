// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkTraceRaysIndirectCommand2KHR")]
[SupportedApiProfile("vulkan")]
public partial struct TraceRaysIndirectCommand2Khr
{
    [NativeName("raygenShaderRecordAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong RaygenShaderRecordAddress;

    [NativeName("raygenShaderRecordSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong RaygenShaderRecordSize;

    [NativeName("missShaderBindingTableAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong MissShaderBindingTableAddress;

    [NativeName("missShaderBindingTableSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong MissShaderBindingTableSize;

    [NativeName("missShaderBindingTableStride")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong MissShaderBindingTableStride;

    [NativeName("hitShaderBindingTableAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong HitShaderBindingTableAddress;

    [NativeName("hitShaderBindingTableSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong HitShaderBindingTableSize;

    [NativeName("hitShaderBindingTableStride")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong HitShaderBindingTableStride;

    [NativeName("callableShaderBindingTableAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong CallableShaderBindingTableAddress;

    [NativeName("callableShaderBindingTableSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong CallableShaderBindingTableSize;

    [NativeName("callableShaderBindingTableStride")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong CallableShaderBindingTableStride;

    [NativeName("width")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public uint Width;

    [NativeName("height")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public uint Height;

    [NativeName("depth")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public uint Depth;
}
