// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPointClippingBehaviorKHR")]
    public enum PointClippingBehaviorKHR
    {
        [NativeName("Name", "VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES")]
        PointClippingBehaviorAllClipPlanes = 0,
        [NativeName("Name", "VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY")]
        PointClippingBehaviorUserClipPlanesOnly = 1,
    }
}
