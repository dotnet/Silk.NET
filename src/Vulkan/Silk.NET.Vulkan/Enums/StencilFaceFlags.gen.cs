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
    [NativeName("Name", "VkStencilFaceFlags")]
    public enum StencilFaceFlags
    {
        [NativeName("Name", "VK_STENCIL_FACE_FRONT_BIT")]
        StencilFaceFrontBit = 1,
        [NativeName("Name", "VK_STENCIL_FACE_BACK_BIT")]
        StencilFaceBackBit = 2,
        [NativeName("Name", "VK_STENCIL_FACE_FRONT_AND_BACK")]
        StencilFaceFrontAndBack = 3,
        [NativeName("Name", "VK_STENCIL_FRONT_AND_BACK")]
        StencilFrontAndBack = 3,
    }
}
