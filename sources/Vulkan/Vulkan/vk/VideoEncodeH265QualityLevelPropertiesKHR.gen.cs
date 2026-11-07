// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265QualityLevelPropertiesKHR")]
public unsafe partial struct VideoEncodeH265QualityLevelPropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH265QualityLevelPropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("preferredRateControlFlags")]
    public VideoEncodeH265RateControlFlagsKHR PreferredRateControlFlags;

    [NativeName("preferredGopFrameCount")]
    public uint PreferredGopFrameCount;

    [NativeName("preferredIdrPeriod")]
    public uint PreferredIdrPeriod;

    [NativeName("preferredConsecutiveBFrameCount")]
    public uint PreferredConsecutiveBFrameCount;

    [NativeName("preferredSubLayerCount")]
    public uint PreferredSubLayerCount;

    [NativeName("preferredConstantQp")]
    public VideoEncodeH265QpKHR PreferredConstantQp;

    [NativeName("preferredMaxL0ReferenceCount")]
    public uint PreferredMaxL0ReferenceCount;

    [NativeName("preferredMaxL1ReferenceCount")]
    public uint PreferredMaxL1ReferenceCount;

    public VideoEncodeH265QualityLevelPropertiesKHR() { }
}
