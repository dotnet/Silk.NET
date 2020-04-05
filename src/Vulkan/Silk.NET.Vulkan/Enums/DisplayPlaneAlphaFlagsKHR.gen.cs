// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum DisplayPlaneAlphaFlagsKHR
    {
        DisplayPlaneAlphaOpaqueBitKhr = 1,
        DisplayPlaneAlphaGlobalBitKhr = 2,
        DisplayPlaneAlphaPerPixelBitKhr = 4,
        DisplayPlaneAlphaPerPixelPremultipliedBitKhr = 8,
    }
}
