// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH264RateControlInfoKHR")]
public unsafe partial struct VideoEncodeH264RateControlInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH264RateControlInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public VideoEncodeH264RateControlFlagsKHR Flags;

    [NativeName("gopFrameCount")]
    public uint GopFrameCount;

    [NativeName("idrPeriod")]
    public uint IdrPeriod;

    [NativeName("consecutiveBFrameCount")]
    public uint ConsecutiveBFrameCount;

    [NativeName("temporalLayerCount")]
    public uint TemporalLayerCount;

    public VideoEncodeH264RateControlInfoKHR() { }
}
