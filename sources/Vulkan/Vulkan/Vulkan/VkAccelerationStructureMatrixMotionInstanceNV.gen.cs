// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkAccelerationStructureMatrixMotionInstanceNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public VkTransformMatrixKHR transformT0;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public VkTransformMatrixKHR transformT1;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public uint _bitfield1;

    [NativeTypeName("uint32_t : 24")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public uint instanceCustomIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield1 & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeTypeName("uint32_t : 8")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public uint mask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield1 >> 24) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
    }

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public uint _bitfield2;

    [NativeTypeName("uint32_t : 24")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public uint instanceShaderBindingTableRecordOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield2 & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeTypeName("VkGeometryInstanceFlagsKHR : 8")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public uint flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield2 >> 24) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
    }

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public ulong accelerationStructureReference;
}
