// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkClusterAccelerationStructureBuildTriangleClusterTemplateInfoNV
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint clusterID;

    [NativeTypeName("VkClusterAccelerationStructureClusterFlagsNV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint clusterFlags;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint _bitfield;

    [NativeTypeName("uint32_t : 9")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint triangleCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0x1FFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0x1FFu) | (value & 0x1FFu); }
    }

    [NativeTypeName("uint32_t : 9")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint vertexCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 9) & 0x1FFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1FFu << 9)) | ((value & 0x1FFu) << 9); }
    }

    [NativeTypeName("uint32_t : 6")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint positionTruncateBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 18) & 0x3Fu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x3Fu << 18)) | ((value & 0x3Fu) << 18); }
    }

    [NativeTypeName("uint32_t : 4")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint indexType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 24) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFu << 24)) | ((value & 0xFu) << 24); }
    }

    [NativeTypeName("uint32_t : 4")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint opacityMicromapIndexType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 28) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFu << 28)) | ((value & 0xFu) << 28); }
    }

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV baseGeometryIndexAndGeometryFlags;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort indexBufferStride;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort vertexBufferStride;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort geometryIndexAndFlagsBufferStride;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort opacityMicromapIndexBufferStride;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong indexBuffer;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong vertexBuffer;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong geometryIndexAndFlagsBuffer;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong opacityMicromapArray;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong opacityMicromapIndexBuffer;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong instantiationBoundingBoxLimit;
}
