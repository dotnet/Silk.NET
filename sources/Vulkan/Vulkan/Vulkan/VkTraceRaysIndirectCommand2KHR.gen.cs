// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTraceRaysIndirectCommand2KHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public partial struct VkTraceRaysIndirectCommand2KHR
{
    [NativeName("raygenShaderRecordAddress")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong RaygenShaderRecordAddress;

    [NativeName("raygenShaderRecordSize")]
    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong RaygenShaderRecordSize;

    [NativeName("missShaderBindingTableAddress")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong MissShaderBindingTableAddress;

    [NativeName("missShaderBindingTableSize")]
    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong MissShaderBindingTableSize;

    [NativeName("missShaderBindingTableStride")]
    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong MissShaderBindingTableStride;

    [NativeName("hitShaderBindingTableAddress")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong HitShaderBindingTableAddress;

    [NativeName("hitShaderBindingTableSize")]
    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong HitShaderBindingTableSize;

    [NativeName("hitShaderBindingTableStride")]
    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong HitShaderBindingTableStride;

    [NativeName("callableShaderBindingTableAddress")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong CallableShaderBindingTableAddress;

    [NativeName("callableShaderBindingTableSize")]
    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong CallableShaderBindingTableSize;

    [NativeName("callableShaderBindingTableStride")]
    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong CallableShaderBindingTableStride;

    [NativeName("width")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public uint Width;

    [NativeName("height")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public uint Height;

    [NativeName("depth")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public uint Depth;
}
