// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkFormatFeatureFlags")]
    public enum FormatFeatureFlags : int
    {
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT")]
        FormatFeatureSampledImageBit = 1,
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT")]
        FormatFeatureStorageImageBit = 2,
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT")]
        FormatFeatureStorageImageAtomicBit = 4,
        [NativeName("Name", "VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT")]
        FormatFeatureUniformTexelBufferBit = 8,
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT")]
        FormatFeatureStorageTexelBufferBit = 16,
        [NativeName("Name", "VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT")]
        FormatFeatureStorageTexelBufferAtomicBit = 32,
        [NativeName("Name", "VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT")]
        FormatFeatureVertexBufferBit = 64,
        [NativeName("Name", "VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT")]
        FormatFeatureColorAttachmentBit = 128,
        [NativeName("Name", "VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT")]
        FormatFeatureColorAttachmentBlendBit = 256,
        [NativeName("Name", "VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT")]
        FormatFeatureDepthStencilAttachmentBit = 512,
        [NativeName("Name", "VK_FORMAT_FEATURE_BLIT_SRC_BIT")]
        FormatFeatureBlitSrcBit = 1024,
        [NativeName("Name", "VK_FORMAT_FEATURE_BLIT_DST_BIT")]
        FormatFeatureBlitDstBit = 2048,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT")]
        FormatFeatureSampledImageFilterLinearBit = 4096,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG")]
        FormatFeatureSampledImageFilterCubicBitImg = 8192,
        [NativeName("Name", "VK_FORMAT_FEATURE_RESERVED_27_BIT_KHR")]
        FormatFeatureReserved27BitKhr = 134217728,
        [NativeName("Name", "VK_FORMAT_FEATURE_RESERVED_28_BIT_KHR")]
        FormatFeatureReserved28BitKhr = 268435456,
        [NativeName("Name", "VK_FORMAT_FEATURE_RESERVED_25_BIT_KHR")]
        FormatFeatureReserved25BitKhr = 33554432,
        [NativeName("Name", "VK_FORMAT_FEATURE_RESERVED_26_BIT_KHR")]
        FormatFeatureReserved26BitKhr = 67108864,
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_SRC_BIT_KHR")]
        FormatFeatureTransferSrcBitKhr = 16384,
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_DST_BIT_KHR")]
        FormatFeatureTransferDstBitKhr = 32768,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT")]
        FormatFeatureSampledImageFilterMinmaxBitExt = 65536,
        [NativeName("Name", "VK_FORMAT_FEATURE_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR")]
        FormatFeatureAccelerationStructureVertexBufferBitKhr = 536870912,
        [NativeName("Name", "VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT_KHR")]
        FormatFeatureMidpointChromaSamplesBitKhr = 131072,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR")]
        FormatFeatureSampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR")]
        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR")]
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR")]
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        [NativeName("Name", "VK_FORMAT_FEATURE_DISJOINT_BIT_KHR")]
        FormatFeatureDisjointBitKhr = 4194304,
        [NativeName("Name", "VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT_KHR")]
        FormatFeatureCositedChromaSamplesBitKhr = 8388608,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT")]
        FormatFeatureSampledImageFilterCubicBitExt = 8192,
        [NativeName("Name", "VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT")]
        FormatFeatureFragmentDensityMapBitExt = 16777216,
        [NativeName("Name", "VK_FORMAT_FEATURE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        FormatFeatureFragmentShadingRateAttachmentBitKhr = 1073741824,
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_SRC_BIT")]
        FormatFeatureTransferSrcBit = 16384,
        [NativeName("Name", "VK_FORMAT_FEATURE_TRANSFER_DST_BIT")]
        FormatFeatureTransferDstBit = 32768,
        [NativeName("Name", "VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT")]
        FormatFeatureMidpointChromaSamplesBit = 131072,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT")]
        FormatFeatureSampledImageYcbcrConversionLinearFilterBit = 262144,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT")]
        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT")]
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT")]
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        [NativeName("Name", "VK_FORMAT_FEATURE_DISJOINT_BIT")]
        FormatFeatureDisjointBit = 4194304,
        [NativeName("Name", "VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT")]
        FormatFeatureCositedChromaSamplesBit = 8388608,
        [NativeName("Name", "VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT")]
        FormatFeatureSampledImageFilterMinmaxBit = 65536,
    }
}
