// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkClusterAccelerationStructureBuildTriangleClusterInfoNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public partial struct VkClusterAccelerationStructureBuildTriangleClusterInfoNV
{
    [NativeName("clusterID")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint ClusterID;

    [NativeName("clusterFlags")]
    [NativeTypeName("VkClusterAccelerationStructureClusterFlagsNV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public VkClusterAccelerationStructureClusterFlagsNV ClusterFlags;

    [NativeName("_bitfield")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint Bitfield;

    [NativeName("triangleCount")]
    [NativeTypeName("uint32_t : 9")]
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
    [NativeTypeName("uint32_t : 9")]
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
    [NativeTypeName("uint32_t : 6")]
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
    [NativeTypeName("uint32_t : 4")]
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
    [NativeTypeName("uint32_t : 4")]
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
    public VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV BaseGeometryIndexAndGeometryFlags;

    [NativeName("indexBufferStride")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort IndexBufferStride;

    [NativeName("vertexBufferStride")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort VertexBufferStride;

    [NativeName("geometryIndexAndFlagsBufferStride")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort GeometryIndexAndFlagsBufferStride;

    [NativeName("opacityMicromapIndexBufferStride")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ushort OpacityMicromapIndexBufferStride;

    [NativeName("indexBuffer")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong IndexBuffer;

    [NativeName("vertexBuffer")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong VertexBuffer;

    [NativeName("geometryIndexAndFlagsBuffer")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong GeometryIndexAndFlagsBuffer;

    [NativeName("opacityMicromapArray")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong OpacityMicromapArray;

    [NativeName("opacityMicromapIndexBuffer")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong OpacityMicromapIndexBuffer;
}
