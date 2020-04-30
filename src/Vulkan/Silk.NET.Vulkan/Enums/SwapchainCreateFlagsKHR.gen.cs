// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum SwapchainCreateFlagsKHR
    {
        SwapchainCreateSplitInstanceBindRegionsBitKhr = 1,
        SwapchainCreateProtectedBitKhr = 2,
        SwapchainCreateMutableFormatBitKhr = 4,
    }
}
