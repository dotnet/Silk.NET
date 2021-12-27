// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR")]
        ImageUsageVideoDecodeDstBitKhr = 1024,
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_DECODE_SRC_BIT_KHR")]
        ImageUsageVideoDecodeSrcBitKhr = 2048,
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR")]
        ImageUsageVideoDecodeDpbBitKhr = 4096,
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
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_ENCODE_DST_BIT_KHR")]
        ImageUsageVideoEncodeDstBitKhr = 8192,
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_ENCODE_SRC_BIT_KHR")]
        ImageUsageVideoEncodeSrcBitKhr = 16384,
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_ENCODE_DPB_BIT_KHR")]
        ImageUsageVideoEncodeDpbBitKhr = 32768,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_19_BIT_EXT")]
        ImageUsageReserved19BitExt = 524288,
        [NativeName("Name", "VK_IMAGE_USAGE_INVOCATION_MASK_BIT_HUAWEI")]
        ImageUsageInvocationMaskBitHuawei = 262144,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_20_BIT_QCOM")]
        ImageUsageReserved20BitQCom = 1048576,
        [NativeName("Name", "VK_IMAGE_USAGE_RESERVED_21_BIT_QCOM")]
        ImageUsageReserved21BitQCom = 2097152,
    }
}
