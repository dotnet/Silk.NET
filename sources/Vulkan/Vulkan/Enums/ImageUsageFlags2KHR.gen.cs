// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageUsageFlags2KHR")]
[Flags]
public enum ImageUsageFlags2KHR : ulong
{
    None = 0x0,

    [NativeName("VK_IMAGE_USAGE_2_TRANSFER_SRC_BIT_KHR")]
    TransferSrcBit = 0x1,

    [NativeName("VK_IMAGE_USAGE_2_TRANSFER_DST_BIT_KHR")]
    TransferDstBit = 0x2,

    [NativeName("VK_IMAGE_USAGE_2_SAMPLED_BIT_KHR")]
    SampledBit = 0x4,

    [NativeName("VK_IMAGE_USAGE_2_STORAGE_BIT_KHR")]
    StorageBit = 0x8,

    [NativeName("VK_IMAGE_USAGE_2_COLOR_ATTACHMENT_BIT_KHR")]
    ColorAttachmentBit = 0x10,

    [NativeName("VK_IMAGE_USAGE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR")]
    DepthStencilAttachmentBit = 0x20,

    [NativeName("VK_IMAGE_USAGE_2_TRANSIENT_ATTACHMENT_BIT_KHR")]
    TransientAttachmentBit = 0x40,

    [NativeName("VK_IMAGE_USAGE_2_INPUT_ATTACHMENT_BIT_KHR")]
    InputAttachmentBit = 0x80,

    [NativeName("VK_IMAGE_USAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    FragmentShadingRateAttachmentBit = 0x100,

    [NativeName("VK_IMAGE_USAGE_2_FRAGMENT_DENSITY_MAP_BIT_EXT")]
    FragmentDensityMapBitEXT = 0x200,

    [NativeName("VK_IMAGE_USAGE_2_VIDEO_DECODE_DST_BIT_KHR")]
    VideoDecodeDstBit = 0x400,

    [NativeName("VK_IMAGE_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR")]
    VideoDecodeSrcBit = 0x800,

    [NativeName("VK_IMAGE_USAGE_2_VIDEO_DECODE_DPB_BIT_KHR")]
    VideoDecodeDpbBit = 0x1000,

    [NativeName("VK_IMAGE_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR")]
    VideoEncodeDstBit = 0x2000,

    [NativeName("VK_IMAGE_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR")]
    VideoEncodeSrcBit = 0x4000,

    [NativeName("VK_IMAGE_USAGE_2_VIDEO_ENCODE_DPB_BIT_KHR")]
    VideoEncodeDpbBit = 0x8000,

    [NativeName("VK_IMAGE_USAGE_2_INVOCATION_MASK_BIT_HUAWEI")]
    InvocationMaskBitHUAWEI = 0x40000,

    [NativeName("VK_IMAGE_USAGE_2_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT")]
    AttachmentFeedbackLoopBitEXT = 0x80000,

    [NativeName("VK_IMAGE_USAGE_2_SAMPLE_WEIGHT_BIT_QCOM")]
    SampleWeightBitQCOM = 0x100000,

    [NativeName("VK_IMAGE_USAGE_2_SAMPLE_BLOCK_MATCH_BIT_QCOM")]
    SampleBlockMatchBitQCOM = 0x200000,

    [NativeName("VK_IMAGE_USAGE_2_HOST_TRANSFER_BIT_KHR")]
    HostTransferBit = 0x400000,

    [NativeName("VK_IMAGE_USAGE_2_TENSOR_ALIASING_BIT_ARM")]
    TensorAliasingBitARM = 0x800000,

    [NativeName("VK_IMAGE_USAGE_2_VIDEO_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR")]
    VideoEncodeQuantizationDeltaMapBit = 0x2000000,

    [NativeName("VK_IMAGE_USAGE_2_VIDEO_ENCODE_EMPHASIS_MAP_BIT_KHR")]
    VideoEncodeEmphasisMapBit = 0x4000000,

    [NativeName("VK_IMAGE_USAGE_2_TILE_MEMORY_BIT_QCOM")]
    TileMemoryBitQCOM = 0x8000000,
}
