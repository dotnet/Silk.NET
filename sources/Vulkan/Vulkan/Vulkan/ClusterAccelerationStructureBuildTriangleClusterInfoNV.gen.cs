// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkClusterAccelerationStructureBuildTriangleClusterInfoNV")]
[SupportedApiProfile("vulkan")]
public partial struct ClusterAccelerationStructureBuildTriangleClusterInfoNV
{
    [NativeName("clusterID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint ClusterID;

    [NativeName("clusterFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ClusterAccelerationStructureClusterFlagsNV ClusterFlags;

    [NativeName("_bitfield")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint Bitfield;

    [NativeName("triangleCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint TriangleCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0x1FFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0x1FFu) | (value & 0x1FFu); }
    }

    [NativeName("vertexCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint VertexCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 9) & 0x1FFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1FFu << 9)) | ((value & 0x1FFu) << 9); }
    }

    [NativeName("positionTruncateBitCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint PositionTruncateBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 18) & 0x3Fu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x3Fu << 18)) | ((value & 0x3Fu) << 18); }
    }

    [NativeName("indexType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint IndexType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 24) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0xFu << 24)) | ((value & 0xFu) << 24); }
    }

    [NativeName("opacityMicromapIndexType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint OpacityMicromapIndexType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 28) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0xFu << 28)) | ((value & 0xFu) << 28); }
    }

    [NativeName("baseGeometryIndexAndGeometryFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV BaseGeometryIndexAndGeometryFlags;

    [NativeName("indexBufferStride")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort IndexBufferStride;

    [NativeName("vertexBufferStride")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort VertexBufferStride;

    [NativeName("geometryIndexAndFlagsBufferStride")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort GeometryIndexAndFlagsBufferStride;

    [NativeName("opacityMicromapIndexBufferStride")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort OpacityMicromapIndexBufferStride;

    [NativeName("indexBuffer")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong IndexBuffer;

    [NativeName("vertexBuffer")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong VertexBuffer;

    [NativeName("geometryIndexAndFlagsBuffer")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong GeometryIndexAndFlagsBuffer;

    [NativeName("opacityMicromapArray")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong OpacityMicromapArray;

    [NativeName("opacityMicromapIndexBuffer")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong OpacityMicromapIndexBuffer;
}
