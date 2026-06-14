// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageCreateFlags2KHR")]
[Flags]
public enum ImageCreateFlags2KHR : ulong
{
    None = 0x0,

    [NativeName("VK_IMAGE_CREATE_2_SPARSE_BINDING_BIT_KHR")]
    SparseBindingBit = 0x1,

    [NativeName("VK_IMAGE_CREATE_2_SPARSE_RESIDENCY_BIT_KHR")]
    SparseResidencyBit = 0x2,

    [NativeName("VK_IMAGE_CREATE_2_SPARSE_ALIASED_BIT_KHR")]
    SparseAliasedBit = 0x4,

    [NativeName("VK_IMAGE_CREATE_2_MUTABLE_FORMAT_BIT_KHR")]
    MutableFormatBit = 0x8,

    [NativeName("VK_IMAGE_CREATE_2_CUBE_COMPATIBLE_BIT_KHR")]
    CubeCompatibleBit = 0x10,

    [NativeName("VK_IMAGE_CREATE_2_ALIAS_SINGLE_LAYER_DESCRIPTOR_BIT_KHR")]
    AliasSingleLayerDescriptorBit = 0x400000,

    [NativeName("VK_IMAGE_CREATE_2_2D_ARRAY_COMPATIBLE_BIT_KHR")]
    X2DArrayCompatibleBit = 0x20,

    [NativeName("VK_IMAGE_CREATE_2_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
    SplitInstanceBindRegionsBit = 0x40,

    [NativeName("VK_IMAGE_CREATE_2_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR")]
    BlockTexelViewCompatibleBit = 0x80,

    [NativeName("VK_IMAGE_CREATE_2_EXTENDED_USAGE_BIT_KHR")]
    ExtendedUsageBit = 0x100,

    [NativeName("VK_IMAGE_CREATE_2_DISJOINT_BIT_KHR")]
    DisjointBit = 0x200,

    [NativeName("VK_IMAGE_CREATE_2_ALIAS_BIT_KHR")]
    AliasBit = 0x400,

    [NativeName("VK_IMAGE_CREATE_2_PROTECTED_BIT_KHR")]
    ProtectedBit = 0x800,

    [NativeName("VK_IMAGE_CREATE_2_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT")]
    SampleLocationsCompatibleDepthBitEXT = 0x1000,

    [NativeName("VK_IMAGE_CREATE_2_CORNER_SAMPLED_BIT_NV")]
    CornerSampledBitNV = 0x2000,

    [NativeName("VK_IMAGE_CREATE_2_SUBSAMPLED_BIT_EXT")]
    SubsampledBitEXT = 0x4000,

    [NativeName("VK_IMAGE_CREATE_2_FRAGMENT_DENSITY_MAP_OFFSET_BIT_EXT")]
    FragmentDensityMapOffsetBitEXT = 0x8000,

    [NativeName("VK_IMAGE_CREATE_2_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
    DescriptorBufferCaptureReplayBitEXT = 0x10000,

    [NativeName("VK_IMAGE_CREATE_2_2D_VIEW_COMPATIBLE_BIT_EXT")]
    X2DViewCompatibleBitEXT = 0x20000,

    [NativeName("VK_IMAGE_CREATE_2_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXT")]
    MultisampledRenderToSingleSampledBitEXT = 0x40000,

    [NativeName("VK_IMAGE_CREATE_2_VIDEO_PROFILE_INDEPENDENT_BIT_KHR")]
    VideoProfileIndependentBit = 0x100000,
}
