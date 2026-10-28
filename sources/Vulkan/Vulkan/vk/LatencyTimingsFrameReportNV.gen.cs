// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLatencyTimingsFrameReportNV")]
public unsafe partial struct LatencyTimingsFrameReportNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.LatencyTimingsFrameReportNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("presentID")]
    public ulong PresentID;

    [NativeName("inputSampleTimeUs")]
    public ulong InputSampleTimeUs;

    [NativeName("simStartTimeUs")]
    public ulong SimStartTimeUs;

    [NativeName("simEndTimeUs")]
    public ulong SimEndTimeUs;

    [NativeName("renderSubmitStartTimeUs")]
    public ulong RenderSubmitStartTimeUs;

    [NativeName("renderSubmitEndTimeUs")]
    public ulong RenderSubmitEndTimeUs;

    [NativeName("presentStartTimeUs")]
    public ulong PresentStartTimeUs;

    [NativeName("presentEndTimeUs")]
    public ulong PresentEndTimeUs;

    [NativeName("driverStartTimeUs")]
    public ulong DriverStartTimeUs;

    [NativeName("driverEndTimeUs")]
    public ulong DriverEndTimeUs;

    [NativeName("osRenderQueueStartTimeUs")]
    public ulong OsRenderQueueStartTimeUs;

    [NativeName("osRenderQueueEndTimeUs")]
    public ulong OsRenderQueueEndTimeUs;

    [NativeName("gpuRenderStartTimeUs")]
    public ulong GpuRenderStartTimeUs;

    [NativeName("gpuRenderEndTimeUs")]
    public ulong GpuRenderEndTimeUs;

    public LatencyTimingsFrameReportNV() { }
}
