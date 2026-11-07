// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGetLatencyMarkerInfoNV")]
public unsafe partial struct GetLatencyMarkerInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.GetLatencyMarkerInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("timingCount")]
    public uint TimingCount;

    [NativeName("pTimings")]
    public LatencyTimingsFrameReportNV* PTimings;

    public GetLatencyMarkerInfoNV() { }
}
