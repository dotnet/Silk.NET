// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    public enum SwapchainUsageFlags
    {
        SwapchainUsageColorAttachmentBit = 1,
        SwapchainUsageDepthStencilAttachmentBit = 2,
        SwapchainUsageUnorderedAccessBit = 4,
        SwapchainUsageTransferSrcBit = 8,
        SwapchainUsageTransferDstBit = 16,
        SwapchainUsageSampledBit = 32,
        SwapchainUsageMutableFormatBit = 64,
    }
}
