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
    [NativeName("Name", "VkRenderPassCreateFlags")]
    public enum RenderPassCreateFlags : int
    {
        [NativeName("Name", "VK_RENDER_PASS_CREATE_RESERVED_0_BIT_KHR")]
        RenderPassCreateReserved0BitKhr = 1,
        [NativeName("Name", "VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM")]
        RenderPassCreateTransformBitQCom = 2,
    }
}
