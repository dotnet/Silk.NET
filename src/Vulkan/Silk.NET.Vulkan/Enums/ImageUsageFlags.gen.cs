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
    [NativeName("Name", "VkImageUsageFlags")]
    public enum ImageUsageFlags : int
    {
        [NativeName("Name", "VK_IMAGE_USAGE_TRANSFER_SRC_BIT")]
        ImageUsageTransferSrcBit = 1,
        [NativeName("Name", "VK_IMAGE_USAGE_TRANSFER_DST_BIT")]
        ImageUsageTransferDstBit = 2,
        [NativeName("Name", "VK_IMAGE_USAGE_SAMPLED_BIT")]
        ImageUsageSampledBit = 4,
        [NativeName("Name", "VK_IMAGE_USAGE_STORAGE_BIT")]
        ImageUsageStorageBit = 8,
        [NativeName("Name", "VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT")]
        ImageUsageColorAttachmentBit = 16,
        [NativeName("Name", "VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT")]
        ImageUsageDepthStencilAttachmentBit = 32,
        [NativeName("Name", "VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT")]
        ImageUsageTransientAttachmentBit = 64,
        [NativeName("Name", "VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT")]
        ImageUsageInputAttachmentBit = 128,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_13_BIT_KHR")]
        ImageUsageReserved13BitKhr = 8192,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_14_BIT_KHR")]
        ImageUsageReserved14BitKhr = 16384,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_15_BIT_KHR")]
        ImageUsageReserved15BitKhr = 32768,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_10_BIT_KHR")]
        ImageUsageReserved10BitKhr = 1024,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_11_BIT_KHR")]
        ImageUsageReserved11BitKhr = 2048,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_12_BIT_KHR")]
        ImageUsageReserved12BitKhr = 4096,
        [NativeName("Name", "VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV")]
        ImageUsageShadingRateImageBitNV = 256,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_16_BIT_QCOM")]
        ImageUsageReserved16BitQCom = 65536,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_17_BIT_QCOM")]
        ImageUsageReserved17BitQCom = 131072,
        [NativeName("Name", "VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT")]
        ImageUsageFragmentDensityMapBitExt = 512,
        [NativeName("Name", "VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        ImageUsageFragmentShadingRateAttachmentBitKhr = 256,
    }
}
