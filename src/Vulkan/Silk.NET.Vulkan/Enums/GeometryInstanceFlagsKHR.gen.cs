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
        [Obsolete("Deprecated in favour of \"Reserved4BitNV\"")]
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_RESERVED_4_BIT_NV")]
        GeometryInstanceReserved4BitNV = 16,
        [Obsolete("Deprecated in favour of \"Reserved5BitNV\"")]
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_RESERVED_5_BIT_NV")]
        GeometryInstanceReserved5BitNV = 32,
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
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_RESERVED_4_BIT_NV")]
        Reserved4BitNV = 16,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_RESERVED_5_BIT_NV")]
        Reserved5BitNV = 32,
    }
}
