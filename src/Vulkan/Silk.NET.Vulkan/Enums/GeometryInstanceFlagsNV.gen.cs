// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkGeometryInstanceFlagsNV")]
    public enum GeometryInstanceFlagsNV : int
    {
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR")]
        GeometryInstanceTriangleFacingCullDisableBitKhr = 1,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR")]
        GeometryInstanceTriangleFlipFacingBitKhr = 2,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR")]
        GeometryInstanceForceOpaqueBitKhr = 4,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR")]
        GeometryInstanceForceNoOpaqueBitKhr = 8,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR")]
        GeometryInstanceTriangleFrontCounterclockwiseBitKhr = 2,
    }
}
