// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkClusterAccelerationStructureTriangleClusterInputNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public void* pNext;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public VkFormat vertexFormat;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint maxGeometryIndexValue;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint maxClusterUniqueGeometryCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint maxClusterTriangleCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint maxClusterVertexCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint maxTotalTriangleCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint maxTotalVertexCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint minPositionTruncateBitCount;
}
