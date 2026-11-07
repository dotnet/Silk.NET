// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeAV1RateControlInfoKHR")]
public unsafe partial struct VideoEncodeAv1RateControlInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeAv1RateControlInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public VideoEncodeAv1RateControlFlagsKHR Flags;

    [NativeName("gopFrameCount")]
    public uint GopFrameCount;

    [NativeName("keyFramePeriod")]
    public uint KeyFramePeriod;

    [NativeName("consecutiveBipredictiveFrameCount")]
    public uint ConsecutiveBipredictiveFrameCount;

    [NativeName("temporalLayerCount")]
    public uint TemporalLayerCount;

    public VideoEncodeAv1RateControlInfoKHR() { }
}
