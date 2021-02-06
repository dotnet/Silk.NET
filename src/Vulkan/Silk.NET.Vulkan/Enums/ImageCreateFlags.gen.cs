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
    [NativeName("Name", "VkImageCreateFlags")]
    public enum ImageCreateFlags : int
    {
        [NativeName("Name", "VK_IMAGE_CREATE_SPARSE_BINDING_BIT")]
        ImageCreateSparseBindingBit = 1,
        [NativeName("Name", "VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT")]
        ImageCreateSparseResidencyBit = 2,
        [NativeName("Name", "VK_IMAGE_CREATE_SPARSE_ALIASED_BIT")]
        ImageCreateSparseAliasedBit = 4,
        [NativeName("Name", "VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT")]
        ImageCreateMutableFormatBit = 8,
        [NativeName("Name", "VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT")]
        ImageCreateCubeCompatibleBit = 16,
        [NativeName("Name", "VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV")]
        ImageCreateCornerSampledBitNV = 8192,
        [NativeName("Name", "VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
        ImageCreateSplitInstanceBindRegionsBitKhr = 64,
        [NativeName("Name", "VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT_KHR")]
        ImageCreate2DArrayCompatibleBitKhr = 32,
        [NativeName("Name", "VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR")]
        ImageCreateBlockTexelViewCompatibleBitKhr = 128,
        [NativeName("Name", "VK_IMAGE_CREATE_EXTENDED_USAGE_BIT_KHR")]
        ImageCreateExtendedUsageBitKhr = 256,
        [NativeName("Name", "VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT")]
        ImageCreateSampleLocationsCompatibleDepthBitExt = 4096,
        [NativeName("Name", "VK_IMAGE_CREATE_DISJOINT_BIT_KHR")]
        ImageCreateDisjointBitKhr = 512,
        [NativeName("Name", "VK_IMAGE_CREATE_ALIAS_BIT_KHR")]
        ImageCreateAliasBitKhr = 1024,
        [NativeName("Name", "VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT")]
        ImageCreateSubsampledBitExt = 16384,
        [NativeName("Name", "VK_IMAGE_CREATE_RESERVED_15_BIT_NV")]
        ImageCreateReserved15BitNV = 32768,
        [NativeName("Name", "VK_IMAGE_CREATE_ALIAS_BIT")]
        ImageCreateAliasBit = 1024,
        [NativeName("Name", "VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT")]
        ImageCreateSplitInstanceBindRegionsBit = 64,
        [NativeName("Name", "VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT")]
        ImageCreate2DArrayCompatibleBit = 32,
        [NativeName("Name", "VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT")]
        ImageCreateBlockTexelViewCompatibleBit = 128,
        [NativeName("Name", "VK_IMAGE_CREATE_EXTENDED_USAGE_BIT")]
        ImageCreateExtendedUsageBit = 256,
        [NativeName("Name", "VK_IMAGE_CREATE_PROTECTED_BIT")]
        ImageCreateProtectedBit = 2048,
        [NativeName("Name", "VK_IMAGE_CREATE_DISJOINT_BIT")]
        ImageCreateDisjointBit = 512,
    }
}
