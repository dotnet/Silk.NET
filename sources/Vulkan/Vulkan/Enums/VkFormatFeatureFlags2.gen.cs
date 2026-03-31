// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFormatFeatureFlags2")]
[Transformed]
[Flags]
public enum VkFormatFeatureFlags2 : ulong
{
    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT")]
    VkFormatFeature2SampledImageBit = unchecked((ulong)0x00000001UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT")]
    VkFormatFeature2StorageImageBit = unchecked((ulong)0x00000002UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT")]
    VkFormatFeature2StorageImageAtomicBit = unchecked((ulong)0x00000004UL),

    [NativeName("VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT")]
    VkFormatFeature2UniformTexelBufferBit = unchecked((ulong)0x00000008UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT")]
    VkFormatFeature2StorageTexelBufferBit = unchecked((ulong)0x00000010UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT")]
    VkFormatFeature2StorageTexelBufferAtomicBit = unchecked((ulong)0x00000020UL),

    [NativeName("VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT")]
    VkFormatFeature2VertexBufferBit = unchecked((ulong)0x00000040UL),

    [NativeName("VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT")]
    VkFormatFeature2ColorAttachmentBit = unchecked((ulong)0x00000080UL),

    [NativeName("VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT")]
    VkFormatFeature2ColorAttachmentBlendBit = unchecked((ulong)0x00000100UL),

    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT")]
    VkFormatFeature2DepthStencilAttachmentBit = unchecked((ulong)0x00000200UL),

    [NativeName("VK_FORMAT_FEATURE_2_BLIT_SRC_BIT")]
    VkFormatFeature2BlitSrcBit = unchecked((ulong)0x00000400UL),

    [NativeName("VK_FORMAT_FEATURE_2_BLIT_DST_BIT")]
    VkFormatFeature2BlitDstBit = unchecked((ulong)0x00000800UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT")]
    VkFormatFeature2SampledImageFilterLinearBit = unchecked((ulong)0x00001000UL),

    [NativeName("VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT")]
    VkFormatFeature2TransferSrcBit = unchecked((ulong)0x00004000UL),

    [NativeName("VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT")]
    VkFormatFeature2TransferDstBit = unchecked((ulong)0x00008000UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT")]
    VkFormatFeature2SampledImageFilterMinmaxBit = unchecked((ulong)0x00010000UL),

    [NativeName("VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT")]
    VkFormatFeature2MidpointChromaSamplesBit = unchecked((ulong)0x00020000UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT")]
    VkFormatFeature2SampledImageYcbcrConversionLinearFilterBit = unchecked((ulong)0x00040000UL),

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT"
    )]
    VkFormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilterBit =
        unchecked((ulong)0x00080000UL),

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT"
    )]
    VkFormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitBit =
        unchecked((ulong)0x00100000UL),

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT"
    )]
    VkFormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit =
        unchecked((ulong)0x00200000UL),

    [NativeName("VK_FORMAT_FEATURE_2_DISJOINT_BIT")]
    VkFormatFeature2DisjointBit = unchecked((ulong)0x00400000UL),

    [NativeName("VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT")]
    VkFormatFeature2CositedChromaSamplesBit = unchecked((ulong)0x00800000UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT")]
    VkFormatFeature2StorageReadWithoutFormatBit = unchecked((ulong)0x80000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT")]
    VkFormatFeature2StorageWriteWithoutFormatBit = unchecked((ulong)0x100000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT")]
    VkFormatFeature2SampledImageDepthComparisonBit = unchecked((ulong)0x200000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT")]
    VkFormatFeature2SampledImageFilterCubicBit = unchecked((ulong)0x00002000UL),

    [NativeName("VK_FORMAT_FEATURE_2_HOST_IMAGE_TRANSFER_BIT")]
    VkFormatFeature2HostImageTransferBit = unchecked((ulong)0x400000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2VideoDecodeOutputBitKHR = unchecked((ulong)0x02000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2VideoDecodeDpbBitKHR = unchecked((ulong)0x04000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2AccelerationStructureVertexBufferBitKHR = unchecked((ulong)0x20000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkFormatFeature2FragmentDensityMapBitEXT = unchecked((ulong)0x01000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2FragmentShadingRateAttachmentBitKHR = unchecked((ulong)0x40000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_HOST_IMAGE_TRANSFER_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkFormatFeature2HostImageTransferBitEXT = unchecked((ulong)0x400000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2VideoEncodeInputBitKHR = unchecked((ulong)0x08000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2VideoEncodeDpbBitKHR = unchecked((ulong)0x10000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2SampledImageBitKHR = unchecked((ulong)0x00000001UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2StorageImageBitKHR = unchecked((ulong)0x00000002UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2StorageImageAtomicBitKHR = unchecked((ulong)0x00000004UL),

    [NativeName("VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2UniformTexelBufferBitKHR = unchecked((ulong)0x00000008UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2StorageTexelBufferBitKHR = unchecked((ulong)0x00000010UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2StorageTexelBufferAtomicBitKHR = unchecked((ulong)0x00000020UL),

    [NativeName("VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2VertexBufferBitKHR = unchecked((ulong)0x00000040UL),

    [NativeName("VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2ColorAttachmentBitKHR = unchecked((ulong)0x00000080UL),

    [NativeName("VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2ColorAttachmentBlendBitKHR = unchecked((ulong)0x00000100UL),

    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2DepthStencilAttachmentBitKHR = unchecked((ulong)0x00000200UL),

    [NativeName("VK_FORMAT_FEATURE_2_BLIT_SRC_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2BlitSrcBitKHR = unchecked((ulong)0x00000400UL),

    [NativeName("VK_FORMAT_FEATURE_2_BLIT_DST_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2BlitDstBitKHR = unchecked((ulong)0x00000800UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2SampledImageFilterLinearBitKHR = unchecked((ulong)0x00001000UL),

    [NativeName("VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2TransferSrcBitKHR = unchecked((ulong)0x00004000UL),

    [NativeName("VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2TransferDstBitKHR = unchecked((ulong)0x00008000UL),

    [NativeName("VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2MidpointChromaSamplesBitKHR = unchecked((ulong)0x00020000UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2SampledImageYcbcrConversionLinearFilterBitKHR = unchecked((ulong)0x00040000UL),

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR"
    )]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilterBitKHR =
        unchecked((ulong)0x00080000UL),

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR"
    )]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitBitKHR =
        unchecked((ulong)0x00100000UL),

    [NativeName(
        "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR"
    )]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKHR =
        unchecked((ulong)0x00200000UL),

    [NativeName("VK_FORMAT_FEATURE_2_DISJOINT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2DisjointBitKHR = unchecked((ulong)0x00400000UL),

    [NativeName("VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2CositedChromaSamplesBitKHR = unchecked((ulong)0x00800000UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2StorageReadWithoutFormatBitKHR = unchecked((ulong)0x80000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2StorageWriteWithoutFormatBitKHR = unchecked((ulong)0x100000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2SampledImageDepthComparisonBitKHR = unchecked((ulong)0x200000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2SampledImageFilterMinmaxBitKHR = unchecked((ulong)0x00010000UL),

    [NativeName("VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkFormatFeature2SampledImageFilterCubicBitEXT = unchecked((ulong)0x00002000UL),

    [NativeName("VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_RADIUS_BUFFER_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkFormatFeature2AccelerationStructureRadiusBufferBitNV = unchecked((ulong)0x8000000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkFormatFeature2LinearColorAttachmentBitNV = unchecked((ulong)0x4000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_WEIGHT_IMAGE_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    VkFormatFeature2WeightImageBitQCOM = unchecked((ulong)0x400000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_WEIGHT_SAMPLED_IMAGE_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    VkFormatFeature2WeightSampledImageBitQCOM = unchecked((ulong)0x800000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_BLOCK_MATCHING_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    VkFormatFeature2BlockMatchingBitQCOM = unchecked((ulong)0x1000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_BOX_FILTER_SAMPLED_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    VkFormatFeature2BoxFilterSampledBitQCOM = unchecked((ulong)0x2000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_TENSOR_SHADER_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    VkFormatFeature2TensorShaderBitARM = unchecked((ulong)0x8000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_TENSOR_IMAGE_ALIASING_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    VkFormatFeature2TensorImageAliasingBitARM = unchecked((ulong)0x80000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_OPTICAL_FLOW_IMAGE_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkFormatFeature2OpticalFlowImageBitNV = unchecked((ulong)0x10000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_OPTICAL_FLOW_VECTOR_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkFormatFeature2OpticalFlowVectorBitNV = unchecked((ulong)0x20000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_OPTICAL_FLOW_COST_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkFormatFeature2OpticalFlowCostBitNV = unchecked((ulong)0x40000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_TENSOR_DATA_GRAPH_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    VkFormatFeature2TensorDataGraphBitARM = unchecked((ulong)0x1000000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_COPY_IMAGE_INDIRECT_DST_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2CopyImageIndirectDstBitKHR = unchecked((ulong)0x800000000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2VideoEncodeQuantizationDeltaMapBitKHR = unchecked((ulong)0x2000000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_VIDEO_ENCODE_EMPHASIS_MAP_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2VideoEncodeEmphasisMapBitKHR = unchecked((ulong)0x4000000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_COPY_ON_COMPUTE_QUEUE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2DepthCopyOnComputeQueueBitKHR = unchecked((ulong)0x10000000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_DEPTH_COPY_ON_TRANSFER_QUEUE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2DepthCopyOnTransferQueueBitKHR = unchecked((ulong)0x20000000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_STENCIL_COPY_ON_COMPUTE_QUEUE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2StencilCopyOnComputeQueueBitKHR = unchecked((ulong)0x40000000000000UL),

    [NativeName("VK_FORMAT_FEATURE_2_STENCIL_COPY_ON_TRANSFER_QUEUE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkFormatFeature2StencilCopyOnTransferQueueBitKHR = unchecked((ulong)0x80000000000000UL),
}
