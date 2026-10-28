// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH264QualityLevelPropertiesKHR")]
public unsafe partial struct VideoEncodeH264QualityLevelPropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH264QualityLevelPropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("preferredRateControlFlags")]
    public VideoEncodeH264RateControlFlagsKHR PreferredRateControlFlags;

    [NativeName("preferredGopFrameCount")]
    public uint PreferredGopFrameCount;

    [NativeName("preferredIdrPeriod")]
    public uint PreferredIdrPeriod;

    [NativeName("preferredConsecutiveBFrameCount")]
    public uint PreferredConsecutiveBFrameCount;

    [NativeName("preferredTemporalLayerCount")]
    public uint PreferredTemporalLayerCount;

    [NativeName("preferredConstantQp")]
    public VideoEncodeH264QpKHR PreferredConstantQp;

    [NativeName("preferredMaxL0ReferenceCount")]
    public uint PreferredMaxL0ReferenceCount;

    [NativeName("preferredMaxL1ReferenceCount")]
    public uint PreferredMaxL1ReferenceCount;

    [NativeName("preferredStdEntropyCodingModeFlag")]
    public MaybeBool<uint> PreferredStdEntropyCodingModeFlag;

    public VideoEncodeH264QualityLevelPropertiesKHR() { }
}
