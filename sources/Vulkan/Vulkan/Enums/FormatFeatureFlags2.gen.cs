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

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR")]
    VideoDecodeOutputBitKHR = 0x2000000,

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR")]
    VideoDecodeDpbBitKHR = 0x4000000,

    [NativeName("VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR")]
    AccelerationStructureVertexBufferBitKHR = 0x20000000,

    [NativeName("VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT")]
    FragmentDensityMapBitEXT = 0x1000000,

    [NativeName("VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    FragmentShadingRateAttachmentBitKHR = 0x40000000,

    [NativeName("VK_FORMAT_FEATURE_2_HOST_IMAGE_TRANSFER_BIT_EXT")]
    HostImageTransferBitEXT = 0x400000000000,

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR")]
    VideoEncodeInputBitKHR = 0x8000000,

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR")]
    VideoEncodeDpbBitKHR = 0x10000000,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT_KHR")]
    SampledImageBitKHR = 0x1,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT_KHR")]
    StorageImageBitKHR = 0x2,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT_KHR")]
    StorageImageAtomicBitKHR = 0x4,

    [NativeName("VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR")]
    UniformTexelBufferBitKHR = 0x8,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT_KHR")]
    StorageTexelBufferBitKHR = 0x10,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT_KHR")]
    StorageTexelBufferAtomicBitKHR = 0x20,

    [NativeName("VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT_KHR")]
    VertexBufferBitKHR = 0x40,

    [NativeName("VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT_KHR")]
    ColorAttachmentBitKHR = 0x80,

    [NativeName("VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT_KHR")]
    ColorAttachmentBlendBitKHR = 0x100,

    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR")]
    DepthStencilAttachmentBitKHR = 0x200,

    [NativeName("VK_FORMAT_FEATURE_2_BLIT_SRC_BIT_KHR")]
    BlitSrcBitKHR = 0x400,

    [NativeName("VK_FORMAT_FEATURE_2_BLIT_DST_BIT_KHR")]
    BlitDstBitKHR = 0x800,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT_KHR")]
    SampledImageFilterLinearBitKHR = 0x1000,

    [NativeName("VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT_KHR")]
    TransferSrcBitKHR = 0x4000,

    [NativeName("VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT_KHR")]
    TransferDstBitKHR = 0x8000,

    [NativeName("VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT_KHR")]
    MidpointChromaSamplesBitKHR = 0x20000,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR")]
    SampledImageYcbcrConversionLinearFilterBitKHR = 0x40000,

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR"
    )]
    SampledImageYcbcrConversionSeparateReconstructionFilterBitKHR = 0x80000,

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR"
    )]
    SampledImageYcbcrConversionChromaReconstructionExplicitBitKHR = 0x100000,

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR"
    )]
    SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKHR = 0x200000,

    [NativeName("VK_FORMAT_FEATURE_2_DISJOINT_BIT_KHR")]
    DisjointBitKHR = 0x400000,

    [NativeName("VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT_KHR")]
    CositedChromaSamplesBitKHR = 0x800000,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT_KHR")]
    StorageReadWithoutFormatBitKHR = 0x80000000,

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT_KHR")]
    StorageWriteWithoutFormatBitKHR = 0x100000000,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT_KHR")]
    SampledImageDepthComparisonBitKHR = 0x200000000,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT_KHR")]
    SampledImageFilterMinmaxBitKHR = 0x10000,

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT")]
    SampledImageFilterCubicBitEXT = 0x2000,

    [NativeName("VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_RADIUS_BUFFER_BIT_NV")]
    AccelerationStructureRadiusBufferBitNV = 0x8000000000000,

    [NativeName("VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV")]
    LinearColorAttachmentBitNV = 0x4000000000,

    [NativeName("VK_FORMAT_FEATURE_2_WEIGHT_IMAGE_BIT_QCOM")]
    WeightImageBitQCOM = 0x400000000,

    [NativeName("VK_FORMAT_FEATURE_2_WEIGHT_SAMPLED_IMAGE_BIT_QCOM")]
    WeightSampledImageBitQCOM = 0x800000000,

    [NativeName("VK_FORMAT_FEATURE_2_BLOCK_MATCHING_BIT_QCOM")]
    BlockMatchingBitQCOM = 0x1000000000,

    [NativeName("VK_FORMAT_FEATURE_2_BOX_FILTER_SAMPLED_BIT_QCOM")]
    BoxFilterSampledBitQCOM = 0x2000000000,

    [NativeName("VK_FORMAT_FEATURE_2_TENSOR_SHADER_BIT_ARM")]
    TensorShaderBitARM = 0x8000000000,

    [NativeName("VK_FORMAT_FEATURE_2_TENSOR_IMAGE_ALIASING_BIT_ARM")]
    TensorImageAliasingBitARM = 0x80000000000,

    [NativeName("VK_FORMAT_FEATURE_2_OPTICAL_FLOW_IMAGE_BIT_NV")]
    OpticalFlowImageBitNV = 0x10000000000,

    [NativeName("VK_FORMAT_FEATURE_2_OPTICAL_FLOW_VECTOR_BIT_NV")]
    OpticalFlowVectorBitNV = 0x20000000000,

    [NativeName("VK_FORMAT_FEATURE_2_OPTICAL_FLOW_COST_BIT_NV")]
    OpticalFlowCostBitNV = 0x40000000000,

    [NativeName("VK_FORMAT_FEATURE_2_TENSOR_DATA_GRAPH_BIT_ARM")]
    TensorDataGraphBitARM = 0x1000000000000,

    [NativeName("VK_FORMAT_FEATURE_2_COPY_IMAGE_INDIRECT_DST_BIT_KHR")]
    CopyImageIndirectDstBitKHR = 0x800000000000000,

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR")]
    VideoEncodeQuantizationDeltaMapBitKHR = 0x2000000000000,

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_EMPHASIS_MAP_BIT_KHR")]
    VideoEncodeEmphasisMapBitKHR = 0x4000000000000,

    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_COPY_ON_COMPUTE_QUEUE_BIT_KHR")]
    DepthCopyOnComputeQueueBitKHR = 0x10000000000000,

    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_COPY_ON_TRANSFER_QUEUE_BIT_KHR")]
    DepthCopyOnTransferQueueBitKHR = 0x20000000000000,

    [NativeName("VK_FORMAT_FEATURE_2_STENCIL_COPY_ON_COMPUTE_QUEUE_BIT_KHR")]
    StencilCopyOnComputeQueueBitKHR = 0x40000000000000,

    [NativeName("VK_FORMAT_FEATURE_2_STENCIL_COPY_ON_TRANSFER_QUEUE_BIT_KHR")]
    StencilCopyOnTransferQueueBitKHR = 0x80000000000000,
}
