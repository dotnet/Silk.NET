// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum FormatFeatureFlags
    {
        FormatFeatureSampledImageBit = 1,
        FormatFeatureStorageImageBit = 2,
        FormatFeatureStorageImageAtomicBit = 4,
        FormatFeatureUniformTexelBufferBit = 8,
        FormatFeatureStorageTexelBufferBit = 16,
        FormatFeatureStorageTexelBufferAtomicBit = 32,
        FormatFeatureVertexBufferBit = 64,
        FormatFeatureColorAttachmentBit = 128,
        FormatFeatureColorAttachmentBlendBit = 256,
        FormatFeatureDepthStencilAttachmentBit = 512,
        FormatFeatureBlitSrcBit = 1024,
        FormatFeatureBlitDstBit = 2048,
        FormatFeatureSampledImageFilterLinearBit = 4096,
        FormatFeatureSampledImageFilterCubicBitImg = 8192,
        FormatFeatureReserved27BitKhr = 134217728,
        FormatFeatureReserved28BitKhr = 268435456,
        FormatFeatureReserved25BitKhr = 33554432,
        FormatFeatureReserved26BitKhr = 67108864,
        FormatFeatureTransferSrcBitKhr = 16384,
        FormatFeatureTransferDstBitKhr = 32768,
        FormatFeatureSampledImageFilterMinmaxBitExt = 65536,
        FormatFeatureAccelerationStructureVertexBufferBitKhr = 536870912,
        FormatFeatureMidpointChromaSamplesBitKhr = 131072,
        FormatFeatureSampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        FormatFeatureDisjointBitKhr = 4194304,
        FormatFeatureCositedChromaSamplesBitKhr = 8388608,
        FormatFeatureSampledImageFilterCubicBitExt = 8192,
        FormatFeatureFragmentDensityMapBitExt = 16777216,
        FormatFeatureAmdReserved30Bit = 1073741824,
        FormatFeatureTransferSrcBit = 16384,
        FormatFeatureTransferDstBit = 32768,
        FormatFeatureMidpointChromaSamplesBit = 131072,
        FormatFeatureSampledImageYcbcrConversionLinearFilterBit = 262144,
        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        FormatFeatureDisjointBit = 4194304,
        FormatFeatureCositedChromaSamplesBit = 8388608,
        FormatFeatureSampledImageFilterMinmaxBit = 65536,
    }
}
