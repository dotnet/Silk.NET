// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkImageCreateFlags")]
    public enum ImageCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"CreateSparseBindingBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_SPARSE_BINDING_BIT")]
        ImageCreateSparseBindingBit = 1,
        [Obsolete("Deprecated in favour of \"CreateSparseResidencyBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT")]
        ImageCreateSparseResidencyBit = 2,
        [Obsolete("Deprecated in favour of \"CreateSparseAliasedBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_SPARSE_ALIASED_BIT")]
        ImageCreateSparseAliasedBit = 4,
        [Obsolete("Deprecated in favour of \"CreateMutableFormatBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT")]
        ImageCreateMutableFormatBit = 8,
        [Obsolete("Deprecated in favour of \"CreateCubeCompatibleBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT")]
        ImageCreateCubeCompatibleBit = 16,
        [Obsolete("Deprecated in favour of \"CreateCornerSampledBitNV\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV")]
        ImageCreateCornerSampledBitNV = 8192,
        [Obsolete("Deprecated in favour of \"CreateSplitInstanceBindRegionsBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
        ImageCreateSplitInstanceBindRegionsBitKhr = 64,
        [Obsolete("Deprecated in favour of \"Create2DArrayCompatibleBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT_KHR")]
        ImageCreate2DArrayCompatibleBitKhr = 32,
        [Obsolete("Deprecated in favour of \"CreateBlockTexelViewCompatibleBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR")]
        ImageCreateBlockTexelViewCompatibleBitKhr = 128,
        [Obsolete("Deprecated in favour of \"CreateExtendedUsageBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_EXTENDED_USAGE_BIT_KHR")]
        ImageCreateExtendedUsageBitKhr = 256,
        [Obsolete("Deprecated in favour of \"CreateSampleLocationsCompatibleDepthBitExt\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT")]
        ImageCreateSampleLocationsCompatibleDepthBitExt = 4096,
        [Obsolete("Deprecated in favour of \"CreateDisjointBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_DISJOINT_BIT_KHR")]
        ImageCreateDisjointBitKhr = 512,
        [Obsolete("Deprecated in favour of \"CreateAliasBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_ALIAS_BIT_KHR")]
        ImageCreateAliasBitKhr = 1024,
        [Obsolete("Deprecated in favour of \"CreateSubsampledBitExt\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT")]
        ImageCreateSubsampledBitExt = 16384,
        [Obsolete("Deprecated in favour of \"CreateDescriptorBufferCaptureReplayBitExt\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
        ImageCreateDescriptorBufferCaptureReplayBitExt = 65536,
        [Obsolete("Deprecated in favour of \"CreateMultisampledRenderToSingleSampledBitExt\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXT")]
        ImageCreateMultisampledRenderToSingleSampledBitExt = 262144,
        [Obsolete("Deprecated in favour of \"Create2DViewCompatibleBitExt\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_2D_VIEW_COMPATIBLE_BIT_EXT")]
        ImageCreate2DViewCompatibleBitExt = 131072,
        [Obsolete("Deprecated in favour of \"CreateFragmentDensityMapOffsetBitQCom\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_QCOM")]
        ImageCreateFragmentDensityMapOffsetBitQCom = 32768,
        [Obsolete("Deprecated in favour of \"CreateVideoProfileIndependentBitKhr\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_VIDEO_PROFILE_INDEPENDENT_BIT_KHR")]
        ImageCreateVideoProfileIndependentBitKhr = 1048576,
        [Obsolete("Deprecated in favour of \"CreateAliasBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_ALIAS_BIT")]
        ImageCreateAliasBit = 1024,
        [Obsolete("Deprecated in favour of \"CreateSplitInstanceBindRegionsBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT")]
        ImageCreateSplitInstanceBindRegionsBit = 64,
        [Obsolete("Deprecated in favour of \"Create2DArrayCompatibleBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT")]
        ImageCreate2DArrayCompatibleBit = 32,
        [Obsolete("Deprecated in favour of \"CreateBlockTexelViewCompatibleBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT")]
        ImageCreateBlockTexelViewCompatibleBit = 128,
        [Obsolete("Deprecated in favour of \"CreateExtendedUsageBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_EXTENDED_USAGE_BIT")]
        ImageCreateExtendedUsageBit = 256,
        [Obsolete("Deprecated in favour of \"CreateProtectedBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_PROTECTED_BIT")]
        ImageCreateProtectedBit = 2048,
        [Obsolete("Deprecated in favour of \"CreateDisjointBit\"")]
        [NativeName("Name", "VK_IMAGE_CREATE_DISJOINT_BIT")]
        ImageCreateDisjointBit = 512,
        [NativeName("Name", "VK_IMAGE_CREATE_SPARSE_BINDING_BIT")]
        CreateSparseBindingBit = 1,
        [NativeName("Name", "VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT")]
        CreateSparseResidencyBit = 2,
        [NativeName("Name", "VK_IMAGE_CREATE_SPARSE_ALIASED_BIT")]
        CreateSparseAliasedBit = 4,
        [NativeName("Name", "VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT")]
        CreateMutableFormatBit = 8,
        [NativeName("Name", "VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT")]
        CreateCubeCompatibleBit = 16,
        [NativeName("Name", "VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV")]
        CreateCornerSampledBitNV = 8192,
        [NativeName("Name", "VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
        CreateSplitInstanceBindRegionsBitKhr = 64,
        [NativeName("Name", "VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT_KHR")]
        Create2DArrayCompatibleBitKhr = 32,
        [NativeName("Name", "VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR")]
        CreateBlockTexelViewCompatibleBitKhr = 128,
        [NativeName("Name", "VK_IMAGE_CREATE_EXTENDED_USAGE_BIT_KHR")]
        CreateExtendedUsageBitKhr = 256,
        [NativeName("Name", "VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT")]
        CreateSampleLocationsCompatibleDepthBitExt = 4096,
        [NativeName("Name", "VK_IMAGE_CREATE_DISJOINT_BIT_KHR")]
        CreateDisjointBitKhr = 512,
        [NativeName("Name", "VK_IMAGE_CREATE_ALIAS_BIT_KHR")]
        CreateAliasBitKhr = 1024,
        [NativeName("Name", "VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT")]
        CreateSubsampledBitExt = 16384,
        [NativeName("Name", "VK_IMAGE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
        CreateDescriptorBufferCaptureReplayBitExt = 65536,
        [NativeName("Name", "VK_IMAGE_CREATE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXT")]
        CreateMultisampledRenderToSingleSampledBitExt = 262144,
        [NativeName("Name", "VK_IMAGE_CREATE_2D_VIEW_COMPATIBLE_BIT_EXT")]
        Create2DViewCompatibleBitExt = 131072,
        [NativeName("Name", "VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_QCOM")]
        CreateFragmentDensityMapOffsetBitQCom = 32768,
        [NativeName("Name", "VK_IMAGE_CREATE_VIDEO_PROFILE_INDEPENDENT_BIT_KHR")]
        CreateVideoProfileIndependentBitKhr = 1048576,
        [NativeName("Name", "VK_IMAGE_CREATE_ALIAS_BIT")]
        CreateAliasBit = 1024,
        [NativeName("Name", "VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT")]
        CreateSplitInstanceBindRegionsBit = 64,
        [NativeName("Name", "VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT")]
        Create2DArrayCompatibleBit = 32,
        [NativeName("Name", "VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT")]
        CreateBlockTexelViewCompatibleBit = 128,
        [NativeName("Name", "VK_IMAGE_CREATE_EXTENDED_USAGE_BIT")]
        CreateExtendedUsageBit = 256,
        [NativeName("Name", "VK_IMAGE_CREATE_PROTECTED_BIT")]
        CreateProtectedBit = 2048,
        [NativeName("Name", "VK_IMAGE_CREATE_DISJOINT_BIT")]
        CreateDisjointBit = 512,
    }
}
