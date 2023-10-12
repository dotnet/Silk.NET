// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkFormatFeatureFlags2")]
    public enum FormatFeatureFlags2 : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SampledImageBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT")]
        FormatFeature2SampledImageBit = 1,
        [Obsolete("Deprecated in favour of \"SampledImageBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT_KHR")]
        FormatFeature2SampledImageBitKhr = 1,
        [Obsolete("Deprecated in favour of \"StorageImageBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT")]
        FormatFeature2StorageImageBit = 2,
        [Obsolete("Deprecated in favour of \"StorageImageBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT_KHR")]
        FormatFeature2StorageImageBitKhr = 2,
        [Obsolete("Deprecated in favour of \"StorageImageAtomicBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT")]
        FormatFeature2StorageImageAtomicBit = 4,
        [Obsolete("Deprecated in favour of \"StorageImageAtomicBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT_KHR")]
        FormatFeature2StorageImageAtomicBitKhr = 4,
        [Obsolete("Deprecated in favour of \"UniformTexelBufferBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT")]
        FormatFeature2UniformTexelBufferBit = 8,
        [Obsolete("Deprecated in favour of \"UniformTexelBufferBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR")]
        FormatFeature2UniformTexelBufferBitKhr = 8,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT")]
        FormatFeature2StorageTexelBufferBit = 16,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT_KHR")]
        FormatFeature2StorageTexelBufferBitKhr = 16,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferAtomicBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT")]
        FormatFeature2StorageTexelBufferAtomicBit = 32,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferAtomicBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT_KHR")]
        FormatFeature2StorageTexelBufferAtomicBitKhr = 32,
        [Obsolete("Deprecated in favour of \"VertexBufferBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT")]
        FormatFeature2VertexBufferBit = 64,
        [Obsolete("Deprecated in favour of \"VertexBufferBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT_KHR")]
        FormatFeature2VertexBufferBitKhr = 64,
        [Obsolete("Deprecated in favour of \"ColorAttachmentBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT")]
        FormatFeature2ColorAttachmentBit = 128,
        [Obsolete("Deprecated in favour of \"ColorAttachmentBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT_KHR")]
        FormatFeature2ColorAttachmentBitKhr = 128,
        [Obsolete("Deprecated in favour of \"ColorAttachmentBlendBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT")]
        FormatFeature2ColorAttachmentBlendBit = 256,
        [Obsolete("Deprecated in favour of \"ColorAttachmentBlendBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT_KHR")]
        FormatFeature2ColorAttachmentBlendBitKhr = 256,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT")]
        FormatFeature2DepthStencilAttachmentBit = 512,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR")]
        FormatFeature2DepthStencilAttachmentBitKhr = 512,
        [Obsolete("Deprecated in favour of \"BlitSrcBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_SRC_BIT")]
        FormatFeature2BlitSrcBit = 1024,
        [Obsolete("Deprecated in favour of \"BlitSrcBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_SRC_BIT_KHR")]
        FormatFeature2BlitSrcBitKhr = 1024,
        [Obsolete("Deprecated in favour of \"BlitDstBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_DST_BIT")]
        FormatFeature2BlitDstBit = 2048,
        [Obsolete("Deprecated in favour of \"BlitDstBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_DST_BIT_KHR")]
        FormatFeature2BlitDstBitKhr = 2048,
        [Obsolete("Deprecated in favour of \"SampledImageFilterLinearBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT")]
        FormatFeature2SampledImageFilterLinearBit = 4096,
        [Obsolete("Deprecated in favour of \"SampledImageFilterLinearBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT_KHR")]
        FormatFeature2SampledImageFilterLinearBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"SampledImageFilterCubicBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT")]
        FormatFeature2SampledImageFilterCubicBit = 8192,
        [Obsolete("Deprecated in favour of \"SampledImageFilterCubicBitExt\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT")]
        FormatFeature2SampledImageFilterCubicBitExt = 8192,
        [Obsolete("Deprecated in favour of \"TransferSrcBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT")]
        FormatFeature2TransferSrcBit = 16384,
        [Obsolete("Deprecated in favour of \"TransferSrcBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT_KHR")]
        FormatFeature2TransferSrcBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"TransferDstBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT")]
        FormatFeature2TransferDstBit = 32768,
        [Obsolete("Deprecated in favour of \"TransferDstBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT_KHR")]
        FormatFeature2TransferDstBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"SampledImageFilterMinmaxBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT")]
        FormatFeature2SampledImageFilterMinmaxBit = 65536,
        [Obsolete("Deprecated in favour of \"SampledImageFilterMinmaxBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT_KHR")]
        FormatFeature2SampledImageFilterMinmaxBitKhr = 65536,
        [Obsolete("Deprecated in favour of \"MidpointChromaSamplesBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT")]
        FormatFeature2MidpointChromaSamplesBit = 131072,
        [Obsolete("Deprecated in favour of \"MidpointChromaSamplesBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT_KHR")]
        FormatFeature2MidpointChromaSamplesBitKhr = 131072,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionLinearFilterBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT")]
        FormatFeature2SampledImageYcbcrConversionLinearFilterBit = 262144,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionLinearFilterBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR")]
        FormatFeature2SampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionSeparateReconstructionFilterBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT")]
        FormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionSeparateReconstructionFilterBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR")]
        FormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionChromaReconstructionExplicitBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT")]
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionChromaReconstructionExplicitBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR")]
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT")]
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR")]
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        [Obsolete("Deprecated in favour of \"DisjointBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DISJOINT_BIT")]
        FormatFeature2DisjointBit = 4194304,
        [Obsolete("Deprecated in favour of \"DisjointBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DISJOINT_BIT_KHR")]
        FormatFeature2DisjointBitKhr = 4194304,
        [Obsolete("Deprecated in favour of \"CositedChromaSamplesBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT")]
        FormatFeature2CositedChromaSamplesBit = 8388608,
        [Obsolete("Deprecated in favour of \"CositedChromaSamplesBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT_KHR")]
        FormatFeature2CositedChromaSamplesBitKhr = 8388608,
        [Obsolete("Deprecated in favour of \"StorageReadWithoutFormatBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT")]
        FormatFeature2StorageReadWithoutFormatBit = 2147483648,
        [Obsolete("Deprecated in favour of \"StorageReadWithoutFormatBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT_KHR")]
        FormatFeature2StorageReadWithoutFormatBitKhr = 2147483648,
        [Obsolete("Deprecated in favour of \"StorageWriteWithoutFormatBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT")]
        FormatFeature2StorageWriteWithoutFormatBit = 4294967296,
        [Obsolete("Deprecated in favour of \"StorageWriteWithoutFormatBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT_KHR")]
        FormatFeature2StorageWriteWithoutFormatBitKhr = 4294967296,
        [Obsolete("Deprecated in favour of \"SampledImageDepthComparisonBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT")]
        FormatFeature2SampledImageDepthComparisonBit = 8589934592,
        [Obsolete("Deprecated in favour of \"SampledImageDepthComparisonBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT_KHR")]
        FormatFeature2SampledImageDepthComparisonBitKhr = 8589934592,
        [Obsolete("Deprecated in favour of \"VideoDecodeOutputBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR")]
        FormatFeature2VideoDecodeOutputBitKhr = 33554432,
        [Obsolete("Deprecated in favour of \"VideoDecodeDpbBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR")]
        FormatFeature2VideoDecodeDpbBitKhr = 67108864,
        [Obsolete("Deprecated in favour of \"AccelerationStructureVertexBufferBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR")]
        FormatFeature2AccelerationStructureVertexBufferBitKhr = 536870912,
        [Obsolete("Deprecated in favour of \"FragmentDensityMapBitExt\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT")]
        FormatFeature2FragmentDensityMapBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"FragmentShadingRateAttachmentBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        FormatFeature2FragmentShadingRateAttachmentBitKhr = 1073741824,
        [Obsolete("Deprecated in favour of \"HostImageTransferBitExt\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_HOST_IMAGE_TRANSFER_BIT_EXT")]
        FormatFeature2HostImageTransferBitExt = 70368744177664,
        [Obsolete("Deprecated in favour of \"VideoEncodeInputBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR")]
        FormatFeature2VideoEncodeInputBitKhr = 134217728,
        [Obsolete("Deprecated in favour of \"VideoEncodeDpbBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR")]
        FormatFeature2VideoEncodeDpbBitKhr = 268435456,
        [Obsolete("Deprecated in favour of \"LinearColorAttachmentBitNV\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV")]
        FormatFeature2LinearColorAttachmentBitNV = 274877906944,
        [Obsolete("Deprecated in favour of \"WeightImageBitQCom\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_WEIGHT_IMAGE_BIT_QCOM")]
        FormatFeature2WeightImageBitQCom = 17179869184,
        [Obsolete("Deprecated in favour of \"WeightSampledImageBitQCom\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_WEIGHT_SAMPLED_IMAGE_BIT_QCOM")]
        FormatFeature2WeightSampledImageBitQCom = 34359738368,
        [Obsolete("Deprecated in favour of \"BlockMatchingBitQCom\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLOCK_MATCHING_BIT_QCOM")]
        FormatFeature2BlockMatchingBitQCom = 68719476736,
        [Obsolete("Deprecated in favour of \"BoxFilterSampledBitQCom\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BOX_FILTER_SAMPLED_BIT_QCOM")]
        FormatFeature2BoxFilterSampledBitQCom = 137438953472,
        [Obsolete("Deprecated in favour of \"OpticalFlowImageBitNV\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_OPTICAL_FLOW_IMAGE_BIT_NV")]
        FormatFeature2OpticalFlowImageBitNV = 1099511627776,
        [Obsolete("Deprecated in favour of \"OpticalFlowVectorBitNV\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_OPTICAL_FLOW_VECTOR_BIT_NV")]
        FormatFeature2OpticalFlowVectorBitNV = 2199023255552,
        [Obsolete("Deprecated in favour of \"OpticalFlowCostBitNV\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_OPTICAL_FLOW_COST_BIT_NV")]
        FormatFeature2OpticalFlowCostBitNV = 4398046511104,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT")]
        SampledImageBit = 1,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT_KHR")]
        SampledImageBitKhr = 1,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT")]
        StorageImageBit = 2,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT_KHR")]
        StorageImageBitKhr = 2,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT")]
        StorageImageAtomicBit = 4,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT_KHR")]
        StorageImageAtomicBitKhr = 4,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT")]
        UniformTexelBufferBit = 8,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR")]
        UniformTexelBufferBitKhr = 8,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT")]
        StorageTexelBufferBit = 16,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT_KHR")]
        StorageTexelBufferBitKhr = 16,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT")]
        StorageTexelBufferAtomicBit = 32,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT_KHR")]
        StorageTexelBufferAtomicBitKhr = 32,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT")]
        VertexBufferBit = 64,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT_KHR")]
        VertexBufferBitKhr = 64,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT")]
        ColorAttachmentBit = 128,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT_KHR")]
        ColorAttachmentBitKhr = 128,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT")]
        ColorAttachmentBlendBit = 256,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT_KHR")]
        ColorAttachmentBlendBitKhr = 256,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT")]
        DepthStencilAttachmentBit = 512,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR")]
        DepthStencilAttachmentBitKhr = 512,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_SRC_BIT")]
        BlitSrcBit = 1024,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_SRC_BIT_KHR")]
        BlitSrcBitKhr = 1024,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_DST_BIT")]
        BlitDstBit = 2048,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_DST_BIT_KHR")]
        BlitDstBitKhr = 2048,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT")]
        SampledImageFilterLinearBit = 4096,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT_KHR")]
        SampledImageFilterLinearBitKhr = 4096,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT")]
        SampledImageFilterCubicBit = 8192,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT")]
        SampledImageFilterCubicBitExt = 8192,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT")]
        TransferSrcBit = 16384,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT_KHR")]
        TransferSrcBitKhr = 16384,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT")]
        TransferDstBit = 32768,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT_KHR")]
        TransferDstBitKhr = 32768,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT")]
        SampledImageFilterMinmaxBit = 65536,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT_KHR")]
        SampledImageFilterMinmaxBitKhr = 65536,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT")]
        MidpointChromaSamplesBit = 131072,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT_KHR")]
        MidpointChromaSamplesBitKhr = 131072,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT")]
        SampledImageYcbcrConversionLinearFilterBit = 262144,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR")]
        SampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT")]
        SampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR")]
        SampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT")]
        SampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR")]
        SampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT")]
        SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR")]
        SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DISJOINT_BIT")]
        DisjointBit = 4194304,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DISJOINT_BIT_KHR")]
        DisjointBitKhr = 4194304,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT")]
        CositedChromaSamplesBit = 8388608,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT_KHR")]
        CositedChromaSamplesBitKhr = 8388608,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT")]
        StorageReadWithoutFormatBit = 2147483648,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT_KHR")]
        StorageReadWithoutFormatBitKhr = 2147483648,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT")]
        StorageWriteWithoutFormatBit = 4294967296,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT_KHR")]
        StorageWriteWithoutFormatBitKhr = 4294967296,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT")]
        SampledImageDepthComparisonBit = 8589934592,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT_KHR")]
        SampledImageDepthComparisonBitKhr = 8589934592,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR")]
        VideoDecodeOutputBitKhr = 33554432,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR")]
        VideoDecodeDpbBitKhr = 67108864,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR")]
        AccelerationStructureVertexBufferBitKhr = 536870912,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT")]
        FragmentDensityMapBitExt = 16777216,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        FragmentShadingRateAttachmentBitKhr = 1073741824,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_HOST_IMAGE_TRANSFER_BIT_EXT")]
        HostImageTransferBitExt = 70368744177664,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR")]
        VideoEncodeInputBitKhr = 134217728,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR")]
        VideoEncodeDpbBitKhr = 268435456,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV")]
        LinearColorAttachmentBitNV = 274877906944,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_WEIGHT_IMAGE_BIT_QCOM")]
        WeightImageBitQCom = 17179869184,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_WEIGHT_SAMPLED_IMAGE_BIT_QCOM")]
        WeightSampledImageBitQCom = 34359738368,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLOCK_MATCHING_BIT_QCOM")]
        BlockMatchingBitQCom = 68719476736,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BOX_FILTER_SAMPLED_BIT_QCOM")]
        BoxFilterSampledBitQCom = 137438953472,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_OPTICAL_FLOW_IMAGE_BIT_NV")]
        OpticalFlowImageBitNV = 1099511627776,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_OPTICAL_FLOW_VECTOR_BIT_NV")]
        OpticalFlowVectorBitNV = 2199023255552,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_OPTICAL_FLOW_COST_BIT_NV")]
        OpticalFlowCostBitNV = 4398046511104,
    }
}
