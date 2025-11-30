// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFormatFeatureFlags2")]
[Flags]
public enum FormatFeatureFlags2 : ulong
{
    None = 0x0,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT")]
    SampledImageBit = 0x1,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT")]
    StorageImageBit = 0x2,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT")]
    StorageImageAtomicBit = 0x4,

    [NativeName("VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT")]
    UniformTexelBufferBit = 0x8,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT")]
    StorageTexelBufferBit = 0x10,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT")]
    StorageTexelBufferAtomicBit = 0x20,

    [NativeName("VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT")]
    VertexBufferBit = 0x40,

    [NativeName("VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT")]
    ColorAttachmentBit = 0x80,

    [NativeName("VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT")]
    ColorAttachmentBlendBit = 0x100,

    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT")]
    DepthStencilAttachmentBit = 0x200,

    [NativeName("VK_FORMAT_FEATURE_2_BLIT_SRC_BIT")]
    BlitSrcBit = 0x400,

    [NativeName("VK_FORMAT_FEATURE_2_BLIT_DST_BIT")]
    BlitDstBit = 0x800,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT")]
    SampledImageFilterLinearBit = 0x1000,

    [NativeName("VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT")]
    TransferSrcBit = 0x4000,

    [NativeName("VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT")]
    TransferDstBit = 0x8000,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT")]
    SampledImageFilterMinmaxBit = 0x10000,

    [NativeName("VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT")]
    MidpointChromaSamplesBit = 0x20000,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT")]
    SampledImageYcbcrConversionLinearFilterBit = 0x40000,

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT"
    )]
    SampledImageYcbcrConversionSeparateReconstructionFilterBit = 0x80000,

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT"
    )]
    SampledImageYcbcrConversionChromaReconstructionExplicitBit = 0x100000,

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT"
    )]
    SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 0x200000,

    [NativeName("VK_FORMAT_FEATURE_2_DISJOINT_BIT")]
    DisjointBit = 0x400000,

    [NativeName("VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT")]
    CositedChromaSamplesBit = 0x800000,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT")]
    StorageReadWithoutFormatBit = 0x80000000,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT")]
    StorageWriteWithoutFormatBit = 0x100000000,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT")]
    SampledImageDepthComparisonBit = 0x200000000,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT")]
    SampledImageFilterCubicBit = 0x2000,

    [NativeName("VK_FORMAT_FEATURE_2_HOST_IMAGE_TRANSFER_BIT")]
    HostImageTransferBit = 0x400000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR")]
    VideoDecodeOutputBitkhr = 0x2000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR")]
    VideoDecodeDpbBitkhr = 0x4000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR")]
    AccelerationStructureVertexBufferBitkhr = 0x20000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT")]
    FragmentDensityMapBitext = 0x1000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    FragmentShadingRateAttachmentBitkhr = 0x40000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_HOST_IMAGE_TRANSFER_BIT_EXT")]
    HostImageTransferBitext = 0x400000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR")]
    VideoEncodeInputBitkhr = 0x8000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR")]
    VideoEncodeDpbBitkhr = 0x10000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT_KHR")]
    SampledImageBitkhr = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT_KHR")]
    StorageImageBitkhr = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT_KHR")]
    StorageImageAtomicBitkhr = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR")]
    UniformTexelBufferBitkhr = 0x8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT_KHR")]
    StorageTexelBufferBitkhr = 0x10,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT_KHR")]
    StorageTexelBufferAtomicBitkhr = 0x20,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT_KHR")]
    VertexBufferBitkhr = 0x40,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT_KHR")]
    ColorAttachmentBitkhr = 0x80,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT_KHR")]
    ColorAttachmentBlendBitkhr = 0x100,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR")]
    DepthStencilAttachmentBitkhr = 0x200,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_BLIT_SRC_BIT_KHR")]
    BlitSrcBitkhr = 0x400,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_BLIT_DST_BIT_KHR")]
    BlitDstBitkhr = 0x800,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT_KHR")]
    SampledImageFilterLinearBitkhr = 0x1000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT_KHR")]
    TransferSrcBitkhr = 0x4000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT_KHR")]
    TransferDstBitkhr = 0x8000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT_KHR")]
    MidpointChromaSamplesBitkhr = 0x20000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR")]
    SampledImageYcbcrConversionLinearFilterBitkhr = 0x40000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR"
    )]
    SampledImageYcbcrConversionSeparateReconstructionFilterBitkhr = 0x80000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR"
    )]
    SampledImageYcbcrConversionChromaReconstructionExplicitBitkhr = 0x100000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR"
    )]
    SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitkhr = 0x200000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_DISJOINT_BIT_KHR")]
    DisjointBitkhr = 0x400000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT_KHR")]
    CositedChromaSamplesBitkhr = 0x800000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT_KHR")]
    StorageReadWithoutFormatBitkhr = 0x80000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT_KHR")]
    StorageWriteWithoutFormatBitkhr = 0x100000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT_KHR")]
    SampledImageDepthComparisonBitkhr = 0x200000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT_KHR")]
    SampledImageFilterMinmaxBitkhr = 0x10000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT")]
    SampledImageFilterCubicBitext = 0x2000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_RADIUS_BUFFER_BIT_NV")]
    AccelerationStructureRadiusBufferBitnv = 0x8000000000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV")]
    LinearColorAttachmentBitnv = 0x4000000000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_WEIGHT_IMAGE_BIT_QCOM")]
    WeightImageBitqcom = 0x400000000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_WEIGHT_SAMPLED_IMAGE_BIT_QCOM")]
    WeightSampledImageBitqcom = 0x800000000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_BLOCK_MATCHING_BIT_QCOM")]
    BlockMatchingBitqcom = 0x1000000000,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_BOX_FILTER_SAMPLED_BIT_QCOM")]
    BoxFilterSampledBitqcom = 0x2000000000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_TENSOR_SHADER_BIT_ARM")]
    TensorShaderBitarm = 0x8000000000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_TENSOR_IMAGE_ALIASING_BIT_ARM")]
    TensorImageAliasingBitarm = 0x80000000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_OPTICAL_FLOW_IMAGE_BIT_NV")]
    OpticalFlowImageBitnv = 0x10000000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_OPTICAL_FLOW_VECTOR_BIT_NV")]
    OpticalFlowVectorBitnv = 0x20000000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_OPTICAL_FLOW_COST_BIT_NV")]
    OpticalFlowCostBitnv = 0x40000000000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_TENSOR_DATA_GRAPH_BIT_ARM")]
    TensorDataGraphBitarm = 0x1000000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_COPY_IMAGE_INDIRECT_DST_BIT_KHR")]
    CopyImageIndirectDstBitkhr = 0x800000000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR")]
    VideoEncodeQuantizationDeltaMapBitkhr = 0x2000000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_EMPHASIS_MAP_BIT_KHR")]
    VideoEncodeEmphasisMapBitkhr = 0x4000000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_COPY_ON_COMPUTE_QUEUE_BIT_KHR")]
    DepthCopyOnComputeQueueBitkhr = 0x10000000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_COPY_ON_TRANSFER_QUEUE_BIT_KHR")]
    DepthCopyOnTransferQueueBitkhr = 0x20000000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_STENCIL_COPY_ON_COMPUTE_QUEUE_BIT_KHR")]
    StencilCopyOnComputeQueueBitkhr = 0x40000000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_FORMAT_FEATURE_2_STENCIL_COPY_ON_TRANSFER_QUEUE_BIT_KHR")]
    StencilCopyOnTransferQueueBitkhr = 0x80000000000000,
}
