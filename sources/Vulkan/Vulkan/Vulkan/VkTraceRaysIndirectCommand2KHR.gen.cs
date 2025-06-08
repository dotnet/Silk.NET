// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkTraceRaysIndirectCommand2KHR
{
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong raygenShaderRecordAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong raygenShaderRecordSize;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong missShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong missShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong missShaderBindingTableStride;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong hitShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong hitShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong hitShaderBindingTableStride;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong callableShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong callableShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public ulong callableShaderBindingTableStride;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public uint width;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public uint height;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_maintenance1", "VK_KHR_ray_tracing_pipeline"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public uint depth;
}
