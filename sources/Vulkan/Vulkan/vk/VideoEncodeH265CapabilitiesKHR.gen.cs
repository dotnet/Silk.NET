// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265CapabilitiesKHR")]
public unsafe partial struct VideoEncodeH265CapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH265CapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public VideoEncodeH265CapabilityFlagsKHR Flags;

    [NativeName("maxLevelIdc")]
    public StdVideoH265LevelIdc MaxLevelIdc;

    [NativeName("maxSliceSegmentCount")]
    public uint MaxSliceSegmentCount;

    [NativeName("maxTiles")]
    public Extent2D MaxTiles;

    [NativeName("ctbSizes")]
    public VideoEncodeH265CtbSizeFlagsKHR CtbSizes;

    [NativeName("transformBlockSizes")]
    public VideoEncodeH265TransformBlockSizeFlagsKHR TransformBlockSizes;

    [NativeName("maxPPictureL0ReferenceCount")]
    public uint MaxPPictureL0ReferenceCount;

    [NativeName("maxBPictureL0ReferenceCount")]
    public uint MaxBPictureL0ReferenceCount;

    [NativeName("maxL1ReferenceCount")]
    public uint MaxL1ReferenceCount;

    [NativeName("maxSubLayerCount")]
    public uint MaxSubLayerCount;

    [NativeName("expectDyadicTemporalSubLayerPattern")]
    public MaybeBool<uint> ExpectDyadicTemporalSubLayerPattern;

    [NativeName("minQp")]
    public int MinQp;

    [NativeName("maxQp")]
    public int MaxQp;

    [NativeName("prefersGopRemainingFrames")]
    public MaybeBool<uint> PrefersGopRemainingFrames;

    [NativeName("requiresGopRemainingFrames")]
    public MaybeBool<uint> RequiresGopRemainingFrames;

    [NativeName("stdSyntaxFlags")]
    public VideoEncodeH265StdFlagsKHR StdSyntaxFlags;

    public VideoEncodeH265CapabilitiesKHR() { }
}
