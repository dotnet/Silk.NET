// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkImageUsageFlags")]
    public enum ImageUsageFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TransferSrcBit\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_TRANSFER_SRC_BIT")]
        ImageUsageTransferSrcBit = 1,
        [Obsolete("Deprecated in favour of \"TransferDstBit\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_TRANSFER_DST_BIT")]
        ImageUsageTransferDstBit = 2,
        [Obsolete("Deprecated in favour of \"SampledBit\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_SAMPLED_BIT")]
        ImageUsageSampledBit = 4,
        [Obsolete("Deprecated in favour of \"StorageBit\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_STORAGE_BIT")]
        ImageUsageStorageBit = 8,
        [Obsolete("Deprecated in favour of \"ColorAttachmentBit\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT")]
        ImageUsageColorAttachmentBit = 16,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentBit\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT")]
        ImageUsageDepthStencilAttachmentBit = 32,
        [Obsolete("Deprecated in favour of \"TransientAttachmentBit\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT")]
        ImageUsageTransientAttachmentBit = 64,
        [Obsolete("Deprecated in favour of \"InputAttachmentBit\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT")]
        ImageUsageInputAttachmentBit = 128,
        [Obsolete("Deprecated in favour of \"VideoDecodeDstBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR")]
        ImageUsageVideoDecodeDstBitKhr = 1024,
        [Obsolete("Deprecated in favour of \"VideoDecodeSrcBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_DECODE_SRC_BIT_KHR")]
        ImageUsageVideoDecodeSrcBitKhr = 2048,
        [Obsolete("Deprecated in favour of \"VideoDecodeDpbBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR")]
        ImageUsageVideoDecodeDpbBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"ShadingRateImageBitNV\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV")]
        ImageUsageShadingRateImageBitNV = 256,
        [Obsolete("Deprecated in favour of \"FragmentDensityMapBitExt\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT")]
        ImageUsageFragmentDensityMapBitExt = 512,
        [Obsolete("Deprecated in favour of \"FragmentShadingRateAttachmentBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        ImageUsageFragmentShadingRateAttachmentBitKhr = 256,
        [Obsolete("Deprecated in favour of \"HostTransferBitExt\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_HOST_TRANSFER_BIT_EXT")]
        ImageUsageHostTransferBitExt = 4194304,
        [Obsolete("Deprecated in favour of \"VideoEncodeDstBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_ENCODE_DST_BIT_KHR")]
        ImageUsageVideoEncodeDstBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"VideoEncodeSrcBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_ENCODE_SRC_BIT_KHR")]
        ImageUsageVideoEncodeSrcBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"VideoEncodeDpbBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_ENCODE_DPB_BIT_KHR")]
        ImageUsageVideoEncodeDpbBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"AttachmentFeedbackLoopBitExt\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        ImageUsageAttachmentFeedbackLoopBitExt = 524288,
        [Obsolete("Deprecated in favour of \"InvocationMaskBitHuawei\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_INVOCATION_MASK_BIT_HUAWEI")]
        ImageUsageInvocationMaskBitHuawei = 262144,
        [Obsolete("Deprecated in favour of \"SampleWeightBitQCom\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_SAMPLE_WEIGHT_BIT_QCOM")]
        ImageUsageSampleWeightBitQCom = 1048576,
        [Obsolete("Deprecated in favour of \"SampleBlockMatchBitQCom\"")]
        [NativeName("Name", "VK_IMAGE_USAGE_SAMPLE_BLOCK_MATCH_BIT_QCOM")]
        ImageUsageSampleBlockMatchBitQCom = 2097152,
        [NativeName("Name", "VK_IMAGE_USAGE_TRANSFER_SRC_BIT")]
        TransferSrcBit = 1,
        [NativeName("Name", "VK_IMAGE_USAGE_TRANSFER_DST_BIT")]
        TransferDstBit = 2,
        [NativeName("Name", "VK_IMAGE_USAGE_SAMPLED_BIT")]
        SampledBit = 4,
        [NativeName("Name", "VK_IMAGE_USAGE_STORAGE_BIT")]
        StorageBit = 8,
        [NativeName("Name", "VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT")]
        ColorAttachmentBit = 16,
        [NativeName("Name", "VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT")]
        DepthStencilAttachmentBit = 32,
        [NativeName("Name", "VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT")]
        TransientAttachmentBit = 64,
        [NativeName("Name", "VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT")]
        InputAttachmentBit = 128,
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR")]
        VideoDecodeDstBitKhr = 1024,
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_DECODE_SRC_BIT_KHR")]
        VideoDecodeSrcBitKhr = 2048,
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR")]
        VideoDecodeDpbBitKhr = 4096,
        [NativeName("Name", "VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV")]
        ShadingRateImageBitNV = 256,
        [NativeName("Name", "VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT")]
        FragmentDensityMapBitExt = 512,
        [NativeName("Name", "VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        FragmentShadingRateAttachmentBitKhr = 256,
        [NativeName("Name", "VK_IMAGE_USAGE_HOST_TRANSFER_BIT_EXT")]
        HostTransferBitExt = 4194304,
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_ENCODE_DST_BIT_KHR")]
        VideoEncodeDstBitKhr = 8192,
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_ENCODE_SRC_BIT_KHR")]
        VideoEncodeSrcBitKhr = 16384,
        [NativeName("Name", "VK_IMAGE_USAGE_VIDEO_ENCODE_DPB_BIT_KHR")]
        VideoEncodeDpbBitKhr = 32768,
        [NativeName("Name", "VK_IMAGE_USAGE_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
        AttachmentFeedbackLoopBitExt = 524288,
        [NativeName("Name", "VK_IMAGE_USAGE_INVOCATION_MASK_BIT_HUAWEI")]
        InvocationMaskBitHuawei = 262144,
        [NativeName("Name", "VK_IMAGE_USAGE_SAMPLE_WEIGHT_BIT_QCOM")]
        SampleWeightBitQCom = 1048576,
        [NativeName("Name", "VK_IMAGE_USAGE_SAMPLE_BLOCK_MATCH_BIT_QCOM")]
        SampleBlockMatchBitQCom = 2097152,
    }
}
