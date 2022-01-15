// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkGeometryFlagsKHR")]
    public enum GeometryFlagsKHR : int
    {
        [NativeName("Name", "VK_GEOMETRY_OPAQUE_BIT_KHR")]
        GeometryOpaqueBitKhr = 1,
        [NativeName("Name", "VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR")]
        GeometryNoDuplicateAnyHitInvocationBitKhr = 2,
    }
}
