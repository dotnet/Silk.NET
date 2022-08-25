// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkFormatFeatureFlags")]
    public enum FormatFeatureFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SampledImageBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT")]
        FormatFeatureSampledImageBit = 1,
        [Obsolete("Deprecated in favour of \"StorageImageBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT")]
        FormatFeatureStorageImageBit = 2,
        [Obsolete("Deprecated in favour of \"StorageImageAtomicBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT")]
        FormatFeatureStorageImageAtomicBit = 4,
        [Obsolete("Deprecated in favour of \"UniformTexelBufferBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT")]
        FormatFeatureUniformTexelBufferBit = 8,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT")]
        FormatFeatureStorageTexelBufferBit = 16,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferAtomicBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT")]
        FormatFeatureStorageTexelBufferAtomicBit = 32,
        [Obsolete("Deprecated in favour of \"VertexBufferBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT")]
        FormatFeatureVertexBufferBit = 64,
        [Obsolete("Deprecated in favour of \"ColorAttachmentBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT")]
        FormatFeatureColorAttachmentBit = 128,
        [Obsolete("Deprecated in favour of \"ColorAttachmentBlendBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT")]
        FormatFeatureColorAttachmentBlendBit = 256,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT")]
        FormatFeatureDepthStencilAttachmentBit = 512,
        [Obsolete("Deprecated in favour of \"BlitSrcBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_BLIT_SRC_BIT")]
        FormatFeatureBlitSrcBit = 1024,
        [Obsolete("Deprecated in favour of \"BlitDstBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_BLIT_DST_BIT")]
        FormatFeatureBlitDstBit = 2048,
        [Obsolete("Deprecated in favour of \"SampledImageFilterLinearBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT")]
        FormatFeatureSampledImageFilterLinearBit = 4096,
        [Obsolete("Deprecated in favour of \"SampledImageFilterCubicBitImg\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG")]
        FormatFeatureSampledImageFilterCubicBitImg = 8192,
        [Obsolete("Deprecated in favour of \"VideoDecodeOutputBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_VIDEO_DECODE_OUTPUT_BIT_KHR")]
        FormatFeatureVideoDecodeOutputBitKhr = 33554432,
        [Obsolete("Deprecated in favour of \"VideoDecodeDpbBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_VIDEO_DECODE_DPB_BIT_KHR")]
        FormatFeatureVideoDecodeDpbBitKhr = 67108864,
        [Obsolete("Deprecated in favour of \"TransferSrcBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_SRC_BIT_KHR")]
        FormatFeatureTransferSrcBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"TransferDstBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_DST_BIT_KHR")]
        FormatFeatureTransferDstBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"SampledImageFilterMinmaxBitExt\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT")]
        FormatFeatureSampledImageFilterMinmaxBitExt = 65536,
        [Obsolete("Deprecated in favour of \"AccelerationStructureVertexBufferBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR")]
        FormatFeatureAccelerationStructureVertexBufferBitKhr = 536870912,
        [Obsolete("Deprecated in favour of \"MidpointChromaSamplesBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT_KHR")]
        FormatFeatureMidpointChromaSamplesBitKhr = 131072,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionLinearFilterBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR")]
        FormatFeatureSampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionSeparateReconstructionFilterBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR")]
        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionChromaReconstructionExplicitBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR")]
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR")]
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        [Obsolete("Deprecated in favour of \"DisjointBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_DISJOINT_BIT_KHR")]
        FormatFeatureDisjointBitKhr = 4194304,
        [Obsolete("Deprecated in favour of \"CositedChromaSamplesBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT_KHR")]
        FormatFeatureCositedChromaSamplesBitKhr = 8388608,
        [Obsolete("Deprecated in favour of \"SampledImageFilterCubicBitExt\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT")]
        FormatFeatureSampledImageFilterCubicBitExt = 8192,
        [Obsolete("Deprecated in favour of \"FragmentDensityMapBitExt\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT")]
        FormatFeatureFragmentDensityMapBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"FragmentShadingRateAttachmentBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        FormatFeatureFragmentShadingRateAttachmentBitKhr = 1073741824,
        [Obsolete("Deprecated in favour of \"VideoEncodeInputBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_VIDEO_ENCODE_INPUT_BIT_KHR")]
        FormatFeatureVideoEncodeInputBitKhr = 134217728,
        [Obsolete("Deprecated in favour of \"VideoEncodeDpbBitKhr\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_VIDEO_ENCODE_DPB_BIT_KHR")]
        FormatFeatureVideoEncodeDpbBitKhr = 268435456,
        [Obsolete("Deprecated in favour of \"TransferSrcBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_SRC_BIT")]
        FormatFeatureTransferSrcBit = 16384,
        [Obsolete("Deprecated in favour of \"TransferDstBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_DST_BIT")]
        FormatFeatureTransferDstBit = 32768,
        [Obsolete("Deprecated in favour of \"MidpointChromaSamplesBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT")]
        FormatFeatureMidpointChromaSamplesBit = 131072,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionLinearFilterBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT")]
        FormatFeatureSampledImageYcbcrConversionLinearFilterBit = 262144,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionSeparateReconstructionFilterBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT")]
        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionChromaReconstructionExplicitBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT")]
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT")]
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        [Obsolete("Deprecated in favour of \"DisjointBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_DISJOINT_BIT")]
        FormatFeatureDisjointBit = 4194304,
        [Obsolete("Deprecated in favour of \"CositedChromaSamplesBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT")]
        FormatFeatureCositedChromaSamplesBit = 8388608,
        [Obsolete("Deprecated in favour of \"SampledImageFilterMinmaxBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT")]
        FormatFeatureSampledImageFilterMinmaxBit = 65536,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT")]
        SampledImageBit = 1,
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT")]
        StorageImageBit = 2,
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT")]
        StorageImageAtomicBit = 4,
        [NativeName("Name", "VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT")]
        UniformTexelBufferBit = 8,
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT")]
        StorageTexelBufferBit = 16,
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT")]
        StorageTexelBufferAtomicBit = 32,
        [NativeName("Name", "VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT")]
        VertexBufferBit = 64,
        [NativeName("Name", "VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT")]
        ColorAttachmentBit = 128,
        [NativeName("Name", "VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT")]
        ColorAttachmentBlendBit = 256,
        [NativeName("Name", "VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT")]
        DepthStencilAttachmentBit = 512,
        [NativeName("Name", "VK_FORMAT_FEATURE_BLIT_SRC_BIT")]
        BlitSrcBit = 1024,
        [NativeName("Name", "VK_FORMAT_FEATURE_BLIT_DST_BIT")]
        BlitDstBit = 2048,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT")]
        SampledImageFilterLinearBit = 4096,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG")]
        SampledImageFilterCubicBitImg = 8192,
        [NativeName("Name", "VK_FORMAT_FEATURE_VIDEO_DECODE_OUTPUT_BIT_KHR")]
        VideoDecodeOutputBitKhr = 33554432,
        [NativeName("Name", "VK_FORMAT_FEATURE_VIDEO_DECODE_DPB_BIT_KHR")]
        VideoDecodeDpbBitKhr = 67108864,
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_SRC_BIT_KHR")]
        TransferSrcBitKhr = 16384,
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_DST_BIT_KHR")]
        TransferDstBitKhr = 32768,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT")]
        SampledImageFilterMinmaxBitExt = 65536,
        [NativeName("Name", "VK_FORMAT_FEATURE_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR")]
        AccelerationStructureVertexBufferBitKhr = 536870912,
        [NativeName("Name", "VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT_KHR")]
        MidpointChromaSamplesBitKhr = 131072,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR")]
        SampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR")]
        SampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR")]
        SampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR")]
        SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        [NativeName("Name", "VK_FORMAT_FEATURE_DISJOINT_BIT_KHR")]
        DisjointBitKhr = 4194304,
        [NativeName("Name", "VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT_KHR")]
        CositedChromaSamplesBitKhr = 8388608,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT")]
        SampledImageFilterCubicBitExt = 8192,
        [NativeName("Name", "VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT")]
        FragmentDensityMapBitExt = 16777216,
        [NativeName("Name", "VK_FORMAT_FEATURE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        FragmentShadingRateAttachmentBitKhr = 1073741824,
        [NativeName("Name", "VK_FORMAT_FEATURE_VIDEO_ENCODE_INPUT_BIT_KHR")]
        VideoEncodeInputBitKhr = 134217728,
        [NativeName("Name", "VK_FORMAT_FEATURE_VIDEO_ENCODE_DPB_BIT_KHR")]
        VideoEncodeDpbBitKhr = 268435456,
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_SRC_BIT")]
        TransferSrcBit = 16384,
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_DST_BIT")]
        TransferDstBit = 32768,
        [NativeName("Name", "VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT")]
        MidpointChromaSamplesBit = 131072,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT")]
        SampledImageYcbcrConversionLinearFilterBit = 262144,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT")]
        SampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT")]
        SampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT")]
        SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        [NativeName("Name", "VK_FORMAT_FEATURE_DISJOINT_BIT")]
        DisjointBit = 4194304,
        [NativeName("Name", "VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT")]
        CositedChromaSamplesBit = 8388608,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT")]
        SampledImageFilterMinmaxBit = 65536,
    }
}
