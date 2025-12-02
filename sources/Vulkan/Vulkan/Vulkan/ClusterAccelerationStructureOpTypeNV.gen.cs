// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkClusterAccelerationStructureOpTypeNV")]
[SupportedApiProfile("vulkan")]
public enum ClusterAccelerationStructureOpTypeNV : uint
{
    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_MOVE_OBJECTS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    MoveObjects = 0,

    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_CLUSTERS_BOTTOM_LEVEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    BuildClustersBottomLevel = 1,

    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_TRIANGLE_CLUSTER_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    BuildTriangleCluster = 2,

    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_TRIANGLE_CLUSTER_TEMPLATE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    BuildTriangleClusterTemplate = 3,

    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_INSTANTIATE_TRIANGLE_CLUSTER_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    InstantiateTriangleCluster = 4,

    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_GET_CLUSTER_TEMPLATE_INDICES_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    GetClusterTemplateIndices = 5,
}
