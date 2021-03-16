// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkGeometryInstanceFlagsNV")]
    public enum GeometryInstanceFlagsNV : int
    {
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR")]
        GeometryInstanceTriangleFacingCullDisableBitKhr = 1,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR")]
        GeometryInstanceTriangleFrontCounterclockwiseBitKhr = 2,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR")]
        GeometryInstanceForceOpaqueBitKhr = 4,
        [NativeName("Name", "VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR")]
        GeometryInstanceForceNoOpaqueBitKhr = 8,
    }
}
