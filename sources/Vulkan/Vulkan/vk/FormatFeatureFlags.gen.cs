// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFormatFeatureFlags")]
[Flags]
public enum FormatFeatureFlags : uint
{
    None = 0x0,

    [NativeName("VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT")]
    SampledImageBit = 0x1,

    [NativeName("VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT")]
    StorageImageBit = 0x2,

    [NativeName("VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT")]
    StorageImageAtomicBit = 0x4,

    [NativeName("VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT")]
    UniformTexelBufferBit = 0x8,

    [NativeName("VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT")]
    StorageTexelBufferBit = 0x10,

    [NativeName("VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT")]
    StorageTexelBufferAtomicBit = 0x20,

    [NativeName("VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT")]
    VertexBufferBit = 0x40,

    [NativeName("VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT")]
    ColorAttachmentBit = 0x80,

    [NativeName("VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT")]
    ColorAttachmentBlendBit = 0x100,

    [NativeName("VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT")]
    DepthStencilAttachmentBit = 0x200,

    [NativeName("VK_FORMAT_FEATURE_BLIT_SRC_BIT")]
    BlitSrcBit = 0x400,

    [NativeName("VK_FORMAT_FEATURE_BLIT_DST_BIT")]
    BlitDstBit = 0x800,

    [NativeName("VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT")]
    SampledImageFilterLinearBit = 0x1000,

    [NativeName("VK_FORMAT_FEATURE_TRANSFER_SRC_BIT")]
    TransferSrcBit = 0x4000,

    [NativeName("VK_FORMAT_FEATURE_TRANSFER_DST_BIT")]
    TransferDstBit = 0x8000,

    [NativeName("VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT")]
    MidpointChromaSamplesBit = 0x20000,

    [NativeName("VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT")]
    SampledImageYcbcrConversionLinearFilterBit = 0x40000,

    [NativeName(
        "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT"
    )]
    SampledImageYcbcrConversionSeparateReconstructionFilterBit = 0x80000,

    [NativeName(
        "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT"
    )]
    SampledImageYcbcrConversionChromaReconstructionExplicitBit = 0x100000,

    [NativeName(
        "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT"
    )]
    SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 0x200000,

    [NativeName("VK_FORMAT_FEATURE_DISJOINT_BIT")]
    DisjointBit = 0x400000,

    [NativeName("VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT")]
    CositedChromaSamplesBit = 0x800000,

    [NativeName("VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT")]
    SampledImageFilterMinmaxBit = 0x10000,

    [NativeName("VK_FORMAT_FEATURE_VIDEO_DECODE_OUTPUT_BIT_KHR")]
    VideoDecodeOutputBitKHR = 0x2000000,

    [NativeName("VK_FORMAT_FEATURE_VIDEO_DECODE_DPB_BIT_KHR")]
    VideoDecodeDpbBitKHR = 0x4000000,

    [NativeName("VK_FORMAT_FEATURE_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR")]
    AccelerationStructureVertexBufferBitKHR = 0x20000000,

    [NativeName("VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT")]
    SampledImageFilterCubicBitEXT = 0x2000,

    [NativeName("VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT")]
    FragmentDensityMapBitEXT = 0x1000000,

    [NativeName("VK_FORMAT_FEATURE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    FragmentShadingRateAttachmentBitKHR = 0x40000000,

    [NativeName("VK_FORMAT_FEATURE_VIDEO_ENCODE_INPUT_BIT_KHR")]
    VideoEncodeInputBitKHR = 0x8000000,

    [NativeName("VK_FORMAT_FEATURE_VIDEO_ENCODE_DPB_BIT_KHR")]
    VideoEncodeDpbBitKHR = 0x10000000,

    [NativeName("VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG")]
    SampledImageFilterCubicBitIMG = SampledImageFilterCubicBitEXT,

    [NativeName("VK_FORMAT_FEATURE_TRANSFER_SRC_BIT_KHR")]
    TransferSrcBitKHR = TransferSrcBit,

    [NativeName("VK_FORMAT_FEATURE_TRANSFER_DST_BIT_KHR")]
    TransferDstBitKHR = TransferDstBit,

    [NativeName("VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT")]
    SampledImageFilterMinmaxBitEXT = SampledImageFilterMinmaxBit,

    [NativeName("VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT_KHR")]
    MidpointChromaSamplesBitKHR = MidpointChromaSamplesBit,

    [NativeName("VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR")]
    SampledImageYcbcrConversionLinearFilterBitKHR = SampledImageYcbcrConversionLinearFilterBit,

    [NativeName(
        "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR"
    )]
    SampledImageYcbcrConversionSeparateReconstructionFilterBitKHR =
        SampledImageYcbcrConversionSeparateReconstructionFilterBit,

    [NativeName(
        "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR"
    )]
    SampledImageYcbcrConversionChromaReconstructionExplicitBitKHR =
        SampledImageYcbcrConversionChromaReconstructionExplicitBit,

    [NativeName(
        "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR"
    )]
    SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKHR =
        SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit,

    [NativeName("VK_FORMAT_FEATURE_DISJOINT_BIT_KHR")]
    DisjointBitKHR = DisjointBit,

    [NativeName("VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT_KHR")]
    CositedChromaSamplesBitKHR = CositedChromaSamplesBit,
}
