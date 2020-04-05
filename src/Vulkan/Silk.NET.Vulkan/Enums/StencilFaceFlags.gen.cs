// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum StencilFaceFlags
    {
        StencilFaceFrontBit = 1,
        StencilFaceBackBit = 2,
        StencilFaceFrontAndBack = 3,
        StencilFrontAndBack = 3,
    }
}
