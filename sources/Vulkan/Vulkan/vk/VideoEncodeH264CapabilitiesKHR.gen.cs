// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH264CapabilitiesKHR")]
public unsafe partial struct VideoEncodeH264CapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH264CapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public VideoEncodeH264CapabilityFlagsKHR Flags;

    [NativeName("maxLevelIdc")]
    public StdVideoH264LevelIdc MaxLevelIdc;

    [NativeName("maxSliceCount")]
    public uint MaxSliceCount;

    [NativeName("maxPPictureL0ReferenceCount")]
    public uint MaxPPictureL0ReferenceCount;

    [NativeName("maxBPictureL0ReferenceCount")]
    public uint MaxBPictureL0ReferenceCount;

    [NativeName("maxL1ReferenceCount")]
    public uint MaxL1ReferenceCount;

    [NativeName("maxTemporalLayerCount")]
    public uint MaxTemporalLayerCount;

    [NativeName("expectDyadicTemporalLayerPattern")]
    public MaybeBool<uint> ExpectDyadicTemporalLayerPattern;

    [NativeName("minQp")]
    public int MinQp;

    [NativeName("maxQp")]
    public int MaxQp;

    [NativeName("prefersGopRemainingFrames")]
    public MaybeBool<uint> PrefersGopRemainingFrames;

    [NativeName("requiresGopRemainingFrames")]
    public MaybeBool<uint> RequiresGopRemainingFrames;

    [NativeName("stdSyntaxFlags")]
    public VideoEncodeH264StdFlagsKHR StdSyntaxFlags;

    public VideoEncodeH264CapabilitiesKHR() { }
}
