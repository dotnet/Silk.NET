// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureMotionInstanceDataNV")]
[StructLayout(LayoutKind.Explicit)]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public partial struct VkAccelerationStructureMotionInstanceDataNV
{
    [NativeName("staticInstance")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public VkAccelerationStructureInstanceKHR StaticInstance;

    [NativeName("matrixMotionInstance")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public VkAccelerationStructureMatrixMotionInstanceNV MatrixMotionInstance;

    [NativeName("srtMotionInstance")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing_motion_blur"],
        ImpliesSets = ["VK_KHR_ray_tracing_pipeline"]
    )]
    public VkAccelerationStructureSrtMotionInstanceNV SrtMotionInstance;
}
