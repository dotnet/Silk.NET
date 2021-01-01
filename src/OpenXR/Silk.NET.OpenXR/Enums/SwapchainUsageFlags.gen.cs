// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    [NativeName("Name", "XrSwapchainUsageFlags")]
    public enum SwapchainUsageFlags : int
    {
        [NativeName("Name", "XR_SWAPCHAIN_USAGE_COLOR_ATTACHMENT_BIT")]
        SwapchainUsageColorAttachmentBit = 1,
        [NativeName("Name", "XR_SWAPCHAIN_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT")]
        SwapchainUsageDepthStencilAttachmentBit = 2,
        [NativeName("Name", "XR_SWAPCHAIN_USAGE_UNORDERED_ACCESS_BIT")]
        SwapchainUsageUnorderedAccessBit = 4,
        [NativeName("Name", "XR_SWAPCHAIN_USAGE_TRANSFER_SRC_BIT")]
        SwapchainUsageTransferSrcBit = 8,
        [NativeName("Name", "XR_SWAPCHAIN_USAGE_TRANSFER_DST_BIT")]
        SwapchainUsageTransferDstBit = 16,
        [NativeName("Name", "XR_SWAPCHAIN_USAGE_SAMPLED_BIT")]
        SwapchainUsageSampledBit = 32,
        [NativeName("Name", "XR_SWAPCHAIN_USAGE_MUTABLE_FORMAT_BIT")]
        SwapchainUsageMutableFormatBit = 64,
        [NativeName("Name", "XR_SWAPCHAIN_USAGE_INPUT_ATTACHMENT_BIT_MND")]
        SwapchainUsageInputAttachmentBitMnd = 128,
    }
}
