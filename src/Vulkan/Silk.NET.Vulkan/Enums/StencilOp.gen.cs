// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkStencilOp")]
    public enum StencilOp
    {
        [NativeName("Name", "VK_STENCIL_OP_KEEP")]
        Keep = 0,
        [NativeName("Name", "VK_STENCIL_OP_ZERO")]
        Zero = 1,
        [NativeName("Name", "VK_STENCIL_OP_REPLACE")]
        Replace = 2,
        [NativeName("Name", "VK_STENCIL_OP_INCREMENT_AND_CLAMP")]
        IncrementAndClamp = 3,
        [NativeName("Name", "VK_STENCIL_OP_DECREMENT_AND_CLAMP")]
        DecrementAndClamp = 4,
        [NativeName("Name", "VK_STENCIL_OP_INVERT")]
        Invert = 5,
        [NativeName("Name", "VK_STENCIL_OP_INCREMENT_AND_WRAP")]
        IncrementAndWrap = 6,
        [NativeName("Name", "VK_STENCIL_OP_DECREMENT_AND_WRAP")]
        DecrementAndWrap = 7,
    }
}
