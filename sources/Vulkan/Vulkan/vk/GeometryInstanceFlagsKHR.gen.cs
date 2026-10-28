// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGeometryInstanceFlagsKHR")]
[Flags]
public enum GeometryInstanceFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR")]
    TriangleFacingCullDisableBit = 0x1,

    [NativeName("VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR")]
    TriangleFlipFacingBit = 0x2,

    [NativeName("VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR")]
    ForceOpaqueBit = 0x4,

    [NativeName("VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR")]
    ForceNoOpaqueBit = 0x8,

    [NativeName("VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_BIT_KHR")]
    ForceOpacityMicromap2StateBit = 0x10,

    [NativeName("VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_BIT_KHR")]
    DisableOpacityMicromapsBit = 0x20,

    [NativeName("VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR")]
    TriangleFrontCounterclockwiseBit = TriangleFlipFacingBit,

    [NativeName("VK_GEOMETRY_INSTANCE_TRIANGLE_CULL_DISABLE_BIT_NV")]
    TriangleCullDisableBitNV = TriangleFacingCullDisableBit,

    [NativeName("VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV")]
    TriangleFrontCounterclockwiseBitNV = TriangleFrontCounterclockwiseBit,

    [NativeName("VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_NV")]
    ForceOpaqueBitNV = ForceOpaqueBit,

    [NativeName("VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_NV")]
    ForceNoOpaqueBitNV = ForceNoOpaqueBit,

    [NativeName("VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_BIT_EXT")]
    ForceOpacityMicromap2StateBitEXT = ForceOpacityMicromap2StateBit,

    [NativeName("VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_BIT_EXT")]
    DisableOpacityMicromapsBitEXT = DisableOpacityMicromapsBit,
}
