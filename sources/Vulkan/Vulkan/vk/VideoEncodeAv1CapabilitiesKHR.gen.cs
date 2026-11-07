// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeAV1CapabilitiesKHR")]
public unsafe partial struct VideoEncodeAv1CapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeAv1CapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public VideoEncodeAv1CapabilityFlagsKHR Flags;

    [NativeName("maxLevel")]
    public StdVideoAv1Level MaxLevel;

    [NativeName("codedPictureAlignment")]
    public Extent2D CodedPictureAlignment;

    [NativeName("maxTiles")]
    public Extent2D MaxTiles;

    [NativeName("minTileSize")]
    public Extent2D MinTileSize;

    [NativeName("maxTileSize")]
    public Extent2D MaxTileSize;

    [NativeName("superblockSizes")]
    public VideoEncodeAv1SuperblockSizeFlagsKHR SuperblockSizes;

    [NativeName("maxSingleReferenceCount")]
    public uint MaxSingleReferenceCount;

    [NativeName("singleReferenceNameMask")]
    public uint SingleReferenceNameMask;

    [NativeName("maxUnidirectionalCompoundReferenceCount")]
    public uint MaxUnidirectionalCompoundReferenceCount;

    [NativeName("maxUnidirectionalCompoundGroup1ReferenceCount")]
    public uint MaxUnidirectionalCompoundGroup1ReferenceCount;

    [NativeName("unidirectionalCompoundReferenceNameMask")]
    public uint UnidirectionalCompoundReferenceNameMask;

    [NativeName("maxBidirectionalCompoundReferenceCount")]
    public uint MaxBidirectionalCompoundReferenceCount;

    [NativeName("maxBidirectionalCompoundGroup1ReferenceCount")]
    public uint MaxBidirectionalCompoundGroup1ReferenceCount;

    [NativeName("maxBidirectionalCompoundGroup2ReferenceCount")]
    public uint MaxBidirectionalCompoundGroup2ReferenceCount;

    [NativeName("bidirectionalCompoundReferenceNameMask")]
    public uint BidirectionalCompoundReferenceNameMask;

    [NativeName("maxTemporalLayerCount")]
    public uint MaxTemporalLayerCount;

    [NativeName("maxSpatialLayerCount")]
    public uint MaxSpatialLayerCount;

    [NativeName("maxOperatingPoints")]
    public uint MaxOperatingPoints;

    [NativeName("minQIndex")]
    public uint MinQIndex;

    [NativeName("maxQIndex")]
    public uint MaxQIndex;

    [NativeName("prefersGopRemainingFrames")]
    public MaybeBool<uint> PrefersGopRemainingFrames;

    [NativeName("requiresGopRemainingFrames")]
    public MaybeBool<uint> RequiresGopRemainingFrames;

    [NativeName("stdSyntaxFlags")]
    public VideoEncodeAv1StdFlagsKHR StdSyntaxFlags;

    public VideoEncodeAv1CapabilitiesKHR() { }
}
