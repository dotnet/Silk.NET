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
    [NativeName("Name", "VkGeometryFlagsNV")]
    public enum GeometryFlagsNV
    {
        [NativeName("Name", "VK_GEOMETRY_OPAQUE_BIT_KHR")]
        GeometryOpaqueBitKhr = 1,
        [NativeName("Name", "VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR")]
        GeometryNoDuplicateAnyHitInvocationBitKhr = 2,
    }
}
