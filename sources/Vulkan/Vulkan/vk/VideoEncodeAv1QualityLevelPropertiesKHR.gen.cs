// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeAV1QualityLevelPropertiesKHR")]
public unsafe partial struct VideoEncodeAv1QualityLevelPropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeAv1QualityLevelPropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("preferredRateControlFlags")]
    public VideoEncodeAv1RateControlFlagsKHR PreferredRateControlFlags;

    [NativeName("preferredGopFrameCount")]
    public uint PreferredGopFrameCount;

    [NativeName("preferredKeyFramePeriod")]
    public uint PreferredKeyFramePeriod;

    [NativeName("preferredConsecutiveBipredictiveFrameCount")]
    public uint PreferredConsecutiveBipredictiveFrameCount;

    [NativeName("preferredTemporalLayerCount")]
    public uint PreferredTemporalLayerCount;

    [NativeName("preferredConstantQIndex")]
    public VideoEncodeAv1QIndexKHR PreferredConstantQIndex;

    [NativeName("preferredMaxSingleReferenceCount")]
    public uint PreferredMaxSingleReferenceCount;

    [NativeName("preferredSingleReferenceNameMask")]
    public uint PreferredSingleReferenceNameMask;

    [NativeName("preferredMaxUnidirectionalCompoundReferenceCount")]
    public uint PreferredMaxUnidirectionalCompoundReferenceCount;

    [NativeName("preferredMaxUnidirectionalCompoundGroup1ReferenceCount")]
    public uint PreferredMaxUnidirectionalCompoundGroup1ReferenceCount;

    [NativeName("preferredUnidirectionalCompoundReferenceNameMask")]
    public uint PreferredUnidirectionalCompoundReferenceNameMask;

    [NativeName("preferredMaxBidirectionalCompoundReferenceCount")]
    public uint PreferredMaxBidirectionalCompoundReferenceCount;

    [NativeName("preferredMaxBidirectionalCompoundGroup1ReferenceCount")]
    public uint PreferredMaxBidirectionalCompoundGroup1ReferenceCount;

    [NativeName("preferredMaxBidirectionalCompoundGroup2ReferenceCount")]
    public uint PreferredMaxBidirectionalCompoundGroup2ReferenceCount;

    [NativeName("preferredBidirectionalCompoundReferenceNameMask")]
    public uint PreferredBidirectionalCompoundReferenceNameMask;

    public VideoEncodeAv1QualityLevelPropertiesKHR() { }
}
