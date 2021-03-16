// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFrontFace")]
    public enum FrontFace : int
    {
        [NativeName("Name", "VK_FRONT_FACE_COUNTER_CLOCKWISE")]
        CounterClockwise = 0,
        [NativeName("Name", "VK_FRONT_FACE_CLOCKWISE")]
        Clockwise = 1,
    }
}
