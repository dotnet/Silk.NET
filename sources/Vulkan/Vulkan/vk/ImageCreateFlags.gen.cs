// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageCreateFlags")]
[Flags]
public enum ImageCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_IMAGE_CREATE_SPARSE_BINDING_BIT")]
    CreateSparseBindingBit = 0x1,

    [NativeName("VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT")]
    CreateSparseResidencyBit = 0x2,

    [NativeName("VK_IMAGE_CREATE_SPARSE_ALIASED_BIT")]
    CreateSparseAliasedBit = 0x4,

    [NativeName("VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT")]
    CreateMutableFormatBit = 0x8,

    [NativeName("VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT")]
    CreateCubeCompatibleBit = 0x10,

    [NativeName("VK_IMAGE_CREATE_ALIAS_BIT")]
    CreateAliasBit = 0x400,

    [NativeName("VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT")]
    CreateSplitInstanceBindRegionsBit = 0x40,

    [NativeName("VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT")]
    Create2DArrayCompatibleBit = 0x20,

    [NativeName("VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT")]
    CreateBlockTexelViewCompatibleBit = 0x80,

    [NativeName("VK_IMAGE_CREATE_EXTENDED_USAGE_BIT")]
    CreateExtendedUsageBit = 0x100,

    [NativeName("VK_IMAGE_CREATE_PROTECTED_BIT")]
    CreateProtectedBit = 0x800,

    [NativeName("VK_IMAGE_CREATE_DISJOINT_BIT")]
    CreateDisjointBit = 0x200,

    [NativeName("VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV")]
    CreateCornerSampledBitNV = 0x2000,

    [NativeName("VK_IMAGE_CREATE_DESCRIPTOR_HEAP_CAPTURE_REPLAY_BIT_EXT")]
    CreateDescriptorHeapCaptureReplayBitEXT = 0x10000,

    [NativeName("VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT")]
    CreateSampleLocationsCompatibleDepthBitEXT = 0x1000,

    [NativeName("VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT")]
    CreateSubsampledBitEXT = 0x4000,

    [NativeName("VK_IMAGE_CREATE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXT")]
    CreateMultisampledRenderToSingleSampledBitEXT = 0x40000,

    [NativeName("VK_IMAGE_CREATE_2D_VIEW_COMPATIBLE_BIT_EXT")]
    Create2DViewCompatibleBitEXT = 0x20000,

    [NativeName("VK_IMAGE_CREATE_VIDEO_PROFILE_INDEPENDENT_BIT_KHR")]
    CreateVideoProfileIndependentBitKHR = 0x100000,

    [NativeName("VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_EXT")]
    CreateFragmentDensityMapOffsetBitEXT = 0x8000,

    [NativeName("VK_IMAGE_CREATE_ALIAS_SINGLE_LAYER_DESCRIPTOR_BIT_KHR")]
    CreateAliasSingleLayerDescriptorBitKHR = 0x400000,

    [NativeName("VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
    CreateSplitInstanceBindRegionsBitKHR = CreateSplitInstanceBindRegionsBit,

    [NativeName("VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT_KHR")]
    Create2DArrayCompatibleBitKHR = Create2DArrayCompatibleBit,

    [NativeName("VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR")]
    CreateBlockTexelViewCompatibleBitKHR = CreateBlockTexelViewCompatibleBit,

    [NativeName("VK_IMAGE_CREATE_EXTENDED_USAGE_BIT_KHR")]
    CreateExtendedUsageBitKHR = CreateExtendedUsageBit,

    [NativeName("VK_IMAGE_CREATE_DISJOINT_BIT_KHR")]
    CreateDisjointBitKHR = CreateDisjointBit,

    [NativeName("VK_IMAGE_CREATE_ALIAS_BIT_KHR")]
    CreateAliasBitKHR = CreateAliasBit,

    [NativeName("VK_IMAGE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
    CreateDescriptorBufferCaptureReplayBitEXT = CreateDescriptorHeapCaptureReplayBitEXT,

    [NativeName("VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_QCOM")]
    CreateFragmentDensityMapOffsetBitQCOM = CreateFragmentDensityMapOffsetBitEXT,
}
