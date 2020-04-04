// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ColorComponentFlags
    {
        ColorComponentRBit = 1,
        ColorComponentGBit = 2,
        ColorComponentBBit = 4,
        ColorComponentABit = 8,
    }
}
