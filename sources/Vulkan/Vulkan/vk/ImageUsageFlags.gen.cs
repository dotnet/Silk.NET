// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageUsageFlags")]
[Flags]
public enum ImageUsageFlags : uint
{
    None = 0x0,

    [NativeName("VK_IMAGE_USAGE_TRANSFER_SRC_BIT")]
    TransferSrcBit = 0x1,

    [NativeName("VK_IMAGE_USAGE_TRANSFER_DST_BIT")]
    TransferDstBit = 0x2,

    [NativeName("VK_IMAGE_USAGE_SAMPLED_BIT")]
    SampledBit = 0x4,

    [NativeName("VK_IMAGE_USAGE_STORAGE_BIT")]
    StorageBit = 0x8,

    [NativeName("VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT")]
    ColorAttachmentBit = 0x10,

    [NativeName("VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT")]
    DepthStencilAttachmentBit = 0x20,

    [NativeName("VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT")]
    TransientAttachmentBit = 0x40,

    [NativeName("VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT")]
    InputAttachmentBit = 0x80,

    [NativeName("VK_IMAGE_USAGE_HOST_TRANSFER_BIT")]
    HostTransferBit = 0x400000,

    [NativeName("VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR")]
    VideoDecodeDstBitKHR = 0x400,

    [NativeName("VK_IMAGE_USAGE_VIDEO_DECODE_SRC_BIT_KHR")]
    VideoDecodeSrcBitKHR = 0x800,

    [NativeName("VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR")]
    VideoDecodeDpbBitKHR = 0x1000,

    [NativeName("VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT")]
    FragmentDensityMapBitEXT = 0x200,

    [NativeName("VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    FragmentShadingRateAttachmentBitKHR = 0x100,

    [NativeName("VK_IMAGE_USAGE_VIDEO_ENCODE_DST_BIT_KHR")]
    VideoEncodeDstBitKHR = 0x2000,

    [NativeName("VK_IMAGE_USAGE_VIDEO_ENCODE_SRC_BIT_KHR")]
    VideoEncodeSrcBitKHR = 0x4000,

    [NativeName("VK_IMAGE_USAGE_VIDEO_ENCODE_DPB_BIT_KHR")]
    VideoEncodeDpbBitKHR = 0x8000,

    [NativeName("VK_IMAGE_USAGE_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    AttachmentFeedbackLoopBitEXT = 0x80000,

    [NativeName("VK_IMAGE_USAGE_INVOCATION_MASK_BIT_HUAWEI")]
    InvocationMaskBitHUAWEI = 0x40000,

    [NativeName("VK_IMAGE_USAGE_SAMPLE_WEIGHT_BIT_QCOM")]
    SampleWeightBitQCOM = 0x100000,

    [NativeName("VK_IMAGE_USAGE_SAMPLE_BLOCK_MATCH_BIT_QCOM")]
    SampleBlockMatchBitQCOM = 0x200000,

    [NativeName("VK_IMAGE_USAGE_TENSOR_ALIASING_BIT_ARM")]
    TensorAliasingBitARM = 0x800000,

    [NativeName("VK_IMAGE_USAGE_TILE_MEMORY_BIT_QCOM")]
    TileMemoryBitQCOM = 0x8000000,

    [NativeName("VK_IMAGE_USAGE_VIDEO_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR")]
    VideoEncodeQuantizationDeltaMapBitKHR = 0x2000000,

    [NativeName("VK_IMAGE_USAGE_VIDEO_ENCODE_EMPHASIS_MAP_BIT_KHR")]
    VideoEncodeEmphasisMapBitKHR = 0x4000000,

    [NativeName("VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV")]
    ShadingRateImageBitNV = FragmentShadingRateAttachmentBitKHR,

    [NativeName("VK_IMAGE_USAGE_HOST_TRANSFER_BIT_EXT")]
    HostTransferBitEXT = HostTransferBit,
}
