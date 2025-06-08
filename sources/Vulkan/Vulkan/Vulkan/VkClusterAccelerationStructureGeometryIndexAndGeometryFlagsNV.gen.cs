// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV
{
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
    public uint geometryIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeTypeName("uint32_t : 5")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 24) & 0x1Fu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1Fu << 24)) | ((value & 0x1Fu) << 24); }
    }

    [NativeTypeName("uint32_t : 3")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public uint geometryFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 29) & 0x7u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x7u << 29)) | ((value & 0x7u) << 29); }
    }
}
