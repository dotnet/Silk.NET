// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPointClippingBehavior")]
    public enum PointClippingBehavior : int
    {
        [NativeName("Name", "VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES")]
        AllClipPlanes = 0,
        [NativeName("Name", "VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY")]
        UserClipPlanesOnly = 1,
    }
}
