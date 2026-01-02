// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceClusterCullingShaderPropertiesHuawei
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceClusterCullingShaderPropertiesHuaweiMaxWorkGroupCount MaxWorkGroupCount;

    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceClusterCullingShaderPropertiesHuaweiMaxWorkGroupSize MaxWorkGroupSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MaxOutputClusterCount;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    public ulong IndirectBufferOffsetAlignment;
}
