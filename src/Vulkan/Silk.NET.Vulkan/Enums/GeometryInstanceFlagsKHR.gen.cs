// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkGeometryInstanceFlagsKHR")]
    public enum GeometryInstanceFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TriangleFacingCullDisableBitKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR")]
        GeometryInstanceTriangleFacingCullDisableBitKhr = 1,
        [Obsolete("Deprecated in favour of \"TriangleFlipFacingBitKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR")]
        GeometryInstanceTriangleFlipFacingBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ForceOpaqueBitKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR")]
        GeometryInstanceForceOpaqueBitKhr = 4,
        [Obsolete("Deprecated in favour of \"ForceNoOpaqueBitKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR")]
        GeometryInstanceForceNoOpaqueBitKhr = 8,
        [Obsolete("Deprecated in favour of \"TriangleFrontCounterclockwiseBitKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR")]
        GeometryInstanceTriangleFrontCounterclockwiseBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ForceOpacityMicromap2StateExt\"")]
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_EXT")]
        GeometryInstanceForceOpacityMicromap2StateExt = 16,
        [Obsolete("Deprecated in favour of \"DisableOpacityMicromapsExt\"")]
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_EXT")]
        GeometryInstanceDisableOpacityMicromapsExt = 32,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR")]
        TriangleFacingCullDisableBitKhr = 1,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR")]
        TriangleFlipFacingBitKhr = 2,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR")]
        ForceOpaqueBitKhr = 4,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR")]
        ForceNoOpaqueBitKhr = 8,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR")]
        TriangleFrontCounterclockwiseBitKhr = 2,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_EXT")]
        ForceOpacityMicromap2StateExt = 16,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_EXT")]
        DisableOpacityMicromapsExt = 32,
    }
}
