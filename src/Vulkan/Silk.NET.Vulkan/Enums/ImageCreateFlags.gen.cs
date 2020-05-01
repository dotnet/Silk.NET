// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ImageCreateFlags
    {
        ImageCreateSparseBindingBit = 1,
        ImageCreateSparseResidencyBit = 2,
        ImageCreateSparseAliasedBit = 4,
        ImageCreateMutableFormatBit = 8,
        ImageCreateCubeCompatibleBit = 16,
        ImageCreateCornerSampledBitNV = 8192,
        ImageCreateSplitInstanceBindRegionsBitKhr = 64,
        ImageCreate2DArrayCompatibleBitKhr = 32,
        ImageCreateBlockTexelViewCompatibleBitKhr = 128,
        ImageCreateExtendedUsageBitKhr = 256,
        ImageCreateSampleLocationsCompatibleDepthBitExt = 4096,
        ImageCreateDisjointBitKhr = 512,
        ImageCreateAliasBitKhr = 1024,
        ImageCreateSubsampledBitExt = 16384,
        ImageCreateAliasBit = 1024,
        ImageCreateSplitInstanceBindRegionsBit = 64,
        ImageCreate2DArrayCompatibleBit = 32,
        ImageCreateBlockTexelViewCompatibleBit = 128,
        ImageCreateExtendedUsageBit = 256,
        ImageCreateProtectedBit = 2048,
        ImageCreateDisjointBit = 512,
    }
}
