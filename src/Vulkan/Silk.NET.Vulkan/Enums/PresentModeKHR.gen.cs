// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    public enum PresentModeKHR
    {
        PresentModeImmediateKhr = 0,
        PresentModeMailboxKhr = 1,
        PresentModeFifoKhr = 2,
        PresentModeFifoRelaxedKhr = 3,
        PresentModeSharedDemandRefreshKhr = 1000111000,
        PresentModeSharedContinuousRefreshKhr = 1000111001,
    }
}
