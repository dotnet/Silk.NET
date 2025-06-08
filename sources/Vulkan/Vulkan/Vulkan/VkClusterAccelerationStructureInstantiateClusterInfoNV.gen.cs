// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkClusterAccelerationStructureInstantiateClusterInfoNV
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint clusterIdOffset;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint _bitfield;

    [NativeTypeName("uint32_t : 24")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint geometryIndexOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeTypeName("uint32_t : 8")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 24) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
    }

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ulong clusterTemplateAddress;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public VkStridedDeviceAddressNV vertexBuffer;
}
