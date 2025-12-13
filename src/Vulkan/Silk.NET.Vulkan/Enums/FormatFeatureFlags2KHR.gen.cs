// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkFormatFeatureFlags2KHR")]
    public enum FormatFeatureFlags2KHR : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SampledImageBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT")]
        FormatFeature2SampledImageBit = 1,
        [Obsolete("Deprecated in favour of \"StorageImageBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT")]
        FormatFeature2StorageImageBit = 2,
        [Obsolete("Deprecated in favour of \"StorageImageAtomicBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT")]
        FormatFeature2StorageImageAtomicBit = 4,
        [Obsolete("Deprecated in favour of \"UniformTexelBufferBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT")]
        FormatFeature2UniformTexelBufferBit = 8,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT")]
        FormatFeature2StorageTexelBufferBit = 16,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferAtomicBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT")]
        FormatFeature2StorageTexelBufferAtomicBit = 32,
        [Obsolete("Deprecated in favour of \"VertexBufferBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT")]
        FormatFeature2VertexBufferBit = 64,
        [Obsolete("Deprecated in favour of \"ColorAttachmentBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT")]
        FormatFeature2ColorAttachmentBit = 128,
        [Obsolete("Deprecated in favour of \"ColorAttachmentBlendBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT")]
        FormatFeature2ColorAttachmentBlendBit = 256,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT")]
        FormatFeature2DepthStencilAttachmentBit = 512,
        [Obsolete("Deprecated in favour of \"BlitSrcBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_SRC_BIT")]
        FormatFeature2BlitSrcBit = 1024,
        [Obsolete("Deprecated in favour of \"BlitDstBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_DST_BIT")]
        FormatFeature2BlitDstBit = 2048,
        [Obsolete("Deprecated in favour of \"SampledImageFilterLinearBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT")]
        FormatFeature2SampledImageFilterLinearBit = 4096,
        [Obsolete("Deprecated in favour of \"TransferSrcBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT")]
        FormatFeature2TransferSrcBit = 16384,
        [Obsolete("Deprecated in favour of \"TransferDstBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT")]
        FormatFeature2TransferDstBit = 32768,
        [Obsolete("Deprecated in favour of \"SampledImageFilterMinmaxBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT")]
        FormatFeature2SampledImageFilterMinmaxBit = 65536,
        [Obsolete("Deprecated in favour of \"MidpointChromaSamplesBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT")]
        FormatFeature2MidpointChromaSamplesBit = 131072,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionLinearFilterBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT")]
        FormatFeature2SampledImageYcbcrConversionLinearFilterBit = 262144,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionSeparateReconstructionFilterBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT")]
        FormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionChromaReconstructionExplicitBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT")]
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        [Obsolete("Deprecated in favour of \"SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT")]
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        [Obsolete("Deprecated in favour of \"DisjointBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DISJOINT_BIT")]
        FormatFeature2DisjointBit = 4194304,
        [Obsolete("Deprecated in favour of \"CositedChromaSamplesBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT")]
        FormatFeature2CositedChromaSamplesBit = 8388608,
        [Obsolete("Deprecated in favour of \"StorageReadWithoutFormatBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT")]
        FormatFeature2StorageReadWithoutFormatBit = 2147483648,
        [Obsolete("Deprecated in favour of \"StorageWriteWithoutFormatBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT")]
        FormatFeature2StorageWriteWithoutFormatBit = 4294967296,
        [Obsolete("Deprecated in favour of \"SampledImageDepthComparisonBit\"")]
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT")]
        FormatFeature2SampledImageDepthComparisonBit = 8589934592,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT")]
        SampledImageBit = 1,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT")]
        StorageImageBit = 2,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT")]
        StorageImageAtomicBit = 4,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT")]
        UniformTexelBufferBit = 8,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT")]
        StorageTexelBufferBit = 16,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT")]
        StorageTexelBufferAtomicBit = 32,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT")]
        VertexBufferBit = 64,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT")]
        ColorAttachmentBit = 128,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT")]
        ColorAttachmentBlendBit = 256,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT")]
        DepthStencilAttachmentBit = 512,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_SRC_BIT")]
        BlitSrcBit = 1024,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_DST_BIT")]
        BlitDstBit = 2048,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT")]
        SampledImageFilterLinearBit = 4096,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT")]
        TransferSrcBit = 16384,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT")]
        TransferDstBit = 32768,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT")]
        SampledImageFilterMinmaxBit = 65536,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT")]
        MidpointChromaSamplesBit = 131072,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT")]
        SampledImageYcbcrConversionLinearFilterBit = 262144,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT")]
        SampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT")]
        SampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT")]
        SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DISJOINT_BIT")]
        DisjointBit = 4194304,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT")]
        CositedChromaSamplesBit = 8388608,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT")]
        StorageReadWithoutFormatBit = 2147483648,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT")]
        StorageWriteWithoutFormatBit = 4294967296,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT")]
        SampledImageDepthComparisonBit = 8589934592,
    }
}
