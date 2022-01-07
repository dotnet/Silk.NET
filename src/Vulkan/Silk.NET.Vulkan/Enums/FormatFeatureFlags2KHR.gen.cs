// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkFormatFeatureFlags2KHR")]
    public enum FormatFeatureFlags2KHR : long
    {
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT_KHR")]
        FormatFeature2SampledImageBitKhr = 1,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT_KHR")]
        FormatFeature2StorageImageBitKhr = 2,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT_KHR")]
        FormatFeature2StorageImageAtomicBitKhr = 4,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR")]
        FormatFeature2UniformTexelBufferBitKhr = 8,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT_KHR")]
        FormatFeature2StorageTexelBufferBitKhr = 16,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT_KHR")]
        FormatFeature2StorageTexelBufferAtomicBitKhr = 32,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT_KHR")]
        FormatFeature2VertexBufferBitKhr = 64,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT_KHR")]
        FormatFeature2ColorAttachmentBitKhr = 128,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT_KHR")]
        FormatFeature2ColorAttachmentBlendBitKhr = 256,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR")]
        FormatFeature2DepthStencilAttachmentBitKhr = 512,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_SRC_BIT_KHR")]
        FormatFeature2BlitSrcBitKhr = 1024,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_BLIT_DST_BIT_KHR")]
        FormatFeature2BlitDstBitKhr = 2048,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT_KHR")]
        FormatFeature2SampledImageFilterLinearBitKhr = 4096,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT")]
        FormatFeature2SampledImageFilterCubicBitExt = 8192,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT_KHR")]
        FormatFeature2TransferSrcBitKhr = 16384,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT_KHR")]
        FormatFeature2TransferDstBitKhr = 32768,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT_KHR")]
        FormatFeature2SampledImageFilterMinmaxBitKhr = 65536,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT_KHR")]
        FormatFeature2MidpointChromaSamplesBitKhr = 131072,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR")]
        FormatFeature2SampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR")]
        FormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR")]
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR")]
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_DISJOINT_BIT_KHR")]
        FormatFeature2DisjointBitKhr = 4194304,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT_KHR")]
        FormatFeature2CositedChromaSamplesBitKhr = 8388608,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT_KHR")]
        FormatFeature2StorageReadWithoutFormatBitKhr = 2147483648,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT_KHR")]
        FormatFeature2StorageWriteWithoutFormatBitKhr = 4294967296,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT_KHR")]
        FormatFeature2SampledImageDepthComparisonBitKhr = 8589934592,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR")]
        FormatFeature2VideoDecodeOutputBitKhr = 33554432,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR")]
        FormatFeature2VideoDecodeDpbBitKhr = 67108864,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR")]
        FormatFeature2AccelerationStructureVertexBufferBitKhr = 536870912,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT")]
        FormatFeature2FragmentDensityMapBitExt = 16777216,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        FormatFeature2FragmentShadingRateAttachmentBitKhr = 1073741824,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR")]
        FormatFeature2VideoEncodeInputBitKhr = 134217728,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR")]
        FormatFeature2VideoEncodeDpbBitKhr = 268435456,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV")]
        FormatFeature2LinearColorAttachmentBitNV = 274877906944,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_RESERVED_34_BIT_QCOM")]
        FormatFeature2Reserved34BitQCom = 17179869184,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_RESERVED_35_BIT_QCOM")]
        FormatFeature2Reserved35BitQCom = 34359738368,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_RESERVED_36_BIT_QCOM")]
        FormatFeature2Reserved36BitQCom = 68719476736,
        [NativeName("Name", "VK_FORMAT_FEATURE_2_RESERVED_37_BIT_QCOM")]
        FormatFeature2Reserved37BitQCom = 137438953472,
    }
}
